Imports System.Data.SqlClient

Public Class ConnectData
    Private conn As SqlConnection

    Public Function getConnect() As SqlConnection

        Try
            conn = New SqlConnection With {.ConnectionString = "Data Source=(local);Initial Catalog=VBNetHT;Trusted_Connection=True;"}
            Return conn

        Catch ex As Exception
            Throw

        End Try

    End Function

End Class
