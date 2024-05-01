Public Class InicioSesion
    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If (TBUsuario.Text = "vendedor" And TBContraseña.Text = "vendedor") Then
            MDIParent1.Show()
            Hide()
        ElseIf (TBUsuario.Text = "gerente" And TBContraseña.Text = "gerente") Then
            MDIParent2.Show()
            Hide()
        ElseIf (TBUsuario.Text = "admin" And TBContraseña.Text = "admin") Then
            MDIParent3.Show()
            Hide()
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
End Class
