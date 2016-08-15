Imports System.Data.SqlClient

Public Class ConnectData
    Private conn As SqlConnection

    Public Function getConnect() As SqlConnection

        Try
            conn = New SqlConnection With {.ConnectionString = "Data Source=(local);Initial Catalog=DbMinanoNihongo;Trusted_Connection=True;"}
            'conn = New SqlConnection With {.ConnectionString = "Data Source=(local);Initial Catalog=DbMinanoNihongo; User Id=sa; Password=123456;"}
            Return conn

        Catch ex As Exception
            Throw

        End Try

    End Function

End Class
