Public Class SoDem_Parent
    Private taiNguyen As New Const_Object
    Private Sub btnHinagana_Click(sender As Object, e As EventArgs) Handles btnSoDem.Click
        Dim uc As New ucSoDem
        uc.initList(taiNguyen.soDem)
        pnMainContent.Controls.Clear()
        pnMainContent.Controls.Add(uc)
    End Sub

    Private Sub btnNgayThang_Click(sender As Object, e As EventArgs) Handles btnNgayThang.Click
        Dim uc As New ucNgayThang
        uc.initList(lstNam:=taiNguyen.nam, lstThang:=taiNguyen.thang, lstNgay:=taiNguyen.ngayTrongThang, lstThu:=taiNguyen.ngayTrongTuan)
        pnMainContent.Controls.Clear()
        pnMainContent.Controls.Add(uc)
    End Sub

    Private Sub SoDem_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uc As New ucSoDem
        uc.initList(taiNguyen.soDem)
        pnMainContent.Controls.Clear()
        pnMainContent.Controls.Add(uc)
    End Sub
End Class