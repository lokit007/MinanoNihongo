Public Class ucVietTheo
    Private imageCurent As String = "Hiragana_1"
    Private pathRoot As String = My.Application.Info.DirectoryPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")

    Public Sub loadBangChuCai(ByVal bang As String)
        Try
            PictureBox1.Image = Image.FromFile(pathRoot & "\Resources\ImageFiles\Viet_" & bang & ".png")
        Catch ex As Exception
            MsgBox("Không load được dữ liệu!")
        End Try
    End Sub

    Private Sub lbNext_Click(sender As Object, e As EventArgs) Handles lbNext.Click
        Select Case imageCurent
            Case "Hiragana_1"
                imageCurent = "Hiragana_2"
            Case "Hiragana_2"
                imageCurent = "Katakana_1"
            Case "Katakana_1"
                imageCurent = "Katakana_2"
            Case "Katakana_2"
                imageCurent = "Hiragana_1"
        End Select
        If System.IO.File.Exists(pathRoot & "\Resources\ImageFiles\Viet_" & imageCurent & ".png") Then
            PictureBox1.Image = Image.FromFile(pathRoot & "\Resources\ImageFiles\Viet_" & imageCurent & ".png")
        End If
    End Sub
End Class
