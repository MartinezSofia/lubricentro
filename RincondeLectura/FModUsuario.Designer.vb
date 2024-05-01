<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FModUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.GBtipo = New System.Windows.Forms.GroupBox()
        Me.RBGerente = New System.Windows.Forms.RadioButton()
        Me.RBAdmin = New System.Windows.Forms.RadioButton()
        Me.RBEmpleado = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GBtipo.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.GBdni)
        Me.Panel1.Controls.Add(Me.GBApellido)
        Me.Panel1.Controls.Add(Me.GBNombre)
        Me.Panel1.Controls.Add(Me.BModificar)
        Me.Panel1.Controls.Add(Me.BCerrar)
        Me.Panel1.Controls.Add(Me.GBtipo)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 502)
        Me.Panel1.TabIndex = 0
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BEliminar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.BEliminar.Location = New System.Drawing.Point(446, 345)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(117, 27)
        Me.BEliminar.TabIndex = 42
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(203, 248)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(167, 57)
        Me.GBdni.TabIndex = 48
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(18, 21)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(133, 20)
        Me.TxtDNI.TabIndex = 3
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TxtApe)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.Window
        Me.GBApellido.Location = New System.Drawing.Point(203, 171)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(167, 57)
        Me.GBApellido.TabIndex = 45
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TxtApe
        '
        Me.TxtApe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtApe.Location = New System.Drawing.Point(18, 21)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(134, 20)
        Me.TxtApe.TabIndex = 2
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TxtNom)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNombre.Location = New System.Drawing.Point(203, 93)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(167, 57)
        Me.GBNombre.TabIndex = 44
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNom.Location = New System.Drawing.Point(17, 21)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(134, 20)
        Me.TxtNom.TabIndex = 1
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(446, 396)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(117, 27)
        Me.BModificar.TabIndex = 41
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BCerrar.Location = New System.Drawing.Point(334, 457)
        Me.BCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(117, 27)
        Me.BCerrar.TabIndex = 43
        Me.BCerrar.Text = "Cancelar"
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'GBtipo
        '
        Me.GBtipo.BackColor = System.Drawing.Color.Transparent
        Me.GBtipo.Controls.Add(Me.RBGerente)
        Me.GBtipo.Controls.Add(Me.RBAdmin)
        Me.GBtipo.Controls.Add(Me.RBEmpleado)
        Me.GBtipo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBtipo.Location = New System.Drawing.Point(210, 328)
        Me.GBtipo.Name = "GBtipo"
        Me.GBtipo.Size = New System.Drawing.Size(144, 103)
        Me.GBtipo.TabIndex = 49
        Me.GBtipo.TabStop = False
        Me.GBtipo.Text = "Tipo de Usuario"
        '
        'RBGerente
        '
        Me.RBGerente.AutoSize = True
        Me.RBGerente.Location = New System.Drawing.Point(27, 44)
        Me.RBGerente.Name = "RBGerente"
        Me.RBGerente.Size = New System.Drawing.Size(63, 17)
        Me.RBGerente.TabIndex = 12
        Me.RBGerente.TabStop = True
        Me.RBGerente.Text = "Gerente"
        Me.RBGerente.UseVisualStyleBackColor = True
        '
        'RBAdmin
        '
        Me.RBAdmin.AutoSize = True
        Me.RBAdmin.Location = New System.Drawing.Point(27, 21)
        Me.RBAdmin.Name = "RBAdmin"
        Me.RBAdmin.Size = New System.Drawing.Size(88, 17)
        Me.RBAdmin.TabIndex = 8
        Me.RBAdmin.TabStop = True
        Me.RBAdmin.Text = "Administrador"
        Me.RBAdmin.UseVisualStyleBackColor = True
        '
        'RBEmpleado
        '
        Me.RBEmpleado.AutoSize = True
        Me.RBEmpleado.Location = New System.Drawing.Point(27, 68)
        Me.RBEmpleado.Name = "RBEmpleado"
        Me.RBEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.RBEmpleado.TabIndex = 10
        Me.RBEmpleado.TabStop = True
        Me.RBEmpleado.Text = "Empleado"
        Me.RBEmpleado.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.ComboBox1)
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox8.Location = New System.Drawing.Point(246, 18)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(302, 57)
        Me.GroupBox8.TabIndex = 47
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Usuario"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(269, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'FModUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FModUsuario"
        Me.Text = "Modificar Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GBtipo.ResumeLayout(False)
        Me.GBtipo.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BEliminar As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents BModificar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents GBtipo As GroupBox
    Friend WithEvents RBGerente As RadioButton
    Friend WithEvents RBAdmin As RadioButton
    Friend WithEvents RBEmpleado As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
