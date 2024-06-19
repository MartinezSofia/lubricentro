Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FLClientes
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        If (CBTodos.Checked = True) Then
            Try
                abrir()
                da = New SqlDataAdapter("listacompleta_clientes", conexion)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cerrar()
            Catch ex As Exception : MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Sub consultaDni(ByVal dni As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from cliente where dnicli like '" & dni + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub consultaDireccion(ByVal direccion As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from cliente where direccion like '" & direccion + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub consultaNombre(ByVal nomyape As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Select * from cliente where nomyape like '" & nomyape + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TBDni_TextChanged(sender As Object, e As EventArgs) Handles TBDni.TextChanged
        consultaDni(TBDni.Text, DataGridView1)
    End Sub

    Private Sub TBDireccion_TextChanged(sender As Object, e As EventArgs) Handles TBDireccion.TextChanged
        consultaDireccion(TBDireccion.Text, DataGridView1)
    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        consultaNombre(TBNombre.Text, DataGridView1)
    End Sub
End Class