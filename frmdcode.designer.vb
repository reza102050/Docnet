<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmdcode
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdfindcode5 As System.Windows.Forms.Button
    Public WithEvents txtproc As System.Windows.Forms.TextBox
    Public WithEvents cmdloop As System.Windows.Forms.Button
    Public WithEvents cmdgetcode As System.Windows.Forms.Button
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents txtcode5 As System.Windows.Forms.TextBox
    Public WithEvents upd1 As System.Windows.Forms.Button
    Public WithEvents upd2 As System.Windows.Forms.Button
    Public WithEvents cmdup3 As System.Windows.Forms.Button
    Public WithEvents mh5 As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents txtvcode As System.Windows.Forms.TextBox
    Public WithEvents txtdaro_fname As System.Windows.Forms.TextBox
    Public WithEvents txtcode As System.Windows.Forms.TextBox
    Public WithEvents txtdaro_pay As System.Windows.Forms.TextBox
    Public WithEvents lblcolor As System.Windows.Forms.Label
    Public WithEvents lblcolor1 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_8 As System.Windows.Forms.Label
    Public WithEvents _Label1_31 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents optsold As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents opttip As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdcode))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.upd1 = New System.Windows.Forms.Button()
        Me.upd2 = New System.Windows.Forms.Button()
        Me.cmdup3 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.opttip1 = New System.Windows.Forms.RadioButton()
        Me.opttip0 = New System.Windows.Forms.RadioButton()
        Me.chkden = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbosex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdaddVirtual = New System.Windows.Forms.Button()
        Me.cmdRemoveVirtual = New System.Windows.Forms.Button()
        Me.cmdfindcode5 = New System.Windows.Forms.Button()
        Me.txtproc = New System.Windows.Forms.TextBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdlist = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddel = New System.Windows.Forms.Button()
        Me.cmdloop = New System.Windows.Forms.Button()
        Me.cmdgetcode = New System.Windows.Forms.Button()
        Me.txtcode5 = New System.Windows.Forms.TextBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.mh5 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtvcode = New System.Windows.Forms.TextBox()
        Me.txtdaro_fname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.txtdaro_pay = New System.Windows.Forms.TextBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lblcolor1 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_31 = New System.Windows.Forms.Label()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.optsold = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.opttip = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame9.SuspendLayout()
        CType(Me.mh5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optsold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opttip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'upd1
        '
        Me.upd1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.upd1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.upd1.Location = New System.Drawing.Point(8, 8)
        Me.upd1.Name = "upd1"
        Me.upd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.upd1.Size = New System.Drawing.Size(25, 27)
        Me.upd1.TabIndex = 17
        Me.upd1.Text = "+"
        Me.ToolTip1.SetToolTip(Me.upd1, "ثبت قيمت براي تمام ليست")
        Me.upd1.UseVisualStyleBackColor = False
        '
        'upd2
        '
        Me.upd2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.upd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.upd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.upd2.Location = New System.Drawing.Point(40, 8)
        Me.upd2.Name = "upd2"
        Me.upd2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.upd2.Size = New System.Drawing.Size(25, 27)
        Me.upd2.TabIndex = 16
        Me.upd2.Text = "*"
        Me.ToolTip1.SetToolTip(Me.upd2, "اضافه كردن قيمت براي تمام بيمه ها")
        Me.upd2.UseVisualStyleBackColor = False
        '
        'cmdup3
        '
        Me.cmdup3.BackColor = System.Drawing.Color.Red
        Me.cmdup3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdup3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdup3.Location = New System.Drawing.Point(72, 8)
        Me.cmdup3.Name = "cmdup3"
        Me.cmdup3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdup3.Size = New System.Drawing.Size(25, 27)
        Me.cmdup3.TabIndex = 15
        Me.cmdup3.Text = "-"
        Me.ToolTip1.SetToolTip(Me.cmdup3, "پاك كردن تمامي قيمتهاي ليست")
        Me.cmdup3.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.opttip1)
        Me.Frame1.Controls.Add(Me.opttip0)
        Me.Frame1.Controls.Add(Me.chkden)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.cbosex)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.cmdaddVirtual)
        Me.Frame1.Controls.Add(Me.cmdRemoveVirtual)
        Me.Frame1.Controls.Add(Me.cmdfindcode5)
        Me.Frame1.Controls.Add(Me.txtproc)
        Me.Frame1.Controls.Add(Me.Frame7)
        Me.Frame1.Controls.Add(Me.txtcode5)
        Me.Frame1.Controls.Add(Me.Frame9)
        Me.Frame1.Controls.Add(Me.txtvcode)
        Me.Frame1.Controls.Add(Me.txtdaro_fname)
        Me.Frame1.Controls.Add(Me.txtcode)
        Me.Frame1.Controls.Add(Me.txtdaro_pay)
        Me.Frame1.Controls.Add(Me.lblcolor)
        Me.Frame1.Controls.Add(Me.lblcolor1)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label1_8)
        Me.Frame1.Controls.Add(Me._Label1_31)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(1001, 729)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        'opttip1
        '
        Me.opttip1.AutoSize = True
        Me.opttip1.Checked = True
        Me.opttip1.Location = New System.Drawing.Point(138, 92)
        Me.opttip1.Name = "opttip1"
        Me.opttip1.Size = New System.Drawing.Size(57, 17)
        Me.opttip1.TabIndex = 77
        Me.opttip1.TabStop = True
        Me.opttip1.Text = "خدمت"
        Me.opttip1.UseVisualStyleBackColor = True
        '
        'opttip0
        '
        Me.opttip0.AutoSize = True
        Me.opttip0.Location = New System.Drawing.Point(223, 92)
        Me.opttip0.Name = "opttip0"
        Me.opttip0.Size = New System.Drawing.Size(56, 17)
        Me.opttip0.TabIndex = 76
        Me.opttip0.Text = "ویزیت"
        Me.opttip0.UseVisualStyleBackColor = True
        '
        'chkden
        '
        Me.chkden.AutoSize = True
        Me.chkden.Location = New System.Drawing.Point(22, 161)
        Me.chkden.Name = "chkden"
        Me.chkden.Size = New System.Drawing.Size(126, 17)
        Me.chkden.TabIndex = 75
        Me.chkden.Text = "خدمت دندانپزشکی"
        Me.chkden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(592, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(88, 41)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "گروه دندانپزشکی"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbosex
        '
        Me.cbosex.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbosex.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbosex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosex.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbosex.Location = New System.Drawing.Point(247, 136)
        Me.cbosex.Name = "cbosex"
        Me.cbosex.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbosex.Size = New System.Drawing.Size(339, 21)
        Me.cbosex.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(196, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "كد مجازی"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdaddVirtual
        '
        Me.cmdaddVirtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaddVirtual.Location = New System.Drawing.Point(31, 10)
        Me.cmdaddVirtual.Name = "cmdaddVirtual"
        Me.cmdaddVirtual.Size = New System.Drawing.Size(26, 25)
        Me.cmdaddVirtual.TabIndex = 70
        Me.cmdaddVirtual.Text = "+"
        Me.cmdaddVirtual.UseVisualStyleBackColor = False
        '
        'cmdRemoveVirtual
        '
        Me.cmdRemoveVirtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdRemoveVirtual.Location = New System.Drawing.Point(33, 40)
        Me.cmdRemoveVirtual.Name = "cmdRemoveVirtual"
        Me.cmdRemoveVirtual.Size = New System.Drawing.Size(24, 27)
        Me.cmdRemoveVirtual.TabIndex = 69
        Me.cmdRemoveVirtual.Text = "-"
        Me.cmdRemoveVirtual.UseVisualStyleBackColor = False
        '
        'cmdfindcode5
        '
        Me.cmdfindcode5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdfindcode5.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdfindcode5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdfindcode5.Image = CType(resources.GetObject("cmdfindcode5.Image"), System.Drawing.Image)
        Me.cmdfindcode5.Location = New System.Drawing.Point(154, 146)
        Me.cmdfindcode5.Name = "cmdfindcode5"
        Me.cmdfindcode5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdfindcode5.Size = New System.Drawing.Size(41, 33)
        Me.cmdfindcode5.TabIndex = 53
        Me.cmdfindcode5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdfindcode5.UseVisualStyleBackColor = False
        '
        'txtproc
        '
        Me.txtproc.AcceptsReturn = True
        Me.txtproc.BackColor = System.Drawing.SystemColors.Window
        Me.txtproc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtproc.Location = New System.Drawing.Point(22, 184)
        Me.txtproc.MaxLength = 0
        Me.txtproc.Name = "txtproc"
        Me.txtproc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtproc.Size = New System.Drawing.Size(12, 21)
        Me.txtproc.TabIndex = 42
        Me.txtproc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtproc.Visible = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdlist)
        Me.Frame7.Controls.Add(Me.cmdexit)
        Me.Frame7.Controls.Add(Me.cmdsave)
        Me.Frame7.Controls.Add(Me.cmddel)
        Me.Frame7.Controls.Add(Me.cmdloop)
        Me.Frame7.Controls.Add(Me.cmdgetcode)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(91, 647)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(537, 72)
        Me.Frame7.TabIndex = 41
        Me.Frame7.TabStop = False
        '
        'cmdlist
        '
        Me.cmdlist.BackColor = System.Drawing.Color.White
        Me.cmdlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdlist.Image = Global.DaroNet.My.Resources.Resources.Search
        Me.cmdlist.Location = New System.Drawing.Point(172, 16)
        Me.cmdlist.Name = "cmdlist"
        Me.cmdlist.Size = New System.Drawing.Size(86, 41)
        Me.cmdlist.TabIndex = 178
        Me.cmdlist.Text = "لیست"
        Me.cmdlist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdlist.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.Location = New System.Drawing.Point(16, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(74, 41)
        Me.cmdexit.TabIndex = 172
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.White
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.Image = Global.DaroNet.My.Resources.Resources.Save_2_Check
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(96, 16)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(65, 41)
        Me.cmdsave.TabIndex = 173
        Me.cmdsave.Text = "ثبت"
        Me.cmdsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmddel
        '
        Me.cmddel.BackColor = System.Drawing.Color.White
        Me.cmddel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddel.Image = Global.DaroNet.My.Resources.Resources.Delete
        Me.cmddel.Location = New System.Drawing.Point(361, 16)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(70, 41)
        Me.cmddel.TabIndex = 174
        Me.cmddel.Text = "حذف"
        Me.cmddel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmddel.UseVisualStyleBackColor = False
        '
        'cmdloop
        '
        Me.cmdloop.Location = New System.Drawing.Point(440, 16)
        Me.cmdloop.Name = "cmdloop"
        Me.cmdloop.Size = New System.Drawing.Size(81, 41)
        Me.cmdloop.TabIndex = 60
        Me.cmdloop.Text = "ادامه"
        '
        'cmdgetcode
        '
        Me.cmdgetcode.Location = New System.Drawing.Point(264, 16)
        Me.cmdgetcode.Name = "cmdgetcode"
        Me.cmdgetcode.Size = New System.Drawing.Size(81, 41)
        Me.cmdgetcode.TabIndex = 62
        Me.cmdgetcode.Text = "کد جدید"
        '
        'txtcode5
        '
        Me.txtcode5.AcceptsReturn = True
        Me.txtcode5.BackColor = System.Drawing.SystemColors.Window
        Me.txtcode5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode5.Font = New System.Drawing.Font("Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtcode5.Location = New System.Drawing.Point(308, 83)
        Me.txtcode5.MaxLength = 10
        Me.txtcode5.Name = "txtcode5"
        Me.txtcode5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode5.Size = New System.Drawing.Size(107, 33)
        Me.txtcode5.TabIndex = 4
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me.upd1)
        Me.Frame9.Controls.Add(Me.upd2)
        Me.Frame9.Controls.Add(Me.cmdup3)
        Me.Frame9.Controls.Add(Me.mh5)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(153, 213)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(513, 497)
        Me.Frame9.TabIndex = 12
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "قيمت  به تفكيك بيمه"
        '
        'mh5
        '
        Me.mh5.AllowEditing = False
        Me.mh5.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.mh5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mh5.Location = New System.Drawing.Point(8, 41)
        Me.mh5.Name = "mh5"
        Me.mh5.Rows.DefaultSize = 20
        Me.mh5.Size = New System.Drawing.Size(497, 393)
        Me.mh5.StyleInfo = resources.GetString("mh5.StyleInfo")
        Me.mh5.TabIndex = 52
        '
        'txtvcode
        '
        Me.txtvcode.AcceptsReturn = True
        Me.txtvcode.BackColor = System.Drawing.Color.Silver
        Me.txtvcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvcode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtvcode.Location = New System.Drawing.Point(91, 19)
        Me.txtvcode.MaxLength = 0
        Me.txtvcode.Name = "txtvcode"
        Me.txtvcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvcode.Size = New System.Drawing.Size(73, 21)
        Me.txtvcode.TabIndex = 11
        Me.txtvcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdaro_fname
        '
        Me.txtdaro_fname.AcceptsReturn = True
        Me.txtdaro_fname.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaro_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaro_fname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdaro_fname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaro_fname.Location = New System.Drawing.Point(207, 56)
        Me.txtdaro_fname.MaxLength = 0
        Me.txtdaro_fname.Name = "txtdaro_fname"
        Me.txtdaro_fname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaro_fname.Size = New System.Drawing.Size(379, 21)
        Me.txtdaro_fname.TabIndex = 1
        Me.txtdaro_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcode
        '
        Me.txtcode.AcceptsReturn = True
        Me.txtcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.Font = New System.Drawing.Font("Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcode.Location = New System.Drawing.Point(370, 17)
        Me.txtcode.MaxLength = 10
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode.Size = New System.Drawing.Size(216, 33)
        Me.txtcode.TabIndex = 0
        '
        'txtdaro_pay
        '
        Me.txtdaro_pay.AcceptsReturn = True
        Me.txtdaro_pay.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaro_pay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaro_pay.Font = New System.Drawing.Font("Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdaro_pay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaro_pay.Location = New System.Drawing.Point(477, 84)
        Me.txtdaro_pay.MaxLength = 10
        Me.txtdaro_pay.Name = "txtdaro_pay"
        Me.txtdaro_pay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaro_pay.Size = New System.Drawing.Size(107, 33)
        Me.txtdaro_pay.TabIndex = 3
        '
        'lblcolor
        '
        Me.lblcolor.BackColor = System.Drawing.Color.Yellow
        Me.lblcolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcolor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcolor.Location = New System.Drawing.Point(38, 231)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblcolor.Size = New System.Drawing.Size(41, 17)
        Me.lblcolor.TabIndex = 44
        Me.lblcolor.Text = "Label3"
        Me.lblcolor.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblcolor.Visible = False
        '
        'lblcolor1
        '
        Me.lblcolor1.BackColor = System.Drawing.Color.White
        Me.lblcolor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcolor1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcolor1.Location = New System.Drawing.Point(46, 215)
        Me.lblcolor1.Name = "lblcolor1"
        Me.lblcolor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblcolor1.Size = New System.Drawing.Size(33, 9)
        Me.lblcolor1.TabIndex = 43
        Me.lblcolor1.Text = "Label3"
        Me.lblcolor1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblcolor1.Visible = False
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(421, 84)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_2.Size = New System.Drawing.Size(59, 31)
        Me._Label1_2.TabIndex = 13
        Me._Label1_2.Text = "كد استاندارد"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(589, 92)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_1.Size = New System.Drawing.Size(65, 23)
        Me._Label1_1.TabIndex = 9
        Me._Label1_1.Text = "قيمت آزاد"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.Transparent
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_8, CType(8, Short))
        Me._Label1_8.Location = New System.Drawing.Point(592, 54)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_8.Size = New System.Drawing.Size(71, 23)
        Me._Label1_8.TabIndex = 8
        Me._Label1_8.Text = "نام "
        Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_31
        '
        Me._Label1_31.BackColor = System.Drawing.Color.Transparent
        Me._Label1_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_31, CType(31, Short))
        Me._Label1_31.Location = New System.Drawing.Point(614, 26)
        Me._Label1_31.Name = "_Label1_31"
        Me._Label1_31.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_31.Size = New System.Drawing.Size(55, 23)
        Me._Label1_31.TabIndex = 7
        Me._Label1_31.Text = "كد "
        Me._Label1_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'optsold
        '
        '
        'opttip
        '
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(114, 122)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "توجه درصورتيکه در ستون درصد مقداري را وارد نماييد براي بيمه مشخص شده سهم سازمان ب" & _
    "ا درصد جديد مشخص شده محاسبه خواهد شد"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label5.Visible = False
        '
        'frmdcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 722)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmdcode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "معرفي کدينگ خدمات"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame9.ResumeLayout(False)
        CType(Me.mh5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optsold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opttip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdsave As System.Windows.Forms.Button
    Public WithEvents cmddel As System.Windows.Forms.Button
    Public WithEvents cmdlist As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveVirtual As System.Windows.Forms.Button
    Friend WithEvents cmdaddVirtual As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cbosex As System.Windows.Forms.ComboBox
    Friend WithEvents chkden As System.Windows.Forms.CheckBox
    Friend WithEvents opttip1 As System.Windows.Forms.RadioButton
    Friend WithEvents opttip0 As System.Windows.Forms.RadioButton
    Public WithEvents Label5 As System.Windows.Forms.Label
#End Region
End Class