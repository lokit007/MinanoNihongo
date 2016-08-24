Imports AxWMPLib
Imports WMPLib

Public Class ucNguPhap
    Private lst As List(Of NguPhap_Object)
    Private nguPhap As NguPhap_Object
    Private audio As New WindowsMediaPlayer
    Private rd As New Random

    Public Sub InitListNguPhap(ByRef lstTuVung As List(Of NguPhap_Object))
        lst = lstTuVung
        If IsNothing(lst) OrElse lst.Count < 1 Then
            ShowTrangThai("Danh sách rỗng :'(", Color.Yellow, Color.Black)
            nguPhap = Nothing
            tbCauTruc.Text = ""
            tbCachDung.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""
        Else
            ShowTrangThai("", Color.Gray, Color.Black)
            btnTiep_Click(Me, New EventArgs)
        End If
    End Sub

    Private Sub ShowTrangThai(mes, col1, col2)
        lblTrangThai.Text = mes
        lblTrangThai.BackColor = col1
        lblTrangThai.ForeColor = col2
    End Sub

    Private Sub btnThuoc_Click(sender As Object, e As EventArgs) Handles btnThuoc.Click
        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            lst.Remove(nguPhap)
            btnTiep_Click(sender, e)
        Else
            ShowTrangThai("Chúc mừng bạn đã học xong (y).", Color.Green, Color.Black)
            nguPhap = Nothing
            tbCauTruc.Text = ""
            tbCachDung.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""
        End If
    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click
        If Not IsNothing(lst) AndAlso lst.Count > 0 Then
            nguPhap = lst.Item(rd.Next(lst.Count))
            If Not IsNothing(nguPhap) Then
                tbCauTruc.Text = nguPhap.cauTruc
                tbCachDung.Text = nguPhap.cachDung
                tbNguNghia.Text = nguPhap.nguNghia
                tbViDu.Text = ""
                If Not IsNothing(nguPhap.lstViDu) Then
                    For Each vidu As ViDu_Object In nguPhap.lstViDu
                        tbViDu.AppendText(vidu.noiDung & vbCrLf)
                    Next
                End If
            Else
                ShowTrangThai("Chúc mừng bạn đã học xong (y).", Color.Green, Color.Black)
                tbCauTruc.Text = ""
                tbCachDung.Text = ""
                tbNguNghia.Text = ""
                tbViDu.Text = ""
            End If
        Else
            nguPhap = Nothing
            tbCauTruc.Text = ""
            tbCachDung.Text = ""
            tbNguNghia.Text = ""
            tbViDu.Text = ""
        End If
    End Sub
End Class
