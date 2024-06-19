<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TUsername = New System.Windows.Forms.TextBox()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBusername = New System.Windows.Forms.GroupBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.GBContraseña = New System.Windows.Forms.GroupBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.GBTipo = New System.Windows.Forms.GroupBox()
        Me.RBVendedor = New System.Windows.Forms.RadioButton()
        Me.RBAdmin = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBusername.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GBContraseña.SuspendLayout()
        Me.GBTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.DataGridView1.Location = New System.Drawing.Point(35, 235)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(621, 207)
        Me.DataGridView1.TabIndex = 66
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Black
        Me.GBFiltrar.Controls.Add(Me.BActivar)
        Me.GBFiltrar.Controls.Add(Me.BEliminar)
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(35, 151)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(621, 77)
        Me.GBFiltrar.TabIndex = 67
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'BActivar
        '
        Me.BActivar.BackColor = System.Drawing.Color.Black
        Me.BActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivar.Location = New System.Drawing.Point(428, 20)
        Me.BActivar.Name = "BActivar"
        Me.BActivar.Size = New System.Drawing.Size(93, 27)
        Me.BActivar.TabIndex = 84
        Me.BActivar.Text = "Activar"
        Me.BActivar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Black
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.Location = New System.Drawing.Point(524, 20)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(88, 27)
        Me.BEliminar.TabIndex = 83
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(537, 50)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 82
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TUsername)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(298, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 40)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre de usuario"
        '
        'TUsername
        '
        Me.TUsername.Location = New System.Drawing.Point(9, 13)
        Me.TUsername.MaxLength = 100
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(105, 20)
        Me.TUsername.TabIndex = 1
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Checked = True
        Me.RBActivos.Location = New System.Drawing.Point(437, 50)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 81
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(152, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 40)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(9, 13)
        Me.TBDni.MaxLength = 8
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(105, 20)
        Me.TBDni.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Black
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(8, 31)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
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
        Me.BSalir.TabIndex = 75
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(356, 118)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 74
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(203, 119)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 72
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(94, 20)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(120, 40)
        Me.GBdni.TabIndex = 70
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(9, 13)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(105, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBusername
        '
        Me.GBusername.BackColor = System.Drawing.Color.Transparent
        Me.GBusername.Controls.Add(Me.TxtUsername)
        Me.GBusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBusername.Location = New System.Drawing.Point(94, 67)
        Me.GBusername.Name = "GBusername"
        Me.GBusername.Size = New System.Drawing.Size(120, 40)
        Me.GBusername.TabIndex = 77
        Me.GBusername.TabStop = False
        Me.GBusername.Text = "Nombre de usuario"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUsername.Location = New System.Drawing.Point(10, 13)
        Me.TxtUsername.MaxLength = 100
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(105, 20)
        Me.TxtUsername.TabIndex = 3
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TxtApellido)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(344, 20)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(120, 40)
        Me.GBApellido.TabIndex = 78
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtApellido.Location = New System.Drawing.Point(8, 13)
        Me.TxtApellido.MaxLength = 100
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(105, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TxtNombre)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(220, 20)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(120, 40)
        Me.GBNombre.TabIndex = 76
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNombre.Location = New System.Drawing.Point(9, 13)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(105, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'GBContraseña
        '
        Me.GBContraseña.BackColor = System.Drawing.Color.Transparent
        Me.GBContraseña.Controls.Add(Me.TxtPassword)
        Me.GBContraseña.ForeColor = System.Drawing.SystemColors.Window
        Me.GBContraseña.Location = New System.Drawing.Point(220, 67)
        Me.GBContraseña.Name = "GBContraseña"
        Me.GBContraseña.Size = New System.Drawing.Size(120, 40)
        Me.GBContraseña.TabIndex = 79
        Me.GBContraseña.TabStop = False
        Me.GBContraseña.Text = "Contraseña"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPassword.Location = New System.Drawing.Point(9, 14)
        Me.TxtPassword.MaxLength = 100
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(105, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'GBTipo
        '
        Me.GBTipo.BackColor = System.Drawing.Color.Transparent
        Me.GBTipo.Controls.Add(Me.RBVendedor)
        Me.GBTipo.Controls.Add(Me.RBAdmin)
        Me.GBTipo.ForeColor = System.Drawing.Color.White
        Me.GBTipo.Location = New System.Drawing.Point(482, 20)
        Me.GBTipo.Name = "GBTipo"
        Me.GBTipo.Size = New System.Drawing.Size(107, 62)
        Me.GBTipo.TabIndex = 80
        Me.GBTipo.TabStop = False
        Me.GBTipo.Text = "Tipo Usuario"
        '
        'RBVendedor
        '
        Me.RBVendedor.AutoSize = True
        Me.RBVendedor.Location = New System.Drawing.Point(6, 40)
        Me.RBVendedor.Name = "RBVendedor"
        Me.RBVendedor.Size = New System.Drawing.Size(71, 17)
        Me.RBVendedor.TabIndex = 2
        Me.RBVendedor.TabStop = True
        Me.RBVendedor.Text = "Vendedor"
        Me.RBVendedor.UseVisualStyleBackColor = True
        '
        'RBAdmin
        '
        Me.RBAdmin.AutoSize = True
        Me.RBAdmin.Location = New System.Drawing.Point(6, 17)
        Me.RBAdmin.Name = "RBAdmin"
        Me.RBAdmin.Size = New System.Drawing.Size(88, 17)
        Me.RBAdmin.TabIndex = 0
        Me.RBAdmin.TabStop = True
        Me.RBAdmin.Text = "Administrador"
        Me.RBAdmin.UseVisualStyleBackColor = True
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.GBTipo)
        Me.Controls.Add(Me.GBContraseña)
        Me.Controls.Add(Me.GBusername)
        Me.Controls.Add(Me.GBApellido)
        Me.Controls.Add(Me.GBNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBFiltrar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GBdni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBusername.ResumeLayout(False)
        Me.GBusername.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GBContraseña.ResumeLayout(False)
        Me.GBContraseña.PerformLayout()
        Me.GBTipo.ResumeLayout(False)
        Me.GBTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TUsername As TextBox
    Friend WithEvents GBusername As GroupBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents GBContraseña As GroupBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents GBTipo As GroupBox
    Friend WithEvents RBVendedor As RadioButton
    Friend WithEvents RBAdmin As RadioButton
    Friend WithEvents BActivar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
End Class
