<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmamar
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
	Public WithEvents txtmonth As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents txtdat1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents mh1 As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmamar))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdDo = New System.Windows.Forms.Button
        Me.cmdDayReport = New System.Windows.Forms.Button
        Me.cmdHour = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.txtmonth = New System.Windows.Forms.TextBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.Command4 = New System.Windows.Forms.Button
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.txtdat1 = New System.Windows.Forms.MaskedTextBox
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.mh1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmdDo)
        Me.Frame1.Controls.Add(Me.cmdDayReport)
        Me.Frame1.Controls.Add(Me.cmdHour)
        Me.Frame1.Controls.Add(Me.cmdexit)
        Me.Frame1.Controls.Add(Me.txtmonth)
        Me.Frame1.Controls.Add(Me.Command5)
        Me.Frame1.Controls.Add(Me.Command4)
        Me.Frame1.Controls.Add(Me.Text2)
        Me.Frame1.Controls.Add(Me.Text1)
        Me.Frame1.Controls.Add(Me.txtdat1)
        Me.Frame1.Controls.Add(Me._Label1_5)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(967, 127)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'cmdDo
        '
        Me.cmdDo.BackColor = System.Drawing.Color.White
        Me.cmdDo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdDo.Image = Global.DaroNet.My.Resources.Resources.Preview_321
        Me.cmdDo.Location = New System.Drawing.Point(688, 64)
        Me.cmdDo.Name = "cmdDo"
        Me.cmdDo.Size = New System.Drawing.Size(87, 41)
        Me.cmdDo.TabIndex = 174
        Me.cmdDo.Text = "ماهیانه"
        Me.cmdDo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdDo.UseVisualStyleBackColor = False
        '
        'cmdDayReport
        '
        Me.cmdDayReport.BackColor = System.Drawing.Color.White
        Me.cmdDayReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdDayReport.Image = Global.DaroNet.My.Resources.Resources.Preview_321
        Me.cmdDayReport.Location = New System.Drawing.Point(688, 13)
        Me.cmdDayReport.Name = "cmdDayReport"
        Me.cmdDayReport.Size = New System.Drawing.Size(87, 41)
        Me.cmdDayReport.TabIndex = 173
        Me.cmdDayReport.Text = "روزانه"
        Me.cmdDayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdDayReport.UseVisualStyleBackColor = False
        '
        'cmdHour
        '
        Me.cmdHour.BackColor = System.Drawing.Color.White
        Me.cmdHour.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdHour.Image = Global.DaroNet.My.Resources.Resources.Preview_321
        Me.cmdHour.Location = New System.Drawing.Point(116, 24)
        Me.cmdHour.Name = "cmdHour"
        Me.cmdHour.Size = New System.Drawing.Size(87, 41)
        Me.cmdHour.TabIndex = 172
        Me.cmdHour.Text = "گزارش"
        Me.cmdHour.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdHour.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.Location = New System.Drawing.Point(23, 24)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(87, 41)
        Me.cmdexit.TabIndex = 171
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'txtmonth
        '
        Me.txtmonth.AcceptsReturn = True
        Me.txtmonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtmonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmonth.Location = New System.Drawing.Point(816, 64)
        Me.txtmonth.MaxLength = 0
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmonth.Size = New System.Drawing.Size(40, 20)
        Me.txtmonth.TabIndex = 9
        Me.txtmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(376, 24)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(49, 21)
        Me.Command5.TabIndex = 6
        Me.Command5.Text = "تا ساعت"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(568, 24)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(49, 21)
        Me.Command4.TabIndex = 5
        Me.Command4.Text = "از ساعت"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(240, 24)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(129, 20)
        Me.Text2.TabIndex = 4
        Me.Text2.Text = " "
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(432, 24)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(129, 20)
        Me.Text1.TabIndex = 3
        Me.Text1.Text = " "
        '
        'txtdat1
        '
        Me.txtdat1.AllowPromptAsInput = False
        Me.txtdat1.Location = New System.Drawing.Point(816, 24)
        Me.txtdat1.Mask = "1399/99/99"
        Me.txtdat1.Name = "txtdat1"
        Me.txtdat1.Size = New System.Drawing.Size(89, 20)
        Me.txtdat1.TabIndex = 1
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(904, 64)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_5.Size = New System.Drawing.Size(49, 31)
        Me._Label1_5.TabIndex = 10
        Me._Label1_5.Text = "ماه"
        Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(240, 56)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_1.Size = New System.Drawing.Size(361, 31)
        Me._Label1_1.TabIndex = 7
        Me._Label1_1.Text = "برای مشاهده محدوده ساعت برروی از تا کلیک نمایید"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(904, 24)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_0.Size = New System.Drawing.Size(49, 31)
        Me._Label1_0.TabIndex = 2
        Me._Label1_0.Text = "تاریخ"
        Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mh1
        '
        Me.mh1.AllowEditing = False
        Me.mh1.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.mh1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mh1.Location = New System.Drawing.Point(0, 128)
        Me.mh1.Name = "mh1"
        Me.mh1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mh1.Rows.DefaultSize = 20
        Me.mh1.Size = New System.Drawing.Size(969, 489)
        Me.mh1.StyleInfo = resources.GetString("mh1.StyleInfo")
        Me.mh1.TabIndex = 8
        '
        'frmamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(974, 626)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.mh1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmamar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "آمارگزارش ساعتی فروش"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdHour As System.Windows.Forms.Button
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdDo As System.Windows.Forms.Button
    Public WithEvents cmdDayReport As System.Windows.Forms.Button
#End Region 
End Class