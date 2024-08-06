Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form2
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub showpw_CheckedChanged(sender As Object, e As EventArgs) Handles showpw.CheckedChanged
        If showpw.Checked = True Then
            tbox_enterpw.PasswordChar = ""
            tbox_conpw.PasswordChar = ""
        Else
            tbox_enterpw.PasswordChar = "*"
            tbox_conpw.PasswordChar = "*"
        End If
    End Sub
    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click


        Try
            If tbox_enterpw.Text <> tbox_conpw.Text Then
                MessageBox.Show("Invalid Confirm Password")
            Else
                con.Open()
                Dim query As String = "INSERT INTO userdetailTable (
             [fname],
             [lname],
             [uname],
             [email],
             [password])
             VALUES 
              ('" + tbox_fname.Text + "', '" + tbox_lname.Text + "',
             '" + tbox_uname.Text + "','" + tbox_email.Text + "',
             '" + tbox_conpw.Text + "'); select user_id();"
                Dim cmd As SqlCommand = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("user added")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        If String.IsNullOrEmpty(tbox_fname.Text.Trim) Or String.IsNullOrEmpty(tbox_lname.Text.Trim) Or String.IsNullOrEmpty(tbox_email.Text.Trim) Or String.IsNullOrEmpty(tbox_uname.Text.Trim) Or String.IsNullOrEmpty(tbox_conpw.Text.Trim) Or String.IsNullOrEmpty(tbox_enterpw.Text.Trim) Then
            error_fname.SetError(tbox_fname, "Please Enter frist name")
            error_lname.SetError(tbox_lname, "Please Enter last name")
            error_email.SetError(tbox_email, "Please Enter Email address")
            error_cpw.SetError(tbox_conpw, "Please Enter Confirm Password")
            error_epw.SetError(tbox_enterpw, "Please Enter The Password")
        Else
            error_fname.SetError(tbox_fname, String.Empty)
            error_lname.SetError(tbox_lname, String.Empty)
            error_email.SetError(tbox_email, String.Empty)
            error_cpw.SetError(tbox_conpw, String.Empty)
            error_epw.SetError(tbox_enterpw, String.Empty)
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint

    End Sub
End Class