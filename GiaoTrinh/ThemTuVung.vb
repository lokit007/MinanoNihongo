Imports System.Media
Imports System.Runtime.InteropServices

Public Class ThemTuVung
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String,
                                                                            ByVal lpstrReturnString As String,
                                                                            ByVal uReturnLength As Integer,
                                                                            ByVal hwndCallback As Integer) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        record("open new Type waveaudio Alias recsound", "", 0, 0)
        record("record recsound", "", 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        record("save recsound E:\mic.wav", "", 0, 0)
        record("close recsound", "", 0, 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play("E:\mic.wav", AudioPlayMode.Background)
    End Sub

End Class