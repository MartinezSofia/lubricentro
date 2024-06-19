Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RegistroTurno
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM cliente WHERE (dnicli=@dnicli)"
            Dim consultaSql1 As String = "SELECT COUNT(*) FROM turno WHERE (fecha=@fecha AND hora=@hora)"
            Dim consultaSql2 As String = "SELECT COUNT(*) FROM vehiculo WHERE (patente=@patente)"

            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dnicli", TxtDNI.Text)
            Dim comd2 As New SqlCommand(consultaSql2, conexion)
            comd2.Parameters.AddWithValue("@patente", TBPatente.Text)

            conexion.Open()

            ' Verificar si el cliente ya existe
            Dim clienteExiste As Boolean = Convert.ToInt32(comd.ExecuteScalar()) > 0
            ' Verificar si el vehículo ya existe
            Dim vehiculoExiste As Boolean = Convert.ToInt32(comd2.ExecuteScalar()) > 0

            ' Verificar si todos los campos están completos
            If (TxtDNI.Text = "") Or (TxtNyA.Text = "") Or (TxtTelefono.Text = "") Or (TxtDireccion.Text = "") Or (TBPatente.Text = "") Or (TBModelo.Text = "") Or (TBMarca.Text = "") Or (CBHora.Text = "") Or (DTFecha.Text = "") Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Alerta")
                Exit Sub
            End If

            ' Obtener la hora actual del sistema
            Dim horaActual As DateTime = DateTime.Now
            ' Obtener la fecha y hora seleccionadas por el usuario
            Dim fechaSeleccionada As DateTime = DTFecha.Value
            Dim horarioSeleccionado As DateTime = fechaSeleccionada.Date.Add(TimeSpan.Parse(CBHora.SelectedItem.ToString()))

            ' Verificar si la fecha seleccionada es anterior a la fecha actual
            If fechaSeleccionada < Date.Today Then
                MessageBox.Show("La fecha ingresada es menor que la fecha actual. Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Verificar si el horario seleccionado es anterior al horario actual
            If horarioSeleccionado <= horaActual Then
                MessageBox.Show("No se puede agregar un turno con un horario anterior al horario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Verificar si la combinación de fecha y hora ya está ocupada
            Dim comd1 As New SqlCommand(consultaSql1, conexion)
            comd1.Parameters.AddWithValue("@fecha", fechaSeleccionada)
            comd1.Parameters.AddWithValue("@hora", CBHora.SelectedItem.ToString())
            Dim turnoOcupado As Boolean = Convert.ToInt32(comd1.ExecuteScalar()) > 0
            If turnoOcupado Then
                MsgBox("La combinación de fecha y hora ya está ocupada. Por favor, seleccione otra fecha u hora.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            ' Verificar si el cliente o el vehículo ya existen en la base de datos
            If clienteExiste Then
                MsgBox("El cliente con ese DNI ya existe en la base de datos.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            If vehiculoExiste Then
                MsgBox("El vehículo con esa patente ya existe en la base de datos.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            ' Preguntar al usuario si desea registrar el nuevo turno
            Dim result As MsgBoxResult = MsgBox("¿Desea terminar y registrar el nuevo turno?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmación")
            If result = MsgBoxResult.Yes Then
                Try
                    Dim cmd As New SqlCommand("pa_cliente_insertar", conexion)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@dnicli", TxtDNI.Text)
                    cmd.Parameters.AddWithValue("@nomyape", TxtNyA.Text)
                    cmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text)
                    cmd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
                    cmd.Parameters.AddWithValue("@patente", TBPatente.Text)
                    cmd.Parameters.AddWithValue("@marca", TBMarca.Text)
                    cmd.Parameters.AddWithValue("@modelo", TBModelo.Text)
                    cmd.Parameters.AddWithValue("@hora", CBHora.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@fecha", DTFecha.Value)
                    cmd.ExecuteNonQuery()
                    MsgBox("Turno registrado", MsgBoxStyle.OkOnly)

                    ' Limpiar los campos después de registrar el turno
                    TxtDNI.Clear()
                    TxtNyA.Clear()
                    TxtDireccion.Clear()
                    TxtTelefono.Clear()
                    TBPatente.Clear()
                    TBMarca.Clear()
                    TBModelo.Clear()
                    CBHora.SelectedIndex = -1
                    DTFecha.Value = DateTime.Now

                Catch ex As Exception
                    MsgBox("Error al registrar el turno: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If

            conexion.Close()
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

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub CBHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBHora.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TxtDNI.Text = DataGridView1.CurrentRow.Cells("dni").Value.ToString()
            TxtNyA.Text = DataGridView1.CurrentRow.Cells("nomyape").Value.ToString()
            TxtDireccion.Text = DataGridView1.CurrentRow.Cells("direccion").Value.ToString()
            TxtTelefono.Text = DataGridView1.CurrentRow.Cells("telefono").Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            TxtDNI.Text = DataGridView1.CurrentRow.Cells("dni").Value.ToString()
            TxtNyA.Text = DataGridView1.CurrentRow.Cells("nomyape").Value.ToString()
            TxtDireccion.Text = DataGridView1.CurrentRow.Cells("direccion").Value.ToString()
            TxtTelefono.Text = DataGridView1.CurrentRow.Cells("telefono").Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TxtDNI.Text = DataGridView1.CurrentRow.Cells("dni").Value.ToString()
            TxtNyA.Text = DataGridView1.CurrentRow.Cells("nomyape").Value.ToString()
            TxtDireccion.Text = DataGridView1.CurrentRow.Cells("direccion").Value.ToString()
            TxtTelefono.Text = DataGridView1.CurrentRow.Cells("telefono").Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class