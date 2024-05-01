Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ABMProductos
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM producto WHERE (idproducto=@idproducto)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@idproducto", TBIdproducto.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TBIdproducto.Text = "") Or (TBNombre.Text = "") Or (TBPrecio.Text = "") Or (TBStock.Text = "") Or (TBDescripcion.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    MsgBox("El producto ingresado ya existe", vbCritical, "Error")
                Else
                    Dim result As MsgBoxResult
                    result = MsgBox("¿Desea terminar y registrar el nuevo producto?", 4 + 256 + 32, "Confirmación")
                    If result = vbYes Then
                        Try
                            Dim cmd As New SqlCommand
                            abrir()
                            cmd = New SqlCommand("pa_producto_insertar", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idproducto", TBIdproducto.Text)
                            cmd.Parameters.AddWithValue("@nombre", TBNombre.Text)
                            cmd.Parameters.AddWithValue("@descripcion", TBDescripcion.Text)
                            cmd.Parameters.AddWithValue("@precio", TBPrecio.Text)
                            cmd.Parameters.AddWithValue("@stock", TBStock.Text)
                            cmd.ExecuteNonQuery()
                            MsgBox("Producto registrado", MsgBoxStyle.OkOnly)
                            cerrar()
                            TBIdproducto.Clear()
                            TBNombre.Clear()
                            TBDescripcion.Clear()
                            TBPrecio.Clear()
                            TBStock.Clear()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        If (RBActivos.Checked = True) Then
            Try
                abrir()
                da = New SqlDataAdapter("lista_productos", conexion)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cerrar()
            Catch ex As Exception : MsgBox(ex.Message)
            End Try
        Else
            If (RBEliminados.Checked = True) Then
                Try
                    abrir()
                    da = New SqlDataAdapter("lista_productos_eliminados", conexion)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                    cerrar()
                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            End If
        End If
    End Sub

    Sub consultaProducto(ByVal idproducto As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from producto where idproducto like '" & idproducto + "%" & "'", conexion)
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
            da = New SqlDataAdapter("Select * from producto where nombre like '" & nombre + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TIdproducto_TextChanged(sender As Object, e As EventArgs) Handles TIdproducto.TextChanged
        consultaProducto(TIdproducto.Text, DataGridView1)
    End Sub
    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        consultaNombre(TNombre.Text, DataGridView1)
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM producto WHERE (idproducto=@idproducto)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@idproducto", TBIdproducto.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TBNombre.Text = "") Or (TBDescripcion.Text = "") Or (TBPrecio.Text = "") Or (TBStock.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    Try
                        Modificar(TBIdproducto.Text, TBNombre.Text, TBDescripcion.Text, TBPrecio.Text, TBStock.Text)
                        MsgBox("Se modifico el producto con numero de ID: " + TBIdproducto.Text)

                        TBIdproducto.Text = ""
                        TBNombre.Text = ""
                        TBDescripcion.Text = ""
                        TBPrecio.Text = ""
                        TBStock.Text = ""
                    Catch ex As Exception
                        MsgBox("Error al modificar", vbCritical, "Error")
                    End Try
                Else
                    MsgBox("El ID del producto ingresado no existe", vbCritical, "Error")
                End If
            End If
        End Using
    End Sub

    Public Function Modificar(idproducto As String, nombre As String, descripcion As String, precio As Decimal, stock As Integer)
        Dim act As New SqlCommand("pb_modificarProducto", conexion)
        act.CommandType = CommandType.StoredProcedure
        act.Parameters.AddWithValue("@idproducto", idproducto)
        act.Parameters.AddWithValue("@nombre", nombre)
        act.Parameters.AddWithValue("@descripcion", descripcion)
        act.Parameters.AddWithValue("@precio", precio)
        act.Parameters.AddWithValue("@stock", stock)
        abrir()
        act.ExecuteNonQuery()
        cerrar()
    End Function



    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_producto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idproducto", DataGridView1.SelectedCells.Item(0).Value)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            MsgBox("Se dio de baja el producto")
            cerrar()
        Catch ex As Exception : MsgBox("Error al eliminar el producto")
        End Try
    End Sub

    Private Sub BActivar_Click(sender As Object, e As EventArgs) Handles BActivar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("alta_producto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idproducto", DataGridView1.SelectedCells.Item(0).Value)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            MsgBox("Se dio de alta el producto")
            cerrar()
        Catch ex As Exception : MsgBox("Error al dar de alta el producto")
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
            TBIdproducto.Text = DataGridView1.CurrentRow.Cells("idproducto").Value.ToString()
            TBNombre.Text = DataGridView1.CurrentRow.Cells("nombre").Value.ToString()
            TBDescripcion.Text = DataGridView1.CurrentRow.Cells("descripcion").Value.ToString()
            TBPrecio.Text = DataGridView1.CurrentRow.Cells("precio").Value.ToString()
            TBStock.Text = DataGridView1.CurrentRow.Cells("stock").Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class