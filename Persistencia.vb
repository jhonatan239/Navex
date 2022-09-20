Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Persistencia
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
            MsgBox("Error de conexión")
            SQLConnection.Close()
            ' MsgBox(ex)
            Return False

        End Try
        SQLConnection.Close()
    End Function





End Class
