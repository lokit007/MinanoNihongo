Imports WMPLib

Public Class ucChaoHoi
    Private audio As New WindowsMediaPlayer

    Public Sub initCauChao(ByVal cau As String, ByVal nghia As String, ByVal urlDoc As String)
        lblCau.Text = cau
        lblNghia.Text = "=> " & nghia
        audio.URL = urlDoc
        audio.controls.stop()
    End Sub

    Private Sub lblCau_Click(sender As Object, e As EventArgs) Handles lblCau.Click
        audio.controls.play()
    End Sub
End Class
