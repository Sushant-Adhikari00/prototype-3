Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Report_form
    Dim con As SqlConnection = New SqlConnection("Data Source=SUSHANT;Initial Catalog=project;Integrated Security=True")

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        Me.Refresh()
        Form3.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        Category_form.Show()
    End Sub
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        Me.Refresh()
        Category_form.Show()
    End Sub
    Private Sub logout_btn_Click_1(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure!!", MsgBoxStyle.YesNo, "Log Out")

        If result = MsgBoxResult.Yes Then
            ' Code to log out the user
            ' For example, close the current form
            Me.Hide()
            Form1.Show()
        ElseIf result = MsgBoxResult.No Then
            ' No action needed, just close the message box
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateChart()
    End Sub

    Private Sub PopulateChart()
        Try
            con.Open()
            Dim query As String = "SELECT category, SUM(amount) AS TotalAmount FROM category GROUP BY category ORDER BY category"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)

            ' Clear any existing series and chart areas
            categoryChart.Series.Clear()
            categoryChart.ChartAreas.Clear()

            ' Create a new chart area
            Dim chartArea As New ChartArea()
            categoryChart.ChartAreas.Add(chartArea)

            ' Create a new series and set its properties
            Dim series As New Series("Category Amounts")
            series.ChartType = SeriesChartType.Column ' You can change the chart type here
            categoryChart.Series.Add(series)

            ' Populate the series with data
            For Each row As DataRow In table.Rows
                series.Points.AddXY(row("category").ToString(), Convert.ToDecimal(row("TotalAmount")))
            Next

            ' Set chart title
            categoryChart.Titles.Clear()
            categoryChart.Titles.Add("Total Amounts by Category")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class