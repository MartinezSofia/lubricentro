<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBDescripcion = New System.Windows.Forms.GroupBox()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.GBPrecio = New System.Windows.Forms.GroupBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.GBStock = New System.Windows.Forms.GroupBox()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBIDProd = New System.Windows.Forms.GroupBox()
        Me.TBIdproducto = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBFiltro = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TIdproducto = New System.Windows.Forms.TextBox()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.GBDescripcion.SuspendLayout()
        Me.GBPrecio.SuspendLayout()
        Me.GBStock.SuspendLayout()
        Me.GBIDProd.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.SuspendLayout()
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 99
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBDescripcion
        '
        Me.GBDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.GBDescripcion.Controls.Add(Me.TBDescripcion)
        Me.GBDescripcion.ForeColor = System.Drawing.Color.White
        Me.GBDescripcion.Location = New System.Drawing.Point(289, 56)
        Me.GBDescripcion.Name = "GBDescripcion"
        Me.GBDescripcion.Size = New System.Drawing.Size(157, 85)
        Me.GBDescripcion.TabIndex = 91
        Me.GBDescripcion.TabStop = False
        Me.GBDescripcion.Text = "Descripcion"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(6, 14)
        Me.TBDescripcion.Multiline = True
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(145, 64)
        Me.TBDescripcion.TabIndex = 94
        '
        'GBPrecio
        '
        Me.GBPrecio.BackColor = System.Drawing.Color.Transparent
        Me.GBPrecio.Controls.Add(Me.TBPrecio)
        Me.GBPrecio.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPrecio.Location = New System.Drawing.Point(18, 99)
        Me.GBPrecio.Name = "GBPrecio"
        Me.GBPrecio.Size = New System.Drawing.Size(120, 40)
        Me.GBPrecio.TabIndex = 83
        Me.GBPrecio.TabStop = False
        Me.GBPrecio.Text = "Precio"
        '
        'TBPrecio
        '
        Me.TBPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.TBPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBPrecio.Location = New System.Drawing.Point(9, 14)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(105, 20)
        Me.TBPrecio.TabIndex = 3
        '
        'GBStock
        '
        Me.GBStock.BackColor = System.Drawing.Color.Transparent
        Me.GBStock.Controls.Add(Me.TBStock)
        Me.GBStock.ForeColor = System.Drawing.SystemColors.Window
        Me.GBStock.Location = New System.Drawing.Point(152, 100)
        Me.GBStock.Name = "GBStock"
        Me.GBStock.Size = New System.Drawing.Size(120, 40)
        Me.GBStock.TabIndex = 85
        Me.GBStock.TabStop = False
        Me.GBStock.Text = "Stock"
        '
        'TBStock
        '
        Me.TBStock.BackColor = System.Drawing.SystemColors.Window
        Me.TBStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBStock.Location = New System.Drawing.Point(8, 14)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(105, 20)
        Me.TBStock.TabIndex = 3
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(490, 100)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 86
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(490, 60)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 84
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBIDProd
        '
        Me.GBIDProd.BackColor = System.Drawing.Color.Transparent
        Me.GBIDProd.Controls.Add(Me.TBIdproducto)
        Me.GBIDProd.ForeColor = System.Drawing.SystemColors.Window
        Me.GBIDProd.Location = New System.Drawing.Point(18, 54)
        Me.GBIDProd.Name = "GBIDProd"
        Me.GBIDProd.Size = New System.Drawing.Size(120, 40)
        Me.GBIDProd.TabIndex = 82
        Me.GBIDProd.TabStop = False
        Me.GBIDProd.Text = "Id Producto"
        '
        'TBIdproducto
        '
        Me.TBIdproducto.BackColor = System.Drawing.SystemColors.Window
        Me.TBIdproducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBIdproducto.Location = New System.Drawing.Point(9, 13)
        Me.TBIdproducto.MaxLength = 8
        Me.TBIdproducto.Name = "TBIdproducto"
        Me.TBIdproducto.Size = New System.Drawing.Size(105, 20)
        Me.TBIdproducto.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 263)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(664, 182)
        Me.DataGridView1.TabIndex = 101
        '
        'GBFiltro
        '
        Me.GBFiltro.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltro.Controls.Add(Me.GroupBox2)
        Me.GBFiltro.Controls.Add(Me.GroupBox1)
        Me.GBFiltro.Controls.Add(Me.BActivar)
        Me.GBFiltro.Controls.Add(Me.BEliminar)
        Me.GBFiltro.Controls.Add(Me.RBEliminados)
        Me.GBFiltro.Controls.Add(Me.RBActivos)
        Me.GBFiltro.Controls.Add(Me.BBuscar)
        Me.GBFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltro.Location = New System.Drawing.Point(12, 178)
        Me.GBFiltro.Name = "GBFiltro"
        Me.GBFiltro.Size = New System.Drawing.Size(664, 79)
        Me.GBFiltro.TabIndex = 100
        Me.GBFiltro.TabStop = False
        Me.GBFiltro.Text = "Filtrar Por"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TNombre)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(251, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre"
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TNombre.Location = New System.Drawing.Point(9, 13)
        Me.TNombre.MaxLength = 8
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(105, 20)
        Me.TNombre.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TIdproducto)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(125, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Id Producto"
        '
        'TIdproducto
        '
        Me.TIdproducto.BackColor = System.Drawing.SystemColors.Window
        Me.TIdproducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TIdproducto.Location = New System.Drawing.Point(9, 13)
        Me.TIdproducto.MaxLength = 8
        Me.TIdproducto.Name = "TIdproducto"
        Me.TIdproducto.Size = New System.Drawing.Size(105, 20)
        Me.TIdproducto.TabIndex = 2
        '
        'BActivar
        '
        Me.BActivar.BackColor = System.Drawing.Color.Black
        Me.BActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivar.Location = New System.Drawing.Point(496, 21)
        Me.BActivar.Name = "BActivar"
        Me.BActivar.Size = New System.Drawing.Size(79, 27)
        Me.BActivar.TabIndex = 94
        Me.BActivar.Text = "Activar"
        Me.BActivar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Black
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.Location = New System.Drawing.Point(582, 21)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 27)
        Me.BEliminar.TabIndex = 93
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(582, 52)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 92
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Checked = True
        Me.RBActivos.Location = New System.Drawing.Point(508, 51)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 91
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(9, 31)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(98, 27)
        Me.BBuscar.TabIndex = 21
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TBNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBNombre.Location = New System.Drawing.Point(9, 13)
        Me.TBNombre.MaxLength = 8
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(105, 20)
        Me.TBNombre.TabIndex = 3
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TBNombre)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(154, 54)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(120, 40)
        Me.GBNombre.TabIndex = 87
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'ABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBFiltro)
        Me.Controls.Add(Me.GBDescripcion)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.GBPrecio)
        Me.Controls.Add(Me.GBIDProd)
        Me.Controls.Add(Me.GBNombre)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GBStock)
        Me.Controls.Add(Me.BModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ABMLibros"
        Me.GBDescripcion.ResumeLayout(False)
        Me.GBDescripcion.PerformLayout()
        Me.GBPrecio.ResumeLayout(False)
        Me.GBPrecio.PerformLayout()
        Me.GBStock.ResumeLayout(False)
        Me.GBStock.PerformLayout()
        Me.GBIDProd.ResumeLayout(False)
        Me.GBIDProd.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltro.ResumeLayout(False)
        Me.GBFiltro.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSalir As Button
    Friend WithEvents GBDescripcion As GroupBox
    Friend WithEvents GBPrecio As GroupBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents GBStock As GroupBox
    Friend WithEvents TBStock As TextBox
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBIDProd As GroupBox
    Friend WithEvents TBIdproducto As TextBox
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltro As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents BActivar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TIdproducto As TextBox
End Class
