Option Strict Off
Option Explicit On
Friend Class frmdoc
	Inherits System.Windows.Forms.Form
	
	
	
    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub cmdlook_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdlook.Click
        fillgrid()
    End Sub

    Private Sub cmdDel_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim msg As Object
        If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close()
        de1.findbdhosp((txtcode.Text))
        If de1.rsfindbdhosp.EOF = False Then
            de1.rsfindbdhosp.Delete()
            de1.rsfindbdhosp.Update()
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "حذف شد"
            MsgBox(msg, MsgBoxStyle.Information)

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "مشخصات پیدا نشد"
            MsgBox(msg, MsgBoxStyle.Information)
        End If
        txtcode.Text = ""

    End Sub
    Private Sub hotkey(ByRef KeyCode As Short)
        Select Case KeyCode
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 27
                Me.Close()
        End Select
    End Sub

    Private Sub frmlogin_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub cmdsave_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim msg As Object
        Dim i As Object
        Dim tmptip As Object
        If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close()
        de1.findbdhosp((txtcode.Text))
        If de1.rsfindbdhosp.EOF = True Then
            de1.rsfindbdhosp.AddNew()
            de1.rsfindbdhosp.Fields("code").Value = txtcode.Text
        End If

        de1.rsfindbdhosp.Fields("famil").Value = txtfamil.Text
        de1.rsfindbdhosp.Fields("codmeli").Value = txtcodmeli.Text
        de1.rsfindbdhosp.Fields("tkhs_code").Value = Val(txttkhs_code.Text)
        de1.rsfindbdhosp.Fields("tkhs_Name").Value = txttkhs_name.Text
        de1.rsfindbdhosp.Fields("nezam").Value = txtnezam.Text
        de1.rsfindbdhosp.Fields("ad").Value = txtad.Text
        de1.rsfindbdhosp.Fields("tel").Value = Trim(txttel.Text)
        de1.rsfindbdhosp.Fields("city_name").Value = txtcity_name.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmptip = 0
        For i = 0 To 4
            If opttip(i).Checked = True Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmptip = i
            End If
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.rsfindbdhosp.Fields("tip").Value = tmptip
        de1.rsfindbdhosp.Update()
        de1.rsfindbdhosp.Close()
        Command3_Click(Command3, New System.EventArgs)
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "ثبت شد"
        MsgBox(msg, MsgBoxStyle.Information)
    End Sub
    Private Sub clsgrid()
        mh1.Rows.Count = 2
        mh1.Cols.Count = 6
        mh1.Clear()
        mh1.Cols(0).Width = 80
        mh1.Cols(1).Width = 120
        mh1.Cols(2).Width = 250
        mh1.Cols(3).Width = 250
        mh1.Cols(4).Width = 500
        mh1.Cols(5).Width = 200

        mh1.AutoResize = True
        'mh1.ComboSearch = VSFlex7L.ComboSearchSettings.flexCmbSearchLists
        'mh1.AutoSizeMode = VSFlex7L.AutoSizeSettings.flexAutoSizeColWidth
        'UPGRADE_NOTE: RightToLeft was upgraded to CtlRightToLeft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        ' mh1.CtlRightToLeft = True
        '-----------------------------------------------------------------------
        mh1.SetData(0, 0, "ردیف ")
        mh1.SetData(0, 1, "نظام پزشکی ")
        mh1.SetData(0, 2, "نام ")
        mh1.SetData(0, 3, "گروه ")
        mh1.SetData(0, 4, "آدرس ")
        mh1.SetData(0, 5, "تلفن ")
        mh1.Cols(4).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        mh1.Cols(5).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        mh1.Cols(2).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        
    End Sub
    Private Sub fillgrid()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If de1.rsbdhospname.State <> 0 Then de1.rsbdhospname.Close()

        de1.bdhospname("select * from bdhosp where  bdhosp.famil like '%" & Trim(txtfamil.Text) & "%' order by famil")

        Dim i As Short
        i = 1
        clsgrid()
        Do While de1.rsbdhospname.EOF = False

            mh1.setdata(i, 0, i)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("code").Value) Then mh1.setdata(i, 1, de1.rsbdhospname.Fields("code").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("famil").Value) Then mh1.setdata(i, 2, de1.rsbdhospname.Fields("famil").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("ad").Value) Then mh1.setdata(i, 4, de1.rsbdhospname.Fields("ad").Value)
            de1.rsbdhospname.MoveNext()
            mh1.Rows.Count = mh1.Rows.Count + 1
            i = i + 1
        Loop

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub fillgrid1()
        Dim tmptip As Object
        Dim mcap As Object
        Dim aa As Object
        Dim i As Short
        If de1.rsbdhospname.State <> 0 Then de1.rsbdhospname.Close()

        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aa = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object mcap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mcap = ""
        For i = 1 To 4
            If opttip(i).Checked = True Then
                'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aa = i
                'UPGRADE_WARNING: Couldn't resolve default property of object mcap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mcap = opttip(aa).Text
            End If
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aa = Str(aa)
        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.bdhospname("select * from bdhosp where tip=" + aa + " order by famil")

        i = 1
        clsgrid()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Do While de1.rsbdhospname.EOF = False
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmptip = 0
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDbNull(de1.rsbdhospname.Fields("tip").Value) Then tmptip = de1.rsbdhospname.Fields("tip").Value


            mh1.setdata(i, 0, i)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("code").Value) Then mh1.setdata(i, 1, de1.rsbdhospname.Fields("code").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("famil").Value) Then mh1.setdata(i, 2, de1.rsbdhospname.Fields("famil").Value)
            'UPGRADE_WARNING: Couldn't resolve default property of object mcap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.setdata(i, 3, mcap)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("ad").Value) Then mh1.setdata(i, 4, de1.rsbdhospname.Fields("ad").Value)
            i = i + 1
            mh1.Rows.Count = mh1.Rows.Count + 1
            de1.rsbdhospname.MoveNext()

        Loop
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub



    Private Sub cmdlist_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdlist.Click
        fillgrid1()
    End Sub

    Private Sub cmdTakh_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdTakh.Click
        frmLtaKh.txtproc.Text = CStr(1)
        frmLtaKh.Show()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Dim t1 As Object
        If Len(txtcode.Text) = 0 Then
            MsgBox(" کدرا وارد کنید", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '-----------------------------------------------------------------
        If Trim(Text1.Text) = "" Then
            If de1.rsFindvcode1.State <> 0 Then de1.rsFindvcode1.Close()
            de1.findvcode1((txtcode.Text), 1)

            If de1.rsFindvcode1.EOF = False Then
                de1.rsFindvcode1.Delete()
                Text1.Text = ""
                MsgBox("˜کد غیرفعال شد", MsgBoxStyle.Information)
            End If
            Exit Sub
        End If
        If de1.rsfindvcode.State <> 0 Then de1.rsfindvcode.Close()
        de1.findvcode((Text1.Text), 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        t1 = ""
        If de1.rsfindvcode.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDbNull(de1.rsfindvcode.Fields) Then t1 = de1.rsfindvcode.Fields("daro_code").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If t1 <> "" And t1 <> Text1.Text Then
                ' MsgBox "  " + t1 + "˜Ï ÞÈáÇ ÈÑÇí ÒÔß ÏíÑí ãäÙæÑ ÔÏå ÇÓÊ", vbCritical
                Text1.Text = ""
                Exit Sub
            End If
            '---------------------------------
        Else
            de1.rsfindvcode.AddNew()
            de1.rsfindvcode.Fields("daro_code").Value = txtnezam.Text
            de1.rsfindvcode.Fields("vcode").Value = Text1.Text
            de1.rsfindvcode.Fields("tip").Value = 1
            de1.rsfindvcode.Update()

        End If

        '-----------------------------------------------------------------
        '  If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close
        '    de1.findbdhosp Text1.Text
        '    If de1.rsfindbdhosp.EOF = False Then
        '      If Not IsNull(de1.rsfindbdhosp!code) Then a = de1.rsfindbdhosp!code
        '        MsgBox "Çíä ßÏ ÞÈáÇ ÈÑÇí ÒÔß ÏíÑí ÇÎÊÕÇÕ íÇÝÊå ÇÓÊ", vbCritical
        '        Exit Sub
        '      Else
        '        If de1.rsUpdateNezam.State <> 0 Then de1.rsUpdateNezam.Close
        '           de1.rsUpdateNezam.Source = "update bdhosp set code='" + Text1.Text + "' where code='" + txtcode.Text + "' "
        '           de1.rsUpdateNezam.Open
        '
        '           MsgBox "ßÏ ÈÑÇí ÒÔß ÇÎÊÕÇÕ íÇÝÊ", vbInformation
        '           Beep
        '    End If

    End Sub



    Private Sub CmdListGroup_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles CmdListGroup.Click
        Dim mcap As Object
        Dim tmptip As Object
        Dim aa As Object
        Dim i As Short
        If de1.rsbdhospname.State <> 0 Then de1.rsbdhospname.Close()

        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

        de1.bdhospname("select * from bdhosp where tkhs_code=" & txttkhs_code.Text & " order by famil")

        i = 1
        clsgrid()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Do While de1.rsbdhospname.EOF = False
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmptip = 0
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDbNull(de1.rsbdhospname.Fields("tip").Value) Then tmptip = de1.rsbdhospname.Fields("tip").Value


            mh1.setdata(i, 0, i)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("code").Value) Then mh1.setdata(i, 1, de1.rsbdhospname.Fields("code").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("famil").Value) Then mh1.setdata(i, 2, de1.rsbdhospname.Fields("famil").Value)
            'UPGRADE_WARNING: Couldn't resolve default property of object mcap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.setdata(i, 3, mcap)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsbdhospname.Fields("ad").Value) Then mh1.setdata(i, 4, de1.rsbdhospname.Fields("ad").Value)
            i = i + 1
            mh1.Rows.Count = mh1.Rows.Count + 1
            de1.rsbdhospname.MoveNext()

        Loop
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    'UPGRADE_WARNING: Form event frmdoc.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmdoc_Activated(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        keybfarsi()
    End Sub

    Private Sub frmdoc_Load(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opttip(0).Checked = True
    End Sub

    Private Sub mh1_DoubleClick(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles mh1.DoubleClick
        txtcode.Text = mh1.GetData(mh1.Row, 1)
        txtcode_Leave(txtcode, New System.EventArgs)
    End Sub


    Private Sub Opttip_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opttip.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Dim Index As Short = opttip.GetIndex(eventSender)
        hotkey(KeyCode)
    End Sub

    Private Sub Text1_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text1.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub Text1_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Text1.Leave
        If de1.rsfindvcode.State <> 0 Then de1.rsfindvcode.Close()

        de1.findvcode((Text1.Text), 1)
        If de1.rsfindvcode.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindvcode.Fields("daro_code").Value) Then txtcode.Text = de1.rsfindvcode.Fields("daro_code").Value
            txtcode_Leave(txtcode, New System.EventArgs)
        End If
    End Sub

    Private Sub txtcode_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub


    Private Sub txtPassword_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtcode_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcode.Leave
        Dim tmpcokm As Object
        Dim tmcokm As Object
        Dim tmptip As Object
        txtnezam.Text = ""
        txtfamil.Text = ""
        txttkhs_code.Text = ""
        txtad.Text = ""
        txttel.Text = ""
        txtcity_name.Text = ""
        opttip(0).Checked = True
        If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close()
        de1.findbdhosp((txtcode.Text))
        If de1.rsfindbdhosp.EOF = False Then

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("famil").Value) Then txtfamil.Text = de1.rsfindbdhosp.Fields("famil").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("codmeli").Value) Then txtcodmeli.Text = de1.rsfindbdhosp.Fields("codmeli").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("tkhs_code").Value) Then txttkhs_code.Text = de1.rsfindbdhosp.Fields("tkhs_code").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("nezam").Value) Then txtnezam.Text = de1.rsfindbdhosp.Fields("nezam").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("ad").Value) Then txtad.Text = de1.rsfindbdhosp.Fields("ad").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("tel").Value) Then txttel.Text = de1.rsfindbdhosp.Fields("tel").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("city_name").Value) Then txtcity_name.Text = de1.rsfindbdhosp.Fields("city_name").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmptip = 0
            txttkhs_code_Leave(txttkhs_code, New System.EventArgs)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDbNull(de1.rsfindbdhosp.Fields("tip").Value) Then tmptip = de1.rsfindbdhosp.Fields("tip").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmptip >= 0 And tmptip <= 4 Then
                opttip(tmptip).Checked = True
            Else
                MsgBox("وضعیت پزشک مشخص نشده است ", MsgBoxStyle.Critical)

            End If
            '--------------------------------------------------------------'
            If de1.rsFindvcode1.State <> 0 Then de1.rsFindvcode1.Close()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmcokm = ""
            de1.Findvcode1(txtnezam.Text, 1)
            If de1.rsFindvcode1.EOF = False Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Not IsDbNull(de1.rsFindvcode1.Fields("vcode").Value) Then tmpcokm = de1.rsFindvcode1.Fields("vcode").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Text1.Text = tmpcokm
            End If
            '------------------------------------------------------------
        Else
            Text1.Text = ""
            txtfamil.Text = ""
            txttkhs_code.Text = ""
            txttkhs_name.Text = ""
            txtnezam.Text = ""
            txtad.Text = ""
            txtcity_name.Text = ""
            txttel.Text = ""
        End If
    End Sub

    Private Sub txtfani_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtfanifamil_Change()

    End Sub

    Private Sub txtfanifamil_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtfaninezam_Change()

    End Sub

    Private Sub txtfaninezam_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtcodmeli_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodmeli.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtfamil_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtfamil.Enter
        keybfarsi()
    End Sub

    Private Sub txtfamil_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfamil.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub


    Private Sub txtnezam_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnezam.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub
    Private Sub txtad_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtad.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtnezam_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtnezam.Leave
        If Trim(txtnezam.Text) = "" Then
            txtnezam.Text = txtcode.Text
        End If
    End Sub

    Private Sub txttel_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttel.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub
    Private Sub txtcity_name_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcity_name.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub



    Private Sub txttkhs_code_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttkhs_code.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txttkhs_code_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txttkhs_code.Leave
        If de1.rsfindbdtakh.State <> 0 Then de1.rsfindbdtakh.Close()
        de1.findbdtakh((txttkhs_code.Text))
        If de1.rsfindbdtakh.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(de1.rsfindbdtakh.Fields("tkhs_Name").Value) Then txttkhs_name.Text = de1.rsfindbdtakh.Fields("tkhs_Name").Value
        End If
        de1.rsfindbdtakh.Close()

    End Sub

    
    
    
    Private Sub mh1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mh1.Click

    End Sub

    Private Sub mh1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh1.KeyDown

    End Sub

    Private Sub mh1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh1.KeyPress
        Dim keyascii As Integer
        keyascii = Asc(e.KeyChar)
    End Sub

    Private Sub txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

    End Sub
End Class