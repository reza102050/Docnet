<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmchkdel
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
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtrad As System.Windows.Forms.TextBox
	Public WithEvents txtidchek As System.Windows.Forms.TextBox
	Public WithEvents txtbank As System.Windows.Forms.TextBox
	Public WithEvents txtradif As System.Windows.Forms.TextBox
	Public WithEvents txtpay As System.Windows.Forms.TextBox
	Public WithEvents txtvaz As System.Windows.Forms.TextBox
	Public WithEvents txtbank_nam As System.Windows.Forms.TextBox
	Public WithEvents txtbank_cod As System.Windows.Forms.TextBox
	Public WithEvents txtnagh As System.Windows.Forms.TextBox
	Public WithEvents txtdate As System.Windows.Forms.MaskedTextBox
	Public WithEvents mdate As System.Windows.Forms.MaskedTextBox
	Public WithEvents _Label1_30 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents mh1 As c1.win.c1flexgrid.c1flexgrid
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchkdel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.txtrad = New System.Windows.Forms.TextBox
        Me.txtidchek = New System.Windows.Forms.TextBox
        Me.txtbank = New System.Windows.Forms.TextBox
        Me.txtradif = New System.Windows.Forms.TextBox
        Me.txtpay = New System.Windows.Forms.TextBox
        Me.txtvaz = New System.Windows.Forms.TextBox
        Me.txtbank_nam = New System.Windows.Forms.TextBox
        Me.txtbank_cod = New System.Windows.Forms.TextBox
        Me.txtnagh = New System.Windows.Forms.TextBox
        Me.txtdate = New System.Windows.Forms.MaskedTextBox
        Me.mdate = New System.Windows.Forms.MaskedTextBox
        Me._Label1_30 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.mh1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdloop = New System.Windows.Forms.Button
        Me.cmddel = New System.Windows.Forms.Button
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmddel)
        Me.Frame2.Controls.Add(Me.cmdexit)
        Me.Frame2.Controls.Add(Me.cmdloop)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(144, 160)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(270, 65)
        Me.Frame2.TabIndex = 18
        Me.Frame2.TabStop = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame3.Controls.Add(Me.txtrad)
        Me.Frame3.Controls.Add(Me.txtidchek)
        Me.Frame3.Controls.Add(Me.txtbank)
        Me.Frame3.Controls.Add(Me.txtradif)
        Me.Frame3.Controls.Add(Me.txtpay)
        Me.Frame3.Controls.Add(Me.txtvaz)
        Me.Frame3.Controls.Add(Me.txtbank_nam)
        Me.Frame3.Controls.Add(Me.txtbank_cod)
        Me.Frame3.Controls.Add(Me.txtnagh)
        Me.Frame3.Controls.Add(Me.txtdate)
        Me.Frame3.Controls.Add(Me.mdate)
        Me.Frame3.Controls.Add(Me._Label1_30)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(777, 233)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "مشخصات چک"
        '
        'txtrad
        '
        Me.txtrad.AcceptsReturn = True
        Me.txtrad.BackColor = System.Drawing.SystemColors.Window
        Me.txtrad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtrad.Location = New System.Drawing.Point(8, 56)
        Me.txtrad.MaxLength = 0
        Me.txtrad.Name = "txtrad"
        Me.txtrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtrad.Size = New System.Drawing.Size(25, 19)
        Me.txtrad.TabIndex = 9
        Me.txtrad.Text = "Text1"
        Me.txtrad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtrad.Visible = False
        '
        'txtidchek
        '
        Me.txtidchek.AcceptsReturn = True
        Me.txtidchek.BackColor = System.Drawing.SystemColors.Window
        Me.txtidchek.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidchek.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtidchek.Location = New System.Drawing.Point(504, 16)
        Me.txtidchek.MaxLength = 0
        Me.txtidchek.Name = "txtidchek"
        Me.txtidchek.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtidchek.Size = New System.Drawing.Size(105, 33)
        Me.txtidchek.TabIndex = 8
        Me.txtidchek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbank
        '
        Me.txtbank.AcceptsReturn = True
        Me.txtbank.BackColor = System.Drawing.SystemColors.Window
        Me.txtbank.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbank.Enabled = False
        Me.txtbank.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtbank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbank.Location = New System.Drawing.Point(400, 56)
        Me.txtbank.MaxLength = 0
        Me.txtbank.Name = "txtbank"
        Me.txtbank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbank.Size = New System.Drawing.Size(209, 33)
        Me.txtbank.TabIndex = 7
        Me.txtbank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtradif
        '
        Me.txtradif.AcceptsReturn = True
        Me.txtradif.BackColor = System.Drawing.SystemColors.Window
        Me.txtradif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtradif.Enabled = False
        Me.txtradif.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtradif.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtradif.Location = New System.Drawing.Point(240, 56)
        Me.txtradif.MaxLength = 0
        Me.txtradif.Name = "txtradif"
        Me.txtradif.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtradif.Size = New System.Drawing.Size(97, 33)
        Me.txtradif.TabIndex = 6
        Me.txtradif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpay
        '
        Me.txtpay.AcceptsReturn = True
        Me.txtpay.BackColor = System.Drawing.SystemColors.Window
        Me.txtpay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpay.Enabled = False
        Me.txtpay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtpay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpay.Location = New System.Drawing.Point(240, 96)
        Me.txtpay.MaxLength = 0
        Me.txtpay.Name = "txtpay"
        Me.txtpay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpay.Size = New System.Drawing.Size(97, 33)
        Me.txtpay.TabIndex = 5
        Me.txtpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvaz
        '
        Me.txtvaz.AcceptsReturn = True
        Me.txtvaz.BackColor = System.Drawing.SystemColors.Window
        Me.txtvaz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvaz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtvaz.Location = New System.Drawing.Point(120, 104)
        Me.txtvaz.MaxLength = 0
        Me.txtvaz.Name = "txtvaz"
        Me.txtvaz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvaz.Size = New System.Drawing.Size(25, 25)
        Me.txtvaz.TabIndex = 4
        Me.txtvaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtvaz.Visible = False
        '
        'txtbank_nam
        '
        Me.txtbank_nam.AcceptsReturn = True
        Me.txtbank_nam.BackColor = System.Drawing.SystemColors.Window
        Me.txtbank_nam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbank_nam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbank_nam.Location = New System.Drawing.Point(64, 104)
        Me.txtbank_nam.MaxLength = 0
        Me.txtbank_nam.Name = "txtbank_nam"
        Me.txtbank_nam.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbank_nam.Size = New System.Drawing.Size(41, 25)
        Me.txtbank_nam.TabIndex = 3
        Me.txtbank_nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbank_nam.Visible = False
        '
        'txtbank_cod
        '
        Me.txtbank_cod.AcceptsReturn = True
        Me.txtbank_cod.BackColor = System.Drawing.SystemColors.Window
        Me.txtbank_cod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbank_cod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbank_cod.Location = New System.Drawing.Point(64, 144)
        Me.txtbank_cod.MaxLength = 0
        Me.txtbank_cod.Name = "txtbank_cod"
        Me.txtbank_cod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbank_cod.Size = New System.Drawing.Size(49, 25)
        Me.txtbank_cod.TabIndex = 2
        Me.txtbank_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbank_cod.Visible = False
        '
        'txtnagh
        '
        Me.txtnagh.AcceptsReturn = True
        Me.txtnagh.BackColor = System.Drawing.SystemColors.Window
        Me.txtnagh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnagh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnagh.Location = New System.Drawing.Point(16, 200)
        Me.txtnagh.MaxLength = 0
        Me.txtnagh.Name = "txtnagh"
        Me.txtnagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnagh.Size = New System.Drawing.Size(33, 19)
        Me.txtnagh.TabIndex = 1
        Me.txtnagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnagh.Visible = False
        '
        'txtdate
        '
        Me.txtdate.AllowPromptAsInput = False
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(520, 96)
        Me.txtdate.Mask = "9999/99/99"
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(89, 21)
        Me.txtdate.TabIndex = 10
        '
        'mdate
        '
        Me.mdate.AllowPromptAsInput = False
        Me.mdate.Location = New System.Drawing.Point(520, 136)
        Me.mdate.Mask = "9999/99/99"
        Me.mdate.Name = "mdate"
        Me.mdate.Size = New System.Drawing.Size(89, 21)
        Me.mdate.TabIndex = 11
        '
        '_Label1_30
        '
        Me._Label1_30.BackColor = System.Drawing.Color.Transparent
        Me._Label1_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_30, CType(30, Short))
        Me._Label1_30.Location = New System.Drawing.Point(626, 144)
        Me._Label1_30.Name = "_Label1_30"
        Me._Label1_30.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label1_30.Size = New System.Drawing.Size(83, 23)
        Me._Label1_30.TabIndex = 17
        Me._Label1_30.Text = "تاریخ وصول"
        Me._Label1_30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(624, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "شماره چک"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(632, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "بانک"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(616, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "تاریخ سررسید"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(343, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "مبلغ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(343, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(48, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ردیف"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mh1
        '
        Me.mh1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.mh1.Location = New System.Drawing.Point(0, 240)
        Me.mh1.Name = "mh1"
        Me.mh1.Rows.DefaultSize = 19
        Me.mh1.Size = New System.Drawing.Size(777, 241)
        Me.mh1.TabIndex = 23
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.Location = New System.Drawing.Point(19, 12)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(74, 41)
        Me.cmdexit.TabIndex = 179
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdloop
        '
        Me.cmdloop.BackColor = System.Drawing.Color.White
        Me.cmdloop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdloop.Image = CType(resources.GetObject("cmdloop.Image"), System.Drawing.Image)
        Me.cmdloop.Location = New System.Drawing.Point(179, 12)
        Me.cmdloop.Name = "cmdloop"
        Me.cmdloop.Size = New System.Drawing.Size(76, 41)
        Me.cmdloop.TabIndex = 181
        Me.cmdloop.Text = "ادامه"
        Me.cmdloop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdloop.UseVisualStyleBackColor = False
        '
        'cmddel
        '
        Me.cmddel.BackColor = System.Drawing.Color.White
        Me.cmddel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddel.Image = Global.DaroNet.My.Resources.Resources.Delete
        Me.cmddel.Location = New System.Drawing.Point(103, 12)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(70, 41)
        Me.cmddel.TabIndex = 182
        Me.cmddel.Text = "حذف"
        Me.cmddel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmddel.UseVisualStyleBackColor = False
        '
        'frmchkdel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(782, 487)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.mh1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmchkdel"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "حذف چک"
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.mh1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdloop As System.Windows.Forms.Button
    Public WithEvents cmddel As System.Windows.Forms.Button
#End Region 
End Class