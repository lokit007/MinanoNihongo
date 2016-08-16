Imports AxWMPLib
Imports WMPLib

Public Class ucHoiThoai
    Private lst As List(Of HoiThoai_Object)
    Private hoiThoai As HoiThoai_Object

    Public Sub InitListHoiThoai(ByRef lstResult As List(Of HoiThoai_Object))
        lst = lstResult
        Dim rootPath As String = My.Application.Info.DirectoryPath.Replace("bin\Debug", "Resources\AudioFiles\")
        lbHoiThoai.Items.Clear()

        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            For Each pt In lst
                lbHoiThoai.Items.Add(pt.urlAmThanh)
                AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(rootPath & pt.urlAmThanh))

            Next

        End If

    End Sub

    Private Sub AxWindowsMediaPlayer1_CurrentItemChange(sender As Object, e As _WMPOCXEvents_CurrentItemChangeEvent) Handles AxWindowsMediaPlayer1.CurrentItemChange
        Dim itemSelect As String = AxWindowsMediaPlayer1.currentMedia.sourceURL
        lbHoiThoai.SelectedItem = itemSelect.Substring(itemSelect.LastIndexOf("\") + 1)

    End Sub

    Private Sub lbHoiThoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbHoiThoai.SelectedIndexChanged
        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            hoiThoai = lst.Item(lbHoiThoai.SelectedIndex)
            showHoiThoai()

        End If

    End Sub

    Private Sub showHoiThoai()
        If Not IsNothing(lst) AndAlso lst.Count > 0 AndAlso Not IsNothing(hoiThoai) Then
            Select Case Color.IndianRed
                Case btnNoiDung.BackColor
                    rbResult.Text = hoiThoai.noiDung

                Case btnHanTu.BackColor
                    rbResult.Text = hoiThoai.hanTu

                Case btnDichBai.BackColor
                    rbResult.Text = hoiThoai.phienDich

            End Select

        End If

    End Sub

    Private Sub btnNoiDung_Click(sender As Object, e As EventArgs) Handles btnNoiDung.Click
        setButtonSelect(btnNoiDung, btnDichBai, btnHanTu)
        showHoiThoai()

    End Sub

    Private Sub btnHanTu_Click(sender As Object, e As EventArgs) Handles btnHanTu.Click
        setButtonSelect(btnHanTu, btnNoiDung, btnDichBai)
        showHoiThoai()

    End Sub

    Private Sub btnDichBai_Click(sender As Object, e As EventArgs) Handles btnDichBai.Click
        setButtonSelect(btnDichBai, btnNoiDung, btnHanTu)
        showHoiThoai()

    End Sub

    Private Sub setButtonSelect(ByRef bt1, ByRef bt2, ByRef bt3)
        bt1.BackColor = Color.IndianRed
        bt1.ForeColor = Color.White
        bt2.BackColor = SystemColors.Control
        bt2.ForeColor = Color.Black
        bt3.BackColor = SystemColors.Control
        bt3.ForeColor = Color.Black

    End Sub

End Class
