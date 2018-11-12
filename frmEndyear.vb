Imports Microsoft.Win32
Public Class frmEndyear

    Private Sub cmdstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstart.Click
        Dim a As Integer

        Dim msg, mykey, gsql, tmpcode, sdat, tmpdbnamedata, strcnndata As String

        Dim tmpbedeh, tmpbestan, rm, mbed, mbes As Double
        a = MsgBox("برای اعلام پایان سال مطمئن هستید؟", vbYesNo)
        If a <> vbYes Then Exit Sub

        Dim fobj As Object
        fobj = CreateObject("Scripting.FileSystemObject")




        If Dir(txtfile2.Text) <> "" Then
            msg = "در مسیر فوق از قبل اطلاعاتی وجود دارد برای حذف آنها مطمئن هستید؟"
            a = MsgBox(msg, vbYesNo)
        End If
        If a <> vbYes Then
            msg = "عملیات پایان سال انجام نشد خروج از برنامه "
            MsgBox(msg, vbInformation)
            Exit Sub
        End If
        '--------------------------------------------------------'
        sdat = Trim(txtsalnew.Text) + "/01/01"
        fobj.CopyFile(txtfile1.Text, txtfile2.Text)

        If deHesab.con_newyear.State <> 0 Then deHesab.con_newyear.Close()
        tmpdbnamedata = Me.txtfile2.Text
        strcnndata = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" + tmpdbnamedata + ";"

        If deHesab.con_newyear.State <> 0 Then deHesab.con_newyear.Close()
        deHesab.con_newyear.ConnectionString = strcnndata
        deHesab.con_newyear.Open()
        '-----------------------------------------------------------------------'
        If deHesab.rssanadnewyear.State <> 0 Then deHesab.rssanadnewyear.Close()
        deHesab.sanadnewyear("delete from asnad")
        '------------------------------------------------------------------------
        If deHesab.rssanadriznewyear.State <> 0 Then deHesab.rssanadriznewyear.Close()
        deHesab.sanadriznewyear("delete from sanadriz")
        '------------------------------------------------------------------------
        If deHesab.rssanadnewyear.State <> 0 Then deHesab.rssanadnewyear.Close()
        deHesab.sanadnewyear("select *  from asnad")
        deHesab.rssanadnewyear.AddNew()
        deHesab.rssanadnewyear.Fields("ns").Value = 1
        deHesab.rssanadnewyear.Fields("datee").Value = sdat
        deHesab.rssanadnewyear.Fields("Comment").Value = "انتقال از سال قبل" + "  " + txtsalnew.Text
        deHesab.rssanadnewyear.Update()
        '------------------------------------------------------
        gsql = "select  sum(sanadriz.bedeh) as bedeh,sum(sanadriz.bestan) as bestan ,code,codk,codm   from sanadriz   group by code,codk,codm   "
        If deHesab.rslistcode.State <> 0 Then deHesab.rslistcode.Close()
        deHesab.listcode(gsql)
        If deHesab.rssanadriznewyear.State <> 0 Then deHesab.rssanadriznewyear.Close()
        deHesab.sanadriznewyear("select *  from sanadriz")

        Do While deHesab.rslistcode.EOF = False
            tmpcode = deHesab.rslistcode.Fields("code").Value
            tmpbedeh = deHesab.rslistcode.Fields("bedeh").Value
            tmpbestan = deHesab.rslistcode.Fields("bestan").Value
            rm = tmpbestan - tmpbedeh
            If rm > 0 Then
                mbes = rm
                mbed = 0
            Else
                mbed = Math.Abs(rm)
                mbes = 0
            End If
            deHesab.rssanadriznewyear.AddNew()
            deHesab.rssanadriznewyear.Fields("code").Value = tmpcode
            deHesab.rssanadriznewyear.Fields("codk").Value = Mid(tmpcode, 1, 3)
            deHesab.rssanadriznewyear.Fields("codm").Value = Mid(tmpcode, 1, 6)
            deHesab.rssanadriznewyear.Fields("codj").Value = tmpcode
            deHesab.rssanadriznewyear.Fields("ns").Value = 1
            deHesab.rssanadriznewyear.Fields("Comment").Value = "مانده اول دوره "
            deHesab.rssanadriznewyear.Fields("bedeh").Value = mbed
            deHesab.rssanadriznewyear.Fields("bestan").Value = mbes
            deHesab.rssanadriznewyear.Fields("datee").Value = sdat
            deHesab.rssanadriznewyear.Update()
            deHesab.rslistcode.MoveNext()
        Loop
        '---------------------------------  --------------------------
        If deHesab.rskolnewyear.State <> 0 Then deHesab.rskolnewyear.Close()
        deHesab.kolnewyear()
        Do While deHesab.rskolnewyear.EOF = False

            tmpbedeh = deHesab.rskolnewyear.Fields("bedeh").Value
            tmpbestan = deHesab.rskolnewyear.Fields("bestan").Value
            rm = tmpbestan - tmpbedeh
            If rm > 0 Then
                mbes = rm
                mbed = 0
            Else
                mbed = Math.Abs(rm)
                mbes = 0
            End If
            deHesab.rskolnewyear.Fields("bedeh").Value = mbed
            deHesab.rskolnewyear.Fields("bedeh").Value = mbes
            deHesab.rskolnewyear.Update()
            deHesab.rskolnewyear.MoveNext()
        Loop
        '-------------------- clear data in  new year ----------------------------
        If deHesab.rsCardexNewYear.State <> 0 Then deHesab.rsCardexNewYear.Close()
        deHesab.CardexNewYear("delete  *  from pha_detail")
        '-------------------------------------------------
        If deHesab.rsCardexNewYear.State <> 0 Then deHesab.rsCardexNewYear.Close()
        deHesab.CardexNewYear("delete  *  from pha_dnos")
        '--------------------- clear iokala list of kharid and forosh factors --------------------
        If deHesab.rsCardexNewYear.State <> 0 Then deHesab.rsCardexNewYear.Close()
        deHesab.CardexNewYear("delete  *  from iokala")

        gsql = "select  sum(pha_dnos.nom) as bedeh,sum(pha_dnos.nom_in) as bestan ,cokm   from pha_dnos   group by cokm   "
        If deHesab.rslistcode.State <> 0 Then deHesab.rslistcode.Close()
        deHesab.listcode(gsql)
        If deHesab.rsCardexNewYear.State <> 0 Then deHesab.rsCardexNewYear.Close()

        deHesab.CardexNewYear("select *  from pha_dnos")

        Do While deHesab.rslistcode.EOF = False
            tmpcode = deHesab.rslistcode.Fields("cokm").Value
            tmpbedeh = deHesab.rslistcode.Fields("bedeh").Value
            tmpbestan = deHesab.rslistcode.Fields("bestan").Value
            rm = tmpbestan - tmpbedeh
            If rm > 0 Then
                mbes = rm
                mbed = 0
            Else
                mbed = Math.Abs(rm)
                mbes = 0
            End If
            deHesab.rsCardexNewYear.AddNew()
            deHesab.rsCardexNewYear.Fields("cokm").Value = tmpcode
            deHesab.rsCardexNewYear.Fields("Nf").Value = 1
            deHesab.rsCardexNewYear.Fields("Comment").Value = "مانده اول دوره "
            deHesab.rsCardexNewYear.Fields("Nom").Value = mbed
            deHesab.rsCardexNewYear.Fields("nom_in").Value = mbes
            deHesab.rsCardexNewYear.Fields("datee").Value = sdat
            deHesab.rsCardexNewYear.Fields("oper").Value = 0
            deHesab.rsCardexNewYear.Update()
            deHesab.rslistcode.MoveNext()
        Loop


        '------------------------------------- set zero to counter
        If deHesab.rstanzimhesabnewyear.State <> 0 Then deHesab.rstanzimhesabnewyear.Close()
        deHesab.tanzimhesabnewyear()
        deHesab.rstanzimhesabnewyear.Fields("cod_sanad").Value = 1
        deHesab.rstanzimhesabnewyear.Fields("cod_sold").Value = 1
        deHesab.rstanzimhesabnewyear.Fields("cod_kharid").Value = 0

        deHesab.rstanzimhesabnewyear.Fields("radif").Value = 0
        deHesab.rstanzimhesabnewyear.Update()
        '---------------------------- add new sal parameter to list ---------------------------------------'
        If deHesab.rslistsal.State <> 0 Then deHesab.rslistsal.Close()
        deHesab.listsal()
        deHesab.rslistsal.AddNew()
        deHesab.rslistsal.Fields("psal").Value = txtsalnew.Text
        deHesab.rslistsal.Fields("dbname").Value = "data" + Trim(txtsalnew.Text) + ".mdb"
        ' deHesab.rslistsal.Fields("Name").Value = MainForm.lblSaheb
        deHesab.rslistsal.Fields("psal_path").Value = txtfile2.Text
        deHesab.rslistsal.Update()

        '----------------------------- insert year information into table
        If deHesab.rslistsal.State <> 0 Then deHesab.rslistsal.Close()
        deHesab.listsal()
        deHesab.rslistsal.AddNew()
        deHesab.rslistsal.Fields("psal").Value = txtsalnew.Text
        deHesab.rslistsal.Fields("dbname").Value = txtdbname.Text
        'deHesab.rslistsal.Fields("Name").Value = txtsaheb
        deHesab.rslistsal.Fields("psal_path").Value = txtfile2.Text
        deHesab.rslistsal.Update()
        mykey = "Software\zn\doctors\daro" + txtsal.Text
        '------------------------------------------------------------------------'
        Dim regVersion As RegistryKey
        Dim keyValue As String
        keyValue = "Software\zn\doctors"
        regVersion = Registry.LocalMachine.OpenSubKey(keyValue, True)
        Dim intVersion As Integer = 0
        If (regVersion Is Nothing) Then regVersion = Registry.LocalMachine.CreateSubKey(keyValue)
        regVersion.SetValue("sal", txtsalnew.Text)
        regVersion.SetValue("dbname", txtdbname.Text)
        regVersion.SetValue("path", txtfile2.Text)
        regVersion.SetValue("saheb", txtsaheb.Text)
        regVersion.SetValue("dat1", txtdat1.Text)
        regVersion.SetValue("dat2", txtdat2.Text)
        regVersion.Flush()
        regVersion.Close()


        '--------------------------------------------------------------------------
        MsgBox("عملیات پایان سال با موفقیت انجام شد", vbInformation)
ErrTrapped:


    End Sub

    Private Sub frmEndyear_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        Dim a, b, c As String
        txtsal.Text = MainForm.txtsal.Text
        txtsalnew.Text = Val(MainForm.txtsal.Text) + 1
        txtfile1.Text = MainForm.txtpsal_path.Text
        txtsaheb.Text = MainForm.lblSaheb.Text
        txtdbname.Text = "Data" + Trim(txtsalnew.Text) + ".mdb"
        c = txtdbname.Text
        b = MainForm.txtdbname.Text
        a = Replace(txtfile1.Text, b, c)
        txtfile2.Text = a
        txtdat1.Text = Trim(txtsalnew.Text) + "/01/01"
        txtdat2.Text = Trim(txtsalnew.Text) + "/12/30"

    End Sub
End Class