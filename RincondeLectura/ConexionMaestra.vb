Imports System.Data.SqlClient

Module ConexionMaestra
    Public conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
    Public dr As SqlDataReader
    Public cmd As SqlCommand
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
