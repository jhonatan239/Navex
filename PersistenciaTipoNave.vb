'Importamos referencia mysql para la conexiona a la BD
Imports MySql.Data.MySqlClient

Imports System.IO

Public Class PersistenciaTipoNave

    Public connectionString As String
    Public connectionString2 As String
    Public SQLConnection As MySqlConnection = New MySqlConnection
    Public SQLConnection2 As MySqlConnection = New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlCommand2 As New MySqlCommand
    Public consulta As String
    Public Lector As MySqlDataReader
    Public Lector2 As MySqlDataReader
    Public Lector3 As MySqlDataReader
    Public rutabd = "localhost", ubd = "root", contraseñabd = "root", bd = "bdnavex", null As String

    Public Sub conectarse()
        connectionString = "Server=" + rutabd + "; User Id=" + ubd + "; Password=" + contraseñabd + "; Database=" + bd + ";CHARSET=utf8;" '  aca se configura la conexion a la bd

    End Sub

    Public Function consultar(ByVal consulta As String) As MySqlDataReader
        SQLConnection.Close()
        conectarse()

        Try

            SQLConnection = New MySqlConnection()
            SQLConnection.ConnectionString = connectionString
            SQLConnection.Open()


            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = consulta

            Return sqlCommand.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error de conexión")
            Return sqlCommand.ExecuteReader()
        End Try

        SQLConnection.Close()
    End Function


    Public Function consultar2(ByVal consulta As String) As MySqlDataReader

        Try
            conectarse()
            'SQLcONECTION.close linea agregada por el fallo de conexion al hacer repetidas veces click en 

            SQLConnection2 = New MySqlConnection()

            SQLConnection2.ConnectionString = connectionString

            SQLConnection2.Open()


            sqlCommand2.Connection = SQLConnection2
            sqlCommand2.CommandText = consulta

            Return sqlCommand2.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error de conexión")
            Return sqlCommand2.ExecuteReader()
        End Try

        SQLConnection.Close()
    End Function


    Public Function ejecutar(ByVal consulta As String) As Boolean
        SQLConnection.Close()
        Try
            conectarse()

            SQLConnection = New MySqlConnection()
            SQLConnection.ConnectionString = connectionString
            SQLConnection.Open()
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = consulta
            sqlCommand.ExecuteReader()
            Return True

        Catch ex As Exception
            'MsgBox("Error de conexión")
            ' MsgBox(ex)
            Return False

        End Try
        SQLConnection.Close()
    End Function

    '------Guardar Tipo Nave-----
    Public Function guardar_tipoNave(ByVal tn As TipoNave) As Boolean
        If ejecutar("INSERT INTO tipoNaves (nombre, id) VALUES('" & tn.nombre & "'," & tn.id & ")") Then
            MsgBox("Nuevo tipo de nave Ingresado.")
            Return True
        Else
            MsgBox("Error al Guardar, puede que existan datos mal asignados.")
        End If
        Return False
    End Function

    '------Actualizar Tipo Nave -----
    Public Sub modificar_tipoNave(tn As TipoNave)
        If ejecutar("update tiponaves set  nombre='" & tn.nombre & "', id='" & tn.id & "' where id='" & tn.id & "'") Then
            MsgBox("Datos de tipo de nave Actualizados.")
        Else
            MsgBox("Error al actualizar, puede que existan datos mal asignados.")
        End If
    End Sub


    Public Function existeIdXtabla(ByVal id As Integer, tabla As String)
        'Trae los Socios por id
        Lector = consultar("select * from " & tabla & " Where id='" & id & "'")
        'Dim c As New Cooperativa
        'Dim listac As New ArrayList
        If Lector.Read() Then
            Return True
        Else
            Return False
        End If
    End Function

    'buscamos el ultimo id y deveolvemos uno nuevo para que el usario sepa que  id tendra
    Public Function ultimoId(table As String)
        Dim id As Integer
        Try

            Dim s As String
            s = "SELECT * FROM " & table
            Dim command2 = New MySqlCommand(s)
            Dim cadena As String = "server=localhost;database=bdnavex;user id=root;password=root;port=3306;"
            Dim conn As New MySqlConnection(cadena)

            command2.Connection = conn
            conn.Open()
            Dim reader As MySqlDataReader = command2.ExecuteReader()
            While reader.Read()
                id = reader("id")
            End While

        Catch ex As Exception
            MsgBox("Error en ultimoid")
        End Try

        Return id
    End Function


    'Tipo de nave por ID

    Public Function tipoNaveXid(id As Integer) As TipoNave
        Try   'Trae todos los tipos de Naves
            Lector2 = consultar2("select * from tipoNaves Where id='" & id & "'")
            Dim tn As New TipoNave

            While Lector2.Read()
                tn = New TipoNave
                tn.id = Lector2("id")
                tn.nombre = Lector2("nombre")
            End While
            Return tn
        Catch ex As Exception
            MsgBox("Error al listar los tipos de naves")
        End Try

    End Function



    'Lista Tipos de naves

    Public Function Lista_tiposNaves() As ArrayList
        'Trae todos los tipos de Naves
        Lector2 = consultar2("select * from tipoNaves")
        Dim listTiposN As New ArrayList
        Dim tn As New TipoNave
        Try
            While Lector2.Read()
                tn = New TipoNave
                tn.id = Lector2("id")
                tn.nombre = Lector2("nombre")

                listTiposN.Add(tn)
            End While
            Return listTiposN
        Catch ex As Exception
            MsgBox("Error al listar los tipos de naves")
        End Try
        Return listTiposN
    End Function


End Class
