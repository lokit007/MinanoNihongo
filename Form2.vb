Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As New List(Of String)
        lst.Add("Một")
        lst.Add("Hai")
        lst.Add("Ba")
        lst.Add("Bốn")
        CType(DataGridView1.Columns(1), DataGridViewComboBoxColumn).DataSource = lst
        'Dim dtColumns As DataGridViewComboBoxColumn
        'dtColumns = dgvDisplay.Columns(DataGridViewArray.dgvPRINT_PATTERNCode)
        'dtColumns.DataSource = dtCcb
        'dtColumns.ValueMember = "Name"
        'dtColumns.DisplayMember = "ID"
    End Sub
End Class