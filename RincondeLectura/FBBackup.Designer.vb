<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBBackup
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.txtDescrip_Backup = New System.Windows.Forms.TextBox()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom_Backup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDirPathBackup = New System.Windows.Forms.TextBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.TRuta = New System.Windows.Forms.TextBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnBackup)
        Me.Panel1.Controls.Add(Me.TRuta)
        Me.Panel1.Controls.Add(Me.BExaminar)
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 562)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(442, 337)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 27)
        Me.btnSalir.TabIndex = 140
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtServidor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnExaminar)
        Me.GroupBox1.Controls.Add(Me.txtDescrip_Backup)
        Me.GroupBox1.Controls.Add(Me.cboBaseDatos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNom_Backup)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDirPathBackup)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(50, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(800, 214)
        Me.GroupBox1.TabIndex = 139
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Backup"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(397, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 28)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(143, 28)
        Me.txtServidor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(245, 22)
        Me.txtServidor.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Servidor Local :"
        '
        'btnExaminar
        '
        Me.btnExaminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExaminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExaminar.Location = New System.Drawing.Point(689, 58)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(77, 28)
        Me.btnExaminar.TabIndex = 21
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'txtDescrip_Backup
        '
        Me.txtDescrip_Backup.Location = New System.Drawing.Point(140, 117)
        Me.txtDescrip_Backup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescrip_Backup.MaxLength = 100
        Me.txtDescrip_Backup.Multiline = True
        Me.txtDescrip_Backup.Name = "txtDescrip_Backup"
        Me.txtDescrip_Backup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrip_Backup.Size = New System.Drawing.Size(625, 75)
        Me.txtDescrip_Backup.TabIndex = 29
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(527, 28)
        Me.cboBaseDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(239, 24)
        Me.cboBaseDatos.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(27, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Observación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "BDs:"
        '
        'txtNom_Backup
        '
        Me.txtNom_Backup.Location = New System.Drawing.Point(140, 89)
        Me.txtNom_Backup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom_Backup.MaxLength = 20
        Me.txtNom_Backup.Name = "txtNom_Backup"
        Me.txtNom_Backup.Size = New System.Drawing.Size(625, 22)
        Me.txtNom_Backup.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(27, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Directorio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(27, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre Backup:"
        '
        'txtDirPathBackup
        '
        Me.txtDirPathBackup.Enabled = False
        Me.txtDirPathBackup.Location = New System.Drawing.Point(140, 62)
        Me.txtDirPathBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirPathBackup.Name = "txtDirPathBackup"
        Me.txtDirPathBackup.Size = New System.Drawing.Size(540, 22)
        Me.txtDirPathBackup.TabIndex = 25
        '
        'btnBackup
        '
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.Location = New System.Drawing.Point(325, 337)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(111, 27)
        Me.btnBackup.TabIndex = 138
        Me.btnBackup.Text = "Crear Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'TRuta
        '
        Me.TRuta.Location = New System.Drawing.Point(97, 175)
        Me.TRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.TRuta.Name = "TRuta"
        Me.TRuta.Size = New System.Drawing.Size(399, 22)
        Me.TRuta.TabIndex = 132
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExaminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BExaminar.Location = New System.Drawing.Point(521, 173)
        Me.BExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(156, 33)
        Me.BExaminar.TabIndex = 131
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BCancelar.Location = New System.Drawing.Point(118, 226)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(156, 33)
        Me.BCancelar.TabIndex = 130
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BGuardar.Location = New System.Drawing.Point(341, 227)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(156, 33)
        Me.BGuardar.TabIndex = 129
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(17, 16)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(33, 32)
        Me.BSalir.TabIndex = 141
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'FBBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 562)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(917, 562)
        Me.MinimumSize = New System.Drawing.Size(917, 562)
        Me.Name = "FBBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Backup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TRuta As TextBox
    Friend WithEvents BExaminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExaminar As Button
    Friend WithEvents txtDescrip_Backup As TextBox
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom_Backup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDirPathBackup As TextBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents BSalir As Button
End Class
