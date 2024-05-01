Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
            TBTitulo.Text = selectedRow.Cells(1).Value.ToString()
            TBCantidad.Text = selectedRow.Cells(4).Value.ToString()
            TBPrecio.Text = selectedRow.Cells(3).Value.ToString()
        End If
    End Sub
    Dim GrdTotal = 0, id = 0

    Private Sub BRemover_Click(sender As Object, e As EventArgs) Handles BRemover.Click
        ListaVenta.Rows.Remove(ListaVenta.CurrentRow)
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        ' Verificar si el DataGridView tiene al menos una fila
        If ListaVenta.Rows.Count > 0 Then
            MessageBox.Show("Venta realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ListaVenta.Rows.Remove(ListaVenta.CurrentRow)
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
        'Dim carga As Boolean = False
        If TBPrecio.Text = "" Or TBCantidad.Text = "" Then
            MsgBox("Ingrese la cantidad")
        ElseIf TBTitulo.Text = "" Then
            MsgBox("Seleccione un producto")
        Else
            Dim k As Integer

            If TBCantidad.Text <= Me.DataGridView2.Item(4, i).Value Then
                Dim rnum As Integer = ListaVenta.Rows.Add()
                id = id + 1
                Dim total = Convert.ToInt32(TBCantidad.Text) * TBPrecio.Text
                Dim cantidad = Convert.ToInt32(TBCantidad.Text)
                ListaVenta.Rows.Item(rnum).Cells("Column2").Value = TBTitulo.Text
                ListaVenta.Rows.Item(rnum).Cells("Column3").Value = TBPrecio.Text
                ListaVenta.Rows.Item(rnum).Cells("Column4").Value = cantidad

                GrdTotal = GrdTotal + total
                Dim tot As String
                tot = Convert.ToString(GrdTotal)
                LTotal.Text = tot
            Else
                'Si el stock es menor a la cantidad seleccionada, el sistema nos avisa
                MessageBox.Show("La cantidad seleccionada supera el stock disponible", "Stock no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub
End Class