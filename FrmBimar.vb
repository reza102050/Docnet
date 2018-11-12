Imports System.Data.OleDb
Imports System.IO
Imports GdPicture10

Public Class FrmBimar
    Dim tsql As String
    Private Sub clsgrid5()
        mh5.Rows.Count = 2
        mh5.Cols.Count = 5
        mh5.Clear()
        mh5.Cols(0).Width = 50
        mh5.Cols(1).Width = 100
        mh5.Cols(2).Width = 150
        mh5.Cols(3).Width = 100
        '-----------------------------------------------------------------------
        mh5.SetData(0, 0, " ردیف  ")
        mh5.SetData(0, 1, " تاریخ ")
        mh5.SetData(0, 2, "توضیح ")
        '---------------------------
        mh5.SetData(0, 3, "نام فایل")

    End Sub
    Private Sub txtparvandeh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtparvandeh.KeyDown
        hotkey(e.KeyCode)
    End Sub
    Private Sub hotkey(ByRef KeyCode As Short)
        Select Case KeyCode
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 113 'f2
                cmdsave_Click(cmdsave, New System.EventArgs)
            Case 27 'esc
                cmdexit_Click(cmdexit, New System.EventArgs)
        End Select
    End Sub

    Private Sub txtparvandeh_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtparvandeh.Leave
        If txtparvandeh.Text = "" Then Exit Sub
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        tsql = "select * from bimar where parvandeh='" + txtparvandeh.Text + "'"
        de1.browall(tsql)
        If de1.rsbrowall.EOF = False Then
            If Not IsDBNull(de1.rsbrowall.Fields("name").Value) Then txtname.Text = de1.rsbrowall.Fields("name").Value
            If Not IsDBNull(de1.rsbrowall.Fields("bimeh").Value) Then txtcode.Text = de1.rsbrowall.Fields("bimeh").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment0").Value) Then text10.Text = de1.rsbrowall.Fields("comment0").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment1").Value) Then text11.Text = de1.rsbrowall.Fields("comment1").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment2").Value) Then text12.Text = de1.rsbrowall.Fields("comment2").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment3").Value) Then text13.Text = de1.rsbrowall.Fields("comment3").Value
            If Not IsDBNull(de1.rsbrowall.Fields("Check1").Value) Then check1.Checked = de1.rsbrowall.Fields("Check1").Value
            If Not IsDBNull(de1.rsbrowall.Fields("Check2").Value) Then Check2.Checked = de1.rsbrowall.Fields("Check2").Value
            If Not IsDBNull(de1.rsbrowall.Fields("Check3").Value) Then Check3.Checked = de1.rsbrowall.Fields("Check3").Value
            If Not IsDBNull(de1.rsbrowall.Fields("cath").Value) Then txtCath.Text = de1.rsbrowall.Fields("cath").Value
            showCathName()
            If Not IsDBNull(de1.rsbrowall.Fields("sex").Value) Then cbosex.SelectedIndex = de1.rsbrowall.Fields("sex").Value
            If Not IsDBNull(de1.rsbrowall.Fields("ad").Value) Then txtad.Text = de1.rsbrowall.Fields("ad").Value
            If Not IsDBNull(de1.rsbrowall.Fields("tel").Value) Then txttel.Text = de1.rsbrowall.Fields("tel").Value
            If Not IsDBNull(de1.rsbrowall.Fields("mobile").Value) Then txtmobile.Text = de1.rsbrowall.Fields("mobile").Value
            If Not IsDBNull(de1.rsbrowall.Fields("age").Value) Then txtage.Text = de1.rsbrowall.Fields("age").Value
            If Not IsDBNull(de1.rsbrowall.Fields("tahsilat").Value) Then txtTahsilat.Text = de1.rsbrowall.Fields("tahsilat").Value
            If Not IsDBNull(de1.rsbrowall.Fields("email").Value) Then txtemail.Text = de1.rsbrowall.Fields("email").Value
            If Not IsDBNull(de1.rsbrowall.Fields("job").Value) Then txtjob.Text = de1.rsbrowall.Fields("job").Value
            If Not IsDBNull(de1.rsbrowall.Fields("tvsal").Value) Then txtTvSal.Text = de1.rsbrowall.Fields("tvsal").Value
            fillgrid5()
        Else
            clsform()
            txtname.Text = ""
        End If
        '-------------------------------------------------------------------------
        fillMedia()
    End Sub
    Public Sub fillMedia()
        If de1.rsbrowall1.State <> 0 Then de1.rsbrowall1.Close()
        tsql = "select * from bimarmedia where parvandeh='" + txtparvandeh.Text + "' order by radif desc"
        de1.browall1(tsql)
        Dim ii, bb, jj As Integer
        ii = 1
        bb = 0
        jj = 1
        Dim aa, ff, mdate, mcomment As String
        Do While de1.rsbrowall1.EOF = False
            mcomment = ""
            mdate = ""
            ff = ""
            If Not IsDBNull(de1.rsbrowall1.Fields("radif").Value) Then bb = de1.rsbrowall1.Fields("radif").Value
            If Not IsDBNull(de1.rsbrowall1.Fields("filename").Value) Then ff = de1.rsbrowall1.Fields("filename").Value
            If Not IsDBNull(de1.rsbrowall1.Fields("mdate").Value) Then mdate = de1.rsbrowall1.Fields("mdate").Value
            If Not IsDBNull(de1.rsbrowall1.Fields("Mcomment").Value) Then mcomment = de1.rsbrowall1.Fields("Mcomment").Value
            mh5.Rows.Add()
            mh5.SetData(ii, 0, bb)
            mh5.SetData(ii, 1, mdate)
            mh5.SetData(ii, 2, mcomment)
            mh5.SetData(ii, 3, ff)
            If bb > jj Then jj = bb  ' max radif number
            ii = ii + 1
            de1.rsbrowall1.MoveNext()
        Loop
        txtradif.Text = jj
    End Sub
    Private Sub Showtip()
        Dim i As Short ' Counter
        'Dim PaperOrientation As CRPaperOrientation
        Addcbo(cbosex, "0زن", 0)
        Addcbo(cbosex, "1مرد", 1)

    End Sub

    Private Sub clsform()
        txtTvSal.Text = ""
        txtcode.Text = ""
        txtname.Text = ""
        text10.Text = ""
        text11.Text = ""
        text12.Text = ""
        text13.Text = ""
        check1.Checked = False
        Check2.Checked = False
        Check3.Checked = False
        txtCath.Text = ""
        txttel.Text = ""
        txtmobile.Text = ""
        txtage.Text = ""
        txtTahsilat.Text = ""
        txtad.Text = ""
        txtjob.Text = ""
        txtemail.Text = ""
    End Sub
    Private Sub fillgrid5()

    End Sub

    Private Sub txtparvandeh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtparvandeh.TextChanged

    End Sub

    Private Sub FrmBimar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Showtip()
        clsgrid5()
        Me.txtdatePaz.Text = MainForm.txtdate1.Text
        Dim strcon As String
        strcon = de1.con_main.ConnectionString
        Dim strSQL As String = "Select Cath,name From bdcath"
        Dim Connection As New OleDbConnection(strcon)
        Dim DA As New OleDbDataAdapter(strSQL, Connection)
        Dim DS As New DataSet
        DA.Fill(DS, "bdcath")
        If Not IsNothing(DS) Then
            cbo2.DataSource = DS.Tables(0)
            cbo2.DisplayMember = "name"
            cbo2.ValueMember = "cath"
            cbo2.SelectedIndex = 1
        End If
        Dim licenseManager As New LicenseManager
        licenseManager.RegisterKEY("211828254337675620511032833732212") 'Please, replace XXXX by a valid demo or commercial license key. 

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If txtparvandeh.Text = "" Then
            MsgBox("شماره پرونده را وارد نمایید", vbCritical)
            Exit Sub
        End If

        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        tsql = "select * from bimar where parvandeh='" + txtparvandeh.Text + "'"
        de1.browall(tsql)

        If de1.rsbrowall.EOF = True Then
            de1.rsbrowall.AddNew()
            de1.rsbrowall.Fields("parvandeh").Value = txtparvandeh.Text
        End If
        de1.rsbrowall.Fields("bimeh").Value = txtcode.Text
        de1.rsbrowall.Fields("Name").Value = txtname.Text
        de1.rsbrowall.Fields("comment0").Value = text10.Text
        de1.rsbrowall.Fields("comment1").Value = text11.Text
        de1.rsbrowall.Fields("comment2").Value = text12.Text
        de1.rsbrowall.Fields("comment3").Value = text13.Text
        de1.rsbrowall.Fields("Check1").Value = check1.Checked
        de1.rsbrowall.Fields("Check2").Value = Check2.Checked
        de1.rsbrowall.Fields("Check3").Value = Check3.Checked
        de1.rsbrowall.Fields("cath").Value = Val(txtCath.Text)
        de1.rsbrowall.Fields("cath_name").Value = cbo2.SelectedText
        de1.rsbrowall.Fields("sex").Value = cbosex.SelectedIndex
        de1.rsbrowall.Fields("job").Value = txtjob.Text
        de1.rsbrowall.Fields("tel").Value = txttel.Text
        de1.rsbrowall.Fields("mobile").Value = txtmobile.Text
        de1.rsbrowall.Fields("ad").Value = txtad.Text
        de1.rsbrowall.Fields("tahsilat").Value = txtTahsilat.Text
        de1.rsbrowall.Fields("age").Value = txtage.Text
        de1.rsbrowall.Fields("tvsal").Value = txtTvSal.Text
        de1.rsbrowall.Fields("email").Value = txtemail.Text
        de1.rsbrowall.Update()
        de1.rsbrowall.Close()
        MsgBox("ثبت شد...")

        cmdloop_Click(sender, New System.EventArgs)
        txtparvandeh.Focus()
    End Sub

    Private Sub cmdloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdloop.Click
        txtparvandeh.Text = ""
        clsform()
        txtparvandeh.Focus()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub txtcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtTahsilat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTahsilat.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtTahsilat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahsilat.TextChanged

    End Sub

    Private Sub txtjob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjob.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtjob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjob.TextChanged

    End Sub

    Private Sub txtage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtage.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged

    End Sub

    Private Sub txtad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtad.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtad.TextChanged

    End Sub

    Private Sub txttel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttel.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel.TextChanged

    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmobile.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmobile.TextChanged

    End Sub

    Private Sub cbosex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbosex.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub cbosex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosex.SelectedIndexChanged

    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        If Val(txtparvandeh.Text) = 0 Then
            MsgBox("شماره پرونده را وارد نمایید", vbCritical)
            Exit Sub
        End If
        Dim a As Integer
        a = MsgBox("برای حذف پرونده مطمئن هستید؟", MsgBoxStyle.YesNo)
        If a = vbYes Then
            If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
            tsql = "delete from bimar where parvandeh=" + txtparvandeh.Text + ""
            de1.browall(tsql)
            MsgBox("حذف گردید", MsgBoxStyle.Critical)
            cmdloop_Click(sender, New System.EventArgs)
        End If

    End Sub

    Private Sub txtCath_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCath.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Val(txtCath.Text) > 0 Then
                showCathName()
            End If
        End If
        hotkey(e.KeyCode)
    End Sub
    Private Sub showCathName()
        Dim aa As Integer
        Dim aIndex As Integer
        With cbo2
            For aIndex = 0 To .Items.Count - 1
                aa = cbo2.Items(aIndex)(0)
                If aa = Val(txtCath.Text) Then
                    .SelectedIndex = aIndex
                    Exit For
                End If

            Next
            If aIndex >= .Items.Count Then .SelectedIndex = -1
        End With
    End Sub
    Private Sub txtCath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCath.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmlbimar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk


        txtPath.Text = (OpenFileDialog1.FileName)
    End Sub
    Private Sub cbo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo2.SelectedIndexChanged
        If cbo2.SelectedIndex <> -1 Then
            txtCath.Text = cbo2.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtproc_TextChanged(sender As Object, e As EventArgs) Handles txtproc.TextChanged
        If Val(txtproc.Text) = 1 Then
            txtparvandeh_Leave(txtproc, New System.EventArgs)
            txtproc.Text = 0
        End If
    End Sub

    Private Sub cmdnew_Click(sender As Object, e As EventArgs) Handles cmdnew.Click
        If de1.rsbrowall1.State <> 0 Then de1.rsbrowall1.Close()
        Dim aa As String
        Dim bb As Integer
        aa = "select parvandeh from bimar order by parvandeh desc"
        de1.browall1(aa)
        de1.rsbrowall1.MoveFirst()
        If de1.rsbrowall1.EOF = False Then
            If Not IsDBNull(de1.rsbrowall1.Fields("parvandeh").Value) Then aa = de1.rsbrowall1.Fields("parvandeh").Value
            bb = Val(aa) + 1
            txtparvandeh.Text = bb.ToString
        End If
        txtparvandeh.Focus()
    End Sub

    Private Sub txtTvSal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTvSal.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtTvSal_TextChanged(sender As Object, e As EventArgs) Handles txtTvSal.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        txtparvandeh.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Tname, T1, Tx, a4, a5, a6, mdate, mtime As String
        Dim Tfolder As String
        Tfolder = Application.StartupPath + "\Media"
        If My.Computer.FileSystem.DirectoryExists(Tfolder) = False Then
            My.Computer.FileSystem.CreateDirectory(Tfolder)
        End If
        mtime = VB6.Format(Now, "hh:mm:ss")
        mdate = MainForm.txtdate1.Text
        a4 = Replace(mdate, "/", "")
        a5 = Replace(mtime, ":", "")
        a6 = a4 + a5
        Tx = ".Png"
        T1 = "P" + txtparvandeh.Text + "_" + a6
        txtPath.Text = Tfolder + "\" + T1 + Tx
        Tname = Path.GetFileName(txtPath.Text)
        frmPenTab.txtPath.Text = Me.txtPath.Text
        frmPenTab.txtradif.Text = Val(Me.txtradif.Text) + 1
        frmPenTab.txtpar.Text = Me.txtparvandeh.Text
        frmPenTab.txtComment.Text = Me.txtComment.Text
        frmPenTab.txtMdate.Text = mdate
        frmPenTab.Show()
    End Sub

    Private Sub txtproc1_TextChanged(sender As Object, e As EventArgs) Handles txtproc1.TextChanged
        If Val(txtproc1.Text) = 2 Then
            ShowImage(txtPath.Text)
        End If
    End Sub
    Private Sub ShowImage(tmpFilePath)
        ' Call GdViewer1.DisplayFromGdPictureImage(ImageID)

        GdViewer1.DisplayFromFile(tmpFilePath)
        '  GdViewer1.CloseDocument(True)
    End Sub

    Private Sub mh5_Click(sender As Object, e As EventArgs) Handles mh5.Click
        Dim a1, A2 As String
        a1 = mh5.GetData(mh5.Row, 3)
        Dim Tfolder As String
        Tfolder = Application.StartupPath + "\Media"
        A2 = Tfolder + "\" + a1
        If My.Computer.FileSystem.FileExists(A2) Then
            ShowImage(A2)
        End If
    End Sub
    Private Sub cmdlist_Click(sender As Object, e As EventArgs) Handles cmdlist.Click
        If txtradif.Text = "" Then
            Exit Sub
        End If

        txtpayment.Text = 0
        txtComment.Text = ""
        txtCath.Text = ""

        txtname.Text = ""
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        de1.browall("select *  from BimarPaziresh where radif=" + txtradif.Text + " and datepaz='" + txtdatePaz.Text + "'")
        If de1.rsbrowall.EOF = False Then
            If Not IsDBNull(de1.rsbrowall.Fields("cath").Value) Then txtCath.Text = de1.rsbrowall.Fields("cath").Value
            If Not IsDBNull(de1.rsbrowall.Fields("na").Value) Then txtname.Text = de1.rsbrowall.Fields("na").Value
            If Not IsDBNull(de1.rsbrowall.Fields("datepaz").Value) Then txtdatePaz.Text = de1.rsbrowall.Fields("datepaz").Value
            If Not IsDBNull(de1.rsbrowall.Fields("parvandeh").Value) Then txtparvandeh.Text = de1.rsbrowall.Fields("parvandeh").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment").Value) Then txtComment.Text = de1.rsbrowall.Fields("comment").Value
            If Not IsDBNull(de1.rsbrowall.Fields("payment").Value) Then txtpayment.Text = de1.rsbrowall.Fields("payment").Value

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If de1.rsfindmain.State <> 0 Then de1.rsfindmain.Close()
        de1.findmain()
        If de1.rsfindmain.RecordCount <= 0 Then
            Err.Number = MsgBox("Error In Setup File(main.mdb) in Root Directory ....... ", MsgBoxStyle.OkOnly, "")
            MsgBox(" main table اشکال در ثبت اطلاعات ", MsgBoxStyle.Information)
        Else

            If Not IsDBNull(de1.rsfindmain.Fields("DocPanelDate").Value) Then txtdatePaz.Text = de1.rsfindmain.Fields("DocPanelDate").Value
            If Not IsDBNull(de1.rsfindmain.Fields("DocPanelRadif").Value) Then txtradif.Text = de1.rsfindmain.Fields("DocPanelRadif").Value

            Me.txtDocpanelRadif.Text = Me.txtradif.Text
        End If
        cmdlist_Click(Button1, New System.EventArgs)
    End Sub
End Class