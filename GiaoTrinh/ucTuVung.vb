Imports AxWMPLib

Public Class ucTuVung
    Private lst As List(Of TuVung_Object)
    Private tuVung As TuVung_Object
    Private audio As New AxWindowsMediaPlayer

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

        End If

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
            audio.URL = "E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\Bai1_Kotoba_1.mp3"
            MsgBox(audio.URL)
            audio.Ctlcontrols.play()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnKiemTra_Click(sender As Object, e As EventArgs) Handles btnKiemTra.Click

    End Sub

    Private Sub btnThuoc_Click(sender As Object, e As EventArgs) Handles btnThuoc.Click

    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click

    End Sub

End Class
