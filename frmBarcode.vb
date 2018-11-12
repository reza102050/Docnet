Option Strict Off
Option Explicit On
Friend Class frmBarcode
	Inherits System.Windows.Forms.Form
	
	Private Sub clsgrid4()
		
        mh4.Cols.Count = 2
		mh4.Clear()
        mh4.Rows.Count = 2
		'UPGRADE_NOTE: RightToLeft was upgraded to CtlRightToLeft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        ' mh4.CtlRightToLeft = True

        mh4.Cols(1).Width = 80
        mh4.Cols(0).Width = 350
        mh4.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
        mh4.Cols(0).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom

		
        mh4.SetData(0, 0, "ÈÇÑßÏ")
        mh4.Rows.Fixed = 1

    End Sub

    Private Sub cmdexit_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    'UPGRADE_WARNING: Form event frmBarcode.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmBarcode_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        mh4.Focus()
    End Sub

    Private Sub mh4_KeyPressEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh4.KeyPress
        Dim RowsSel As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object RowsSel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        RowsSel = mh4.Row
        Dim mKeyascii As Integer
        mKeyascii = Asc(e.KeyChar)
        If mKeyascii = 32 Or (mKeyascii >= 40 And mKeyascii <= 133) Or (mKeyascii >= 159 And mKeyascii <= 159) Or (mKeyascii >= 161 And mKeyascii <= 162) Or (mKeyascii >= 191 And mKeyascii <= 237) Or (mKeyascii >= 138 And mKeyascii <= 156) Then
            If Len(mh4.GetData(mh4.Row, mh4.Col)) > 0 Then
                If Mid(mh4.GetData(mh4.Row, mh4.Col), Len(mh4.GetData(mh4.Row, mh4.Col)), 1) = "|" Then
                    mh4.SetData(mh4.Row, mh4.Col, Mid(mh4.GetData(mh4.Row, mh4.Col), 1, Len(mh4.GetData(mh4.Row, mh4.Col)) - 1))
                End If
            End If
            mh4.SetData(mh4.Row, mh4.Col, mh4.GetData(mh4.Row, mh4.Col) & Chr(mKeyascii))
        End If
        If mKeyascii = 8 And mh4.GetData(mh4.Row, mh4.Col) <> "" Then
            If Mid(mh4.GetData(mh4.Row, mh4.Col), Len(mh4.GetData(mh4.Row, mh4.Col)), 1) = "|" Then
                mh4.SetData(mh4.Row, mh4.Col, Mid(mh4.GetData(mh4.Row, mh4.Col), 1, Len(mh4.GetData(mh4.Row, mh4.Col)) - 1))
            End If
            If mh4.GetData(mh4.Row, mh4.Col) <> "" Then
                mh4.SetData(mh4.Row, mh4.Col, Mid(mh4.GetData(mh4.Row, mh4.Col), 1, Len(mh4.GetData(mh4.Row, mh4.Col)) - 1))
            End If
        End If
        '------------------------------------------------
        If mKeyascii = 13 Then
            If Len(mh4.GetData(mh4.Row, mh4.Col)) > 0 Then
                If Mid(mh4.GetData(mh4.Row, mh4.Col), Len(mh4.GetData(mh4.Row, mh4.Col)), 1) = "|" Then
                    mh4.SetData(mh4.Row, mh4.Col, Mid(mh4.GetData(mh4.Row, mh4.Col), 1, Len(mh4.GetData(mh4.Row, mh4.Col)) - 1))
                End If
            End If
            mh4.Col = 0
            If mh4.Row < mh4.Rows.Count - 1 Then
                mh4.Row = mh4.Row + 1
            Else
                mh4.Rows.Count = mh4.Rows.Count + 1
                If mh4.Row < mh4.Rows.Count - 1 Then
                    mh4.Row = mh4.Row + 1
                End If

            End If

        End If

    End Sub

    Private Sub fillgrid()
        If de1.rsBarCodeBrow.State <> 0 Then de1.rsBarCodeBrow.Close()
        de1.BarCodeBrow((txtcode.Text))
        Dim i As Short
        i = 1

        Do While de1.rsBarCodeBrow.EOF = False
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsBarCodeBrow.Fields("barcode").Value) Then mh4.SetData(i, 0, de1.rsBarCodeBrow.Fields("barcode").Value)

            de1.rsBarCodeBrow.MoveNext()
            If de1.rsBarCodeBrow.EOF = True Then GoTo D1
            mh4.Rows.Count = mh4.Rows.Count + 1
            i = i + 1
        Loop
D1:
        mh4.Rows.Count = mh4.Rows.Count + 1
        mh4.Row = mh4.Rows.Count - 1
        de1.rsBarCodeBrow.Close()

    End Sub

    Private Sub cmdsave_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsave.Click
        Dim tmpcod As Object
        Dim i As Object

        If de1.rsBarCodeDel.State <> 0 Then de1.rsBarCodeDel.Close()
        de1.BarCodeDel("delete from barcode where daro_code='" & txtcode.Text & "'")

        If de1.rsBarCodeBrow.State <> 0 Then de1.rsBarCodeBrow.Close()
        de1.BarCodeBrow((txtcode.Text))
        For i = 0 To mh4.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh4.GetData(i, 0))
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcod > 0 Then
                de1.rsBarCodeBrow.AddNew()
                de1.rsBarCodeBrow.Fields("daro_code").Value = txtcode.Text
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                de1.rsBarCodeBrow.Fields("barcode").Value = mh4.GetData(i, 0)
                de1.rsBarCodeBrow.Update()
            End If

        Next i
        de1.rsBarCodeBrow.Close()
        Me.Close()
    End Sub

    Private Sub cmdShow_Click()
        fillgrid()
    End Sub

    Private Sub frmBarcode_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'On Error Resume Next
        clsgrid4()

        'SendKeys "{TAB}"
    End Sub

    Private Sub mh4_KeyDownEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh4.KeyDown

        Dim pp As Object
        Dim kk As Object
        Dim ii As Object
        Select Case e.KeyCode
            Case 113 'f2
                cmdsave_ClickEvent(cmdsave, New System.EventArgs())
            Case 115 'f4
                On Error Resume Next
                'UPGRADE_WARNING: Couldn't resolve default property of object ii. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ii = mh4.Row

                'UPGRADE_WARNING: Couldn't resolve default property of object ii. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For kk = ii To mh4.Rows.Count - 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object pp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pp = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object pp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object kk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    mh4.SetData(kk, pp, mh4.GetData(kk + 1, pp))

                Next kk

                If mh4.Rows.Count > 1 Then
                    mh4.Rows.Count = mh4.Rows.Count - 1
                End If

            Case 46 ' delete
                mh4.SetData(mh4.Row, mh4.Col, "")
            Case 27 ' esc
                Me.Close()
        End Select
    End Sub
	
	'UPGRADE_WARNING: Event txtcode.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtcode_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcode.TextChanged
		fillgrid()
	End Sub
End Class