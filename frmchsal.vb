Option Strict Off
Option Explicit Off
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Win32

Public Class frmchsal
    Inherits System.Windows.Forms.Form


    'UPGRADE_WARNING: Structure OpenFilename may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (ByRef pOpenfilename As OpenFilename) As Integer
    Private Structure OpenFilename
        Dim lStructSize As Integer
        Dim hwndOwner As Integer
        Dim hInstance As Integer
        Dim lpstrFilter As String
        Dim lpstrCustomFilter As String
        Dim nMaxCustFilter As Integer
        Dim iFilterIndex As Integer
        Dim lpstrFile As String
        Dim nMaxFile As Integer
        Dim lpstrFileTitle As String
        Dim nMaxFileTitle As Integer
        Dim lpstrInitialDir As String
        Dim lpstrTitle As String
        Dim Flags As Integer
        Dim nFileOffset As Short
        Dim nFileExtension As Short
        Dim lpstrDefExt As String
        Dim lCustData As Integer
        Dim lpfnHook As Integer
        Dim lpTemplateName As String
    End Structure
    Private Function getradif() As Object
        Dim tmpnom As Object
        Dim i As Object
        Dim mx As Object


        mx = 0
        For i = 1 To mh6.Rows.Count - 1


            tmpnom = Val(mh6.GetData(i, 0))

            If Val(tmpnom) > 0 Then

                mx = tmpnom
            End If
        Next i

        getradif = mx
    End Function
    Private Sub hotkey(ByRef KeyCode As Short)
        Select Case KeyCode
            Case 13
                System.Windows.Forms.SendKeys.Send(("{TAB}"))
        End Select
    End Sub
    Private Sub clsgrid6()
        mh6.Rows.Count = 2
        mh6.Cols.Count = 10
        mh6.Clear()

        mh6.Cols(0).Width = 50
        mh6.Cols(1).Width = 70
        mh6.Cols(2).Width = 100
        mh6.Cols(3).Width = 200
        mh6.Cols(4).Width = 300
        mh6.Cols(5).Width = 50
        mh6.Cols(6).Width = 50
        mh6.Cols(7).Width = 50

        mh6.Cols(8).Width = 100
        mh6.Cols(9).Width = 50

        mh6.SetData(0, 0, "ردیف  ")
        mh6.SetData(0, 1, "سال  ")
        mh6.SetData(0, 2, "نام فايل  ")
        mh6.SetData(0, 3, "عنوان  ")
        mh6.SetData(0, 4, "مسير فايل ")
        mh6.SetData(0, 5, "شماره ")
        mh6.SetData(0, 6, "از تاريخ ")
        mh6.SetData(0, 7, "تا تاريخ ")
        mh6.SetData(0, 8, " مسیراصلی")
        mh6.SetData(0, 9, " رمز")

    End Sub

    Public Sub DataMdbDaro()
        Dim strcnn1 As String
        Dim adir As String
        Dim tmp1 As String
        Dim tmpsaheb As String
        Dim tmpdat2 As String
        Dim tmpdat1 As String
        Dim tmppath As String
        Dim tmpsal As String
        Dim tmpdbname As String
        Dim tmpMainPath As String

        tmpdbname = ReadSettingString("Software\zn\doctors", "dbname")

        tmpsal = ReadSettingString("Software\zn\doctors", "sal")
        tmppath = ReadSettingString("Software\zn\doctors", "path")
        tmpMainPath = ReadSettingString("Software\zn\doctors", "Mainpath")
        tmpdat1 = ReadSettingString("Software\zn\doctors", "dat1")
        tmpdat2 = ReadSettingString("Software\zn\doctors", "dat2")
        tmpsaheb = ReadSettingString("Software\zn\doctors", "saheb")
        If tmpdat1 <> "0" Then

            MainForm.txtmdat1.Text = tmpdat1
            MainForm.txtmdat2.Text = tmpdat2
        Else
            MainForm.txtmdat2.Text = MainForm.txtdate1.Text
            MainForm.txtmdat1.Text = Mid(MainForm.txtdate1.Text, 1, 4) & "/01/01"
        End If

        MainForm.txtdbname.Text = tmpdbname
        MainForm.txtsal.Text = tmpsal
        MainForm.txtpsal_path.Text = tmppath
        MainForm.txtMainPath.Text = tmpMainPath
        MainForm.sbar1.Items.Item(1).Text = MainForm.txtdate1.Text
        MainForm.sbar1.Items.Item(3).Text = MainForm.txtuser.Text
        MainForm.sbar1.Items.Item(4).Text = MainForm.txtsal.Text
        MainForm.sbar1.Items.Item(7).Text = MainForm.txtdbname.Text
        tmp1 = tmppath
        adir = Dir(tmp1)
        If adir <> "" And tmppath <> "" Then
            strcnn1 = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" + tmp1 + ";"
            If de1.con_main.State <> 0 Then de1.con_main.Close()
            de1.con_main.ConnectionString = strcnn1
            de1.con_main.Open()

            If deHesab.con_data.State <> 0 Then deHesab.con_data.Close()
            deHesab.con_data.ConnectionString = strcnn1
            deHesab.con_data.Open()
            '----------------------------------------
            Dim tmpeoffice As String
            tmpeoffice = tmpMainPath
            If de3.con_eoffice.State <> 0 Then de3.con_eoffice.Close()
            de3.con_eoffice.ConnectionString = strcnn1
            de3.con_eoffice.Open()
            tmp1 = Application.StartupPath.ToString + "\data1390.mdb"
            '------------------------------------------------------
            MainForm.txtconstring.Text = strcnn1
            MainForm.chkOk.CheckState = System.Windows.Forms.CheckState.Checked

            '---------------------------------------------------------------------------------'
        Else
            '----------------------------------- not in registery
            Dim tmpeoffice As String
            tmpeoffice = Application.StartupPath.ToString + "\Eoffice.mdb"
            If Dir(tmpeoffice) = "" Then
                MsgBox("بانک اطلاعاتی  پیدا نشد امکان اجرای برنامه وجود ندارد Eoffice.mdb", MsgBoxStyle.Critical)
                End

            End If
            If de3.con_eoffice.State <> 0 Then de3.con_eoffice.Close()
            de3.con_eoffice.ConnectionString = tmpeoffice.ToString
            de3.con_eoffice.Open()
            tmp1 = Application.StartupPath.ToString + "\data1391.mdb"
            strcnn1 = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" + tmp1 + ";"
            MainForm.txtpsal_path.Text = tmp1
            MainForm.txtconstring.Text = strcnn1
            If Dir(tmp1) = "" Then
                MsgBox("بانک اطلاعاتی پیدا نشد لطفا مسیر آنرا مشخص نمایید", MsgBoxStyle.Critical)
                frmgetMdb.ShowDialog()
            Else
                strcnn1 = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" + tmp1 + ";"

                If de1.con_main.State <> 0 Then de1.con_main.Close()
                de1.con_main.ConnectionString = strcnn1
                de1.con_main.Open()
                If deHesab.con_data.State <> 0 Then deHesab.con_data.Close()
                deHesab.con_data.ConnectionString = strcnn1
                deHesab.con_data.Open()

            End If

        End If
        '-------------------------------------------------------------------------



    End Sub

    Private Sub SetAppdataSource()

        '--------------------------------------
        SaveSettingString("Software\zn\doctors", "sal", txtsal.Text)
        SaveSettingString("Software\zn\doctors", "dbname", txtdbname.Text)
        SaveSettingString("Software\zn\doctors", "path", txtpath.Text)
        SaveSettingString("Software\zn\doctors", "MainPath", txtMainPath.Text)
        SaveSettingString("Software\zn\doctors", "saheb", txtsaheb.Text)
        SaveSettingString("Software\zn\doctors", "dat1", txtdat1.Text)
        SaveSettingString("Software\zn\doctors", "dat2", txtdat2.Text)
        DataMdbDaro()




    End Sub
    Private Sub Cmdsave_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        '--------------------------------------------------------

        SetAppdataSource()

        If de3.rsfindsal.State <> 0 Then de3.rsfindsal.Close()
        de3.findsal(Val(txtid.Text))
        If de3.rsfindsal.EOF = True Then
            de3.rsfindsal.AddNew()
        End If
        de3.rsfindsal.Fields("psal").Value = txtsal.Text
        de3.rsfindsal.Fields("dbname").Value = txtdbname.Text
        de3.rsfindsal.Fields("Name").Value = txtsaheb.Text
        de3.rsfindsal.Fields("psal_path").Value = txtpath.Text
        'de3.rsfindsal.Fields("date1").Value = txtdat1.Text
        'de3.rsfindsal.Fields("date2").Value = txtdat2.Text
        'de3.rsfindsal.Fields("lockPass").Value = txtLockPass.Text
        de3.rsfindsal.Update()


        findall()
        MsgBox("اطلاعات ثبت گرديد", MsgBoxStyle.Information)

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click

        txtid.Text = ""
        _Frame2_0.Visible = True
        cmdsave.Visible = True

    End Sub


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click

        _Frame2_0.Visible = True
        cmdsave.Visible = True
        Me.txtsal.Text = mh6.GetData(mh6.Row, 1)
        Me.txtdbname.Text = mh6.GetData(mh6.Row, 2)
        Me.txtpath.Text = mh6.GetData(mh6.Row, 4)
        Me.txtsaheb.Text = mh6.GetData(mh6.Row, 3)
        Me.txtid.Text = mh6.GetData(mh6.Row, 5)
        Me.txtdat1.Text = mh6.GetData(mh6.Row, 6)
        Me.txtdat2.Text = mh6.GetData(mh6.Row, 7)

    End Sub


    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles Command5.Click
        Dim B As Object
        Dim a As Object
        Dim ofn As OpenFilename
        On Error Resume Next
        ofn.lStructSize = Len(ofn)
        ofn.hwndOwner = Handle.ToInt32
        ofn.lpstrFilter = "Access files (*.mdb)" & Chr(0) & "*.mdb" & Chr(0) & Chr(0) & Chr(0)
        ofn.lpstrFile = New String(Chr(0), 256)
        ofn.nMaxFile = 255
        ofn.lpstrTitle = "Open Database"
        ofn.Flags = &H800000 + &H1000 + &H8 + &H4
        ofn.lpstrDefExt = "mdb" & Chr(0)
        GetOpenFileName(ofn)
        If Mid(ofn.lpstrFile, 1, 1) <> Chr(0) Then
            txtpath.Text = ofn.lpstrFile

            a = ofn.nFileOffset
            B = Mid(txtpath.Text, a + 1, 20)
            txtdbname.Text = B
        End If
    End Sub

    Private Sub mh6_dblClick(ByVal eventSender As System.Object, ByVal e As System.EventArgs)
        SetNew()
    End Sub

    Private Sub mh6_KeyDownEvent(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim p As Object
        Dim mykey As Object
        Dim a As Object

        Select Case e.KeyCode
            Case 27
                Me.Hide()
            Case 112 To 123 'f1
                'Case 123  'f12
                '          changesr
            Case 46 ' delete
                If mh6.GetData(mh6.Row, 2) = "" Then Exit Sub
                'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                a = MsgBox("براي حذف سال مالي مطمئن هستيد؟", MsgBoxStyle.YesNo)
                If a = MsgBoxResult.Yes Then
                    mykey = mh6.GetData(mh6.Row, 8)
                    MsgBox("حذف شد.....", MsgBoxStyle.Information)
                    For p = 1 To 5
                        mh6.SetData(mh6.Row, p, "")
                    Next
                End If

            Case 13
                SetNew()



        End Select
    End Sub
    Private Sub SetNew()
        Dim a As Object
        Dim tmpdat2 As Object
        Dim tmpdat1 As Object
        Dim tmpidsal As Object
        On Error Resume Next

        tmpidsal = mh6.GetData(mh6.Row, 0)
        txtsal.Text = mh6.GetData(mh6.Row, 1)
        txtdbname.Text = mh6.GetData(mh6.Row, 2)

        tmpdat1 = mh6.GetData(mh6.Row, 6)

        tmpdat2 = mh6.GetData(mh6.Row, 7)
        txtpsal_path.Text = mh6.GetData(mh6.Row, 4)
        txtpath.Text = mh6.GetData(mh6.Row, 4)
        txtMainPath.Text = mh6.GetData(mh6.Row, 8)

        MainForm.lblSaheb.Text = mh6.GetData(mh6.Row, 3)
        '
        MainForm.txtsal.Text = Me.txtsal.Text
        MainForm.txtidsal.Text = tmpidsal
        MainForm.txtdbname.Text = txtdbname.Text
        MainForm.txtpsal_path.Text = txtpsal_path.Text
        If Mid(tmpdat1, 10, 1) <> "" Then

            MainForm.txtmdat1.Text = tmpdat1

            MainForm.txtmdat2.Text = tmpdat2
        Else
            MainForm.txtmdat1.Text = txtsal.Text & "/01/01"
            MainForm.txtmdat2.Text = txtsal.Text & "/12/30"
        End If


        MsgBox("سال  مالي جديد انتخاب شد ......", MsgBoxStyle.OkOnly)
        ShowMainBar()
        MainForm.sbar1.Refresh()
        '------------------------------------------------------------
        SetAppdataSource()
        Me.Close()
        '        a = MsgBox("براي فعال شدن سال جديد ميبايست از نرم افزار خارج و مجددا وارد شود", MsgBoxStyle.YesNo)
        '        If a = MsgBoxResult.Yes Then End
        '        Me.Close()
    End Sub
    Private Sub cmdexit_Click(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub


    Private Sub frmchsal_Load(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        clsgrid6()
        findall()

    End Sub
    Private Sub findall()
        On Error Resume Next
        Dim tmpdate2 As String
        Dim tmpdate1 As String
        Dim rtn As Object
        Dim mykey As String
        Dim tmpsaheb As String
        Dim tmpPsal_path As String
        Dim tmpName As String
        Dim tmpLockPass As String
        Dim tmppath As String
        Dim tmpid As String
        Dim tmpDbname As String
        Dim tmpcode As String
        Dim a1 As Integer
        Dim i As Integer
        tmpMainPath = ReadSettingString("Software\zn\doctors", "Mainpath")

        i = 1
        clsgrid6()
        If de3.rslistsal.State <> 0 Then de3.rslistsal.Close()
        de3.listsal()
        Do While de3.rslistsal.EOF = False
            mh6.Rows.Add()
            If Not IsDBNull(de3.rslistsal.Fields("name")) Then tmpName = de3.rslistsal.Fields("name").Value
            If Not IsDBNull(de3.rslistsal.Fields("psal")) Then tmpPsal = de3.rslistsal.Fields("psal").Value
            If Not IsDBNull(de3.rslistsal.Fields("id")) Then tmpid = de3.rslistsal.Fields("id").Value
            If Not IsDBNull(de3.rslistsal.Fields("Dbname")) Then tmpDbname = de3.rslistsal.Fields("Dbname").Value
            If Not IsDBNull(de3.rslistsal.Fields("psal_path")) Then tmpPsal_path = de3.rslistsal.Fields("psal_path").Value
            If Not IsDBNull(de3.rslistsal.Fields("LockPass")) Then tmpLockPass = de3.rslistsal.Fields("LockPass").Value
            If Not IsDBNull(de3.rslistsal.Fields("Date1")) Then tmpdate1 = de3.rslistsal.Fields("Date1").Value
            If Not IsDBNull(de3.rslistsal.Fields("Date2")) Then tmpdate2 = de3.rslistsal.Fields("Date2").Value

            mh6.SetData(i, 0, i)
            mh6.SetData(i, 1, tmpPsal)
            mh6.SetData(i, 2, tmpDbname)
            mh6.SetData(i, 3, tmpsaheb)
            mh6.SetData(i, 4, tmpPsal_path)
            mh6.SetData(i, 5, tmpid)
            mh6.SetData(i, 6, tmpdate1)
            mh6.SetData(i, 7, tmpdate2)
            mh6.SetData(i, 8, tmpMainPath)
            mh6.SetData(i, 9, tmpLockPass)
            i = i + 1
            '-------------------------------------------------
            de3.rslistsal.MoveNext()
        Loop
        ''

    End Sub


    Private Sub txtnaka_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtpass1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtpass2_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
        hotkey(KeyCode)
    End Sub

    Private Sub txtsal_Enter(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles txtsal.Enter
        txtsal.SelectionStart = 0
        txtsal.SelectionLength = Len(txtsal.Text)
    End Sub

    Private Sub txtsal_KeyDown(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsal.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        hotkey(KeyCode)
    End Sub



    Private Sub mh6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mh6.Click

    End Sub

    Private Sub mh6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles mh6.DoubleClick
        SetNew()
    End Sub

    Private Sub mh6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh6.KeyDown
        Dim p As Object
        Dim mykey As Object
        Dim a As Object

        Select Case e.KeyCode
            Case 27
                Me.Hide()
            Case 112 To 123 'f1
            Case 46 ' delete
                If mh6.GetData(mh6.Row, 5) = "" Then Exit Sub
                a = MsgBox("براي حذف سال مالي مطمئن هستيد؟", MsgBoxStyle.YesNo)
                If a = MsgBoxResult.Yes Then

                    mykey = Val(mh6.GetData(mh6.Row, 5))
                    If de3.rsfindsal.State <> 0 Then de3.rsfindsal.Close()
                    de3.findsal(mykey)
                    If de3.rsfindsal.EOF = False Then
                        de3.rsfindsal.Delete()
                        de3.rsfindsal.Update()
                    End If
                    MsgBox("حذف شد.....", MsgBoxStyle.Information)
                    findall()

                End If

            Case 13
                SetNew()
        End Select
    End Sub

    Private Sub mh6_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mh6.KeyDown

    End Sub


    Private Sub mh6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mh6.KeyPress

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mysql As Object
        On Error Resume Next
        Dim conn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset

        Dim dbs As New ADODB.Connection
        Dim curpath As String
        curpath = txtpath.Text & "Eoffice.mdb"
        If Dir(curpath) = "" Then
            MsgBox("فایل Eoffice.mdb درمسیر مربوطه پیدا نشد", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If conn.State = 1 Then conn.Close()
        conn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data source =" & curpath)
        '----------------------------------------------------------------------------------------------'
        mysql = "create TABLE Sal (ID  AUTOINCREMENT,psal text(10),name text(50),psal_path text(100),Dbname text(20),Date1 text(10),Date2 text(10),LockPass text(10))"
        Rs.Open(mysql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        '--------------------------------------------------------------
        MsgBox("انجام شد.....", MsgBoxStyle.Information)
        '------------------------------------------------------------

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim B As Object
        Dim a As Object
        Dim ofn As OpenFilename
        On Error Resume Next
        ofn.lStructSize = Len(ofn)
        ofn.hwndOwner = Handle.ToInt32
        ofn.lpstrFilter = "Access files (*.mdb)" & Chr(0) & "*.mdb" & Chr(0) & Chr(0) & Chr(0)
        ofn.lpstrFile = New String(Chr(0), 256)
        ofn.nMaxFile = 255
        ofn.lpstrTitle = "Open Database"
        ofn.Flags = &H800000 + &H1000 + &H8 + &H4
        ofn.lpstrDefExt = "mdb" & Chr(0)
        GetOpenFileName(ofn)
        If Mid(ofn.lpstrFile, 1, 1) <> Chr(0) Then
            txtMainPath.Text = ofn.lpstrFile

          
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If de3.rsDelsal.State <> 0 Then de3.rsDelsal.Close()
        de3.Delsal()
        findall()
    End Sub
End Class