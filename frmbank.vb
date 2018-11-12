Option Strict Off
Option Explicit On
Friend Class frmbank
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdexit_Click()
		Me.Close()
	End Sub
	
	
	
	Private Sub cmdnz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdnz.Click
		frmorgan.Show()
	End Sub
	
	
	Private Sub hotkey(ByRef KeyCode As Short)
		Select Case KeyCode
			Case 13
				System.Windows.Forms.SendKeys.Send("{TAB}")
		End Select
	End Sub
	
	Private Sub frmlogin_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	
	Private Sub clsgrid()
		
	End Sub
	Private Sub clsgrid1()
        mh1.rows.count = 2
        mh1.Cols.Count = 7
		mh1.Clear()
        'mh1.set_ColAlignmentFixed(0, 5)
        'mh1.set_ColWidth(0, 1000)
        'mh1.set_ColWidth(1, 2200)
        'mh1.set_ColWidth(2, 2200)
        'mh1.set_ColWidth(3, 2200)
        'mh1.set_ColWidth(4, 1600)
        'mh1.set_ColWidth(5, 1200)
        'mh1.set_ColWidth(6, 2200)
        '-----------------------------------------------------------------------

        mh1.SetData(0, 0, "کد سازمان ")
        mh1.SetData(0, 1, "نام  ")
        mh1.SetData(0, 2, "نام بانک ")
        mh1.SetData(0, 3, "نام شعبه ")
        mh1.SetData(0, 4, "شماره حساب ")
        mh1.SetData(0, 5, "کد شناسایی ")
        mh1.SetData(0, 6, "نام شهرستان")
    End Sub

    Private Sub fillgrid2()
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If de1.rsbrowbank.State <> 0 Then de1.rsbrowbank.Close()
        de1.browbank()
        Dim i As Short
        i = 1
        clsgrid1()
        If de1.rsbrowbank.RecordCount = 0 Then

        Else
            Do While de1.rsbrowbank.EOF = False
                mh1.Rows.Count = mh1.Rows.Count + 1
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("organ_code").Value) Then mh1.SetData(i, 0, de1.rsbrowbank.Fields("organ_code").Value)
                mh1.SetData(i, 1, sayorgan(Val(mh1.GetData(i, 0))))
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("bankname").Value) Then mh1.SetData(i, 2, de1.rsbrowbank.Fields("bankname").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("brn_name").Value) Then mh1.SetData(i, 3, de1.rsbrowbank.Fields("brn_name").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("hesab").Value) Then mh1.SetData(i, 4, de1.rsbrowbank.Fields("hesab").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("codem").Value) Then mh1.SetData(i, 5, de1.rsbrowbank.Fields("codem").Value)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsbrowbank.Fields("cityname").Value) Then mh1.SetData(i, 6, de1.rsbrowbank.Fields("cityname").Value)

                de1.rsbrowbank.MoveNext()
                i = i + 1
            Loop
        End If
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub cmdsave1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsave1.Click
        Dim msg As Object
        Dim tmpcod As Object
        Dim i As Object
        If de1.rsbrowbank.State <> 0 Then de1.rsbrowbank.Close()
        de1.browbank()
        Do While de1.rsbrowbank.EOF = False
            de1.rsbrowbank.Delete()
            de1.rsbrowbank.Update()
            de1.rsbrowbank.MoveNext()
        Loop
        '-----------------------------------------------------------------
        For i = 1 To mh1.rows.count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh1.getdata(i, 0))

            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcod > 0 Then
                de1.rsbrowbank.AddNew()
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("organ_code").Value = mh1.getdata(i, 0)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("bankname").Value = mh1.getdata(i, 2)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("brn_name").Value = mh1.getdata(i, 3)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("hesab").Value = mh1.getdata(i, 4)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("codem").Value = mh1.getdata(i, 5)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsbrowbank.Fields("cityname").Value = mh1.getdata(i, 6)
                de1.rsbrowbank.Update()
            End If
        Next i
        de1.rsbrowbank.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "ثبت شد..."
        MsgBox(msg, MsgBoxStyle.Information)

    End Sub


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me.Close()
    End Sub

    

    

    Private Sub frmbank_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        clsgrid1()
        fillgrid2()
    End Sub

    Private Sub Text2_Change()

    End Sub

    Private Sub txtbank_name_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub mh1_KeyDownEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh1.KeyDown
        Select Case e.KeyCode
            Case 46 ' delete
                mh1.SetData(mh1.Row, mh1.Col, "")
        End Select
        ' hotkey KeyCode
    End Sub
    Private Sub mh1_KeyPressEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh1.KeyPress
        Dim tmpcod As Object
        Dim mKeyAscii As Integer
        mKeyAscii = Asc(e.KeyChar)
        If mKeyAscii = 32 Or (mKeyAscii >= 40 And mKeyAscii <= 133) Or (mKeyAscii >= 159 And mKeyAscii <= 159) Or (mKeyAscii >= 161 And mKeyAscii <= 162) Or (mKeyAscii >= 191 And mKeyAscii <= 237) Or (mKeyAscii >= 138 And mKeyAscii <= 156) Then
            If Len(mh1.GetData(mh1.Row, mh1.Col)) > 0 Then
                If Mid(mh1.GetData(mh1.Row, mh1.Col), Len(mh1.GetData(mh1.Row, mh1.Col)), 1) = "|" Then
                    mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
                End If
            End If
            mh1.SetData(mh1.Row, mh1.Col, mh1.GetData(mh1.Row, mh1.Col) & Chr(mKeyAscii))
        End If
        If mKeyAscii = 8 And mh1.GetData(mh1.Row, mh1.Col) <> "" Then
            If Mid(mh1.GetData(mh1.Row, mh1.Col), Len(mh1.GetData(mh1.Row, mh1.Col)), 1) = "|" Then
                mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
            End If
            If mh1.GetData(mh1.Row, mh1.Col) <> "" Then
                mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
            End If
        End If
        If mKeyAscii = 13 Then
            If Len(mh1.GetData(mh1.Row, mh1.Col)) > 0 Then
                If Mid(mh1.GetData(mh1.Row, mh1.Col), Len(mh1.GetData(mh1.Row, mh1.Col)), 1) = "|" Then
                    mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
                End If
            End If
            If mh1.Col < 6 Then
                mh1.Col = mh1.Col + 1
            Else
                mh1.Col = 0
                If mh1.Row < mh1.Rows.Count - 1 Then
                    mh1.Row = mh1.Row + 1
                Else
                    mh1.Rows.Count = mh1.Rows.Count + 1
                    mh1.Row = mh1.Row + 1

                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh1.GetData(mh1.Row, 0))
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcod > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh1.SetData(mh1.Row, 1, sayorgan(tmpcod))
            Else
                mh1.SetData(mh1.Row, 1, "")
            End If

            '  *********************************************

        End If
        'calcgrid
    End Sub

    Private Sub mh1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mh1.Leave
        Dim cod_cres As Object
        If Len(mh1.getdata(mh1.Row, mh1.Col)) > 0 Then
            If Mid(mh1.getdata(mh1.Row, mh1.Col), Len(mh1.getdata(mh1.Row, mh1.Col)), 1) = "|" Then
                mh1.setdata(mh1.Row, mh1.Col, Mid(mh1.getdata(mh1.Row, mh1.Col), 1, Len(mh1.getdata(mh1.Row, mh1.Col)) - 1))
            End If
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object cod_cres. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cod_cres = 0
    End Sub
	
	
	Private Sub txtbankname_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtbrn_name_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtcode_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
	
	Private Sub txtcode_LostFocus()
		Dim txtname As Object
		Dim txtcode As Object
		If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object txtcode.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		de1.findbdhosp(txtcode.Text)
		If de1.rsfindbdhosp.EOF = False Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_WARNING: Couldn't resolve default property of object txtname.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not IsDbNull(de1.rsfindbdhosp.Fields("Name").Value) Then txtname.Text = de1.rsfindbdhosp.Fields("Name").Value
			fillgrid2()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object txtname.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtname.Text = ""
			
		End If
	End Sub
	
	
	
	Private Sub txtname_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
		hotkey(KeyCode)
	End Sub
End Class