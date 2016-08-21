Imports System.Data.SqlClient
Imports System.Text

Public Class GiaoTrinh_Parent
    Private connect As New ConnectData
    Private conn As SqlConnection
    Private tuVung As New ucTuVung
    Private nguPhap As New ucNguPhap
    Private hoiThoai As New ucHoiThoai
    Private kiemTra As New ucKiemTra

    Private Sub GiaoTrinh_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connect.getConnect

        clstBaiHoc.Items.Clear()

        Dim dt As DataTable = getBaiHoc()
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                clstBaiHoc.Items.Add(r.Item("TenBaiHoc"))

            Next

        End If

        selectButton("TuVung")
        tuVung.InitListTuVung(getListTuVung(getTuVung()))
        pnMain.Controls.Clear()
        pnMain.Controls.Add(tuVung)

    End Sub

    Private Sub btnTuVung_Click(sender As Object, e As EventArgs) Handles btnTuVung.Click
        selectButton("TuVung")
        tuVung.InitListTuVung(getListTuVung(getTuVung()))
        pnMain.Controls.Clear()
        pnMain.Controls.Add(tuVung)

    End Sub

    Private Sub btnNguPhap_Click(sender As Object, e As EventArgs) Handles btnNguPhap.Click
        selectButton("NguPhap")
        nguPhap.InitListNguPhap(getListNguPhap(getNguPhap()))
        pnMain.Controls.Clear()
        pnMain.Controls.Add(nguPhap)

    End Sub

    Private Sub btnHoiThoai_Click(sender As Object, e As EventArgs) Handles btnHoiThoai.Click
        selectButton("HoiThoai")
        hoiThoai.InitListHoiThoai(getListHoiThoai(getHoiThoai()))
        pnMain.Controls.Clear()
        pnMain.Controls.Add(hoiThoai)

    End Sub

    Private Sub btnKiemTra_Click(sender As Object, e As EventArgs) Handles btnKiemTra.Click
        selectButton("KiemTra")
        kiemTra.InitListTuVung(getListTuVung(getTuVung()))
        pnMain.Controls.Clear()
        pnMain.Controls.Add(kiemTra)

    End Sub

    Private Sub selectButton(ByVal btnSelect As String)
        Select Case btnSelect
            Case "TuVung"
                btnTuVung.BackColor = Color.Brown
                btnTuVung.ForeColor = Color.White
                btnNguPhap.BackColor = SystemColors.Control
                btnNguPhap.ForeColor = Color.Black
                btnHoiThoai.BackColor = SystemColors.Control
                btnHoiThoai.ForeColor = Color.Black
                btnKiemTra.BackColor = SystemColors.Control
                btnKiemTra.ForeColor = Color.Black

            Case "NguPhap"
                btnNguPhap.BackColor = Color.Brown
                btnNguPhap.ForeColor = Color.White
                btnTuVung.BackColor = SystemColors.Control
                btnTuVung.ForeColor = Color.Black
                btnHoiThoai.BackColor = SystemColors.Control
                btnHoiThoai.ForeColor = Color.Black
                btnKiemTra.BackColor = SystemColors.Control
                btnKiemTra.ForeColor = Color.Black

            Case "HoiThoai"
                btnHoiThoai.BackColor = Color.Brown
                btnHoiThoai.ForeColor = Color.White
                btnNguPhap.BackColor = SystemColors.Control
                btnNguPhap.ForeColor = Color.Black
                btnTuVung.BackColor = SystemColors.Control
                btnTuVung.ForeColor = Color.Black
                btnKiemTra.BackColor = SystemColors.Control
                btnKiemTra.ForeColor = Color.Black

            Case Else
                btnKiemTra.BackColor = Color.Brown
                btnKiemTra.ForeColor = Color.White
                btnNguPhap.BackColor = SystemColors.Control
                btnNguPhap.ForeColor = Color.Black
                btnHoiThoai.BackColor = SystemColors.Control
                btnHoiThoai.ForeColor = Color.Black
                btnTuVung.BackColor = SystemColors.Control
                btnTuVung.ForeColor = Color.Black

        End Select

    End Sub

    Private Function checkNull(ByRef dtResult As DataTable) As Boolean
        If IsNothing(dtResult) AndAlso dtResult.Rows.Count < 1 Then
            Return True

        Else
            Return False

        End If

    End Function

    Private Function getListTuVung(ByVal dtResult As DataTable) As List(Of TuVung_Object)
        Dim tuVung As TuVung_Object
        Dim lst As New List(Of TuVung_Object)

        Try
            If Not checkNull(dtResult) Then
                For Each row As DataRow In dtResult.Rows
                    tuVung = New TuVung_Object
                    tuVung.idTuVung = row.Item("IdTuVung")
                    tuVung.tuVung = row.Item("TuVung")
                    If Not IsDBNull(row.Item("HanTu")) Then
                        tuVung.hanTu = row.Item("HanTu")
                    End If
                    tuVung.nguNghia = row.Item("Nghia")
                    If Not IsDBNull(row.Item("AnhMoTa")) Then
                        tuVung.urlAnhMoTa = row.Item("AnhMoTa")
                    End If
                    If Not IsDBNull(row.Item("AmDieu")) Then
                        tuVung.urlAmDoc = row.Item("AmDieu")
                    End If
                    tuVung.lstViDu = getListViDu(getViDu(tuVung.idTuVung, "TUVUNG"))
                    lst.Add(tuVung)
                Next
                Return lst
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Throw
        End Try
    End Function

    Private Function getListNguPhap(ByVal dtResult As DataTable) As List(Of NguPhap_Object)
        Dim nguPhap As NguPhap_Object
        Dim lst As New List(Of NguPhap_Object)

        Try
            If Not checkNull(dtResult) Then
                For Each row As DataRow In dtResult.Rows
                    nguPhap = New NguPhap_Object
                    nguPhap.idNguPhap = row.Item("IdNguPhap")
                    nguPhap.cauTruc = row.Item("CauTruc")
                    nguPhap.cachDung = row.Item("NguNghia")
                    nguPhap.nguNghia = row.Item("CachDung")
                    nguPhap.lstViDu = getListViDu(getViDu(nguPhap.idNguPhap, "NGUPHAP"))

                    lst.Add(nguPhap)

                Next

                Return lst

            Else
                Return Nothing

            End If

        Catch ex As Exception
            Throw

        End Try

    End Function

    Private Function getListHoiThoai(ByVal dtResult As DataTable) As List(Of HoiThoai_Object)
        Dim hoiThoai As HoiThoai_Object
        Dim lst As New List(Of HoiThoai_Object)

        Try
            If Not checkNull(dtResult) Then
                For Each row As DataRow In dtResult.Rows
                    hoiThoai = New HoiThoai_Object
                    hoiThoai.idHoiThoai = row.Item("IdHoiThoai")
                    hoiThoai.noiDung = row.Item("NoiDung")
                    hoiThoai.hanTu = row.Item("HanTu")
                    hoiThoai.phienDich = row.Item("PhienDich")
                    hoiThoai.urlAmThanh = row.Item("DocHoiThoai")
                    hoiThoai.urlVideo = row.Item("Video")

                    lst.Add(hoiThoai)

                Next

                Return lst

            Else
                Return Nothing

            End If

        Catch ex As Exception
            Throw

        End Try

    End Function

    Private Function getListViDu(ByVal dtResult As DataTable) As List(Of ViDu_Object)
        Dim viDu As ViDu_Object
        Dim lst As New List(Of ViDu_Object)

        Try
            If Not checkNull(dtResult) Then
                For Each row As DataRow In dtResult.Rows
                    viDu = New ViDu_Object
                    viDu.idViDu = row.Item("IdViDu")
                    viDu.noiDung = row.Item("ViDu")
                    viDu.hanTu = row.Item("HanTu")
                    viDu.nguNghia = row.Item("Nghia")
                    viDu.urlAnhMoTa = row.Item("AnhMoTa")
                    viDu.urlAmDoc = row.Item("AmDieu")

                    lst.Add(viDu)

                Next

                Return lst

            Else
                Return Nothing

            End If

        Catch ex As Exception
            Throw

        End Try

    End Function

    Private Function getBaiHoc() As DataTable
        Dim strSQL As New StringBuilder
        Dim dtResult As New DataTable
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter

        Try
            strSQL.Append("select * from BAIHOC ")
            
            cmd.CommandText = strSQL.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Function getTuVung() As DataTable
        Dim strSQL As New StringBuilder
        Dim dtResult As New DataTable
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim lstBai As New List(Of String)

        Try
            For Each bai In clstBaiHoc.CheckedItems
                lstBai.Add("'" & bai & "'")

            Next

            strSQL.Append("select TUVUNG.IdTuVung, TUVUNG.TuVung , TUVUNG.HanTu , TUVUNG.Nghia , TUVUNG.AnhMoTa , TUVUNG.AmDieu from TUVUNG ")
            strSQL.Append("inner join TUVUNGBAI on TUVUNG.IdTuVung = TUVUNGBAI.TuVung ")
            strSQL.Append("inner join BAIHOC on TUVUNGBAI .BaiHoc = BAIHOC .IdBaiHoc ")

            If lstBai.Count > 0 Then
                strSQL.Append("where TenBaiHoc in (" & String.Join(",", lstBai) & ")")
            End If

            cmd.CommandText = strSQL.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Function getNguPhap() As DataTable
        Dim strSQL As New StringBuilder
        Dim dtResult As New DataTable
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim lstBai As New List(Of String)

        Try
            For Each bai In clstBaiHoc.CheckedItems
                lstBai.Add("'" & bai & "'")
            Next

            strSQL.Append("select NGUPHAP.IdNguPhap, NGUPHAP.CauTruc, NGUPHAP.CachDung, NGUPHAP.NguNghia from NGUPHAP ")
            strSQL.Append("inner join NGUPHAPBAI on NGUPHAP.IdNguPhap = NGUPHAPBAI.NguPhap ")
            strSQL.Append("inner join BAIHOC on NGUPHAPBAI.BaiHoc = BAIHOC.IdBaiHoc ")

            If lstBai.Count > 0 Then
                strSQL.Append("where TenBaiHoc in (" & String.Join(",", lstBai) & ")")
            End If

            cmd.CommandText = strSQL.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()

            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Function getHoiThoai() As DataTable
        Dim strSQL As New StringBuilder
        Dim dtResult As New DataTable
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim lstBai As New List(Of String)

        Try
            For Each bai In clstBaiHoc.CheckedItems
                lstBai.Add("'" & bai & "'")
            Next

            strSQL.Append("select HOITHOAI.IdHoiThoai, HOITHOAI.NoiDung, HOITHOAI.HanTu, HOITHOAI.PhienDich, HOITHOAI.DocHoiThoai, HOITHOAI.Video from HOITHOAI ")
            strSQL.Append("inner join HOITHOAIBAI on HOITHOAIBAI.HoiThoai = HOITHOAI.IdHoiThoai ")
            strSQL.Append("inner join BAIHOC on HOITHOAIBAI.HoiThoai = HOITHOAIBAI.BaiHoc ")

            If lstBai.Count > 0 Then
                strSQL.Append("where TenBaiHoc in (" & String.Join(",", lstBai) & ")")
            End If

            cmd.CommandText = strSQL.ToString
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()

            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Function getViDu(ByVal khoa As Integer, ByVal bang As String) As DataTable
        Dim strSQL As New StringBuilder
        Dim dtResult As New DataTable
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim lstBai As New List(Of String)

        Try
            strSQL.Append("select VIDU.IdViDu, VIDU.ViDu, VIDU.HanTu, VIDU.Nghia, VIDU.AnhMoTa, VIDU.AmDieu from VIDU ")
            strSQL.Append("inner join VIDUCHO on VIDU.IdViDu = VIDUCHO.ViDu ")
            strSQL.Append("where VIDUCHO.TuKhoa = @Khoa and VIDUCHO.BangLienKet like @Bang")

            cmd.CommandText = strSQL.ToString
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@Khoa", khoa)
            cmd.Parameters.AddWithValue("@Bang", bang)
            cmd.Connection = conn

            conn.Open()

            da = New SqlDataAdapter(cmd)
            da.Fill(dtResult)

            cmd.Dispose()
            da.Dispose()
            conn.Close()

            Return dtResult

        Catch ex As Exception
            Throw
        End Try

    End Function

End Class