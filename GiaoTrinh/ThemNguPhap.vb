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

        cbBaiHoc.DataSource = GetListBaiHoc()
        cbBaiHoc.DisplayMember = "TenBaiHoc"
        cbBaiHoc.ValueMember = "IdBaiHoc"
        cbBaiHoc.Text = "----- Thêm vào bài học -----"

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
        tbAmDoc.Text = String.Empty
        pathAudioLocation = String.Empty

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvViDu.RowCount > 0 _
            AndAlso MsgBox("Bạn muốn xóa các ví dụ được đánh dấu ???", MsgBoxStyle.YesNo, "Xóa ví dụ !!!") = DialogResult.Yes Then
            dgvViDu.CurrentCell = Nothing
            For Each pt As DataGridViewRow In dgvViDu.Rows
                If pt.Cells(0).Value = True Then
                    lstViDuAdd.Remove(pt.Cells(1).Value)
                    dgvViDu.Rows.Remove(pt)
                End If
            Next
        End If
    End Sub

    Private Sub btnThemViDu_Click(sender As Object, e As EventArgs) Handles btnThemViDu.Click
        Try
            If Not String.IsNullOrEmpty(tbViDu.Text) AndAlso Not String.IsNullOrEmpty(tbNguNghia.Text) Then
                Dim vidu As New ViDu_Object
                vidu.noiDung = tbViDu.Text
                vidu.nguNghia = tbNguNghia.Text
                vidu.urlAmDoc = tbAmDoc.Text
                Try
                    lstViDuAdd.Add(tbViDu.Text, vidu)
                    If Not String.IsNullOrEmpty(pathAudioLocation) Then
                        SaveFile(pathAudioLocation, pathSource.Replace("wav", pathAudioLocation.Substring(pathAudioLocation.LastIndexOf(".") + 1)))
                    End If
                    AddNewRowGridView(tbViDu.Text)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Throw
        End Try
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

    Private Sub dgvViDu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViDu.CellClick
        Try
            If e.ColumnIndex = 2 AndAlso e.RowIndex <> -1 Then
                lstViDuAdd.Remove(dgvViDu.CurrentRow.Cells(1).Value)
                dgvViDu.Rows.RemoveAt(e.RowIndex)

            ElseIf e.ColumnIndex = 0 AndAlso e.RowIndex = -1 Then
                dgvViDu.CurrentCell = Nothing
                If dgvViDu.RowCount > 0 Then
                    For Each pt As DataGridViewRow In dgvViDu.Rows
                        pt.Cells(0).Value = Not pt.Cells(0).Value
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

    Private Function GetListBaiHoc() As DataTable
        Dim dtResult As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim strSQl As New StringBuilder

        Try
            strSQl.Append("select * from BAIHOC ")

            cmd.CommandText = strSQl.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub SaveFile(ByVal pathNguon As String, ByVal pathDich As String)
        Try
            If Not String.IsNullOrEmpty(pathNguon) AndAlso Not String.IsNullOrEmpty(pathDich) _
                AndAlso System.IO.File.Exists(pathNguon) Then
                If File.Exists(pathDich) Then
                    File.Delete(pathDich)
                End If
                File.Copy(pathNguon, pathDich, True)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Throw
        End Try
    End Sub

    Private Sub AddNewRowGridView(ByVal vidu As String)
        If Not String.IsNullOrEmpty(vidu) Then
            Dim indexNewRow As Integer = dgvViDu.Rows.Add()
            dgvViDu.Rows(indexNewRow).Cells(1).Value = vidu
        End If
    End Sub


End Class