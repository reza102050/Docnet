Public Class frmDocNobat
    Private Sub clsgrid()
        mh1.Rows.Count = 2
        mh1.Cols.Count = 6
        mh1.Clear()
        mh1.Cols(0).Width = 80
        mh1.Cols(1).Width = 120
        mh1.Cols(2).Width = 250
        mh1.Cols(3).Width = 250


        mh1.AutoResize = True
        '-----------------------------------------------------------------------
        mh1.SetData(0, 0, "ردیف ")
        mh1.SetData(0, 1, "نام بیمار ")
        mh1.SetData(0, 2, "کد بیمه ")
        mh1.SetData(0, 3, "تلفن ")
        mh1.SetData(0, 4, "مبلغ دریافتی ")
        mh1.Cols(4).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        mh1.Cols(5).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        mh1.Cols(2).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom

    End Sub
    Private Sub fillgrid()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If de1.rsbdhospname.State <> 0 Then de1.rsbdhospname.Close()

        de1.bdhospname("select * from bimarpaziresh  where DatePaz='" + txtdatePaz.Text + "'")

        Dim i As Short
        i = 1
        clsgrid()
        Do While de1.rsbdhospname.EOF = False

            mh1.SetData(i, 0, i)
            If Not IsDBNull(de1.rsbdhospname.Fields("radif").Value) Then mh1.SetData(i, 0, de1.rsbdhospname.Fields("radif").Value)
            If Not IsDBNull(de1.rsbdhospname.Fields("na").Value) Then mh1.SetData(i, 1, de1.rsbdhospname.Fields("na").Value)
            If Not IsDBNull(de1.rsbdhospname.Fields("bimehid").Value) Then mh1.SetData(i, 2, de1.rsbdhospname.Fields("bimehid").Value)
            If Not IsDBNull(de1.rsbdhospname.Fields("mob").Value) Then mh1.SetData(i, 3, de1.rsbdhospname.Fields("mob").Value)
            If Not IsDBNull(de1.rsbdhospname.Fields("payment").Value) Then mh1.SetData(i, 4, de1.rsbdhospname.Fields("payment").Value)
            de1.rsbdhospname.MoveNext()
            mh1.Rows.Count = mh1.Rows.Count + 1
            i = i + 1
        Loop

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub Getradif()
        Dim tmpradif As Object

        If de1.rsbrowall1.State <> 0 Then de1.rsbrowall1.Close()
        de1.browall1("select radif from Bimarpaziresh where DatePaz='" + txtdatePaz.Text + "'")
        If de1.rsbrowall1.EOF = False Then
            de1.rsbrowall1.MoveLast()
            tmpradif = de1.rsbrowall1.Fields("radif").Value
            txtradif.Text = tmpradif + 1
        Else
            txtradif.Text = CStr(1)
        End If
        de1.rsbrowall1.Close()
    End Sub
    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If txtradif.Text = "" Then
            Getradif()
        End If
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        de1.browall("select *  from BimarPaziresh where radif=" + txtradif.Text + "")
        If de1.rsbrowall.EOF = True Then
            de1.rsbrowall.AddNew()
        End If
        '-----------------------------------------------------------------
        de1.rsbrowall.Fields("cath").Value = Val(txtCath.Text)
        de1.rsbrowall.Fields("radif").Value = Val(txtradif.Text)
        de1.rsbrowall.Fields("BimehId").Value = txtbimehId.Text
        de1.rsbrowall.Fields("na").Value = txtname.Text
        de1.rsbrowall.Fields("Mob").Value = txtMob.Text
        de1.rsbrowall.Fields("datePaz").Value = txtdatePaz.Text
        de1.rsbrowall.Fields("payment").Value = Val(txtpayment.Text)
        de1.rsbrowall.Fields("comment").Value = txtComment.Text
        de1.rsbrowall.Fields("act").Value = 0
        de1.rsbrowall.Fields("parvandeh").Value = txtParvandeh.Text
        de1.rsbrowall.Update()
        MsgBox("ثبت شد", vbInformation)
        fillgrid()
    End Sub
    Private Sub hotkey(ByVal KeyCode As Short)
        Select Case KeyCode
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 113
                If cmdsave.Enabled = True Then cmdsave_Click(cmdsave, New System.EventArgs)
        End Select
    End Sub

    Private Sub frmDocNobat_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.txtdatePaz.Text = MainForm.txtdate1.Text
        fillgrid()
    End Sub

    Private Sub txtdatePaz_TextChanged(sender As Object, e As EventArgs) Handles txtdatePaz.TextChanged

    End Sub

    Private Sub txtdatePaz_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdatePaz.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtCath_TextChanged(sender As Object, e As EventArgs) Handles txtCath.TextChanged
        If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
        de1.findcath(Val(txtCath.Text))
        If de1.rsfindcath.EOF = False Then


            If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then lblC2.Text = de1.rsfindcath.Fields("Name").Value
        End If
    End Sub

    Private Sub txtCath_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCath.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtMob_TextChanged(sender As Object, e As EventArgs) Handles txtMob.TextChanged

    End Sub

    Private Sub txtMob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMob.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtbimehId_TextChanged(sender As Object, e As EventArgs) Handles txtbimehId.TextChanged

    End Sub

    Private Sub txtbimehId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbimehId.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtpayment_TextChanged(sender As Object, e As EventArgs) Handles txtpayment.TextChanged

    End Sub

    Private Sub txtpayment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpayment.KeyDown
        hotkey(e.KeyCode)
    End Sub

    Private Sub txtradif_TextChanged(sender As Object, e As EventArgs) Handles txtradif.TextChanged

    End Sub

    Private Sub mh1_Click(sender As Object, e As EventArgs) Handles mh1.Click

    End Sub

    Private Sub mh1_DoubleClick(sender As Object, e As EventArgs) Handles mh1.DoubleClick
        txtradif.Text = mh1.GetData(mh1.Row, 0)
        cmdlist_Click(cmdlist, New System.EventArgs)
    End Sub

    Private Sub cmdlist_Click(sender As Object, e As EventArgs) Handles cmdlist.Click
        If txtradif.Text = "" Then
            Exit Sub
        End If
        txtMob.Text = ""
        txtpayment.Text = 0
        txtComment.Text = ""
        txtCath.Text = ""
        txtbimehId.Text = ""
        txtname.Text = ""
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        de1.browall("select *  from BimarPaziresh where radif=" + txtradif.Text + " and datepaz='" + txtdatePaz.Text + "'")
        If de1.rsbrowall.EOF = False Then
            If Not IsDBNull(de1.rsbrowall.Fields("cath").Value) Then txtCath.Text = de1.rsbrowall.Fields("cath").Value
            If Not IsDBNull(de1.rsbrowall.Fields("na").Value) Then txtname.Text = de1.rsbrowall.Fields("na").Value
            If Not IsDBNull(de1.rsbrowall.Fields("datepaz").Value) Then txtdatePaz.Text = de1.rsbrowall.Fields("datepaz").Value
            If Not IsDBNull(de1.rsbrowall.Fields("mob").Value) Then txtMob.Text = de1.rsbrowall.Fields("mob").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment").Value) Then txtComment.Text = de1.rsbrowall.Fields("comment").Value
            If Not IsDBNull(de1.rsbrowall.Fields("payment").Value) Then txtpayment.Text = de1.rsbrowall.Fields("payment").Value
            If Not IsDBNull(de1.rsbrowall.Fields("bimehid").Value) Then txtbimehId.Text = de1.rsbrowall.Fields("bimehid").Value
            If Not IsDBNull(de1.rsbrowall.Fields("parvandeh").Value) Then txtParvandeh.Text = de1.rsbrowall.Fields("parvandeh").Value
        End If
    End Sub

    Private Sub cmdnew_Click(sender As Object, e As EventArgs) Handles cmdnew.Click
        txtMob.Text = ""
        txtpayment.Text = 0
        txtComment.Text = ""
        txtCath.Text = ""
        txtbimehId.Text = ""
        txtname.Text = ""
    End Sub

    Private Sub cmddel_Click(sender As Object, e As EventArgs) Handles cmddel.Click
        If txtradif.Text = "" Then
            Exit Sub
        End If
        txtMob.Text = ""
        txtpayment.Text = 0
        txtComment.Text = ""
        txtCath.Text = ""
        txtbimehId.Text = ""
        txtname.Text = ""
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        de1.browall("delete  from BimarPaziresh where radif=" + txtradif.Text + " and datepaz='" + txtdatePaz.Text + "'")
        MsgBox("حذف شد", vbInformation)
        fillgrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If de1.rsfindmain.State <> 0 Then de1.rsfindmain.Close()
        de1.findmain()
        If de1.rsfindmain.RecordCount <= 0 Then
            Err.Number = MsgBox("Error In Setup File(main.mdb) in Root Directory ....... ", MsgBoxStyle.OkOnly, "")
            MsgBox(" main table اشکال در ثبت اطلاعات ", MsgBoxStyle.Information)
        Else

            de1.rsfindmain.Fields("DocPanelDate").Value = txtdatePaz.Text
            de1.rsfindmain.Fields("DocPanelRadif").Value = txtradif.Text
            de1.rsfindmain.Update()
            Me.txtDocpanelRadif.Text = Me.txtradif.Text
        End If
    End Sub
End Class