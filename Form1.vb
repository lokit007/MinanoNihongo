Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnChuCai_Click(sender As Object, e As EventArgs) Handles btnChuCai.Click
        Dim chuCai As New ChuCai_Parent()
        Me.Hide()
        chuCai.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSoDem_Click(sender As Object, e As EventArgs) Handles btnSoDem.Click
        Dim soDem As New SoDem_Parent()
        Me.Hide()
        soDem.ShowDialog()
        Me.Show()
    End Sub

End Class
