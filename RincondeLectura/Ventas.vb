Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.Odbc
Imports System.IO
Imports System.Windows.Forms

Public Class Ventas
    Dim connectionString As String = "Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    Dim connection As SqlConnection = New SqlConnection(connectionString)

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        Dim query As String = "SELECT * FROM producto"
        Dim dataAdapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)
        DataGridView2.DataSource = dataTable
        connection.Close()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            TBIdproducto.Text = selectedRow.Cells(0).Value.ToString()
            TBTitulo.Text = selectedRow.Cells(1).Value.ToString()
            TBCantidad.Text = selectedRow.Cells(4).Value.ToString()
            TBPrecio.Text = selectedRow.Cells(3).Value.ToString()
        End If
    End Sub
    Dim GrdTotal = 0, id = 0
    Private Sub BRemover_Click(sender As Object, e As EventArgs) Handles BRemover.Click
        If ListaVenta.CurrentRow IsNot Nothing Then
            Try
                ' Verificar si la columna contiene un valor válido
                Dim cellValue As Object = ListaVenta.CurrentRow.Cells("Column5").Value

                If cellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cellValue.ToString()) Then
                    ' Convertir el valor de la celda a Decimal
                    Dim importeActual As Decimal = Convert.ToDecimal(cellValue)
                    ' Restar el importe de la fila actual del total
                    GrdTotal -= importeActual
                    ' Eliminar la fila actual
                    ListaVenta.Rows.Remove(ListaVenta.CurrentRow)
                    ' Recalcular el total para asegurar la precisión
                    GrdTotal = 0
                    For Each row As DataGridViewRow In ListaVenta.Rows
                        If Not row.IsNewRow Then
                            GrdTotal += Convert.ToDecimal(row.Cells("Column5").Value)
                        End If
                    Next

                    ' Actualizar el label LTotal
                    LTotal.Text = GrdTotal.ToString()
                Else
                    MsgBox("La celda no contiene un valor válido.")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub autocompletarTextbox(ByVal TBCliente As System.Windows.Forms.TextBox)
        Try
            abrir()
            cmd = New SqlCommand("SELECT dnicli FROM cliente", conexion)
            dr = cmd.ExecuteReader()
            While dr.Read()
                TBCliente.AutoCompleteCustomSource.Add(dr.Item("dnicli").ToString())
            End While
            cerrar()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autocompletarTextbox(Me.TBCliente)
    End Sub
    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Using conexion As New SqlConnection("Data Source=ARIEL\SQLEXPRESS;Initial Catalog=dbLubricentro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            conexion.Open()

            If ListaVenta.Rows.Count = 0 Then
                MsgBox("La tabla venta se encuentra vacía", MsgBoxStyle.Critical)
            Else
                If MsgBox("¿Confirmar Operación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Factura") = MsgBoxResult.Yes Then
                    Try
                        ' Eliminar caracteres no numéricos del total antes de convertir
                        Dim totalTexto As String = LTotal.Text.Replace("ARS", "").Trim()
                        Dim totalVenta As Decimal = Convert.ToDecimal(totalTexto)
                        Dim dnicliente As String = TBCliente.Text

                        ' Iterar sobre las filas del DataGridView y agregar parámetros
                        For Each row As DataGridViewRow In ListaVenta.Rows
                            If Not row.IsNewRow Then
                                Dim comd = New SqlCommand("ventas_insertar", conexion)
                                comd.CommandType = CommandType.StoredProcedure

                                comd.Parameters.AddWithValue("@dnicliente", dnicliente)
                                comd.Parameters.AddWithValue("@total", totalVenta)

                                ' Validar y convertir los valores de las celdas
                                Dim idProducto As Integer = Convert.ToInt32(row.Cells("Column1").Value)
                                Dim cantidad As Integer = Convert.ToInt32(row.Cells("Column4").Value)
                                Dim precio As Decimal = Convert.ToDecimal(row.Cells("Column3").Value)
                                Dim importe As Decimal = precio * cantidad

                                comd.Parameters.AddWithValue("@idproducto", idProducto)
                                comd.Parameters.AddWithValue("@cantidad", cantidad)
                                comd.Parameters.AddWithValue("@precio", precio)
                                comd.Parameters.AddWithValue("@importe", importe)

                                comd.ExecuteNonQuery()
                            End If
                        Next

                        MsgBox("Venta registrada", MsgBoxStyle.OkOnly)

                        ' Limpiar los TextBox y el DataGridView
                        TBCliente.Clear()
                        TBIdproducto.Clear()
                        TBTitulo.Clear()
                        TBPrecio.Clear()
                        TBCantidad.Clear()
                        LTotal.Text = "0"

                        ListaVenta.Rows.Clear()

                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                End If
            End If
        End Using
    End Sub


    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ListaVenta.Rows.Clear()
        TBCantidad.Text = ""
        TBPrecio.Text = ""
        TBTitulo.Text = ""
        LTotal.Text = "-"
    End Sub

    Private Sub BAgregarProducto_Click(sender As Object, e As EventArgs) Handles BAgregarProducto.Click
        Dim i As Integer = DataGridView2.CurrentRow.Index

        If TBPrecio.Text = "" Or TBCantidad.Text = "" Then
            MsgBox("Ingrese la cantidad")
        ElseIf TBTitulo.Text = "" Then
            MsgBox("Seleccione un producto")
        ElseIf TBCliente.Text = "" Then
            MsgBox("El campo DNI cliente está vacío")
        ElseIf TBCliente.Text.Length < 8 Then
            MsgBox("El campo DNI cliente debe contener al menos 8 dígitos")
        Else
            If Convert.ToInt32(TBCantidad.Text) <= Convert.ToInt32(Me.DataGridView2.Item(4, i).Value) Then
                Dim rnum As Integer = ListaVenta.Rows.Add()
                id = id + 1

                ' Convertir los valores a Decimal para el cálculo del subtotal
                Dim precio As Decimal = Convert.ToDecimal(TBPrecio.Text)
                Dim cantidad As Decimal = Convert.ToDecimal(TBCantidad.Text)
                Dim subtotal As Decimal = cantidad * precio

                ' Asignar valores a las celdas del DataGridView
                ListaVenta.Rows.Item(rnum).Cells("Column1").Value = TBIdproducto.Text
                ListaVenta.Rows.Item(rnum).Cells("Column2").Value = TBTitulo.Text
                ListaVenta.Rows.Item(rnum).Cells("Column3").Value = precio
                ListaVenta.Rows.Item(rnum).Cells("Column4").Value = cantidad
                ListaVenta.Rows.Item(rnum).Cells("Column5").Value = subtotal  ' Guardar el subtotal en Column5

                ' Actualizar el total general
                GrdTotal = GrdTotal + subtotal
                LTotal.Text = "ARS " + GrdTotal.ToString()
            Else
                ' Si el stock es menor a la cantidad seleccionada, el sistema nos avisa
                MessageBox.Show("La cantidad seleccionada supera el stock disponible", "Stock no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub



End Class