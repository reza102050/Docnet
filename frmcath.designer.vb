<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmcath
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
	Public WithEvents chkMeli As System.Windows.Forms.CheckBox
	Public WithEvents chkbwork As System.Windows.Forms.CheckBox
	Public WithEvents chkdate As System.Windows.Forms.CheckBox
	Public WithEvents chkpage As System.Windows.Forms.CheckBox
	Public WithEvents chkbimar As System.Windows.Forms.CheckBox
	Public WithEvents chkbimeh As System.Windows.Forms.CheckBox
	Public WithEvents chknezam As System.Windows.Forms.CheckBox
	Public WithEvents chktaan As System.Windows.Forms.CheckBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdsave As System.Windows.Forms.Button
    Public WithEvents cmddel As System.Windows.Forms.Button
    Public WithEvents cmdlook As System.Windows.Forms.Button
    Public WithEvents cmdcopy As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtpaymama As System.Windows.Forms.TextBox
    Public WithEvents txtproc As System.Windows.Forms.TextBox
    Public WithEvents txtfhaz As System.Windows.Forms.TextBox
    Public WithEvents txtcode As System.Windows.Forms.TextBox
    Public WithEvents txtpayden As System.Windows.Forms.TextBox
    Public WithEvents txtpaymot As System.Windows.Forms.TextBox
    Public WithEvents txtnamenos As System.Windows.Forms.TextBox
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents txtnprint As System.Windows.Forms.TextBox
    Public WithEvents txtkhas As System.Windows.Forms.TextBox
    Public WithEvents cbo1 As System.Windows.Forms.ComboBox
    Public WithEvents cmdnz As System.Windows.Forms.Button
    Public WithEvents txtfname As System.Windows.Forms.TextBox
    Public WithEvents txtdc As System.Windows.Forms.TextBox
    Public WithEvents txtpt As System.Windows.Forms.TextBox
    Public WithEvents txtpaydoc As System.Windows.Forms.TextBox
    Public WithEvents txtorgan_name As System.Windows.Forms.TextBox
    Public WithEvents txtorgan_code As System.Windows.Forms.TextBox
    Public WithEvents txtbimar As System.Windows.Forms.TextBox
    Public WithEvents txtorg As System.Windows.Forms.TextBox
    Public WithEvents txtname As System.Windows.Forms.TextBox
    Public WithEvents cmdlistcath As System.Windows.Forms.Button
    Public WithEvents _Label1_6 As System.Windows.Forms.Label
    Public WithEvents _Label1_8 As System.Windows.Forms.Label
    Public WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents _Label1_7 As System.Windows.Forms.Label
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents _Label1_9 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents mh1 As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcath))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button
        Me.cmdnz = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.chkMeli = New System.Windows.Forms.CheckBox
        Me.chkbwork = New System.Windows.Forms.CheckBox
        Me.chkdate = New System.Windows.Forms.CheckBox
        Me.chkpage = New System.Windows.Forms.CheckBox
        Me.chkbimar = New System.Windows.Forms.CheckBox
        Me.chkbimeh = New System.Windows.Forms.CheckBox
        Me.chknezam = New System.Windows.Forms.CheckBox
        Me.chktaan = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdloop = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmddel = New System.Windows.Forms.Button
        Me.cmdlook = New System.Windows.Forms.Button
        Me.cmdcopy = New System.Windows.Forms.Button
        Me.txtpaymama = New System.Windows.Forms.TextBox
        Me.txtproc = New System.Windows.Forms.TextBox
        Me.txtfhaz = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtpayden = New System.Windows.Forms.TextBox
        Me.txtpaymot = New System.Windows.Forms.TextBox
        Me.txtnamenos = New System.Windows.Forms.TextBox
        Me.txtnprint = New System.Windows.Forms.TextBox
        Me.txtkhas = New System.Windows.Forms.TextBox
        Me.cbo1 = New System.Windows.Forms.ComboBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.txtdc = New System.Windows.Forms.TextBox
        Me.txtpt = New System.Windows.Forms.TextBox
        Me.txtpaydoc = New System.Windows.Forms.TextBox
        Me.txtorgan_name = New System.Windows.Forms.TextBox
        Me.txtorgan_code = New System.Windows.Forms.TextBox
        Me.txtbimar = New System.Windows.Forms.TextBox
        Me.txtorg = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.cmdlistcath = New System.Windows.Forms.Button
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me._Label1_9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mh1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(528, 288)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command2.Size = New System.Drawing.Size(85, 22)
        Me.Command2.TabIndex = 35
        Me.Command2.Text = "مدل چاپ نسخه"
        Me.ToolTip1.SetToolTip(Me.Command2, "ليست انواع چاپ نسخه")
        Me.Command2.UseVisualStyleBackColor = False
        '
        'cmdnz
        '
        Me.cmdnz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdnz.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdnz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdnz.Location = New System.Drawing.Point(16, 16)
        Me.cmdnz.Name = "cmdnz"
        Me.cmdnz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdnz.Size = New System.Drawing.Size(21, 22)
        Me.cmdnz.TabIndex = 32
        Me.cmdnz.Text = "؟"
        Me.ToolTip1.SetToolTip(Me.cmdnz, "ليست طرف قراردادها")
        Me.cmdnz.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Frame3.Controls.Add(Me.chkMeli)
        Me.Frame3.Controls.Add(Me.chkbwork)
        Me.Frame3.Controls.Add(Me.chkdate)
        Me.Frame3.Controls.Add(Me.chkpage)
        Me.Frame3.Controls.Add(Me.chkbimar)
        Me.Frame3.Controls.Add(Me.chkbimeh)
        Me.Frame3.Controls.Add(Me.chknezam)
        Me.Frame3.Controls.Add(Me.chktaan)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(153, 649)
        Me.Frame3.TabIndex = 41
        Me.Frame3.TabStop = False
        '
        'chkMeli
        '
        Me.chkMeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkMeli.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMeli.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMeli.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkMeli.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMeli.Location = New System.Drawing.Point(8, 456)
        Me.chkMeli.Name = "chkMeli"
        Me.chkMeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkMeli.Size = New System.Drawing.Size(129, 49)
        Me.chkMeli.TabIndex = 55
        Me.chkMeli.Text = "ثبت كد ملي  درنسخه"
        Me.chkMeli.UseVisualStyleBackColor = False
        '
        'chkbwork
        '
        Me.chkbwork.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkbwork.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkbwork.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkbwork.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkbwork.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkbwork.Location = New System.Drawing.Point(8, 376)
        Me.chkbwork.Name = "chkbwork"
        Me.chkbwork.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkbwork.Size = New System.Drawing.Size(129, 65)
        Me.chkbwork.TabIndex = 48
        Me.chkbwork.Text = "در صورت نداشتن اعتبار  آزاد حساب نشود"
        Me.chkbwork.UseVisualStyleBackColor = False
        '
        'chkdate
        '
        Me.chkdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkdate.Location = New System.Drawing.Point(8, 312)
        Me.chkdate.Name = "chkdate"
        Me.chkdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkdate.Size = New System.Drawing.Size(129, 49)
        Me.chkdate.TabIndex = 47
        Me.chkdate.Text = "ثبت تاريخ نسخه  الزامي است"
        Me.chkdate.UseVisualStyleBackColor = False
        '
        'chkpage
        '
        Me.chkpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkpage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkpage.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkpage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkpage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkpage.Location = New System.Drawing.Point(8, 256)
        Me.chkpage.Name = "chkpage"
        Me.chkpage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkpage.Size = New System.Drawing.Size(129, 49)
        Me.chkpage.TabIndex = 46
        Me.chkpage.Text = "ثبت شماره صفحه دفترچه الزامي است"
        Me.chkpage.UseVisualStyleBackColor = False
        '
        'chkbimar
        '
        Me.chkbimar.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkbimar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkbimar.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkbimar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkbimar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkbimar.Location = New System.Drawing.Point(8, 192)
        Me.chkbimar.Name = "chkbimar"
        Me.chkbimar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkbimar.Size = New System.Drawing.Size(129, 49)
        Me.chkbimar.TabIndex = 45
        Me.chkbimar.Text = "ثبت نام بيمار الزامي است"
        Me.chkbimar.UseVisualStyleBackColor = False
        '
        'chkbimeh
        '
        Me.chkbimeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chkbimeh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkbimeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkbimeh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkbimeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkbimeh.Location = New System.Drawing.Point(8, 136)
        Me.chkbimeh.Name = "chkbimeh"
        Me.chkbimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkbimeh.Size = New System.Drawing.Size(129, 49)
        Me.chkbimeh.TabIndex = 44
        Me.chkbimeh.Text = "ثبت کد بيمه شده الزامي است"
        Me.chkbimeh.UseVisualStyleBackColor = False
        '
        'chknezam
        '
        Me.chknezam.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chknezam.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chknezam.Cursor = System.Windows.Forms.Cursors.Default
        Me.chknezam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chknezam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chknezam.Location = New System.Drawing.Point(8, 80)
        Me.chknezam.Name = "chknezam"
        Me.chknezam.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chknezam.Size = New System.Drawing.Size(129, 49)
        Me.chknezam.TabIndex = 43
        Me.chknezam.Text = "ثبت نظام پزشکي الزامي است"
        Me.chknezam.UseVisualStyleBackColor = False
        '
        'chktaan
        '
        Me.chktaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.chktaan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chktaan.Cursor = System.Windows.Forms.Cursors.Default
        Me.chktaan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chktaan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chktaan.Location = New System.Drawing.Point(8, 24)
        Me.chktaan.Name = "chktaan"
        Me.chktaan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chktaan.Size = New System.Drawing.Size(129, 49)
        Me.chktaan.TabIndex = 42
        Me.chktaan.Text = "ثبت تاريخ اعتبار دفترچه الزامي است"
        Me.chktaan.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.txtpaymama)
        Me.Frame1.Controls.Add(Me.txtproc)
        Me.Frame1.Controls.Add(Me.txtfhaz)
        Me.Frame1.Controls.Add(Me.txtcode)
        Me.Frame1.Controls.Add(Me.txtpayden)
        Me.Frame1.Controls.Add(Me.txtpaymot)
        Me.Frame1.Controls.Add(Me.txtnamenos)
        Me.Frame1.Controls.Add(Me.Command2)
        Me.Frame1.Controls.Add(Me.txtnprint)
        Me.Frame1.Controls.Add(Me.txtkhas)
        Me.Frame1.Controls.Add(Me.cbo1)
        Me.Frame1.Controls.Add(Me.cmdnz)
        Me.Frame1.Controls.Add(Me.txtfname)
        Me.Frame1.Controls.Add(Me.txtdc)
        Me.Frame1.Controls.Add(Me.txtpt)
        Me.Frame1.Controls.Add(Me.txtpaydoc)
        Me.Frame1.Controls.Add(Me.txtorgan_name)
        Me.Frame1.Controls.Add(Me.txtorgan_code)
        Me.Frame1.Controls.Add(Me.txtbimar)
        Me.Frame1.Controls.Add(Me.txtorg)
        Me.Frame1.Controls.Add(Me.txtname)
        Me.Frame1.Controls.Add(Me.cmdlistcath)
        Me.Frame1.Controls.Add(Me._Label1_6)
        Me.Frame1.Controls.Add(Me._Label1_8)
        Me.Frame1.Controls.Add(Me._Label1_5)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Label1_7)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me._Label1_9)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(152, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(675, 408)
        Me.Frame1.TabIndex = 20
        Me.Frame1.TabStop = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdloop)
        Me.Frame2.Controls.Add(Me.cmdexit)
        Me.Frame2.Controls.Add(Me.cmdsave)
        Me.Frame2.Controls.Add(Me.cmddel)
        Me.Frame2.Controls.Add(Me.cmdlook)
        Me.Frame2.Controls.Add(Me.cmdcopy)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 320)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(655, 65)
        Me.Frame2.TabIndex = 13
        Me.Frame2.TabStop = False
        '
        'cmdloop
        '
        Me.cmdloop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdloop.Location = New System.Drawing.Point(159, 16)
        Me.cmdloop.Name = "cmdloop"
        Me.cmdloop.Size = New System.Drawing.Size(81, 41)
        Me.cmdloop.TabIndex = 58
        Me.cmdloop.Text = "ادامه"
        '
        'cmdexit
        '
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(8, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(73, 41)
        Me.cmdexit.TabIndex = 15
        Me.cmdexit.Text = "خروج"
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(88, 16)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(65, 41)
        Me.cmdsave.TabIndex = 14
        Me.cmdsave.Text = "ثبت"
        '
        'cmddel
        '
        Me.cmddel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddel.Location = New System.Drawing.Point(350, 16)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(97, 41)
        Me.cmddel.TabIndex = 57
        Me.cmddel.Text = "حذف"
        '
        'cmdlook
        '
        Me.cmdlook.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdlook.Location = New System.Drawing.Point(246, 16)
        Me.cmdlook.Name = "cmdlook"
        Me.cmdlook.Size = New System.Drawing.Size(97, 41)
        Me.cmdlook.TabIndex = 16
        Me.cmdlook.Text = "جستجو"
        '
        'cmdcopy
        '
        Me.cmdcopy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcopy.Location = New System.Drawing.Point(453, 16)
        Me.cmdcopy.Name = "cmdcopy"
        Me.cmdcopy.Size = New System.Drawing.Size(97, 41)
        Me.cmdcopy.TabIndex = 17
        Me.cmdcopy.Text = "کپی اطلاعات خدمت"
        '
        'txtpaymama
        '
        Me.txtpaymama.AcceptsReturn = True
        Me.txtpaymama.BackColor = System.Drawing.SystemColors.Window
        Me.txtpaymama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpaymama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtpaymama.Location = New System.Drawing.Point(224, 224)
        Me.txtpaymama.MaxLength = 0
        Me.txtpaymama.Name = "txtpaymama"
        Me.txtpaymama.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpaymama.Size = New System.Drawing.Size(70, 20)
        Me.txtpaymama.TabIndex = 11
        Me.txtpaymama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtproc
        '
        Me.txtproc.AcceptsReturn = True
        Me.txtproc.BackColor = System.Drawing.SystemColors.Window
        Me.txtproc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtproc.Location = New System.Drawing.Point(576, 48)
        Me.txtproc.MaxLength = 0
        Me.txtproc.Name = "txtproc"
        Me.txtproc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtproc.Size = New System.Drawing.Size(17, 20)
        Me.txtproc.TabIndex = 40
        Me.txtproc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtproc.Visible = False
        '
        'txtfhaz
        '
        Me.txtfhaz.AcceptsReturn = True
        Me.txtfhaz.BackColor = System.Drawing.SystemColors.Window
        Me.txtfhaz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfhaz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtfhaz.Location = New System.Drawing.Point(48, 184)
        Me.txtfhaz.MaxLength = 0
        Me.txtfhaz.Name = "txtfhaz"
        Me.txtfhaz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtfhaz.Size = New System.Drawing.Size(46, 20)
        Me.txtfhaz.TabIndex = 12
        Me.txtfhaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcode
        '
        Me.txtcode.AcceptsReturn = True
        Me.txtcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcode.Location = New System.Drawing.Point(480, 15)
        Me.txtcode.MaxLength = 0
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode.Size = New System.Drawing.Size(56, 20)
        Me.txtcode.TabIndex = 0
        '
        'txtpayden
        '
        Me.txtpayden.AcceptsReturn = True
        Me.txtpayden.BackColor = System.Drawing.SystemColors.Window
        Me.txtpayden.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtpayden.Location = New System.Drawing.Point(224, 184)
        Me.txtpayden.MaxLength = 0
        Me.txtpayden.Name = "txtpayden"
        Me.txtpayden.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpayden.Size = New System.Drawing.Size(70, 20)
        Me.txtpayden.TabIndex = 10
        Me.txtpayden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpaymot
        '
        Me.txtpaymot.AcceptsReturn = True
        Me.txtpaymot.BackColor = System.Drawing.SystemColors.Window
        Me.txtpaymot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpaymot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtpaymot.Location = New System.Drawing.Point(432, 224)
        Me.txtpaymot.MaxLength = 0
        Me.txtpaymot.Name = "txtpaymot"
        Me.txtpaymot.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpaymot.Size = New System.Drawing.Size(70, 20)
        Me.txtpaymot.TabIndex = 9
        Me.txtpaymot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnamenos
        '
        Me.txtnamenos.AcceptsReturn = True
        Me.txtnamenos.BackColor = System.Drawing.SystemColors.Window
        Me.txtnamenos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamenos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnamenos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnamenos.Location = New System.Drawing.Point(288, 288)
        Me.txtnamenos.MaxLength = 0
        Me.txtnamenos.Name = "txtnamenos"
        Me.txtnamenos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnamenos.Size = New System.Drawing.Size(183, 21)
        Me.txtnamenos.TabIndex = 36
        Me.txtnamenos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnprint
        '
        Me.txtnprint.AcceptsReturn = True
        Me.txtnprint.BackColor = System.Drawing.SystemColors.Window
        Me.txtnprint.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnprint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnprint.Location = New System.Drawing.Point(480, 288)
        Me.txtnprint.MaxLength = 0
        Me.txtnprint.Name = "txtnprint"
        Me.txtnprint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnprint.Size = New System.Drawing.Size(40, 20)
        Me.txtnprint.TabIndex = 13
        '
        'txtkhas
        '
        Me.txtkhas.AcceptsReturn = True
        Me.txtkhas.BackColor = System.Drawing.SystemColors.Window
        Me.txtkhas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkhas.Enabled = False
        Me.txtkhas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtkhas.Location = New System.Drawing.Point(392, 88)
        Me.txtkhas.MaxLength = 0
        Me.txtkhas.Name = "txtkhas"
        Me.txtkhas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtkhas.Size = New System.Drawing.Size(40, 20)
        Me.txtkhas.TabIndex = 4
        '
        'cbo1
        '
        Me.cbo1.BackColor = System.Drawing.SystemColors.Window
        Me.cbo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cbo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbo1.Location = New System.Drawing.Point(72, 88)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbo1.Size = New System.Drawing.Size(313, 21)
        Me.cbo1.TabIndex = 33
        '
        'txtfname
        '
        Me.txtfname.AcceptsReturn = True
        Me.txtfname.BackColor = System.Drawing.SystemColors.Window
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfname.Location = New System.Drawing.Point(224, 152)
        Me.txtfname.MaxLength = 0
        Me.txtfname.Name = "txtfname"
        Me.txtfname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtfname.Size = New System.Drawing.Size(121, 21)
        Me.txtfname.TabIndex = 6
        Me.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdc
        '
        Me.txtdc.AcceptsReturn = True
        Me.txtdc.BackColor = System.Drawing.SystemColors.Window
        Me.txtdc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdc.Location = New System.Drawing.Point(16, 152)
        Me.txtdc.MaxLength = 0
        Me.txtdc.Name = "txtdc"
        Me.txtdc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdc.Size = New System.Drawing.Size(129, 21)
        Me.txtdc.TabIndex = 7
        Me.txtdc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpt
        '
        Me.txtpt.AcceptsReturn = True
        Me.txtpt.BackColor = System.Drawing.SystemColors.Window
        Me.txtpt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtpt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpt.Location = New System.Drawing.Point(432, 152)
        Me.txtpt.MaxLength = 0
        Me.txtpt.Name = "txtpt"
        Me.txtpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpt.Size = New System.Drawing.Size(57, 21)
        Me.txtpt.TabIndex = 5
        Me.txtpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpaydoc
        '
        Me.txtpaydoc.AcceptsReturn = True
        Me.txtpaydoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtpaydoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpaydoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtpaydoc.Location = New System.Drawing.Point(432, 192)
        Me.txtpaydoc.MaxLength = 0
        Me.txtpaydoc.Name = "txtpaydoc"
        Me.txtpaydoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpaydoc.Size = New System.Drawing.Size(70, 20)
        Me.txtpaydoc.TabIndex = 8
        Me.txtpaydoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtorgan_name
        '
        Me.txtorgan_name.AcceptsReturn = True
        Me.txtorgan_name.BackColor = System.Drawing.SystemColors.Window
        Me.txtorgan_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtorgan_name.Enabled = False
        Me.txtorgan_name.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtorgan_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtorgan_name.Location = New System.Drawing.Point(39, 16)
        Me.txtorgan_name.MaxLength = 0
        Me.txtorgan_name.Name = "txtorgan_name"
        Me.txtorgan_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtorgan_name.Size = New System.Drawing.Size(247, 21)
        Me.txtorgan_name.TabIndex = 26
        Me.txtorgan_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtorgan_code
        '
        Me.txtorgan_code.AcceptsReturn = True
        Me.txtorgan_code.BackColor = System.Drawing.SystemColors.Window
        Me.txtorgan_code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtorgan_code.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtorgan_code.Location = New System.Drawing.Point(297, 15)
        Me.txtorgan_code.MaxLength = 0
        Me.txtorgan_code.Name = "txtorgan_code"
        Me.txtorgan_code.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtorgan_code.Size = New System.Drawing.Size(40, 20)
        Me.txtorgan_code.TabIndex = 19
        '
        'txtbimar
        '
        Me.txtbimar.AcceptsReturn = True
        Me.txtbimar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbimar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbimar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbimar.Location = New System.Drawing.Point(512, 117)
        Me.txtbimar.MaxLength = 0
        Me.txtbimar.Name = "txtbimar"
        Me.txtbimar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbimar.Size = New System.Drawing.Size(46, 20)
        Me.txtbimar.TabIndex = 3
        Me.txtbimar.Text = "30"
        Me.txtbimar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtorg
        '
        Me.txtorg.AcceptsReturn = True
        Me.txtorg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtorg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtorg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtorg.Location = New System.Drawing.Point(512, 87)
        Me.txtorg.MaxLength = 0
        Me.txtorg.Name = "txtorg"
        Me.txtorg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtorg.Size = New System.Drawing.Size(46, 20)
        Me.txtorg.TabIndex = 2
        Me.txtorg.Text = "70"
        Me.txtorg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtname
        '
        Me.txtname.AcceptsReturn = True
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtname.Location = New System.Drawing.Point(240, 48)
        Me.txtname.MaxLength = 0
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtname.Size = New System.Drawing.Size(298, 23)
        Me.txtname.TabIndex = 1
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdlistcath
        '
        Me.cmdlistcath.Location = New System.Drawing.Point(560, 8)
        Me.cmdlistcath.Name = "cmdlistcath"
        Me.cmdlistcath.Size = New System.Drawing.Size(81, 33)
        Me.cmdlistcath.TabIndex = 56
        Me.cmdlistcath.Text = "کد بیمه"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.Color.Transparent
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_6, CType(6, Short))
        Me._Label1_6.Location = New System.Drawing.Point(296, 184)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_6.Size = New System.Drawing.Size(120, 32)
        Me._Label1_6.TabIndex = 52
        Me._Label1_6.Text = "سقف تاييد  دندانپزشكان  "
        Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.Transparent
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_8, CType(8, Short))
        Me._Label1_8.Location = New System.Drawing.Point(296, 224)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_8.Size = New System.Drawing.Size(120, 40)
        Me._Label1_8.TabIndex = 51
        Me._Label1_8.Text = "سقف تاييد  ماما"
        Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(64, 384)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(461, 25)
        Me._Label1_5.TabIndex = 50
        Me._Label1_5.Text = "براي تکميل کردن اطلاعات مربوط به ديسکت با توجه به نوع بيمه از ليست ذيل استفاده نم" & _
            "اييد"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(100, 184)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_3.Size = New System.Drawing.Size(104, 32)
        Me._Label1_3.TabIndex = 38
        Me._Label1_3.Text = "اضافه قيمت ثابت نسخ بيمه"
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.Transparent
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_7, CType(7, Short))
        Me._Label1_7.Location = New System.Drawing.Point(512, 224)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_7.Size = New System.Drawing.Size(104, 32)
        Me._Label1_7.TabIndex = 37
        Me._Label1_7.Text = "سقف تاييد دارو پزشكان متخصص"
        Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.Color.Transparent
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(440, 88)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(37, 25)
        Me._Label1_4.TabIndex = 34
        Me._Label1_4.Text = "كد ويژه"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(352, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(78, 33)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "نام فايل XML"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(152, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(70, 33)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "كد پزشک درفايل XML"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(552, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(78, 33)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "كد سازمان درفايل XML"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(512, 192)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_2.Size = New System.Drawing.Size(104, 32)
        Me._Label1_2.TabIndex = 28
        Me._Label1_2.Text = "سقف تاييد  پزشكان عمومي"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(344, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "سازمان"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(560, 114)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_1.Size = New System.Drawing.Size(48, 32)
        Me._Label1_1.TabIndex = 25
        Me._Label1_1.Text = "سهم بيمار"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(494, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(13, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.Color.Transparent
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_9, CType(9, Short))
        Me._Label1_9.Location = New System.Drawing.Point(560, 78)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_9.Size = New System.Drawing.Size(48, 32)
        Me._Label1_9.TabIndex = 23
        Me._Label1_9.Text = "سهم سازمان"
        Me._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(491, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(13, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(552, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "نام "
        '
        'mh1
        '
        Me.mh1.ColumnInfo = "10,1,0,0,0,110,Columns:"
        Me.mh1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mh1.Location = New System.Drawing.Point(160, 408)
        Me.mh1.Name = "mh1"
        Me.mh1.Rows.DefaultSize = 22
        Me.mh1.Size = New System.Drawing.Size(665, 240)
        Me.mh1.StyleInfo = resources.GetString("mh1.StyleInfo")
        Me.mh1.TabIndex = 53
        '
        'frmcath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(827, 655)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.mh1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmcath"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "معرفي  بيمه ها"
        Me.Frame3.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdloop As System.Windows.Forms.Button
#End Region 
End Class