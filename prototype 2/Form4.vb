Imports System.Data
Imports System.Data.SqlClient

Public Class Category_form
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")

    ' Button click event to open another form and close this one
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim unused = Me.close()
        Form3.Show()
    End Sub

    ' Button click event to open report form
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim unused = Me.close()
        Report_form.Show()
    End Sub

    ' Add category
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO [dbo].[category]
                                   ([category], [description], [amount], [trans_date])
                                   VALUES
                                   (@category, @description, @amount, @trans_date);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@category", tbox_category.Text)
                cmd.Parameters.AddWithValue("@description", tbox_desp.Text)
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(tbox_amount.Text))
                cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(tbox_date.Text))

                Dim newId As Object = cmd.ExecuteScalar()
                MessageBox.Show("Category Added. New ID: " & newId.ToString())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding category: " & ex.Message)
        Finally
            con.Close()
            FetchAndDisplayData() ' Refresh data after adding
        End Try
    End Sub

    ' Update category
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
                cmd.Parameters.AddWithValue("@category", tbox_name.Text)
                cmd.Parameters.AddWithValue("@description", tbox_updesp.Text)
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(tbox_upamt.Text))
                cmd.Parameters.AddWithValue("@trans_date", Convert.ToDateTime(tbox_update.Text))
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbox_id.Text))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Category Updated")
                Else
                    MessageBox.Show("No record found with the specified ID.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating category: " & ex.Message)
        Finally
            con.Close()
            FetchAndDisplayData() ' Refresh data after updating
        End Try
    End Sub

    ' Delete category
    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        Dim deleteQuery As String = "DELETE FROM [dbo].[category] WHERE id = @id"
        Try
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(deleteQuery, con)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbox_dlt.Text))
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Category with ID " & tbox_dlt.Text & " deleted successfully!")
                Else
                    MessageBox.Show("No record found with the specified ID.")
                End If
                tbox_dlt.Text = ""
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting category: " & ex.Message)
        Finally
            con.Close()
            FetchAndDisplayData() ' Refresh data after deletion
        End Try
    End Sub

    ' Fetch and display data in DataGridView
    Private Sub FetchAndDisplayData()
        Try
            con.Open()
            Dim query As String = "SELECT id, category [Category], trans_date, description [Description], amount [Amount] FROM [dbo].[category]"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            datagrid.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Log out button click event
    Private Sub logout_btn_Click_1(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Log Out")
        If result = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    ' Form load event
    Private Sub Category_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAndDisplayData()
    End Sub
End Class
