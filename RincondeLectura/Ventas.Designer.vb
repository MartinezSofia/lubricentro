<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PFacturacion = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.BRemover = New System.Windows.Forms.Button()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ListaVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBIdproducto = New System.Windows.Forms.TextBox()
        Me.LIdProducto = New System.Windows.Forms.Label()
        Me.TBCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BAgregarProducto = New System.Windows.Forms.Button()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBTitulo = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PFacturacion.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(524, 409)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Total:"
        '
        'PFacturacion
        '
        Me.PFacturacion.Controls.Add(Me.BCancelar)
        Me.PFacturacion.Controls.Add(Me.BConfirmar)
        Me.PFacturacion.Location = New System.Drawing.Point(801, 301)
        Me.PFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.PFacturacion.Name = "PFacturacion"
        Me.PFacturacion.Size = New System.Drawing.Size(328, 88)
        Me.PFacturacion.TabIndex = 91
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(193, 18)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(121, 58)
        Me.BCancelar.TabIndex = 8
        Me.BCancelar.Text = "Cancelar Facturacion"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.Location = New System.Drawing.Point(12, 18)
        Me.BConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(128, 58)
        Me.BConfirmar.TabIndex = 7
        Me.BConfirmar.Text = "Confirmar Facturacion"
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'BRemover
        '
        Me.BRemover.Location = New System.Drawing.Point(7, 413)
        Me.BRemover.Margin = New System.Windows.Forms.Padding(4)
        Me.BRemover.Name = "BRemover"
        Me.BRemover.Size = New System.Drawing.Size(100, 28)
        Me.BRemover.TabIndex = 89
        Me.BRemover.Text = "Remover"
        Me.BRemover.UseVisualStyleBackColor = True
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(595, 409)
        Me.LTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(68, 29)
        Me.LTotal.TabIndex = 88
        Me.LTotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Lista de productos"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(7, 28)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(768, 185)
        Me.DataGridView2.TabIndex = 86
        '
        'ListaVenta
        '
        Me.ListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.ListaVenta.Location = New System.Drawing.Point(7, 220)
        Me.ListaVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.ListaVenta.Name = "ListaVenta"
        Me.ListaVenta.RowHeadersWidth = 51
        Me.ListaVenta.Size = New System.Drawing.Size(676, 185)
        Me.ListaVenta.TabIndex = 85
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id Producto"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Productos"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TBIdproducto)
        Me.Panel1.Controls.Add(Me.LIdProducto)
        Me.Panel1.Controls.Add(Me.TBCliente)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BAgregarProducto)
        Me.Panel1.Controls.Add(Me.TBPrecio)
        Me.Panel1.Controls.Add(Me.LPrecio)
        Me.Panel1.Controls.Add(Me.TBCantidad)
        Me.Panel1.Controls.Add(Me.TBTitulo)
        Me.Panel1.Controls.Add(Me.LCantidad)
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(799, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 265)
        Me.Panel1.TabIndex = 84
        '
        'TBIdproducto
        '
        Me.TBIdproducto.Location = New System.Drawing.Point(229, 67)
        Me.TBIdproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBIdproducto.Name = "TBIdproducto"
        Me.TBIdproducto.Size = New System.Drawing.Size(132, 22)
        Me.TBIdproducto.TabIndex = 16
        '
        'LIdProducto
        '
        Me.LIdProducto.AutoSize = True
        Me.LIdProducto.Location = New System.Drawing.Point(226, 47)
        Me.LIdProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LIdProducto.Name = "LIdProducto"
        Me.LIdProducto.Size = New System.Drawing.Size(75, 16)
        Me.LIdProducto.TabIndex = 15
        Me.LIdProducto.Text = "Id Producto"
        '
        'TBCliente
        '
        Me.TBCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TBCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TBCliente.Location = New System.Drawing.Point(88, 159)
        Me.TBCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCliente.Name = "TBCliente"
        Me.TBCliente.Size = New System.Drawing.Size(132, 22)
        Me.TBCliente.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cliente"
        '
        'BAgregarProducto
        '
        Me.BAgregarProducto.Location = New System.Drawing.Point(13, 214)
        Me.BAgregarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BAgregarProducto.Name = "BAgregarProducto"
        Me.BAgregarProducto.Size = New System.Drawing.Size(100, 28)
        Me.BAgregarProducto.TabIndex = 8
        Me.BAgregarProducto.Text = "Agregar"
        Me.BAgregarProducto.UseVisualStyleBackColor = True
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(89, 114)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(132, 22)
        Me.TBPrecio.TabIndex = 7
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(16, 117)
        Me.LPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(46, 16)
        Me.LPrecio.TabIndex = 5
        Me.LPrecio.Text = "Precio"
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(89, 66)
        Me.TBCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(132, 22)
        Me.TBCantidad.TabIndex = 3
        '
        'TBTitulo
        '
        Me.TBTitulo.Location = New System.Drawing.Point(88, 20)
        Me.TBTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTitulo.Name = "TBTitulo"
        Me.TBTitulo.Size = New System.Drawing.Size(132, 22)
        Me.TBTitulo.TabIndex = 2
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Location = New System.Drawing.Point(16, 69)
        Me.LCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(61, 16)
        Me.LCantidad.TabIndex = 1
        Me.LCantidad.Text = "Cantidad"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Location = New System.Drawing.Point(16, 24)
        Me.LTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(61, 16)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Producto"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 572)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PFacturacion)
        Me.Controls.Add(Me.BRemover)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ListaVenta)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ventas"
        Me.Text = "Form3"
        Me.PFacturacion.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents PFacturacion As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents BRemover As Button
    Friend WithEvents LTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ListaVenta As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BAgregarProducto As Button
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBTitulo As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents TBCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBIdproducto As TextBox
    Friend WithEvents LIdProducto As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
