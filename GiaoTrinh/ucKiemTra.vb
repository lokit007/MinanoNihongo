Public Class ucKiemTra
    Private lst As List(Of TuVung_Object)
    Private lstTam As New List(Of TuVung_Object)
    Private tuVung As TuVung_Object
    Private traLoi1 As TuVung_Object
    Private traLoi2 As TuVung_Object
    Private traLoi3 As TuVung_Object
    Private rd As New Random
    Private time As Integer = 60
    Private soCauDung As Integer = 0
    Private viTriTraLoi As Integer = 1
    Private daTraLoi As Boolean = False

    Public Sub InitListTuVung(ByRef lstTuVung As List(Of TuVung_Object))
        lst = lstTuVung
        soCauDung = 0
        lbTongCau.Text = "Tổng sô câu cần học : " & lst.Count
        lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0}", soCauDung)
        If IsNothing(lst) OrElse lst.Count < 1 Then
            tuVung = Nothing
        Else
            lstTam.AddRange(lst.ToArray)
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
            If lst.Count > 3 Then
                GroupBox1.Visible = True
                btnBoQua.Visible = True
                btnBoQua_Click(sender, e)
                Timer1.Start()
            Else
                lbCauHoi.Text = "Không đủ dữ liệu để thực hiện chức năng này :'(" & vbCrLf & "Vui lòng chọn thêm bài để có đủ dữ liệu kiểm tra."
                lbCauHoi.BackColor = Color.Yellow
                lbCauHoi.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbShowThoiGian.Checked AndAlso time >= 0 Then
            lbThoiGian.Text = Math.Floor(time / 60).ToString("00") & ":" & CInt(time Mod 60).ToString("00")
            If time < 10 Then
                Beep()
                lbThoiGian.ForeColor = Color.Red
            End If
            If time = 0 Then
                btnBoQua_Click(sender, e)
            End If
            time -= 1

        End If
    End Sub

    Private Sub btnBoQua_Click(sender As Object, e As EventArgs) Handles btnBoQua.Click
        If btnBoQua.Text.Equals("LÀM LẠI") Then
            soCauDung = 0
            daTraLoi = False
            lbTongCau.Text = "Tổng số câu cần học : " & lst.Count
            lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0}", soCauDung)
            btnBoQua.Text = "BỎ QUA"
            If IsNothing(lst) OrElse lst.Count < 1 Then
                tuVung = Nothing
            Else
                lstTam.AddRange(lst.ToArray)
            End If
            Timer1.Start()
        End If

        If Not IsNothing(lstTam) AndAlso lstTam.Count > 0 AndAlso lst.Count > 3 Then
            audioCauHoi.Ctlcontrols.stop()
            daTraLoi = False
            time = 60
            lbThoiGian.ForeColor = Nothing
            btnTraLoi1.Enabled = True
            btnTraLoi2.Enabled = True
            btnTraLoi3.Enabled = True
            btnTraLoi4.Enabled = True
            tuVung = lstTam.Item(rd.Next(lstTam.Count))
            traLoi1 = lst.Item(rd.Next(lst.Count))
            traLoi2 = lst.Item(rd.Next(lst.Count))
            traLoi3 = lst.Item(rd.Next(lst.Count))
            While tuVung.Equals(traLoi1)
                traLoi1 = lst.Item(rd.Next(lst.Count))
            End While
            While tuVung.Equals(traLoi2) OrElse traLoi1.Equals(traLoi2)
                traLoi2 = lst.Item(rd.Next(lst.Count))
            End While
            While tuVung.Equals(traLoi3) OrElse traLoi1.Equals(traLoi3) OrElse traLoi2.Equals(traLoi3)
                traLoi3 = lst.Item(rd.Next(lst.Count))
            End While

            Select Case rd.Next(1, 4)
                Case 1
                    viTriTraLoi = 1
                    ShowCauHoi(hoi:=tuVung, traloi1:=traLoi1, traloi2:=traLoi2, traloi3:=traLoi3)
                Case 2
                    viTriTraLoi = 2
                    ShowCauHoi(hoi:=traLoi1, traloi1:=tuVung, traloi2:=traLoi2, traloi3:=traLoi3)
                Case 3
                    viTriTraLoi = 3
                    ShowCauHoi(hoi:=traLoi1, traloi1:=traLoi2, traloi2:=tuVung, traloi3:=traLoi3)
                Case Else
                    viTriTraLoi = 4
                    ShowCauHoi(hoi:=traLoi1, traloi1:=traLoi2, traloi2:=traLoi3, traloi3:=tuVung)
            End Select
        Else
            tuVung = Nothing
            lbCauHoi.Text = "Bạn đã hoàn thành xong bài kiểm tra :D."
            btnBoQua.Text = "LÀM LẠI"
            Timer1.Stop()
        End If
    End Sub

    Private Sub ShowCauHoi(hoi, traloi1, traloi2, traloi3)
        If Not IsNothing(tuVung) Then
            Select Case rd.Next(4)
                Case 1
                    audioCauHoi.Visible = False
                    lbCauHoi.Visible = True
                    lbCauHoi.Text = tuVung.tuVung
                    btnTraLoi1.Text = hoi.nguNghia
                    btnTraLoi2.Text = traloi1.nguNghia
                    btnTraLoi3.Text = traloi2.nguNghia
                    btnTraLoi4.Text = traloi3.nguNghia
                Case 2
                    audioCauHoi.Visible = False
                    lbCauHoi.Visible = True
                    lbCauHoi.Text = tuVung.nguNghia
                    btnTraLoi1.Text = hoi.tuVung
                    btnTraLoi2.Text = traloi1.tuVung
                    btnTraLoi3.Text = traloi2.tuVung
                    btnTraLoi4.Text = traloi3.tuVung
                Case 3
                    audioCauHoi.Visible = False
                    lbCauHoi.Visible = True
                    If Not String.IsNullOrEmpty(tuVung.hanTu) Then
                        lbCauHoi.Text = tuVung.hanTu
                    Else
                        lbCauHoi.Text = tuVung.tuVung
                    End If
                    btnTraLoi1.Text = hoi.nguNghia
                    btnTraLoi2.Text = traloi1.nguNghia
                    btnTraLoi3.Text = traloi2.nguNghia
                    btnTraLoi4.Text = traloi3.nguNghia
                Case Else
                    Dim path As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\AudioFiles\" & tuVung.urlAmDoc
                    If Not String.IsNullOrEmpty(tuVung.urlAmDoc) Then
                        audioCauHoi.Visible = True
                        If System.IO.File.Exists(path) Then
                            audioCauHoi.URL = path
                            audioCauHoi.Ctlcontrols.play()
                        End If
                        lbCauHoi.Visible = False
                        lbCauHoi.Text = tuVung.hanTu
                    Else
                        audioCauHoi.Visible = False
                        lbCauHoi.Visible = True
                        lbCauHoi.Text = tuVung.tuVung
                    End If
                    btnTraLoi1.Text = hoi.nguNghia
                    btnTraLoi2.Text = traloi1.nguNghia
                    btnTraLoi3.Text = traloi2.nguNghia
                    btnTraLoi4.Text = traloi3.nguNghia
            End Select
        End If
    End Sub

    Private Sub btnTraLoi1_Click(sender As Object, e As EventArgs) Handles btnTraLoi1.Click
        If Not IsNothing(tuVung) AndAlso Not IsNothing(lstTam) AndAlso lstTam.Count > 0 Then
            If viTriTraLoi = 1 Then
                If Not daTraLoi Then
                    soCauDung += 1
                    lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0} ({1}%)", soCauDung, Math.Round(soCauDung / lst.Count, 2) * 100)
                End If
                lstTam.Remove(tuVung)
                btnBoQua_Click(sender, e)
            Else
                btnTraLoi1.Enabled = False
                daTraLoi = True
            End If
        End If
    End Sub

    Private Sub btnTraLoi2_Click(sender As Object, e As EventArgs) Handles btnTraLoi2.Click
        If Not IsNothing(tuVung) AndAlso Not IsNothing(lstTam) AndAlso lstTam.Count > 0 Then
            If viTriTraLoi = 2 Then
                If Not daTraLoi Then
                    soCauDung += 1
                    lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0} ({1}%)", soCauDung, Math.Round(soCauDung / lst.Count, 2) * 100)
                End If
                lstTam.Remove(tuVung)
                btnBoQua_Click(sender, e)
            Else
                btnTraLoi2.Enabled = False
                daTraLoi = True
            End If
        End If
    End Sub

    Private Sub btnTraLoi3_Click(sender As Object, e As EventArgs) Handles btnTraLoi3.Click
        If Not IsNothing(tuVung) AndAlso Not IsNothing(lstTam) AndAlso lstTam.Count > 0 Then
            If viTriTraLoi = 3 Then
                If Not daTraLoi Then
                    soCauDung += 1
                    lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0} ({1}%)", soCauDung, Math.Round(soCauDung / lst.Count, 2) * 100)
                End If
                lstTam.Remove(tuVung)
                btnBoQua_Click(sender, e)
            Else
                btnTraLoi3.Enabled = False
                daTraLoi = True
            End If
        End If
    End Sub

    Private Sub btnTraLoi4_Click(sender As Object, e As EventArgs) Handles btnTraLoi4.Click
        If Not IsNothing(tuVung) AndAlso Not IsNothing(lstTam) AndAlso lstTam.Count > 0 Then
            If viTriTraLoi = 4 Then
                If Not daTraLoi Then
                    soCauDung += 1
                    lbSoCauDung.Text = String.Format("Số câu trả lời đúng : {0} ({1}%)", soCauDung, Math.Round(soCauDung / lst.Count, 2) * 100)
                End If
                lstTam.Remove(tuVung)
                btnBoQua_Click(sender, e)
            Else
                btnTraLoi4.Enabled = False
                daTraLoi = True
            End If
        End If
    End Sub

End Class
