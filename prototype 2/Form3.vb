﻿
Public Class Form3
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        Category_form.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        Report_form.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure!!", MsgBoxStyle.YesNo, "Log Out")

        If result = MsgBoxResult.Yes Then
            ' Code to log out the user
            ' For example, close the current form
            Me.Close()
            Form1.Show()
        ElseIf result = MsgBoxResult.No Then
            ' No action needed, just close the message box
        End If
    End Sub

End Class