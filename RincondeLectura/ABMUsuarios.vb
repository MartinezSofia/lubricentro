Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ABMUsuarios
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        If (RBActivos.Checked = True) Then
            Try
                abrir()
                da = New SqlDataAdapter("lista_usuarios", conexion)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cerrar()
            Catch ex As Exception : MsgBox(ex.Message)

            End Try
        Else
            If (RBEliminados.Checked = True) Then
                Try
                    abrir()
                    da = New SqlDataAdapter("lista_usuarios_eliminados", conexion)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                    cerrar()
                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            End If
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

    Private Sub TUsername_TextChanged(sender As Object, e As EventArgs) Handles TUsername.TextChanged
        consultaUsername(TUsername.Text, DataGridView1)
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM usuario WHERE (dni=@dni)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dni", TxtDNI.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TxtDNI.Text = "") Or (TxtNombre.Text = "") Or (TxtApellido.Text = "") Or (TxtPassword.Text = "") Or (TxtUsername.Text = "") And (RBAdmin.Checked = False) And (RBVendedor.Checked = False) Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    MsgBox("El usuario ingresado ya existe", vbCritical, "Error")
                Else
                    Dim result As MsgBoxResult
                    result = MsgBox("¿Desea terminar y registrar el nuevo usuario?", 4 + 256 + 32, "Confirmación")
                    If result = vbYes Then
                        Try
                            Dim cmd As New SqlCommand
                            abrir()
                            cmd = New SqlCommand("pa_usuario_insertar", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@dni", TxtDNI.Text)
                            cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text)
                            cmd.Parameters.AddWithValue("@apellido", TxtApellido.Text)
                            cmd.Parameters.AddWithValue("@pass", TxtPassword.Text)
                            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
                            If (RBAdmin.Checked = True) Then
                                cmd.Parameters.AddWithValue("@tipousuario", RBAdmin.Text)
                            Else
                                If (RBVendedor.Checked = True) Then
                                    cmd.Parameters.AddWithValue("@tipousuario", RBVendedor.Text)

                                End If
                            End If
                            cmd.ExecuteNonQuery()
                            MsgBox("Usuario registrado", MsgBoxStyle.OkOnly)
                            cerrar()
                            TxtDNI.Clear()
                            TxtNombre.Clear()
                            TxtApellido.Clear()
                            TxtPassword.Clear()
                            TxtUsername.Clear()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM usuario WHERE (dni=@dni)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dni", TxtDNI.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TxtDNI.Text = "") Or (TxtNombre.Text = "") Or (TxtApellido.Text = "") Or (TxtPassword.Text = "") Or (TxtUsername.Text = "") And (RBAdmin.Checked = False) And (RBVendedor.Checked = False) Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    Try
                        Modificar(TxtDNI.Text, TxtNombre.Text, TxtApellido.Text, TxtUsername.Text, TxtPassword.Text)
                        MsgBox("Se modifico al usuario con DNI: " + TxtDNI.Text)

                        TxtNombre.Text = ""
                        TxtApellido.Text = ""
                        TxtUsername.Text = ""
                        TxtPassword.Text = ""
                        TxtDNI.Text = ""
                    Catch ex As Exception
                        MsgBox("Error al modificar", vbCritical, "Error")
                    End Try
                Else
                    MsgBox("El DNI ingresado no existe", vbCritical, "Error")
                End If
            End If
        End Using
    End Sub

    Public Function Modificar(dni As String, nombre As String, apellido As String, username As String, pass As String)
        Dim act As New SqlCommand("pb_modificarUsuario", conexion)
        act.CommandType = CommandType.StoredProcedure
        act.Parameters.AddWithValue("@dni", dni)
        act.Parameters.AddWithValue("@nombre", nombre)
        act.Parameters.AddWithValue("@apellido", apellido)
        act.Parameters.AddWithValue("@username", username)
        act.Parameters.AddWithValue("@pass", pass)
        If (RBAdmin.Checked = True) Then
            act.Parameters.AddWithValue("@tipousuario", RBAdmin.Text)
        Else
            If (RBVendedor.Checked = True) Then
                act.Parameters.AddWithValue("@tipousuario", RBVendedor.Text)
            End If
        End If
        abrir()
        act.ExecuteNonQuery()
        cerrar()
    End Function

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@dni", DataGridView1.SelectedCells.Item(0).Value)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            MsgBox("Se dio de baja el usuario")
            cerrar()
        Catch ex As Exception : MsgBox("Error al eliminar el usuario")
        End Try
    End Sub

    Private Sub BActivar_Click(sender As Object, e As EventArgs) Handles BActivar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("alta_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@dni", DataGridView1.SelectedCells.Item(0).Value)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            MsgBox("Se dio de alta el usuario")
            cerrar()
        Catch ex As Exception : MsgBox("Error al dar de alta el usuario")
        End Try
    End Sub

    Private Sub RBActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RBActivos.CheckedChanged
        If RBActivos.Checked = True Then
            BActivar.Enabled = False
            BEliminar.Enabled = True
        End If
    End Sub

    Private Sub RBEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles RBEliminados.CheckedChanged
        If RBEliminados.Checked = True Then
            BEliminar.Enabled = False
            BActivar.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TxtDNI.Text = DataGridView1.CurrentRow.Cells("dni").Value.ToString()
            TxtNombre.Text = DataGridView1.CurrentRow.Cells("nombre").Value.ToString()
            TxtApellido.Text = DataGridView1.CurrentRow.Cells("apellido").Value.ToString()
            TxtUsername.Text = DataGridView1.CurrentRow.Cells("username").Value.ToString()
            TxtPassword.Text = DataGridView1.CurrentRow.Cells("pass").Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class