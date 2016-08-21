Imports System.Data.SqlClient
Imports System.IO

Public Class Form2
    Private connect As New ConnectData
    Private conn As SqlConnection

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
        conn = connect.getConnect
        conn.Open()
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

    Private Function GetData(ByVal sheetName As String) As DataTable
        Dim myconnection As System.Data.OleDb.OleDbConnection = Nothing
        Dim dtResult As New DataTable
        Try
            Dim Mycommand As System.Data.OleDb.OleDbDataAdapter = Nothing
            Dim strConnectionString As String = GetConnectionString(Application.StartupPath.Replace("bin\Debug", "Resources\TuVung.xlsx"))
            myconnection = New System.Data.OleDb.OleDbConnection(strConnectionString)
            Mycommand = New System.Data.OleDb.OleDbDataAdapter("select * from  [" & sheetName & "$]", myconnection)
            Mycommand.Fill(dtResult)
            Return dtResult
            myconnection.Close()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub InsertData(ByVal id As Integer, ByVal dtResult As DataTable)
        If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then
            For Each pt As DataRow In dtResult.Rows
                chenServer(id, pt.Item(0), pt.Item(2), pt.Item(4))
            Next
        End If
    End Sub

    Private Sub chenServer(id, tu, han, nghia)
        Dim cmd As New SqlCommand
        Try
            cmd.CommandText = "addTuVung"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            'set input value
            cmd.Parameters.AddWithValue("@IdBaiHoc", id)
            cmd.Parameters.AddWithValue("@TuVung", tu)
            cmd.Parameters.AddWithValue("@HanTu", han)
            cmd.Parameters.AddWithValue("@Nghia", nghia)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            TextBox1.Text = "Lỗi chèn bai " & id & "! " & tu & " - " & nghia & vbCrLf & TextBox1.Text
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        For bai = 1 To 50
            Try
                InsertData(bai, GetData("Bai" & bai))
                TextBox1.Text = "Chèn xong Bai" & bai & vbCrLf & TextBox1.Text
            Catch ex As Exception
                TextBox1.Text = "Lỗi thêm bai " & bai & vbCrLf & TextBox1.Text
            End Try
        Next
    End Sub
End Class