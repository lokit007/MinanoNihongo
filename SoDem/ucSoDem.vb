Public Class ucSoDem
    Private list As New List(Of SoDem_Object)
    Private chiSo As Integer = 0
    Private max As Integer = 0

    Public Sub initList(ByRef soDem As Dictionary(Of String, SoDem_Object))
        If Not soDem Is Nothing Then
            For Each so In soDem
                list.Add(so.Value)
            Next
            max = list.Count
            ShowSoDem()
        End If
    End Sub

    Private Sub ShowSoDem()
        If cbRanDom.Checked Then
            Dim rd As New Random
            chiSo = rd.Next(max)
        End If
        Try
            Dim so As SoDem_Object = list.Item(chiSo)
            btnChinh.Text = so.hinagana
            If cbShowKanji.Checked And so.kanji <> "" Then
                btnChinh.Text &= "[" & so.kanji & "]"
            End If
            lblThongTin.Text = ""
            If cbShowNguNghia.Checked Then
                lblThongTin.Text = so.nguNghia
            End If
            If cbShowLama.Checked Then
                lblThongTin.Text &= " [" & so.lama & "]"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnTruoc_Click(sender As Object, e As EventArgs) Handles btnTruoc.Click
        chiSo -= 1
        ShowSoDem()
    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click
        chiSo += 1
        ShowSoDem()
    End Sub
End Class
