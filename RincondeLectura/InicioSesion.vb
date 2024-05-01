
Public Class InicioSesion
    Public Function Verificar(ByVal p_usuario As String, ByVal p_pass As String, ByVal p_tipo As String)
        Try
            Dim tipouser As New dbLubricentroEntities1
            Dim verif = (From q In tipouser.usuario
                         Where (p_usuario = q.username And p_pass = q.pass And q.tipousuario = p_tipo)
                         Select q).First()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub BIngresar_Click() Handles BIngresar.Click

        If Verificar(TBUsuario.Text, TBContraseña.Text, "A") Then
            MessageBox.Show("Bienvenido a Lubricentro Dienfa", "Usuario: Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            administrador.ShowDialog()
        ElseIf Verificar(TBUsuario.Text, TBContraseña.Text, "V") Then
            MessageBox.Show("Bienvenido a Lubricentro Dienfa", "Usuario: Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vendedor.ShowDialog()
        ElseIf TBUsuario.Text = "" Or TBContraseña.Text = "" Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        TBUsuario.Text = ""
        TBContraseña.Text = ""
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TBContraseña_TextChanged(sender As Object, e As EventArgs) Handles TBContraseña.TextChanged
        TBContraseña.PasswordChar = "*"
    End Sub

    Private Sub InicioSesion_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.TBUsuario.Focus()
    End Sub

    Private Sub TBUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TBUsuario.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.TBContraseña.Focus()
        End If
    End Sub

    Private Sub TBContraseña_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TBContraseña.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BIngresar_Click()
        End If
    End Sub

End Class
