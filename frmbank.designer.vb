<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmbank
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cmdsave1 As System.Windows.Forms.Button
	Public WithEvents cmdnz As System.Windows.Forms.Button
    Public WithEvents mh1 As C1.Win.C1FlexGrid.C1FlexGrid
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbank))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command1 = New System.Windows.Forms.Button
        Me.cmdnz = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdsave1 = New System.Windows.Forms.Button
        Me.mh1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(64, 359)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command1.Size = New System.Drawing.Size(39, 42)
        Me.Command1.TabIndex = 3
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Command1, "ÎÑæÌ")
        Me.Command1.UseVisualStyleBackColor = False
        '
        'cmdnz
        '
        Me.cmdnz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdnz.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdnz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdnz.Location = New System.Drawing.Point(112, 359)
        Me.cmdnz.Name = "cmdnz"
        Me.cmdnz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdnz.Size = New System.Drawing.Size(69, 38)
        Me.cmdnz.TabIndex = 1
        Me.cmdnz.Text = "لیست بیمه ها"
        Me.cmdnz.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.Command1)
        Me.Frame1.Controls.Add(Me.cmdsave1)
        Me.Frame1.Controls.Add(Me.cmdnz)
        Me.Frame1.Controls.Add(Me.mh1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(651, 410)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'cmdsave1
        '
        Me.cmdsave1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmdsave1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdsave1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdsave1.Location = New System.Drawing.Point(16, 359)
        Me.cmdsave1.Name = "cmdsave1"
        Me.cmdsave1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdsave1.Size = New System.Drawing.Size(40, 40)
        Me.cmdsave1.TabIndex = 2
        Me.cmdsave1.Text = "ثبت"
        Me.cmdsave1.UseVisualStyleBackColor = False
        '
        'mh1
        '
        Me.mh1.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.mh1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mh1.Location = New System.Drawing.Point(8, 24)
        Me.mh1.Name = "mh1"
        Me.mh1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mh1.Rows.DefaultSize = 20
        Me.mh1.Size = New System.Drawing.Size(641, 329)
        Me.mh1.StyleInfo = resources.GetString("mh1.StyleInfo")
        Me.mh1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(192, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(449, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "برای هرکدام از بیمه های اصلی شماره حساب و سایر مشخصات را وارد نمایید و کلید ثبا ر" & _
            "ا بزنید"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmbank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(653, 411)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmbank"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "معرفی حسابهای بانکی"
        Me.Frame1.ResumeLayout(False)
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class