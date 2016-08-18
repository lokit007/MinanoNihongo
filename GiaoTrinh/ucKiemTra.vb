Public Class ucKiemTra
    Private lst As List(Of TuVung_Object)
    Private tuVung As TuVung_Object
    Private time As Integer = 60

    Public Sub InitListTuVung(ByRef lstTuVung As List(Of TuVung_Object))
        lst = lstTuVung

        If IsNothing(lst) OrElse lst.Count < 1 Then
            tuVung = Nothing

        Else

        End If

    End Sub

    Private Sub lbCauHoi_MouseHover(sender As Object, e As EventArgs) Handles lbCauHoi.MouseHover
        If lbCauHoi.Text.Equals("Click để bắt đầu kiểm tra nào :D :D") Then
            lbCauHoi.BackColor = Color.AliceBlue
            lbCauHoi.ForeColor = Color.PaleVioletRed
        End If
    End Sub

    Private Sub lbCauHoi_MouseLeave(sender As Object, e As EventArgs) Handles lbCauHoi.MouseLeave
        If lbCauHoi.Text.Equals("Click để bắt đầu kiểm tra nào :D :D") Then
            lbCauHoi.BackColor = Nothing
            lbCauHoi.ForeColor = Nothing
        End If
    End Sub

    Private Sub lbCauHoi_Click(sender As Object, e As EventArgs) Handles lbCauHoi.Click
        If lbCauHoi.Text.Equals("Click để bắt đầu kiểm tra nào :D :D") Then
            GroupBox1.Visible = True
            btnBoQua.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbShowThoiGian.Checked AndAlso time >= 0 Then
            lbThoiGian.Text = Math.Floor(time / 60).ToString("00") & ":" & CInt(time Mod 60).ToString("00")
            If time < 10 Then
                Beep()
                lbThoiGian.ForeColor = Color.Red
            End If

            time -= 1

        End If
    End Sub
End Class
