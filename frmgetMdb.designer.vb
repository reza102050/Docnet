<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmgetMdb
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents txtpath As System.Windows.Forms.TextBox
	Public WithEvents txtdbname As System.Windows.Forms.TextBox
	Public WithEvents txtsal As System.Windows.Forms.TextBox
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDbnameE = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtMainPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command5 = New System.Windows.Forms.Button()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.txtdbname = New System.Windows.Forms.TextBox()
        Me.txtsal = New System.Windows.Forms.TextBox()
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Frame1.Controls.Add(Me.Button3)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.txtDbnameE)
        Me.Frame1.Controls.Add(Me.Button2)
        Me.Frame1.Controls.Add(Me.txtMainPath)
        Me.Frame1.Controls.Add(Me.Button1)
        Me.Frame1.Controls.Add(Me.Command2)
        Me.Frame1.Controls.Add(Me.Command5)
        Me.Frame1.Controls.Add(Me.txtpath)
        Me.Frame1.Controls.Add(Me.txtdbname)
        Me.Frame1.Controls.Add(Me.txtsal)
        Me.Frame1.Controls.Add(Me.File1)
        Me.Frame1.Controls.Add(Me.Dir1)
        Me.Frame1.Controls.Add(Me.Drive1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(703, 546)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(368, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 33)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "نام بانك اطلاعاتي"
        '
        'txtDbnameE
        '
        Me.txtDbnameE.AcceptsReturn = True
        Me.txtDbnameE.BackColor = System.Drawing.SystemColors.Window
        Me.txtDbnameE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDbnameE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtDbnameE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDbnameE.Location = New System.Drawing.Point(168, 480)
        Me.txtDbnameE.MaxLength = 0
        Me.txtDbnameE.Name = "txtDbnameE"
        Me.txtDbnameE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDbnameE.Size = New System.Drawing.Size(153, 23)
        Me.txtDbnameE.TabIndex = 31
        Me.txtDbnameE.Text = "Eoffice.mdb"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(589, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(89, 25)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "مسير Eoffice"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtMainPath
        '
        Me.txtMainPath.AcceptsReturn = True
        Me.txtMainPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtMainPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainPath.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMainPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMainPath.Location = New System.Drawing.Point(12, 509)
        Me.txtMainPath.MaxLength = 0
        Me.txtMainPath.Name = "txtMainPath"
        Me.txtMainPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainPath.Size = New System.Drawing.Size(571, 23)
        Me.txtMainPath.TabIndex = 29
        Me.txtMainPath.Text = "c:\daro"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(430, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ایجادفایل سال مالی"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(430, 113)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(137, 25)
        Me.Command2.TabIndex = 10
        Me.Command2.Text = "  Ok"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(589, 440)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(89, 25)
        Me.Command5.TabIndex = 9
        Me.Command5.Text = "مسير فايل data"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'txtpath
        '
        Me.txtpath.AcceptsReturn = True
        Me.txtpath.BackColor = System.Drawing.SystemColors.Window
        Me.txtpath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpath.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtpath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpath.Location = New System.Drawing.Point(12, 442)
        Me.txtpath.MaxLength = 0
        Me.txtpath.Name = "txtpath"
        Me.txtpath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpath.Size = New System.Drawing.Size(570, 23)
        Me.txtpath.TabIndex = 8
        Me.txtpath.Text = "c:\daro"
        '
        'txtdbname
        '
        Me.txtdbname.AcceptsReturn = True
        Me.txtdbname.BackColor = System.Drawing.SystemColors.Window
        Me.txtdbname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdbname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdbname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdbname.Location = New System.Drawing.Point(168, 408)
        Me.txtdbname.MaxLength = 0
        Me.txtdbname.Name = "txtdbname"
        Me.txtdbname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdbname.Size = New System.Drawing.Size(153, 23)
        Me.txtdbname.TabIndex = 5
        Me.txtdbname.Text = "Data1390.mdb"
        '
        'txtsal
        '
        Me.txtsal.AcceptsReturn = True
        Me.txtsal.BackColor = System.Drawing.SystemColors.Window
        Me.txtsal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsal.Location = New System.Drawing.Point(456, 408)
        Me.txtsal.MaxLength = 0
        Me.txtsal.Name = "txtsal"
        Me.txtsal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsal.Size = New System.Drawing.Size(49, 23)
        Me.txtsal.TabIndex = 4
        Me.txtsal.Text = "1390"
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        Me.File1.Location = New System.Drawing.Point(224, 24)
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.*"
        Me.File1.Size = New System.Drawing.Size(185, 355)
        Me.File1.TabIndex = 3
        '
        'Dir1
        '
        Me.Dir1.BackColor = System.Drawing.SystemColors.Window
        Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dir1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(8, 40)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.Size = New System.Drawing.Size(161, 351)
        Me.Dir1.TabIndex = 2
        '
        'Drive1
        '
        Me.Drive1.BackColor = System.Drawing.SystemColors.Window
        Me.Drive1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drive1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Drive1.FormattingEnabled = True
        Me.Drive1.Location = New System.Drawing.Point(8, 16)
        Me.Drive1.Name = "Drive1"
        Me.Drive1.Size = New System.Drawing.Size(161, 21)
        Me.Drive1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(368, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "نام بانك اطلاعاتي"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(528, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "سال "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(430, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "حذف تنظمیات رجیستری"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmgetMdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(705, 544)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmgetMdb"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فايل اطلاعاتي را مشخص کنيد"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents txtMainPath As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtDbnameE As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
#End Region 
End Class