Imports WMPLib
Imports System.IO

Public Class ucChaoHoi
    Private audio As New WindowsMediaPlayer

    Public Sub initCauChao(ByVal cau As String, ByVal nghia As String, ByVal urlDoc As String)
        lblCau.Text = cau
        lblNghia.Text = "=> " & nghia
        If File.Exists(urlDoc) Then
            audio.URL = urlDoc
            audio.controls.stop()
        End If
    End Sub

    Private Sub lblCau_Click(sender As Object, e As EventArgs) Handles lblCau.Click
        If Not audio.playState = WMPPlayState.wmppsPlaying Then
            audio.controls.play()
        End If
    End Sub
End Class
