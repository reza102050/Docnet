<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmedit
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
	Public WithEvents txtname As System.Windows.Forms.TextBox
	Public WithEvents txtcath As System.Windows.Forms.TextBox
	Public WithEvents txtmonth As System.Windows.Forms.TextBox
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelzero = New System.Windows.Forms.Button()
        Me.cmdSort = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcath = New System.Windows.Forms.TextBox()
        Me.txtmonth = New System.Windows.Forms.TextBox()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.txtTafkik = New System.Windows.Forms.TextBox()
        Me.opttip2 = New System.Windows.Forms.RadioButton()
        Me.opttip1 = New System.Windows.Forms.RadioButton()
        Me.opttip0 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.txtTafkik)
        Me.Frame2.Controls.Add(Me.opttip2)
        Me.Frame2.Controls.Add(Me.opttip1)
        Me.Frame2.Controls.Add(Me.opttip0)
        Me.Frame2.Controls.Add(Me.cmdDelzero)
        Me.Frame2.Controls.Add(Me.cmdSort)
        Me.Frame2.Controls.Add(Me.cmdexit)
        Me.Frame2.Controls.Add(Me.txtname)
        Me.Frame2.Controls.Add(Me.txtcath)
        Me.Frame2.Controls.Add(Me.txtmonth)
        Me.Frame2.Controls.Add(Me._Label1_0)
        Me.Frame2.Controls.Add(Me._Label1_5)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 1)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(751, 209)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        '
        'cmdDelzero
        '
        Me.cmdDelzero.BackColor = System.Drawing.Color.White
        Me.cmdDelzero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdDelzero.Image = Global.DaroNet.My.Resources.Resources.Delete
        Me.cmdDelzero.Location = New System.Drawing.Point(451, 158)
        Me.cmdDelzero.Name = "cmdDelzero"
        Me.cmdDelzero.Size = New System.Drawing.Size(175, 41)
        Me.cmdDelzero.TabIndex = 175
        Me.cmdDelzero.Text = "حذف نسخه های با مبلغ صفر"
        Me.cmdDelzero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdDelzero.UseVisualStyleBackColor = False
        '
        'cmdSort
        '
        Me.cmdSort.BackColor = System.Drawing.Color.White
        Me.cmdSort.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdSort.Image = Global.DaroNet.My.Resources.Resources.Edit1
        Me.cmdSort.Location = New System.Drawing.Point(245, 158)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(189, 41)
        Me.cmdSort.TabIndex = 174
        Me.cmdSort.Text = "مرتب نمودن نسخ ها براساس تاریخ"
        Me.cmdSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdSort.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.Location = New System.Drawing.Point(165, 158)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(74, 41)
        Me.cmdexit.TabIndex = 173
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.AcceptsReturn = True
        Me.txtname.BackColor = System.Drawing.SystemColors.Window
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtname.Location = New System.Drawing.Point(136, 16)
        Me.txtname.MaxLength = 0
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtname.Size = New System.Drawing.Size(298, 23)
        Me.txtname.TabIndex = 8
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcath
        '
        Me.txtcath.AcceptsReturn = True
        Me.txtcath.BackColor = System.Drawing.SystemColors.Window
        Me.txtcath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcath.Location = New System.Drawing.Point(448, 15)
        Me.txtcath.MaxLength = 0
        Me.txtcath.Name = "txtcath"
        Me.txtcath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcath.Size = New System.Drawing.Size(40, 21)
        Me.txtcath.TabIndex = 1
        Me.txtcath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtmonth
        '
        Me.txtmonth.AcceptsReturn = True
        Me.txtmonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtmonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmonth.Location = New System.Drawing.Point(580, 15)
        Me.txtmonth.MaxLength = 0
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmonth.Size = New System.Drawing.Size(40, 21)
        Me.txtmonth.TabIndex = 0
        Me.txtmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(649, 16)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(70, 25)
        Me._Label1_0.TabIndex = 7
        Me._Label1_0.Text = "ماه نسخه"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(494, 18)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_5.Size = New System.Drawing.Size(62, 23)
        Me._Label1_5.TabIndex = 6
        Me._Label1_5.Text = "کد بیمه"
        Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTafkik
        '
        Me.txtTafkik.AcceptsReturn = True
        Me.txtTafkik.BackColor = System.Drawing.SystemColors.Window
        Me.txtTafkik.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTafkik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtTafkik.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTafkik.Location = New System.Drawing.Point(597, 129)
        Me.txtTafkik.MaxLength = 0
        Me.txtTafkik.Name = "txtTafkik"
        Me.txtTafkik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTafkik.Size = New System.Drawing.Size(40, 26)
        Me.txtTafkik.TabIndex = 179
        Me.txtTafkik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTafkik.Visible = False
        '
        'opttip2
        '
        Me.opttip2.AutoSize = True
        Me.opttip2.Checked = True
        Me.opttip2.Location = New System.Drawing.Point(580, 55)
        Me.opttip2.Name = "opttip2"
        Me.opttip2.Size = New System.Drawing.Size(84, 17)
        Me.opttip2.TabIndex = 178
        Me.opttip2.TabStop = True
        Me.opttip2.Text = "ویزیت/خدمت"
        Me.opttip2.UseVisualStyleBackColor = True
        '
        'opttip1
        '
        Me.opttip1.AutoSize = True
        Me.opttip1.Location = New System.Drawing.Point(610, 106)
        Me.opttip1.Name = "opttip1"
        Me.opttip1.Size = New System.Drawing.Size(54, 17)
        Me.opttip1.TabIndex = 177
        Me.opttip1.Text = "خدمت"
        Me.opttip1.UseVisualStyleBackColor = True
        '
        'opttip0
        '
        Me.opttip0.AutoSize = True
        Me.opttip0.Location = New System.Drawing.Point(610, 79)
        Me.opttip0.Name = "opttip0"
        Me.opttip0.Size = New System.Drawing.Size(51, 17)
        Me.opttip0.TabIndex = 176
        Me.opttip0.Text = "ویزیت"
        Me.opttip0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(669, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "تفکیک"
        '
        'frmedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(751, 212)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmedit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مرتب نمودن نسخ براساس تاریخ"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdDelzero As System.Windows.Forms.Button
    Public WithEvents cmdSort As System.Windows.Forms.Button
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtTafkik As System.Windows.Forms.TextBox
    Friend WithEvents opttip2 As System.Windows.Forms.RadioButton
    Friend WithEvents opttip1 As System.Windows.Forms.RadioButton
    Friend WithEvents opttip0 As System.Windows.Forms.RadioButton
#End Region 
End Class