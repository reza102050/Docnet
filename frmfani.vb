Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmfani
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
		Me.Close()
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		Dim msg As Object
		On Error Resume Next
		If de1.rsfindmain.State <> 0 Then de1.rsfindmain.Close()
		de1.findmain()
		
		If de1.rsfindmain.RecordCount > 0 Then
			
			de1.rsfindmain.Fields("mabna").Value = Val(txtmabna.Text)
			de1.rsfindmain.Fields("omabna").Value = Val(txtomabna.Text)
			de1.rsfindmain.Fields("cod_sanad").Value = Val(txtNopay.Text)
			'de1.rsfindmain!ofhaz = Val(txtofhaz)
			
			'-----------------------------------------------
			de1.rsfindmain.Fields("fdpay").Value = Val(txtfdpay.Text)
			de1.rsfindmain.Fields("fdpay1").Value = Val(txtfdpay1.Text)
			de1.rsfindmain.Fields("fnpay").Value = Val(txtfnpay.Text)
			de1.rsfindmain.Fields("fnpay1").Value = Val(txtfnpay1.Text)
			'------------------------
			de1.rsfindmain.Fields("fdper").Value = Val(txtfdper.Text)
			de1.rsfindmain.Fields("fdper1").Value = Val(txtfdper1.Text)
			de1.rsfindmain.Fields("fnper").Value = Val(txtfnper.Text)
			de1.rsfindmain.Fields("fnper1").Value = Val(txtfnper1.Text)
			'------------------------------------------------
			de1.rsfindmain.Fields("ofdpay").Value = Val(txtofdpay.Text)
			de1.rsfindmain.Fields("ofdpay1").Value = Val(txtofdpay1.Text)
			de1.rsfindmain.Fields("ofnpay").Value = Val(txtofnpay.Text)
			de1.rsfindmain.Fields("ofnpay1").Value = Val(txtofnpay1.Text)
			'------------------------
			de1.rsfindmain.Fields("ofdper").Value = Val(txtofdper.Text)
			de1.rsfindmain.Fields("ofdper1").Value = Val(txtofdper1.Text)
			de1.rsfindmain.Fields("ofnper").Value = Val(txtofnper.Text)
			de1.rsfindmain.Fields("ofnper1").Value = Val(txtofnper1.Text)
			de1.rsfindmain.Fields("hour1").Value = txthour1.Text
			de1.rsfindmain.Fields("hour2").Value = txthour2.Text
			de1.rsfindmain.Fields("otcmax").Value = Val(txtotcmax.Text)
			de1.rsfindmain.Fields("otctip").Value = Check1.CheckState
			de1.rsfindmain.Update()
			'--------------------------------------------------
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "ثبت گردید"
			MsgBox(msg, MsgBoxStyle.Information)
		End If
		de1.rsfindmain.Close()
	End Sub
	
	'UPGRADE_WARNING: Form event frmfani.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmfani_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		On Error Resume Next
		If de1.rsfindmain.State <> 0 Then de1.rsfindmain.Close()
		de1.findmain()
		
		If de1.rsfindmain.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("mabna").Value) Then txtmabna.Text = de1.rsfindmain.Fields("mabna").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("omabna").Value) Then txtomabna.Text = de1.rsfindmain.Fields("omabna").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("cod_sanad").Value) Then txtNopay.Text = de1.rsfindmain.Fields("cod_sanad").Value
			
			'-----------------------------------------------
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fdpay").Value) Then txtfdpay.Text = de1.rsfindmain.Fields("fdpay").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fdpay1").Value) Then txtfdpay1.Text = de1.rsfindmain.Fields("fdpay1").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fnpay").Value) Then txtfnpay.Text = de1.rsfindmain.Fields("fnpay").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fnpay1").Value) Then txtfnpay1.Text = de1.rsfindmain.Fields("fnpay1").Value
			'------------------------
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fdper").Value) Then txtfdper.Text = de1.rsfindmain.Fields("fdper").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fdper1").Value) Then txtfdper1.Text = de1.rsfindmain.Fields("fdper1").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fnper").Value) Then txtfnper.Text = de1.rsfindmain.Fields("fnper").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("fnper1").Value) Then txtfnper1.Text = de1.rsfindmain.Fields("fnper1").Value
			'------------------------------------------------
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofdpay").Value) Then txtofdpay.Text = de1.rsfindmain.Fields("ofdpay").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofdpay1").Value) Then txtofdpay1.Text = de1.rsfindmain.Fields("ofdpay1").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofnpay").Value) Then txtofnpay.Text = de1.rsfindmain.Fields("ofnpay").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofnpay1").Value) Then txtofnpay1.Text = de1.rsfindmain.Fields("ofnpay1").Value
			'------------------------
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofdper").Value) Then txtofdper.Text = de1.rsfindmain.Fields("ofdper").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofdper1").Value) Then txtofdper1.Text = de1.rsfindmain.Fields("ofdper1").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofnper").Value) Then txtofnper.Text = de1.rsfindmain.Fields("ofnper").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("ofnper1").Value) Then txtofnper1.Text = de1.rsfindmain.Fields("ofnper1").Value
			'--------------------------------------------------
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("hour1").Value) Then txthour1.Text = de1.rsfindmain.Fields("hour1").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("hour2").Value) Then txthour2.Text = de1.rsfindmain.Fields("hour2").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("otcmax").Value) Then txtotcmax.Text = de1.rsfindmain.Fields("otcmax").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindmain.Fields("otctip").Value) Then Check1.CheckState = de1.rsfindmain.Fields("otctip").Value
			
		End If
		
	End Sub
	
	Private Sub txtfdpay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfdpay.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtfdpay1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfdpay1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
				
				
		End Select
	End Sub
	
	Private Sub txtfhaz_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtfnper_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfnper.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtfnper1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfnper1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txthour1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txthour1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txthour2_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txthour2.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtmabna_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtmabna.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtNopay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtNopay.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtofdpay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofdpay.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofdpay1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofdpay1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtfnpay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfnpay.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtfnpay1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfnpay1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	
	Private Sub txtofnpay_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofnpay.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofnpay1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofnpay1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtfdper_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfdper.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtfdper1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtfdper1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofdper_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofdper.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofdper1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofdper1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofnper_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofnper.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	Private Sub txtofnper1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtofnper1.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtomabna_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtomabna.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtotcmax_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtotcmax.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub

    
End Class