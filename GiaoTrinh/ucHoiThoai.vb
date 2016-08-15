Imports AxWMPLib
Imports WMPLib

Public Class ucHoiThoai
    Private lst As List(Of HoiThoai_Object)
    Private hoiThoai As HoiThoai_Object
    Private rd As New Random

    Public Sub InitListHoiThoai(ByRef lstResult As List(Of HoiThoai_Object))
        lst = lstResult

        lbHoiThoai.Items.Clear()

        'If Not IsNothing(lst) AndAlso lst.Count > 0 Then
        '    For Each pt In lst
        '        lbHoiThoai.Items.Add(pt.urlAmThanh)

        '    Next

        'End If

        'AxWindowsMediaPlayer1.URL = "E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\Bai1_Kotoba_1.mp3"
        AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia("E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\1 - 1 - Kotoba.mp3"))
        AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia("E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\1 - 2 - Bunkei.mp3"))
        AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia("E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\1 - 3 - Reibun.mp3"))
        AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia("E:\DUAN\VBNET\MinanoNihongo\MinanoNihongo\MinanoNihongo\Resources\AudioFiles\1 - 5 - Kaiwa.mp3"))

    End Sub

End Class
