Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb


Friend Class frmdnos
    Inherits System.Windows.Forms.Form
    Dim isfound As Boolean
    Dim tmpshak As String
    Dim upcounter As Boolean
    Dim pay_inter As Integer
    Dim Nopay As Integer
    Dim tmpsal As Short
    Dim tmpmabna As Short
    Private Rs As ADODB.Recordset
    Private rsCopy As ADODB.Recordset

    Public SQL As String
    Dim sFile As String 'Filename of selected file    
    Dim report_file As String
    Public LastCath As String
    Public StrKey As String
    Dim tmpsex As Integer
    ' Dim MESHAMSI As New MEShamsiDate.ShamsiDate


    Sub PlaySound(ByVal tip As Short)
        On Error Resume Next
        'If ExcelGlobal_definst.Application.CanPlaySounds = False Then Exit Sub
        Select Case tip
            Case 1
                'Call sndPlaySound32(txtSoundRadif.Text, 0)
            Case 2
                'Call sndPlaySound32(txtSoundAlarm.Text, 0)
        End Select


    End Sub

    Private Sub getradiflist()
        Dim tmpradif As Object
        '******************************************
        If de1.rsfindradifpha.State <> 0 Then de1.rsfindradifpha.Close()
        de1.findradifpha(Val(txtmonth.Text), Val(txtCath.Text))
        If de1.rsfindradifpha.EOF = False Then
            de1.rsfindradifpha.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsfindradifpha.Fields("radif").Value + 1
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If IsDBNull(tmpradif) Then tmpradif = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtnomlist.Text = tmpradif
        Else
            txtnomlist.Text = CStr(1)
        End If
        de1.rsfindradifpha.Close()
    End Sub

    Private Sub clsgrid2()

        mh2.Rows.Count = 20
        mh2.Cols.Count = 2
        mh2.Clear()
        mh2.Rows.Count = 20
        mh2.Cols(0).Width = 150
        mh2.Cols(1).Width = 150
        mh2.SetData(0, 0, "قابل پرداخت")
        mh2.SetData(1, 0, "خارج تعهد")
        mh2.SetData(2, 0, "جمع نسخه  ")
        mh2.SetData(3, 0, "سهم بیمار")
        mh2.SetData(4, 0, "سهم سازمان")
        mh2.SetData(5, 0, " حق فنی")
        mh2.SetData(6, 0, "اضافه قیمت")
        mh2.SetData(7, 0, "حق ثبت ")
        mh2.SetData(8, 0, "ثبت کننده")
        mh2.SetData(9, 0, " ساعت")
        mh2.SetData(10, 0, "تاریخ")
        mh2.SetData(11, 0, "شماره")

        mh2.Cols(0).Width = 90
        mh2.Cols(1).Width = 100
        mh2.ScrollBars = ScrollBars.Vertical
        mh2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        mh2.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        mh2.Cols(0).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        mh2.Cols(1).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        mh2.Cols(0).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        mh2.Cols(1).Format = ("#,###")
    End Sub

    Private Sub showlist()
        Dim r2 As Object
        Dim r1 As Object
        Dim aaa As String
        aaa = Trim(mh1.GetData(mh1.Row, 2))
        If aaa = "*" Then Exit Sub
        MainForm.Mtip = 0
        frmxlist.mh6.SetData(1, 0, aaa)

        frmxlist.txtproc.Text = CStr(1)
        frmxlist.Show()
    End Sub

    Private Sub cboact_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboact.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub cboact_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cboact.Leave
        mh1.SetData(mh1.Row, 15, cboact.SelectedIndex)
        mh1.SetData(mh1.Row, 1, cboact.Text)
        cboact.Visible = False
        mh1.Col = 2
        mh1.Focus()
    End Sub

    Private Sub cmdcalcrep_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdcalcrep.Click
        Dim a As Object
        Dim tmpcod As Object
        Dim i As Object
        GetCath((Val(txtCath.Text)))
        For i = 1 To mh1.Rows.Count - 1
            tmpcod = Val(mh1.GetData(i, 2))
            mh1.Row = i
            a = sdaro(i)
            calcgrid()
        Next i
    End Sub

    Private Sub cmdclosefrmopt_Click()
        Dim frmopt As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object frmopt.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmopt.Visible = False
    End Sub



    Private Sub cmdCalculator_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculator.Click
        Dim aa As Object

        aa = Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmddel_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Dim krem As Double
        Dim tmpcokm As String
        Dim tmpnom As Double
        Dim a As Integer
        Dim msg As String

        msg = "برای حذف مطمئن هستید؟"
        a = 7
        a = MsgBox(msg, MsgBoxStyle.YesNo)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If a = MsgBoxResult.Yes Then
            If de1.rsbrow_phanumber.State <> 0 Then de1.rsbrow_phanumber.Close()
            de1.brow_phanumber(Val(txtmonth.Text), (txtradif.Text))
            If de1.rsbrow_phanumber.RecordCount > 0 Then
                de1.rsbrow_phanumber.Delete()
                de1.rsbrow_phanumber.Update()
            End If
            de1.rsbrow_phanumber.Close()
            '-----------------------------------------------------

            If de1.rsbrow_dnos.State <> 0 Then de1.rsbrow_dnos.Close()
            de1.brow_dnos(Val(txtmonth.Text), Val(txtradif.Text))
            Do While de1.rsbrow_dnos.EOF = False
                tmpnom = 0
                tmpcokm = ""
                If Not IsDBNull(de1.rsbrow_dnos.Fields("cokm").Value) Then tmpcokm = de1.rsbrow_dnos.Fields("cokm").Value
                If Not IsDBNull(de1.rsbrow_dnos.Fields("Nom").Value) Then tmpnom = de1.rsbrow_dnos.Fields("Nom").Value
                If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
                de1.darocode(tmpcokm)
                If de1.rsdarocode.RecordCount <> 0 Then

                    krem = 0
                    If Not IsDBNull(de1.rsdarocode.Fields("tremain").Value) Then krem = de1.rsdarocode.Fields("tremain").Value
                    de1.rsdarocode.Fields("tremain").Value = krem + tmpnom
                    de1.rsdarocode.Update()
                End If
                '---------------------------- update remain ...................................
                de1.rsbrow_dnos.Delete()
                de1.rsbrow_dnos.Update()
                de1.rsbrow_dnos.MoveNext()
            Loop
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            msg = "حذف گردید"
            MsgBox(msg, MsgBoxStyle.Information)
            clsNos()
        End If
    End Sub



    Private Sub cmddoc_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmddoc.Click
        frmdoc.Show()
    End Sub

    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub settextbox()
        Dim tact As Object
        Dim i As Object 'put textbox over cell
        Exit Sub
        With cboact
            '.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(mh1.Top) + mh1.Cols.CellTop)
            .Left = VB6.TwipsToPixelsX(9800)
            .Width = VB6.TwipsToPixelsX(1500)
            .Visible = True
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object tact. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tact = Val(mh1.GetData(i, 15))
        'UPGRADE_WARNING: Couldn't resolve default property of object tact. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If tact >= 0 And tact <= 7 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tact. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboact.SelectedIndex = tact
        Else
            cboact.SelectedIndex = 0
        End If
        cboact.Focus()

    End Sub
    Private Function FindCathRow(ByRef tmpcath As Short) As Short
        Dim tmpcod As Object
        Dim i As Object
        Dim trow As Object
        '-----------------------------------------------------------------
        'UPGRADE_WARNING: Couldn't resolve default property of object trow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        trow = 0
        For i = 0 To mh4.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpcod = Val(mh4.GetData(i, 0))
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpcod = tmpcath Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object trow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trow = i
                Exit For
            End If

        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object trow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FindCathRow = trow
    End Function
    Private Sub fillgrid()
        Dim ttp2 As Object
        Dim ttp1 As Object
        Dim tmpcokm As Object
        Dim tmpnom As Double
        Dim ttot As Object
        Dim torg As Object
        Dim tbimar As Object
        Dim tkol As Object
        Dim tpfani As Object
        Dim tfr As Object
        If de1.rsbrow_dnos.State <> 0 Then de1.rsbrow_dnos.Close()
        de1.brow_dnos(Val(txtmonth.Text), Val(txtradif.Text))
        Dim i As Short
        i = 1
        clsgrid()
        tfr = 0
        tpfani = 0
        tkol = 0
        tbimar = 0
        torg = 0
        ttot = 0
        Do While de1.rsbrow_dnos.EOF = False
            mh1.SetData(i, 0, i)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("tot").Value) Then mh1.SetData(i, 7, de1.rsbrow_dnos.Fields("tot").Value)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("org").Value) Then mh1.SetData(i, 11, de1.rsbrow_dnos.Fields("org").Value)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("bimar").Value) Then mh1.SetData(i, 10, de1.rsbrow_dnos.Fields("bimar").Value)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("pay").Value) Then mh1.SetData(i, 5, de1.rsbrow_dnos.Fields("pay").Value)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("paybimeh").Value) Then mh1.SetData(i, 6, de1.rsbrow_dnos.Fields("paybimeh").Value)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("daroPercent").Value) Then mh1.SetData(i, 20, de1.rsbrow_dnos.Fields("daroPercent").Value)
            '------------------------------
            tmpnom = 0
            If Not IsDBNull(de1.rsbrow_dnos.Fields("Nom").Value) Then tmpnom = de1.rsbrow_dnos.Fields("Nom").Value
            mh1.SetData(i, 4, tmpnom)
            If Not IsDBNull(de1.rsbrow_dnos.Fields("act").Value) Then mh1.SetData(i, 13, de1.rsbrow_dnos.Fields("act").Value)


            mh1.SetData(i, 9, Val(mh1.GetData(i, 4)) * Val(mh1.GetData(i, 6)))
            mh1.SetData(i, 12, Val(mh1.GetData(i, 7)) - Val(mh1.GetData(i, 9)))
            mh1.SetData(i, 1, VB6.GetItemString(cboact, Val(mh1.GetData(i, 13))))
            '-------------------------------------------------------------------
            If Not IsDBNull(de1.rsbrow_dnos.Fields("cokm").Value) Then tmpcokm = de1.rsbrow_dnos.Fields("cokm").Value
            mh1.SetData(i, 2, tmpcokm)
            '--------------------------------
            ' mh1.SetData(i, 18, tmpcokm)
            ' mh1.SetData(i, 19, tmpnom)
            '--------------------------------

            If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
            de1.darocode(tmpcokm)

            ' mh1.SetData(i, 15, tmpcokm)
            If de1.rsdarocode.RecordCount <> 0 Then


                If Not IsDBNull(de1.rsdarocode.Fields("daro_fname").Value) Then mh1.SetData(i, 3, de1.rsdarocode.Fields("daro_fname").Value)

            End If
           
            'ttp1 = mh1.GetData(i, 6)
            'ttp2 = mh1.GetData(i, 9)
            'mh1.SetData(i, 7, ttp1 - ttp2)
            'If Val(mh1.GetData(i, 7)) < 0 Then mh1.SetData(i, 7, 0)
            mh1.Rows.Count = mh1.Rows.Count + 1
            i = i + 1
            de1.rsbrow_dnos.MoveNext()
        Loop
        calcgrid()
        mh1.Row = 1
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cmdloop_Click()
        clsNos()
        clsgrid()

    End Sub
    Private Sub SetGridColor(ByVal tmprow As Short, ByVal tip As Short)



        Select Case tip
            Case 0
                mh1.Rows(tmprow).StyleNew.BackColor = Color.White
            Case 1
                mh1.Rows(tmprow).StyleNew.BackColor = Color.PowderBlue
            Case 2
                mh1.Rows(tmprow).StyleNew.BackColor = Color.LightPink

        End Select

    End Sub
    Private Sub Calcgrid()
        Dim bb As Object
        Dim cc As Object
        Dim tmppaymax As Object
        Dim tmpfani2 As Object
        Dim tmpfani1 As Object
        Dim ss As Object
        Dim ufani As Object
        Dim tf1 As Object
        Dim tmptip As Object
        Dim tkol1 As Object
        Dim testbim As Object
        Dim jdis As Object
        Dim itot As Object
        Dim jbimeh As Object
        Dim jact As Object
        Dim jj As Object
        Dim tez As Object
        Dim tmp2 As Object
        Dim tmp1 As Object
        Dim tt1 As Object
        Dim ttp2 As Object
        Dim abb As Object
        Dim tact As Object
        Dim tmprow As Object
        Dim i As Object
        Dim tbimeh As Object
        Dim tbimar As Object
        Dim totezaf As Object
        Dim tkol As Object
        Dim tpfani As Object
        Dim tfr As Object
        Dim TmpOrgPercent As Integer = 0
        Dim TmpOrgperc, ab1, dd As Integer
        Dim TmpBimarperc As Integer
        tottot.Text = 0
        tfr = 0
        txtfree.Text = 0
        tpfani = 0
        tkol = 0
        totezaf = 0
        tbimar = 0
        tbimeh = 0

        For i = 1 To mh1.Rows.Count - 1

            tmprow = i

            tact = Val(mh1.GetData(tmprow, 1))
            'mh1.TextMatrix(tmprow, 13) = 0

            txtnom.Text = Val(mh1.GetData(tmprow, 4))

            abb = Val(txtnom.Text) * Val(mh1.GetData(tmprow, 5))
            mh1.SetData(tmprow, 7, Math.Round(abb, 0))
            ttp2 = Val(mh1.GetData(tmprow, 6))
            mh1.SetData(tmprow, 9, ttp2 * Val(txtnom.Text))
            mh1.SetData(tmprow, 8, Val(mh1.GetData(tmprow, 5)) - Val(mh1.GetData(tmprow, 6)))
            txtpaynone.Text = ""
            txtpaynoneb.Text = ""

            tt1 = Val(mh1.GetData(tmprow, 9))
            '--------------------------------- new for sahme sazeman jadid
            TmpOrgPercent = 0
            TmpOrgPercent = Val(mh1.GetData(tmprow, 20))
            If TmpOrgPercent = 0 Then
                tmp1 = Val(txtperc.Text) * tt1 / 100
                tmp2 = Val(txtperb.Text) * tt1 / 100
            Else
                TmpOrgperc = TmpOrgPercent
                TmpBimarperc = 100 - TmpOrgPercent
                tmp1 = Val(TmpOrgperc) * tt1 / 100
                tmp2 = Val(TmpBimarperc) * tt1 / 100
            End If
            '-----------------------------------------------------------
            tmp1 = Math.Round(tmp1, 2)
            tmp2 = Math.Round(tmp2, 2)
            mh1.SetData(tmprow, 10, tmp2)
            mh1.SetData(tmprow, 11, tmp1)
            tbimar = tbimar + tmp2
            tbimeh = tbimeh + tmp1
            Select Case tact
                Case 0

                    tez = Math.Round(Val(mh1.GetData(tmprow, 7)) - Val(mh1.GetData(tmprow, 9)))
                    If tez < 0 Then tez = 0
                    mh1.SetData(tmprow, 12, tez)

            End Select

            abb = Val(mh1.GetData(tmprow, 9))
            ab1 = Val(mh1.GetData(tmprow, 12))
            tkol = tkol + abb
            totezaf = totezaf + ab1
        Next i
        '--------------------------------------------------------


        tottot.Text = tkol
        tmp2 = Val(txtperb.Text) * tkol / 100
        tmp2 = Math.Round(tmp2, 0)
        txtfree.Text = tfr
        txtezaf.Text = totezaf


        '----------------------------------------------'
        txtbimar.Text = tbimar
        txtpay.Text = Val(txtbimar.Text) + Val(txtfree.Text) + Val(txtezaf.Text)
        txtorg.Text = tbimeh
        txtbimar.Text = tbimar

        '------------------- end of fani calculte
        tmppaymax = 0

        '-----------------------------
        mh2.SetData(0, 1, txtpay.Text)
        cc = tmpmabna
        If cc > 0 Then
            bb = Val(mh2.GetData(0, 1))
            dd = myRound(bb, cc)
            mh2.SetData(0, 1, dd)
            txtpay.Text = mh2.GetData(0, 1)
        End If
        '-----------------------------


        mh2.SetData(1, 1, txtfree.Text)

        mh2.SetData(2, 1, tottot.Text)
        mh2.SetData(3, 1, txtbimar.Text)
        mh2.SetData(4, 1, txtorg.Text)
        mh2.SetData(5, 1, txtfani.Text)
        mh2.SetData(6, 1, txtezaf.Text)
        mh2.SetData(7, 1, txtfhaz.Text)

    End Sub
    Private Sub calcgrid00()

        Dim bb As Object
        Dim cc As Object
        Dim tmppaymax As Object
        Dim tmpfani2 As Object
        Dim tmpfani1 As Object
        Dim ss As Object
        Dim ufani As Object
        Dim tf1 As Object
        Dim tmptip As Object
        Dim tkol1 As Object
        Dim testbim As Object
        Dim jdis As Object
        Dim itot As Object
        Dim jbimeh As Object
        Dim jact As Object
        Dim jj As Object
        Dim tez As Object
        Dim tmp2 As Object
        Dim tmp1 As Object
        Dim tt1 As Object
        Dim ttp2 As Object
        Dim abb As Object
        Dim tact As Object
        Dim tmprow As Object
        Dim i As Object
        Dim tbimeh As Object
        Dim tbimar As Object
        Dim totezaf As Object
        Dim tkol As Object
        Dim tpfani As Object
        Dim tfr As Object
        Dim TmpOrgPercent As Integer = 0
        Dim TmpOrgperc As Integer
        Dim TmpBimarperc As Integer
        sysmsg.Visible = False
        tottot.Text = CStr(0)
        tfr = 0
        txtfree.Text = CStr(0)
        tpfani = 0
        tkol = 0
        totezaf = 0
        tbimar = 0
        tbimeh = 0

        For i = 1 To mh1.Rows.Count - 1

            tmprow = i

            tact = Val(mh1.GetData(tmprow, 1))
            mh1.SetData(tmprow, 13, 0)
            mh1.SetData(tmprow, 17, 0)
            txtnom.Text = CStr(Val(mh1.GetData(tmprow, 5)))


            abb = Val(txtnom.Text) * Val(mh1.GetData(tmprow, 6))
            mh1.SetData(tmprow, 8, System.Math.Round(abb, 0))
            ttp2 = Val(mh1.GetData(tmprow, 9))
            mh1.SetData(tmprow, 10, ttp2 * Val(txtnom.Text))
            txtpaynone.Text = ""
            txtpaynoneb.Text = ""

            tt1 = Val(mh1.GetData(tmprow, 10))
            '--------------------------------- new for sahme sazeman jadid
            TmpOrgPercent = 0
            TmpOrgPercent = Val(mh1.GetData(tmprow, 20))
            If TmpOrgPercent = 0 Then
                tmp1 = Val(txtperc.Text) * tt1 / 100
                tmp2 = Val(txtperb.Text) * tt1 / 100
            Else
                TmpOrgperc = TmpOrgPercent
                TmpBimarperc = 100 - TmpOrgPercent
                tmp1 = Val(TmpOrgperc) * tt1 / 100
                tmp2 = Val(TmpBimarperc) * tt1 / 100
            End If
            tmp1 = Val(txtperc.Text) * tt1 / 100
            tmp2 = Val(txtperb.Text) * tt1 / 100
            tmp1 = System.Math.Round(tmp1, 2)
            tmp2 = System.Math.Round(tmp2, 2)
            mh1.SetData(tmprow, 11, tmp2)
            mh1.SetData(tmprow, 12, tmp1)

            Select Case tact
                Case 0

                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    If tez < 0 Then tez = 0
                    mh1.SetData(tmprow, 13, tez)

                Case 1

                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    mh1.SetData(tmprow, 13, tez)

                Case 2 ' insert daro as orginal
                    mh1.SetData(i, 10, 0)
                    jj = i - 1
                    jact = Val(mh1.GetData(jj, 1))
                    If jact = 1 Then

                        jbimeh = Val(mh1.GetData(jj, 10))
                        itot = Val(mh1.GetData(i, 8))
                        jdis = (itot - jbimeh)

                        mh1.SetData(tmprow, 17, jdis) 'ezaf col
                    End If
                Case 3
                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    txtezaf.Text = Val(txtezaf.Text) + tez
                    mh1.SetData(tmprow, 17, tez)
                    mh1.SetData(tmprow, 13, 0)
                Case 4
                    testbim = 1
                    mh1.SetData(tmprow, 7, 0)
                    txtprice.Text = mh1.GetData(tmprow, 6)
                    txtpricebimeh.Text = CStr(Val(txtprice.Text))
                    ttp2 = Val(txtpricebimeh.Text)
                    mh1.SetData(tmprow, 9, ttp2)
                    '---------------- for recalculate mablaghe bimeh
                    txtnom.Text = CStr(Val(mh1.GetData(tmprow, 5)))


                    abb = Val(txtnom.Text) * Val(mh1.GetData(tmprow, 6))
                    mh1.SetData(tmprow, 8, System.Math.Round(abb, 0))
                    ttp2 = Val(mh1.GetData(tmprow, 9))
                    mh1.SetData(tmprow, 10, ttp2 * Val(txtnom.Text))
                    txtpaynone.Text = ""
                    txtpaynoneb.Text = ""

                    tt1 = Val(mh1.GetData(tmprow, 10))
                    tmp1 = Val(txtperc.Text) * tt1 / 100
                    tmp2 = Val(txtperb.Text) * tt1 / 100
                    tmp1 = System.Math.Round(tmp1, 2)
                    tmp2 = System.Math.Round(tmp2, 2)
                    mh1.SetData(tmprow, 11, tmp2)
                    mh1.SetData(tmprow, 12, tmp1)

                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    mh1.SetData(tmprow, 13, 0)

                Case 5

                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    mh1.SetData(tmprow, 13, tez)

                Case 6 'hazineh
                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    txtezaf.Text = Val(txtezaf.Text) + tez
                    mh1.SetData(tmprow, 17, tez)
                    mh1.SetData(tmprow, 13, 0)
                Case 8

                    testbim = 1
                    txtprice.Text = mh1.GetData(tmprow, 6)
                    ttp2 = Val(txtpricebimeh.Text)
                    txtnom.Text = CStr(Val(mh1.GetData(tmprow, 5)))
                    abb = Val(txtnom.Text) * Val(mh1.GetData(tmprow, 6))
                    mh1.SetData(tmprow, 8, System.Math.Round(abb, 0))
                    tt1 = Val(mh1.GetData(tmprow, 8))
                    tmp1 = 50 * tt1 / 100
                    tmp2 = 50 * tt1 / 100
                    tmp1 = System.Math.Round(tmp1, 2)
                    tmp2 = System.Math.Round(tmp2, 2)
                    mh1.SetData(tmprow, 7, Val(mh1.GetData(tmprow, 6)) / 2)
                    mh1.SetData(tmprow, 10, tmp2)
                    mh1.SetData(tmprow, 11, tmp2)
                    mh1.SetData(tmprow, 12, tmp1)

                    tez = System.Math.Round(Val(mh1.GetData(tmprow, 8)) - Val(mh1.GetData(tmprow, 10)))
                    mh1.SetData(tmprow, 13, tez)



            End Select

            abb = Val(mh1.GetData(tmprow, 8))

            If Val(mh1.GetData(tmprow, 14)) = 0 Then
                tpfani = tpfani + abb
            End If
            '-------------new
            If Val(mh1.GetData(tmprow, 13)) < 0 Then
                tkol1 = Val(mh1.GetData(tmprow, 8))
            Else
                tkol1 = Val(mh1.GetData(tmprow, 10))
            End If
            tfr = tfr + Val(mh1.GetData(tmprow, 13))
            tkol = tkol + tkol1
            totezaf = totezaf + Val(mh1.GetData(tmprow, 17))
            If Val(mh1.GetData(i, 8)) = 0 Then
                mh1.SetData(i, 8, "")
            End If
            If Val(mh1.GetData(i, 13)) = 0 Then
                mh1.SetData(i, 13, "")
            End If
            tmptip = 0
            If Val(mh1.GetData(i, 7)) = 0 Then
                tmptip = 0
                GoTo Um
            End If
            If Val(mh1.GetData(i, 7)) < Val(mh1.GetData(i, 6)) Then
                tmptip = 1
                GoTo Um
            End If
            If Val(mh1.GetData(i, 6)) = Val(mh1.GetData(i, 7)) Then
                tmptip = 2
                GoTo Um
            End If

Um:
            If tact = 6 Or tact = 5 Then tmptip = 2
            SetGridColor(i, tmptip)
        Next i
        '--------------------------------------------------------


        tottot.Text = tkol
        tmp2 = Val(txtperb.Text) * tkol / 100
        tmp2 = System.Math.Round(tmp2, 0)
        tbimar = tmp2
        tbimeh = tkol - tbimar
        txtfree.Text = tfr
        txtezaf.Text = totezaf

        '--------------------- fani calc -------------------------
        If Val(txtCath.Text) <> Val(txtotccath.Text) Then
            If chktatil.CheckState = 1 Then
                chknight.CheckState = System.Windows.Forms.CheckState.Checked
            End If
            If tpfani <= Val(txtmabna.Text) Then
                txtfani.Text = 0
            Else
                txtfani.Text = 0

            End If
            If Val(txtCath.Text) <> Val(txtotccath.Text) Or Val(txtCath.Text) <> Val(txtfreecath.Text) Then
                If tbimeh > 0 Then
                    txtfani.Text = 0
                Else
                    txtfani.Text = 0
                End If
                If tpfani <= Nopay Then
                    txtfani.Text = 0

                End If
            End If
            If tpfani = 0 Then
                txtfani.Text = 0
            End If
        End If
        '----------------------------------------------'
        If Val(txtCath.Text) = Val(txtotccath.Text) Then
            Select Case Val(txtOtcTip.Text)
                Case 0 ' old way
                    '---------------------------------------------------------------------------
                    If tpfani <= Val(txtomabna.Text) Then
                        If chknight.CheckState = 0 Then
                            tf1 = System.Math.Round(tpfani * Val(txtofdper.Text) / 100, 0)
                        Else
                            tf1 = System.Math.Round(tpfani * Val(txtofnper.Text) / 100, 0)
                        End If
                        If tf1 > Val(txtotcmax.Text) Then
                            tf1 = txtotcmax.Text
                        End If
                        txtfani.Text = tf1
                    Else
                        If chknight.CheckState = 0 Then
                            tf1 = System.Math.Round(tpfani * Val(txtofdper1.Text) / 100, 0)
                        Else
                            tf1 = System.Math.Round(tpfani * Val(txtofnper1.Text) / 100, 0)
                        End If
                        If tf1 > Val(txtotcmax.Text) Then
                            tf1 = txtotcmax.Text
                        End If
                        txtfani.Text = tf1

                    End If


                    ' -----------------------
                Case 1 ' calc otc fani with new way  for each item in nos
                    ufani = 0
                    For ss = 1 To mh1.Rows.Count - 1
                        abb = Val(mh1.GetData(ss, 8))
                        If abb <= 0 Then GoTo nss
                        If Val(mh1.GetData(ss, 14)) = 0 Then
                            If chknight.CheckState = 0 Then
                                tf1 = System.Math.Round(abb * Val(txtofdper.Text) / 100, 0)
                            Else
                                tf1 = System.Math.Round(abb * Val(txtofnper.Text) / 100, 0)
                            End If
                            If tf1 > Val(txtotcmax.Text) Then
                                tf1 = txtotcmax.Text
                            End If
                            ufani = ufani + tf1
                        End If
nss:
                    Next ss
                    txtfani.Text = 0
            End Select
            '----------------------- end of fani for otc
        End If
        txtbimar.Text = tbimar
        '----------------- new for special fani calculating
        '============================================================
        If chkfanitip.CheckState = 0 Then
            txtpay.Text = CStr(Val(txtbimar.Text) + Val(txtfani.Text) + Val(txtfree.Text) + Val(txtezaf.Text) + Val(txtfhaz.Text))
            txtorg.Text = tbimeh
            txtbimar.Text = tbimar
        Else ' 
            tottot.Text = tbimeh + tbimar + Val(txtfani.Text) + Val(txtfhaz.Text)
            tmp1 = Val(txtperc.Text) * CDbl(tottot.Text) / 100
            tmp2 = Val(txtperb.Text) * CDbl(tottot.Text) / 100
            tmp1 = System.Math.Round(tmp1, 0)
            tmp2 = Val(tottot.Text) - tmp1
            tmp2 = System.Math.Round(tmp2, 0)
            txtorg.Text = tmp1
            txtbimar.Text = tmp2
            txtpay.Text = CStr(Val(txtbimar.Text) + Val(txtfree.Text) + Val(txtezaf.Text))
        End If

        '------------------- end of fani calculte
        tmppaymax = 0
        Select Case cbosex.SelectedIndex
            Case 0
                tmppaymax = Val(txtpaydoc.Text)
            Case 1, 2
                tmppaymax = Val(txtpaymot.Text)
            Case 3
                tmppaymax = Val(txtpayden.Text)
            Case 4
                tmppaymax = Val(txtpaymama.Text)
        End Select

        '-----------------------------
        mh2.SetData(0, 1, txtpay.Text)
        cc = tmpmabna
        Dim dd As Integer
        If cc > 0 Then

            bb = Val(mh2.GetData(0, 1))
            dd = myRound(bb, cc)
            mh2.SetData(0, 1, dd)
            txtpay.Text = mh2.GetData(0, 1)
        End If
        '-----------------------------
        mh2.SetData(3, 0, "% " & txtperb.Text & "بیمار")

        mh2.SetData(1, 1, txtfree.Text)

        mh2.SetData(2, 1, tottot.Text)
        mh2.SetData(3, 1, txtbimar.Text)
        mh2.SetData(4, 1, txtorg.Text)
        mh2.SetData(5, 1, txtfani.Text)
        mh2.SetData(6, 1, txtezaf.Text)
        mh2.SetData(7, 1, txtfhaz.Text)

        '----------------------------
    End Sub
    Private Sub showKarbar(ByRef tmpcoka As Short)

        If de1.rsfindkar.State <> 0 Then de1.rsfindkar.Close()
        de1.findkar(tmpcoka)
        If de1.rsfindkar.RecordCount > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindkar.Fields("naka").Value) Then mh2.SetData(8, 1, de1.rsfindkar.Fields("naka").Value)
            'Label1(5).Text = mh2.GetData(8, 1)
        End If


    End Sub
    Private Sub ShowMyAgent(ByVal msg As String, ByRef act As Short)
        If MainForm.chkagent.CheckState = 0 Then Exit Sub
        Select Case act
            Case 0
                'peedy.Stop()
                'peedy.Play("blink")

            Case 1 'alert

                '			peedy.Balloon.Visible = True
                '			peedy.Stop()
                '			peedy.Think("äÓÎå äíÇÒ Èå ÊÇííÏ ÏÇÑÏ")


            Case 2 'alert
                '				peedy.Stop()
                '				peedy.Play("write")
                'peedy.Balloon.t = ""
                ''''http://home.pacbell.net/cetta/msagent.html good sample
            Case 3 'msg in nos

                '				peedy.Balloon.Visible = False '
                '				peedy.Stop()
                '				
                '				peedy.Think(msg)
                '				
                '				peedy.Balloon.Visible = True
        End Select
        ' peedy.Stop
        ' peedy.Speak "hi"
        ' peedy.Play "alert"
        ' 'peedy.Play "announce"
        ' peedy.Play "Decline" 'The character declines somethingy"
        ' peedy.Think "äÓÎå äíÇÒ Èå ÊÇííÏ ÏÇÑÏ"
        'msagent.Characters.Load "Peedy", tmpagent
        'Set peedy = msagent.Characters("Peedy")
        'peedy.LanguageID = &H409
        'peedy.Balloon.Style

        'Char.Play "Write" 'The character writes for a while and then stopsy"
        'Char.Play "Writing" 'The character writes until the char.stop function is usedy"
        'Char.Play "Read" 'The character reads for a while and then stopsy"
        'Char.Play "Reading" 'The character reads until the char.stop function is usedy"
        'Char.Play "Process" 'The character processes for a while and then stopsy"
        'Char.Play "Processing" 'The character processes until the char.stop function is used
        'Char.Play "Search" 'The character searches for a while and then stopsy"
        'Char.Play "Searching" 'The character searches until the char.stop function is used
        'Char.Play "Idle1_1" 'The character appears idley"
        'Char.Play "Acknowledge 'The character acknowledges somethingy"
        'Char.Play "Alert" 'The character look alerty"
        'Char.Play "Blink" 'The character blinksy"
        'Char.Play "Confused" 'The character looks confusedy"
        'Char.Play "Decline" 'The character declines somethingy"
        'Char.Play "DontRecognize" 'The character looks like he doesn't recognize something char.play "Hearing_1" 'The character looks like he is listening (left)y"
        'Char.Play "Hearing_2" 'The character looks like he is listening (right)y"
        'Char.Play "Hearing_3" 'The character looks like he is listening (both sides)y"
        'Char.Play "Hearing_4" 'The character lookz like he is listeningy"
        'Char.Play "Pleased" 'The character looks pleasedy"
        'Char.Play "Sad" 'The character looks sady"
        'Char.Play "Surprised" 'The character looks surprisedy"
        'Char.Play "Uncertain" 'The character looks uncertainy"
        'Char.Play "LookDown" 'Looks Downy"
        'Char.Play "LookDownBlink" 'Looks and Blinksy"
        'Char.Play "LookDownReturn" 'Stops looking and returns to rest posey"
        'Char.Play "LookUp" 'Looks Upy"
        'Char.Play "LookUpBlink" 'Looks and Blinksy"
        'Char.Play "LookUpReturn" 'Stops looking and returns to rest posey"
        'Char.Play "LookRight" 'Looks to the Righty"
        'Char.Play "LookRightBlink" 'Looks and Blinksy"
        'char.play "LookRightReturn" Stops looking and returns to rest pose
        'Char.Play "LookLeft" 'Looks to the Lefty"
        'Char.Play "LookLeftBlink" 'Looks and Blinks
        'Char.Play "LookLeftReturn" 'Stops looking and returns to rest posey"
        'Char.Play "GestureUp" 'Gestures Upy"
        'Char.Play "GestureRight" 'Gestures Righty"
        'Char.Play "GestureLeft" 'Gestures Lefty"
        'Char.Play "GestureDown" 'Gestures Downy"
        'char.play "Explain" "Explains Somethingy"
        'Char.Play "GetAttention" 'Gets the users attentiony"
        'Char.Play "Greet" 'Greets the Usery"
        'Char.Play "Announce" 'Announces somethingy"
        'Char.Play "Congratulate_1" 'Congratulates usery"
        'Char.Play "Congratulate_2" 'Congratulates usery"
        'Char.Play "DoMagic1" 'Does Magicy"
        'Char.Play "DoMagic2" 'Does Magicy"
        'Char.Play "StartListening" 'Starts Listeningy"
        'Char.Play "StoptListening" 'Stops Listeningy"
        'Char.Play "Think" 'Makes him look like he is thinkingy"
        'Char.Play "Blink" 'Makes him blink his eyesy"
        '---------------------------
        'Agent1_IdleStart 'One of the Idle methods was called
        'Agent1_Move ' fired when the character is being movedy"y"
        'Agent1_DragStart
        'Agent1_DragCompletey ""
        'Agent1_BalloonShowy ""
        'Agent1_BalloonHidey ""
        'Agent1_Clicky ""
    End Sub
    Private Sub saveheader()
        Dim vperb As Object
        Dim vperc As Object
        'On Error Resume Next
        If Val(txtnomlist.Text) = 0 Then
            getradiflist()
        End If

        If de1.rsbrow_phanumber.State <> 0 Then de1.rsbrow_phanumber.Close()
        de1.brow_phanumber(Val(txtmonth.Text), Val(txtradif.Text))

        If de1.rsbrow_phanumber.EOF = True Then
            de1.rsbrow_phanumber.AddNew()
            de1.rsbrow_phanumber.Fields("monthh").Value = Val(txtmonth.Text)
            de1.rsbrow_phanumber.Fields("cath").Value = Val(txtCath.Text)
            de1.rsbrow_phanumber.Fields("number").Value = Val(txtradif.Text)
            de1.rsbrow_phanumber.Fields("coka").Value = Val(MainForm.txtcoka.Text)
            mh2.SetData(10, 1, lbltime.Text)
            de1.rsbrow_phanumber.Fields("tim").Value = lbltime.Text

            mh2.SetData(9, 1, MainForm.txtdate1.Text)
            de1.rsbrow_phanumber.Fields("tasb").Value = MainForm.txtdate1.Text
        End If
        mh2.SetData(11, 1, Val(txtradif.Text))
        de1.rsbrow_phanumber.Fields("radif").Value = Val(txtnomlist.Text)
        de1.rsbrow_phanumber.Fields("cath").Value = Val(txtCath.Text)
        LastCath = CStr(Val(txtCath.Text))
        de1.rsbrow_phanumber.Fields("coseshbs").Value = txtbimeh.Text
        de1.rsbrow_phanumber.Fields("codmeli").Value = txtcodmeli.Text
        de1.rsbrow_phanumber.Fields("cokm").Value = Val(txtpay.Text)
        de1.rsbrow_phanumber.Fields("tot").Value = Val(tottot.Text)
        de1.rsbrow_phanumber.Fields("taan").Value = txttaan.Text
        de1.rsbrow_phanumber.Fields("datee").Value = txtdate.Text
        de1.rsbrow_phanumber.Fields("na").Value = Trim(txtname.Text)
        de1.rsbrow_phanumber.Fields("doc_name").Value = Trim(txtdoc_name.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object vperc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vperc = Val(txtperc.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object vperb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vperb = Val(txtperb.Text)
        de1.rsbrow_phanumber.Fields("org").Value = Val(txtorg.Text)
        de1.rsbrow_phanumber.Fields("tafavot").Value = Val(txtfree.Text)
        de1.rsbrow_phanumber.Fields("fani").Value = Val(txtfani.Text)
        de1.rsbrow_phanumber.Fields("bimar").Value = Val(txtbimar.Text)
        de1.rsbrow_phanumber.Fields("nezam").Value = txtnezam.Text
        de1.rsbrow_phanumber.Fields("bey").Value = 0
        de1.rsbrow_phanumber.Fields("discount").Value = 0
        de1.rsbrow_phanumber.Fields("tip").Value = Val(txttip.Text) ' noe pezeshk
        de1.rsbrow_phanumber.Fields("sex").Value = cbosex.SelectedIndex
        de1.rsbrow_phanumber.Fields("page_no").Value = Val(txtpage_no.Text)
        de1.rsbrow_phanumber.Fields("fhaz").Value = Val(txtfhaz.Text)
        de1.rsbrow_phanumber.Fields("vaz").Value = Val(txtvaz.Text) ' visit/khedmat
        de1.rsbrow_phanumber.Update()
        de1.rsbrow_phanumber.Close()

    End Sub


    Private Sub savedetail(ByRef tip As Short)
        Dim msg As Object
        Dim p1 As Object
        Dim tmpcod As Object
        Dim i As Object
        If Val(txtradif.Text) = 0 Then ' new record
            getradif()
        End If
        saveheader()
        '---------------------------------------------------------------
        If de1.rsbrow_dnos.State <> 0 Then de1.rsbrow_dnos.Close()
        de1.brow_dnos(Val(txtmonth.Text), Val(txtradif.Text))
        Do While de1.rsbrow_dnos.EOF = False
            de1.rsbrow_dnos.Delete()
            de1.rsbrow_dnos.Update()
            de1.rsbrow_dnos.MoveNext()
        Loop
        '-----------------------------------------------------------------

        For i = 1 To mh1.Rows.Count - 1
            tmpcod = Val(mh1.GetData(i, 2))
            If tmpcod > 0 Then
                p1 = Val(mh1.GetData(i, 16))
                de1.rsbrow_dnos.AddNew()
                de1.rsbrow_dnos.Fields("cath").Value = Val(txtCath.Text)
                de1.rsbrow_dnos.Fields("radif").Value = i
                de1.rsbrow_dnos.Fields("monthh").Value = Val(txtmonth.Text)
                de1.rsbrow_dnos.Fields("number").Value = Val(txtradif.Text)
                '----------------------------------------------------
                de1.rsbrow_dnos.Fields("cokm").Value = mh1.GetData(i, 2)
                de1.rsbrow_dnos.Fields("act").Value = Val(mh1.GetData(i, 13))
                de1.rsbrow_dnos.Fields("datee").Value = txtdate.Text
                de1.rsbrow_dnos.Fields("Nom").Value = Val(mh1.GetData(i, 4))
                de1.rsbrow_dnos.Fields("pay").Value = Val(mh1.GetData(i, 5))
                de1.rsbrow_dnos.Fields("paybimeh").Value = Val(mh1.GetData(i, 6))
                de1.rsbrow_dnos.Fields("bimar").Value = Val(mh1.GetData(i, 10))
                de1.rsbrow_dnos.Fields("org").Value = Val(mh1.GetData(i, 11))
                de1.rsbrow_dnos.Fields("tot").Value = Val(mh1.GetData(i, 9))
                de1.rsbrow_dnos.Fields("tim").Value = mh2.GetData(9, 1)
                de1.rsbrow_dnos.Fields("tasb").Value = Trim(mh2.GetData(10, 1))
                de1.rsbrow_dnos.Fields("Comment").Value = txtname.Text
                de1.rsbrow_dnos.Fields("daropercent").Value = Val(mh1.GetData(i, 20))
                de1.rsbrow_dnos.Update()
                '------------------------------------------
            End If
        Next i
        de1.rsbrow_dnos.Close()
        '--------------------------------------------------------
        If tip <> 1 Then
            msg = "ثبت گردید ..."
            MsgBox(msg, MsgBoxStyle.Information)
        End If
nosabt:
    End Sub

    Private Sub clsNos()
        Dim t2 As Object
        txttaan.Text = ""
        txtbimeh.Text = ""
        tottot.Text = ""
        txtorg.Text = ""
        txtbimar.Text = ""
        txtfree.Text = ""
        txtname.Text = ""
        txtfani.Text = ""
        'Label1(5).Text = MainForm.txtnaka.Text
        mh2.SetData(8, 1, MainForm.txtnaka.Text)
        txtprice.Text = ""
        txtpricebimeh.Text = ""
        txtnom.Text = ""
        txtvaz.Text = 0
        '---------------------------------------------------------------------
        If chkEtebarRepeat.CheckState = 1 Then
            mdate.Text = "1300/01/01"
            mdate.Text = "13  /  /  "
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            t2 = MainForm.txtsal.Text & "/12/30"
            'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdate.Text = t2
        End If

        txtcod_takh.Text = ""
        cbosex.SelectedIndex = 0
        txtfhaz.Text = CStr(0)
        txtnomlist.Text = ""
        txtpage_no.Text = ""
        txtcodmeli.Text = ""
        sysmsg.Visible = False
        sysmsg1.Visible = False
        flashTimer.Enabled = False
        clsgrid()
    End Sub

    Private Sub cmdlast_Click()
        If Val(mh1.GetData(mh1.Row, 0)) > 0 Then
            frmdcode.txtcode.Text = mh1.GetData(mh1.Row, 0)
        End If
        frmdcode.Show()
    End Sub


    'UPGRADE_WARNING: Event chksizetip.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chksizetip_CheckStateChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles chksizetip.CheckStateChanged
        If chksizetip.CheckState = 0 Then
            chksizetip.Text = "چاپگر1"
        Else
            chksizetip.Text = "چاپگر 2"
        End If


    End Sub

    Private Sub cmdnz_Click()
        'frmnezam.txtcode = Me.txtnezam.Text
        frmdoc.Show()
    End Sub
    Private Sub readprinttip()
        Dim tmptip As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmptip = 0

        If de1.rsfindnprint.State <> 0 Then de1.rsfindnprint.Close()
        de1.findnprint(Val(txtnprint.Text), (chksizetip.CheckState))
        If de1.rsfindnprint.EOF = False Then
            '---------------------

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsfindnprint.Fields("papertip").Value) Then tmptip = de1.rsfindnprint.Fields("papertip").Value

        End If
        If cboPaperOrientation.SelectedIndex <> -1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmptip = 0 Then
                cboPaperOrientation.SelectedIndex = 0
            Else
                cboPaperOrientation.SelectedIndex = 1
            End If
        End If
    End Sub
    Private Sub MakeFish(ByVal Index As Integer)

        frmtanzim.GetTanzimData()
        Dim tmpfile, tmpbar As String
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()

        de1.factor("delete * from factor")
        '-------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()
        de1.factor("select * from factor")
        For i = 1 To mh1.Rows.Count - 1
            If Val(mh1.GetData(i, 5)) > 0 Then
                de1.rsfactor.AddNew()
                de1.rsfactor.Fields("code").Value = mh1.GetData(i, 2)
                de1.rsfactor.Fields("Name").Value = mh1.GetData(i, 3)
                de1.rsfactor.Fields("Nom").Value = Val(mh1.GetData(i, 5))
                de1.rsfactor.Fields("pay").Value = Val(mh1.GetData(i, 6))
                de1.rsfactor.Fields("tot").Value = Val(mh1.GetData(i, 8))
                de1.rsfactor.Fields("tafavot").Value = Val(mh1.GetData(i, 13))
                de1.rsfactor.Fields("doc_name").Value = txtdoc_name.Text
                de1.rsfactor.Fields("na").Value = txtname.Text
                de1.rsfactor.Fields("nom_out").Value = Val(mh2.GetData(7, 1))  'for haghe sabt new
                de1.rsfactor.Update()
            End If
        Next i
        '---------------------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()
        de1.factor("select * from factor")

        

        tmpfile = My.Application.Info.DirectoryPath & "\report\fish.rpt"

        '-----------------------------------------------------

        Dim CR As New FactorFish

        If Dir(tmpfile) <> "" Then
            CR.Load(tmpfile, OpenReportMethod.OpenReportByDefault)
        End If
        CR.SetDataSource(de1.rsfactor)

        CR.ParameterFields(0).CurrentValues.Clear()
        CR.ParameterFields(1).CurrentValues.Clear()
        CR.ParameterFields(2).CurrentValues.Clear()
        CR.ParameterFields(3).CurrentValues.Clear()
        CR.ParameterFields(4).CurrentValues.Clear()
        CR.ParameterFields(5).CurrentValues.Clear()
        CR.ParameterFields(6).CurrentValues.Clear()
        CR.ParameterFields(7).CurrentValues.Clear()

        CR.ParameterFields(0).CurrentValues.AddValue(txtradif.Text)
        CR.ParameterFields(1).CurrentValues.AddValue(txtdate.Text)
        CR.ParameterFields(2).CurrentValues.AddValue(Val(mh2.GetData(0, 1)))
        CR.ParameterFields(3).CurrentValues.AddValue(Val(mh2.GetData(2, 1)))
        CR.ParameterFields(4).CurrentValues.AddValue(Val(mh2.GetData(4, 1)))
        CR.ParameterFields(5).CurrentValues.AddValue(Val(mh2.GetData(3, 1)))
        CR.ParameterFields(6).CurrentValues.AddValue(Val(mh2.GetData(1, 1)))
        CR.ParameterFields(7).CurrentValues.AddValue(Val(mh2.GetData(5, 1)))
        CR.SummaryInfo.ReportTitle = MainForm.lblSaheb.Text

        tmpbar = "*" + txtCath.Text + "/" + txtradif.Text + "*"

        CR.SummaryInfo.ReportComments = tmpbar


        If Index = 0 Then
            'CR.PrinterSetup(Me.hWnd)
            FrmTestAns.CRViewer1.ReportSource = CR
            FrmTestAns.CRViewer1.Show()
            FrmTestAns.Show()
        End If

        If Index = 1 Then


            CR.PrintToPrinter(1, True, 0, 0)
            If chk2daro.CheckState = 1 Then
                CR.PrintToPrinter(1, True, 0, 0)

            End If
        End If
    End Sub
    Private Sub MakeFactor(ByVal Index As Integer)
        frmtanzim.GetTanzimData()
        Dim tmpfile, tmpbar As String
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()

        de1.factor("delete from factor")
        '-------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()

        de1.factor("select * from factor")
        For i = 1 To mh1.Rows.Count - 1
            If Val(mh1.GetData(i, 5)) > 0 Then
                de1.rsfactor.AddNew()
                de1.rsfactor.Fields("code").Value = mh1.GetData(i, 2)
                de1.rsfactor.Fields("Name").Value = mh1.GetData(i, 3)
                de1.rsfactor.Fields("Nom").Value = Val(mh1.GetData(i, 5))
                de1.rsfactor.Fields("pay").Value = Val(mh1.GetData(i, 6))
                de1.rsfactor.Fields("tot").Value = Val(mh1.GetData(i, 8))
                de1.rsfactor.Fields("tafavot").Value = Val(mh1.GetData(i, 13))
                de1.rsfactor.Fields("doc_name").Value = txtdoc_name.Text
                de1.rsfactor.Fields("na").Value = txtname.Text
                de1.rsfactor.Fields("nom_out").Value = Val(mh2.GetData(7, 1))  'for haghe sabt new
                de1.rsfactor.Update()
            End If
        Next i
        '---------------------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()

        de1.factor("select * from factor")
        If de1.rsfactor.RecordCount = 0 Then
            MsgBox("اطلاعات نسخه پیدا نشد", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim Crxreport As New ReportDocument
        Dim CR As New FactorKamel
        Dim CB As New FactorDaroBig

        tmpfile = ""
        If Dir(tmpfile) = "" Or tmpfile = "" Then
            Crxreport = CB
        Else
            Crxreport.Load(tmpfile)

        End If
        '-------------------------------------------------    we dont define report . use default 
        Crxreport.SetDataSource(de1.rsfactor)
        Crxreport.ParameterFields(0).CurrentValues.Clear()
        Crxreport.ParameterFields(1).CurrentValues.Clear()
        Crxreport.ParameterFields(2).CurrentValues.Clear()
        Crxreport.ParameterFields(3).CurrentValues.Clear()
        Crxreport.ParameterFields(4).CurrentValues.Clear()
        Crxreport.ParameterFields(5).CurrentValues.Clear()
        Crxreport.ParameterFields(6).CurrentValues.Clear()
        Crxreport.ParameterFields(7).CurrentValues.Clear()

        Crxreport.ParameterFields(0).CurrentValues.AddValue(txtradif.Text)
        Crxreport.ParameterFields(1).CurrentValues.AddValue(txtdate.Text)
        Crxreport.ParameterFields(2).CurrentValues.AddValue(Val(mh2.GetData(0, 1)))
        Crxreport.ParameterFields(3).CurrentValues.AddValue(Val(mh2.GetData(2, 1)))
        Crxreport.ParameterFields(4).CurrentValues.AddValue(Val(mh2.GetData(4, 1)))
        Crxreport.ParameterFields(5).CurrentValues.AddValue(Val(mh2.GetData(3, 1)))
        Crxreport.ParameterFields(6).CurrentValues.AddValue(Val(mh2.GetData(1, 1)))
        Crxreport.ParameterFields(7).CurrentValues.AddValue(Val(mh2.GetData(5, 1)))
        Crxreport.SummaryInfo.ReportTitle = MainForm.lblSaheb.Text

        tmpbar = "*" + txtCath.Text + "/" + txtradif.Text + "*"

        Crxreport.SummaryInfo.ReportComments = tmpbar


        If Index = 0 Then

            FrmTestAns.CRViewer1.ReportSource = Crxreport
            FrmTestAns.CRViewer1.Show()
            FrmTestAns.Show()
        End If
        If Index = 1 Then

            Crxreport.PrintToPrinter(1, True, 0, 0)
            If chk2daro.CheckState = 1 Then
                Crxreport.PrintToPrinter(1, True, 0, 0)
            End If
        End If
        '-----------------------------------------------------------------------------------------------------'


    End Sub

    Private Sub dofish()
        Dim Index As Object
        Dim fishcath As Object
        Dim tmpfile As Object

        tmpfile = My.Application.Info.DirectoryPath & "\report\fish.rpt"


        Dim CR As New fishcath
        If Dir(tmpfile) <> "" Then

            CR.Load(tmpfile, OpenReportMethod.OpenReportByDefault)

        End If
        CR.ParameterFields(0).CurrentValues.Clear()
        CR.ParameterFields(1).CurrentValues.Clear()
        CR.ParameterFields(2).CurrentValues.Clear()

        CR.ParameterFields(0).CurrentValues.AddValue(Val(mh2.GetData(0, 1)))
        CR.ParameterFields(1).CurrentValues.AddValue(Val(mh2.GetData(11, 1)))
        CR.ParameterFields(2).CurrentValues.AddValue(MainForm.txtdate1.Text)





        Index = 1

        If Index = 0 Then
            FrmTestAns.CRViewer1.ReportSource = CR
            FrmTestAns.CRViewer1.Show()
            FrmTestAns.Show()
        End If
        If Index = 1 Then
            CR.PrintToPrinter(1, True, 0, 0)
            If chk2daro.CheckState = 1 Then
                CR.PrintToPrinter(1, True, 0, 0)
            End If
        End If

    End Sub
    Private Sub dojob(ByRef mytip As Short)
        Dim aa As Object
        'UPGRADE_NOTE: modal was upgraded to modal_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'

        Dim modal_Renamed As Object
        Dim pfree As Object
        Dim tmp1 As Object
        Dim tmpcod As Object
        Dim i As Object
        Dim tmpcath1 As Object
        Dim tmpcath As Object
        Dim mxrow As Object

        Dim tmpfontsize As Object
        Dim txtfile_name As Object

        readprinttip()
        'UPGRADE_WARNING: Couldn't resolve default property of object txtfile_name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtfile_name = txtnprint.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpfontsize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpfontsize = 10
        If de1.rsfindnprint.State <> 0 Then de1.rsfindnprint.Close()
        de1.findnprint(Val(txtnprint.Text), (chksizetip.CheckState))
        If de1.rsfindnprint.EOF = True Then Exit Sub





        If Not IsDBNull(de1.rsfindnprint.Fields("FontSize").Value) Then tmpfontsize = de1.rsfindnprint.Fields("FontSize").Value
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpfontsize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If tmpfontsize > 20 Or tmpfontsize < 6 Then tmpfontsize = 10


        Dim CR As New rptfish
        Dim section As Section

        Dim fieldObject As FieldObject
        Dim fieldFormat As FieldFormat
        section = CR.ReportDefinition.Sections.Item("Section6")

        fieldObject = section.ReportObjects("Field1")
        fieldFormat = fieldObject.FieldFormat
        fieldObject.Color = Color.Red
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom1left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom1left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom1top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom1top").Value
        '---------------------------------------
        fieldObject = section.ReportObjects("Field2")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom2left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom2left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom2top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom2top").Value
        '------------------------------------------
        '---------------------------------------
        fieldObject = section.ReportObjects("Field3")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom3left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom3left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom3top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom3top").Value
        '------------------------------------------
        '---------------------------------------
        fieldObject = section.ReportObjects("Field4")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom4left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom4left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom4top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom4top").Value
        '------------------------------------------
        '---------------------------------------
        fieldObject = section.ReportObjects("Field5")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom5left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom5left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom5top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom5top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field6")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom6left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom6left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom6top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom6top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field7")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom7left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom7left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom7top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom7top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field8")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom8left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom8left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom8top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom8top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field9")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom9left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom9left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom9top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom9top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field10")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom10left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom10left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom10top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom10top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field11")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom11left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom11left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom11top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom11top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field12")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom12left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom12left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom12top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom12top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field13")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom13left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom13left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom13top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom13top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field14")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom14left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom14left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom14top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom14top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field15")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom15left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom15left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom15top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom15top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field16")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom16left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom16left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom16top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom16top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field17")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom17left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom17left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom17top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom17top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field18")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom18left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom18left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom18top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom18top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field19")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom19left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom19left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom19top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom19top").Value
        '------------------------------------------'---------------------------------------
        fieldObject = section.ReportObjects("Field20")
        If Not IsDBNull(de1.rsfindnprint.Fields("Nom20left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("Nom20left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("nom20top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("nom20top").Value
        '------------------------------------------'---------------------------------------

        fieldObject = section.ReportObjects("Field21")
        If Not IsDBNull(de1.rsfindnprint.Fields("tot1left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("tot1left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("tot1top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("tot1top").Value
        '------------------------------------------
        fieldObject = section.ReportObjects("Field22")
        If Not IsDBNull(de1.rsfindnprint.Fields("tot2left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("tot2left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("tot2top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("tot2top").Value
        '------------------------------------------
        fieldObject = section.ReportObjects("Field23")
        If Not IsDBNull(de1.rsfindnprint.Fields("tot3left").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("tot3left").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("tot3top").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("tot3top").Value
        '------------------------------------------
        fieldObject = section.ReportObjects("Field24")
        If Not IsDBNull(de1.rsfindnprint.Fields("totkolleft").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("totkolleft").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("totkoltop").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("totkoltop").Value
        '------------------------------------------
        fieldObject = section.ReportObjects("Field25")
        If Not IsDBNull(de1.rsfindnprint.Fields("idleft").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("idleft").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("idtop").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("idtop").Value
        '------------------------------------------
        fieldObject = section.ReportObjects("Field26")
        If Not IsDBNull(de1.rsfindnprint.Fields("cokaleft").Value) Then fieldObject.Left = de1.rsfindnprint.Fields("cokaleft").Value
        If Not IsDBNull(de1.rsfindnprint.Fields("cokatop").Value) Then fieldObject.Top = de1.rsfindnprint.Fields("cokatop").Value
        '------------------------------------------
        CR.ParameterFields(0).CurrentValues.Clear()
        CR.ParameterFields(1).CurrentValues.Clear()
        CR.ParameterFields(2).CurrentValues.Clear()
        CR.ParameterFields(3).CurrentValues.Clear()
        CR.ParameterFields(4).CurrentValues.Clear()
        CR.ParameterFields(5).CurrentValues.Clear()
        CR.ParameterFields(6).CurrentValues.Clear()
        CR.ParameterFields(7).CurrentValues.Clear()
        CR.ParameterFields(8).CurrentValues.Clear()
        CR.ParameterFields(9).CurrentValues.Clear()
        CR.ParameterFields(10).CurrentValues.Clear()
        CR.ParameterFields(11).CurrentValues.Clear()
        CR.ParameterFields(12).CurrentValues.Clear()
        CR.ParameterFields(13).CurrentValues.Clear()
        CR.ParameterFields(14).CurrentValues.Clear()
        CR.ParameterFields(15).CurrentValues.Clear()
        CR.ParameterFields(16).CurrentValues.Clear()
        CR.ParameterFields(17).CurrentValues.Clear()
        CR.ParameterFields(18).CurrentValues.Clear()
        CR.ParameterFields(19).CurrentValues.Clear()
        CR.ParameterFields(20).CurrentValues.Clear()
        CR.ParameterFields(21).CurrentValues.Clear()
        CR.ParameterFields(21).CurrentValues.Clear()
        CR.ParameterFields(22).CurrentValues.Clear()
        CR.ParameterFields(23).CurrentValues.Clear()
        CR.ParameterFields(24).CurrentValues.Clear()
        CR.ParameterFields(25).CurrentValues.Clear()

        mxrow = mh1.Rows.Count - 1
        tmpcath = Val(txtCath.Text)
        tmpcath1 = Trim(txtCath.Text)

        For i = 1 To mxrow
            tmpcod = Val(mh1.GetData(i, 2))
            tmp1 = ""
            '---------------------------------------------------
            pfree = 0
            If (Val(txtorg.Text) = 0) Or (tmpcath = Val(txtfreecath.Text) Or tmpcath = Val(txtotccath.Text)) Then
                pfree = 1
                tmp1 = mh1.GetData(i, 8)
            End If
            If pfree = 0 Then
                If Val(mh1.GetData(i, 8)) = 0 And Val(mh1.GetData(i, 2)) = 7 Then
                    tmp1 = "--"
                End If
                If Val(mh1.GetData(i, 8)) > 0 And Val(mh1.GetData(i, 10)) = 0 Then
                    tmp1 = "X-X"
                End If
                If Val(mh1.GetData(i, 10)) > 0 And Val(mh1.GetData(i, 2)) > 0 Then
                    tmp1 = mh1.GetData(i, 10)
                End If
            End If


            Select Case i
                Case 1
                    CR.ParameterFields(0).CurrentValues.AddValue(tmp1)
                Case 2
                    CR.ParameterFields(1).CurrentValues.AddValue(tmp1)
                Case 3
                    CR.ParameterFields(2).CurrentValues.AddValue(tmp1)
                Case 4
                    CR.ParameterFields(3).CurrentValues.AddValue(tmp1)
                Case 5
                    CR.ParameterFields(4).CurrentValues.AddValue(tmp1)
                Case 6
                    CR.ParameterFields(5).CurrentValues.AddValue(tmp1)
                Case 7
                    CR.ParameterFields(6).CurrentValues.AddValue(tmp1)
                Case 8
                    CR.ParameterFields(7).CurrentValues.AddValue(tmp1)
                Case 9
                    CR.ParameterFields(8).CurrentValues.AddValue(tmp1)
                Case 10
                    CR.ParameterFields(9).CurrentValues.AddValue(tmp1)
                Case 11
                    CR.ParameterFields(10).CurrentValues.AddValue(tmp1)
                Case 12
                    CR.ParameterFields(11).CurrentValues.AddValue(tmp1)
                Case 13
                    CR.ParameterFields(12).CurrentValues.AddValue(tmp1)
                Case 14
                    CR.ParameterFields(13).CurrentValues.AddValue(tmp1)
                Case 15
                    CR.ParameterFields(14).CurrentValues.AddValue(tmp1)
                Case 16
                    CR.ParameterFields(15).CurrentValues.AddValue(tmp1)
                Case 17
                    CR.ParameterFields(16).CurrentValues.AddValue(tmp1)
                Case 18
                    CR.ParameterFields(17).CurrentValues.AddValue(tmp1)
                Case 19
                    CR.ParameterFields(18).CurrentValues.AddValue(tmp1)
                Case 20
                    CR.ParameterFields(19).CurrentValues.AddValue(tmp1)

            End Select


        Next i
        '---------------------------------------------------------------------------------------------------
        For j = i - 1 To 19
            CR.ParameterFields(j).CurrentValues.AddValue("")
        Next
        If pfree = 1 Then
            CR.ParameterFields(20).CurrentValues.AddValue(Str(Val(txtpay.Text) - Val(txtfani.Text) - Val(mh2.GetData(7, 1))))
            CR.ParameterFields(21).CurrentValues.AddValue(txtfani.Text)
            CR.ParameterFields(22).CurrentValues.AddValue(mh2.GetData(7, 1))
        Else
            CR.ParameterFields(20).CurrentValues.AddValue(tottot.Text)
            CR.ParameterFields(21).CurrentValues.AddValue(txtbimar.Text)
            CR.ParameterFields(22).CurrentValues.AddValue(txtorg.Text)
        End If

        CR.ParameterFields(23).CurrentValues.AddValue("(" + Str(mh2.GetData(0, 1)) + ")")
        If frmtanzim.chkfishno.CheckState > 0 Then
            CR.ParameterFields(24).CurrentValues.AddValue(tmpcath1 + "\" + txtnomlist.Text)
        Else
            CR.ParameterFields(24).CurrentValues.AddValue(tmpcath1 + "\" + txtradif.Text)
        End If
        '---------------------------------------------------------------------------------------------------
        CR.ParameterFields(25).CurrentValues.AddValue(txtnomlist.Text)  ' shomare list jadid 

        '--------------------------------------------------------------------------

        If mytip = 0 Then
            FrmTestAns.CRViewer1.ReportSource = CR
            FrmTestAns.CRViewer1.Show()
            FrmTestAns.ShowDialog()
        Else

            CR.PrintToPrinter(1, False, 1, 1)

        End If
        '----------------------------------------------------------------------
        If frmtanzim.chkprinTtip.CheckState = 0 Then GoTo NoMyFish
        aa = MsgBox("فیش صندوق راچاپ میکنید؟", MsgBoxStyle.YesNo)
        If aa = MsgBoxResult.Yes Then
            MakeFish(1)
        End If
NoMyFish:

    End Sub

    Private Sub cmdFactor_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdfactor.Click
        MakeFactor(0)


    End Sub

    Private Sub cmdFishcath_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdfishcath.Click
        savedetail((0))
        MakeFish(1)

        cmdnew_Click(cmdnew, New System.EventArgs)
    End Sub

    Private Sub cmdfishJanbaz_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        Dim Index As Object
        Dim tmpfile As Object
        Dim i As Object
        Dim jan As Object
        '------------------------------------------------------
        '-------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()
        de1.factor("delete * from factor")
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()
        de1.factor("select  * from factor")
        jan = 0
        For i = 1 To mh1.Rows.Count - 1
            If Val(mh1.GetData(i, 5)) > 0 Then
                If Val(mh1.GetData(i, 13)) > 0 Then
                    jan = 1
                End If
                de1.rsfactor.AddNew()
                de1.rsfactor.Fields("code").Value = mh1.GetData(i, 2)
                de1.rsfactor.Fields("Name").Value = mh1.GetData(i, 3)
                de1.rsfactor.Fields("Nom").Value = Val(mh1.GetData(i, 5))
                de1.rsfactor.Fields("pay").Value = Val(mh1.GetData(i, 6))
                de1.rsfactor.Fields("tot").Value = Val(mh1.GetData(i, 8))
                de1.rsfactor.Fields("tafavot").Value = Val(mh1.GetData(i, 13))
                de1.rsfactor.Fields("doc_name").Value = txtdoc_name.Text
                de1.rsfactor.Fields("na").Value = txtname.Text

                de1.rsfactor.Update()
            End If
        Next i
        '-------------------------------------------
        If jan = 0 Then
            de1.rsfactor.AddNew()
            de1.rsfactor.Fields("code").Value = 0
            de1.rsfactor.Fields("Name").Value = 0
            de1.rsfactor.Fields("Nom").Value = 0
            de1.rsfactor.Fields("pay").Value = 0
            de1.rsfactor.Fields("tot").Value = 0
            de1.rsfactor.Fields("tafavot").Value = 1
            de1.rsfactor.Fields("doc_name").Value = txtdoc_name.Text
            de1.rsfactor.Fields("na").Value = txtname.Text & " کدجانباز "

            de1.rsfactor.Update()
        End If
        '---------------------------------------------------------
        If de1.rsfactor.State <> 0 Then de1.rsfactor.Close()
        de1.factor("select * from factor where tafavot>0")




        tmpfile = My.Application.Info.DirectoryPath & "\report\factorjanbaz.rpt"

        '-----------------------------------------------------

        Dim CR As New factorJanbaz

        If Dir(tmpfile) <> "" Then
            CR.Load(tmpfile, OpenReportMethod.OpenReportByDefault)
        End If

        CR.Load(tmpfile, OpenReportMethod.OpenReportByDefault)
        CR.SetDataSource(de1.rsfactor)

        CR.ParameterFields(0).CurrentValues.Clear()
        CR.ParameterFields(1).CurrentValues.Clear()
        CR.ParameterFields(2).CurrentValues.Clear()
        CR.ParameterFields(3).CurrentValues.Clear()
        CR.ParameterFields(4).CurrentValues.Clear()
        CR.ParameterFields(5).CurrentValues.Clear()
        CR.ParameterFields(6).CurrentValues.Clear()
        CR.ParameterFields(7).CurrentValues.Clear()
        CR.ParameterFields(0).CurrentValues.AddValue(txtradif.Text)
        CR.ParameterFields(1).CurrentValues.AddValue(txtdate.Text.ToString)
        CR.ParameterFields(2).CurrentValues.AddValue(Val(mh2.GetData(0, 1)))
        CR.ParameterFields(3).CurrentValues.AddValue(Val(mh2.GetData(2, 1)))
        CR.ParameterFields(4).CurrentValues.AddValue(Val(mh2.GetData(4, 1)))
        CR.ParameterFields(5).CurrentValues.AddValue(Val(mh2.GetData(3, 1)))
        CR.ParameterFields(6).CurrentValues.AddValue(Val(mh2.GetData(1, 1)))
        CR.ParameterFields(7).CurrentValues.AddValue(Val(mh2.GetData(5, 1)) + Val(mh2.GetData(7, 1)))
        CR.SummaryInfo.ReportTitle = MainForm.lblSaheb.Text
        CR.SummaryInfo.ReportComments = frmtanzim.txtad.Text
        FrmTestAns.CRViewer1.ReportSource = CR
        FrmTestAns.CRViewer1.Show()
        FrmTestAns.Show()


    End Sub

    '--------------------------------------------------



    Private Sub cmdlbimar_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdlbimar.Click
        frmlbimar.Show()
    End Sub




    ' *************************************************************
    ' Display the list of available paper orientations in the
    ' cboPaperOrientation combo box.
    '
    Private Sub ShowPaperOrientation()
        Dim kol As Object
        Dim i As Short ' Counter
        'Dim PaperOrientation As CRAXDDRT.CRPaperOrientation
        ' Addcbo(cboPaperOrientation, "ÚãæÏí", CRAXDDRT.CRPaperOrientation.crPortrait)
        ' Addcbo(cboPaperOrientation, "ÇÝÞí", CRAXDDRT.CRPaperOrientation.crLandscape)
        'UPGRADE_WARNING: Couldn't resolve default property of object kol.PrintOptions.PaperOrientation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ' PaperOrientation = kol.PrintOptions.PaperOrientation ' Get the report's paper orientation setting
        ' Cycle through the combo box and select the correct currently selected type of paper orientation in the report
        With cboPaperOrientation
            For i = 0 To .Items.Count - 1
                '  If VB6.GetItemData(cboPaperOrientation, i) = PaperOrientation Then .SelectedIndex = i
            Next i
        End With
    End Sub
    'Private Sub ShowPaperSize()
    '    Dim i As Integer                            ' Counter
    '    Dim PaperSize As CRPaperSize
    '
    '    ' Add the large number of supported paper sizes to the cboPaperSize combobox
    '    Addcbo cboPaperSize, "Default", crDefaultPaperSize
    '    Addcbo cboPaperSize, "Letter", crPaperLetter
    '    Addcbo cboPaperSize, "Small Letter", crPaperLetterSmall
    '    Addcbo cboPaperSize, "Legal", crPaperLegal
    '    Addcbo cboPaperSize, "10x14", crPaper10x14
    '    Addcbo cboPaperSize, "11x17", crPaper11x17
    '    Addcbo cboPaperSize, "A3", crPaperA3
    '    Addcbo cboPaperSize, "A4", crPaperA4
    '    Addcbo cboPaperSize, "A4 Small", crPaperA4Small
    '    Addcbo cboPaperSize, "A5", crPaperA5
    '    Addcbo cboPaperSize, "B4", crPaperB4
    '    Addcbo cboPaperSize, "B5", crPaperB5
    '    Addcbo cboPaperSize, "C Sheet", crPaperCsheet
    '    Addcbo cboPaperSize, "D Sheet", crPaperDsheet
    '    Addcbo cboPaperSize, "Envelope 9", crPaperEnvelope9
    '    Addcbo cboPaperSize, "Envelope 10", crPaperEnvelope10
    '    Addcbo cboPaperSize, "Envelope 11", crPaperEnvelope11
    '    Addcbo cboPaperSize, "Envelope 12", crPaperEnvelope12
    '    Addcbo cboPaperSize, "Envelope 14", crPaperEnvelope14
    '    Addcbo cboPaperSize, "Envelope B4", crPaperEnvelopeB4
    '    Addcbo cboPaperSize, "Envelope B5", crPaperEnvelopeB5
    '    Addcbo cboPaperSize, "Envelope B6", crPaperEnvelopeB6
    '    Addcbo cboPaperSize, "Envelope C3", crPaperEnvelopeC3
    '    Addcbo cboPaperSize, "Envelope C4", crPaperEnvelopeC4
    '    Addcbo cboPaperSize, "Envelope C5", crPaperEnvelopeC5
    '    Addcbo cboPaperSize, "Envelope C6", crPaperEnvelopeC6
    '    Addcbo cboPaperSize, "Envelope C65", crPaperEnvelopeC65
    '    Addcbo cboPaperSize, "Envelope DL", crPaperEnvelopeDL
    '    Addcbo cboPaperSize, "Envelope Italy", crPaperEnvelopeItaly
    '    Addcbo cboPaperSize, "Envelope Monarch", crPaperEnvelopeMonarch
    '    Addcbo cboPaperSize, "Envelope Personal", crPaperEnvelopePersonal
    '    Addcbo cboPaperSize, "E Sheet", crPaperEsheet
    '    Addcbo cboPaperSize, "Executive", crPaperExecutive
    '   Addcbo cboPaperSize, "Fanfold Legal German", crPaperFanfoldLegalGerman
    '   Addcbo cboPaperSize, "Fanfold Standard German", crPaperFanfoldStdGerman
    '   Addcbo cboPaperSize, "Fanfold US", crPaperFanfoldUS
    '   Addcbo cboPaperSize, "Folio", crPaperFolio
    '   Addcbo cboPaperSize, "Ledger", crPaperLedger
    '   Addcbo cboPaperSize, "Note", crPaperNote
    '   Addcbo cboPaperSize, "Quarto", crPaperQuarto
    '   Addcbo cboPaperSize, "Statement", crPaperStatement
    '   Addcbo cboPaperSize, "Tabloid", crPaperTabloid
    '   PaperSize = kol.PrintOptions.PaperSize    ' Get the report's paper size setting
    '   ' Cycle through the combo box and select the correct currently selected type of paper size in the report
    '   With cboPaperSize
    '       For i = 0 To .ListCount - 1
    '           If .ItemData(i) = PaperSize Then .ListIndex = i
    '       Next i
    '   End With
    'End Sub

    ' *************************************************************
    ' A small helper function for the ShowPrinterOption functions that
    ' helps reduce the amount of code to write
    '   Addcbo format:   <combo name to add item to>, <item caption>, <.itemdata(.listindex) to assign>
    'UPGRADE_NOTE: Name was upgraded to Name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Addcbo(ByRef cbo As System.Windows.Forms.ComboBox, ByRef Name_Renamed As String, ByRef Index As Short)
        cbo.Items.Add(Name_Renamed) ' Add the name of the item to the combo box
        'UPGRADE_ISSUE: ComboBox property index was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
        VB6.SetItemData(cbo, Index, Index) ' Set the .itemdata(.listindex) for later retrieval
    End Sub





    Private Sub cmdMkasr_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdMkasr.Click
        On Error Resume Next
        If Val(txtmonth.Text) > 1 Then
            txtmonth.Text = CStr(Val(txtmonth.Text) - 1)
        Else
            Exit Sub
        End If
        MainForm.txtmonth.Text = CStr(Val(txtmonth.Text))
        'UPGRADE_WARNING: Lower bound of collection mainform.sbar1.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        MainForm.sbar1.Items.Item(4).Text = CStr(Val(txtmonth.Text))
        MainForm.sbar1.Refresh()
        dodate()
        If de1.rsfindpass.State <> 0 Then de1.rsfindpass.Close()
        de1.findpass((MainForm.txtuser.Text), (MainForm.txtpass.Text))

        If de1.rsfindpass.EOF = False Then
            de1.rsfindpass.Fields("actmonth_sbt").Value = Val(txtmonth.Text)
            de1.rsfindpass.Update()
        End If
        cmdnew_Click(cmdnew, New System.EventArgs)
    End Sub

    Private Sub cmdMplus_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdMplus.Click
        On Error Resume Next
        If Val(txtmonth.Text) < 12 Then
            txtmonth.Text = CStr(Val(txtmonth.Text) + 1)
        Else
            Exit Sub
        End If
        MainForm.txtmonth.Text = CStr(Val(txtmonth.Text))
        MainForm.sbar1.Items.Item(4).Text = CStr(Val(txtmonth.Text))
        MainForm.sbar1.Refresh()
        dodate()
        '--------------------------------------------
        If de1.rsfindpass.State <> 0 Then de1.rsfindpass.Close()
        de1.findpass((MainForm.txtuser.Text), (MainForm.txtpass.Text))

        If de1.rsfindpass.EOF = False Then
            de1.rsfindpass.Fields("actmonth_sbt").Value = Val(txtmonth.Text)
            de1.rsfindpass.Update()
        End If
        cmdnew_Click(cmdnew, New System.EventArgs)
    End Sub


    Private Sub cmdPerFerazh_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        If ControlMe() = 0 Then Exit Sub
        savedetail((1))
        dojob((0))
        cmdnew_Click(cmdnew, New System.EventArgs)


    End Sub



    Private Sub Cmdsave_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim a As Object
        If ControlMe() = 0 Then Exit Sub
        If Val(mh2.GetData(2, 1)) <= 0 And Val(mh2.GetData(0, 1)) <= 0 Then
            a = MsgBox("مبلغ نسخه صفر میباشد از ثبت آن مطمئن هستید؟", MsgBoxStyle.YesNo)
            If a <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        savedetail((0))
        cmdnew_Click(cmdnew, New System.EventArgs)

    End Sub


    Private Sub cmdlistcath_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdlistcath.Click
        frmlcath.txtproc.Text = CStr(1)
        frmlcath.Show()
    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command10.Click
        Dim tmpradif As Object
        If de1.rsshowRadif.State <> 0 Then de1.rsshowRadif.Close()
        de1.showRadif(Val(txtmonth.Text))
        If de1.rsshowRadif.EOF = False Then
            de1.rsshowRadif.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshowRadif.Fields("radif").Value

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = 1
        End If
        de1.rsshowRadif.Close()
        If Val(txtnomlist.Text) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtnomlist.Text = tmpradif
            txtnomlist_Leave(txtnomlist, New System.EventArgs)

        Else
            If Val(txtnomlist.Text) > 1 Then
                txtnomlist.Text = CStr(Val(txtnomlist.Text) - 1)
            End If

            txtnomlist_Leave(txtnomlist, New System.EventArgs)

        End If
        mh1.Row = 1
    End Sub

    Private Sub Command2_Click()
        Dim tmpvaz As Object
        If de1.rsbrow_phanumber.State <> 0 Then de1.rsbrow_phanumber.Close()
        de1.brow_phanumber(Val(txtmonth.Text), Val(txtradif.Text))

        If de1.rsbrow_phanumber.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpvaz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("vaz").Value) Then tmpvaz = de1.rsbrow_phanumber.Fields("vaz").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpvaz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpvaz < 10 Then
                de1.rsbrow_phanumber.Fields("vaz").Value = 10
                de1.rsbrow_phanumber.Update()
                MsgBox("äÓÎå ÏÑ áíÓÊ ÂãÇÏå ÇÑÓÇá ÞÑÇÑÑÝÊ", MsgBoxStyle.Information)
            End If
        End If
    End Sub




    Private Sub CmdLastShow_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdlastshow.Click
        ShowLastNos()
    End Sub





    Private Sub Command7_Click()
        cmdleft_Click(cmdleft, New System.EventArgs)
    End Sub

    Private Sub Command8_Click()
        cmdright_Click(cmdright, New System.EventArgs)
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command9.Click
        Dim tmpradif As Object
        If de1.rsshowRadif.State <> 0 Then de1.rsshowRadif.Close()
        de1.showRadif(Val(txtmonth.Text))
        If de1.rsshowRadif.EOF = False Then
            de1.rsshowRadif.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshowRadif.Fields("radif").Value

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = 1
        End If
        de1.rsshowRadif.Close()
        '---------------------------------------------------
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Val(txtnomlist.Text) < tmpradif Then
            txtnomlist.Text = CStr(Val(txtnomlist.Text) + 1)
            txtnomlist_Leave(txtnomlist, New System.EventArgs)

        End If


nofound:

        mh1.Row = 1
    End Sub


    Private Function SayKarbar(ByVal tmpcoka As Short) As String
        Dim tmp1 As Object
        If de1.rsfindkar.State <> 0 Then de1.rsfindkar.Close()

        de1.findkar(tmpcoka)
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp1 = ""
        If de1.rsfindkar.RecordCount > 0 Then

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsfindkar.Fields("naka").Value) Then tmp1 = de1.rsfindkar.Fields("naka").Value
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SayKarbar = tmp1
    End Function
    Private Sub frmdnos_Load(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnezam.Text = frmtanzim.txtcode.Text
        txtdoc_name.Text = frmtanzim.txtsaheb.Text
        Timer1.Enabled = True

        'mh1.HighLight = VSFlex7L.ShowSelSettings.flexHighlightAlways
        'UPGRADE_WARNING: Lower bound of collection mainform.sbar1.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        txtmonth.Text = MainForm.sbar1.Items.Item(4).Text
        chksizetip.CheckState = Val(MainForm.txttip.Text)
        cboact.Visible = False
        Showtip()
        clsgrid2()
        clsgrid4()
        keyblatin()
        _Label1_5.Text = MainForm.txtnaka.Text
        '----------------------------------------------------------------'
        If de1.rsfindmain.State <> 0 Then de1.rsfindmain.Close()
        de1.findmain()

        If de1.rsfindmain.RecordCount > 0 Then

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("mabna").Value) Then txtmabna.Text = de1.rsfindmain.Fields("mabna").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("omabna").Value) Then txtomabna.Text = de1.rsfindmain.Fields("omabna").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofhaz").Value) Then txtofhaz.Text = de1.rsfindmain.Fields("ofhaz").Value
            '-----------------------------------------------
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fdpay").Value) Then txtfdpay.Text = de1.rsfindmain.Fields("fdpay").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fdpay1").Value) Then txtfdpay1.Text = de1.rsfindmain.Fields("fdpay1").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fnpay").Value) Then txtfnpay.Text = de1.rsfindmain.Fields("fnpay").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fnpay1").Value) Then txtfnpay1.Text = de1.rsfindmain.Fields("fnpay1").Value
            '------------------------
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fdper").Value) Then txtfdper.Text = de1.rsfindmain.Fields("fdper").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fdper1").Value) Then txtfdper1.Text = de1.rsfindmain.Fields("fdper1").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fnper").Value) Then txtfnper.Text = de1.rsfindmain.Fields("fnper").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("fnper1").Value) Then txtfnper1.Text = de1.rsfindmain.Fields("fnper1").Value
            '------------------------------------------------
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofdpay").Value) Then txtofdpay.Text = de1.rsfindmain.Fields("ofdpay").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofdpay1").Value) Then txtofdpay1.Text = de1.rsfindmain.Fields("ofdpay1").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofnpay").Value) Then txtofnpay.Text = de1.rsfindmain.Fields("ofnpay").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofnpay1").Value) Then txtofnpay1.Text = de1.rsfindmain.Fields("ofnpay1").Value
            '------------------------
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofdper").Value) Then txtofdper.Text = de1.rsfindmain.Fields("ofdper").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofdper1").Value) Then txtofdper1.Text = de1.rsfindmain.Fields("ofdper1").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofnper").Value) Then txtofnper.Text = de1.rsfindmain.Fields("ofnper").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("ofnper1").Value) Then txtofnper1.Text = de1.rsfindmain.Fields("ofnper1").Value
            '--------------------------------------------------
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("hour1").Value) Then txthour1.Text = de1.rsfindmain.Fields("hour1").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("hour2").Value) Then txthour2.Text = de1.rsfindmain.Fields("hour2").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("otcmax").Value) Then txtotcmax.Text = de1.rsfindmain.Fields("otcmax").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("farsi").Value) Then chkfarsi.CheckState = de1.rsfindmain.Fields("farsi").Value


            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("savebimar").Value) Then chkbimar.CheckState = de1.rsfindmain.Fields("savebimar").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("otccath").Value) Then txtotccath.Text = de1.rsfindmain.Fields("otccath").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("freecath").Value) Then txtfreecath.Text = de1.rsfindmain.Fields("freecath").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("daynight").Value) Then chkdaynight.CheckState = de1.rsfindmain.Fields("daynight").Value
            tmpmabna = 0
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("saghf_pay").Value) Then tmpmabna = de1.rsfindmain.Fields("saghf_pay").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("cod_sanad").Value) Then Nopay = de1.rsfindmain.Fields("cod_sanad").Value ' refer for free fani 'new
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindmain.Fields("otctip").Value) Then txtOtcTip.Text = de1.rsfindmain.Fields("otctip").Value ' new 881117



        End If
        chkEtebarRepeat.CheckState = frmtanzim.chkEtebarRepeat.CheckState
        ShowPaperOrientation()
        'cboPaperOrientation.SelectedIndex = 0
        txtmonth.Text = MainForm.txtmonth.Text
        txtperc.Text = CStr(70) ' franshiz of noskheh
        txtfani.Text = ""
        Showact()

        clsgrid()
        clsgrid2()
        dodate()
        If frmtanzim.chkNoshow.CheckState <> 1 Then

            ShowLastNos()
        End If
        frmxlist.txtproc.Text = CStr(9)
    End Sub
    Private Sub ShowLastNos()
        Dim tmpradif As Object

        If de1.rsshownumber.State <> 0 Then de1.rsshownumber.Close()
        de1.shownumber(Val(txtmonth.Text))
        If de1.rsshownumber.EOF = False Then
            de1.rsshownumber.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshownumber.Fields("number").Value

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = 1
        End If
        de1.rsshownumber.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtradif.Text = tmpradif
        txtradif_Leave(txtradif, New System.EventArgs)



    End Sub




    Private Sub lmbimar_Click()
        'frmlbimar.Show()
    End Sub

    Private Sub Label2_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        ' Dim Index As Short = Label2.GetIndex(eventSender)
        mh1.Row = 1
    End Sub

    Private Sub mh1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mh1_EnterCell(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        ' mh1.CellBackColor = lblcolor.BackColor
    End Sub

    Private Sub mh1_LeaveCell(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        'mh1.CellBackColor = lblcolor1.BackColor
    End Sub

    Private Sub cmdAutoedit_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdautoedit.Click
        Dim tmpcod As Object
        Dim i As Object
        Dim a As Object
        If Val(txtmonth.Text) = 0 Then
            MsgBox("ماه نسخه را مشخص نمایید", vbCritical)
            Exit Sub
        End If
        If Val(txtCath.Text) = 0 Then
            MsgBox("نوع بیمه را مشخص نمایید", vbCritical)
            Exit Sub
        End If


        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = MsgBox("برای اجرای محاسبه اتوماتیک مطمئن هستید؟", MsgBoxStyle.YesNo)
        If a <> MsgBoxResult.Yes Then Exit Sub
        If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
        de1.browall("select * from pha_detail where cath=" + txtCath.Text + " and monthh=" + txtmonth.Text + " ")

        Dim tmpradif As Integer
        Do While de1.rsbrowall.EOF = False

            tmpradif = 0
            If Not IsDBNull(de1.rsbrowall.Fields("number").Value) Then tmpradif = de1.rsbrowall.Fields("number").Value

            If tmpradif <> 0 Then

                txtradif.Text = tmpradif

                txtradif_Leave(txtradif.Text, New System.EventArgs)
                cmdcalcrep_Click(cmdcalcrep, New System.EventArgs)
                savedetail((1))
                cmdnew_Click(cmdnew, New System.EventArgs)


            End If
            de1.rsbrowall.MoveNext()
        Loop
        MsgBox("پایان محاسبه مجدد تمام نسخ ثبت شده....", vbInformation)


    End Sub

    Private Sub mncalc_Click()
        Dim aa As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aa = Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

   

    Private Sub dodate()
        Dim tmp1 As Object
        Dim tmp2 As Object
        On Error Resume Next
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp2 = MainForm.txtmonth.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Val(tmp2) <= 9 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmp2 = "0" + tmp2
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp1 = MainForm.txtsal.Text & "/" + tmp2 + "/" + Mid(MainForm.txtdate1.Text, 9, 2)
        txtdate.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtdate.Text = tmp1
        txtdate.SelectionLength = 8
        txtdate.SelectionStart = 9

    End Sub
    Private Sub mdate_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles mdate.Enter
        '   mdate.BackColor = lblcolor.BackColor
        '   mdate.SelectionStart = 2
        '   mdate.SelectionLength = 8
        '        Me.mdate.BackColor = Color.Purple
        '        Me.mdate.ForeColor = Color.Yellow
    End Sub

    Private Sub mdate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mdate.GotFocus
        mdate.SelectionStart = 2
        mdate.SelectionLength = 8
    End Sub

    Private Sub mdate_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mdate.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        On Error Resume Next
        Select Case KeyCode
            Case 33 'pgup
                '  mdate.Text = MESHAMSI.IncreaseDate(mdate.Text)

            Case 34 'pgdn
                ' mdate.Text = MESHAMSI.DecreaseDate(mdate.Text)
            Case 38 'up arrow
                System.Windows.Forms.SendKeys.Send("+{TAB}")

            Case 40

                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 13

                System.Windows.Forms.SendKeys.Send("{TAB}")

            Case 27

                System.Windows.Forms.SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub mdate_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles mdate.Leave
        'Me.mdate.BackColor = Me.mdate.DefaultBackColor
        'Me.mdate.ForeColor = Me.mdate.DefaultForeColor
        txttaan.Text = mdate.Text
    End Sub
    Private Sub Showact()
        Dim i As Short ' Counter
        '----------------- new
        Addcbo(cboact, "       ", 0)
        Addcbo(cboact, "1-مشابه", 1)
        Addcbo(cboact, "2-جایگزین", 2)
        Addcbo(cboact, "3-اضافه", 3)
        Addcbo(cboact, "4-بیمه ای", 4)
        Addcbo(cboact, "5-غیربیمه ای", 5)
        Addcbo(cboact, "6-هزینه", 6)
        Addcbo(cboact, "7-خالی", 7)
        Addcbo(cboact, "8-50 درصد", 8)



    End Sub
   
    Private Sub clsgrid4()
        mh4.Rows.Count = 1
        mh4.Cols.Count = 2
        mh4.Clear()
        mh4.Rows.Fixed = 0
        ' mh4.AutoSearch = VSFlex7L.AutoSearchSettings.flexSearchFromTop
        ' mh4.FocusRect = VSFlex7L.FocusRectSettings.flexFocusHeavy
        'mh4.AllowSelection = False
        'mh4.SelectionMode = VSFlex7L.SelModeSettings.flexSelectionByRow
        'UPGRADE_NOTE: RightToLeft was upgraded to CtlRightToLeft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'mh4.CtlRightToLeft = True
        mh4.Cols(0).Width = 500
        mh4.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom

        mh4.Cols(1).Width = 3200
        If de1.rslistcath.State <> 0 Then de1.rslistcath.Close()
        de1.listcath()
        Dim i As Short
        i = 0

        Do While de1.rslistcath.EOF = False

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rslistcath.Fields("cath").Value) Then mh4.SetData(i, 0, de1.rslistcath.Fields("cath").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rslistcath.Fields("Name").Value) Then mh4.SetData(i, 1, de1.rslistcath.Fields("Name").Value)

            de1.rslistcath.MoveNext()
            If de1.rslistcath.EOF = True Then GoTo D1
            mh4.Rows.Count = mh4.Rows.Count + 1
            i = i + 1
        Loop
D1:
        de1.rslistcath.Close()
        'mh4.Col = 0
        'mh4.TextMatrix(mh4.Row, 0) = LastCath
        'GetCath

    End Sub
    Private Sub clsgrid()
        mh1.Rows.Count = 2
        mh1.Cols.Count = 22
        mh1.Clear()
        mh1.SetData(0, 0, "رديف")
        mh1.SetData(0, 1, "وضعيت")
        mh1.SetData(0, 2, "كد ")

        '  mh1.RightToLeft = True
       
        mh1.SetData(0, 3, "نام             ")
        mh1.SetData(0, 4, "تعداد")
        mh1.SetData(0, 5, " قيمت")
        mh1.SetData(0, 6, "قيمت بيمه")
        mh1.SetData(0, 7, "جمع كل")
        mh1.SetData(0, 8, "اختلاف")
        mh1.Cols(0).Width = 30

        mh1.Cols(1).Width = 80
        mh1.Cols(2).Width = 110
        mh1.Cols(3).Width = 300

        mh1.Cols(4).Width = 70
        mh1.Cols(5).Width = 70
        mh1.Cols(6).Width = 100
        mh1.Cols(7).Width = 80
        mh1.Cols(8).Width = 100
        mh1.Cols(9).Width = 100
        mh1.Cols(10).Width = 100
        mh1.Cols(11).Width = 100
        mh1.Cols(12).Width = 100
        mh1.Cols(20).Width = 100
        '---------------------------------------
        mh1.Cols(13).Width = 0
        mh1.Cols(14).Width = 0
        mh1.Cols(15).Width = 0
        mh1.Cols(16).Width = 0
        mh1.Cols(17).Width = 0
        mh1.Cols(18).Width = 0
        mh1.Cols(19).Width = 0
        '--------------------------------------
        mh1.SetData(0, 9, "جمع بيمه")
        mh1.SetData(0, 10, "سهم بيمار")
        mh1.SetData(0, 11, "سهم بيمه")
        mh1.SetData(0, 12, "تفاوت بيمه")
        mh1.SetData(0, 13, "وضعيت")
        mh1.SetData(0, 20, "درصد")
        mh1.SetData(1, 0, 1)
        mh1.Row = 1
        '-----------------------------------------
        mh1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        mh1.Col = 2
    End Sub
   
    Private Sub calcrow()

        Dim newrow As Integer
        Dim ttp2 As Integer
        Dim testbim As Integer
        Dim tact As Integer
        Dim a As Integer
        Dim uc As Integer
        Dim tpact As Double
        Dim tmpact As Double
        Dim tmpcokm As String
        tmpcokm = mh1.GetData(mh1.Row, 2)
        tmpact = Val(mh1.GetData(mh1.Row, 15))
        Select Case mh1.Col
            Case 0
                mh1.Col = 1
            Case 1
                tpact = Val(mh1.GetData(mh1.Row, 1))
                mh1.SetData(mh1.Row, 16, tpact)
                mh1.SetData(mh1.Row, 1, VB6.GetItemString(cboact, Val(mh1.GetData(mh1.Row, 16))))

                If Val(tpact) >= 0 And Val(tpact) <= 8 Then
                    cboact.SelectedIndex = tpact
                End If
                Select Case tpact

                    Case 6
                        mh1.SetData(mh1.Row, 2, 6)
                        mh1.SetData(mh1.Row, 3, "هزینه")
                        mh1.SetData(mh1.Row, 5, 1)
                        mh1.SetData(mh1.Row, 14, 0)
                        mh1.SetData(mh1.Row, 7, mh1.GetData(mh1.Row, 6))
                        mh1.Col = 6
                    Case 7
                        mh1.SetData(mh1.Row, 2, 7)
                        mh1.SetData(mh1.Row, 3, "خالی ")
                        mh1.SetData(mh1.Row, 5, 1)
                        mh1.SetData(mh1.Row, 14, 1)
                        'mh1.TextMatrix(mh1.Row, 7) = "X-X"
                        mh1.SetData(mh1.Row, 7, mh1.GetData(mh1.Row, 6))
                        mh1.Col = 6
                    Case Else
                        mh1.Col = 2
                End Select
            Case 2
                a = sdaro(0)

                tact = Val(mh1.GetData(mh1.Row, 1))

                'Case 4
                '  testbim = 1
                '   mh1.SetData(mh1.Row, 7, 0)
                ' txtprice.Text = mh1.GetData(mh1.Row, 6)
                'txtpricebimeh.Text = CStr(Val(txtprice.Text))
                'ttp2 = Val(txtpricebimeh.Text)
                'mh1.SetData(mh1.Row, 9, ttp2)

            Case 4, 6
                If tmpact = 1 Then
                    newrow = mh1.Row + 1
                    If newrow >= mh1.Rows.Count Then
                        mh1.Rows.Count = mh1.Rows.Count + 1
                    End If
                    mh1.SetData(mh1.Row + 1, 15, 2)
                    mh1.Col = 2
                End If
                If mh1.Row < mh1.Rows.Count - 1 Then
                    mh1.Row = mh1.Row + 1
                Else
                    mh1.Rows.Count = mh1.Rows.Count + 1
                    mh1.Row = mh1.Row + 1
                End If

                mh1.Col = 2


        End Select

        Calcgrid()
    End Sub

    Private Sub mh1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh1.KeyDown
        Dim L2 As Object
        Dim L1 As Object
        Dim pp As Object
        Dim ii As Object
        Dim kk As Object
        If e.Shift = 4 And e.KeyCode = 18 Then
            frmBarcode.txtcode.Text = mh1.GetData(mh1.Row, 2)
            frmBarcode.txtdaro_fname.Text = mh1.GetData(mh1.Row, 3)
            frmBarcode.ShowDialog()
        End If
        Select Case e.KeyCode
            Case 17 ' perferzh
                savedetail((1))
                dojob((0))
                cmdnew_Click(cmdnew, New System.EventArgs())
            Case 38 'up arrow
                If mh1.Row = 1 Then
                    System.Windows.Forms.SendKeys.Send("+{TAB}")
                End If
            Case 33 'pgup
                cmdleft_Click(cmdleft, New System.EventArgs)

            Case 34 'pgdn
                cmdright_Click(cmdright, New System.EventArgs)


            Case 13

                If mh1.Col = 4 Then
                    calcrow()
                End If



            Case 46 ' delete
                'UPGRADE_WARNING: Couldn't resolve default property of object kk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                kk = mh1.Row
                mh1.SetData(mh1.Row, mh1.Col, "")


                '------------------------------



            Case 113 'f2
                If ControlMe() = 0 Then Exit Sub
                If cmdsave.Enabled = False Then Exit Sub
                Cmdsave_Click(cmdsave, New System.EventArgs)

            Case 114 'f3
                cmdFishcath_Click(cmdfishcath, New System.EventArgs)

            Case 27 'ESC

                Dim msg As String
                Dim a As Integer

                msg = "نسخه جدید را شروع میکنید؟"

                a = 7

                a = MsgBox(msg, MsgBoxStyle.YesNo)
                If a = MsgBoxResult.Yes Then
                    cmdnew_Click(cmdnew, New System.EventArgs())
                End If



            Case 115 'f4

                ii = mh1.Row


                For kk = ii To mh1.Rows.Count - 2
                    For pp = 1 To mh1.Cols.Count - 1

                        mh1.SetData(kk, pp, mh1.GetData(kk + 1, pp))
                    Next pp
                Next kk
                txtprice.Text = ""
                txtpricebimeh.Text = ""

                If mh1.Rows.Count > 2 Then
                    mh1.Rows.Count = mh1.Rows.Count - 1
                End If

                Calcgrid()
            Case 116 'f5
                If Val(mh1.GetData(mh1.Row, 2)) > 0 Then
                    frmdcode.txtcode.Text = mh1.GetData(mh1.Row, 2)
                    '  frmdcode.txtcode_Leave(mh1.GetData(mh1.Row, 2), New System.EventArgs)
                End If
                frmdcode.Show()
                frmdcode.BringToFront()
            Case 117 'f6
                ii = mh1.Row
                mh1.Rows.Count = mh1.Rows.Count + 1
                L1 = mh1.Rows.Count - 1
                For kk = L1 To ii Step -1
                    L2 = kk - 1
                    For pp = 1 To mh1.Cols.Count - 1
                        mh1.SetData(kk, pp, mh1.GetData(kk - 1, pp))
                    Next pp
                Next kk
                For pp = 1 To mh1.Cols.Count - 1
                    mh1.SetData(ii, pp, "")
                Next pp
            Case 118 'f7
                savedetail((1))
                dojob((1))

                cmdnew_Click(cmdnew, New System.EventArgs())
            Case 107 '+
                savedetail((1))
                dojob((1))
                cmdnew_Click(cmdnew, New System.EventArgs())
        End Select

    End Sub


    Private Sub mh1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh1.KeyPress
        Dim isch As Object
        Dim vt As Object
        Dim RowsSel As Object
        Dim mkeyascii As Integer
        mkeyascii = Asc(e.KeyChar)
        RowsSel = mh1.Row
        If mkeyascii = 32 Or (mkeyascii >= 40 And mkeyascii <= 133) Or (mkeyascii >= 159 And mkeyascii <= 159) Or (mkeyascii >= 161 And mkeyascii <= 162) Or (mkeyascii >= 191 And mkeyascii <= 237) Or (mkeyascii >= 138 And mkeyascii <= 156) Then
            If Len(mh1.GetData(mh1.Row, mh1.Col)) > 0 Then
                If Mid(mh1.GetData(mh1.Row, mh1.Col), Len(mh1.GetData(mh1.Row, mh1.Col)), 1) = "|" Then
                    mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
                End If
            End If
            mh1.SetData(mh1.Row, mh1.Col, mh1.GetData(mh1.Row, mh1.Col) & e.KeyChar)
        End If
        'If mkeyascii = 8 And mh1.GetData(mh1.Row, mh1.Col) <> "" Then
        'If Mid(mh1.GetData(mh1.Row, mh1.Col), Len(mh1.GetData(mh1.Row, mh1.Col)), 1) = "|" Then
        'mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
        'End If
        'If mh1.GetData(mh1.Row, mh1.Col) <> "" Then
        ' mh1.SetData(mh1.Row, mh1.Col, Mid(mh1.GetData(mh1.Row, mh1.Col), 1, Len(mh1.GetData(mh1.Row, mh1.Col)) - 1))
        ' End If
        ' End If

        '------------------------------------------------
        If mh1.Col = 2 Then
            vt = IsNumeric(mh1.GetData(mh1.Row, 2))
            isch = Trim(mh1.GetData(mh1.Row, 2))
            If vt = False And isch <> "" Then
                showlist()
            End If

        End If
        If mkeyascii = 13 Then
            calcrow()
        End If
    End Sub

    Private Function sdaro(ByVal tmprow As Integer) As Integer
        Dim kfound, tact, ttp1, ttp2, tmpOrgPercenet, tstekht, testbim As Integer
        Dim tmpcokm, tvcode As String
        If tmprow = 0 Then
            tmprow = mh1.Row
        End If
        tmpcokm = mh1.GetData(tmprow, 2)
        If Val(tmpcokm) = 0 Then
            mh1.Col = 2
            Exit Function
        End If

        tact = Val(mh1.GetData(tmprow, 1))
        kfound = 0
        '-------------------------------------------------------
        If Len(tmpcokm) >= 10 Then
            If de1.rsBarCodeFind.State <> 0 Then de1.rsBarCodeFind.Close()
            de1.BarCodeFind(tmpcokm)
            If de1.rsBarCodeFind.EOF = False Then
                tmpcokm = de1.rsBarCodeFind.Fields("daro_code").Value
                mh1.SetData(tmprow, 2, tmpcokm)
                GoTo NoVcode
            End If

        End If
        If de1.rsfindvcode.State <> 0 Then de1.rsfindvcode.Close()
        tvcode = tmpcokm
        de1.findvcode(tvcode, 0)
        If de1.rsfindvcode.EOF = False Then
            If Not IsDBNull(de1.rsfindvcode.Fields("daro_code").Value) Then tmpcokm = de1.rsfindvcode.Fields("daro_code").Value
            mh1.SetData(tmprow, 2, tmpcokm)
        End If
NoVcode:
        '-------------------------------------------------------------------
        txtprice.Text = 0
        txtpricebimeh.Text = 0
        If de1.rsdarocode.State <> 0 Then de1.rsdarocode.Close()
        de1.darocode(tmpcokm)
        If de1.rsdarocode.RecordCount <> 0 Then
            kfound = 1
            '-----------------------------------------------
            '--------------------------------------------
            If Not IsDBNull(de1.rsdarocode.Fields("daro_pay").Value) Then txtprice.Text = de1.rsdarocode.Fields("daro_pay").Value
            If Not IsDBNull(de1.rsdarocode.Fields("daro_fname").Value) Then mh1.SetData(tmprow, 3, de1.rsdarocode.Fields("daro_fname").Value)
            '------------------------------------------'
            mh1.Col = 4
            ttp1 = Val(txtprice.Text)
            If Val(txtprice.Text) > 0 Then
                mh1.SetData(tmprow, 5, ttp1)
            End If
            '-----------------------------------------------
            tmpOrgPercenet = 0
            If de1.rsfindcond.State <> 0 Then de1.rsfindcond.Close()
            de1.findcond(tmpcokm, Val(txtCath.Text))
            If de1.rsfindcond.EOF = False Then
                If Not IsDBNull(de1.rsfindcond.Fields("bimeh_pay").Value) Then txtpricebimeh.Text = de1.rsfindcond.Fields("bimeh_pay").Value
                If Not IsDBNull(de1.rsfindcond.Fields("mot").Value) Then tmpOrgPercenet = de1.rsfindcond.Fields("mot").Value

                '--------------------------------------------
            Else
                txtpricebimeh.Text = 0
            End If
            mh1.SetData(tmprow, 20, tmpOrgPercenet)     ' save new percent Temp
            ttp2 = Val(txtpricebimeh.Text)
            mh1.SetData(tmprow, 6, ttp2)
            tstekht = ttp1 - ttp2
            If tstekht < 0 Then tstekht = 0
            mh1.SetData(tmprow, 8, tstekht)
            de1.rsfindcond.Close()
            testbim = 1
            If Val(txtCath.Text) = Val(txtfreecath.Text) Then
                testbim = 0
            End If
            If testbim = 0 Then
                mh1.SetData(tmprow, 6, 0)
                mh1.SetData(tmprow, 9, 0)
            End If
            '------------------------- new for daruye hamrah ----------------------
        End If
Gend:
        sdaro = kfound
    End Function

    Private Function IsDaroExist(ByVal tmpcokm As String) As Short
        Dim i As Object
        Dim urec As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        urec = 0
        For i = 1 To mh1.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(mh1.GetData(i, 2)) = Val(tmpcokm) Then 'col code=0
                'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                urec = 1
                Exit For
            End If
        Next i

        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        IsDaroExist = urec
    End Function
    Private Function IsDaroExistRow(ByVal tmpcokm As String, ByVal tmprow As Short) As Short
        Dim i As Object
        Dim urec As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        urec = 0
        For i = 1 To mh1.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(mh1.GetData(i, 2)) = Val(tmpcokm) And i <> tmprow Then 'col code=0
                'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                urec = 1
                Exit For
            End If
        Next i

        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        IsDaroExistRow = urec
    End Function

    Private Function FindBlankRow(ByRef trow As Short) As Short
        Dim i As Object
        Dim urec As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        urec = 0
        If trow = 0 Then trow = 1
        For i = trow To mh1.Rows.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Val(mh1.GetData(i, 2)) = 0 Then 'col code=0
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                urec = i
            End If
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If urec = 0 Then
            mh1.Rows.Count = mh1.Rows.Count + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            urec = mh1.Rows.Count - 1
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object urec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FindBlankRow = urec
    End Function
    Private Sub calcradif(ByRef tmprow As Short)
        Dim txtpayoneb As Object
        Dim abb As Object
        Dim testbim As Object
        Dim tact As Object
        Dim ttp2 As Object
        Dim ttp1 As Object


        txtnom.Text = CStr(Val(mh1.GetData(tmprow, 5)))
        '   If tmprow <= 0 Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object ttp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ttp1 = Val(txtprice.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object ttp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ttp2 = Val(txtpricebimeh.Text)

        If Val(txtprice.Text) > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ttp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mh1.SetData(tmprow, 6, ttp1)
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ttp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh1.SetData(tmprow, 8, ttp2)
        '------------------------------------------------------------------'
        'UPGRADE_WARNING: Couldn't resolve default property of object tact. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tact = Val(mh1.GetData(tmprow, 1))
        'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        testbim = 0
        Select Case tact
            Case 0
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = checkbimeh0()
            Case 1
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = checkbimeh0()
            Case 2 ' insert daro as orginal
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = checkbimeh0()
            Case 3
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = 0
            Case 4
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = 1
            Case 5
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = 0
            Case 6
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = 0
                mh1.SetData(tmprow, 13, 1) 'no fani
            Case 7
                'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                testbim = checkbimeh0()
        End Select



        'UPGRADE_WARNING: Couldn't resolve default property of object testbim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If testbim = 0 Then
            mh1.SetData(tmprow, 9, 0)
            mh1.SetData(tmprow, 8, 0)
            'UPGRADE_WARNING: Couldn't resolve default property of object ttp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ttp2 = 0
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object abb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        abb = Val(txtnom.Text) * Val(mh1.GetData(tmprow, 6))
        'UPGRADE_WARNING: Couldn't resolve default property of object abb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh1.SetData(tmprow, 7, System.Math.Round(abb, 0))
        'UPGRADE_WARNING: Couldn't resolve default property of object ttp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh1.SetData(tmprow, 9, ttp2 * Val(txtnom.Text))
        txtpaynone.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object txtpayoneb.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtpayoneb.Text = ""
    End Sub


    Private Function checkbimeh0() As Short
        Dim tmptip As Object
        Dim tmpbimpay As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpbimpay = 0
        If Val(txtpricebimeh.Text) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpbimpay = 0
            GoTo calcend
        End If
        If chkspmot.CheckState = 1 Then
            If de1.rsfindspmot.State <> 0 Then de1.rsfindspmot.Close()
            de1.findspmot(mh1.GetData(mh1.Row, 2), Val(txtcod_takh.Text))
            If de1.rsfindspmot.EOF = False Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpbimpay = 1
                GoTo calcend
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpbimpay = 0
                GoTo calcend
            End If
        End If
        '-----------    -------------------------------
        If chkbimeh.CheckState = 1 Then ' no bimeh
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpbimpay = 0
            GoTo calcend
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmptip = Val(txttip.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If tmptip = 1 Or tmptip = 2 Then
            If chkdoc.CheckState = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpbimpay = 1
                GoTo calcend
            End If
        End If
        Select Case Val(txttip.Text)
            Case 0
                If chkdoc.CheckState = 0 Then

                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If chkpay_add.CheckState = 1 Then tmpbimpay = 1
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '-----------------
            Case 1

                If chkmot.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '----------------
            Case 5
                If chkhsp.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '----------------
            Case 6
                If chkhspmot.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '----------------
            Case 3
                If chkden.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '----------------
            Case 4
                If chkmama.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '---------------
            Case 2
                If chkfog.CheckState = 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If chkmot.CheckState = 1 Then tmpbimpay = 1
                    GoTo calcend
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmpbimpay = 1
                    GoTo calcend
                End If
                '----------------
        End Select
calcend:
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpbimpay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        checkbimeh0 = tmpbimpay
    End Function


    Private Sub txtpmon_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub

    Private Sub Optsex_KeyDown(ByRef Index As Short, ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub

    Private Sub mh2_DblClick(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles mh2.DoubleClick
        Dim tmpcod As Object
        Dim i As Object
        Dim krow As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        krow = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        krow = mh1.Rows.Count - 1
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        i = mh2.Row
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpcod = Val(mh2.GetData(i, 0))

        'UPGRADE_WARNING: Couldn't resolve default property of object tmpcod. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If tmpcod > 0 Then
            mh1.Rows.Count = mh1.Rows.Count + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            krow = Val(krow) + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '            mh1.SetData(Val(krow), 0, mh2.GetData(i, 0))

            'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '          mh1.SetData(Val(krow), 1, mh2.GetData(i, 1))
            '           'UPGRADE_WARNING: Couldn't resolve default property of object krow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '         mh1.SetData(Val(krow), 4, mh2.GetData(i, 2))


        End If
        'Next i

    End Sub
    Private Sub Opttip_KeyDown(ByRef Index As Short, ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub



    Private Sub txtbimeh_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtbimeh.Enter
        txtbimeh.BackColor = lblcolor.BackColor
        txtbimeh.SelectionStart = 0
        txtbimeh.SelectionLength = Len(txtbimeh.Text)

    End Sub

    Private Sub txtbimeh_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtbimeh.Leave
        Dim tmp1 As Object
        Dim msg As Object
        txtbimeh.BackColor = lblcolor1.BackColor
        If Len(txtbimeh.Text) > 20 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "کد بیمه شده اشتباه است"
            MsgBox(msg, MsgBoxStyle.Information)
            txtbimeh.SelectionLength = Len(txtbimeh.Text)
            txtbimeh.SelectionStart = 0
            txtbimeh.Focus()
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp1 = Mid(Trim(txtbimeh.Text), 1, 3)
        If chkbimar.CheckState = 1 Then
            If de1.rsfindbim.State <> 0 Then de1.rsfindbim.Close()
            de1.findbim((txtbimeh.Text))
            If de1.rsfindbim.EOF = False Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(de1.rsfindbim.Fields("Name").Value) Then txtname.Text = de1.rsfindbim.Fields("Name").Value

            Else
                txtname.Text = ""

            End If
            de1.rsfindbim.Close()
        Else

        End If
    End Sub




    Private Sub txtbmeli_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub





    Private Sub txtcath_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtCath.Enter

        txtCath.SelectionStart = 0
        txtCath.SelectionLength = Len(txtCath.Text)



    End Sub

    Private Sub txtcath_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCath.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Dim msg As Object
        Dim a As Object

        If KeyCode = 39 Then
            '
            If mh4.Row > 0 Then
                mh4.Row = mh4.Row - 1
                txtCath.Text = mh4.GetData(mh4.Row, 0)
                lblC2.Text = mh4.GetData(mh4.Row, 1)

                txtCath.SelectionStart = 0
                txtCath.SelectionLength = Len(txtCath.Text)
            End If

        End If
        If KeyCode = 37 Then
            If mh4.Row < mh4.Rows.Count - 1 Then
                mh4.Row = mh4.Row + 1
                txtCath.Text = mh4.GetData(mh4.Row, 0)
                lblC2.Text = mh4.GetData(mh4.Row, 1)

                txtCath.SelectionStart = 0
                txtCath.SelectionLength = Len(txtCath.Text)
            End If

        End If



        Select Case KeyCode
            Case 40
                System.Windows.Forms.SendKeys.Send("{TAB}")

            Case 46 '
                txtCath.Text = ""
                lblC2.Text = ""
            Case 113 'f2
                If chktad.CheckState = 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    a = MsgBox("نسخه نیاز به تایید دارد مطمئن هستید؟", MsgBoxStyle.YesNo)
                    If a <> MsgBoxResult.Yes Then
                        Exit Sub
                    End If
                End If
                '-----------------------------------------------------
                If ControlMe() = 0 Then Exit Sub
                savedetail((0))
                cmdnew_Click(cmdnew, New System.EventArgs)
            Case 114 'f3
                MakeFish(1)

            Case 116 'f5
                frmdcode.Show()
            Case 118 'f7
                If ControlMe() = 0 Then Exit Sub
                savedetail((1))
                dojob((1))
                cmdnew_Click(cmdnew, New System.EventArgs)
            Case 121 'f10
                MsgBox(" برای انتخاب داروی ترکیبی برروی یکی از ردیفهای خالی نسخه کلیک نمایید", MsgBoxStyle.Critical)
                Exit Sub

            Case 33 ' blank for show befor
                cmdleft_Click(cmdleft, New System.EventArgs)
                mh1.Row = 1
            Case 34 ' blank for show befor
                cmdright_Click(cmdright, New System.EventArgs)
                mh1.Row = 1
            Case 32 ' blank for show befor
                cmdright_Click(cmdright, New System.EventArgs)
                mh1.Row = 1
            Case 13 ' enter
                GetCath(Val(txtCath.Text))
                System.Windows.Forms.SendKeys.Send("{TAB}")
                StrKey = ""
                mh1.Row = 1
            Case 27

                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msg = "نسخه جدید را شروع میکنید؟"
                'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                a = 7
                'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                a = MsgBox(msg, MsgBoxStyle.YesNo)
                If a = MsgBoxResult.Yes Then
                    cmdnew_Click(cmdnew, New System.EventArgs)
                End If
        End Select
    End Sub

    Private Sub txtCath_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCath.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        'If KeyAscii >= 48 And KeyAscii <= 57 Then
        '       aa = Chr(KeyAscii)
        '       StrKey = StrKey + aa
        '       ll = Len(StrKey)
        '       trow = 0
        '       kf = 0
        'For i = 0 To mh4.Rows - 1
        '   tmpcod = Mid(mh4.TextMatrix(i, 0), 1, ll)
        '   If tmpcod = aa Then
        '      mh4.Row = i
        '      txtcath.Text = mh4.TextMatrix(mh4.Row, 0)
        '      lblC2 = mh4.TextMatrix(mh4.Row, 1)
        '      txtcath.BackColor = lblcolor.BackColor
        '      txtcath.SelStart = 0
        '      txtcath.SelLength = Len(txtcath.Text)
        '      StrKey = tmpcod
        '      kf = 1
        '      Exit For
        '   End If
        '
        'Next i
        'If kf = 0 Then StrKey = ""
        'End If
        'If KeyAscii = vbKeyTab Or KeyAscii = 13 Then
        'Else
        'KeyAscii = 0
        'End If
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub



    'UPGRADE_WARNING: Event txtcod_takh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtcod_takh_TextChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcod_takh.TextChanged
        txttkhs_name.Text = ""
        If de1.rsfindbdtakh.State <> 0 Then de1.rsfindbdtakh.Close()
        de1.findbdtakh((txtcod_takh.Text))
        If de1.rsfindbdtakh.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindbdtakh.Fields("tkhs_Name").Value) Then txttkhs_name.Text = de1.rsfindbdtakh.Fields("tkhs_Name").Value
        End If
        de1.rsfindbdtakh.Close()

    End Sub

    Private Sub txtcodejanbaz_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtcodejanbaz_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        mh1.Focus()
    End Sub

    Private Sub txtcodmeli_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcodmeli.Enter

        txtcodmeli.BackColor = lblcolor.BackColor
    End Sub

    Private Sub txtcodmeli_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodmeli.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtcodmeli_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtcodmeli.Leave
        txtcodmeli.BackColor = lblcolor1.BackColor
    End Sub

    Private Sub txtdoc_name_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdoc_name.Enter
        txtnezam.BackColor = lblcolor.BackColor
        keybfarsi()
        txtdoc_name.SelectionStart = 0
        txtdoc_name.SelectionLength = Len(txtdoc_name.Text)

    End Sub


    Private Sub txtdoc_name_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdoc_name.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Select Case KeyCode
            Case 38 'up arrow
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            Case 40
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 27
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Else
                hotkey(KeyCode, 0)
        End Select


    End Sub

    Private Sub txtdoc_name_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdoc_name.Leave
        On Error Resume Next
        cbosex.Focus()
    End Sub

    'UPGRADE_WARNING: Event txtmonth.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtmonth_TextChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtmonth.TextChanged
        Dim aa As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aa = txtmonth.Text
    End Sub

    Private Sub txtmonth_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtmonth.Enter
        txtmonth.BackColor = lblcolor.BackColor
    End Sub

    Private Sub txtname_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtname.Leave
        txtname.BackColor = lblcolor1.BackColor
        If chkbimar.CheckState = 1 Then
            If de1.rsfindbim.State <> 0 Then de1.rsfindbim.Close()
            de1.findbim((txtbimeh.Text))
            If de1.rsfindbim.EOF = True Then
                de1.rsfindbim.AddNew()
                de1.rsfindbim.Fields("bimeh").Value = txtbimeh.Text
                de1.rsfindbim.Fields("Name").Value = txtname.Text
                de1.rsfindbim.Update()
            End If
            de1.rsfindbim.Close()
        End If

    End Sub

    Private Sub txtnezam_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnezam.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Dim a1 As Object
        If KeyAscii = 13 Then GoTo EventExitSub
        If KeyAscii = 8 Then GoTo EventExitSub
        'UPGRADE_WARNING: Couldn't resolve default property of object a1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a1 = Chr(KeyAscii)
        'UPGRADE_WARNING: Couldn't resolve default property of object a1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If a1 = "*" Then GoTo EventExitSub
        'UPGRADE_WARNING: Couldn't resolve default property of object a1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If a1 >= "0" And a1 <= "9" Then
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object a1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'frmdocxlist.mh6.setdata(1, 0, a1)
            'frmdocxlist.txtproc.Text = CStr(1)
            'frmdocxlist.Show()
        End If

EventExitSub:
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnomlist_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtnomlist.Enter
        txtnomlist.BackColor = lblcolor.BackColor
        txtnomlist.SelectionStart = 0
        txtnomlist.SelectionLength = Len(txtnomlist.Text)

    End Sub

    Private Sub txtnomlist_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomlist.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtnomlist_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtnomlist.Leave
        txtnomlist.BackColor = lblcolor1.BackColor
        If de1.rsbrow_phadetail.State <> 0 Then de1.rsbrow_phadetail.Close()
        de1.brow_phadetail(Val(txtmonth.Text), Val(txtCath.Text), Val(txtnomlist.Text))
        If de1.rsbrow_phadetail.RecordCount > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phadetail.Fields("number").Value) Then txtradif.Text = de1.rsbrow_phadetail.Fields("number").Value
            txtradif_Leave(txtradif, New System.EventArgs)
        Else
            MsgBox("شماره لیست پیدا نشد", MsgBoxStyle.Critical)
            GoTo nofound


        End If
        ' de1.rsbrow_phadetail.Close()
        Exit Sub
nofound:
        On Error Resume Next
        cmdnew_Click(cmdnew, New System.EventArgs)
    End Sub

    Private Sub txtpage_no_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtpage_no.Enter
        txtpage_no.BackColor = lblcolor.BackColor
        txtpage_no.SelectionStart = 0
        txtpage_no.SelectionLength = Len(txtpage_no.Text)

    End Sub

    Private Sub txtpage_no_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpage_no.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)

    End Sub

    Private Sub txtpage_no_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtpage_no.Leave
        txtpage_no.BackColor = lblcolor1.BackColor
    End Sub

    Private Sub txtpaynone_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtpaynone_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        mh1.SetData(mh1.Row, 5, 1)
        mh1.SetData(mh1.Row, 6, txtpaynone.Text)
        If Val(mh1.GetData(mh1.Row, 1)) = 7 Then
            txtpaynoneb.Focus()
        Else
            mh1.Focus()
        End If
    End Sub

    Private Sub txtpaynoneb_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtpaynoneb_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        mh1.SetData(mh1.Row, 8, txtpaynoneb.Text)
        mh1.Focus()
    End Sub
    Private Sub txtprice_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub



    Private Sub txtproc_TextChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtproc.TextChanged
        Dim a As Object
        On Error Resume Next
        Select Case Val(txtproc.Text)
            Case 1
                GetCath(Val(txtCath.Text))
                txtCath.Focus()
            Case 2


                a = sdaro(0)
                mh1.Col = 5
            Case 3
                txtradif_Leave(txtradif, New System.EventArgs)

           
            Case 110
                mh1.Focus()
        End Select
        txtproc.Text = ""
    End Sub






    Private Sub GetCath(ByVal iCath As Short)
        Dim t1 As Object
        Dim chkmeliValue As Object
        Dim chkbimehValue As Object
        Dim chkdateValue As Object
        Dim chknezamValue As Object
        Dim chkbimarValue As Object
        Dim chkpageValue As Object
        Dim chktaanValue As Object
        Dim tmporgan_code As Object


        txtnprint.Text = ""
        chkazad.CheckState = System.Windows.Forms.CheckState.Unchecked
        txtfhaz.Text = CStr(0)
        chkfanitip.CheckState = System.Windows.Forms.CheckState.Unchecked
        txtcodmeli.Enabled = False
        lblC2.Text = ""
        If de1.rsfindcath.State <> 0 Then de1.rsfindcath.Close()
        de1.findcath(iCath)
        If de1.rsfindcath.EOF = False Then

            If Not IsDBNull(de1.rsfindcath.Fields("organ_code").Value) Then tmporgan_code = de1.rsfindcath.Fields("organ_code").Value
            If Not IsDBNull(de1.rsfindcath.Fields("Name").Value) Then lblC2.Text = de1.rsfindcath.Fields("Name").Value
            If Not IsDBNull(de1.rsfindcath.Fields("org").Value) Then txtperc.Text = de1.rsfindcath.Fields("org").Value
            If Not IsDBNull(de1.rsfindcath.Fields("bimar").Value) Then txtperb.Text = de1.rsfindcath.Fields("bimar").Value
            If Not IsDBNull(de1.rsfindcath.Fields("nprint").Value) Then txtnprint.Text = de1.rsfindcath.Fields("nprint").Value
            If Not IsDBNull(de1.rsfindcath.Fields("paydoc").Value) Then txtpaydoc.Text = de1.rsfindcath.Fields("paydoc").Value
            If Not IsDBNull(de1.rsfindcath.Fields("paymot").Value) Then txtpaymot.Text = de1.rsfindcath.Fields("paymot").Value
            If Not IsDBNull(de1.rsfindcath.Fields("payden").Value) Then txtpayden.Text = de1.rsfindcath.Fields("payden").Value
            If Not IsDBNull(de1.rsfindcath.Fields("paymama").Value) Then txtpaymama.Text = de1.rsfindcath.Fields("paymama").Value
            If Not IsDBNull(de1.rsfindcath.Fields("fhaz").Value) Then txtfhaz.Text = de1.rsfindcath.Fields("fhaz").Value
            If Not IsDBNull(de1.rsfindcath.Fields("fanitip").Value) Then chkfanitip.CheckState = de1.rsfindcath.Fields("fanitip").Value

            If Not IsDBNull(de1.rsfindcath.Fields("chktaan").Value) Then chktaanValue = de1.rsfindcath.Fields("chktaan").Value
            If Not IsDBNull(de1.rsfindcath.Fields("chkpage").Value) Then chkpageValue = de1.rsfindcath.Fields("chkpage").Value
            If Not IsDBNull(de1.rsfindcath.Fields("chkbimar").Value) Then chkbimarValue = de1.rsfindcath.Fields("chkbimar").Value
            If Not IsDBNull(de1.rsfindcath.Fields("chknezam").Value) Then chknezamValue = de1.rsfindcath.Fields("chknezam").Value
            If Not IsDBNull(de1.rsfindcath.Fields("chkdate").Value) Then chkdateValue = de1.rsfindcath.Fields("chkdate").Value
            If Not IsDBNull(de1.rsfindcath.Fields("chkbimeh").Value) Then chkbimehValue = de1.rsfindcath.Fields("chkbimeh").Value
            If Not IsDBNull(de1.rsfindcath.Fields("bwork").Value) Then chkbwork.CheckState = de1.rsfindcath.Fields("bwork").Value
            t1 = 0
            chkpay_add.CheckState = System.Windows.Forms.CheckState.Unchecked
            If Not IsDBNull(de1.rsfindcath.Fields("pay_add").Value) Then t1 = de1.rsfindcath.Fields("pay_add").Value ' for daro takhsosi
            If t1 = 1 Then chkpay_add.CheckState = System.Windows.Forms.CheckState.Checked
            mdate.Enabled = True
            txtpage_no.Enabled = True
            txtname.Enabled = True
            txtnezam.Enabled = False
            txtdate.Enabled = True
            txtbimeh.Enabled = True
            cbosex.Enabled = True
            If chkmeliValue = 1 Then txtcodmeli.Enabled = True
            If chktaanValue = 1 Then mdate.Enabled = False
            If chkpageValue = 1 Then txtpage_no.Enabled = False
            If chkbimarValue = 1 Then txtname.Enabled = False

            If chkdateValue = 1 Then txtdate.Enabled = False
            If chkbimehValue = 1 Then txtbimeh.Enabled = False
        Else
            lblC2.Text = "کد اشتباه است"
        End If
        de1.rsfindcath.Close()

        readprinttip()
    End Sub
    Private Sub ChangeRowZeroWithN(ByRef n As Short)
        Dim k2 As Object
        Dim k1 As Object
        Dim t2 As Object
        Dim t1 As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        t1 = mh4.GetData(0, 0)
        'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        t2 = mh4.GetData(0, 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object k1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        k1 = mh4.GetData(n, 0)
        'UPGRADE_WARNING: Couldn't resolve default property of object k2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        k2 = mh4.GetData(n, 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object k1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh4.SetData(0, 0, k1)
        'UPGRADE_WARNING: Couldn't resolve default property of object k2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh4.SetData(0, 1, k2)
        'UPGRADE_WARNING: Couldn't resolve default property of object t1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh4.SetData(n, 0, t1)
        'UPGRADE_WARNING: Couldn't resolve default property of object t2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mh4.SetData(n, 1, t2)
        'mh4.ScrollBars = VSFlex7L.ScrollBarsSettings.flexScrollBarNone
        mh4.Row = 0
        'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'mh4.CtlRefresh()
    End Sub
    Private Sub txtbimeh_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbimeh.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtcode_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub

    Private Sub cmdright_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdright.Click
        Dim tmpradif As Object
        If de1.rsshownumber.State <> 0 Then de1.rsshownumber.Close()
        de1.shownumber(Val(txtmonth.Text))
        If de1.rsshownumber.EOF = False Then
            de1.rsshownumber.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshownumber.Fields("number").Value

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = 1
        End If
        de1.rsshownumber.Close()
        If Val(txtradif.Text) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtradif.Text = tmpradif
            txtradif_Leave(txtradif, New System.EventArgs)

        Else
            If Val(txtradif.Text) > 1 Then
                txtradif.Text = CStr(Val(txtradif.Text) - 1)
            End If

            txtradif_Leave(txtradif, New System.EventArgs)


        End If
        mh1.Row = 1
    End Sub
    Private Sub cmdleft_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdleft.Click
        Dim tmpradif As Object
        If de1.rsshownumber.State <> 0 Then de1.rsshownumber.Close()
        de1.shownumber(Val(txtmonth.Text))
        If de1.rsshownumber.EOF = False Then
            de1.rsshownumber.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshownumber.Fields("number").Value

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = 1
        End If
        de1.rsshownumber.Close()

        If Val(txtradif.Text) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtradif.Text = tmpradif
            txtradif_Leave(txtradif, New System.EventArgs)

        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Val(txtradif.Text) < tmpradif Then
            txtradif.Text = CStr(Val(txtradif.Text) + 1)
            txtradif_Leave(txtradif, New System.EventArgs)
        End If
        mh1.Row = 1
    End Sub
    Private Sub cmdprint_Click()
        dojob((1))

    End Sub

    Private Sub hotkey(ByRef KeyCode As Short, ByRef Shift As Short)
        Dim a As Object
        Dim msg As Object
        Select Case KeyCode
            Case 38 'up arrow
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            Case 40
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 27

                'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

                msg = "نسخه جدید را شروع میکنید؟"
                'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                a = 7
                'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                a = MsgBox(msg, MsgBoxStyle.YesNo)
                If a = MsgBoxResult.Yes Then
                    cmdnew_Click(cmdnew, New System.EventArgs)
                End If
            Case 33 'pgup
                cmdleft_Click(cmdleft, New System.EventArgs)
                mh1.Row = 1
            Case 34 'pgdn
                cmdright_Click(cmdright, New System.EventArgs)
                mh1.Row = 1
            Case 107 '+
                If ControlMe() = 0 Then Exit Sub
                savedetail((0))
                cmdnew_Click(cmdnew, New System.EventArgs)

            Case 109 '-
            Case 106 '*
            Case 111 '/
            Case 112 'f1
                showlist()
            Case 113 'f2
                If ControlMe() = 0 Then Exit Sub
                If chktad.CheckState = 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    a = MsgBox("نسخه نیاز به تایید دارد مطمئن هستید؟", MsgBoxStyle.YesNo)
                    If a <> MsgBoxResult.Yes Then
                        Exit Sub
                    End If
                End If
                '-----------------------------------------------------
                savedetail((0))
                cmdnew_Click(cmdnew, New System.EventArgs)
            Case 114 'f3
                cmdFishcath_Click(cmdfishcath, New System.EventArgs)
            Case 115 'f4

            Case 116 'f5
                frmdcode.Show()
            Case 117 'f6
                cmddel_Click(cmddel, New System.EventArgs)
            Case 118 'f7
                If ControlMe() = 0 Then Exit Sub
                savedetail((1))
                dojob((1))
                cmdnew_Click(cmdnew, New System.EventArgs)
            Case 119 'f8

            Case 120 'f9
            Case 121 'f10
                MsgBox("برای داروی ترکیبی برروی یکی از ردیفهای خالی نسخه کلیک نمایید", MsgBoxStyle.Critical)
                Exit Sub
                'Case 122  'f12
                'changesr

                '--------------------------------------------------------------


        End Select
    End Sub
    
    Private Sub txtdoctor_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub
    Private Sub txtcotd_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtcotd_LostFocus()
        If cmdsave.Enabled = True Then cmdsave.Focus()
    End Sub

    Private Sub txtdate_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdate.Enter
        Dim tmpd As Object
        txtdate.BackColor = lblcolor.BackColor
        tmpd = Val(Mid(txtdate.Text, 9, 2))
        If tmpd > 0 Then
        Else
            If chkfound.CheckState = 0 Then
                dodate()
            End If
        End If
        txtdate.SelectionStart = 8
        txtdate.SelectionLength = 2

    End Sub
    Private Function DateLock() As Object

        If txtdate.Text >= MainForm.txtActiveDate.Text Then
            'Me.Close()
        End If
    End Function
    Private Sub txtdate_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtdate.Leave
        Dim ld2 As Object
        Dim ld1 As Object
        Dim a As Object
        Dim tmp1 As Object
        Dim tmpa As Object
        Dim tmpd As Object
        Dim msg As Object
        Dim mmm As Object
        txtdate.BackColor = lblcolor1.BackColor

        mmm = DateLock()
        If Len(txtdate.Text) > 10 Then

            msg = "تاریخ را اشتباه وارد کرده اید "
            MsgBox(msg, MsgBoxStyle.Information)
            txtdate.Focus()
            Exit Sub
        End If

        tmpd = Val(Mid(txtdate.Text, 9, 3))

        If tmpd > 31 Then


            msg = "تاریخ را اشتباه وارد کرده اید "
            MsgBox(msg, MsgBoxStyle.Information)

            txtdate.Focus()
            Exit Sub
        End If

        If tmpd = 0 Then
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpa = Mid(txtdate.Text, 9, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If (tmpd >= 1 And tmpd <= 9) And tmpa <> "0" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                txtdate.Text = Mid(txtdate.Text, 1, 8) & "0" & Trim(Str(tmpd))
            End If
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp1 = Mid(txtdate.Text, 6, 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Val(tmp1) <> Val(txtmonth.Text) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "ماه ثبت با تاریخ روز نسخه مغایرت دارد ماه ثبت اصلاح گردد؟  "
            'UPGRADE_WARNING: MsgBox Parameter 'context' is not supported, and was removed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
            'UPGRADE_WARNING: MsgBox Parameter 'helpfile' is not supported, and was removed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            a = MsgBox(msg, MsgBoxStyle.YesNo, "")
            If a = MsgBoxResult.Yes Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                txtmonth.Text = CStr(Val(tmp1))
            End If


        End If
        If (mdate.Enabled = False) Then GoTo nochk
        'UPGRADE_WARNING: Couldn't resolve default property of object ld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ld1 = Mid(txttaan.Text, 1, 4) & Mid(txttaan.Text, 6, 2) & Mid(txttaan.Text, 9, 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object ld2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ld2 = Mid(txtdate.Text, 1, 4) & Mid(txtdate.Text, 6, 2) & Mid(txtdate.Text, 9, 2)

        'UPGRADE_WARNING: Couldn't resolve default property of object ld2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Val(ld1) < Val(ld2) Then
            'lblmsg.Caption = "ÝÇÞÏ ÇÚÊÈÇÑ"
            If chkbwork.CheckState = 0 Then
                MsgBox("نسخه فاقد اعتبار میباشد ", MsgBoxStyle.Critical)
                GoTo nochk
            End If
            'UPGRADE_WARNING: MsgBox Parameter 'context' is not supported, and was removed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
            'UPGRADE_WARNING: MsgBox Parameter 'helpfile' is not supported, and was removed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            a = MsgBox("تاریخ اعتبار نسخه اشکال دارد بصورت آزاد حساب گردد؟", MsgBoxStyle.YesNo, "")

            If a = MsgBoxResult.Yes Then
                txtCath.Text = txtfreecath.Text
                cmdcalcrep_Click(cmdcalcrep, New System.EventArgs)
                mh1.Row = 1
            End If
        Else

        End If
nochk:
        'mh1.Col = 2

    End Sub

    Private Sub txtfamil_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub




    Private Sub txtfree_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub
    Private Sub txtdate_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdate.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        On Error Resume Next
        Select Case KeyCode
            Case 33 'pgup
                '   txtdate.Text = MESHAMSI.IncreaseDate(txtdate.Text)

            Case 34 'pgdn
                '  txtdate.Text = MESHAMSI.DecreaseDate(txtdate.Text)
            Case 38 'up arrow
                System.Windows.Forms.SendKeys.Send("+{TAB}")

            Case 40

                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 13

                System.Windows.Forms.SendKeys.Send("{TAB}")

            Case 27

                System.Windows.Forms.SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub txtdate2_Change()
        Dim txtdate1 As Object
        Dim txtdate2 As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object txtdate2.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object txtdate1.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtdate.Text = Trim(txtdate1.Text) & Trim(txtdate2.Text)
    End Sub

    Private Sub txtdate2_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub




    Private Sub txtmonth_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtmonth.Leave
        Dim tmpv1 As Object
        Dim msg As Object
        txtmonth.BackColor = lblcolor1.BackColor
        If Val(txtmonth.Text) > 12 Or Val(txtmonth.Text) < 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "ãÇå ÓäÏ ÇÔÊÈÇå ÇÓÊ ..."
            MsgBox(msg, MsgBoxStyle.Critical)
            If txtmonth.Enabled = True Then
                txtmonth.Focus()
            End If
            Exit Sub
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpv1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmpv1 = 0
        mh1.Focus()
    End Sub
    Private Sub showradif()
        Dim tmpradif As Object
        '******************************************
        clsNos()
        If de1.rsshownumber.State <> 0 Then de1.rsshownumber.Close()
        de1.shownumber(Val(txtmonth.Text))
        If de1.rsshownumber.EOF = False Then
            de1.rsshownumber.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshownumber.Fields("number").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtradif.Text = tmpradif
        Else
            txtradif.Text = CStr(1)
        End If
        de1.rsshownumber.Close()

    End Sub

    Private Sub getradif()
        Dim tmpradif As Object

        If de1.rsshownumber.State <> 0 Then de1.rsshownumber.Close()
        de1.shownumber(Val(txtmonth.Text))
        If de1.rsshownumber.EOF = False Then
            de1.rsshownumber.MoveLast()
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpradif = de1.rsshownumber.Fields("number").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpradif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtradif.Text = tmpradif + 1
        Else
            txtradif.Text = CStr(1)
        End If
        de1.rsshownumber.Close()

    End Sub



    Private Sub txtmonth_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmonth.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        If KeyCode = 13 Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If

    End Sub



    Private Sub txtna_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub


    Private Sub txtnom_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnom.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtname_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtname.Enter
        txtname.BackColor = lblcolor.BackColor
        keybfarsi()
    End Sub

    Private Sub txtname_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        If KeyCode = 46 Then
            txtname.Text = ""
            Exit Sub
        End If
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtostan_Change()
        Dim cboostan As Object
        Dim txtostan As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cboostan.BoundText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object txtostan.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboostan.BoundText = Val(txtostan.Text)
    End Sub

    Private Sub txtostan_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txtnezam_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtnezam.Enter
        txtnezam.BackColor = lblcolor.BackColor
        txtnezam.SelectionStart = 0
        txtnezam.SelectionLength = Len(txtnezam.Text)

    End Sub

    Private Sub txtnezam_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnezam.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Select Case KeyCode
            Case 38 'up arrow
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            Case 40
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 13
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case 27
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Else
                hotkey(KeyCode, 0)
        End Select

    End Sub

    Private Sub txtnezam_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtnezam.Leave
        Dim tmptip As Object
        Dim tmp2 As Object
        Dim tmp1 As Object
        Dim tmpcokm As Object
        Dim tvcode As Object
        txtnezam.BackColor = lblcolor1.BackColor
        If Mid(txtnezam.Text, 1, 2) = "0*" Then GoTo M2
        If Val(txtnezam.Text) = 0 Then Exit Sub
M2:
        On Error Resume Next
        If de1.rsfindvcode.State <> 0 Then de1.rsfindvcode.Close()
        'UPGRADE_WARNING: Couldn't resolve default property of object tvcode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tvcode = txtnezam.Text
        de1.findvcode(tvcode, 1)
        If de1.rsfindvcode.EOF = False Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsfindvcode.Fields("daro_code").Value) Then tmpcokm = de1.rsfindvcode.Fields("daro_code").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpcokm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtnezam.Text = tmpcokm
        End If


        ' txtdoc_name.Text = ""
        txtcod_takh.Text = ""
        If Len(Trim(txtnezam.Text)) = 0 Then Exit Sub
        If de1.rsfindbdhosp.State <> 0 Then de1.rsfindbdhosp.Close()
        de1.findbdhosp((txtnezam.Text))
        If de1.rsfindbdhosp.EOF = False Then
            chkdocfound.CheckState = System.Windows.Forms.CheckState.Checked
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmp1 = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmp2 = ""

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsfindbdhosp.Fields("famil").Value) Then tmp2 = de1.rsfindbdhosp.Fields("famil").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindbdhosp.Fields("tkhs_code").Value) Then txtcod_takh.Text = de1.rsfindbdhosp.Fields("tkhs_code").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ' txtdoc_name.Text = Trim(tmp2)
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmptip = 0
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not IsDBNull(de1.rsfindbdhosp.Fields("tip").Value) Then tmptip = de1.rsfindbdhosp.Fields("tip").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsfindbdhosp.Fields("nezam").Value) Then txtnezam.Text = de1.rsfindbdhosp.Fields("nezam").Value

            'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmptip >= 0 And tmptip <= 4 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                cbosex.SelectedIndex = tmptip
                'UPGRADE_WARNING: Couldn't resolve default property of object tmptip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                txttip.Text = tmptip

            Else
                cbosex.SelectedIndex = 0
                txttip.Text = CStr(0)
            End If
        Else
            chkdocfound.CheckState = System.Windows.Forms.CheckState.Unchecked

        End If
        If chkdocfound.CheckState = 0 Then
            txtdoc_name.Focus()
        End If
    End Sub

    Private Sub Showtip()
        Dim i As Short ' Counter
        'Dim PaperOrientation As CRPaperOrientation
        Addcbo(cbosex, "0زن", 0)
        Addcbo(cbosex, "1مرد", 1)

    End Sub




    Private Sub txtradif_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtradif.Enter
        txtradif.BackColor = lblcolor.BackColor
        txtradif.SelectionStart = 0
        txtradif.SelectionLength = Len(txtradif.Text)

    End Sub

    Private Sub txtradif_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtradif.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub
    Private Sub clear_kasr()
    End Sub

    Private Sub txtradif_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtradif.Leave
        txtradif.BackColor = lblcolor1.BackColor
        clsgrid2()
        'On Error GoTo noFocus
        cbosex.SelectedIndex = 0
        txtcod_takh.Text = ""
        txtname.Text = ""
        tottot.Text = ""
        txtorg.Text = ""
        txtbimar.Text = ""
        txtfani.Text = ""
        txtfree.Text = ""
        txtcoka.Text = ""

        txtbimeh.Text = ""

        txttaan.Text = ""
        txtdate.Text = ""

        txttip.Text = ""
        txtvaz.Text = 0
        txtnomlist.Text = ""
        txtcodmeli.Text = ""
        txtCath.Text = ""
        txtpage_no.Text = ""

        'Label1(5).Text = ""
        If de1.rsbrow_phanumber.State <> 0 Then de1.rsbrow_phanumber.Close()
        de1.brow_phanumber(Val(txtmonth.Text), Val(txtradif.Text))
        If de1.rsbrow_phanumber.RecordCount > 0 Then
            mh2.SetData(11, 1, Val(txtradif.Text))
            chkfound.CheckState = System.Windows.Forms.CheckState.Checked
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("na").Value) Then txtname.Text = de1.rsbrow_phanumber.Fields("na").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("radif").Value) Then txtnomlist.Text = de1.rsbrow_phanumber.Fields("radif").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("tot").Value) Then tottot.Text = de1.rsbrow_phanumber.Fields("tot").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("org").Value) Then txtorg.Text = de1.rsbrow_phanumber.Fields("org").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("bimar").Value) Then txtbimar.Text = de1.rsbrow_phanumber.Fields("bimar").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("fani").Value) Then txtfani.Text = de1.rsbrow_phanumber.Fields("fani").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("tafavot").Value) Then txtfree.Text = de1.rsbrow_phanumber.Fields("tafavot").Value

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("coka").Value) Then txtcoka.Text = de1.rsbrow_phanumber.Fields("coka").Value
            showKarbar((Val(txtcoka.Text)))
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            ' If Not IsDBNull(de1.rsbrow_phanumber.Fields("doc_name").Value) Then txtdoc_name.Text = de1.rsbrow_phanumber.Fields("doc_name").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("coseshbs").Value) Then txtbimeh.Text = de1.rsbrow_phanumber.Fields("coseshbs").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("codmeli").Value) Then txtcodmeli.Text = de1.rsbrow_phanumber.Fields("codmeli").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("cath").Value) Then txtCath.Text = de1.rsbrow_phanumber.Fields("cath").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("taan").Value) Then txttaan.Text = de1.rsbrow_phanumber.Fields("taan").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("page_no").Value) Then txtpage_no.Text = de1.rsbrow_phanumber.Fields("page_no").Value
            GetCath((Val(txtCath.Text)))
            putdate()
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("datee").Value) Then txtdate.Text = de1.rsbrow_phanumber.Fields("datee").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("tim").Value) Then mh2.SetData(9, 1, de1.rsbrow_phanumber.Fields("tim").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("tasb").Value) Then mh2.SetData(10, 1, de1.rsbrow_phanumber.Fields("tasb").Value)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            ' If Not IsDBNull(de1.rsbrow_phanumber.Fields("nezam").Value) Then txtnezam.Text = de1.rsbrow_phanumber.Fields("nezam").Value
            'txtnezam_Leave(txtnezam, New System.EventArgs)
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("tip").Value) Then txttip.Text = de1.rsbrow_phanumber.Fields("tip").Value
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("sex").Value) Then tmpsex = de1.rsbrow_phanumber.Fields("sex").Value
            If Not IsDBNull(de1.rsbrow_phanumber.Fields("vaz").Value) Then txtvaz.Text = de1.rsbrow_phanumber.Fields("vaz").Value
            If tmpsex = 0 Or tmpsex = 1 Then
                cbosex.SelectedIndex = tmpsex
            End If
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'

            de1.rsbrow_phanumber.Close()
        End If
        fillgrid()
        On Error Resume Next
        mh1.Focus()
noFocus:
    End Sub

    Private Sub putdate()
        Dim D1 As Object
        Dim ltmp As Object
        Dim tmp1 As Object
        On Error GoTo notdo
        'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp1 = Trim(txttaan.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object ltmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ltmp = Len(tmp1)
        'UPGRADE_WARNING: Couldn't resolve default property of object ltmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If ltmp = 0 Then GoTo notdo
        'UPGRADE_WARNING: Couldn't resolve default property of object ltmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If ltmp <= 6 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            D1 = "13" & Mid(tmp1, 1, 2) & "/" & Mid(tmp1, 3, 2) & "/" & Mid(tmp1, 5, 2)
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdate.Text = D1
            GoTo endp
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ltmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If ltmp = 8 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            D1 = Mid(tmp1, 1, 4) & "/" & Mid(tmp1, 5, 2) & "/" & Mid(tmp1, 7, 2)
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdate.Text = D1
            GoTo endp
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ltmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If ltmp = 10 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmp1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            D1 = tmp1
            'UPGRADE_WARNING: Couldn't resolve default property of object D1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdate.Text = D1
            GoTo endp
        End If
notdo:
        mdate.Text = "13  /  /  "
endp:
    End Sub
    Private Sub txttaan_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txttaan.Enter
        txttaan.Text = Trim(txttaan.Text)
        txttaan.SelectionStart = 0
        txttaan.SelectionLength = Len(txttaan.Text)
    End Sub

    Private Sub txttaan_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttaan.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode, 0)
    End Sub

    Private Sub txttaan_Leave(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txttaan.Leave
        Dim msg As Object
        If Len(Trim(txttaan.Text)) = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msg = "ÊÇÑíÎ ÇÚÊÈÇÑ ÏÑÓÊ æÇÑÏ äÔÏå ÇÓÊ"
            MsgBox(msg, MsgBoxStyle.Information)
            '    txttaan.SetFocus
        End If
    End Sub

    'UPGRADE_WARNING: Event txttip.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'

    Private Sub txtdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mh1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtpage_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpage_no.TextChanged

    End Sub





    Private Sub cmdPerFerazh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPerFerazh.Click
        savedetail((1))
        dojob((0))
        cmdnew_Click(cmdnew, New System.EventArgs())
    End Sub




    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click

        chkfound.CheckState = System.Windows.Forms.CheckState.Unchecked
        '------------------------------
        txtnezam.Enabled = False
        txtbimeh.Enabled = True
        txtname.Enabled = True
        txttaan.Enabled = True
        txtcodmeli.Enabled = False
        clsgrid2()
        txtmonth.Text = MainForm.txtmonth.Text
        dodate()
        clsNos()
        txtradif.Text = ""
        On Error Resume Next

        txtCath.Focus()

        sysmsg.Visible = False

    End Sub








    Private Sub mdate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mdate.MaskInputRejected

    End Sub


    Private Sub txtbimeh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbimeh.TextChanged

    End Sub

    Private Sub chktatil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktatil.CheckedChanged

    End Sub

    Private Sub mdate_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mdate.ParentChanged

    End Sub

    Private Sub txtCath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCath.TextChanged

    End Sub

    Private Sub flashTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flashTimer.Tick
        ' If bBlink Then
        sysmsg.Visible = Not sysmsg.Visible
        'End If
    End Sub

    Private Sub cbosex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbosex.KeyDown
        hotkey(e.KeyCode, 0)
    End Sub

    Private Sub cbosex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosex.SelectedIndexChanged

    End Sub
End Class