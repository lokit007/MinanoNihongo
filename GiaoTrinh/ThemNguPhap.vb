Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports WMPLib

Public Class ThemNguPhap
    'Biến sử dụng
    Private pathAudioLocation As String = String.Empty
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String,
                                                                            ByVal lpstrReturnString As String,
                                                                            ByVal uReturnLength As Integer,
                                                                            ByVal hwndCallback As Integer) As Integer

    Private pathSource As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\AudioFiles\nguphap_"

    Private giay As Integer = 0
    Private connect As New ConnectData
    Private conn As SqlConnection = connect.getConnect
    Private lstViDuAdd As New Dictionary(Of String, ViDu_Object)
    Private audio As New WindowsMediaPlayer

    'Sự kiện trong form
    Private Sub ThemNguPhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pathSource &= GetNewIdNguPhap() & ".wav"

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.Filter = "File audio|*.mp3;*.wav"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pathAudioLocation = OpenFileDialog1.FileName
            tbAmDoc.Text = pathAudioLocation.Substring(pathAudioLocation.LastIndexOf("\") + 1)
        End If
    End Sub

    Private Sub btnGhiAm_Click(sender As Object, e As EventArgs) Handles btnGhiAm.Click
        btnGhiAm.Enabled = False
        btnLuuDung.Enabled = True
        pathAudioLocation = String.Empty
        record("open new Type waveaudio Alias recsound", "", 0, 0)
        record("record recsound", "", 0, 0)
    End Sub

    Private Sub btnLuuDung_Click(sender As Object, e As EventArgs) Handles btnLuuDung.Click
        btnGhiAm.Enabled = True
        btnLuuDung.Enabled = False
        record("save recsound " & pathSource, "", 0, 0)
        record("close recsound", "", 0, 0)
        tbAmDoc.Text = pathSource.Substring(pathSource.LastIndexOf("\") + 1)
    End Sub

    Private Sub btnNgheLai_Click(sender As Object, e As EventArgs) Handles btnNgheLai.Click
        Try
            If audio.playState <> WMPPlayState.wmppsPlaying Then
                If String.IsNullOrEmpty(pathAudioLocation) Then
                    audio.URL = pathSource
                Else
                    audio.URL = pathAudioLocation
                End If
                audio.controls.play()
            Else
                audio.controls.stop()
            End If
        Catch ex As Exception
            audio.controls.stop()
        End Try
    End Sub

    Private Sub btnLamTrong_Click(sender As Object, e As EventArgs) Handles btnLamTrong.Click
        tbViDu.Text = String.Empty
        tbNguNghia.Text = String.Empty

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub btnThemViDu_Click(sender As Object, e As EventArgs) Handles btnThemViDu.Click

    End Sub

    Private Sub btnThemNguPhap_Click(sender As Object, e As EventArgs) Handles btnThemNguPhap.Click

    End Sub

    Private Sub controlEnter(sender As Object, e As EventArgs) Handles tbViDu.Enter, tbNguNghia.Enter,
        rtbNguNghia.Enter, rtbCachDung.Enter, rtbCauTruc.Enter
        Select Case True
            Case rtbCauTruc Is sender AndAlso "Cấu trúc ...".Equals(rtbCauTruc.Text)
                rtbCauTruc.Clear()
            Case rtbNguNghia Is sender AndAlso "Ngữ nghĩa ...".Equals(rtbNguNghia.Text)
                rtbNguNghia.Clear()
            Case rtbCachDung Is sender AndAlso "Cách dùng ...".Equals(rtbCachDung.Text)
                rtbCachDung.Clear()
            Case tbViDu Is sender AndAlso "Ví dụ ...".Equals(tbViDu.Text)
                tbViDu.Clear()
            Case tbNguNghia Is sender AndAlso "Ngữ nghĩa ví dụ ...".Equals(tbNguNghia.Text)
                tbNguNghia.Clear()
        End Select
    End Sub

    Private Sub controlLeave(sender As Object, e As EventArgs) Handles tbViDu.Leave, tbNguNghia.Leave,
        rtbNguNghia.Leave, rtbCauTruc.Leave, rtbCachDung.Leave
        Select Case True
            Case rtbCauTruc Is sender AndAlso String.IsNullOrEmpty(rtbCauTruc.Text)
                rtbCauTruc.Text = "Cấu trúc ..."
            Case rtbNguNghia Is sender AndAlso String.IsNullOrEmpty(rtbNguNghia.Text)
                rtbNguNghia.Text = "Ngữ nghĩa ..."
            Case rtbCachDung Is sender AndAlso String.IsNullOrEmpty(rtbCachDung.Text)
                rtbCachDung.Text = "Cách dùng ..."
            Case tbViDu Is sender AndAlso String.IsNullOrEmpty(tbViDu.Text)
                tbViDu.Text = "Ví dụ ..."
            Case tbNguNghia Is sender AndAlso String.IsNullOrEmpty(tbNguNghia.Text)
                tbNguNghia.Text = "Ngữ nghĩa ví dụ ..."
        End Select
    End Sub

    'Định nghĩa dùng chung
    Private Function GetNewIdNguPhap() As Integer
        Dim dtResult As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim strSQl As New StringBuilder

        Try
            strSQl.Append("select case when max(IdNguPhap) is null then 1 else max(IdNguPhap)+1 end as NewIdNguPhap from NGUPHAP ")

            cmd.CommandText = strSQl.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult.Rows(0).Item("NewIdNguPhap")
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class