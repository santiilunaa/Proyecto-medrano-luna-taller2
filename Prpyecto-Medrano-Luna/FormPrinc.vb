﻿Public Class FormPrinc
    Private Sub FormPrinc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnBkp_Click(sender As Object, e As EventArgs) Handles BtnBkp.Click
        FormBkUp.MdiParent = Me
        FormBkUp.Show()

    End Sub

End Class