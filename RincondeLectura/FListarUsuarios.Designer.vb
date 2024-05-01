<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListarUsuarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBtodos = New System.Windows.Forms.RadioButton()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBusername = New System.Windows.Forms.GroupBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBusername.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBApellido.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
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
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 67
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBtodos)
        Me.GBFiltrar.Controls.Add(Me.GBdni)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBusername)
        Me.GBFiltrar.Controls.Add(Me.GBApellido)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(19, 65)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(649, 99)
        Me.GBFiltrar.TabIndex = 8
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBtodos
        '
        Me.RBtodos.AutoSize = True
        Me.RBtodos.Location = New System.Drawing.Point(9, 29)
        Me.RBtodos.Name = "RBtodos"
        Me.RBtodos.Size = New System.Drawing.Size(115, 17)
        Me.RBtodos.TabIndex = 26
        Me.RBtodos.TabStop = True
        Me.RBtodos.Text = "Todos los Usuarios"
        Me.RBtodos.UseVisualStyleBackColor = True
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TBDni)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdni.Location = New System.Drawing.Point(130, 30)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(125, 51)
        Me.GBdni.TabIndex = 5
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(9, 54)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(113, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBusername
        '
        Me.GBusername.BackColor = System.Drawing.Color.Transparent
        Me.GBusername.Controls.Add(Me.TBUsername)
        Me.GBusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBusername.Location = New System.Drawing.Point(517, 30)
        Me.GBusername.Name = "GBusername"
        Me.GBusername.Size = New System.Drawing.Size(123, 51)
        Me.GBusername.TabIndex = 3
        Me.GBusername.TabStop = False
        Me.GBusername.Text = "Nombre de Usuario"
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TBNombre)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(260, 30)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(123, 51)
        Me.GBNombre.TabIndex = 2
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(19, 174)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(649, 256)
        Me.DataGridView1.TabIndex = 7
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TBApellido)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(388, 30)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(124, 51)
        Me.GBApellido.TabIndex = 4
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TBDni
        '
        Me.TBDni.BackColor = System.Drawing.SystemColors.Window
        Me.TBDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBDni.Location = New System.Drawing.Point(10, 15)
        Me.TBDni.MaxLength = 8
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(105, 20)
        Me.TBDni.TabIndex = 3
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TBNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBNombre.Location = New System.Drawing.Point(9, 15)
        Me.TBNombre.MaxLength = 8
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(105, 20)
        Me.TBNombre.TabIndex = 3
        '
        'TBApellido
        '
        Me.TBApellido.BackColor = System.Drawing.SystemColors.Window
        Me.TBApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBApellido.Location = New System.Drawing.Point(10, 15)
        Me.TBApellido.MaxLength = 8
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(105, 20)
        Me.TBApellido.TabIndex = 3
        '
        'TBUsername
        '
        Me.TBUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TBUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBUsername.Location = New System.Drawing.Point(9, 15)
        Me.TBUsername.MaxLength = 8
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(105, 20)
        Me.TBUsername.TabIndex = 3
        '
        'FListarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "FListarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBusername.ResumeLayout(False)
        Me.GBusername.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBtodos As RadioButton
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBusername As GroupBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents TBDni As TextBox
    Friend WithEvents TBUsername As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
End Class
