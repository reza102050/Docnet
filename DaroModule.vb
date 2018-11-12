Module DaroModule
    
    Public Function ControlMe() As Short

        Dim modal As Object
        Dim sql, msg As String
        If MainForm.chkregister.CheckState = 0 Then

            If de1.rsbrowall.State <> 0 Then de1.rsbrowall.Close()
            sql = "select * from pha_detail"
            de1.browall(sql)
            If de1.rsbrowall.RecordCount >= 5 Then

                msg = "در نسخه نمايشي امکان ثبت  بيشتر از 5 وجود ندارد لطفا جهت ثبت نام نسخه اصلي اقدام نماييد "
                MsgBox(msg, MsgBoxStyle.Critical)
                ControlMe = 0
                GoTo mp1
            End If
        End If
        If Val(MainForm.txtActive.Text) = 0 Then
            msg = "نسبت به تمديد قرارداد اقدام نماييد امكان ثبت وجود ندارد "
            MsgBox(msg, MsgBoxStyle.Critical)
            ControlMe = 0
            GoTo mp1
        End If
mtest:
        ControlMe = 1
mp1:
    End Function
End Module
