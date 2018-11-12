<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me._Label1_4 = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.showFolder = New System.Windows.Forms.Button
        Me.txtfile1 = New System.Windows.Forms.TextBox
        Me.txtmyloc = New System.Windows.Forms.TextBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdBackup = New System.Windows.Forms.Button
        Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._Label1_4)
        Me.GroupBox1.Controls.Add(Me.lblPath)
        Me.GroupBox1.Controls.Add(Me.showFolder)
        Me.GroupBox1.Controls.Add(Me.txtfile1)
        Me.GroupBox1.Controls.Add(Me.txtmyloc)
        Me.GroupBox1.Controls.Add(Me.cmdexit)
        Me.GroupBox1.Controls.Add(Me.cmdBackup)
        Me.GroupBox1.Controls.Add(Me.Drive1)
        Me.GroupBox1.Controls.Add(Me.Dir1)
        Me.GroupBox1.Controls.Add(Me.File1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 387)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Zar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(505, 349)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(105, 17)
        Me._Label1_4.TabIndex = 62
        Me._Label1_4.Text = "فولدر بانك اطلاعاتي"
        Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPath
        '
        Me.lblPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPath.Location = New System.Drawing.Point(6, 349)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPath.Size = New System.Drawing.Size(449, 25)
        Me.lblPath.TabIndex = 61
        '
        'showFolder
        '
        Me.showFolder.Location = New System.Drawing.Point(509, 136)
        Me.showFolder.Name = "showFolder"
        Me.showFolder.Size = New System.Drawing.Size(105, 41)
        Me.showFolder.TabIndex = 60
        Me.showFolder.Text = "نمایش فولدر"
        '
        'txtfile1
        '
        Me.txtfile1.Location = New System.Drawing.Point(398, 242)
        Me.txtfile1.Name = "txtfile1"
        Me.txtfile1.Size = New System.Drawing.Size(178, 20)
        Me.txtfile1.TabIndex = 54
        '
        'txtmyloc
        '
        Me.txtmyloc.Location = New System.Drawing.Point(9, 279)
        Me.txtmyloc.Name = "txtmyloc"
        Me.txtmyloc.Size = New System.Drawing.Size(532, 20)
        Me.txtmyloc.TabIndex = 53
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdexit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexit.Image = Global.DaroNet.My.Resources.Resources._142
        Me.cmdexit.Location = New System.Drawing.Point(539, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdexit.Size = New System.Drawing.Size(75, 41)
        Me.cmdexit.TabIndex = 52
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdBackup
        '
        Me.cmdBackup.BackColor = System.Drawing.Color.White
        Me.cmdBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBackup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBackup.Image = CType(resources.GetObject("cmdBackup.Image"), System.Drawing.Image)
        Me.cmdBackup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdBackup.Location = New System.Drawing.Point(539, 78)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdBackup.Size = New System.Drawing.Size(75, 41)
        Me.cmdBackup.TabIndex = 51
        Me.cmdBackup.Text = "شروع"
        Me.cmdBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdBackup.UseVisualStyleBackColor = False
        '
        'Drive1
        '
        Me.Drive1.BackColor = System.Drawing.SystemColors.Window
        Me.Drive1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drive1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Drive1.FormattingEnabled = True
        Me.Drive1.Location = New System.Drawing.Point(6, 19)
        Me.Drive1.Name = "Drive1"
        Me.Drive1.Size = New System.Drawing.Size(121, 21)
        Me.Drive1.TabIndex = 50
        '
        'Dir1
        '
        Me.Dir1.BackColor = System.Drawing.SystemColors.Window
        Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(134, 19)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.Size = New System.Drawing.Size(265, 202)
        Me.Dir1.TabIndex = 49
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        Me.File1.Location = New System.Drawing.Point(6, 43)
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.txt"
        Me.File1.Size = New System.Drawing.Size(121, 147)
        Me.File1.TabIndex = 48
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBackup"
        Me.Text = "frmBackup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Public WithEvents cmdexit As System.Windows.Forms.Button
    Public WithEvents cmdBackup As System.Windows.Forms.Button
    Friend WithEvents txtfile1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmyloc As System.Windows.Forms.TextBox
    Public WithEvents showFolder As System.Windows.Forms.Button
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents lblPath As System.Windows.Forms.Label
End Class
