Imports System.IO

Public Class Kanji_Parent

    Private Sub Kanji_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As System.Data.OleDb.OleDbConnection = Nothing
        Try
            Dim Mycommand As System.Data.OleDb.OleDbDataAdapter = Nothing
            Dim strConnectionString As String = GetConnectionString(Application.StartupPath.Replace("bin\Debug", "Resources\Kanji.xlsx"))
            myconnection = New System.Data.OleDb.OleDbConnection(strConnectionString)
            Mycommand = New System.Data.OleDb.OleDbDataAdapter("select * from  [N5$]", myconnection)
            Dim dtResult As New DataTable
            Mycommand.Fill(dtResult)
            DataGridView1.DataSource = dtResult
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 50
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            myconnection.Close()
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Function GetConnectionString(ByVal excelFileName As String) As String
        Dim strConnectionString As String = ""
        If Path.GetExtension(excelFileName).ToLower() = ".xlsx" Then
            strConnectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"";", excelFileName)
        ElseIf Path.GetExtension(excelFileName).ToLower() = ".xls" Then
            strConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";", excelFileName)
        End If
        Return (strConnectionString)
    End Function

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        lblKanji.Text = DataGridView1.CurrentRow.Cells(1).Value
        lblAmHan.Text = DataGridView1.CurrentRow.Cells(2).Value
        lblNghia.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnTiep_Click(sender As Object, e As EventArgs) Handles btnTiep.Click
        Try
            DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.CurrentRow.Index + 1)
        Catch ex As Exception
            DataGridView1.CurrentCell = DataGridView1(0, 0)
        End Try
        DataGridView1_SelectionChanged(sender, e)
    End Sub

    Private Sub btnTruoc_Click(sender As Object, e As EventArgs) Handles btnTruoc.Click
        Try
            DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.CurrentRow.Index - 1)
        Catch ex As Exception
            DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
        End Try
        DataGridView1_SelectionChanged(sender, e)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class