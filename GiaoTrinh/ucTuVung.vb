Imports AxWMPLib
Imports WMPLib

Public Class ucTuVung
    Private lst As List(Of TuVung_Object)
    Private tuVung As TuVung_Object
    Private audio As New WindowsMediaPlayer
    Private rd As New Random

    Public Sub InitListTuVung(ByRef lstTuVung As List(Of TuVung_Object))
        lst = lstTuVung

        If IsNothing(lst) OrElse lst.Count < 1 Then
            ShowTrangThai("Danh sách rỗng :'(", Color.Yellow, Color.Black)
            tuVung = Nothing
            pcbAnhMinhHoa.Image = Nothing
            tbTuVung.Text = ""
            tbHanTu.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""

        Else
            ShowTrangThai("", Color.Gray, Color.Black)
            btnTiep_Click(Me, New EventArgs)

        End If

    End Sub

    Private Sub ShowSelect(ByVal tu As String, ByVal nghia As String)
        If Not IsNothing(tuVung) Then
            btnKiemTra.Enabled = Not rbtnShowAll.Checked
            tbTuVung.ReadOnly = Not rbtnNhapTuVung.Checked
            tbNguNghia.ReadOnly = Not rbtnDichNghia.Checked
            tbTuVung.Text = tu
            tbNguNghia.Text = nghia

        End If

    End Sub

    Private Sub ShowSelect()
        If Not IsNothing(tuVung) Then
            rbtnShowAll_CheckedChanged(Me, New EventArgs)

            Try
                pcbAnhMinhHoa.Image = Image.FromFile("../../Resources/ImageFiles/" & tuVung.urlAnhMoTa)

            Catch ex As Exception
                pcbAnhMinhHoa.Image = Nothing

            End Try

            tbHanTu.Text = tuVung.hanTu
            tbViDu.Text = ""

            If Not IsNothing(tuVung.lstViDu) Then
                For Each vidu As ViDu_Object In tuVung.lstViDu
                    tbViDu.AppendText(vidu.noiDung & vbCrLf)

                Next

            End If

        Else
            pcbAnhMinhHoa.Image = Nothing
            tbTuVung.Text = ""
            tbHanTu.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""

        End If

    End Sub

    Private Sub ShowTrangThai(mes, col1, col2)
        lblTrangThai.Text = mes
        lblTrangThai.BackColor = col1
        lblTrangThai.ForeColor = col2

    End Sub

    Private Sub rbtnShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnShowAll.CheckedChanged, rbtnNhapTuVung.CheckedChanged, rbtnDichNghia.CheckedChanged
        If Not IsNothing(tuVung) Then
            If rbtnShowAll.Checked Then
                ShowSelect(tuVung.tuVung, tuVung.nguNghia)

            ElseIf rbtnNhapTuVung.Checked Then
                ShowSelect("", tuVung.nguNghia)

            ElseIf rbtnDichNghia.Checked Then
                ShowSelect(tuVung.tuVung, "")

            End If

        End If
    End Sub

    Private Sub btnNgheLai_Click(sender As Object, e As EventArgs) Handles btnNgheLai.Click
        Try
            If audio.playState <> WMPPlayState.wmppsPlaying Then
                audio.URL = My.Application.Info.DirectoryPath.Replace("bin\Debug", "Resources\AudioFiles\") & tuVung.urlAmDoc
                audio.controls.play()

            Else
                audio.controls.stop()

            End If

        Catch ex As Exception
            audio.close()

        End Try

    End Sub

    Private Sub btnKiemTra_Click(sender As Object, e As EventArgs) Handles btnKiemTra.Click
        If Not IsNothing(tuVung) Then
            If rbtnNhapTuVung.Checked Then
                If Not String.IsNullOrEmpty(tbTuVung.Text) _
                    AndAlso String.Compare(tuVung.tuVung.Trim, tbTuVung.Text.Trim, True) = 0 Then
                    ShowTrangThai("Bạn có trí nhớ thật siêu phàm (y).", Color.Green, Color.Black)
                    btnThuoc_Click(sender, e)

                Else
                    ShowTrangThai("Sai rồi :(. Vui lòng nhập lại", Color.Yellow, Color.Black)
                    tbTuVung.SelectAll()
                    tbTuVung.Focus()

                End If

            ElseIf rbtnDichNghia.Checked Then
                If Not String.IsNullOrEmpty(tbNguNghia.Text) _
                    AndAlso String.Compare(tuVung.nguNghia.Trim, tbNguNghia.Text.Trim.Trim, True) Then
                    ShowTrangThai("Bạn có trí nhớ thật siêu phàm (y).", Color.Green, Color.Black)
                    btnThuoc_Click(sender, e)

                Else
                    ShowTrangThai("Sai rồi :(. Vui lòng nhập lại", Color.Yellow, Color.Black)
                    tbNguNghia.SelectAll()
                    tbNguNghia.Focus()

                End If
            Else
                ShowTrangThai("Chưa chọn đúng chức năng", Color.MediumVioletRed, Color.White)

            End If
        End If

    End Sub

    Private Sub btnThuoc_Click(sender As Object, e As EventArgs) Handles btnThuoc.Click
        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            lst.Remove(tuVung)
            btnTiep_Click(sender, e)

        Else
            ShowTrangThai("Chúc mừng bạn đã học xong (y).", Color.Green, Color.Black)
            pcbAnhMinhHoa.Image = Nothing
            tbTuVung.Text = ""
            tbHanTu.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""

        End If

    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click
        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            tuVung = lst.Item(rd.Next(lst.Count))
            ShowSelect()

        Else
            ShowTrangThai("Chúc mừng bạn đã học xong (y).", Color.Green, Color.Black)
            pcbAnhMinhHoa.Image = Nothing
            tbTuVung.Text = ""
            tbHanTu.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""

        End If

    End Sub

End Class
