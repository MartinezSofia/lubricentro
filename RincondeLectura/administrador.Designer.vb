<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrador))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PLogoVendedor = New System.Windows.Forms.Panel()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PUsuarios = New System.Windows.Forms.Panel()
        Me.BABMUsuarios = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PEditorial = New System.Windows.Forms.Panel()
        Me.BABMLibros = New System.Windows.Forms.Button()
        Me.BLibros = New System.Windows.Forms.Button()
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BLVentas = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.P = New System.Windows.Forms.Panel()
        Me.PUsuarios.SuspendLayout()
        Me.PEditorial.SuspendLayout()
        Me.PVentas.SuspendLayout()
        Me.P.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(182, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 573)
        Me.Panel1.TabIndex = 14
        '
        'PLogoVendedor
        '
        Me.PLogoVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PLogoVendedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PLogoVendedor.Name = "PLogoVendedor"
        Me.PLogoVendedor.Size = New System.Drawing.Size(182, 113)
        Me.PLogoVendedor.TabIndex = 8
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.Silver
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUsuarios.Location = New System.Drawing.Point(0, 113)
        Me.BUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BUsuarios.Size = New System.Drawing.Size(182, 27)
        Me.BUsuarios.TabIndex = 9
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PUsuarios
        '
        Me.PUsuarios.BackColor = System.Drawing.Color.White
        Me.PUsuarios.Controls.Add(Me.BABMUsuarios)
        Me.PUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PUsuarios.Location = New System.Drawing.Point(0, 140)
        Me.PUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PUsuarios.Name = "PUsuarios"
        Me.PUsuarios.Size = New System.Drawing.Size(182, 34)
        Me.PUsuarios.TabIndex = 11
        '
        'BABMUsuarios
        '
        Me.BABMUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.BABMUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BABMUsuarios.Name = "BABMUsuarios"
        Me.BABMUsuarios.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMUsuarios.Size = New System.Drawing.Size(182, 33)
        Me.BABMUsuarios.TabIndex = 0
        Me.BABMUsuarios.Text = "ABM Usuarios"
        Me.BABMUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMUsuarios.UseVisualStyleBackColor = True
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 532)
        Me.BCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BCerrarSesion.Size = New System.Drawing.Size(182, 41)
        Me.BCerrarSesion.TabIndex = 36
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'PEditorial
        '
        Me.PEditorial.Controls.Add(Me.BABMLibros)
        Me.PEditorial.Controls.Add(Me.BLibros)
        Me.PEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.PEditorial.Location = New System.Drawing.Point(0, 174)
        Me.PEditorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PEditorial.Name = "PEditorial"
        Me.PEditorial.Size = New System.Drawing.Size(182, 58)
        Me.PEditorial.TabIndex = 39
        '
        'BABMLibros
        '
        Me.BABMLibros.BackColor = System.Drawing.Color.White
        Me.BABMLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMLibros.Location = New System.Drawing.Point(0, 30)
        Me.BABMLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BABMLibros.Name = "BABMLibros"
        Me.BABMLibros.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMLibros.Size = New System.Drawing.Size(182, 28)
        Me.BABMLibros.TabIndex = 34
        Me.BABMLibros.Text = "ABM Productos"
        Me.BABMLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMLibros.UseVisualStyleBackColor = False
        '
        'BLibros
        '
        Me.BLibros.BackColor = System.Drawing.Color.Silver
        Me.BLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLibros.FlatAppearance.BorderSize = 0
        Me.BLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLibros.Location = New System.Drawing.Point(0, 0)
        Me.BLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLibros.Name = "BLibros"
        Me.BLibros.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BLibros.Size = New System.Drawing.Size(182, 30)
        Me.BLibros.TabIndex = 35
        Me.BLibros.Text = "Productos"
        Me.BLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLibros.UseVisualStyleBackColor = False
        '
        'PVentas
        '
        Me.PVentas.Controls.Add(Me.Button1)
        Me.PVentas.Controls.Add(Me.Button2)
        Me.PVentas.Controls.Add(Me.Panel2)
        Me.PVentas.Controls.Add(Me.BLVentas)
        Me.PVentas.Controls.Add(Me.BVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PVentas.Location = New System.Drawing.Point(0, 232)
        Me.PVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(182, 122)
        Me.PVentas.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 87)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(182, 33)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Registrar turno"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 60)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(182, 27)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Turnos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 62)
        Me.Panel2.TabIndex = 41
        '
        'BLVentas
        '
        Me.BLVentas.BackColor = System.Drawing.Color.White
        Me.BLVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLVentas.Location = New System.Drawing.Point(0, 27)
        Me.BLVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLVentas.Name = "BLVentas"
        Me.BLVentas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLVentas.Size = New System.Drawing.Size(182, 33)
        Me.BLVentas.TabIndex = 34
        Me.BLVentas.Text = "Lista de Ventas"
        Me.BLVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLVentas.UseVisualStyleBackColor = False
        '
        'BVentas
        '
        Me.BVentas.BackColor = System.Drawing.Color.Silver
        Me.BVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentas.FlatAppearance.BorderSize = 0
        Me.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVentas.Location = New System.Drawing.Point(0, 0)
        Me.BVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BVentas.Size = New System.Drawing.Size(182, 27)
        Me.BVentas.TabIndex = 35
        Me.BVentas.Text = "Ventas"
        Me.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'P
        '
        Me.P.AutoScroll = True
        Me.P.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.P.Controls.Add(Me.PVentas)
        Me.P.Controls.Add(Me.PEditorial)
        Me.P.Controls.Add(Me.BCerrarSesion)
        Me.P.Controls.Add(Me.PUsuarios)
        Me.P.Controls.Add(Me.BUsuarios)
        Me.P.Controls.Add(Me.PLogoVendedor)
        Me.P.Dock = System.Windows.Forms.DockStyle.Left
        Me.P.Location = New System.Drawing.Point(0, 0)
        Me.P.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(182, 573)
        Me.P.TabIndex = 11
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 573)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.P)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(345, 160)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1130, 650)
        Me.MinimumSize = New System.Drawing.Size(1125, 600)
        Me.Name = "administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administrador"
        Me.PUsuarios.ResumeLayout(False)
        Me.PEditorial.ResumeLayout(False)
        Me.PVentas.ResumeLayout(False)
        Me.P.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PLogoVendedor As Panel
    Friend WithEvents BUsuarios As Button
    Friend WithEvents PUsuarios As Panel
    Friend WithEvents BABMUsuarios As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents PEditorial As Panel
    Friend WithEvents BABMLibros As Button
    Friend WithEvents BLibros As Button
    Friend WithEvents PVentas As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BLVentas As Button
    Friend WithEvents BVentas As Button
    Friend WithEvents P As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
