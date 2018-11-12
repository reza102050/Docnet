Option Strict Off
Option Explicit On
Friend Class frmedit
	Inherits System.Windows.Forms.Form
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
				
				
		End Select
	End Sub
	
    Private Sub opttip2_CheckedChanged(sender As Object, e As EventArgs) Handles opttip2.CheckedChanged
        If opttip2.Checked = True Then
            txtTafkik.Text = 0 ' no tafkik
        End If
    End Sub

    Private Sub opttip0_CheckedChanged(sender As Object, e As EventArgs) Handles opttip0.CheckedChanged
        If opttip0.Checked = True Then
            txtTafkik.Text = 1 ' visit
        End If
    End Sub

    Private Sub opttip1_CheckedChanged(sender As Object, e As EventArgs) Handles opttip1.CheckedChanged
        If opttip1.Checked = True Then
            txtTafkik.Text = 2 ' khed
        End If
    End Sub

	
    Private Sub cmdexit_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub cmdsort_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSort.Click
        Dim tmpnumber As Object
        Dim sqlstring As Object
        Dim a As Object
        Dim msg As Object
        If Val(txtmonth.Text) = 0 Then
            MsgBox("ماه نسخه ها رامشخص نمایید", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "برای مرتب نمودن نسخ مطمئن هستید؟"
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = 7
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox(msg, MsgBoxStyle.YesNo)
        If a <> MsgBoxResult.Yes Then Exit Sub

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'UPGRADE_WARNING: Couldn't resolve default property of object sqlstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
           Select Val(txtTafkik.Text)
            Case 0
                sqlstring = "select  pha_detail.radif as radif,pha_detail.na as na,pha_detail.coseshbs as coseshbs,pha_detail.datee as datee,pha_detail.number  ,pha_detail.doc_name as doc_name,pha_detail.tot as tot,pha_detail.org as org,pha_detail.bimar as bimar,pha_detail.id as id   from pha_detail   where  pha_detail.monthh=" & txtmonth.Text & " and pha_detail.cath=" & txtcath.Text & " order by datee,number "
            Case 1
                sqlstring = "select  pha_detail.radif as radif,pha_detail.na as na,pha_detail.coseshbs as coseshbs,pha_detail.datee as datee,pha_detail.number  ,pha_detail.doc_name as doc_name,pha_detail.tot as tot,pha_detail.org as org,pha_detail.bimar as bimar,pha_detail.id as id   from pha_detail   where  vaz=0 and pha_detail.monthh=" & txtmonth.Text & " and pha_detail.cath=" & txtcath.Text & " order by datee,number "
            Case 2
                sqlstring = "select  pha_detail.radif as radif,pha_detail.na as na,pha_detail.coseshbs as coseshbs,pha_detail.datee as datee,pha_detail.number  ,pha_detail.doc_name as doc_name,pha_detail.tot as tot,pha_detail.org as org,pha_detail.bimar as bimar,pha_detail.id as id   from pha_detail   where  vaz=1 and pha_detail.monthh=" & txtmonth.Text & " and pha_detail.cath=" & txtcath.Text & " order by datee,number "

        End Select
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object sqlstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(sqlstring)

        'de1.rsbrowall.Open()
        If de1.rsbrowall.RecordCount = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "اطلاعاتی پیدانشد ...."
            'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MsgBox(msg, MsgBoxStyle.Information)

            Exit Sub
        End If

        Dim i As Short
        i = 1
        On Error GoTo nrec
        Do While de1.rsbrowall.EOF = False

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpnumber. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsbrowall.Fields("number").Value) Then tmpnumber = de1.rsbrowall.Fields("number").Value
            de1.rsbrowall.Fields("radif").Value = i
            de1.rsbrowall.Update()

            i = i + 1
            de1.rsbrowall.MoveNext()
        Loop
        de1.rsbrowall.Close()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "نسخ براساس تاریخ مرتب گردید"
        MsgBox(msg, MsgBoxStyle.Information)
        Exit Sub
nrec:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpnumber. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "اشکا درمرتب سازی نسخ" & Str(tmpnumber)
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MsgBox(msg, MsgBoxStyle.Critical)

    End Sub



    Private Sub Command1_Click()
        frmlcath.Show()
    End Sub

    Private Sub cmdDelZero_click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelzero.Click
        Dim sqlstring As Object
        Dim a As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = 7
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox("برای حذف نسخ با مبلغ صفر مطمئن هستید؟", MsgBoxStyle.YesNo)
        If a <> MsgBoxResult.Yes Then Exit Sub

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'UPGRADE_WARNING: Couldn't resolve default property of object sqlstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sqlstring = "delete  from pha_detail   where  pha_detail.org=0 and pha_detail.bimar=0 and pha_detail.tot=0 and pha_detail.monthh=" & txtmonth.Text & " and pha_detail.cath=" & txtcath.Text & "  "
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object sqlstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(sqlstring)

        MsgBox("نسخ با مبلغ صفر حذف گردید", MsgBoxStyle.Information)
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
	
	
	Private Sub Text1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	'UPGRADE_WARNING: Event txtcath.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtcath_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcath.TextChanged
		txtcath_Leave(txtcath, New System.EventArgs())
		
	End Sub
	
	Private Sub txtcath_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtcath.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = 13 Then
			System.Windows.Forms.SendKeys.Send("{TAB}")
		End If
		
	End Sub
	
	
	Private Sub txtcath_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcath.Leave
		If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
		de1.findcath(Val(txtcath.Text))
		If de1.rsfindcath.EOF = False Then
			'If Not IsNull(de1.rsfindcath!org) Then txtorg = de1.rsfindcath!org
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(de1.rsfindcath.Fields("Name").Value) Then txtname.Text = de1.rsfindcath.Fields("Name").Value
			'If Not IsNull(de1.rsfindcath!bimar) Then txtbimar = de1.rsfindcath!bimar
			'If Not IsNull(de1.rsfindcath!organ_Name) Then txtorgan_name = de1.rsfindcath!organ_Name
			'If Not IsNull(de1.rsfindcath!organ_code) Then txtorgan_code = de1.rsfindcath!organ_code
			'If Not IsNull(de1.rsfindcath!paydoc) Then txtpaydoc = de1.rsfindcath!paydoc
			'If Not IsNull(de1.rsfindcath!paymot) Then txtpaymot = de1.rsfindcath!paymot
			'If Not IsNull(de1.rsfindcath!payden) Then txtpayden = de1.rsfindcath!payden
			'If Not IsNull(de1.rsfindcath!fhaz) Then txtfhaz.Text = de1.rsfindcath!fhaz
			'If Not IsNull(de1.rsfindcath!pt) Then txtpt.Text = de1.rsfindcath!pt
			'If Not IsNull(de1.rsfindcath!dc) Then txtdc.Text = de1.rsfindcath!dc
			'If Not IsNull(de1.rsfindcath!fname) Then txtfname.Text = de1.rsfindcath!fname
			'If Not IsNull(de1.rsfindcath!khas) Then txtkhas = de1.rsfindcath!khas
			'If Not IsNull(de1.rsfindcath!nprint) Then txtnprint = de1.rsfindcath!nprint
			
			'If Not IsNull(de1.rsfindcath!fanitip) Then chkfanitip.Value = de1.rsfindcath!fanitip
		Else
			txtname.Text = ""
		End If
		de1.rsfindcath.Close()
	End Sub
	
	Private Sub txtmonth_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtmonth.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub

    Private Sub frmedit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtmonth.Text = frmlog.txtmonth.Text
    End Sub
End Class