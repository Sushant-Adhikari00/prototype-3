Imports System.Data
Imports System.Data.SqlClient
Public Class Form3

    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Close()
        Category_form.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Close()
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

    Private Sub DisplayTotalAmount()
        Try
            con.Open()
            Dim query As String = "SELECT SUM([amount]) AS TotalAmount FROM [dbo].[category]"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                ' Execute the command and get the result
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    ' Convert result to Decimal and set label text
                    lb_exp.Text = Convert.ToDecimal(result).ToString("C") ' Format as currency
                Else
                    lb_exp.Text = "No data available"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DisplayTodayAmount()
        Try
            con.Open()
            Dim query As String = "SELECT SUM(amount) AS [total amount] FROM category WHERE trans_date = CAST(GETDATE() AS DATE);"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                ' Execute the command and get the result
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    ' Convert result to Decimal and set label text
                    lb_texp.Text = Convert.ToDecimal(result).ToString("C") ' Format as currency
                Else
                    lb_texp.Text = "No data available"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub lb_exp_Click(sender As Object, e As EventArgs) Handles lb_exp.Click
        DisplayTotalAmount()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lb_texp.Click
        DisplayTodayAmount()
    End Sub
End Class