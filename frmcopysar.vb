Option Strict Off
Option Explicit On
Friend Class frmcopysar
	Inherits System.Windows.Forms.Form
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
			Case 113
		End Select
	End Sub
	
	Private Sub cmdplus_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdplus.Click
		Dim t2 As Object
		Dim t1 As Object
		Dim i As Object
        For i = 1 To mh1.rows.count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(mh1.getdata(i, 0)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t1 = Mid(mh1.getdata(i, 0), 7, 3)
                'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t2 = txtkol.Text & txtmon.Text + t1
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh1.setdata(i, 0, t2)
            End If
        Next i

    End Sub

    Private Sub cmdsave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsave.Click
        Dim txtnamet1 As Object
        Dim tmpcode As Object
        Dim i As Object
        Dim a As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox("»—«Ì À»  ”—›’· Â« „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo)
        If a <> MsgBoxResult.Yes Then Exit Sub
        For i = 1 To mh1.rows.count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcode = mh1.getdata(i, 0)
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object txtnamet1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtnamet1 = mh1.getdata(i, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(tmpcode) > 0 Then
                If deHesab.rsfindcode.State <> 0 Then deHesab.rsfindcode.Close()
                deHesab.findcode(tmpcode)

                If deHesab.rsfindcode.EOF = True Then
                    deHesab.rsfindcode.AddNew()
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    deHesab.rsfindcode.Fields("code").Value = tmpcode
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object txtnamet1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                deHesab.rsfindcode.Fields("Name").Value = txtnamet1
                deHesab.rsfindcode.Fields("codk").Value = txtkol.Text
                deHesab.rsfindcode.Fields("codm").Value = txtkol.Text & txtmon.Text
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                deHesab.rsfindcode.Fields("codj").Value = tmpcode
                deHesab.rsfindcode.Fields("lvl").Value = 3
                deHesab.rsfindcode.Fields("taf1").Value = 1

                deHesab.rsfindcode.Update()
                '---------------------------------------------------------------------'
            End If

        Next i
        MsgBox("À»  ê—œÌœ.....", MsgBoxStyle.Information)
    End Sub
	
	Private Sub txtkol_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtkol.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = 13 Then
			System.Windows.Forms.SendKeys.Send("{TAB}")
		End If
		
	End Sub
	
	Private Sub txtkol_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtkol.Leave
		If deHesab.rsfindcode.State <> 0 Then deHesab.rsfindcode.Close()
        deHesab.findcode(txtkol.Text)
		txtnamek.Enabled = False
		If deHesab.rsfindcode.RecordCount = 0 Then
			txtnamek.Text = ""
		Else
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(deHesab.rsfindcode.Fields("Name").Value) Then txtnamek.Text = deHesab.rsfindcode.Fields("Name").Value
			
		End If
		'key1 = "select * from kol where lvl=2 and codk='" + txtkol.Text + "'order by code"
		'If deHesab.rslistcode.State <> 0 Then deHesab.rslistcode.Close
		'deHesab.rslistcode.Source = key1
		'deHesab.rslistcode.Open
		'
		'disname
	End Sub
	
	Private Sub txtmon_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtmon.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = 13 Then
			System.Windows.Forms.SendKeys.Send("{TAB}")
		End If
		
	End Sub
	
	Private Sub txtmon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtmon.Leave
		If Val(txtmon.Text) = 0 Then Exit Sub
		If deHesab.rsfindcode.State <> 0 Then deHesab.rsfindcode.Close()
		deHesab.findcode(txtkol.Text & txtmon.Text)
		txtnamem.Enabled = False
		If deHesab.rsfindcode.RecordCount = 0 Then
			
			txtnamem.Text = ""
		Else
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(deHesab.rsfindcode.Fields("Name").Value) Then txtnamem.Text = deHesab.rsfindcode.Fields("Name").Value
			
		End If
		't1 = txtkol.Text + txtmon.Text
		'key1 = "select * from kol where lvl=3 and codm='" + t1 + "'order by code"
		'If deHesab.rslistcode.State <> 0 Then deHesab.rslistcode.Close
		'deHesab.rslistcode.Source = key1
		'deHesab.rslistcode.Open
		'disname
	End Sub
End Class