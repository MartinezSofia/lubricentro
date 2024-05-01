Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FListarUsuarios
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        If (RBtodos.Checked = True) Then
            Try
                abrir()
                da = New SqlDataAdapter("lista_usuarios", conexion)
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
            da = New SqlDataAdapter("Select * from usuario where dni like '" & dni + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub consultaNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from usuario where nombre like '" & nombre + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub consultaApellido(ByVal apellido As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from usuario where apellido like '" & apellido + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub consultaUsername(ByVal username As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from usuario where username like '" & username + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TBDni_TextChanged(sender As Object, e As EventArgs) Handles TBDni.TextChanged
        consultaDni(TBDni.Text, DataGridView1)
    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        consultaNombre(TBNombre.Text, DataGridView1)
    End Sub

    Private Sub TBApellido_TextChanged(sender As Object, e As EventArgs) Handles TBApellido.TextChanged
        consultaApellido(TBApellido.Text, DataGridView1)
    End Sub
    Private Sub TBUsername_TextChanged(sender As Object, e As EventArgs) Handles TBUsername.TextChanged
        consultaUsername(TBUsername.Text, DataGridView1)
    End Sub
End Class