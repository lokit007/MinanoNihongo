﻿Imports System.IO

Public Class ChaoHoi_Parent
    Private duLieu As New Const_Object

    Private Sub ChaoHoi_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pathRoot As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        If File.Exists(pathRoot & "\Resources\AudioFiles\Chao_0.mp3") Then
            AxWindowsMediaPlayer1.URL = pathRoot & "\Resources\AudioFiles\Chao_0.mp3"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If

        If Not IsNothing(duLieu) AndAlso Not IsNothing(duLieu.chaoHoi) Then
            Dim chiSo As Integer = 1
            Dim objUc As ucChaoHoi
            For Each cau In duLieu.chaoHoi
                objUc = New ucChaoHoi
                objUc.initCauChao(cau.Key, cau.Value, pathRoot & "\Resources\AudioFiles\Chao_" & chiSo & ".mp3")
                FlowLayoutPanel1.Controls.Add(objUc)
                chiSo += 1
            Next
        End If
    End Sub

    Private Sub ChaoHoi_Parent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

End Class