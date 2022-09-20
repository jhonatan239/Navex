Imports MySql.Data.MySqlClient

Imports System.IO

Public Class PersistenciaNave


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

    'Consultas a BD
    Public Function consultar(ByVal consulta As String) As MySqlDataReader
        conectarse()
        SQLConnection.Close()
        Try
            SQLConnection = New MySqlConnection()
            SQLConnection.ConnectionString = connectionString
            SQLConnection.Open()

            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = consulta

            Return sqlCommand.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error de conexión (Cons)")
            Return sqlCommand.ExecuteReader()
        End Try

        SQLConnection.Close()
    End Function

    'Consultas a BD
    Public Function consultar2(ByVal consulta As String) As MySqlDataReader

        Try
            'SQLConnection2.Close()
            conectarse()
            'SQLcONECTION.close linea agregada por el fallo de conexion al hacer repetidas veces click en 

            SQLConnection2 = New MySqlConnection()

            SQLConnection2.ConnectionString = connectionString

            SQLConnection2.Open()


            sqlCommand2.Connection = SQLConnection2
            sqlCommand2.CommandText = consulta

            Return sqlCommand2.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error de conexión (Cons2)")
            Return sqlCommand2.ExecuteReader()
        End Try

        SQLConnection.Close()
    End Function

    'Ejecutar sentencia en Bd
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
            MsgBox("Error de conexión (Ejec)")
            Return False

        End Try
        SQLConnection.Close()
    End Function

    Public Function Eliminar_IngEgreXid(id As Integer)
        If ejecutar("delete * from naves") Then
            Return True
        Else
            Return False
        End If
    End Function


    '------Guardar Nave-----
    Public Function guardar_nave(ByVal n As Nave) As Boolean
        If ejecutar("INSERT INTO naves (tipoNave,nombre,empresa,pais,imagen,tipoCombustible,potencia,toneDeEm,tipoCarga,capacidadCarga,capacidadPersonas,altura,peso,funcion,id) VALUES('" & n.tipoDeNave.id & "','" & n.nombre & "','" & n.empresa & "','" & n.pais & "','" & n.imagen & "','" & n.tipoCombustible & "','" & n.potencia & "','" & n.toneEmpuje & "','" & n.tipoDeCarga & "','" & n.capDeCarga & "','" & n.capDePersonas & "','" & n.altura & "','" & n.peso & "','" & n.funcion & "','" & n.id & "')") Then
            MsgBox("Nueva Nave Ingresada.")
            Return True
        Else
            MsgBox("Error al Guardar, puede que existan datos mal asignados.")
        End If
        Return False
    End Function

    '------Actualizar Nave -----
    Public Sub modificar_nave(n As Nave)
        If ejecutar("update naves set  tipoNave='" & n.tipoDeNave.id & "', nombre='" & n.nombre & "', empresa='" & n.empresa & "', pais='" & n.pais & "', imagen='" & n.imagen & "', tipoCombustible='" & n.tipoCombustible & "', potencia='" & n.potencia & "', toneDeEm='" & n.toneEmpuje & "', tipoCarga='" & n.tipoDeCarga & "', capacidadCarga='" & n.capDeCarga & "', capacidadPersonas='" & n.capDePersonas & "', altura='" & n.altura & "', funcion='" & n.funcion & "' where id='" & n.id & "'") Then
            MsgBox("Datos de la Nave Actualizados.")
        Else
            MsgBox("Error al actualizar, puede que existan datos mal asignados.")
        End If
    End Sub

    '------Eliminar Tipo Nave -----
    Public Function eliminar_nave(id As Integer)
        Try
            If ejecutar("delete from naves where id=" & id) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la nave")
        End Try

        Return False
    End Function


    Public Function existeIdXtabla(ByVal id As Integer, tabla As String)
        'Trae los objetos por id
        Lector = consultar("select * from " & tabla & " Where id='" & id & "'")
        If Lector.Read() Then
            Return True
        Else
            Return False
        End If
    End Function

    'Trae naves por nombre si no hay texto trae todas
    Public Function ListaNaveXnombre(ByVal nom As String) As ArrayList

        Lector = consultar2("select * from naves Where nombre Like '%" & nom & "%'")
        Dim n As New Nave, tp As New TipoNave
        Dim listan As New ArrayList
        Try
            While Lector.Read()
                n = New Nave
                n.tipoDeNave = New TipoNave
                n.id = Lector("id")
                n.nombre = Lector("nombre")
                n.tipoDeNave.id = Lector("tipoNave")
                'Traemos el objeto tipo por id
                n.tipoDeNave = n.tipoDeNave.buscarXid(n.tipoDeNave.id, "tipoNaves")

                n.potencia = Lector("potencia")
                n.tipoDeCarga = Lector("tipoCarga")
                n.pais = Lector("pais")
                n.peso = Lector("peso")
                n.capDeCarga = Lector("capacidadCarga")
                n.altura = Lector("altura")
                n.toneEmpuje = Lector("toneDeEm")
                n.imagen = Lector("imagen")
                n.capDePersonas = Lector("capacidadPersonas")
                n.funcion = Lector("funcion")

                listan.Add(n)
            End While
        Catch ex As Exception
            MsgBox("Error al listar las naves")
        End Try

        Return listan

    End Function


    'Trae naves por columna y valor
    Public Overloads Function ListaNaveXColumVal(ByVal colum As String, val As String) As ArrayList

        Lector = consultar2("select * from naves Where " & colum & " Like '%" & val & "%'")
        Dim n As New Nave, tp As New TipoNave
        Dim listan As New ArrayList
        Try
            While Lector.Read()
                n = New Nave
                n.tipoDeNave = New TipoNave
                n.id = Lector("id")
                n.nombre = Lector("nombre")
                n.tipoDeNave.id = Lector("tipoNave")
                'Traemos el objeto tipo por id
                n.tipoDeNave = n.tipoDeNave.buscarXid(n.tipoDeNave.id, "tipoNaves")

                n.potencia = Lector("potencia")
                n.tipoDeCarga = Lector("tipoCarga")
                n.pais = Lector("pais")
                n.peso = Lector("peso")
                n.capDeCarga = Lector("capacidadCarga")
                n.altura = Lector("altura")
                n.toneEmpuje = Lector("toneDeEm")
                n.imagen = Lector("imagen")
                n.capDePersonas = Lector("capacidadPersonas")
                n.funcion = Lector("funcion")

                listan.Add(n)
            End While
        Catch ex As Exception
            MsgBox("Error al listar las naves por filtro")
        End Try
        Return listan
    End Function

    'Trae naves por columna y valor y si es mayor o menor (sobrecarga metodo ListaNaveXcolumVal)<>
    Public Overloads Function ListaNaveXcolumVal(ByVal colum As String, val1 As Integer, val2 As Integer) As ArrayList
        Dim filtro As String
        filtro = " " & colum
        If val1 <> 0 AndAlso val2 <> 0 Then

            filtro = ">='" & val1 & "' and " & colum & "<='" & val2 & "'"
        Else

            If val1 <> 0 Then
                filtro = ">='" & val1 & "'"
            End If
            If val2 <> 0 Then
                filtro = "<='" & val2 & "'"
            End If
        End If


        Lector = consultar2("select * from naves Where " & colum & filtro & "")
        Dim n As New Nave, tp As New TipoNave
        Dim listan As New ArrayList
        Try
            While Lector.Read()
                n = New Nave
                n.tipoDeNave = New TipoNave
                n.id = Lector("id")
                n.nombre = Lector("nombre")
                n.tipoDeNave.id = Lector("tipoNave")
                'Traemos el objeto tipo por id
                n.tipoDeNave = n.tipoDeNave.buscarXid(n.tipoDeNave.id, "tipoNaves")

                n.potencia = Lector("potencia")
                n.tipoDeCarga = Lector("tipoCarga")
                n.pais = Lector("pais")
                n.peso = Lector("peso")
                n.capDeCarga = Lector("capacidadCarga")
                n.altura = Lector("altura")
                n.toneEmpuje = Lector("toneDeEm")
                n.imagen = Lector("imagen")
                n.capDePersonas = Lector("capacidadPersonas")
                n.funcion = Lector("funcion")

                listan.Add(n)
            End While
        Catch ex As Exception
            MsgBox("Error al listar las naves por filtro")
        End Try
        Return listan
    End Function
End Class
