Option Strict Off
Option Explicit On
Friend Class frmchkdel
	Inherits System.Windows.Forms.Form
	Private Sub clsgrid()
        mh1.rows.count = 2
        mh1.Cols.count = 10
        mh1.Clear()

        mh1.SetData(0, 0, "ردیف")

        mh1.SetData(0, 1, "نام            ")
        mh1.SetData(0, 2, " کد")
        mh1.SetData(0, 3, " شماره چک")
        mh1.SetData(0, 4, "مبلغ ")
        mh1.SetData(0, 5, "تاریخ سررسید  ")




    End Sub

    Private Sub fillgrid()
        Dim a As Object
        clsgrid()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If deHesab.rslistchek.State <> 0 Then deHesab.rslistchek.Close()
        deHesab.listchek("select * from chek ")

        Dim i As Short
        i = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = 0
        Do While deHesab.rslistchek.EOF = False

            mh1.rows.count = mh1.rows.count + 1

            mh1.setdata(i, 0, i)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(deHesab.rslistchek.Fields("sis_bes").Value) Then mh1.setdata(i, 1, deHesab.rslistchek.Fields("sis_bes").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(deHesab.rslistchek.Fields("moc_bes").Value) Then mh1.setdata(i, 2, deHesab.rslistchek.Fields("moc_bes").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(deHesab.rslistchek.Fields("IDchek").Value) Then mh1.setdata(i, 3, deHesab.rslistchek.Fields("IDchek").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(deHesab.rslistchek.Fields("pay").Value) Then mh1.setdata(i, 4, deHesab.rslistchek.Fields("pay").Value)
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            a = a + Val(mh1.getdata(i, 4))
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDbNull(deHesab.rslistchek.Fields("datee").Value) Then mh1.setdata(i, 5, deHesab.rslistchek.Fields("datee").Value)

            deHesab.rslistchek.MoveNext()

            i = i + 1
        Loop
        mh1.SetData(i, 3, "جمع ")
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh1.setdata(i, 4, a)
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'calcgrid
    End Sub
    Private Sub mh1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mh1.DoubleClick
        txtidchek.Text = mh1.GetData(mh1.Row, 3)
        txtidchek_Leave(txtidchek, New System.EventArgs())
    End Sub



    

    Private Sub cmddel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As Object
        Dim a As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox("برای حذف چک مطمئن هستید؟ ", MsgBoxStyle.YesNo)
        If a = MsgBoxResult.Yes Then
            If deHesab.rsfindchek.State <> 0 Then deHesab.rsfindchek.Close()
            deHesab.findchek(txtidchek.Text)
            If deHesab.rsfindchek.EOF = False Then
                deHesab.rsfindchek.Delete()
                deHesab.rsfindchek.Update()
                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msg = "چک حذف شد......."
                MsgBox(msg, MsgBoxStyle.Information)
                fillgrid()
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msg = "چک اشتباه میباشد  "
                MsgBox(msg, MsgBoxStyle.Critical)
            End If

        End If
        deHesab.rsfindchek.Close()
    End Sub

    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdloop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtidchek.Text = ""
        txtbank.Text = ""
        txtpay.Text = ""
        txtidchek.Focus()

    End Sub


    Private Sub frmchkdel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        clsgrid()
        fillgrid()
    End Sub

    Private Sub mh1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mh1.Enter
        Dim cod_cres As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cod_cres. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cod_cres = 1
    End Sub
    Private Sub mh1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles mh1.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case 13 'enter
            Case 46 ' delete
                mh1.setdata(mh1.Row, mh1.Col, "")
            Case 113 'f2
                'If cmdsave.Enabled = True Then cmdsave_Click
            Case 114 'f3

            Case 115 'f4

            Case 116 'f5

        End Select
    End Sub
    Private Sub calcgrid()
        Dim i As Object
        Dim totpay As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object totpay.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        totpay.Text = 0
        For i = 1 To mh1.Rows.Count - 1


            'UPGRADE_WARNING: Couldn't resolve default property of object totpay.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object totpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            totpay.Text = totpay + Val(mh1.GetData(i, 5))
        Next i

    End Sub

    
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
			Case 113
	
        End Select
	End Sub
	
	Private Sub mdate_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles mdate.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtbank_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtbank.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtcode_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtcode_LostFocus()
		Dim Key As Object
		Dim msg As Object
		Dim txtname As Object
		Dim txtcode As Object
		Dim chkbank As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object chkbank.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		chkbank.Value = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object txtcode.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Trim(txtcode.Text) = "" Then Exit Sub
		If deHesab.rsfindcode.State <> 0 Then deHesab.rsfindcode.Close()
		deHesab.findcode(txtcode)
		If deHesab.rsfindcode.EOF = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object txtname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtname = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "کد اشتباه است ..."
			MsgBox(msg, MsgBoxStyle.Information)

			'UPGRADE_WARNING: Couldn't resolve default property of object txtcode.SetFocus. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtcode.SetFocus()
		Else

			'UPGRADE_WARNING: Couldn't resolve default property of object txtname.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtname.Text = deHesab.rsfindcode.Fields("Name").Value
			'----------------------------
			
			'UPGRADE_WARNING: Couldn't resolve default property of object txtcode.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Key. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Key = CDbl("select * from kol where cod_dary='") + txtcode.Text + CDbl("' ")
			If deHesab.rsbrowkol.State <> 0 Then deHesab.rsbrowkol.Close()
			'UPGRADE_WARNING: Couldn't resolve default property of object Key. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            deHesab.browkol(Key)

			If deHesab.rsbrowkol.EOF = False Then
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(deHesab.rsbrowkol.Fields("Name").Value) Then txtbank_nam.Text = deHesab.rsbrowkol.Fields("Name").Value
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(deHesab.rsbrowkol.Fields("code").Value) Then txtbank_cod.Text = deHesab.rsbrowkol.Fields("code").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object chkbank.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				chkbank.Value = 1
			End If
			
		End If
		deHesab.rsfindcode.Close()
		'******************************************
	End Sub
	
	
	Private Sub txtdate_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtdate.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtidchek_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtidchek.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtidchek_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtidchek.Leave
		Dim msg As Object
		Err.Clear()
		If deHesab.rsfindchek.State <> 0 Then deHesab.rsfindchek.Close()
        deHesab.findchek(txtidchek.Text)
		If deHesab.rsfindchek.EOF = False Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(deHesab.rsfindchek.Fields("pay").Value) Then txtpay.Text = deHesab.rsfindchek.Fields("pay").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(deHesab.rsfindchek.Fields("bank").Value) Then txtbank.Text = deHesab.rsfindchek.Fields("bank").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(deHesab.rsfindchek.Fields("radif").Value) Then txtradif.Text = deHesab.rsfindchek.Fields("radif").Value
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "شماره چک اشتباه است"
			MsgBox(msg, MsgBoxStyle.Information)
			Err.Number = 1
		End If
		deHesab.rsfindchek.Close()
		
	End Sub
	
    Private Sub txtpay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtpay.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub
	
	Private Sub txtradif_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtradif.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtsis_bes_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
End Class