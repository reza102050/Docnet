<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmcopysar
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
	Public WithEvents cmdplus As System.Windows.Forms.Button
	Public WithEvents cmdexit As System.Windows.Forms.Button
	Public WithEvents cmdsave As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtnamek As System.Windows.Forms.TextBox
	Public WithEvents txtkol As System.Windows.Forms.TextBox
	Public WithEvents txtmon As System.Windows.Forms.TextBox
	Public WithEvents txtnamem As System.Windows.Forms.TextBox
    Public WithEvents mh1 As c1.win.c1flexgrid.c1flexgrid
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdplus = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.txtnamek = New System.Windows.Forms.TextBox
        Me.txtkol = New System.Windows.Forms.TextBox
        Me.txtmon = New System.Windows.Forms.TextBox
        Me.txtnamem = New System.Windows.Forms.TextBox
        Me.mh1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdplus
        '
        Me.cmdplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdplus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdplus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdplus.Location = New System.Drawing.Point(40, 64)
        Me.cmdplus.Name = "cmdplus"
        Me.cmdplus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdplus.Size = New System.Drawing.Size(33, 25)
        Me.cmdplus.TabIndex = 10
        Me.cmdplus.Text = "+"
        Me.ToolTip1.SetToolTip(Me.cmdplus, "ÇÖÇÝå ßÑÏä ÓÑÝÕá ÌÏíÏ Èå áíÓÊ")
        Me.cmdplus.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmdexit)
        Me.Frame1.Controls.Add(Me.cmdsave)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(192, 496)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(174, 64)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexit.Location = New System.Drawing.Point(24, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdexit.Size = New System.Drawing.Size(57, 34)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "ÎÑæÌ"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdsave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdsave.Location = New System.Drawing.Point(88, 24)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdsave.Size = New System.Drawing.Size(60, 29)
        Me.cmdsave.TabIndex = 2
        Me.cmdsave.Text = "ËÈÊ"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'txtnamek
        '
        Me.txtnamek.AcceptsReturn = True
        Me.txtnamek.BackColor = System.Drawing.SystemColors.Window
        Me.txtnamek.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamek.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnamek.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnamek.Location = New System.Drawing.Point(90, 16)
        Me.txtnamek.MaxLength = 0
        Me.txtnamek.Name = "txtnamek"
        Me.txtnamek.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnamek.Size = New System.Drawing.Size(330, 31)
        Me.txtnamek.TabIndex = 5
        Me.txtnamek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtkol
        '
        Me.txtkol.AcceptsReturn = True
        Me.txtkol.BackColor = System.Drawing.SystemColors.Window
        Me.txtkol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtkol.Location = New System.Drawing.Point(429, 16)
        Me.txtkol.MaxLength = 0
        Me.txtkol.Name = "txtkol"
        Me.txtkol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtkol.Size = New System.Drawing.Size(41, 31)
        Me.txtkol.TabIndex = 0
        '
        'txtmon
        '
        Me.txtmon.AcceptsReturn = True
        Me.txtmon.BackColor = System.Drawing.SystemColors.Window
        Me.txtmon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmon.Location = New System.Drawing.Point(426, 64)
        Me.txtmon.MaxLength = 0
        Me.txtmon.Name = "txtmon"
        Me.txtmon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmon.Size = New System.Drawing.Size(41, 31)
        Me.txtmon.TabIndex = 1
        '
        'txtnamem
        '
        Me.txtnamem.AcceptsReturn = True
        Me.txtnamem.BackColor = System.Drawing.SystemColors.Window
        Me.txtnamem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnamem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnamem.Location = New System.Drawing.Point(90, 64)
        Me.txtnamem.MaxLength = 0
        Me.txtnamem.Name = "txtnamem"
        Me.txtnamem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnamem.Size = New System.Drawing.Size(330, 31)
        Me.txtnamem.TabIndex = 4
        Me.txtnamem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mh1
        '
        Me.mh1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.mh1.Location = New System.Drawing.Point(8, 120)
        Me.mh1.Name = "mh1"
        Me.mh1.Rows.DefaultSize = 19
        Me.mh1.Size = New System.Drawing.Size(545, 365)
        Me.mh1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(480, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "کل"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(472, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "معین"
        '
        'frmcopysar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(557, 562)
        Me.Controls.Add(Me.cmdplus)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.txtnamek)
        Me.Controls.Add(Me.txtkol)
        Me.Controls.Add(Me.txtmon)
        Me.Controls.Add(Me.txtnamem)
        Me.Controls.Add(Me.mh1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmcopysar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.ResumeLayout(False)
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class