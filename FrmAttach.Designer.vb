<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttach
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
        Me.txtparvandeh = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._Label5_0 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtparvandeh)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me._Label1_0)
        Me.GroupBox1.Controls.Add(Me._Label5_0)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 439)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtparvandeh
        '
        Me.txtparvandeh.AcceptsReturn = True
        Me.txtparvandeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtparvandeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtparvandeh.Font = New System.Drawing.Font("Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtparvandeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtparvandeh.Location = New System.Drawing.Point(426, 16)
        Me.txtparvandeh.MaxLength = 0
        Me.txtparvandeh.Name = "txtparvandeh"
        Me.txtparvandeh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtparvandeh.Size = New System.Drawing.Size(152, 31)
        Me.txtparvandeh.TabIndex = 15
        '
        'txtname
        '
        Me.txtname.AcceptsReturn = True
        Me.txtname.BackColor = System.Drawing.SystemColors.Window
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtname.Location = New System.Drawing.Point(98, 16)
        Me.txtname.MaxLength = 0
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtname.Size = New System.Drawing.Size(240, 21)
        Me.txtname.TabIndex = 16
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(591, 16)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(69, 41)
        Me._Label1_0.TabIndex = 18
        Me._Label1_0.Text = "شماره پرونده"
        '
        '_Label5_0
        '
        Me._Label5_0.BackColor = System.Drawing.Color.Transparent
        Me._Label5_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label5_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_0.Location = New System.Drawing.Point(366, 16)
        Me._Label5_0.Name = "_Label5_0"
        Me._Label5_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_0.Size = New System.Drawing.Size(54, 25)
        Me._Label5_0.TabIndex = 17
        Me._Label5_0.Text = "فامیل"
        '
        'FrmAttach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAttach"
        Me.Text = "FrmAttach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtparvandeh As System.Windows.Forms.TextBox
    Public WithEvents txtname As System.Windows.Forms.TextBox
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents _Label5_0 As System.Windows.Forms.Label
End Class
