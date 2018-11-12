Public Class frmDateTimePicker
    Dim daytime As New Date

    Private Sub frmDateTimePicker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.ShowUpDown = True
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  Daytime.SetWindowsClock()
    End Sub
End Class