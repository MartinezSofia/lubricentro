Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RegistroTurno
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM cliente WHERE (dnicli=@dnicli)"
            Dim consultaSql1 As String = "SELECT COUNT(*) FROM turno WHERE (fecha=@fecha)"
            Dim consultaSql2 As String = "SELECT COUNT(*) FROM vehiculo WHERE (patente=@patente)"
            Dim fecha As DateTime = Convert.ToDateTime(fecha)
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dnicli", TBDni.Text)
            conexion.Open()
            ' Obtener los datos de la tabla turno y almacenarlos en un objeto DataTable
            Dim command As New SqlCommand("SELECT hora FROM turno", conexion)
            Dim dataTable As New DataTable()
            dataTable.Load(command.ExecuteReader())
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0
            Dim fechaIngresada As Date
            fechaIngresada = DTFecha.Value
            Dim valorCombobox = CBHora.SelectedItem.ToString()
            ' Obtener la hora actual del sistema
            Dim horaActual As DateTime = DateTime.Now
            ' Obtener la fecha seleccionada por el usuario
            Dim fechaSeleccionada As DateTime = DTFecha.Value
            ' Combinar la fecha seleccionada por el usuario con el horario seleccionado
            Dim horarioSeleccionado As DateTime = fechaSeleccionada.Date.Add(TimeSpan.Parse(CBHora.SelectedItem.ToString()))
            ' Verificar si el horario seleccionado es anterior al horario actual
            If horarioSeleccionado <= horaActual Then
                MessageBox.Show("No se puede agregar un turno con un horario anterior al horario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Salir del método sin agregar el turno
            End If

            If (TxtDNI.Text = "") Or (TxtNyA.Text = "") Or (TxtTelefono.Text = "") Or (TxtDireccion.Text = "") Or (TBPatente.Text = "") Or (TBModelo.Text = "") Or (TBMarca.Text = "") Or (CBHora.Text = "") Or (DTFecha.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    MsgBox("La fecha ingresada no disponible", vbCritical, "Error")
                Else
                    If fechaIngresada < Date.Today Then
                        MessageBox.Show("La fecha ingresada es menor que la fecha actual. Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim horaDisponible As Boolean = True
                        For Each row As DataRow In dataTable.Rows
                            Dim horaTurno As String = row("hora").ToString()
                            If horaTurno = valorCombobox Then
                                horaDisponible = False
                                MsgBox("La hora solicitada ya esta ocupada. Por favor, seleccione otro horario.")
                                Exit For
                            End If
                        Next
                        If horaDisponible Then
                            Dim result As MsgBoxResult
                            result = MsgBox("¿Desea terminar y registrar el nuevo turno?", 4 + 256 + 32, "Confirmación")
                            If result = vbYes Then
                                Try
                                    Dim cmd As New SqlCommand
                                    abrir()
                                    cmd = New SqlCommand("pa_cliente_insertar", conexion)
                                    cmd.CommandType = 4
                                    cmd.Parameters.AddWithValue("@dnicli", TxtDNI.Text)
                                    cmd.Parameters.AddWithValue("@nomyape", TxtNyA.Text)
                                    cmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text)
                                    cmd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
                                    cmd.Parameters.AddWithValue("@patente", TBPatente.Text)
                                    cmd.Parameters.AddWithValue("@marca", TBMarca.Text)
                                    cmd.Parameters.AddWithValue("@modelo", TBModelo.Text)
                                    cmd.Parameters.AddWithValue("@hora", CBHora.SelectedItem)
                                    cmd.Parameters.AddWithValue("@fecha", DTFecha.Value)
                                    cmd.ExecuteNonQuery()
                                    MsgBox("Turno registrado", MsgBoxStyle.OkOnly)
                                    cerrar()
                                    TxtDNI.Clear()
                                    TxtNyA.Clear()
                                    TxtDireccion.Clear()
                                    TxtTelefono.Clear()

                                Catch ex As Exception : MsgBox(ex.Message)

                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
                abrir()
                da = New SqlDataAdapter("lista_clientes", conexion)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cerrar()
            Catch ex As Exception : MsgBox(ex.Message)

            End Try
    End Sub

    Private Sub BBuscar_Click2(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("lista_clientes_2", conexion)
            da.Fill(dt)
            DataGridView2.DataSource = dt
            cerrar()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BBuscar_Click3(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("lista_clientes_3", conexion)
            da.Fill(dt)
            DataGridView3.DataSource = dt
            cerrar()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Sub consultaDinamica(ByVal dni As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Select * from Cliente where dnicli like '" & dni + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TBDni_TextChanged(sender As Object, e As EventArgs) Handles TBDni.TextChanged
        consultaDinamica(TBDni.Text, DataGridView1)
    End Sub

    Public Function Modificar(dnicli As String, nomyape As String, telefono As String, direccion As String)
        Dim act As New SqlCommand("pb_modificar", conexion)
        act.CommandType = CommandType.StoredProcedure
        act.Parameters.AddWithValue("@dnicli", dnicli)
        act.Parameters.AddWithValue("@nomyape", nomyape)
        act.Parameters.AddWithValue("@telefono", telefono)
        act.Parameters.AddWithValue("@direccion", direccion)
        abrir()
        act.ExecuteNonQuery()
        cerrar()
    End Function

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM cliente WHERE (dniCli=@dniCli)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dniCli", TxtDNI.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TxtDNI.Text = "") Or (TxtNyA.Text = "") Or (TxtTelefono.Text = "") Or (TxtDireccion.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    Try
                        Modificar(TxtDNI.Text, TxtNyA.Text, TxtTelefono.Text, TxtDireccion.Text)
                        MsgBox("Se modifico al cliente con DNI: " + TxtDNI.Text)

                        TxtNyA.Text = ""
                        TxtTelefono.Text = ""
                        TxtDireccion.Text = ""
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

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNyA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNyA.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



End Class