<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.tbox_conpw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbox_enterpw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbox_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbox_uname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.close = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showpw = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.create_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tbox_lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbox_fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.error_fname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_lname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_uname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_email = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_epw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_cpw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.error_fname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_lname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_uname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_epw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_cpw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_conpw)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_enterpw)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_email)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_uname)
        Me.Guna2GradientPanel2.Controls.Add(Me.minimize)
        Me.Guna2GradientPanel2.Controls.Add(Me.close)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.showpw)
        Me.Guna2GradientPanel2.Controls.Add(Me.create_btn)
        Me.Guna2GradientPanel2.Controls.Add(Me.login_btn)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_lname)
        Me.Guna2GradientPanel2.Controls.Add(Me.tbox_fname)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Red
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(266, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(796, 572)
        Me.Guna2GradientPanel2.TabIndex = 3
        '
        'tbox_conpw
        '
        Me.tbox_conpw.AutoRoundedCorners = True
        Me.tbox_conpw.BackColor = System.Drawing.Color.Transparent
        Me.tbox_conpw.BorderRadius = 23
        Me.tbox_conpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_conpw.DefaultText = ""
        Me.tbox_conpw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_conpw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_conpw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_conpw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_conpw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_conpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_conpw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_conpw.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_conpw.Location = New System.Drawing.Point(179, 377)
        Me.tbox_conpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_conpw.Name = "tbox_conpw"
        Me.tbox_conpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbox_conpw.PlaceholderText = "Comfirm Password"
        Me.tbox_conpw.SelectedText = ""
        Me.tbox_conpw.Size = New System.Drawing.Size(362, 48)
        Me.tbox_conpw.TabIndex = 15
        '
        'tbox_enterpw
        '
        Me.tbox_enterpw.AutoRoundedCorners = True
        Me.tbox_enterpw.BackColor = System.Drawing.Color.Transparent
        Me.tbox_enterpw.BorderRadius = 23
        Me.tbox_enterpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_enterpw.DefaultText = ""
        Me.tbox_enterpw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_enterpw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_enterpw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_enterpw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_enterpw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_enterpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_enterpw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_enterpw.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_enterpw.Location = New System.Drawing.Point(179, 321)
        Me.tbox_enterpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_enterpw.Name = "tbox_enterpw"
        Me.tbox_enterpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbox_enterpw.PlaceholderText = "Enter Password"
        Me.tbox_enterpw.SelectedText = ""
        Me.tbox_enterpw.Size = New System.Drawing.Size(362, 48)
        Me.tbox_enterpw.TabIndex = 14
        '
        'tbox_email
        '
        Me.tbox_email.AutoRoundedCorners = True
        Me.tbox_email.BackColor = System.Drawing.Color.Transparent
        Me.tbox_email.BorderRadius = 23
        Me.tbox_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_email.DefaultText = ""
        Me.tbox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_email.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_email.Location = New System.Drawing.Point(179, 265)
        Me.tbox_email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_email.Name = "tbox_email"
        Me.tbox_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbox_email.PlaceholderText = "Email"
        Me.tbox_email.SelectedText = ""
        Me.tbox_email.Size = New System.Drawing.Size(362, 48)
        Me.tbox_email.TabIndex = 13
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
        Me.tbox_uname.Location = New System.Drawing.Point(179, 209)
        Me.tbox_uname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_uname.Name = "tbox_uname"
        Me.tbox_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbox_uname.PlaceholderText = "Username"
        Me.tbox_uname.SelectedText = ""
        Me.tbox_uname.Size = New System.Drawing.Size(362, 48)
        Me.tbox_uname.TabIndex = 12
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 22)
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
        Me.Label1.Location = New System.Drawing.Point(70, 73)
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
        Me.showpw.Location = New System.Drawing.Point(191, 438)
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
        'create_btn
        '
        Me.create_btn.AutoRoundedCorners = True
        Me.create_btn.BackColor = System.Drawing.Color.Transparent
        Me.create_btn.BorderRadius = 21
        Me.create_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.create_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.create_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.create_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.create_btn.FillColor = System.Drawing.Color.Transparent
        Me.create_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.create_btn.ForeColor = System.Drawing.Color.White
        Me.create_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.create_btn.Location = New System.Drawing.Point(179, 465)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(175, 45)
        Me.create_btn.TabIndex = 5
        Me.create_btn.Text = "Create Account"
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
        Me.login_btn.Location = New System.Drawing.Point(366, 465)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(175, 45)
        Me.login_btn.TabIndex = 3
        Me.login_btn.Text = "Log In"
        '
        'tbox_lname
        '
        Me.tbox_lname.AutoRoundedCorners = True
        Me.tbox_lname.BackColor = System.Drawing.Color.Transparent
        Me.tbox_lname.BorderRadius = 23
        Me.tbox_lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_lname.DefaultText = ""
        Me.tbox_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_lname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_lname.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_lname.Location = New System.Drawing.Point(366, 153)
        Me.tbox_lname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_lname.Name = "tbox_lname"
        Me.tbox_lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbox_lname.PlaceholderText = "Last Name"
        Me.tbox_lname.SelectedText = ""
        Me.tbox_lname.Size = New System.Drawing.Size(175, 48)
        Me.tbox_lname.TabIndex = 1
        '
        'tbox_fname
        '
        Me.tbox_fname.AutoRoundedCorners = True
        Me.tbox_fname.BackColor = System.Drawing.Color.Transparent
        Me.tbox_fname.BorderRadius = 23
        Me.tbox_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_fname.DefaultText = ""
        Me.tbox_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbox_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbox_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbox_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_fname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbox_fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbox_fname.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.tbox_fname.Location = New System.Drawing.Point(179, 153)
        Me.tbox_fname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbox_fname.Name = "tbox_fname"
        Me.tbox_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbox_fname.PlaceholderText = "First Name"
        Me.tbox_fname.SelectedText = ""
        Me.tbox_fname.Size = New System.Drawing.Size(175, 48)
        Me.tbox_fname.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(266, 572)
        Me.Guna2GradientPanel1.TabIndex = 4
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'error_fname
        '
        Me.error_fname.ContainerControl = Me
        '
        'error_lname
        '
        Me.error_lname.ContainerControl = Me
        '
        'error_uname
        '
        Me.error_uname.ContainerControl = Me
        '
        'error_email
        '
        Me.error_email.ContainerControl = Me
        '
        'error_epw
        '
        Me.error_epw.ContainerControl = Me
        '
        'error_cpw
        '
        Me.error_cpw.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 572)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.error_fname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_lname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_uname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_epw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_cpw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents tbox_uname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents close As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents showpw As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents create_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbox_lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbox_fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents tbox_conpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbox_enterpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbox_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents error_fname As ErrorProvider
    Friend WithEvents error_lname As ErrorProvider
    Friend WithEvents error_uname As ErrorProvider
    Friend WithEvents error_email As ErrorProvider
    Friend WithEvents error_epw As ErrorProvider
    Friend WithEvents error_cpw As ErrorProvider
End Class
