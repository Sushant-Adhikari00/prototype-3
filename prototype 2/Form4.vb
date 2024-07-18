Imports System.Data
Imports System.Data.SqlClient
Public Class Category_form
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        Form3.Show()
    End Sub


    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        Report_form.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim income As String
        income = InputBox("Enter Income Amount", "Income")
        MsgBox(income)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Dim expence As String
        expence = InputBox("Enter Expence Amount", "Expence")
        MsgBox(expence)
    End Sub
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellContentClick

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO [dbo].[category]
           ([name]
           ,[amount]
           ,[date]
           ,[description])
            VALUES
                ('" + datagrid.Text + "', '" + datagrid.Text + "',
                    '" + datagrid.Text + "','" + datagrid.Text + "',
                );"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("detail added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class