Public Class ChuCai_Parent
    Private bangChuCai As New BangChuCai_Object()
    Private btnSelect As String = "chon"

    Private Sub btnHinagana_Click(sender As Object, e As EventArgs) Handles btnHinagana.Click
        If btnSelect <> "Hinagana" Then
            cbShowLama.Visible = True
            lblThongBao.Text = "Bảng chữ cái Hinagana"
            pnMainControl.Controls.Clear()
            btnSelect = "Hinagana"
            'Show cac chu cai ra man hinh
            Dim point_x As Integer = 5
            Dim point_y As Integer = 5
            Dim chiso As Integer = 1
            For Each chuCai In bangChuCai.bangChuCai
                Dim chu As ChuCai_Object = chuCai.Value
                Dim fChuCai As New ucChuCai()
                fChuCai.initValue(chu.hinagana, chu.lama, cbShowLama.Checked)
                fChuCai.Location = New Point(point_x, point_y)
                If chiso Mod 5 = 0 Then
                    point_y += 100
                    point_x = 5
                Else
                    point_x += 100
                End If
                If chiso = 41 Or chiso = 43 Or chiso = 46 Or chiso = 48 _
                    Or (chiso >= 76 And (chiso Mod 10 = 1 Or chiso Mod 10 = 3 _
                                    Or chiso Mod 10 = 6 Or chiso Mod 10 = 8)) Then
                    chiso += 1
                    point_x += 100
                End If
                chiso += 1
                pnMainControl.Controls.Add(fChuCai)
            Next
        End If
    End Sub

    Private Sub btnKatakana_Click(sender As Object, e As EventArgs) Handles btnKatakana.Click
        If btnSelect <> "Katakana" Then
            cbShowLama.Visible = True
            lblThongBao.Text = "Bảng chữ cái Katakana"
            pnMainControl.Controls.Clear()
            btnSelect = "Katakana"
            'Show cac chu cai ra man hinh
            Dim point_x As Integer = 20
            Dim point_y As Integer = 5
            Dim chiso As Integer = 1
            For Each chuCai In bangChuCai.bangChuCai
                Dim chu As ChuCai_Object = chuCai.Value
                Dim fChuCai As New ucChuCai()
                fChuCai.initValue(chu.katakana, chu.lama, cbShowLama.Checked)
                fChuCai.Location = New Point(point_x, point_y)
                If chiso Mod 5 = 0 Then
                    point_y += 100
                    point_x = 20
                Else
                    point_x += 100
                End If
                If chiso = 41 Or chiso = 43 Or chiso = 46 Or chiso = 48 _
                    Or (chiso >= 76 And (chiso Mod 10 = 1 Or chiso Mod 10 = 3 _
                                    Or chiso Mod 10 = 6 Or chiso Mod 10 = 8)) Then
                    chiso += 1
                    point_x += 100
                End If
                chiso += 1
                pnMainControl.Controls.Add(fChuCai)
            Next
        End If
    End Sub

    Private Sub btnTracNghiem_Click(sender As Object, e As EventArgs) Handles btnTracNghiem.Click
        lblThongBao.Text = "Trắc nghiệm bảng chữ cái"
        cbShowLama.Visible = False
        pnMainControl.Controls.Clear()
        Dim tracNghiem As New ucTracNghiem()
        tracNghiem.SetListTracNghiem()
        pnMainControl.Controls.Add(tracNghiem)
    End Sub

    Private Sub btnVietTheo_Click(sender As Object, e As EventArgs) Handles btnVietTheo.Click

    End Sub

    Private Sub cbShowLama_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowLama.CheckedChanged
        For Each f In pnMainControl.Controls
            If TypeOf (f) Is ucChuCai Then
                f.ShowLama(cbShowLama.Checked)
            End If
        Next
    End Sub
End Class