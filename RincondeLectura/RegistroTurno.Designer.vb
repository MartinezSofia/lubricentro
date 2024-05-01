<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroTurno
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TBPatente = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CBHora = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBModelo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBMarca = New System.Windows.Forms.TextBox()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtPatente = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CBFHora = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GBDireccion = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.GBNyA = New System.Windows.Forms.GroupBox()
        Me.TxtNyA = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GBNyA.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.BModificar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.GBdni)
        Me.Panel1.Controls.Add(Me.GBTelefono)
        Me.Panel1.Controls.Add(Me.GBDireccion)
        Me.Panel1.Controls.Add(Me.GBNyA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 457)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.TBPatente)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox7.Location = New System.Drawing.Point(48, 73)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(159, 49)
        Me.GroupBox7.TabIndex = 60
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Patente"
        '
        'TBPatente
        '
        Me.TBPatente.BackColor = System.Drawing.SystemColors.Window
        Me.TBPatente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBPatente.Location = New System.Drawing.Point(15, 19)
        Me.TBPatente.Name = "TBPatente"
        Me.TBPatente.Size = New System.Drawing.Size(134, 20)
        Me.TBPatente.TabIndex = 3
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.CBHora)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox6.Location = New System.Drawing.Point(182, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 49)
        Me.GroupBox6.TabIndex = 67
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Hora"
        '
        'CBHora
        '
        Me.CBHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBHora.FormattingEnabled = True
        Me.CBHora.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.CBHora.Location = New System.Drawing.Point(6, 17)
        Me.CBHora.Name = "CBHora"
        Me.CBHora.Size = New System.Drawing.Size(99, 21)
        Me.CBHora.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DTFecha)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox5.Location = New System.Drawing.Point(48, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 49)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(15, 19)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(102, 20)
        Me.DTFecha.TabIndex = 66
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TBModelo)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(378, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(159, 49)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modelo"
        '
        'TBModelo
        '
        Me.TBModelo.BackColor = System.Drawing.SystemColors.Window
        Me.TBModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBModelo.Location = New System.Drawing.Point(15, 19)
        Me.TBModelo.Name = "TBModelo"
        Me.TBModelo.Size = New System.Drawing.Size(134, 20)
        Me.TBModelo.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TBMarca)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(213, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 49)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marca"
        '
        'TBMarca
        '
        Me.TBMarca.BackColor = System.Drawing.SystemColors.Window
        Me.TBMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TBMarca.Location = New System.Drawing.Point(15, 19)
        Me.TBMarca.Name = "TBMarca"
        Me.TBMarca.Size = New System.Drawing.Size(134, 20)
        Me.TBMarca.TabIndex = 3
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Black
        Me.GBFiltrar.Controls.Add(Me.GroupBox8)
        Me.GBFiltrar.Controls.Add(Me.GroupBox9)
        Me.GBFiltrar.Controls.Add(Me.GroupBox4)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(32, 183)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(622, 77)
        Me.GBFiltrar.TabIndex = 11
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.TxtPatente)
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox8.Location = New System.Drawing.Point(215, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(146, 49)
        Me.GroupBox8.TabIndex = 61
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Patente"
        '
        'TxtPatente
        '
        Me.TxtPatente.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPatente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPatente.Location = New System.Drawing.Point(6, 17)
        Me.TxtPatente.Name = "TxtPatente"
        Me.TxtPatente.Size = New System.Drawing.Size(134, 20)
        Me.TxtPatente.TabIndex = 3
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.CBFHora)
        Me.GroupBox9.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox9.Location = New System.Drawing.Point(492, 16)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(114, 49)
        Me.GroupBox9.TabIndex = 68
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Hora"
        '
        'CBFHora
        '
        Me.CBFHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFHora.FormattingEnabled = True
        Me.CBFHora.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.CBFHora.Location = New System.Drawing.Point(6, 17)
        Me.CBFHora.Name = "CBFHora"
        Me.CBFHora.Size = New System.Drawing.Size(99, 21)
        Me.CBFHora.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.DTPFecha)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(367, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 51)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fecha"
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(6, 20)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(97, 20)
        Me.DTPFecha.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(104, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 51)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(6, 20)
        Me.TBDni.MaxLength = 8
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(95, 20)
        Me.TBDni.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Black
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(16, 29)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(82, 27)
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
        Me.BSalir.TabIndex = 65
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
        Me.BModificar.Location = New System.Drawing.Point(517, 140)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(93, 27)
        Me.BModificar.TabIndex = 64
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(422, 141)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(85, 27)
        Me.BGuardar.TabIndex = 61
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(48, 17)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(128, 49)
        Me.GBdni.TabIndex = 56
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(15, 18)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(102, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TxtTelefono)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTelefono.Location = New System.Drawing.Point(517, 17)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(148, 49)
        Me.GBTelefono.TabIndex = 58
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefono.Location = New System.Drawing.Point(7, 19)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(134, 20)
        Me.TxtTelefono.TabIndex = 3
        '
        'GBDireccion
        '
        Me.GBDireccion.BackColor = System.Drawing.Color.Transparent
        Me.GBDireccion.Controls.Add(Me.TxtDireccion)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.GBDireccion.Location = New System.Drawing.Point(348, 17)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(159, 49)
        Me.GBDireccion.TabIndex = 54
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDireccion.Location = New System.Drawing.Point(15, 18)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(134, 20)
        Me.TxtDireccion.TabIndex = 1
        '
        'GBNyA
        '
        Me.GBNyA.BackColor = System.Drawing.Color.Transparent
        Me.GBNyA.Controls.Add(Me.TxtNyA)
        Me.GBNyA.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNyA.Location = New System.Drawing.Point(182, 17)
        Me.GBNyA.Name = "GBNyA"
        Me.GBNyA.Size = New System.Drawing.Size(159, 49)
        Me.GBNyA.TabIndex = 53
        Me.GBNyA.TabStop = False
        Me.GBNyA.Text = "Nombre y Apellido"
        '
        'TxtNyA
        '
        Me.TxtNyA.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNyA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNyA.Location = New System.Drawing.Point(15, 18)
        Me.TxtNyA.Name = "TxtNyA"
        Me.TxtNyA.Size = New System.Drawing.Size(134, 20)
        Me.TxtNyA.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 457)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 604)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 266)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(215, 179)
        Me.DataGridView1.TabIndex = 10
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(435, 266)
        Me.DataGridView3.Name = "DataGridView3"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(219, 179)
        Me.DataGridView3.TabIndex = 69
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(247, 266)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(190, 179)
        Me.DataGridView2.TabIndex = 68
        '
        'RegistroTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "RegistroTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBDireccion.ResumeLayout(False)
        Me.GBDireccion.PerformLayout()
        Me.GBNyA.ResumeLayout(False)
        Me.GBNyA.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GBDireccion As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents GBNyA As GroupBox
    Friend WithEvents TxtNyA As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BModificar As Button
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents BSalir As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TBPatente As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CBHora As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DTFecha As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBModelo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBMarca As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents CBFHora As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtPatente As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
