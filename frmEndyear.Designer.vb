<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndyear
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtsal = New System.Windows.Forms.TextBox
        Me.txtfile1 = New System.Windows.Forms.TextBox
        Me.txtsalnew = New System.Windows.Forms.TextBox
        Me.txtfile2 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdstart = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtsaheb = New System.Windows.Forms.TextBox
        Me.txtdat1 = New System.Windows.Forms.TextBox
        Me.txtdat2 = New System.Windows.Forms.TextBox
        Me.txtdbname = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfile1)
        Me.GroupBox1.Controls.Add(Me.txtsal)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "سال مالی فعلی"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtfile2)
        Me.GroupBox2.Controls.Add(Me.txtsalnew)
        Me.GroupBox2.Location = New System.Drawing.Point(122, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "سال مالی جدید"
        '
        'txtsal
        '
        Me.txtsal.Location = New System.Drawing.Point(13, 22)
        Me.txtsal.Name = "txtsal"
        Me.txtsal.Size = New System.Drawing.Size(108, 20)
        Me.txtsal.TabIndex = 0
        '
        'txtfile1
        '
        Me.txtfile1.Location = New System.Drawing.Point(13, 59)
        Me.txtfile1.Name = "txtfile1"
        Me.txtfile1.Size = New System.Drawing.Size(526, 20)
        Me.txtfile1.TabIndex = 1
        '
        'txtsalnew
        '
        Me.txtsalnew.Location = New System.Drawing.Point(14, 29)
        Me.txtsalnew.Name = "txtsalnew"
        Me.txtsalnew.Size = New System.Drawing.Size(100, 20)
        Me.txtsalnew.TabIndex = 0
        '
        'txtfile2
        '
        Me.txtfile2.Location = New System.Drawing.Point(14, 73)
        Me.txtfile2.Name = "txtfile2"
        Me.txtfile2.Size = New System.Drawing.Size(526, 20)
        Me.txtfile2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdstart)
        Me.GroupBox3.Controls.Add(Me.cmdexit)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 230)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'cmdstart
        '
        Me.cmdstart.BackColor = System.Drawing.Color.White
        Me.cmdstart.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmdstart.Image = Global.DaroNet.My.Resources.Resources.Redo
        Me.cmdstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdstart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdstart.Location = New System.Drawing.Point(6, 70)
        Me.cmdstart.Name = "cmdstart"
        Me.cmdstart.Size = New System.Drawing.Size(84, 41)
        Me.cmdstart.TabIndex = 178
        Me.cmdstart.Text = "شروع"
        Me.cmdstart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdstart.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdexit.Location = New System.Drawing.Point(6, 22)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(84, 41)
        Me.cmdexit.TabIndex = 177
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtdbname)
        Me.GroupBox4.Controls.Add(Me.txtdat2)
        Me.GroupBox4.Controls.Add(Me.txtdat1)
        Me.GroupBox4.Controls.Add(Me.txtsaheb)
        Me.GroupBox4.Location = New System.Drawing.Point(122, 269)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(541, 179)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مشخصات بانک اطلاعاتی"
        '
        'txtsaheb
        '
        Me.txtsaheb.Location = New System.Drawing.Point(46, 140)
        Me.txtsaheb.Name = "txtsaheb"
        Me.txtsaheb.Size = New System.Drawing.Size(467, 20)
        Me.txtsaheb.TabIndex = 1
        '
        'txtdat1
        '
        Me.txtdat1.Location = New System.Drawing.Point(333, 94)
        Me.txtdat1.Name = "txtdat1"
        Me.txtdat1.Size = New System.Drawing.Size(100, 20)
        Me.txtdat1.TabIndex = 2
        '
        'txtdat2
        '
        Me.txtdat2.Location = New System.Drawing.Point(172, 94)
        Me.txtdat2.Name = "txtdat2"
        Me.txtdat2.Size = New System.Drawing.Size(100, 20)
        Me.txtdat2.TabIndex = 3
        '
        'txtdbname
        '
        Me.txtdbname.Location = New System.Drawing.Point(235, 34)
        Me.txtdbname.Name = "txtdbname"
        Me.txtdbname.Size = New System.Drawing.Size(100, 20)
        Me.txtdbname.TabIndex = 4
        '
        'frmEndyear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 460)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEndyear"
        Me.Text = "اعلام پایان سال"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfile1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfile2 As System.Windows.Forms.TextBox
    Friend WithEvents txtsalnew As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents cmdstart As System.Windows.Forms.Button
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdbname As System.Windows.Forms.TextBox
    Friend WithEvents txtdat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdat1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsaheb As System.Windows.Forms.TextBox
End Class
