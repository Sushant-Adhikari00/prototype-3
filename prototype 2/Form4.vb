Imports System.Data
Imports System.Data.SqlClient
Public Class Category_form
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
        Form3.Show()
    End Sub


    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Close()
        Report_form.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO [dbo].[category]
                                   ([category], [description], [amount], [trans_date])
                                   VALUES
                                   (@category, @description, @amount, @trans_date);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@category", tbox_category.Text)
                cmd.Parameters.AddWithValue("@description", tbox_desp.Text)
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(tbox_amount.Text))
                cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(tbox_date.Text))

                ' Execute the command and retrieve the new identity value if needed
                Dim newId As Object = cmd.ExecuteScalar()
                MessageBox.Show("Category Added. New ID: " & newId.ToString())
            End Using
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
            Dim query As String = "UPDATE [dbo].[category]
                                   SET [category] = @category,
                                       [description] = @description,
                                       [amount] = @amount,
                                       [trans_date] = @trans_date
                                   WHERE [id] = @id"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@category", tbox_name.Text)
                cmd.Parameters.AddWithValue("@description", tbox_updesp.Text)
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(tbox_upamt.Text))
                cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(tbox_update.Text))
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbox_id.Text)) ' ID parameter

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Category Updated")
                Else
                    MessageBox.Show("No record found with the specified ID.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        Dim deleteQuery As String
        Try
            con.Open()
            deleteQuery = "DELETE FROM [dbo].[MembersDetails] WHERE member_id = " & tbox_dlt.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(deleteQuery, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member with ID " & tbox_dlt.Text & "successfully !")
            tbox_dlt.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub FetchAndDisplayData()
        Try
            con.Open()
            Dim query As String = "SELECT id,category[Category],trans_date,description[Description],amount[Amount] FROM [dbo].[category]"
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