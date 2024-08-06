Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles crteacc_btn.Click
        Me.Hide()
        Me.Refresh()
        Form2.Show()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If String.IsNullOrEmpty(tbox_uname.Text.Trim) Or String.IsNullOrEmpty(tbox_pw.Text.Trim) Then
            ErrorProvider1.SetError(tbox_uname, "Please Enter Username")
            ErrorProvider2.SetError(tbox_pw, "Please Enter The Password")
        Else
            ErrorProvider1.SetError(tbox_uname, String.Empty)
            ErrorProvider2.SetError(tbox_pw, String.Empty)
            Try
                Dim query As String = "select * from userdetailTable where
                 uname= '" + tbox_uname.Text + "' AND password= '" + tbox_pw.Text + "'"
                Dim cmd As SqlCommand = New SqlCommand(query, con)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("login successful")
                    Me.Hide()
                    Form3.Show()
                Else
                    MessageBox.Show("login failed due to incorrect password or username")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

        End If

    End Sub

    Private Sub showpw_CheckedChanged(sender As Object, e As EventArgs) Handles showpw.CheckedChanged
        If showpw.Checked = True Then
            tbox_pw.PasswordChar = ""
        Else
            tbox_pw.PasswordChar = "*"
        End If
    End Sub

End Class
