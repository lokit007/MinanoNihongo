Public Class ucTracNghiem
    Private bangChuCai As New BangChuCai_Object()
    Private list As New List(Of ChuCai_Object)
    Private listTam As New List(Of ChuCai_Object)
    Private hoi As ChuCai_Object
    Private traLoi1 As ChuCai_Object
    Private traLoi2 As ChuCai_Object
    Private traLoi3 As ChuCai_Object
    Private nTong As Integer = 0
    Private nDung As Integer = 0
    Private nSai As Integer = 0

    Public Sub SetListTracNghiem()
        For Each cc In bangChuCai.bangChuCai
            list.Add(cc.Value)
            listTam.Add(cc.Value)
        Next
        If Not list Is Nothing Then
            lblTong.Text = "Tổng số từ : " & list.Count
            lblSoTuDung.Text = "Số từ đúng : 0"
            lblSoTuSai.Text = "Số từ sai : 0"
            RanDomCauHoi()
        End If
    End Sub

    Private Sub RanDomCauHoi()
        If Not listTam Is Nothing Then
            Dim rd As New Random
            hoi = listTam.Item(rd.Next(listTam.Count))
            traLoi1 = list.Item(rd.Next(list.Count))
            traLoi2 = list.Item(rd.Next(list.Count))
            traLoi3 = list.Item(rd.Next(list.Count))
            While hoi.Equals(traLoi1)
                traLoi1 = list.Item(rd.Next(list.Count))
            End While
            While hoi.Equals(traLoi2) OrElse traLoi1.Equals(traLoi2)
                traLoi2 = list.Item(rd.Next(list.Count))
            End While
            While hoi.Equals(traLoi3) OrElse traLoi1.Equals(traLoi3) OrElse traLoi2.Equals(traLoi3)
                traLoi3 = list.Item(rd.Next(list.Count))
            End While

            lblCauHoi.Text = hoi.lama
            Select Case rd.Next(1, 4)
                Case 1
                    ShowCauHoi(hoi:=hoi, traloi1:=traLoi1, traloi2:=traLoi2, traloi3:=traLoi3)
                Case 2
                    ShowCauHoi(hoi:=traLoi1, traloi1:=hoi, traloi2:=traLoi2, traloi3:=traLoi3)
                Case 3
                    ShowCauHoi(hoi:=traLoi1, traloi1:=traLoi2, traloi2:=hoi, traloi3:=traLoi3)
                Case Else
                    ShowCauHoi(hoi:=traLoi1, traloi1:=traLoi2, traloi2:=traLoi3, traloi3:=hoi)
            End Select
        End If
    End Sub

    Private Sub ShowCauHoi(hoi, traloi1, traloi2, traloi3)
        Dim rd As New Random
        If rdbHinagana.Checked Then
            btnTraLoi1.Text = hoi.hinagana
            btnTraLoi2.Text = traloi1.hinagana
            btnTraLoi3.Text = traloi2.hinagana
            btnTraLoi4.Text = traloi3.hinagana
        ElseIf rdbKatakana.Checked Then
            btnTraLoi1.Text = hoi.katakana
            btnTraLoi2.Text = traloi1.katakana
            btnTraLoi3.Text = traloi2.katakana
            btnTraLoi4.Text = traloi3.katakana
        Else
            If rd.Next(1, 2) = 1 Then
                btnTraLoi1.Text = hoi.hinagana
            Else
                btnTraLoi1.Text = hoi.katakana
            End If
            If rd.Next(1, 2) = 1 Then
                btnTraLoi2.Text = traloi1.hinagana
            Else
                btnTraLoi2.Text = traloi1.katakana
            End If
            If rd.Next(1, 2) = 1 Then
                btnTraLoi3.Text = traloi2.hinagana
            Else
                btnTraLoi3.Text = traloi2.katakana
            End If
            If rd.Next(1, 2) = 1 Then
                btnTraLoi4.Text = traloi3.hinagana
            Else
                btnTraLoi4.Text = traloi3.katakana
            End If
        End If
    End Sub

    Private Sub btnTraLoi1_Click(sender As Object, e As EventArgs) Handles btnTraLoi1.Click
        If rdbHinagana.Checked Then
            If hoi.hinagana = btnTraLoi1.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        ElseIf rdbKatakana.Checked Then
            If hoi.katakana = btnTraLoi1.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        Else
            If hoi.hinagana = btnTraLoi1.Text Or hoi.katakana = btnTraLoi1.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & (list.Count * 2)
        End If
        lblSoTuDung.Text = "Số từ đúng : " & nDung
        lblSoTuSai.Text = "Số từ sai : " & nSai
        RanDomCauHoi()
    End Sub

    Private Sub btnTraLoi2_Click(sender As Object, e As EventArgs) Handles btnTraLoi2.Click
        If rdbHinagana.Checked Then
            If hoi.hinagana = btnTraLoi2.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        ElseIf rdbKatakana.Checked Then
            If hoi.katakana = btnTraLoi2.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        Else
            If hoi.hinagana = btnTraLoi2.Text Or hoi.katakana = btnTraLoi2.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & (list.Count * 2)
        End If
        lblSoTuDung.Text = "Số từ đúng : " & nDung
        lblSoTuSai.Text = "Số từ sai : " & nSai
        RanDomCauHoi()
    End Sub

    Private Sub btnTraLoi3_Click(sender As Object, e As EventArgs) Handles btnTraLoi3.Click
        If rdbHinagana.Checked Then
            If hoi.hinagana = btnTraLoi3.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        ElseIf rdbKatakana.Checked Then
            If hoi.katakana = btnTraLoi3.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        Else
            If hoi.hinagana = btnTraLoi3.Text Or hoi.katakana = btnTraLoi3.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & (list.Count * 2)
        End If
        lblSoTuDung.Text = "Số từ đúng : " & nDung
        lblSoTuSai.Text = "Số từ sai : " & nSai
        RanDomCauHoi()
    End Sub

    Private Sub btnTraLoi4_Click(sender As Object, e As EventArgs) Handles btnTraLoi4.Click
        If rdbHinagana.Checked Then
            If hoi.hinagana = btnTraLoi4.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        ElseIf rdbKatakana.Checked Then
            If hoi.katakana = btnTraLoi4.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & list.Count
        Else
            If hoi.hinagana = btnTraLoi4.Text Or hoi.katakana = btnTraLoi4.Text Then
                nDung += 1
                listTam.Remove(hoi)
            Else
                nSai += 1
            End If
            lblTong.Text = "Tổng số từ : " & (list.Count * 2)
        End If
        lblSoTuDung.Text = "Số từ đúng : " & nDung
        lblSoTuSai.Text = "Số từ sai : " & nSai
        RanDomCauHoi()
    End Sub
End Class
