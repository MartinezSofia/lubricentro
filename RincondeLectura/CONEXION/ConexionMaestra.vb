Imports System.Data.SqlClient

Module ConexionMaestra
    Public conexion As New SqlConnection("Data Source=DESKTOP-GK3J46S\SQLEXPRESS; Initial Catalog = BlackJodo_BD;Integrated Security=True")

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
