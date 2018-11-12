Option Strict Off
Option Explicit On
Friend Class frmcopydaro
	Inherits System.Windows.Forms.Form
	Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
		Me.Close()
	End Sub
	
	Private Sub cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdok.Click
		Dim a As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a = MsgBox("»—«Ì Õ–› „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo)
		If a = MsgBoxResult.Yes Then
			If de1.rslistdarocond.State <> 0 Then de1.rslistdarocond.Close()
            de1.listdarocond("delete from daro_cond where cath=" & txtcode.Text & " ")

			MsgBox("Õ–› ê—œÌœ......", MsgBoxStyle.Information)
		End If
	End Sub
	
	Private Sub cmdsave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsave.Click
		Dim msg As Object
		Dim tmpbimeh_pay As Object
		Dim tmpdaro_code As Object
		Dim a As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a = MsgBox("»—«Ì «Ã—«Ì «Ì‰ »—‰«„Â „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo)
		If a <> MsgBoxResult.Yes Then Exit Sub
		If Val(txtcode.Text) = 0 Then Exit Sub
		If Val(txtcode1.Text) = 0 Then Exit Sub
		On Error GoTo norec
		If de1.rslistdaroCond1.State <> 0 Then de1.rslistdaroCond1.Close()
        de1.listdaroCond1("delete from daro_cond where cath=" & txtcode.Text & " ")
		

		If de1.rslistdaroCond1.State <> 0 Then de1.rslistdaroCond1.Close()
		'------------------------------------
        de1.listdaroCond1("select * from daro_cond where cath=" & txtcode.Text & " ")
		

		'-------------------------------------------- Olgoo cath
		If de1.rslistdarocond.State <> 0 Then de1.rslistdarocond.Close()
        de1.listdarocond("select * from daro_cond where cath=" & txtcode1.Text & " ")
		

		
		'-------------------------------------------------'
		
		
		Do While de1.rslistdarocond.EOF = False
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpdaro_code. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpdaro_code = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimeh_pay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpbimeh_pay = 0
			
			
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpdaro_code. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rslistdarocond.Fields("daro_code").Value) Then tmpdaro_code = de1.rslistdarocond.Fields("daro_code").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimeh_pay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rslistdarocond.Fields("bimeh_pay").Value) Then tmpbimeh_pay = de1.rslistdarocond.Fields("bimeh_pay").Value
			
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpdaro_code. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.Text = tmpdaro_code
			
			de1.rslistdaroCond1.AddNew()
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpdaro_code. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			de1.rslistdaroCond1.Fields("daro_code").Value = tmpdaro_code
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimeh_pay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			de1.rslistdaroCond1.Fields("bimeh_pay").Value = tmpbimeh_pay
			de1.rslistdaroCond1.Fields("cath").Value = Val(txtcode.Text)
			de1.rslistdaroCond1.Fields("tadate").Value = "1386/12/30"
			de1.rslistdaroCond1.Update()
			
			de1.rslistdarocond.MoveNext()
			
		Loop 
		de1.rslistdarocond.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		msg = "ﬂÅÌ «ÿ·«⁄«  œ«—Ê »—«Ì »Ì„Â ›Êﬁ «ÌÃ«œ ‘œ...."
		MsgBox(msg, MsgBoxStyle.Information)
		Exit Sub
norec: 
		'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		msg = "«‘ò«· œ—  ‘òÌ· ›«Ì· —Ì“ ﬁÌ„  »Ì„Â ...."
		MsgBox(msg, MsgBoxStyle.Critical)
	End Sub
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
		End Select
	End Sub
	
	Private Sub txtcode_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtcode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcode.Leave
		Dim msg As Object
		Dim txtorg As Object
		If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
		de1.findcath(Val(txtcode.Text))
		If de1.rsfindcath.EOF = False Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtorg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("org").Value) Then txtorg = de1.rsfindcath.Fields("org").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("Name").Value) Then txtname.Text = de1.rsfindcath.Fields("Name").Value
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			msg = "ﬂœ »Ì„Â «‘ »«Â «”  "
			MsgBox(msg, MsgBoxStyle.Information)
		End If
		
	End Sub
	Private Sub txtcode1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtcode1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtcode1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcode1.Leave
		Dim msg As Object
		If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
		de1.findcath(Val(txtcode1.Text))
		If de1.rsfindcath.EOF = False Then
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("Name").Value) Then txtname1.Text = de1.rsfindcath.Fields("Name").Value
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			msg = "ﬂœ »Ì„Â «‘ »«Â «”  "
			MsgBox(msg, MsgBoxStyle.Information)
		End If
		
	End Sub
End Class