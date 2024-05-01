<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBFiltroV = New System.Windows.Forms.GroupBox()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBCliente = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBFecha = New System.Windows.Forms.GroupBox()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.GBCod = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBVendedor = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBFiltroL = New System.Windows.Forms.GroupBox()
        Me.GBGenero = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GBAnioEdicion = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GBEditorial = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GBAutores = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.id_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GBFiltroV.SuspendLayout()
        Me.GBCliente.SuspendLayout()
        Me.GBFecha.SuspendLayout()
        Me.GBCod.SuspendLayout()
        Me.GBVendedor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltroL.SuspendLayout()
        Me.GBGenero.SuspendLayout()
        Me.GBAnioEdicion.SuspendLayout()
        Me.GBEditorial.SuspendLayout()
        Me.GBAutores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.GBFiltroV)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GBFiltroL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 457)
        Me.Panel1.TabIndex = 0
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Doppio One", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 66
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBFiltroV
        '
        Me.GBFiltroV.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltroV.Controls.Add(Me.CBTodos)
        Me.GBFiltroV.Controls.Add(Me.BBuscar)
        Me.GBFiltroV.Controls.Add(Me.GBCliente)
        Me.GBFiltroV.Controls.Add(Me.GBFecha)
        Me.GBFiltroV.Controls.Add(Me.GBCod)
        Me.GBFiltroV.Controls.Add(Me.GBVendedor)
        Me.GBFiltroV.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltroV.Location = New System.Drawing.Point(290, 45)
        Me.GBFiltroV.Name = "GBFiltroV"
        Me.GBFiltroV.Size = New System.Drawing.Size(390, 142)
        Me.GBFiltroV.TabIndex = 9
        Me.GBFiltroV.TabStop = False
        Me.GBFiltroV.Text = "Filtrar Por Venta"
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(10, 21)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(108, 17)
        Me.CBTodos.TabIndex = 14
        Me.CBTodos.Text = "Todas las Ventas"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(6, 101)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(126, 27)
        Me.BBuscar.TabIndex = 18
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBCliente
        '
        Me.GBCliente.Controls.Add(Me.TextBox2)
        Me.GBCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBCliente.Location = New System.Drawing.Point(255, 14)
        Me.GBCliente.Name = "GBCliente"
        Me.GBCliente.Size = New System.Drawing.Size(126, 52)
        Me.GBCliente.TabIndex = 17
        Me.GBCliente.TabStop = False
        Me.GBCliente.Text = "Cliente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 20)
        Me.TextBox2.TabIndex = 0
        '
        'GBFecha
        '
        Me.GBFecha.Controls.Add(Me.LHasta)
        Me.GBFecha.Controls.Add(Me.LDesde)
        Me.GBFecha.Controls.Add(Me.DTPHasta)
        Me.GBFecha.Controls.Add(Me.DTPDesde)
        Me.GBFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFecha.Location = New System.Drawing.Point(138, 13)
        Me.GBFecha.Name = "GBFecha"
        Me.GBFecha.Size = New System.Drawing.Size(111, 115)
        Me.GBFecha.TabIndex = 16
        Me.GBFecha.TabStop = False
        Me.GBFecha.Text = "Fecha"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(7, 67)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(35, 13)
        Me.LHasta.TabIndex = 3
        Me.LHasta.Text = "Hasta"
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(7, 20)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(38, 13)
        Me.LDesde.TabIndex = 2
        Me.LDesde.Text = "Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(6, 83)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(98, 20)
        Me.DTPHasta.TabIndex = 1
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(6, 39)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(98, 20)
        Me.DTPDesde.TabIndex = 0
        '
        'GBCod
        '
        Me.GBCod.Controls.Add(Me.TextBox1)
        Me.GBCod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBCod.Location = New System.Drawing.Point(255, 76)
        Me.GBCod.Name = "GBCod"
        Me.GBCod.Size = New System.Drawing.Size(126, 52)
        Me.GBCod.TabIndex = 15
        Me.GBCod.TabStop = False
        Me.GBCod.Text = "Codigo Venta"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GBVendedor
        '
        Me.GBVendedor.Controls.Add(Me.ComboBox5)
        Me.GBVendedor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBVendedor.Location = New System.Drawing.Point(6, 42)
        Me.GBVendedor.Name = "GBVendedor"
        Me.GBVendedor.Size = New System.Drawing.Size(126, 52)
        Me.GBVendedor.TabIndex = 14
        Me.GBVendedor.TabStop = False
        Me.GBVendedor.Text = "Vendedores"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox5.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_venta, Me.id_cliente, Me.cod_libro, Me.total, Me.fecha, Me.vendedor})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(670, 253)
        Me.DataGridView1.TabIndex = 8
        '
        'GBFiltroL
        '
        Me.GBFiltroL.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltroL.Controls.Add(Me.GBGenero)
        Me.GBFiltroL.Controls.Add(Me.GBAnioEdicion)
        Me.GBFiltroL.Controls.Add(Me.GBEditorial)
        Me.GBFiltroL.Controls.Add(Me.GBAutores)
        Me.GBFiltroL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltroL.Location = New System.Drawing.Point(10, 45)
        Me.GBFiltroL.Name = "GBFiltroL"
        Me.GBFiltroL.Size = New System.Drawing.Size(272, 142)
        Me.GBFiltroL.TabIndex = 7
        Me.GBFiltroL.TabStop = False
        Me.GBFiltroL.Text = "Filtrar Por Libro"
        '
        'GBGenero
        '
        Me.GBGenero.Controls.Add(Me.ComboBox3)
        Me.GBGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBGenero.Location = New System.Drawing.Point(138, 19)
        Me.GBGenero.Name = "GBGenero"
        Me.GBGenero.Size = New System.Drawing.Size(126, 52)
        Me.GBGenero.TabIndex = 14
        Me.GBGenero.TabStop = False
        Me.GBGenero.Text = "Genero"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(5, 19)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'GBAnioEdicion
        '
        Me.GBAnioEdicion.Controls.Add(Me.ComboBox1)
        Me.GBAnioEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBAnioEdicion.Location = New System.Drawing.Point(138, 82)
        Me.GBAnioEdicion.Name = "GBAnioEdicion"
        Me.GBAnioEdicion.Size = New System.Drawing.Size(126, 52)
        Me.GBAnioEdicion.TabIndex = 15
        Me.GBAnioEdicion.TabStop = False
        Me.GBAnioEdicion.Text = "Año de Edicion"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(5, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'GBEditorial
        '
        Me.GBEditorial.Controls.Add(Me.ComboBox2)
        Me.GBEditorial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBEditorial.Location = New System.Drawing.Point(6, 82)
        Me.GBEditorial.Name = "GBEditorial"
        Me.GBEditorial.Size = New System.Drawing.Size(126, 52)
        Me.GBEditorial.TabIndex = 14
        Me.GBEditorial.TabStop = False
        Me.GBEditorial.Text = "Editorial"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'GBAutores
        '
        Me.GBAutores.Controls.Add(Me.ComboBox4)
        Me.GBAutores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBAutores.Location = New System.Drawing.Point(6, 19)
        Me.GBAutores.Name = "GBAutores"
        Me.GBAutores.Size = New System.Drawing.Size(126, 52)
        Me.GBAutores.TabIndex = 13
        Me.GBAutores.TabStop = False
        Me.GBAutores.Text = "Autores"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox4.TabIndex = 13
        '
        'id_venta
        '
        Me.id_venta.HeaderText = "Id_venta"
        Me.id_venta.MinimumWidth = 6
        Me.id_venta.Name = "id_venta"
        '
        'id_cliente
        '
        Me.id_cliente.HeaderText = "Id_cliente"
        Me.id_cliente.MinimumWidth = 6
        Me.id_cliente.Name = "id_cliente"
        '
        'cod_libro
        '
        Me.cod_libro.HeaderText = "Cod_libro"
        Me.cod_libro.MinimumWidth = 6
        Me.cod_libro.Name = "cod_libro"
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        '
        'vendedor
        '
        Me.vendedor.HeaderText = "Vendedor"
        Me.vendedor.MinimumWidth = 6
        Me.vendedor.Name = "vendedor"
        '
        'FListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "FListarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltroV.ResumeLayout(False)
        Me.GBFiltroV.PerformLayout()
        Me.GBCliente.ResumeLayout(False)
        Me.GBCliente.PerformLayout()
        Me.GBFecha.ResumeLayout(False)
        Me.GBFecha.PerformLayout()
        Me.GBCod.ResumeLayout(False)
        Me.GBCod.PerformLayout()
        Me.GBVendedor.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltroL.ResumeLayout(False)
        Me.GBGenero.ResumeLayout(False)
        Me.GBAnioEdicion.ResumeLayout(False)
        Me.GBEditorial.ResumeLayout(False)
        Me.GBAutores.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltroV As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBCliente As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBFecha As GroupBox
    Friend WithEvents LHasta As Label
    Friend WithEvents LDesde As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents GBCod As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBVendedor As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltroL As GroupBox
    Friend WithEvents GBGenero As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GBAnioEdicion As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GBEditorial As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GBAutores As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents BSalir As Button
    Friend WithEvents id_venta As DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As DataGridViewTextBoxColumn
    Friend WithEvents cod_libro As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents vendedor As DataGridViewTextBoxColumn
End Class
