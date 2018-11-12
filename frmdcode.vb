Option Strict Off
Option Explicit On
Friend Class frmdcode
	Inherits System.Windows.Forms.Form
	Dim RecordNo As Double
	
	Private Sub showlist(ByVal tmpstr As String)
        frmxlist.mh6.setdata(1, 0, tmpstr)
        'frmxlist.cboact.SelectedIndex = frmtanzim.cboact.SelectedIndex
        frmxlist.txtproc.Text = CStr(3)
        frmxlist.Show()
    End Sub

    Private Sub cboact_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub chkcodetip_Click()
        Dim chkcodetip As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object chkcodetip.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If chkcodetip.Value = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object chkcodetip.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            chkcodetip.Caption = "کداستاندارد"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object chkcodetip.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            chkcodetip.Caption = "کد غیراستاندارد"
        End If
    End Sub

    'UPGRADE_WARNING: Event chkfani.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'



    'UPGRADE_WARNING: Event chkIsShow.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'

    'UPGRADE_WARNING: Event chknonbimeh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'


    Private Sub cmdfindcode5_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdfindcode5.Click
        If de1.rsfindcode5.State <> 0 Then de1.rsfindcode5.Close()
        de1.findcode5((txtcode5.Text))
        If de1.rsfindcode5.EOF = False Then
            txtcode.Text = de1.rsfindcode5.Fields("daro_code").Value
        End If
        de1.rsfindcode5.Close()
        '-------------------------------------------------------
        txtcode_Leave(txtcode, New System.EventArgs())

    End Sub



    Private Sub cmdgetcode_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdgetcode.Click
        Dim tmpcode As Object
        Dim t5 As Object
        Dim t4 As Object
        Dim t3 As Object
        Dim ll As Object
        Dim t0 As Object
        Dim t2 As Object
        Dim tcod As Object
        Dim mm As Object
        Dim t1 As Object
        Dim msql As String


        If de1.rslistdaro.State <> 0 Then de1.rslistdaro.Close()
        
        t1 = de1.rslistdaro.Source
        msql = "select * from daro_code  order by daro_code desc "
        de1.listdaro(msql)


        tcod = ""
        t5 = 1
        If de1.rslistdaro.EOF = False Then
        
            If Not IsDBNull(de1.rslistdaro.Fields("daro_code").Value) Then tcod = de1.rslistdaro.Fields("daro_code").Value
        
            t2 = Mid(tcod, 3, 8)
        
            t0 = Mid(tcod, 1, 2)

            ll = Len(t2)
        
            t3 = Val(t2) + 1
        
            If Len(Trim(Str(t3))) < ll Then
        
                t4 = "0" & Trim(Str(t3))
            Else
                   t4 = Trim(Str(t3))
            End If
            
            t5 = t0 + t4
        End If
        t1 = Str(t5)

        If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
        de1.darocode(t1)
        If de1.rsdarocode.RecordCount <> 0 Then

            t1 = Val(t1) + 1
        End If

        txtcode.Text = t1
        txtcode_Leave(txtcode, New System.EventArgs())
nocode:
        txtcode.Focus()
    End Sub
    Private Function GetNewDaroCode() As String

    End Function
    Private Sub findvcode1()
        Dim tmpcokm As Object
        Dim tvcode As Object
        txtvcode.Text = ""
        If de1.rsFindvcode1.State <> 0 Then de1.rsFindvcode1.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object tvcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tvcode = txtcode.Text
        de1.findvcode1(tvcode, 0)
        If de1.rsFindvcode1.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsFindvcode1.Fields("vcode").Value) Then tmpcokm = de1.rsFindvcode1.Fields("vcode").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtvcode.Text = tmpcokm
        End If

    End Sub





    Private Sub cmdup3_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdup3.Click
        clsgrid5()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        txtcode5.Text = "11111"
        MsgBox("برای هرکدام ازبیمه های اصلی کد استاندارد درستون مربوطه مشخص نمایید ", MsgBoxStyle.Information)
    End Sub

    Private Sub mh5_KeyDownEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh5.KeyDown
        Dim SSTab1 As Object
        On Error GoTo e5
        Select Case e.KeyCode
            Case 32 'blank

            Case 46 ' delete
                mh5.SetData(mh5.Row, mh5.Col, "")
            Case 112 'f1
                If cmdlist.Enabled = True Then cmdlist_Click(cmdlist, New System.EventArgs)
            Case 115 'f4
                If mh5.Row >= 1 Then
                    mh5.RemoveItem(mh5.Row)
                End If


            Case 113 'f2
                Cmdsave_Click(cmdsave, New System.EventArgs)
            Case 117 'f4
                cmdexit_Click(cmdexit, New System.EventArgs)
            Case 120 'f9
                'UPGRADE_WARNING: Couldn't resolve default property of object SSTab1.Tab. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SSTab1.Tab = 0
            Case 121 'f10
                'UPGRADE_WARNING: Couldn't resolve default property of object SSTab1.Tab. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SSTab1.Tab = 1

        End Select
e5:
    End Sub
    Private Sub mh5_KeyPressEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh5.KeyPress
        Dim tmpcod As Object
        Dim mkeyascii As Integer
        mkeyascii = Asc(e.KeyChar)
        If e.KeyChar = "32" Or (mkeyascii >= 40 And mkeyascii <= 133) Or (mkeyascii >= 159 And mkeyascii <= 159) Or (mkeyascii >= 161 And mkeyascii <= 162) Or (mkeyascii >= 191 And mkeyascii <= 237) Or (mkeyascii >= 138 And mkeyascii <= 156) Then
            If Len(mh5.GetData(mh5.Row, mh5.Col)) > 0 Then
                If Mid(mh5.GetData(mh5.Row, mh5.Col), Len(mh5.GetData(mh5.Row, mh5.Col)), 1) = "|" Then
                    mh5.SetData(mh5.Row, mh5.Col, Mid(mh5.GetData(mh5.Row, mh5.Col), 1, Len(mh5.GetData(mh5.Row, mh5.Col)) - 1))
                End If
            End If
            mh5.SetData(mh5.Row, mh5.Col, mh5.GetData(mh5.Row, mh5.Col) & Chr(mkeyascii))
        End If
        If mkeyascii = 8 And mh5.GetData(mh5.Row, mh5.Col) <> "" Then
            If Mid(mh5.GetData(mh5.Row, mh5.Col), Len(mh5.GetData(mh5.Row, mh5.Col)), 1) = "|" Then
                mh5.SetData(mh5.Row, mh5.Col, Mid(mh5.GetData(mh5.Row, mh5.Col), 1, Len(mh5.GetData(mh5.Row, mh5.Col)) - 1))
            End If
            If mh5.GetData(mh5.Row, mh5.Col) <> "" Then
                mh5.SetData(mh5.Row, mh5.Col, Mid(mh5.GetData(mh5.Row, mh5.Col), 1, Len(mh5.GetData(mh5.Row, mh5.Col)) - 1))
            End If
        End If
        If mkeyascii = 13 Then
            If Len(mh5.GetData(mh5.Row, mh5.Col)) > 0 Then
                If Mid(mh5.GetData(mh5.Row, mh5.Col), Len(mh5.GetData(mh5.Row, mh5.Col)), 1) = "|" Then
                    mh5.SetData(mh5.Row, mh5.Col, Mid(mh5.GetData(mh5.Row, mh5.Col), 1, Len(mh5.GetData(mh5.Row, mh5.Col)) - 1))
                End If
            End If
            If mh5.Col < 3 Then
                mh5.Col = mh5.Col + 1
            Else
                mh5.Col = 0
                If mh5.Row < mh5.Rows.Count - 1 Then
                    mh5.Row = mh5.Row + 1
                Else
                    mh5.Rows.Count = mh5.Rows.Count + 1
                    mh5.Row = mh5.Row + 1

                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh5.GetData(mh5.Row, 0))
            If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
            de1.findcath(tmpcod)
            If de1.rsfindcath.EOF = False Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then mh5.SetData(mh5.Row, 1, de1.rsfindcath.Fields("Name").Value)

            Else

            End If
            de1.rsfindcath.Close()

        End If

    End Sub
    '------------------------------------------------------------------------

    Private Sub mh6_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        Dim SSTab1 As Object
        Dim mh6 As Object
        Select Case KeyCode
            Case 32 'blank

            Case 46 ' delete
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.TextMatrix(mh6.Row, mh6.Col) = ""
            Case 112 'f1
                If cmdlist.Enabled = True Then cmdlist_Click(cmdlist, New System.EventArgs)
            Case 115
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.TextMatrix(mh6.Row, 0) = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.TextMatrix(mh6.Row, 1) = ""

            Case 113 'f2
                Cmdsave_Click(Cmdsave, New System.EventArgs)
            Case 117 'f4
                cmdexit_Click(cmdexit, New System.EventArgs)
            Case 120 'f9
                'UPGRADE_WARNING: Couldn't resolve default property of object SSTab1.Tab. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SSTab1.Tab = 0
            Case 121 'f10
                'UPGRADE_WARNING: Couldn't resolve default property of object SSTab1.Tab. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SSTab1.Tab = 1

        End Select
    End Sub
    Private Sub mh6_KeyPress(ByRef KeyAscii As Short)
        Dim tmpcod As Object
        Dim mh6 As Object
        If KeyAscii = 32 Or (KeyAscii >= 40 And KeyAscii <= 133) Or (KeyAscii >= 159 And KeyAscii <= 159) Or (KeyAscii >= 161 And KeyAscii <= 162) Or (KeyAscii >= 191 And KeyAscii <= 237) Or (KeyAscii >= 138 And KeyAscii <= 156) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Len(mh6.TextMatrix(mh6.Row, mh6.Col)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Mid(mh6.TextMatrix(mh6.Row, mh6.Col), Len(mh6.TextMatrix(mh6.Row, mh6.Col)), 1) = "|" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh6.TextMatrix(mh6.Row, mh6.Col) = Mid(mh6.TextMatrix(mh6.Row, mh6.Col), 1, Len(mh6.TextMatrix(mh6.Row, mh6.Col)) - 1)
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh6.TextMatrix(mh6.Row, mh6.Col) = mh6.TextMatrix(mh6.Row, mh6.Col) + Chr(KeyAscii)
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If KeyAscii = 8 And mh6.TextMatrix(mh6.Row, mh6.Col) <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Mid(mh6.TextMatrix(mh6.Row, mh6.Col), Len(mh6.TextMatrix(mh6.Row, mh6.Col)), 1) = "|" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.TextMatrix(mh6.Row, mh6.Col) = Mid(mh6.TextMatrix(mh6.Row, mh6.Col), 1, Len(mh6.TextMatrix(mh6.Row, mh6.Col)) - 1)
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh6.TextMatrix(mh6.Row, mh6.Col) <> "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.TextMatrix(mh6.Row, mh6.Col) = Mid(mh6.TextMatrix(mh6.Row, mh6.Col), 1, Len(mh6.TextMatrix(mh6.Row, mh6.Col)) - 1)
            End If
        End If
        If KeyAscii = 13 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Len(mh6.TextMatrix(mh6.Row, mh6.Col)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Mid(mh6.TextMatrix(mh6.Row, mh6.Col), Len(mh6.TextMatrix(mh6.Row, mh6.Col)), 1) = "|" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh6.TextMatrix(mh6.Row, mh6.Col) = Mid(mh6.TextMatrix(mh6.Row, mh6.Col), 1, Len(mh6.TextMatrix(mh6.Row, mh6.Col)) - 1)
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh6.Col < 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.Col = mh6.Col + 1
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh6.Col = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If mh6.Row < mh6.Rows - 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh6.Row = mh6.Row + 1
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh6.Rows = mh6.Rows + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh6.Row = mh6.Row + 1

                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh6.TextMatrix(mh6.Row, 0))
            If de1.rsfindbdtakh.State <> 0 Then de1.rsfindbdtakh.Close()
            de1.findbdtakh(tmpcod)
            If de1.rsfindbdtakh.EOF = False Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh6.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Not IsDbNull(de1.rsfindbdtakh.Fields("tkhs_Name").Value) Then mh6.TextMatrix(mh6.Row, 1) = de1.rsfindbdtakh.Fields("tkhs_Name").Value
                de1.rsfindbdtakh.Close()

            Else

            End If


        End If
        '
    End Sub



    Private Sub txtazdate_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtcode_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcode.Enter
        txtcode.BackColor = lblcolor.BackColor
        txtcode.SelectionStart = 0
        txtcode.SelectionLength = Len(txtcode.Text)

    End Sub

    Private Sub txtcode_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcode.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Dim isch As Object
        Dim vt As Object
        Dim mm As Object
        If KeyAscii = 13 Then GoTo EventExitSub
        'UPGRADE_WARNING: Couldn't resolve default property of object mm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mm = Chr(KeyAscii)
        'UPGRADE_WARNING: Couldn't resolve default property of object vt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vt = IsNumeric(mm)
        'UPGRADE_WARNING: Couldn't resolve default property of object mm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object vt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If mm = "" Then vt = True
        'UPGRADE_WARNING: Couldn't resolve default property of object mm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object isch. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        isch = Trim(mm)
        'UPGRADE_WARNING: Couldn't resolve default property of object isch. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object vt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If vt = False And isch <> "" Then
            showlist((mm))
        End If

EventExitSub:
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcode5_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcode5.Enter
        txtcode5.BackColor = lblcolor.BackColor
    End Sub

    Private Sub txtcode5_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode5.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub



    Private Sub txtdaro_paynew_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtintercode_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtcode5_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcode5.Leave
        txtcode5.BackColor = lblcolor1.BackColor
    End Sub

    Private Sub txtdaro_fname_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdaro_fname.Leave
        txtdaro_fname.BackColor = lblcolor1.BackColor
    End Sub

    Private Sub txtdaro_pay_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdaro_pay.Enter
        txtdaro_pay.BackColor = lblcolor.BackColor
    End Sub

    Private Sub txtdaro_pay_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdaro_pay.Leave
        txtdaro_pay.BackColor = lblcolor1.BackColor
    End Sub

    'UPGRADE_WARNING: Event txtproc.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtproc_TextChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtproc.TextChanged

        Select Case Val(txtproc.Text)
            Case 1
                txtcode_Leave(txtcode, New System.EventArgs)
                txtproc.Text = CStr(0)

            Case 2
                cmdfindcode5_Click(cmdfindcode5, New System.EventArgs)
        End Select
        txtproc.Text = CStr(0)
    End Sub


    Private Sub txttkhs_code_Change()
        txttkhs_code_LostFocus()
    End Sub

    Private Sub txttkhs_code_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txttkhs_code_LostFocus()
        Dim txttkhs_name As Object
        Dim txttkhs_code As Object
        If de1.rsfindbdtakh.State <> 0 Then de1.rsfindbdtakh.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object txttkhs_code.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        de1.findbdtakh(txttkhs_code.Text)
        If de1.rsfindbdtakh.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object txttkhs_name.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDbNull(de1.rsfindbdtakh.Fields("tkhs_Name").Value) Then txttkhs_name.Text = de1.rsfindbdtakh.Fields("tkhs_Name").Value
        End If
        de1.rsfindbdtakh.Close()

    End Sub

    Private Sub clsgrid5()
        mh5.Rows.Count = 2
        mh5.Cols.Count = 4
        mh5.Clear()
        mh5.Cols(0).Width = 50
        mh5.Cols(1).Width = 230
        mh5.Cols(2).Width = 100
        mh5.Cols(3).Width = 100
        '-----------------------------------------------------------------------
        mh5.SetData(0, 0, " کد  ")
        mh5.SetData(0, 1, "نام ")
        '---------------------------
        mh5.SetData(0, 2, " قیمت ")
        mh5.SetData(0, 3, " درصد سهم بیمه")
    End Sub




    Private Sub Check1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub chkbimeh_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    'UPGRADE_WARNING: Event chkham.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'

    Private Sub chkhsp_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub chkmot_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub


    Private Sub cmddel_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        Dim a As Object
        Dim msg As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "برای حذف مطمئن هستید؟"
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = 7
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox(msg, MsgBoxStyle.YesNo)
        If a = MsgBoxResult.Yes Then
            If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
            de1.darocode((txtcode.Text))
            If de1.rsdarocode.RecordCount > 0 Then
                de1.rsdarocode.Delete()
                de1.rsdarocode.Update()
            End If
            de1.rsdarocode.Close()

            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = " حذف گردید"
            MsgBox(msg, MsgBoxStyle.Information)

        End If
        cmdloop_Click(cmdloop, New System.EventArgs)

    End Sub

    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub




    Private Sub cmdlist_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        frmxlist.txtproc.Text = CStr(3)
        frmxlist.Show()
    End Sub
    'UPGRADE_NOTE: Name was upgraded to Name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Addcbo(ByRef cbo As System.Windows.Forms.ComboBox, ByRef Name_Renamed As String, ByRef Index As Short)
        cbo.Items.Add(Name_Renamed) ' Add the name of the item to the combo box
        'UPGRADE_ISSUE: ComboBox property index was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
        VB6.SetItemData(cbo, Index, Index) ' Set the .itemdata(.listindex) for later retrieval
    End Sub
    Private Sub cmdloop_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdloop.Click
        txtcode.Text = ""
        txtdaro_pay.Text = ""

        txtdaro_fname.Text = ""

        txtvcode.Text = ""
        clsgrid5()

        chkden.CheckState = System.Windows.Forms.CheckState.Unchecked
        txtcode5.Text = ""

        txtcode.Focus()

    End Sub

    Private Sub Cmdsave_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim tmpcod As Object
        Dim i As Object
        Dim u As Object
        Dim msg As Object
        If Len(Trim(txtcode.Text)) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "کد دارو را وارد نمایید"
            MsgBox(msg, MsgBoxStyle.Information)
            Exit Sub
        End If
        If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
        de1.darocode((txtcode.Text))
        If de1.rsdarocode.RecordCount = 0 Then
            de1.rsdarocode.AddNew()
        End If
        de1.rsdarocode.Fields("daro_code").Value = txtcode.Text


        de1.rsdarocode.Fields("daro_fname").Value = txtdaro_fname.Text
        de1.rsdarocode.Fields("daro_pay").Value = Val(txtdaro_pay.Text)
        de1.rsdarocode.Fields("doc").Value = 1
        de1.rsdarocode.Fields("den").Value = chkden.CheckState
        de1.rsdarocode.Fields("code5").Value = txtcode5.Text
        If opttip0.Checked = True Then
            de1.rsdarocode.Fields("tip").Value = 0
        Else
            de1.rsdarocode.Fields("tip").Value = 1
        End If
        de1.rsdarocode.Fields("formcode").Value = cbosex.SelectedIndex
        de1.rsdarocode.Update()
        de1.rsdarocode.Close()
        '-------------------------------------------------'
        If de1.rsbrow_ham.State <> 0 Then de1.rsbrow_ham.Close()
        de1.brow_ham((txtcode.Text))
        Do While de1.rsbrow_ham.EOF = False
            de1.rsbrow_ham.Delete()
            de1.rsbrow_ham.Update()
            de1.rsbrow_ham.MoveNext()
        Loop
        '-----------------------------------------------------------------

        If de1.rslistdarocond.State <> 0 Then de1.rslistdarocond.Close()
        de1.listdarocond("delete from daro_cond where daro_code='" & txtcode.Text & "' ")

        '-------------------------------------------------'
        If de1.rsbrowcond.State <> 0 Then de1.rsbrowcond.Close()
        de1.browcond((txtcode.Text))

        '-----------------------------------------------------------------
        For i = 1 To mh5.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh5.GetData(i, 0))

            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcod > 0 Then
                de1.rsbrowcond.AddNew()
                de1.rsbrowcond.Fields("daro_code").Value = txtcode.Text

                de1.rsbrowcond.Fields("cath").Value = Val(mh5.GetData(i, 0))

                de1.rsbrowcond.Fields("bimeh_pay").Value = Val(mh5.GetData(i, 2))
                de1.rsbrowcond.Fields("mot").Value = Val(mh5.GetData(i, 3))
                de1.rsbrowcond.Update()
            End If

        Next i
        de1.rsbrowcond.Close()
        '----------------------------------------------------------------



        'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msg = "ثبت گردید"
        MsgBox(msg, MsgBoxStyle.Information)
        cmdloop_Click(cmdloop, New System.EventArgs)
    End Sub


    Private Sub hotkey(ByRef KeyCode As Short)
        Select Case KeyCode
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 113 'f2
                Cmdsave_Click(Cmdsave, New System.EventArgs)
            Case 115
                cmdexit_Click(cmdexit, New System.EventArgs)
            Case 112 'f1
                If cmdlist.Enabled = True Then cmdlist_Click(cmdlist, New System.EventArgs)
            Case 27 'esc
                cmdexit_Click(cmdexit, New System.EventArgs)
        End Select
    End Sub




    Private Sub frmdcode_Load(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsgrid5()
        Showsex()


    End Sub

    Private Sub mh1_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        Dim cod_cres As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cod_cres. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cod_cres = 1
    End Sub

    Private Sub mh2_GotFocus()
        Dim cod_cres As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cod_cres. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cod_cres = 1
    End Sub
    Private Sub mh2_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        Dim mh2 As Object
        Select Case KeyCode
            Case 32 'blank

            Case 46 ' delete
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, mh2.Col) = ""


            Case 112 'f1
                If cmdlist.Enabled = True Then cmdlist_Click(cmdlist, New System.EventArgs)
            Case 115
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, 0) = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, 1) = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, 2) = ""
            Case 113 'f2
                Cmdsave_Click(Cmdsave, New System.EventArgs)
            Case 117 'f4
                cmdexit_Click(cmdexit, New System.EventArgs)
            Case 116 'f5
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Val(mh2.TextMatrix(mh2.Row, 0)) > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Me.txtcode.Text = mh2.TextMatrix(mh2.Row, 0)
                End If
                Me.Show()


        End Select
        ' hotkey KeyCode
    End Sub
    Private Sub mh2_KeyPress(ByRef KeyAscii As Short)
        Dim tmpcokm As Object
        Dim way As Object
        Dim mh2 As Object
        If KeyAscii = 32 Or (KeyAscii >= 40 And KeyAscii <= 133) Or (KeyAscii >= 159 And KeyAscii <= 159) Or (KeyAscii >= 161 And KeyAscii <= 162) Or (KeyAscii >= 191 And KeyAscii <= 237) Or (KeyAscii >= 138 And KeyAscii <= 156) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Len(mh2.TextMatrix(mh2.Row, mh2.Col)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Mid(mh2.TextMatrix(mh2.Row, mh2.Col), Len(mh2.TextMatrix(mh2.Row, mh2.Col)), 1) = "|" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh2.TextMatrix(mh2.Row, mh2.Col) = Mid(mh2.TextMatrix(mh2.Row, mh2.Col), 1, Len(mh2.TextMatrix(mh2.Row, mh2.Col)) - 1)
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh2.TextMatrix(mh2.Row, mh2.Col) = mh2.TextMatrix(mh2.Row, mh2.Col) + Chr(KeyAscii)
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If KeyAscii = 8 And mh2.TextMatrix(mh2.Row, mh2.Col) <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Mid(mh2.TextMatrix(mh2.Row, mh2.Col), Len(mh2.TextMatrix(mh2.Row, mh2.Col)), 1) = "|" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, mh2.Col) = Mid(mh2.TextMatrix(mh2.Row, mh2.Col), 1, Len(mh2.TextMatrix(mh2.Row, mh2.Col)) - 1)
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh2.TextMatrix(mh2.Row, mh2.Col) <> "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.TextMatrix(mh2.Row, mh2.Col) = Mid(mh2.TextMatrix(mh2.Row, mh2.Col), 1, Len(mh2.TextMatrix(mh2.Row, mh2.Col)) - 1)
            End If
        End If
        If KeyAscii = 13 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object way. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            way = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcokm = mh2.TextMatrix(mh2.Row, 0)
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh2.Col = 0 And Val(tmpcokm) = 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.Col = 1
                'cboamal.Visible = True
                '
                'UPGRADE_WARNING: Couldn't resolve default property of object way. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                way = 1
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh2.Col < 2 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.Col = mh2.Col + 1
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh2.Col = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If mh2.Row < mh2.Rows - 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh2.Row = mh2.Row + 1
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh2.Rows = mh2.Rows + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh2.Row = mh2.Row + 1
                End If
            End If
            '------------------------------------------------------------
            'UPGRADE_WARNING: Couldn't resolve default property of object way. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If way = 0 Then

                '   cbodarof.Visible = False
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpcokm = mh2.TextMatrix(mh2.Row, 0)
                If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
                de1.darocode(tmpcokm)
                If de1.rsdarocode.RecordCount <> 0 Then
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Not IsDbNull(de1.rsdarocode.Fields("daro_name").Value) Then mh2.TextMatrix(mh2.Row, 1) = de1.rsdarocode.Fields("daro_name").Value

                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Val(mh2.TextMatrix(mh2.Row, 0)) > 0 Then mh2.TextMatrix(mh2.Row, 1) = "ßÏ  ÇÔÊÈÇå ÇÓÊ ....."
                End If

                'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If mh2.Col = 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh2.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh2.Col = 2
                End If

                '  *********************************************
            End If
        End If
    End Sub




    Private Sub optsold_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optsold.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Dim Index As Short = optsold.GetIndex(eventSender)
        hotkey(KeyCode)
    End Sub

    Private Sub Opttip_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opttip.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Dim Index As Short = opttip.GetIndex(eventSender)
        hotkey(KeyCode)
    End Sub


    Private Sub txtbimeh_pay_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub


    Private Sub txtcomment_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtdaro_doze_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtdaro_fname_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdaro_fname.Enter
        txtdaro_fname.BackColor = lblcolor.BackColor
        keybfarsi()
    End Sub

    Private Sub txtdaro_fname_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdaro_fname.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtdaro_form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtcode_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtcode_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcode.Leave
        On Error Resume Next
        Dim tmpformcode As Object
        Dim tmptipsold As Object
        Dim tmptip As Object
        Dim tmpfani As Object
        txtcode.BackColor = lblcolor1.BackColor
        '-------------------------------------------------------
        txtdaro_pay.Text = ""
        cbosex.SelectedIndex = 0
        txtvcode.Text = ""
        txtdaro_fname.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpfani. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpfani = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmptip = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptipsold. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmptipsold = 0


        'UPGRADE_WARNING: Couldn't resolve default property of object tmpformcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpformcode = 0
        txtcode5.Text = ""

        clsgrid5()
        If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
        de1.darocode((txtcode.Text))
        If de1.rsdarocode.RecordCount <> 0 Then





            If Not IsDBNull(de1.rsdarocode.Fields("formcode").Value) Then tmpformcode = de1.rsdarocode.Fields("formcode").Value
            cbosex.SelectedIndex = tmpformcode

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsdarocode.Fields("daro_fname").Value) Then txtdaro_fname.Text = de1.rsdarocode.Fields("daro_fname").Value


            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsdarocode.Fields("daro_pay").Value) Then txtdaro_pay.Text = de1.rsdarocode.Fields("daro_pay").Value




            If Not IsDBNull(de1.rsdarocode.Fields("den").Value) Then chkden.CheckState = Val(de1.rsdarocode.Fields("den").Value)
            If Not IsDBNull(de1.rsdarocode.Fields("tip").Value) Then tmptip = de1.rsdarocode.Fields("tip").Value
            If tmptip = 0 Then
                opttip0.Checked = True
            End If
            If Not IsDBNull(de1.rsdarocode.Fields("tipsold").Value) Then tmptipsold = de1.rsdarocode.Fields("tipsold").Value
            If Not IsDBNull(de1.rsdarocode.Fields("code5").Value) Then txtcode5.Text = de1.rsdarocode.Fields("code5").Value

            findvcode1()


            fillgrid5()
        End If


    End Sub

    Private Sub mh3_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        Dim mh3 As Object
        Select Case KeyCode
            Case 13 'enter
            Case 46 ' delete
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.TextMatrix(mh3.Row, mh3.Col) = ""
        End Select
    End Sub
    Private Sub mh3_KeyPress(ByRef KeyAscii As Short)
        Dim mh3 As Object
        If KeyAscii = 32 Or (KeyAscii >= 40 And KeyAscii <= 133) Or (KeyAscii >= 159 And KeyAscii <= 159) Or (KeyAscii >= 161 And KeyAscii <= 162) Or (KeyAscii >= 191 And KeyAscii <= 237) Or (KeyAscii >= 138 And KeyAscii <= 156) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Len(mh3.TextMatrix(mh3.Row, mh3.Col)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Mid(mh3.TextMatrix(mh3.Row, mh3.Col), Len(mh3.TextMatrix(mh3.Row, mh3.Col)), 1) = "|" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh3.TextMatrix(mh3.Row, mh3.Col) = Mid(mh3.TextMatrix(mh3.Row, mh3.Col), 1, Len(mh3.TextMatrix(mh3.Row, mh3.Col)) - 1)
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh3.TextMatrix(mh3.Row, mh3.Col) = mh3.TextMatrix(mh3.Row, mh3.Col) + Chr(KeyAscii)
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If KeyAscii = 8 And mh3.TextMatrix(mh3.Row, mh3.Col) <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Mid(mh3.TextMatrix(mh3.Row, mh3.Col), Len(mh3.TextMatrix(mh3.Row, mh3.Col)), 1) = "|" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.TextMatrix(mh3.Row, mh3.Col) = Mid(mh3.TextMatrix(mh3.Row, mh3.Col), 1, Len(mh3.TextMatrix(mh3.Row, mh3.Col)) - 1)
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh3.TextMatrix(mh3.Row, mh3.Col) <> "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.TextMatrix(mh3.Row, mh3.Col) = Mid(mh3.TextMatrix(mh3.Row, mh3.Col), 1, Len(mh3.TextMatrix(mh3.Row, mh3.Col)) - 1)
            End If
        End If
        If KeyAscii = 13 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Len(mh3.TextMatrix(mh3.Row, mh3.Col)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Mid(mh3.TextMatrix(mh3.Row, mh3.Col), Len(mh3.TextMatrix(mh3.Row, mh3.Col)), 1) = "|" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh3.TextMatrix(mh3.Row, mh3.Col) = Mid(mh3.TextMatrix(mh3.Row, mh3.Col), 1, Len(mh3.TextMatrix(mh3.Row, mh3.Col)) - 1)
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mh3.Col < 3 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.Col = mh3.Col + 1
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.Col = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If mh3.Row < mh3.Rows - 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh3.Row = mh3.Row + 1
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh3.Rows = mh3.Rows + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh3.Row = mh3.Row + 1

                End If
            End If


        End If
    End Sub
    Private Sub mh3_LostFocus()
        Dim cod_cres As Object
        Dim mh3 As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Len(mh3.TextMatrix(mh3.Row, mh3.Col)) > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Mid(mh3.TextMatrix(mh3.Row, mh3.Col), Len(mh3.TextMatrix(mh3.Row, mh3.Col)), 1) = "|" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object mh3.TextMatrix. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh3.TextMatrix(mh3.Row, mh3.Col) = Mid(mh3.TextMatrix(mh3.Row, mh3.Col), 1, Len(mh3.TextMatrix(mh3.Row, mh3.Col)) - 1)
            End If
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object cod_cres. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cod_cres = 0

    End Sub



    Private Sub fillgrid5()
        Dim tmpcod As Object
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If de1.rsbrowcond.State <> 0 Then de1.rsbrowcond.Close()
        de1.browcond((txtcode.Text))
        Dim i As Short
        i = 1
        clsgrid5()
        If de1.rsbrowcond.RecordCount = 0 Then


        Else
            Do While de1.rsbrowcond.EOF = False
                mh5.Rows.Count = mh5.Rows.Count + 1
                If Not IsDBNull(de1.rsbrowcond.Fields("cath").Value) Then mh5.SetData(i, 0, de1.rsbrowcond.Fields("cath").Value)
                tmpcod = Val(mh5.GetData(i, 0))
                If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
                de1.findcath(tmpcod)
                If de1.rsfindcath.EOF = False Then
                    If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then mh5.SetData(i, 1, de1.rsfindcath.Fields("Name").Value)
                End If
                If Not IsDBNull(de1.rsbrowcond.Fields("bimeh_pay").Value) Then mh5.SetData(i, 2, de1.rsbrowcond.Fields("bimeh_pay").Value)

                If Not IsDBNull(de1.rsbrowcond.Fields("mot").Value) Then mh5.SetData(i, 3, de1.rsbrowcond.Fields("mot").Value)
                de1.rsbrowcond.MoveNext()
                i = i + 1
            Loop
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub





    Private Sub txtdaro_name_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub


    Private Sub txtdaro_pay_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdaro_pay.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub

    Private Sub txtdate_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtmasraf_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txttolid_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub



    Private Sub upd1_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles upd1.Click
        Dim i As Object
        For i = 1 To mh5.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(mh5.GetData(i, 0)) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mh5.SetData(i, 2, Val(txtdaro_pay.Text))


            End If
        Next i

    End Sub

    Private Sub upd2_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles upd2.Click
        Dim tmpName As Object
        Dim tmpcath As Object
        Dim i As Object
        If de1.rslistcath.State <> 0 Then de1.rslistcath.Close()
        de1.listcath()
        clsgrid5()
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        i = 1
        Do While de1.rslistcath.EOF = False
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcath = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpName = ""
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rslistcath.Fields("Name").Value) Then tmpName = de1.rslistcath.Fields("Name").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rslistcath.Fields("cath").Value) Then tmpcath = de1.rslistcath.Fields("cath").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcath = 0 Then GoTo qq
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcath = Val(frmtanzim.txtfreecath.Text) Then GoTo qq
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh5.SetData(i, 0, tmpcath)
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh5.SetData(i, 1, tmpName)
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh5.SetData(i, 2, Val(txtdaro_pay.Text))
            mh5.Rows.Count = mh5.Rows.Count + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            i = i + 1
qq:
            de1.rslistcath.MoveNext()
        Loop
        de1.rslistcath.Close()
    End Sub
    Private Sub Showsex()
        ' Counter
        Dim m1 As String
        For mm = 0 To 18
            m1 = ""
            Select Case mm
                Case 0
                    m1 = ""
                Case 1
                    m1 = ""
                Case 2
                    m1 = ""

                Case 3
                    m1 = "تعداد بیرون درآوردن دندان قدامی"
                Case 4
                    m1 = " تعداد بیرون درآوردن دندان خلفی"
                Case 5
                    m1 = "   تعداد بیرون درآوردن دندان عقل"
                Case 6
                    m1 = "تعداد بیرون درآوردن دندان نهفته نسخ نرم"
                Case 7
                    m1 = "تعداد بیرون درآوردن دندان نهفته نسج سخت"
                Case 8
                    m1 = "تعداد جرم گیری بالای لثه هرفک˜"
                Case 9
                    m1 = "تعداد جرم گیری پایین لثه هرفک˜"
                Case 10
                    m1 = "تعداد بروساژ فک˜"
                Case 11
                    m1 = "ترمیم یک سطحی"
                Case 12
                    m1 = "ترمیم دوسطحی"
                Case 13
                    m1 = "ترمیم سه سطحی"
                Case 14
                    m1 = "رادیوگرافی"
                Case 15
                    m1 = "فیشورسیلانت دندان"
                Case 16
                    m1 = "پروفیلاکسی و فلوراید تراپی هرفک"
                Case 17
                    m1 = "وارنیش فلوراید دوفک"
                Case 18
                    m1 = "آموزش بهداشت"


            End Select






            cbosex.Items.Add(m1)
        Next mm
        cbosex.SelectedIndex = 0

    End Sub

    Private Sub cmdRemoveVirtual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveVirtual.Click
        If txtcode.Text = "" Then
            MsgBox("کد دارو مشخص نمیباشد", vbCritical)
            Exit Sub
        End If
        Dim sql As String
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        sql = "delete * from vcode where tip=0 and daro_code='" + txtcode.Text + "' "
        de1.browall(sql)
        MsgBox("کد مجازی برای این دارو غیر فعال شد", vbInformation)
        txtvcode.Text = ""
        Exit Sub

    End Sub

    Private Sub cmdaddVirtual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddVirtual.Click
        If de1.rsfindvcode.State <> 0 Then de1.rsfindvcode.Close()
        de1.findvcode(txtvcode.Text, 0)

        Dim t1 As String
        t1 = ""
        If de1.rsfindvcode.EOF = False Then
            If Not IsDBNull(de1.rsfindvcode.Fields("daro_code").Value) Then t1 = de1.rsfindvcode.Fields("daro_code").Value
            If t1 <> "" And t1 <> txtcode.Text Then
                MsgBox("  " + t1 + "این کد قبلا برای این دارو منظور شده است", vbCritical)
                txtvcode.Text = ""
                Exit Sub
            Else
                MsgBox("  " + t1 + "این کد دارای کد مجازی میباشد" + txtcode.Text, vbCritical)
            End If
            '---------------------------------
        Else
            de1.rsfindvcode.AddNew()
            de1.rsfindvcode.Fields("daro_code").Value = txtcode.Text
            de1.rsfindvcode.Fields("vcode").Value = txtvcode.Text
            de1.rsfindvcode.Fields("tip").Value = 0
            de1.rsfindvcode.Update()
            MsgBox("کد مجازی ثبت شد", vbInformation)
        End If

    End Sub

    Private Sub txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

    End Sub

    
    
End Class