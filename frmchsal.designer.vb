<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmchsal
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
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1Font As System.Windows.Forms.FontDialog
	Public CommonDialog1Color As System.Windows.Forms.ColorDialog
	Public CommonDialog1Print As System.Windows.Forms.PrintDialog
	Public WithEvents txtpsal_path As System.Windows.Forms.TextBox
	Public WithEvents cmdsave As System.Windows.Forms.Button
	Public WithEvents txtsal As System.Windows.Forms.TextBox
	Public WithEvents txtdbname As System.Windows.Forms.TextBox
	Public WithEvents txtpath As System.Windows.Forms.TextBox
	Public WithEvents txtsaheb As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents txtid As System.Windows.Forms.TextBox
	Public WithEvents txtdat1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtdat2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
	Public WithEvents cmdexit As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button

	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchsal))
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me.txtAppId = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtMainPath = New System.Windows.Forms.TextBox
        Me.txtpsal_path = New System.Windows.Forms.TextBox
        Me.cmdsave = New System.Windows.Forms.Button
        Me.txtsal = New System.Windows.Forms.TextBox
        Me.txtdbname = New System.Windows.Forms.TextBox
        Me.txtpath = New System.Windows.Forms.TextBox
        Me.txtsaheb = New System.Windows.Forms.TextBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtdat1 = New System.Windows.Forms.MaskedTextBox
        Me.txtdat2 = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
        Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog
        Me.CommonDialog1Font = New System.Windows.Forms.FontDialog
        Me.CommonDialog1Color = New System.Windows.Forms.ColorDialog
        Me.CommonDialog1Print = New System.Windows.Forms.PrintDialog
        Me._Frame1_0 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.mh6 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmdexit = New System.Windows.Forms.Button
        Me.Command3 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLockPass = New System.Windows.Forms.TextBox
        Me._Frame2_0.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        CType(Me.mh6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Frame2_0.Controls.Add(Me.txtLockPass)
        Me._Frame2_0.Controls.Add(Me.Label8)
        Me._Frame2_0.Controls.Add(Me.txtAppId)
        Me._Frame2_0.Controls.Add(Me.Button2)
        Me._Frame2_0.Controls.Add(Me.Button1)
        Me._Frame2_0.Controls.Add(Me.txtMainPath)
        Me._Frame2_0.Controls.Add(Me.txtpsal_path)
        Me._Frame2_0.Controls.Add(Me.cmdsave)
        Me._Frame2_0.Controls.Add(Me.txtsal)
        Me._Frame2_0.Controls.Add(Me.txtdbname)
        Me._Frame2_0.Controls.Add(Me.txtpath)
        Me._Frame2_0.Controls.Add(Me.txtsaheb)
        Me._Frame2_0.Controls.Add(Me.Command5)
        Me._Frame2_0.Controls.Add(Me.txtid)
        Me._Frame2_0.Controls.Add(Me.txtdat1)
        Me._Frame2_0.Controls.Add(Me.txtdat2)
        Me._Frame2_0.Controls.Add(Me.Label7)
        Me._Frame2_0.Controls.Add(Me.Label3)
        Me._Frame2_0.Controls.Add(Me.Label4)
        Me._Frame2_0.Controls.Add(Me.Label2)
        Me._Frame2_0.Controls.Add(Me.Label5)
        Me._Frame2_0.Controls.Add(Me.Label12)
        Me._Frame2_0.Controls.Add(Me.Label11)
        Me._Frame2_0.Controls.Add(Me.Label6)
        Me._Frame2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_0.Location = New System.Drawing.Point(8, 384)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_0.Size = New System.Drawing.Size(713, 239)
        Me._Frame2_0.TabIndex = 5
        Me._Frame2_0.TabStop = False
        '
        'txtAppId
        '
        Me.txtAppId.AcceptsReturn = True
        Me.txtAppId.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAppId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtAppId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAppId.Location = New System.Drawing.Point(16, 16)
        Me.txtAppId.MaxLength = 0
        Me.txtAppId.Name = "txtAppId"
        Me.txtAppId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAppId.Size = New System.Drawing.Size(29, 23)
        Me.txtAppId.TabIndex = 29
        Me.txtAppId.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(608, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(89, 25)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "مسير Eoffice"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(264, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMainPath
        '
        Me.txtMainPath.AcceptsReturn = True
        Me.txtMainPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtMainPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainPath.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMainPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMainPath.Location = New System.Drawing.Point(27, 203)
        Me.txtMainPath.MaxLength = 0
        Me.txtMainPath.Name = "txtMainPath"
        Me.txtMainPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainPath.Size = New System.Drawing.Size(574, 23)
        Me.txtMainPath.TabIndex = 26
        '
        'txtpsal_path
        '
        Me.txtpsal_path.AcceptsReturn = True
        Me.txtpsal_path.BackColor = System.Drawing.SystemColors.Window
        Me.txtpsal_path.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsal_path.Enabled = False
        Me.txtpsal_path.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpsal_path.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtpsal_path.Location = New System.Drawing.Point(16, 45)
        Me.txtpsal_path.MaxLength = 0
        Me.txtpsal_path.Name = "txtpsal_path"
        Me.txtpsal_path.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpsal_path.Size = New System.Drawing.Size(121, 20)
        Me.txtpsal_path.TabIndex = 25
        Me.txtpsal_path.Visible = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdsave.Location = New System.Drawing.Point(408, 134)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdsave.Size = New System.Drawing.Size(65, 25)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "ثبت"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'txtsal
        '
        Me.txtsal.AcceptsReturn = True
        Me.txtsal.BackColor = System.Drawing.SystemColors.Window
        Me.txtsal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsal.Location = New System.Drawing.Point(552, 24)
        Me.txtsal.MaxLength = 0
        Me.txtsal.Name = "txtsal"
        Me.txtsal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsal.Size = New System.Drawing.Size(49, 23)
        Me.txtsal.TabIndex = 12
        Me.txtsal.Text = "1390"
        '
        'txtdbname
        '
        Me.txtdbname.AcceptsReturn = True
        Me.txtdbname.BackColor = System.Drawing.SystemColors.Window
        Me.txtdbname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdbname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdbname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdbname.Location = New System.Drawing.Point(288, 24)
        Me.txtdbname.MaxLength = 0
        Me.txtdbname.Name = "txtdbname"
        Me.txtdbname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdbname.Size = New System.Drawing.Size(153, 23)
        Me.txtdbname.TabIndex = 11
        Me.txtdbname.Text = "data1390.mdb"
        '
        'txtpath
        '
        Me.txtpath.AcceptsReturn = True
        Me.txtpath.BackColor = System.Drawing.SystemColors.Window
        Me.txtpath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpath.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtpath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpath.Location = New System.Drawing.Point(27, 174)
        Me.txtpath.MaxLength = 0
        Me.txtpath.Name = "txtpath"
        Me.txtpath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpath.Size = New System.Drawing.Size(574, 23)
        Me.txtpath.TabIndex = 10
        Me.txtpath.Text = "c:\daro"
        '
        'txtsaheb
        '
        Me.txtsaheb.AcceptsReturn = True
        Me.txtsaheb.BackColor = System.Drawing.SystemColors.Window
        Me.txtsaheb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsaheb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsaheb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsaheb.Location = New System.Drawing.Point(264, 96)
        Me.txtsaheb.MaxLength = 0
        Me.txtsaheb.Name = "txtsaheb"
        Me.txtsaheb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsaheb.Size = New System.Drawing.Size(337, 23)
        Me.txtsaheb.TabIndex = 9
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(607, 172)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(89, 25)
        Me.Command5.TabIndex = 8
        Me.Command5.Text = "آدرس فایل"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.AcceptsReturn = True
        Me.txtid.BackColor = System.Drawing.SystemColors.Window
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtid.Location = New System.Drawing.Point(144, 24)
        Me.txtid.MaxLength = 0
        Me.txtid.Name = "txtid"
        Me.txtid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtid.Size = New System.Drawing.Size(49, 23)
        Me.txtid.TabIndex = 6
        '
        'txtdat1
        '
        Me.txtdat1.AllowPromptAsInput = False
        Me.txtdat1.Location = New System.Drawing.Point(509, 64)
        Me.txtdat1.Mask = "1399/99/99"
        Me.txtdat1.Name = "txtdat1"
        Me.txtdat1.Size = New System.Drawing.Size(89, 20)
        Me.txtdat1.TabIndex = 14
        '
        'txtdat2
        '
        Me.txtdat2.AllowPromptAsInput = False
        Me.txtdat2.Location = New System.Drawing.Point(397, 64)
        Me.txtdat2.Mask = "1399/99/99"
        Me.txtdat2.Name = "txtdat2"
        Me.txtdat2.Size = New System.Drawing.Size(89, 20)
        Me.txtdat2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(624, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 33)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "سال "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(464, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 33)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "نام بانك اطلاعاتي"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(400, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 33)
        Me.Label4.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(201, 33)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "مسير فايل بايد بصورت آدرس فايل و نام فايل بطور کامل مشخص شود"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(216, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(41, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "کد"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(491, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "تا"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(605, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "از تاريخ"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(624, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "عنوان "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame1_0.Controls.Add(Me.Button3)
        Me._Frame1_0.Controls.Add(Me.mh6)
        Me._Frame1_0.Controls.Add(Me.cmdexit)
        Me._Frame1_0.Controls.Add(Me.Command3)
        Me._Frame1_0.Controls.Add(Me.Command1)
        Me._Frame1_0.Controls.Add(Me.Label1)
        Me._Frame1_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Frame1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_0.Location = New System.Drawing.Point(8, 12)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(721, 429)
        Me._Frame1_0.TabIndex = 0
        Me._Frame1_0.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(110, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(67, 25)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "حذف کامل"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'mh6
        '
        Me.mh6.AllowEditing = False
        Me.mh6.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.mh6.Location = New System.Drawing.Point(16, 17)
        Me.mh6.Name = "mh6"
        Me.mh6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mh6.Rows.DefaultSize = 20
        Me.mh6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.mh6.Size = New System.Drawing.Size(689, 287)
        Me.mh6.StyleInfo = resources.GetString("mh6.StyleInfo")
        Me.mh6.TabIndex = 25
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexit.Location = New System.Drawing.Point(190, 320)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdexit.Size = New System.Drawing.Size(67, 25)
        Me.cmdexit.TabIndex = 24
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(418, 320)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command3.Size = New System.Drawing.Size(86, 25)
        Me.Command3.TabIndex = 3
        Me.Command3.Text = "ويرايش"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(275, 320)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command1.Size = New System.Drawing.Size(137, 25)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "معرفي سال مالي جديد"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(539, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "کليد del حذف سال از ليست"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(285, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(41, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "رمز"
        '
        'txtLockPass
        '
        Me.txtLockPass.AcceptsReturn = True
        Me.txtLockPass.BackColor = System.Drawing.SystemColors.Window
        Me.txtLockPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLockPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtLockPass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLockPass.Location = New System.Drawing.Point(144, 62)
        Me.txtLockPass.MaxLength = 0
        Me.txtLockPass.Name = "txtLockPass"
        Me.txtLockPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLockPass.Size = New System.Drawing.Size(124, 23)
        Me.txtLockPass.TabIndex = 31
        '
        'frmchsal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(725, 635)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me._Frame1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmchsal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب سال مالي"
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me._Frame1_0.ResumeLayout(False)
        CType(Me.mh6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mh6 As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents txtMainPath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents txtAppId As System.Windows.Forms.TextBox
    Public WithEvents txtLockPass As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
#End Region
End Class