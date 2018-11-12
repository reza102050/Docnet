<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateDbfromTemplate
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
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMpath = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtfile1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtsal = New System.Windows.Forms.TextBox()
        Me.txtfile2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(287, 167)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(58, 41)
        Me.cmdexit.TabIndex = 168
        Me.cmdexit.Text = "خروج"
        Me.cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(351, 167)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(52, 41)
        Me.cmdsave.TabIndex = 169
        Me.cmdsave.Text = "ثبت"
        Me.cmdsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMpath)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.txtfile1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtsal)
        Me.GroupBox2.Controls.Add(Me.txtfile2)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 214)
        Me.GroupBox2.TabIndex = 170
        Me.GroupBox2.TabStop = False
        '
        'txtMpath
        '
        Me.txtMpath.Location = New System.Drawing.Point(14, 178)
        Me.txtMpath.Name = "txtMpath"
        Me.txtMpath.Size = New System.Drawing.Size(245, 20)
        Me.txtMpath.TabIndex = 176
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(553, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 31)
        Me.Button3.TabIndex = 175
        Me.Button3.Text = "انتخاب فابل نمونه"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtfile1
        '
        Me.txtfile1.Location = New System.Drawing.Point(14, 85)
        Me.txtfile1.Name = "txtfile1"
        Me.txtfile1.Size = New System.Drawing.Size(512, 20)
        Me.txtfile1.TabIndex = 174
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(153, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(237, 17)
        Me.CheckBox1.TabIndex = 173
        Me.CheckBox1.Text = "سال مالی جدید را از سال نمونه 1391 ایجاد کن"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(430, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(17, 17)
        Me.Button1.TabIndex = 172
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(430, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(17, 17)
        Me.Button2.TabIndex = 171
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtsal
        '
        Me.txtsal.AcceptsReturn = True
        Me.txtsal.BackColor = System.Drawing.SystemColors.Window
        Me.txtsal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsal.Location = New System.Drawing.Point(470, 21)
        Me.txtsal.MaxLength = 0
        Me.txtsal.Name = "txtsal"
        Me.txtsal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsal.Size = New System.Drawing.Size(56, 24)
        Me.txtsal.TabIndex = 170
        Me.txtsal.Text = "1396"
        '
        'txtfile2
        '
        Me.txtfile2.Location = New System.Drawing.Point(14, 135)
        Me.txtfile2.Name = "txtfile2"
        Me.txtfile2.Size = New System.Drawing.Size(512, 20)
        Me.txtfile2.TabIndex = 1
        '
        'frmCreateDbfromTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 238)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmCreateDbfromTemplate"
        Me.Text = "ایجاد بانک اطلاعاتی"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfile2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents txtsal As System.Windows.Forms.TextBox
    Public WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtfile1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMpath As System.Windows.Forms.TextBox
End Class
