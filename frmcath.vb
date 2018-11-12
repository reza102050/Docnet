Option Strict Off
Option Explicit On
Friend Class frmcath
	Inherits System.Windows.Forms.Form
	
	'UPGRADE_WARNING: Event chkbimar.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkbimar_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkbimar.CheckStateChanged
		If chkbimar.CheckState = 0 Then
            chkbimar.Text = "نام بیمار الزامی است"
		Else
			
            chkbimar.Text = "نام بیمار الزامی نیست"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkbimeh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkbimeh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkbimeh.CheckStateChanged
		If chkbimeh.CheckState = 0 Then
            chkbimeh.Text = "شماره بیمه شده الزامی است"
		Else
            chkbimeh.Text = "شماره بیمه شده الزامی نیست"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkbwork.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkbwork_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkbwork.CheckStateChanged
		If chkbwork.CheckState = 0 Then
            chkbwork.Text = "درصورت نداشتن اعتبار آزاد حساب نشود"
		Else
            chkbwork.Text = "درصورت نداشتن اعتبار آزاد حساب شود"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkdate.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkdate_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkdate.CheckStateChanged
		If chkdate.CheckState = 0 Then
            chkdate.Text = "تاریخ نسخه الزامی است"
		Else
            chkdate.Text = "تاریخ نسخه الزامی نیست"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chknezam.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chknezam_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chknezam.CheckStateChanged
		If chknezam.CheckState = 0 Then
            chknezam.Text = "شماره نظام الزامی است"
		Else
            chknezam.Text = "شماره نظام الزامی نیست"
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event chkpage.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkpage_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkpage.CheckStateChanged
		If chkpage.CheckState = 0 Then
            chkpage.Text = "شماره صفحه الزامی است"
		Else
            chkpage.Text = "شماره صفحه الزامی نیست"
		End If
	End Sub
	
    Private Sub cmdcopy_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdcopy.Click
        frmcopydaro.Show()
    End Sub


    Private Sub cmdlistcath_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdlistcath.Click
        frmlcath.txtproc.Text = CStr(2)
        frmlcath.Show()
    End Sub

    Private Sub cmdlook_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdlook.Click
        frmlcath.txtproc.Text = CStr(2)
        frmlcath.Show()
    End Sub

    Private Sub Command1_Click()

    End Sub

    Private Sub txtname_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtname.Enter
        keybfarsi()
    End Sub

    Private Sub txtpayfog_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtpaymama_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpaymama.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    'UPGRADE_WARNING: Event txtproc.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtproc_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtproc.TextChanged
        Select Case Val(txtproc.Text)
            Case 1
                txtcode_Leave(txtcode, New System.EventArgs())
                txtproc.Text = CStr(0)
        End Select
        txtproc.Text = ""
    End Sub

    Private Sub clsgrid()
        mh1.Rows.Count = 20
        mh1.Cols.Count = 3
        mh1.Clear()

        mh1.Cols(0).Width = 200
        mh1.SetData(0, 0, " نوع بیمه ")
        mh1.SetData(0, 1, "نام فایل ")
        mh1.SetData(0, 2, " کد سازمان")

        '-----------------------------------------------------------------------
        mh1.SetData(1, 0, "تامین اجتماعی")
        mh1.SetData(2, 0, "مامایی تامین اجتماعی ")
        mh1.SetData(3, 0, "تامین اجتماعی خاص   ")

        mh1.SetData(4, 0, "کارکنان دولت")
        mh1.SetData(5, 0, "خویش فرما")
        mh1.SetData(6, 0, "سایراقشار")
        mh1.SetData(7, 0, "روستایی")

        mh1.SetData(8, 0, "کارکنان دولت خاص")
        mh1.SetData(9, 0, " خاص خویش فرما")
        mh1.SetData(10, 0, " خاص سایراقشار")
        mh1.SetData(11, 0, "روستایی خاص")
        mh1.SetData(12, 0, "مامایی خدمات درمانی")

        mh1.SetData(13, 0, "نیروهای مسلح عادی")
        mh1.SetData(14, 0, "نیروهای مسلح جانبازان")
        mh1.SetData(15, 0, "سلامت همگانی")
        '--------------------------------------
        mh1.SetData(1, 1, "nos1.txt")
        mh1.SetData(2, 1, "nos2.txt")
        mh1.SetData(3, 1, "nos3.txt")
        '----------------------
        mh1.SetData(4, 1, "nos1.txt")
        mh1.SetData(5, 1, "nos2.txt")
        mh1.SetData(6, 1, "nos3.txt")
        mh1.SetData(7, 1, "nos4.txt")
        mh1.SetData(8, 1, "nos5.txt")
        mh1.SetData(9, 1, "nos6.txt")
        mh1.SetData(10, 1, "nos7.txt")
        mh1.SetData(11, 1, "nos8.txt")
        mh1.SetData(12, 1, "nos9.txt")
        mh1.SetData(13, 1, "nos1.txt")
        mh1.SetData(14, 1, "nos1.txt")
        '------------------------------
        mh1.SetData(1, 2, "103")
        mh1.SetData(2, 2, "103 ")
        mh1.SetData(3, 2, "103 ")
        '---------------
        mh1.SetData(4, 2, "121 ")
        mh1.SetData(5, 2, "122 ")
        mh1.SetData(6, 2, "123 ")
        mh1.SetData(7, 2, "124 ")
        mh1.SetData(8, 2, "125 ")
        mh1.SetData(9, 2, "126 ")
        mh1.SetData(10, 2, "127 ")
        mh1.SetData(11, 2, "128 ")
        mh1.SetData(12, 2, "101 ")
        mh1.SetData(13, 2, "101 ")
        mh1.SetData(14, 2, "102 ")
        '-------------------------------
    End Sub

    Private Sub cbochk_Click(ByRef Area As Short)
        Dim cbochk As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cbochk.BoundText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtnprint.Text = cbochk.BoundText
    End Sub

    'UPGRADE_WARNING: Event chkfanitip.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'

    'UPGRADE_WARNING: Event chktaan.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chktaan_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chktaan.CheckStateChanged
        If chktaan.CheckState = 1 Then
            chktaan.Text = "تاریخ اعتبار الزامی است"
        Else
            chktaan.Text = "تاریخ اعتبار الزامی نیست"
        End If
    End Sub

    Private Sub cmdexit_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub cmdnz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdnz.Click
        frmorgan.Show()
    End Sub

    Private Sub cmddel_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmddel.Click
        Dim a As Object
        Dim msg As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "˜حذف گردد؟"
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = 7
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox(msg, MsgBoxStyle.YesNo)

        If a = MsgBoxResult.Yes Then

            If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
            de1.findcath(Val(txtcode.Text))
            If de1.rsfindcath.EOF = False Then
                de1.rsfindcath.Delete()
                de1.rsfindcath.Update()
                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msg = "حذف گردید"
                MsgBox(msg, MsgBoxStyle.Information)
                '-----------------------------------------------------------------
                If de1.rslistdarocond.State <> 0 Then de1.rslistdarocond.Close()
                de1.listdarocond("delete from daro_cond where cath=" & txtcode.Text & " ")

                de1.listdarocond("select * from daro_cond")

            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msg = "مشخصات پیدانشد"
                MsgBox(msg, MsgBoxStyle.Information)
            End If
        End If
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

    Private Sub Cmdsave_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsave.Click
        Dim msg As Object
        On Error Resume Next
        If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
        de1.findcath(Val(txtcode.Text))
        If de1.rsfindcath.EOF = True Then
            de1.rsfindcath.AddNew()
            de1.rsfindcath.Fields("cath").Value = Val(txtcode.Text)
        End If
        de1.rsfindcath.Fields("Name").Value = txtname.Text
        de1.rsfindcath.Fields("organ_Name").Value = txtorgan_name.Text
        de1.rsfindcath.Fields("organ_code").Value = txtorgan_code.Text
        de1.rsfindcath.Fields("org").Value = Val(txtorg.Text)
        de1.rsfindcath.Fields("bimar").Value = Val(txtbimar.Text)
        de1.rsfindcath.Fields("paydoc").Value = Val(txtpaydoc.Text)
        de1.rsfindcath.Fields("payden").Value = Val(txtpayden.Text)
        de1.rsfindcath.Fields("paymot").Value = Val(txtpaymot.Text)
        de1.rsfindcath.Fields("fhaz").Value = Val(txtfhaz.Text)
        de1.rsfindcath.Fields("pt").Value = txtpt.Text
        de1.rsfindcath.Fields("dc").Value = txtdc.Text
        de1.rsfindcath.Fields("fname").Value = txtfname.Text
        de1.rsfindcath.Fields("khas").Value = Val(txtkhas.Text)
        de1.rsfindcath.Fields("nprint").Value = Val(txtnprint.Text)
        de1.rsfindcath.Fields("chktaan").Value = chktaan.CheckState
        de1.rsfindcath.Fields("chkpage").Value = chkpage.CheckState
        de1.rsfindcath.Fields("chkbimar").Value = chkbimar.CheckState
        de1.rsfindcath.Fields("chknezam").Value = chknezam.CheckState
        de1.rsfindcath.Fields("chkdate").Value = chkdate.CheckState
        de1.rsfindcath.Fields("chkbimeh").Value = chkbimeh.CheckState
        de1.rsfindcath.Fields("bwork").Value = chkbwork.CheckState
        de1.rsfindcath.Fields("chkMeli").Value = chkMeli.CheckState
        de1.rsfindcath.Fields("paymama").Value = Val(txtpaymama.Text)
        de1.rsfindcath.Update()
        de1.rsfindcath.Close()
norec:

        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "ثبت گردید"
        MsgBox(msg, MsgBoxStyle.Information)
        clsNos()
    End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		frmzprt.txtpmon.Text = Me.txtnprint.Text
		frmzprt.Show()
	End Sub
	
	Private Sub frmcath_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		clsNos()
        cbo1.Items.Insert(0, "نا مشخص      ")
        cbo1.Items.Insert(1, "کارمندی عادی")
        cbo1.Items.Insert(2, "خویش فرما عادی")
        cbo1.Items.Insert(3, "سایراقشارعادی")
        cbo1.Items.Insert(4, "روستایی عادی")
        cbo1.Items.Insert(5, "کارمندی خاص")
        cbo1.Items.Insert(6, "خویش فرما خاص")
        cbo1.Items.Insert(7, "سایراقشار خاص")
        cbo1.Items.Insert(8, "روستایی خاص")
        cbo1.Items.Insert(9, "تامین اجتماعی عادی")
        cbo1.Items.Insert(10, "تامین اجتماعی تاییدی")
        cbo1.Items.Insert(11, "تامین اجتماعیی مامایی")
        cbo1.Items.Insert(12, "تامین اجتماعی خاص")
        cbo1.Items.Insert(13, "نیروهای مسلح عادی")
        cbo1.Items.Insert(14, "نیروهای مسلح جانبازان")
        cbo1.Items.Insert(15, "نیروهای مسلح خاص   ")
        cbo1.Items.Insert(16, "نیروهای مسلح 90 درصد")
        cbo1.Items.Insert(17, "تامین اجتماعی 85 درصد")
        cbo1.Items.Insert(18, "کمیته امداد")
        cbo1.Items.Insert(19, "سلامت همگانی")
        '---------
        clsgrid()
	End Sub
	'UPGRADE_WARNING: Event cbo1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbo1.SelectedIndexChanged
		txtkhas.Text = CStr(cbo1.SelectedIndex)
	End Sub
	
	Private Sub txtbimar_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtbimar.Enter
		txtbimar.SelectionStart = 0
		txtbimar.SelectionLength = Len(txtbimar.Text)
		
	End Sub
	
	Private Sub txtbimar_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtbimar.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtcode_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtmonth_Change()
		
	End Sub
	
	Private Sub txtfhaz_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfhaz.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtkhas_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtkhas.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtPassword_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	Private Sub clsNos()
		txtname.Text = ""
		txtpaydoc.Text = ""
		txtpayden.Text = ""
		txtpaymot.Text = ""
		txtfhaz.Text = ""
		txtpt.Text = ""
		txtdc.Text = ""
		txtnprint.Text = ""
		txtorg.Text = ""
		txtbimar.Text = ""
		txtorgan_name.Text = ""
		txtorgan_code.Text = ""
		txtkhas.Text = ""
		txtpaymama.Text = ""
        chktaan.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkpage.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkbimar.CheckState = System.Windows.Forms.CheckState.Unchecked
		chknezam.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkdate.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkbimeh.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkbwork.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkMeli.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	Private Sub txtcode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcode.Leave
		Dim t1 As Object
		
		clsNos()
		On Error Resume Next
		If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
		de1.findcath(Val(txtcode.Text))
		If de1.rsfindcath.EOF = False Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("org").Value) Then txtorg.Text = de1.rsfindcath.Fields("org").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("Name").Value) Then txtname.Text = de1.rsfindcath.Fields("Name").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("bimar").Value) Then txtbimar.Text = de1.rsfindcath.Fields("bimar").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("organ_Name").Value) Then txtorgan_name.Text = de1.rsfindcath.Fields("organ_Name").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("organ_code").Value) Then txtorgan_code.Text = de1.rsfindcath.Fields("organ_code").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("paydoc").Value) Then txtpaydoc.Text = de1.rsfindcath.Fields("paydoc").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("paymot").Value) Then txtpaymot.Text = de1.rsfindcath.Fields("paymot").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("payden").Value) Then txtpayden.Text = de1.rsfindcath.Fields("payden").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("fhaz").Value) Then txtfhaz.Text = de1.rsfindcath.Fields("fhaz").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("pt").Value) Then txtpt.Text = de1.rsfindcath.Fields("pt").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("dc").Value) Then txtdc.Text = de1.rsfindcath.Fields("dc").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("fname").Value) Then txtfname.Text = de1.rsfindcath.Fields("fname").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("khas").Value) Then txtkhas.Text = de1.rsfindcath.Fields("khas").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("nprint").Value) Then txtnprint.Text = de1.rsfindcath.Fields("nprint").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chktaan").Value) Then chktaan.CheckState = de1.rsfindcath.Fields("chktaan").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chkpage").Value) Then chkpage.CheckState = de1.rsfindcath.Fields("chkpage").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chkbimar").Value) Then chkbimar.CheckState = de1.rsfindcath.Fields("chkbimar").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chknezam").Value) Then chknezam.CheckState = de1.rsfindcath.Fields("chknezam").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chkdate").Value) Then chkdate.CheckState = de1.rsfindcath.Fields("chkdate").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chkbimeh").Value) Then chkbimeh.CheckState = de1.rsfindcath.Fields("chkbimeh").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("bwork").Value) Then chkbwork.CheckState = de1.rsfindcath.Fields("bwork").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("paymama").Value) Then txtpaymama.Text = de1.rsfindcath.Fields("paymama").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("chkMeli").Value) Then chkMeli.CheckState = de1.rsfindcath.Fields("chkMeli").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			t1 = 0

			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("pay_add").Value) Then t1 = de1.rsfindcath.Fields("pay_add").Value ' for daro takhsosi
			'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

			
			
nrec: 
		Else
			clsNos()
		End If
		
	End Sub
	
	Private Sub txtdc_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtdc.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtfname_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfname.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtname_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	'UPGRADE_WARNING: Event txtnprint.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtnprint_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtnprint.TextChanged
		txtnprint_Leave(txtnprint, New System.EventArgs())
	End Sub
	
	Private Sub txtnprint_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtnprint.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtnprint_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtnprint.Leave
		If de1.rsfindnprint.State <> 0 Then de1.rsfindnprint.Close()
		de1.findnprint(Val(txtnprint.Text), 0)
		
		If de1.rsfindnprint.EOF = True Then
			txtnamenos.Text = ""
		Else
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindnprint.Fields("Name").Value) Then txtnamenos.Text = de1.rsfindnprint.Fields("Name").Value
		End If
		de1.rsfindnprint.Close()
	End Sub
	
	Private Sub txtorg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtorg.Enter
		txtorg.SelectionStart = 0
		txtorg.SelectionLength = Len(txtorg.Text)
		
	End Sub
	
	Private Sub txtorg_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtorg.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	'UPGRADE_WARNING: Event txtorgan_code.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtorgan_code_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtorgan_code.TextChanged
		
		txtorgan_name.Text = sayorgan(Val(txtorgan_code.Text))
		
		
	End Sub
	
	Private Sub txtorgan_code_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtorgan_code.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpay_add_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpay_max_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpayden_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpayden.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpaydoc_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpaydoc.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpaymot_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpaymot.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtpt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpt.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub

    Private Sub cmdloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdloop.Click
        txtcode.Focus()
    End Sub

    Private Sub txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub
End Class