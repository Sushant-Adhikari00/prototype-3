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

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO [dbo].[category] ([category], [amount], [trans_date], [description]) VALUES (@category, @amount, @trans_date, @description)"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            ' Assuming datagrid is a DataGridView and has textboxes or cells with data
            cmd.Parameters.AddWithValue("@category", datagrid.Rows(0).Cells("category").Value.ToString())
            cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(datagrid.Rows(0).Cells("amount").Value.ToString()))
            cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(datagrid.Rows(0).Cells("trans_date").Value.ToString()))
            cmd.Parameters.AddWithValue("@description", datagrid.Rows(0).Cells("description").Value.ToString())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Detail added")

            ' Call method to fetch and display data
            FetchAndDisplayData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub Category_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAndDisplayData()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Try
            con.Open()
            Dim query As String = "UPDATE [dbo].[category] SET [name] = @name, [amount] = @amount, [trans_date] = @trans_date, [description] = @description WHERE [id] = @id"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(datagrid.Rows(0).Cells("id").Value.ToString()))
            cmd.Parameters.AddWithValue("@name", datagrid.Rows(0).Cells("name").Value.ToString())
            cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(datagrid.Rows(0).Cells("amount").Value.ToString()))
            cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(datagrid.Rows(0).Cells("trans_date").Value.ToString()))
            cmd.Parameters.AddWithValue("@description", datagrid.Rows(0).Cells("description").Value.ToString())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Detail updated")

            FetchAndDisplayData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        Try
            con.Open()
            Dim query As String = "DELETE FROM [dbo].[category] WHERE [id] = @id"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(datagrid.Rows(0).Cells("id").Value.ToString()))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Detail deleted")

            FetchAndDisplayData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub FetchAndDisplayData()
        Try
            con.Open()
            Dim query As String = "SELECT category[Category],trans_date[Transaction Date],description[Description],amount[Amount] FROM [dbo].[category]"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            datagrid.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class