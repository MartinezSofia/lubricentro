<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FModMiusuario
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GBRPass = New System.Windows.Forms.GroupBox()
        Me.LEtiqueta2 = New System.Windows.Forms.Label()
        Me.TxtContraseña2 = New System.Windows.Forms.TextBox()
        Me.GBPass = New System.Windows.Forms.GroupBox()
        Me.LEtiqueta1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LEtiqueta = New System.Windows.Forms.Label()
        Me.GBUsername = New System.Windows.Forms.GroupBox()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PBAvatar = New System.Windows.Forms.PictureBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.GBTipo = New System.Windows.Forms.GroupBox()
        Me.RBGerente = New System.Windows.Forms.RadioButton()
        Me.RBAdmin = New System.Windows.Forms.RadioButton()
        Me.RBEmpleado = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.GBRPass.SuspendLayout()
        Me.GBPass.SuspendLayout()
        Me.GBUsername.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.GBRPass)
        Me.Panel1.Controls.Add(Me.GBPass)
        Me.Panel1.Controls.Add(Me.GBUsername)
        Me.Panel1.Controls.Add(Me.GBdni)
        Me.Panel1.Controls.Add(Me.GBApellido)
        Me.Panel1.Controls.Add(Me.GBNombre)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GBTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(453, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 27)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GBRPass
        '
        Me.GBRPass.BackColor = System.Drawing.Color.Transparent
        Me.GBRPass.Controls.Add(Me.LEtiqueta2)
        Me.GBRPass.Controls.Add(Me.TxtContraseña2)
        Me.GBRPass.ForeColor = System.Drawing.SystemColors.Window
        Me.GBRPass.Location = New System.Drawing.Point(205, 356)
        Me.GBRPass.Name = "GBRPass"
        Me.GBRPass.Size = New System.Drawing.Size(199, 80)
        Me.GBRPass.TabIndex = 46
        Me.GBRPass.TabStop = False
        Me.GBRPass.Text = "Repetir Contraseña"
        '
        'LEtiqueta2
        '
        Me.LEtiqueta2.Location = New System.Drawing.Point(7, 46)
        Me.LEtiqueta2.Name = "LEtiqueta2"
        Me.LEtiqueta2.Size = New System.Drawing.Size(186, 29)
        Me.LEtiqueta2.TabIndex = 42
        Me.LEtiqueta2.Text = " "
        '
        'TxtContraseña2
        '
        Me.TxtContraseña2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtContraseña2.Location = New System.Drawing.Point(10, 21)
        Me.TxtContraseña2.Name = "TxtContraseña2"
        Me.TxtContraseña2.Size = New System.Drawing.Size(175, 20)
        Me.TxtContraseña2.TabIndex = 6
        '
        'GBPass
        '
        Me.GBPass.BackColor = System.Drawing.Color.Transparent
        Me.GBPass.Controls.Add(Me.LEtiqueta1)
        Me.GBPass.Controls.Add(Me.TxtContraseña)
        Me.GBPass.Controls.Add(Me.LEtiqueta)
        Me.GBPass.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPass.Location = New System.Drawing.Point(206, 267)
        Me.GBPass.Name = "GBPass"
        Me.GBPass.Size = New System.Drawing.Size(199, 80)
        Me.GBPass.TabIndex = 49
        Me.GBPass.TabStop = False
        Me.GBPass.Text = "Contraseña"
        '
        'LEtiqueta1
        '
        Me.LEtiqueta1.Location = New System.Drawing.Point(6, 48)
        Me.LEtiqueta1.Name = "LEtiqueta1"
        Me.LEtiqueta1.Size = New System.Drawing.Size(186, 29)
        Me.LEtiqueta1.TabIndex = 43
        Me.LEtiqueta1.Text = " "
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtContraseña.Location = New System.Drawing.Point(9, 21)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(175, 20)
        Me.TxtContraseña.TabIndex = 4
        '
        'LEtiqueta
        '
        Me.LEtiqueta.AutoSize = True
        Me.LEtiqueta.Location = New System.Drawing.Point(16, 46)
        Me.LEtiqueta.Name = "LEtiqueta"
        Me.LEtiqueta.Size = New System.Drawing.Size(0, 13)
        Me.LEtiqueta.TabIndex = 41
        '
        'GBUsername
        '
        Me.GBUsername.BackColor = System.Drawing.Color.Transparent
        Me.GBUsername.Controls.Add(Me.Txtusuario)
        Me.GBUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.GBUsername.Location = New System.Drawing.Point(206, 204)
        Me.GBUsername.Name = "GBUsername"
        Me.GBUsername.Size = New System.Drawing.Size(167, 57)
        Me.GBUsername.TabIndex = 48
        Me.GBUsername.TabStop = False
        Me.GBUsername.Text = "Nombre de Usuario"
        '
        'Txtusuario
        '
        Me.Txtusuario.BackColor = System.Drawing.SystemColors.Window
        Me.Txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtusuario.Location = New System.Drawing.Point(17, 21)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(134, 20)
        Me.Txtusuario.TabIndex = 3
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(206, 141)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(167, 57)
        Me.GBdni.TabIndex = 47
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
        Me.TxtDNI.TabIndex = 2
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TxtApe)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.Window
        Me.GBApellido.Location = New System.Drawing.Point(205, 78)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(167, 57)
        Me.GBApellido.TabIndex = 44
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
        Me.TxtApe.TabIndex = 1
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TxtNom)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNombre.Location = New System.Drawing.Point(206, 15)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(167, 57)
        Me.GBNombre.TabIndex = 43
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
        Me.TxtNom.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(453, 402)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.PBAvatar)
        Me.GroupBox6.Controls.Add(Me.BExaminar)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox6.Location = New System.Drawing.Point(402, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(193, 212)
        Me.GroupBox6.TabIndex = 45
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Foto del Usuario"
        '
        'PBAvatar
        '
        Me.PBAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBAvatar.Location = New System.Drawing.Point(27, 31)
        Me.PBAvatar.Name = "PBAvatar"
        Me.PBAvatar.Size = New System.Drawing.Size(144, 126)
        Me.PBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAvatar.TabIndex = 16
        Me.PBAvatar.TabStop = False
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Location = New System.Drawing.Point(36, 170)
        Me.BExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(117, 27)
        Me.BExaminar.TabIndex = 7
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'GBTipo
        '
        Me.GBTipo.BackColor = System.Drawing.Color.Transparent
        Me.GBTipo.Controls.Add(Me.RBGerente)
        Me.GBTipo.Controls.Add(Me.RBAdmin)
        Me.GBTipo.Controls.Add(Me.RBEmpleado)
        Me.GBTipo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTipo.Location = New System.Drawing.Point(438, 244)
        Me.GBTipo.Name = "GBTipo"
        Me.GBTipo.Size = New System.Drawing.Size(144, 103)
        Me.GBTipo.TabIndex = 50
        Me.GBTipo.TabStop = False
        Me.GBTipo.Text = "Tipo de Usuario"
        '
        'RBGerente
        '
        Me.RBGerente.AutoSize = True
        Me.RBGerente.Location = New System.Drawing.Point(27, 47)
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
        Me.RBAdmin.Location = New System.Drawing.Point(27, 23)
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
        Me.RBEmpleado.Location = New System.Drawing.Point(27, 71)
        Me.RBEmpleado.Name = "RBEmpleado"
        Me.RBEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.RBEmpleado.TabIndex = 10
        Me.RBEmpleado.TabStop = True
        Me.RBEmpleado.Text = "Empleado"
        Me.RBEmpleado.UseVisualStyleBackColor = True
        '
        'FModMiusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FModMiusuario"
        Me.Text = "Mi usuario"
        Me.Panel1.ResumeLayout(False)
        Me.GBRPass.ResumeLayout(False)
        Me.GBRPass.PerformLayout()
        Me.GBPass.ResumeLayout(False)
        Me.GBPass.PerformLayout()
        Me.GBUsername.ResumeLayout(False)
        Me.GBUsername.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTipo.ResumeLayout(False)
        Me.GBTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents GBRPass As GroupBox
    Friend WithEvents LEtiqueta2 As Label
    Friend WithEvents TxtContraseña2 As TextBox
    Friend WithEvents GBPass As GroupBox
    Friend WithEvents LEtiqueta1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LEtiqueta As Label
    Friend WithEvents GBUsername As GroupBox
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PBAvatar As PictureBox
    Friend WithEvents BExaminar As Button
    Friend WithEvents GBTipo As GroupBox
    Friend WithEvents RBGerente As RadioButton
    Friend WithEvents RBAdmin As RadioButton
    Friend WithEvents RBEmpleado As RadioButton
End Class
