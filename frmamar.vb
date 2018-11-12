Option Strict Off
Option Explicit On
Friend Class frmamar
	Inherits System.Windows.Forms.Form
	
    Private Sub cmddo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim g_SQLString As Object
        If Val(txtmonth.Text) = 0 Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        g_SQLString = "select pha_detail.cath,count(pha_detail.cath) as nos ,sum(pha_detail.tafavot) as tafavot,sum(pha_detail.tot) as tot,sum(pha_detail.org) as org ,sum(pha_detail.bimar) as bimar,sum(pha_detail.fhaz) as fhaz,sum(pha_detail.fani) as fani  from pha_detail   where  pha_detail.monthh=" & txtmonth.Text & "  group by pha_detail.cath"
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(g_SQLString)

        fillgrid()
    End Sub
	Private Sub txtcath_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		If KeyCode = 13 Then
			System.Windows.Forms.SendKeys.Send("{TAB}")
		End If
		
	End Sub
	
	Private Sub txtcath_LostFocus()
		Dim txtfname As Object
		Dim txtpt As Object
		Dim txtdc As Object
		Dim txtcathname As Object
		Dim txtcath As Object
		
		If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object txtcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		de1.findcath(Val(txtcath))
		If de1.rsfindcath.EOF = False Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtcathname.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("Name").Value) Then txtcathname.Text = de1.rsfindcath.Fields("Name").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtdc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("dc").Value) Then txtdc = de1.rsfindcath.Fields("dc").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtpt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("pt").Value) Then txtpt = de1.rsfindcath.Fields("pt").Value
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtfname.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindcath.Fields("fname").Value) Then txtfname.Text = de1.rsfindcath.Fields("fname").Value
		End If
		de1.rsfindcath.Close()
	End Sub
	
	Private Sub clsgrid()
        mh1.Rows.Count = 2
        mh1.Cols.Count = 9
		mh1.Clear()
		
        
        mh1.SetData(0, 0, "کد  ")
        mh1.SetData(0, 1, "بیمه ")
        mh1.SetData(0, 2, "تعداد نسخه")
        mh1.SetData(0, 3, "دریافتی")
        mh1.SetData(0, 4, "جمع سهم سازمان")
        mh1.SetData(0, 5, "جمع سهم بیمار")
        mh1.SetData(0, 6, "جمع تفاوت")
        mh1.SetData(0, 7, "حق فنی")
        mh1.SetData(0, 8, "حق ثبت")

    End Sub
    Private Sub fillgrid()
        Dim t8 As Object
        Dim t6 As Object
        Dim t5 As Object
        Dim t4 As Object
        Dim t3 As Object
        Dim t2 As Object
        Dim t7 As Object
        Dim msg As Object
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim i As Short
        i = 1
        clsgrid()
        If de1.rsbrowall.RecordCount = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "اطلاعاتی پیدا نشد "
            MsgBox(msg, MsgBoxStyle.Information)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object t7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t7 = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t2 = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object t3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t3 = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object t4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t4 = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object t5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t5 = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object t6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t6 = 0
            Do While de1.rsbrowall.EOF = False
                mh1.Rows.Count = mh1.Rows.Count + 1
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("cath").Value) Then mh1.SetData(i, 0, de1.rsbrowall.Fields("cath").Value)
                If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
                de1.findcath(Val(mh1.GetData(i, 0)))
                If de1.rsfindcath.EOF = False Then
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then mh1.SetData(i, 1, de1.rsfindcath.Fields("Name").Value)
                End If

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("nos").Value) Then mh1.SetData(i, 2, de1.rsbrowall.Fields("nos").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("org").Value) Then mh1.SetData(i, 4, de1.rsbrowall.Fields("org").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("bimar").Value) Then mh1.SetData(i, 5, de1.rsbrowall.Fields("bimar").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("tafavot").Value) Then mh1.SetData(i, 6, de1.rsbrowall.Fields("tafavot").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("fani").Value) Then mh1.SetData(i, 7, de1.rsbrowall.Fields("fani").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowall.Fields("fhaz").Value) Then mh1.SetData(i, 8, de1.rsbrowall.Fields("fhaz").Value)
                'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t2 = t2 + Val(mh1.GetData(i, 2))
                mh1.SetData(i, 3, Val(mh1.GetData(i, 5)) + Val(mh1.GetData(i, 6)) + Val(mh1.GetData(i, 7)) + Val(mh1.GetData(i, 8)))
                'UPGRADE_WARNING: Couldn't resolve default property of object t3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t3 = t3 + Val(mh1.GetData(i, 3))
                'UPGRADE_WARNING: Couldn't resolve default property of object t4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t4 = t4 + Val(mh1.GetData(i, 4))
                'UPGRADE_WARNING: Couldn't resolve default property of object t5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t5 = t5 + Val(mh1.GetData(i, 5))
                'UPGRADE_WARNING: Couldn't resolve default property of object t6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t6 = t6 + Val(mh1.GetData(i, 6))
                'UPGRADE_WARNING: Couldn't resolve default property of object t7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t7 = t7 + Val(mh1.GetData(i, 7))
                'UPGRADE_WARNING: Couldn't resolve default property of object t8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                t8 = t8 + Val(mh1.GetData(i, 8))
                de1.rsbrowall.MoveNext()
                i = i + 1
            Loop
            mh1.SetData(i, 1, "جمع کل")
            'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 2, t2)
            'UPGRADE_WARNING: Couldn't resolve default property of object t3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 3, t3)
            'UPGRADE_WARNING: Couldn't resolve default property of object t4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 4, t4)
            'UPGRADE_WARNING: Couldn't resolve default property of object t5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 5, t5)
            'UPGRADE_WARNING: Couldn't resolve default property of object t6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 6, t6)
            'UPGRADE_WARNING: Couldn't resolve default property of object t7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 7, t7)
            'UPGRADE_WARNING: Couldn't resolve default property of object t8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(i, 8, t8)
        End If
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub
	
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
		End Select
	End Sub
	
    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
	
	
	
    Private Sub CmddayReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDayReport.Click
        Dim g_SQLString As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        g_SQLString = "select pha_detail.cath,count(pha_detail.cath) as nos ,sum(pha_detail.tafavot) as tafavot,sum(pha_detail.tot) as tot,sum(pha_detail.org) as org ,sum(pha_detail.bimar) as bimar,sum(pha_detail.fhaz) as fhaz,sum(pha_detail.fani) as fani  from pha_detail   where  pha_detail.tasb='" & txtdat1.Text & "'  group by pha_detail.cath"
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(g_SQLString)

        fillgrid()

    End Sub
	
    Private Sub CmdHour_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim g_SQLString As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        g_SQLString = "select pha_detail.cath,count(pha_detail.cath) as nos ,sum(pha_detail.tafavot) as tafavot,sum(pha_detail.tot) as tot,sum(pha_detail.org) as org ,sum(pha_detail.bimar) as bimar,sum(pha_detail.fhaz) as fhaz,sum(pha_detail.fani) as fani  from pha_detail   where  tim>='" & Text1.Text & "' and tim<='" & Text2.Text & "' and pha_detail.tasb='" & txtdat1.Text & "'  group by pha_detail.cath"
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(g_SQLString)
        If de1.rsbrowall.RecordCount = 0 Then
            MsgBox("اطلاعاتی پیدانشد", MsgBoxStyle.Critical)
            Exit Sub
        End If
        fillgrid()

    End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Dim g_SQLString As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		g_SQLString = "select pha_detail.tim  from pha_detail   where  pha_detail.tasb='" & txtdat1.Text & "'  order by tim"
		If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object g_SQLString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.browall(g_SQLString)

		If de1.rsbrowall.RecordCount = 0 Then
            MsgBox("اطلاعاتی پیدانشد", MsgBoxStyle.Critical)
			Exit Sub
		End If
		Text1.Text = de1.rsbrowall.Fields("tim").Value
		de1.rsbrowall.MoveLast()
		Text2.Text = de1.rsbrowall.Fields("tim").Value
	End Sub
	
	Private Sub frmamar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		txtdat1.Text = mainform.txtdate1.Text
	End Sub
	
	Private Sub txtmonth_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtmonth.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		hotkey(KeyCode)
	End Sub

    
End Class