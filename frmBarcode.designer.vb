<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBarcode
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
	Public WithEvents txtdaro_fname As System.Windows.Forms.TextBox
	Public WithEvents txtcode As System.Windows.Forms.TextBox
    Public WithEvents mh4 As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents cmdexit As Windows.Forms.Button
    Public WithEvents cmdrefresh As Windows.Forms.Button
    Public WithEvents cmdsave As Windows.Forms.Button
	Public WithEvents _Label1_8 As System.Windows.Forms.Label
	Public WithEvents _Label1_31 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtdaro_fname = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.mh4 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdrefresh = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_31 = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        CType(Me.mh4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdaro_fname
        '
        Me.txtdaro_fname.AcceptsReturn = True
        Me.txtdaro_fname.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaro_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaro_fname.Font = New System.Drawing.Font("Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdaro_fname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaro_fname.Location = New System.Drawing.Point(72, 40)
        Me.txtdaro_fname.MaxLength = 0
        Me.txtdaro_fname.Name = "txtdaro_fname"
        Me.txtdaro_fname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdaro_fname.Size = New System.Drawing.Size(379, 28)
        Me.txtdaro_fname.TabIndex = 2
        Me.txtdaro_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcode
        '
        Me.txtcode.AcceptsReturn = True
        Me.txtcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.Font = New System.Drawing.Font("Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcode.Location = New System.Drawing.Point(344, 8)
        Me.txtcode.MaxLength = 10
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode.Size = New System.Drawing.Size(107, 28)
        Me.txtcode.TabIndex = 1
        '
        'mh4
        '
        Me.mh4.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.mh4.Location = New System.Drawing.Point(96, 80)
        Me.mh4.Name = "mh4"
        Me.mh4.Rows.DefaultSize = 19
        Me.mh4.Size = New System.Drawing.Size(353, 400)
        Me.mh4.TabIndex = 0
        '
        'cmdexit
        '
        Me.cmdexit.Location = New System.Drawing.Point(16, 248)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(73, 41)
        Me.cmdexit.TabIndex = 5
        Me.cmdexit.Text = "خروج"
        '
        'cmdrefresh
        '
        Me.cmdrefresh.Location = New System.Drawing.Point(16, 200)
        Me.cmdrefresh.Name = "cmdrefresh"
        Me.cmdrefresh.Size = New System.Drawing.Size(73, 41)
        Me.cmdrefresh.TabIndex = 6
        Me.cmdrefresh.Text = "بروزرسانی"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(16, 152)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(73, 41)
        Me.cmdsave.TabIndex = 7
        Me.cmdsave.Text = "ثبت"
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.Transparent
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_8, CType(8, Short))
        Me._Label1_8.Location = New System.Drawing.Point(457, 40)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_8.Size = New System.Drawing.Size(71, 23)
        Me._Label1_8.TabIndex = 4
        Me._Label1_8.Text = "نام دارو"
        Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_31
        '
        Me._Label1_31.BackColor = System.Drawing.Color.Transparent
        Me._Label1_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_31.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_31, CType(31, Short))
        Me._Label1_31.Location = New System.Drawing.Point(456, 8)
        Me._Label1_31.Name = "_Label1_31"
        Me._Label1_31.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_31.Size = New System.Drawing.Size(55, 23)
        Me._Label1_31.TabIndex = 3
        Me._Label1_31.Text = "كد دارو"
        Me._Label1_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(548, 487)
        Me.Controls.Add(Me.txtdaro_fname)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.mh4)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdrefresh)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_31)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmBarcode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "باركد"
        CType(Me.mh4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class