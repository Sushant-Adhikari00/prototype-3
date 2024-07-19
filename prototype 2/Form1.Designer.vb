<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.close = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showpw = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.crteacc_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tbox_pw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbox_uname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.minimize)
        Me.Guna2GradientPanel2.Controls.Add(Me.close)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.showpw)
        Me.Guna2GradientPanel2.Controls.Add(Me.crteacc_btn)
        Me.Guna2GradientPanel2.Controls.Add(Me.login_btn)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_pw)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_uname)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Red
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(266, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(796, 572)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.minimize.FillColor = System.Drawing.Color.Transparent
        Me.minimize.IconColor = System.Drawing.Color.DimGray
        Me.minimize.Location = New System.Drawing.Point(688, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(45, 29)
        Me.minimize.TabIndex = 11
        '
        'close
        '
        Me.close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close.BackColor = System.Drawing.Color.Transparent
        Me.close.FillColor = System.Drawing.Color.Transparent
        Me.close.IconColor = System.Drawing.Color.DimGray
        Me.close.Location = New System.Drawing.Point(739, 12)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(45, 29)
        Me.close.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(234, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Save Today For Better Tomorrow"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 51)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Welcome To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 51)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Expense Tracker"
        '
        'showpw
        '
        Me.showpw.AutoSize = True
        Me.showpw.BackColor = System.Drawing.Color.Transparent
        Me.showpw.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showpw.CheckedState.BorderRadius = 0
        Me.showpw.CheckedState.BorderThickness = 0
        Me.showpw.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showpw.Location = New System.Drawing.Point(253, 394)
        Me.showpw.Name = "showpw"
        Me.showpw.Size = New System.Drawing.Size(129, 21)
        Me.showpw.TabIndex = 6
        Me.showpw.Text = "Show Password"
        Me.showpw.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showpw.UncheckedState.BorderRadius = 0
        Me.showpw.UncheckedState.BorderThickness = 0
        Me.showpw.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showpw.UseVisualStyleBackColor = False
        '
        'crteacc_btn
        '
        Me.crteacc_btn.AutoRoundedCorners = True
        Me.crteacc_btn.BackColor = System.Drawing.Color.Transparent
        Me.crteacc_btn.BorderRadius = 21
        Me.crteacc_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.crteacc_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.crteacc_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.crteacc_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.crteacc_btn.FillColor = System.Drawing.Color.Transparent
        Me.crteacc_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.crteacc_btn.ForeColor = System.Drawing.Color.White
        Me.crteacc_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.crteacc_btn.Location = New System.Drawing.Point(238, 499)
        Me.crteacc_btn.Name = "crteacc_btn"
        Me.crteacc_btn.Size = New System.Drawing.Size(295, 45)
        Me.crteacc_btn.TabIndex = 5
        Me.crteacc_btn.Text = "Create Account"
        '
        'login_btn
        '
        Me.login_btn.AutoRoundedCorners = True
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.BorderRadius = 21
        Me.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.login_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(238, 436)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(295, 45)
        Me.login_btn.TabIndex = 3
        Me.login_btn.Text = "Log In"
        '
        'tbox_pw
        '
        Me.tbox_pw.AutoRoundedCorners = True
        Me.tbox_pw.BackColor = System.Drawing.Color.Transparent
        Me.tbox_pw.BorderRadius = 23
        Me.tbox_pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_pw.DefaultText = ""
        Me.tbox_pw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_pw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_pw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_pw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_pw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_pw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_pw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_pw.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_pw.Location = New System.Drawing.Point(238, 319)
        Me.tbox_pw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_pw.Name = "tbox_pw"
        Me.tbox_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbox_pw.PlaceholderText = "Password"
        Me.tbox_pw.SelectedText = ""
        Me.tbox_pw.Size = New System.Drawing.Size(295, 48)
        Me.tbox_pw.TabIndex = 1
        '
        'tbox_uname
        '
        Me.tbox_uname.AutoRoundedCorners = True
        Me.tbox_uname.BackColor = System.Drawing.Color.Transparent
        Me.tbox_uname.BorderRadius = 23
        Me.tbox_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_uname.DefaultText = ""
        Me.tbox_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_uname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_uname.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_uname.Location = New System.Drawing.Point(238, 254)
        Me.tbox_uname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_uname.Name = "tbox_uname"
        Me.tbox_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbox_uname.PlaceholderText = "Username"
        Me.tbox_uname.SelectedText = ""
        Me.tbox_uname.Size = New System.Drawing.Size(295, 48)
        Me.tbox_uname.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(266, 572)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 572)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents close As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents showpw As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents crteacc_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbox_pw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbox_uname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
