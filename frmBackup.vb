Public Class frmBackup

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click
        On Error GoTo ErrTrapped
        Dim fobj As Object

        fobj = CreateObject("Scripting.FileSystemObject")
        Dim str As String

        fobj.CopyFile(lblPath.Text, txtmyloc.Text)
        MsgBox(".OK.با موفقیت انجام شد " + txtmyloc.Text, vbInformation)
        Dir1.Refresh()
        File1.Path = Dir1.Path
        File1.Pattern = "*.mdb"
        File1.Refresh()
        Exit Sub
ErrTrapped:
        MsgBox("در انجام نسخه پشتیبان مشکلی بوجود آمده است ", vbCritical)
        Exit Sub

    End Sub

    Private Sub frmBackup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Win32Script As Object
        Win32Script = CreateObject("WScript.Shell")
        lblPath.Text = Win32Script.RegRead("HKEY_LOCAL_MACHINE\Software\zn\doctors\path")
        File1.Path = Dir1.Path
        File1.Pattern = "*.mdb"
        ShowMyloc()

    End Sub
    Private Sub ShowMyloc()
        Dim aa, mystr As String
        txtfile1.Text = MainForm.sbar1.Items(7).Text
        aa = Mid(MainForm.sbar1.Items(7).Text, 1, 8) + "-"
        mystr = aa + Mid(MainForm.txtdate1.Text, 1, 4) + Mid(MainForm.txtdate1.Text, 6, 2) + Mid(MainForm.txtdate1.Text, 9, 2) + ".mdb"
        txtmyloc.Text = Dir1.Path + "\" + mystr

    End Sub

    Private Sub showFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showFolder.Click
        On Error Resume Next
        Dim bb As Object
        bb = Shell("Explorer " & Dir1.Path, 1)
        Exit Sub
Err_Renamed:
        MsgBox(Err.Description)

    End Sub
    Private Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change

        File1.Pattern = "*.txt" '
        File1.Path = Dir1.Path

    End Sub

    Private Sub Drive1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Drive1.SelectedValueChanged
        On Error GoTo errtrap
        Dim pdrv1, drv1 As String
        Dir1.Path = Drive1.Drive

        drv1 = Drive1.Drive
        Exit Sub
errtrap:
        MsgBox("The drive does not exist")
        Drive1.Drive = drv1
        Exit Sub

    End Sub
End Class