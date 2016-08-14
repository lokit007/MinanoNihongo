Public Class ucNgayThang
    Private listNam As New List(Of SoDem_Object)
    Private listThang As New List(Of SoDem_Object)
    Private listNgay As New List(Of SoDem_Object)
    Private listThu As New List(Of SoDem_Object)
    Private chiSo As Integer = 0
    Private max As Integer = 0

    Public Sub initList(ByRef lstNam As Dictionary(Of String, SoDem_Object),
                        ByRef lstThang As Dictionary(Of String, SoDem_Object),
                        ByRef lstNgay As Dictionary(Of String, SoDem_Object),
                        ByRef lstThu As Dictionary(Of String, SoDem_Object))
        If Not lstNam Is Nothing Then
            For Each nam In lstNam
                listNam.Add(nam.Value)
            Next
        End If
        If Not lstThang Is Nothing Then
            For Each thang In lstThang
                listThang.Add(thang.Value)
            Next
        End If
        If Not lstNgay Is Nothing Then
            For Each ngay In lstNgay
                listNgay.Add(ngay.Value)
            Next
        End If
        If Not lstThu Is Nothing Then
            For Each thu In lstThu
                listThu.Add(thu.Value)
            Next
        End If
        Try
            ShowNgayThang()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ShowNgayThang()
        If rbtnNam.Checked Then
            max = listNam.Count
        ElseIf rbtnThang.Checked Then
            max = listThang.Count
        ElseIf rbtnNgay.Checked Then
            max = listNgay.Count
        Else
            max = listThu.Count
        End If
        If cbRanDom.Checked Then
            Dim rd As New Random
            chiSo = rd.Next(max)
        ElseIf chiSo >= max Then
            chiSo = 0
        End If
        Try
            Dim pt As SoDem_Object
            If rbtnNam.Checked Then
                pt = listNam.Item(chiSo)
            ElseIf rbtnThang.Checked Then
                pt = listThang.Item(chiSo)
            ElseIf rbtnNgay.Checked Then
                pt = listNgay.Item(chiSo)
            Else
                pt = listThu.Item(chiSo)
            End If
            btnChinh.Text = pt.hinagana
            If cbShowKanji.Checked And pt.kanji <> "" Then
                btnChinh.Text &= vbCr & "[" & pt.kanji & "]"
            End If
            lblThongTin.Text = ""
            If cbShowNguNghia.Checked Then
                lblThongTin.Text = pt.nguNghia
            End If
            If cbShowLama.Checked Then
                lblThongTin.Text &= " [" & pt.lama & "]"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnTruoc_Click(sender As Object, e As EventArgs) Handles btnTruoc.Click
        chiSo -= 1
        ShowNgayThang()
    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click
        chiSo += 1
        ShowNgayThang()
    End Sub

End Class
