Public Class frmDocPanel
    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            If Not IsDBNull(de1.rsbrowall.Fields("parvandeh").Value) Then txtParvandeh.Text = de1.rsbrowall.Fields("parvandeh").Value
            If Not IsDBNull(de1.rsbrowall.Fields("comment").Value) Then txtComment.Text = de1.rsbrowall.Fields("comment").Value
            If Not IsDBNull(de1.rsbrowall.Fields("payment").Value) Then txtpayment.Text = de1.rsbrowall.Fields("payment").Value

        End If

    End Sub
    Private Sub txtCath_TextChanged(sender As Object, e As EventArgs) Handles txtCath.TextChanged
        If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
        de1.findcath(Val(txtCath.Text))
        If de1.rsfindcath.EOF = False Then


            If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then lblC2.Text = de1.rsfindcath.Fields("Name").Value
        End If
    End Sub

    Private Sub frmDocPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtdatePaz.Text = MainForm.txtdate1.Text


    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
End Class