Imports System.IO

Public Class frmCreateDbfromTemplate

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using dialog As New OpenFileDialog
            dialog.Filter = "data files (*.mdb)|*.mdb|All files (*.*)|*.*"
            dialog.FilterIndex = 1
            dialog.InitialDirectory = txtMpath.Text
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            txtfile1.Text = dialog.FileName

        End Using
    End Sub
    Private Sub make2()
        txtfile2.Text = txtMpath.Text + "\" + "Data" + txtsal.Text + ".mdb"
        txtfile2.BackColor = Color.GreenYellow
    End Sub
    Private Sub frmCreateDbfromTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtMpath.Text = Application.StartupPath
        make2()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtsal.Text = Val(txtsal.Text) - 1
        make2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtsal.Text = Val(txtsal.Text) + 1
        make2()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtfile1.Text = txtMpath.Text + "\Data1391.mdb"
        Else
            txtfile1.Text = ""

        End If
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If My.Computer.FileSystem.FileExists(txtfile2.Text) = True Then
            If MsgBox("فایل از قبل موجو میباشد مطمئن هستید که میخواهید بازنویسی شود", vbYesNo) = MsgBoxResult.Yes Then
                Dim a1 As String
                a1 = txtMpath.Text + "\BakData" + txtsal.Text + "-" + Now.Second.ToString + ".mdb"
                File.Copy(txtfile2.Text, a1, True)
            Else
                MsgBox("فایل ایجاد نشد", vbCritical)
                GoTo mm
            End If

        End If
        Try
            File.Copy(txtfile1.Text, txtfile2.Text, True)
            MsgBox("فایل جدید ایجاد شد", vbInformation)
        Catch ex As Exception
            MsgBox("در ایجاد فایل اشکالی بوجود آمده است", vbCritical)
        End Try
Mm:
    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
End Class