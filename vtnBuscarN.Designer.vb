<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vtnBuscarN
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
        Me.lstNaves = New System.Windows.Forms.ListBox()
        Me.btnBusquedaAv = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cboxTipoN = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.rbPais = New System.Windows.Forms.RadioButton()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbTipoNave = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCapMay = New System.Windows.Forms.TextBox()
        Me.txtCapMe = New System.Windows.Forms.TextBox()
        Me.txtPoMe = New System.Windows.Forms.TextBox()
        Me.txtPoMay = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCapCarg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTipoCarga = New System.Windows.Forms.Label()
        Me.lblCapPers = New System.Windows.Forms.Label()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.lblTonEmp = New System.Windows.Forms.Label()
        Me.lblPotencia = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblTipoN = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblTipoCom = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCaracter = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.rbPotencia = New System.Windows.Forms.RadioButton()
        Me.rbCapCarg = New System.Windows.Forms.RadioButton()
        Me.btnEditNa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstNaves
        '
        Me.lstNaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNaves.FormattingEnabled = True
        Me.lstNaves.ItemHeight = 20
        Me.lstNaves.Location = New System.Drawing.Point(437, 60)
        Me.lstNaves.Name = "lstNaves"
        Me.lstNaves.Size = New System.Drawing.Size(207, 224)
        Me.lstNaves.TabIndex = 0
        '
        'btnBusquedaAv
        '
        Me.btnBusquedaAv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusquedaAv.Location = New System.Drawing.Point(12, 463)
        Me.btnBusquedaAv.Name = "btnBusquedaAv"
        Me.btnBusquedaAv.Size = New System.Drawing.Size(143, 60)
        Me.btnBusquedaAv.TabIndex = 1
        Me.btnBusquedaAv.Text = "Aplicar Busqueda Avanzada"
        Me.btnBusquedaAv.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(47, 170)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(122, 43)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Buscar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cboxTipoN
        '
        Me.cboxTipoN.FormattingEnabled = True
        Me.cboxTipoN.Location = New System.Drawing.Point(242, 39)
        Me.cboxTipoN.Name = "cboxTipoN"
        Me.cboxTipoN.Size = New System.Drawing.Size(143, 28)
        Me.cboxTipoN.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = ""
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtEmpresa)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.rbEmpresa)
        Me.Panel1.Controls.Add(Me.txtPais)
        Me.Panel1.Controls.Add(Me.rbPais)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.rbNombre)
        Me.Panel1.Controls.Add(Me.rbTipoNave)
        Me.Panel1.Controls.Add(Me.cboxTipoN)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(12, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 224)
        Me.Panel1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(253, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 43)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(242, 109)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(143, 26)
        Me.txtEmpresa.TabIndex = 11
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.Location = New System.Drawing.Point(242, 79)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(91, 24)
        Me.rbEmpresa.TabIndex = 10
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Text = "Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(36, 109)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(142, 26)
        Me.txtPais.TabIndex = 9
        '
        'rbPais
        '
        Me.rbPais.AutoSize = True
        Me.rbPais.Location = New System.Drawing.Point(35, 79)
        Me.rbPais.Name = "rbPais"
        Me.rbPais.Size = New System.Drawing.Size(57, 24)
        Me.rbPais.TabIndex = 8
        Me.rbPais.TabStop = True
        Me.rbPais.Text = "Pais"
        Me.rbPais.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(36, 39)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(142, 26)
        Me.txtNom.TabIndex = 7
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(36, 11)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(83, 24)
        Me.rbNombre.TabIndex = 6
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbTipoNave
        '
        Me.rbTipoNave.AutoSize = True
        Me.rbTipoNave.Location = New System.Drawing.Point(242, 11)
        Me.rbTipoNave.Name = "rbTipoNave"
        Me.rbTipoNave.Size = New System.Drawing.Size(119, 24)
        Me.rbTipoNave.TabIndex = 5
        Me.rbTipoNave.TabStop = True
        Me.rbTipoNave.Text = "Tipo de Nave"
        Me.rbTipoNave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCapCarg)
        Me.GroupBox1.Controls.Add(Me.rbPotencia)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCapMay)
        Me.GroupBox1.Controls.Add(Me.txtCapMe)
        Me.GroupBox1.Controls.Add(Me.txtPoMe)
        Me.GroupBox1.Controls.Add(Me.txtPoMay)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 141)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda Avanzada"
        '
        'txtCapMay
        '
        Me.txtCapMay.Location = New System.Drawing.Point(159, 102)
        Me.txtCapMay.Name = "txtCapMay"
        Me.txtCapMay.Size = New System.Drawing.Size(100, 26)
        Me.txtCapMay.TabIndex = 3
        '
        'txtCapMe
        '
        Me.txtCapMe.Location = New System.Drawing.Point(265, 102)
        Me.txtCapMe.Name = "txtCapMe"
        Me.txtCapMe.Size = New System.Drawing.Size(100, 26)
        Me.txtCapMe.TabIndex = 2
        '
        'txtPoMe
        '
        Me.txtPoMe.Location = New System.Drawing.Point(265, 46)
        Me.txtPoMe.Name = "txtPoMe"
        Me.txtPoMe.Size = New System.Drawing.Size(100, 26)
        Me.txtPoMe.TabIndex = 1
        '
        'txtPoMay
        '
        Me.txtPoMay.Location = New System.Drawing.Point(159, 46)
        Me.txtPoMay.Name = "txtPoMay"
        Me.txtPoMay.Size = New System.Drawing.Size(100, 26)
        Me.txtPoMay.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCapCarg)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblTipoCarga)
        Me.Panel2.Controls.Add(Me.lblCapPers)
        Me.Panel2.Controls.Add(Me.lblFuncion)
        Me.Panel2.Controls.Add(Me.lblPeso)
        Me.Panel2.Controls.Add(Me.lblAlt)
        Me.Panel2.Controls.Add(Me.lblTonEmp)
        Me.Panel2.Controls.Add(Me.lblPotencia)
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Controls.Add(Me.lblTipoN)
        Me.Panel2.Controls.Add(Me.lblNom)
        Me.Panel2.Controls.Add(Me.lblEmp)
        Me.Panel2.Controls.Add(Me.lblPais)
        Me.Panel2.Controls.Add(Me.lblTipoCom)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(661, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 463)
        Me.Panel2.TabIndex = 16
        '
        'lblCapCarg
        '
        Me.lblCapCarg.AutoSize = True
        Me.lblCapCarg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapCarg.Location = New System.Drawing.Point(112, 312)
        Me.lblCapCarg.Name = "lblCapCarg"
        Me.lblCapCarg.Size = New System.Drawing.Size(0, 16)
        Me.lblCapCarg.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Cap. de Carga :"
        '
        'lblTipoCarga
        '
        Me.lblTipoCarga.AutoSize = True
        Me.lblTipoCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCarga.Location = New System.Drawing.Point(112, 285)
        Me.lblTipoCarga.Name = "lblTipoCarga"
        Me.lblTipoCarga.Size = New System.Drawing.Size(0, 16)
        Me.lblTipoCarga.TabIndex = 25
        '
        'lblCapPers
        '
        Me.lblCapPers.AutoSize = True
        Me.lblCapPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapPers.Location = New System.Drawing.Point(112, 340)
        Me.lblCapPers.Name = "lblCapPers"
        Me.lblCapPers.Size = New System.Drawing.Size(0, 16)
        Me.lblCapPers.TabIndex = 24
        '
        'lblFuncion
        '
        Me.lblFuncion.AutoSize = True
        Me.lblFuncion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncion.Location = New System.Drawing.Point(112, 368)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(0, 16)
        Me.lblFuncion.TabIndex = 23
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(112, 147)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(0, 16)
        Me.lblPeso.TabIndex = 22
        '
        'lblAlt
        '
        Me.lblAlt.AutoSize = True
        Me.lblAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlt.Location = New System.Drawing.Point(112, 173)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(0, 16)
        Me.lblAlt.TabIndex = 21
        '
        'lblTonEmp
        '
        Me.lblTonEmp.AutoSize = True
        Me.lblTonEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonEmp.Location = New System.Drawing.Point(112, 256)
        Me.lblTonEmp.Name = "lblTonEmp"
        Me.lblTonEmp.Size = New System.Drawing.Size(0, 16)
        Me.lblTonEmp.TabIndex = 20
        '
        'lblPotencia
        '
        Me.lblPotencia.AutoSize = True
        Me.lblPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPotencia.Location = New System.Drawing.Point(112, 227)
        Me.lblPotencia.Name = "lblPotencia"
        Me.lblPotencia.Size = New System.Drawing.Size(0, 16)
        Me.lblPotencia.TabIndex = 19
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(112, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 16)
        Me.lblId.TabIndex = 18
        '
        'lblTipoN
        '
        Me.lblTipoN.AutoSize = True
        Me.lblTipoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoN.Location = New System.Drawing.Point(112, 38)
        Me.lblTipoN.Name = "lblTipoN"
        Me.lblTipoN.Size = New System.Drawing.Size(0, 16)
        Me.lblTipoN.TabIndex = 17
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(112, 63)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(0, 16)
        Me.lblNom.TabIndex = 16
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp.Location = New System.Drawing.Point(112, 91)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(0, 16)
        Me.lblEmp.TabIndex = 15
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(112, 116)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(0, 16)
        Me.lblPais.TabIndex = 14
        '
        'lblTipoCom
        '
        Me.lblTipoCom.AutoSize = True
        Me.lblTipoCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCom.Location = New System.Drawing.Point(112, 198)
        Me.lblTipoCom.Name = "lblTipoCom"
        Me.lblTipoCom.Size = New System.Drawing.Size(0, 16)
        Me.lblTipoCom.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Funcion: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Cap. de Pers. :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tipo de Carga :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ton. de Emp. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Potencia :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de Comb. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Altura :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Peso :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pais :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Empresa :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Nave :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Nave :"
        '
        'cbCaracter
        '
        Me.cbCaracter.AutoSize = True
        Me.cbCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCaracter.ForeColor = System.Drawing.SystemColors.Control
        Me.cbCaracter.Location = New System.Drawing.Point(48, 30)
        Me.cbCaracter.Name = "cbCaracter"
        Me.cbCaracter.Size = New System.Drawing.Size(194, 24)
        Me.cbCaracter.TabIndex = 17
        Me.cbCaracter.Text = "Busqueda Por Caracter"
        Me.cbCaracter.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.Control
        Me.Label27.Location = New System.Drawing.Point(440, 315)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(204, 16)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Imagen Nave Seleccionada:"
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(443, 334)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(201, 156)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 19
        Me.pbImagen.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(167, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Mayor que:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(167, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 20)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Mayor que:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(273, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Menor que:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(269, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 20)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Menor que:"
        '
        'rbPotencia
        '
        Me.rbPotencia.AutoSize = True
        Me.rbPotencia.Location = New System.Drawing.Point(6, 47)
        Me.rbPotencia.Name = "rbPotencia"
        Me.rbPotencia.Size = New System.Drawing.Size(89, 24)
        Me.rbPotencia.TabIndex = 10
        Me.rbPotencia.TabStop = True
        Me.rbPotencia.Text = "Potencia"
        Me.rbPotencia.UseVisualStyleBackColor = True
        '
        'rbCapCarg
        '
        Me.rbCapCarg.AutoSize = True
        Me.rbCapCarg.Location = New System.Drawing.Point(6, 103)
        Me.rbCapCarg.Name = "rbCapCarg"
        Me.rbCapCarg.Size = New System.Drawing.Size(125, 24)
        Me.rbCapCarg.TabIndex = 11
        Me.rbCapCarg.TabStop = True
        Me.rbCapCarg.Text = "Cap de Carga"
        Me.rbCapCarg.UseVisualStyleBackColor = True
        '
        'btnEditNa
        '
        Me.btnEditNa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditNa.Location = New System.Drawing.Point(280, 463)
        Me.btnEditNa.Name = "btnEditNa"
        Me.btnEditNa.Size = New System.Drawing.Size(143, 60)
        Me.btnEditNa.TabIndex = 20
        Me.btnEditNa.Text = "Editar Nave"
        Me.btnEditNa.UseVisualStyleBackColor = True
        Me.btnEditNa.Visible = False
        '
        'vtnBuscarN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(920, 535)
        Me.Controls.Add(Me.btnEditNa)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cbCaracter)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBusquedaAv)
        Me.Controls.Add(Me.lstNaves)
        Me.Name = "vtnBuscarN"
        Me.Text = "Buscador de Naves"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNaves As ListBox
    Friend WithEvents btnBusquedaAv As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cboxTipoN As ComboBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents rbEmpresa As RadioButton
    Friend WithEvents txtPais As TextBox
    Friend WithEvents rbPais As RadioButton
    Friend WithEvents txtNom As TextBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbTipoNave As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCapMay As TextBox
    Friend WithEvents txtCapMe As TextBox
    Friend WithEvents txtPoMe As TextBox
    Friend WithEvents txtPoMay As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCaracter As CheckBox
    Friend WithEvents lblTipoCarga As Label
    Friend WithEvents lblCapPers As Label
    Friend WithEvents lblFuncion As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblAlt As Label
    Friend WithEvents lblTonEmp As Label
    Friend WithEvents lblPotencia As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblTipoN As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblEmp As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblTipoCom As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lblCapCarg As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents rbCapCarg As RadioButton
    Friend WithEvents rbPotencia As RadioButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnEditNa As Button
End Class
