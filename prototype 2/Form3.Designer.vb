<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.income = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.texpense = New System.Windows.Forms.Panel()
        Me.budget = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.expence = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.income.SuspendLayout()
        Me.texpense.SuspendLayout()
        Me.budget.SuspendLayout()
        Me.expence.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(564, 32)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker1.TabIndex = 1
        Me.Guna2DateTimePicker1.Value = New Date(2024, 7, 15, 10, 12, 57, 429)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = " - - - - - - - - - - - - - - - - - - -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Income"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Income"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'income
        '
        Me.income.BackColor = System.Drawing.Color.OliveDrab
        Me.income.Controls.Add(Me.Label6)
        Me.income.Controls.Add(Me.Label5)
        Me.income.Controls.Add(Me.Label4)
        Me.income.Controls.Add(Me.Label3)
        Me.income.Location = New System.Drawing.Point(20, 421)
        Me.income.Name = "income"
        Me.income.Size = New System.Drawing.Size(190, 119)
        Me.income.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Income"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = " - - - - - - - - - - - - - - - - - - -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total Expence"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Income"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 29)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Expense"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'texpense
        '
        Me.texpense.BackColor = System.Drawing.Color.Orange
        Me.texpense.Controls.Add(Me.Label7)
        Me.texpense.Controls.Add(Me.Label9)
        Me.texpense.Controls.Add(Me.Label8)
        Me.texpense.Controls.Add(Me.Label10)
        Me.texpense.Location = New System.Drawing.Point(216, 421)
        Me.texpense.Name = "texpense"
        Me.texpense.Size = New System.Drawing.Size(190, 119)
        Me.texpense.TabIndex = 3
        '
        'budget
        '
        Me.budget.BackColor = System.Drawing.Color.Crimson
        Me.budget.Controls.Add(Me.Label20)
        Me.budget.Controls.Add(Me.Label18)
        Me.budget.Controls.Add(Me.Label16)
        Me.budget.Controls.Add(Me.Label17)
        Me.budget.Location = New System.Drawing.Point(608, 421)
        Me.budget.Name = "budget"
        Me.budget.Size = New System.Drawing.Size(190, 119)
        Me.budget.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(8, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(179, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = " - - - - - - - - - - - - - - - - - - -"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(13, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 29)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Budget"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(14, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Income"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(14, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 20)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Remaining Budget"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(8, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(179, 17)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = " - - - - - - - - - - - - - - - - - - -"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Income"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Total Expence"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'expence
        '
        Me.expence.BackColor = System.Drawing.Color.DarkCyan
        Me.expence.Controls.Add(Me.Label11)
        Me.expence.Controls.Add(Me.Label19)
        Me.expence.Controls.Add(Me.Label12)
        Me.expence.Controls.Add(Me.Label14)
        Me.expence.Location = New System.Drawing.Point(412, 421)
        Me.expence.Name = "expence"
        Me.expence.Size = New System.Drawing.Size(190, 119)
        Me.expence.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(194, 29)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Today Expense"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.expence)
        Me.Guna2GradientPanel2.Controls.Add(Me.budget)
        Me.Guna2GradientPanel2.Controls.Add(Me.texpense)
        Me.Guna2GradientPanel2.Controls.Add(Me.income)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(252, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(810, 572)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Extra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "General"
        '
        'logout_btn
        '
        Me.logout_btn.AutoRoundedCorners = True
        Me.logout_btn.BorderRadius = 21
        Me.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logout_btn.FillColor = System.Drawing.Color.Red
        Me.logout_btn.FillColor2 = System.Drawing.Color.Red
        Me.logout_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logout_btn.Location = New System.Drawing.Point(27, 402)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(180, 45)
        Me.logout_btn.TabIndex = 5
        Me.logout_btn.Text = "Logout"
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.AutoRoundedCorners = True
        Me.Guna2GradientButton4.BorderRadius = 21
        Me.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(27, 334)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton4.TabIndex = 4
        Me.Guna2GradientButton4.Text = "Report"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 21
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(27, 157)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton2.TabIndex = 2
        Me.Guna2GradientButton2.Text = "Catagories"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 21
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(27, 94)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton1.TabIndex = 1
        Me.Guna2GradientButton1.Text = "Dashboard"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.logout_btn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(252, 572)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 572)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.income.ResumeLayout(False)
        Me.income.PerformLayout()
        Me.texpense.ResumeLayout(False)
        Me.texpense.PerformLayout()
        Me.budget.ResumeLayout(False)
        Me.budget.PerformLayout()
        Me.expence.ResumeLayout(False)
        Me.expence.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents income As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents texpense As Panel
    Friend WithEvents budget As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents expence As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
