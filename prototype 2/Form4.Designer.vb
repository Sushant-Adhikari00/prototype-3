<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.update_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dlt_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Catagory = New System.Windows.Forms.Label()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button5
        '
        Me.Guna2Button5.AutoRoundedCorners = True
        Me.Guna2Button5.BorderRadius = 21
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.LightCoral
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Location = New System.Drawing.Point(822, 483)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button5.TabIndex = 31
        Me.Guna2Button5.Text = "Add Category"
        '
        'update_btn
        '
        Me.update_btn.AutoRoundedCorners = True
        Me.update_btn.BorderRadius = 21
        Me.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.update_btn.FillColor = System.Drawing.Color.Orange
        Me.update_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.Location = New System.Drawing.Point(358, 483)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(81, 45)
        Me.update_btn.TabIndex = 29
        Me.update_btn.Text = "Update"
        '
        'dlt_btn
        '
        Me.dlt_btn.AutoRoundedCorners = True
        Me.dlt_btn.BorderRadius = 21
        Me.dlt_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dlt_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dlt_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dlt_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dlt_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dlt_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dlt_btn.ForeColor = System.Drawing.Color.White
        Me.dlt_btn.Location = New System.Drawing.Point(445, 483)
        Me.dlt_btn.Name = "dlt_btn"
        Me.dlt_btn.Size = New System.Drawing.Size(81, 45)
        Me.dlt_btn.TabIndex = 30
        Me.dlt_btn.Text = "Delete"
        '
        'datagrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid.ColumnHeadersHeight = 19
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid.Location = New System.Drawing.Point(321, 121)
        Me.datagrid.Name = "datagrid"
        Me.datagrid.RowHeadersVisible = False
        Me.datagrid.RowHeadersWidth = 51
        Me.datagrid.RowTemplate.Height = 24
        Me.datagrid.Size = New System.Drawing.Size(720, 341)
        Me.datagrid.TabIndex = 28
        Me.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid.ThemeStyle.HeaderStyle.Height = 19
        Me.datagrid.ThemeStyle.ReadOnly = False
        Me.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid.ThemeStyle.RowsStyle.Height = 24
        Me.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.logout_btn.Location = New System.Drawing.Point(30, 402)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(180, 45)
        Me.logout_btn.TabIndex = 16
        Me.logout_btn.Text = "Logout"
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
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(30, 158)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton2.TabIndex = 10
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
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(30, 98)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton1.TabIndex = 9
        Me.Guna2GradientButton1.Text = "Dashboard"
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
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(30, 335)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton4.TabIndex = 12
        Me.Guna2GradientButton4.Text = "Report"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.logout_btn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton4)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(252, 572)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Extra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "General"
        '
        'Catagory
        '
        Me.Catagory.AutoSize = True
        Me.Catagory.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Catagory.Location = New System.Drawing.Point(325, 54)
        Me.Catagory.Name = "Catagory"
        Me.Catagory.Size = New System.Drawing.Size(158, 38)
        Me.Catagory.TabIndex = 25
        Me.Catagory.Text = "Catagory"
        '
        'Category_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1062, 572)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.dlt_btn)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Catagory)
        Me.Name = "Category_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents update_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dlt_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Catagory As Label
End Class
