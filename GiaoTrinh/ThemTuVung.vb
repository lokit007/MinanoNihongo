Imports System.Media
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class ThemTuVung
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String,
                                                                            ByVal lpstrReturnString As String,
                                                                            ByVal uReturnLength As Integer,
                                                                            ByVal hwndCallback As Integer) As Integer

    Private pathSource As String = My.Application.Info.DirectoryPath.Replace("bin\Debug", "Resources\AudioFiles\tuvung_")

    Private giay As Integer = 0
    Private connect As New ConnectData
    Private conn As SqlConnection
    Private lstViDuAdd As New Dictionary(Of String, ViDu_Object)

    Private Sub ThemTuVung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connect.getConnect
        cbBaiHoc.DataSource = GetListBaiHoc()
        cbBaiHoc.DisplayMember = "TenBaiHoc"
        cbBaiHoc.ValueMember = "IdBaiHoc"
        cbBaiHoc.Text = "Chọn bài học"
        pathSource &= GetNewIdTuVung() & ".wav"

        lbViDu.DataSource = lstViDuAdd.ToList
        lbViDu.DisplayMember = "Key"
        lbViDu.ValueMember = "Key"

    End Sub

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

    Private Function GetNewIdTuVung() As Integer
        Dim dtResult As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim strSQl As New StringBuilder

        Try
            strSQl.Append("select case when max(IdTuVung) is null then 1 else max(IdTuVung)+1 end as NewIdTuVung from TUVUNG ")

            cmd.CommandText = strSQl.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult.Rows(0).Item("NewIdTuVung")
            
        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub btnGhiAm_Click(sender As Object, e As EventArgs) Handles btnGhiAm.Click
        giay = 0
        Timer1.Start()
        record("open new Type waveaudio Alias recsound", "", 0, 0)
        record("record recsound", "", 0, 0)

    End Sub

    Private Sub btnLuuDung_Click(sender As Object, e As EventArgs) Handles btnLuuDung.Click
        Timer1.Stop()

        'If File.Exists(pathSource) Then
        '    File.Delete(pathSource)
        'End If

        record("save recsound " & pathSource, "", 0, 0)
        record("close recsound", "", 0, 0)
        tbAmDieu.Text = pathSource

    End Sub

    Private Sub btnNgheLai_Click(sender As Object, e As EventArgs) Handles btnNgheLai.Click
        'My.Computer.Audio.Play("D:\mic.wav", AudioPlayMode.Background)
        Try
            Dim audio As New AxWMPLib.AxWindowsMediaPlayer
            audio.URL = tbAmDieu.Text
            audio.Ctlcontrols.play()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ptbAnhMinhHoa_Click(sender As Object, e As EventArgs) Handles ptbAnhMinhHoa.Click
        OpenFileDialog1.Filter = "PNG|*.png|JPG|*.jpg"
        Dim btnResult As DialogResult = OpenFileDialog1.ShowDialog

        If btnResult = DialogResult.OK Then
            ptbAnhMinhHoa.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        giay += 1
        tbAmDieu.Text = CInt(giay / 60).ToString("00") & ":" & (giay Mod 60).ToString("00")

    End Sub

    Private Sub lbDinhKem_Click(sender As Object, e As EventArgs) Handles lbDinhKem.Click
        OpenFileDialog1.Filter = "MP3|*.mp3|WAV|*.wav"
        Dim btnResult As DialogResult = OpenFileDialog1.ShowDialog

        If btnResult = DialogResult.OK Then
            tbAmDieu.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        tbViDu.Text = ""
        tbDichNghia.Text = ""

    End Sub

    Private Sub btnThemViDu_Click(sender As Object, e As EventArgs) Handles btnThemViDu.Click
        Try
            If Not String.IsNullOrEmpty(tbViDu.Text) Then
                If Not String.IsNullOrEmpty(tbDichNghia.Text) Then
                    lstViDuAdd.Add(tbViDu.Text,
                        New ViDu_Object With {.noiDung = tbViDu.Text, .nguNghia = tbDichNghia.Text})
                    lbViDu.DataSource = lstViDuAdd.ToList

                Else
                    tbDichNghia.Focus()

                End If
            Else
                tbViDu.Focus()

            End If

        Catch ex As Exception
            tbViDu.Text = ""
            tbDichNghia.Text = ""
            tbViDu.Focus()
            MsgBox("Đã tồn tại ví dụ trong danh sách.", MsgBoxStyle.OkOnly, "Đã tồn tại trong danh sách")

        End Try
    End Sub

    Private Sub lbViDu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbViDu.SelectedIndexChanged
        If lbViDu.SelectedIndex > -1 Then
            Dim viDu As ViDu_Object = lstViDuAdd.Item(lbViDu.SelectedItem.key)

            If Not IsNothing(viDu) Then
                tbViDu.Text = viDu.noiDung
                tbDichNghia.Text = viDu.nguNghia

            End If

        End If
    End Sub

    Private Sub btnXoaViDu_Click(sender As Object, e As EventArgs) Handles btnXoaViDu.Click
        If lbViDu.SelectedIndex > -1 Then
            Dim btnSelect As DialogResult = MsgBox("Bạn muốn xóa ví dụ này khỏi danh sách ???", MsgBoxStyle.YesNo, "Xóa ví dụ")

            Try
                If btnSelect = DialogResult.Yes Then
                    lstViDuAdd.Remove(lbViDu.SelectedItem.key)
                    lbViDu.DataSource = lstViDuAdd.ToList

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnThemTuVung_Click(sender As Object, e As EventArgs) Handles btnThemTuVung.Click
        Dim idTuVung As Integer = GetNewIdTuVung()
        Dim cmd As New SqlCommand
        Dim pathImage As String = My.Application.Info.DirectoryPath.Replace("bin\Debug", "Resources\ImageFiles\tuvung_") & idTuVung & ".png"
        Dim pathAmThanh As String = ""

        Try
            cmd.CommandText = "ThemTuVung"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            'set input value
            cmd.Parameters.AddWithValue("@BaiHoc", cbBaiHoc.Text)
            cmd.Parameters.AddWithValue("@TuVung", tbTuVung.Text)
            cmd.Parameters.AddWithValue("@HanTu", tbHanTu.Text)
            cmd.Parameters.AddWithValue("@NguNghia", tbNguNghia.Text)


            Try
                pathAmThanh = pathSource.Replace("wav", tbAmDieu.Text.Substring(tbAmDieu.Text.LastIndexOf(".") + 1))

                If Not File.Exists(pathAmThanh) Then
                    File.Copy(tbAmDieu.Text, pathAmThanh)

                End If

                cmd.Parameters.AddWithValue("@Anh", pathImage.Substring(pathImage.LastIndexOf("\") + 1))

            Catch ex As Exception
                cmd.Parameters.AddWithValue("@Anh", "")

            End Try
            Try
                ptbAnhMinhHoa.Image.Save(pathImage, Imaging.ImageFormat.Png)
                cmd.Parameters.AddWithValue("@Doc", pathAmThanh.Substring(pathAmThanh.LastIndexOf("\") + 1))

            Catch ex As Exception
                cmd.Parameters.AddWithValue("@Doc", "")

            End Try

            'set output value
            cmd.Parameters.AddWithValue("@IdTuVung", -1)
            'or cmd.Parameters.Add("@IdTuVung", SqlDbType.Int)
            cmd.Parameters("@IdTuVung").Direction = ParameterDirection.Output

            conn.Open()
            cmd.ExecuteNonQuery()
            'get output value
            idTuVung = cmd.Parameters("@IdTuVung").Value

            If idTuVung > -1 Then
                For Each vidu In lstViDuAdd
                    InsertViDu(idTuVung, "TUVUNG", vidu.Key, vidu.Value.nguNghia)

                Next

            End If

            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            Throw
        End Try

        Me.Close()

    End Sub

    Private Sub InsertViDu(ByVal khoa As Integer, ByVal bang As String, ByVal viDu As String, ByVal nghia As String)
        Dim cmd As New SqlCommand

        Try
            cmd.CommandText = "ThemViDu"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            'set input value
            cmd.Parameters.AddWithValue("@Khoa", khoa)
            cmd.Parameters.AddWithValue("@Bang", bang)
            cmd.Parameters.AddWithValue("@ViDu", viDu)
            cmd.Parameters.AddWithValue("@HanTu", "")
            cmd.Parameters.AddWithValue("@NguNghia", nghia)
            cmd.Parameters.AddWithValue("@Anh", "")
            cmd.Parameters.AddWithValue("@Doc", "")
            'set output value
            cmd.Parameters.AddWithValue("@IdViDu", -1)
            'or cmd.Parameters.Add("@IdTuVung", SqlDbType.Int)
            cmd.Parameters("@IdViDu").Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Throw

        End Try

    End Sub

End Class