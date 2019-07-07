<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainLogin))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LineBlack = New System.Windows.Forms.Label()
        Me.LblHelp1 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblWrongUP = New System.Windows.Forms.Label()
        Me.LblAttempts = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblHelp2 = New System.Windows.Forms.Label()
        Me.ExistingUser = New System.Windows.Forms.GroupBox()
        Me.NEWUser = New System.Windows.Forms.GroupBox()
        Me.LblNEWRePassword = New System.Windows.Forms.Label()
        Me.TxtNEWRePassword = New System.Windows.Forms.TextBox()
        Me.LblNEWUsername = New System.Windows.Forms.Label()
        Me.LblNEWPassword = New System.Windows.Forms.Label()
        Me.TxtNEWPassword = New System.Windows.Forms.TextBox()
        Me.TxtNEWUsername = New System.Windows.Forms.TextBox()
        Me.lblCNo = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExistingUser.SuspendLayout()
        Me.NEWUser.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Firebrick
        Me.LblTitle.Location = New System.Drawing.Point(3, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(507, 35)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Globe Trotter Hotel Booking System"
        '
        'LineBlack
        '
        Me.LineBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LineBlack.Location = New System.Drawing.Point(3, 42)
        Me.LineBlack.Name = "LineBlack"
        Me.LineBlack.Size = New System.Drawing.Size(510, 2)
        Me.LineBlack.TabIndex = 1
        Me.LineBlack.Text = "1"
        '
        'LblHelp1
        '
        Me.LblHelp1.AutoSize = True
        Me.LblHelp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp1.ForeColor = System.Drawing.Color.DarkRed
        Me.LblHelp1.Location = New System.Drawing.Point(6, 44)
        Me.LblHelp1.Name = "LblHelp1"
        Me.LblHelp1.Size = New System.Drawing.Size(369, 17)
        Me.LblHelp1.TabIndex = 2
        Me.LblHelp1.Text = "Please enter your username and password below."
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(20, 48)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(55, 13)
        Me.LblUsername.TabIndex = 3
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(20, 98)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'LblWrongUP
        '
        Me.LblWrongUP.AutoSize = True
        Me.LblWrongUP.Location = New System.Drawing.Point(7, 13)
        Me.LblWrongUP.Name = "LblWrongUP"
        Me.LblWrongUP.Size = New System.Drawing.Size(70, 13)
        Me.LblWrongUP.TabIndex = 7
        Me.LblWrongUP.Text = "password UP"
        Me.LblWrongUP.Visible = False
        '
        'LblAttempts
        '
        Me.LblAttempts.AutoSize = True
        Me.LblAttempts.Location = New System.Drawing.Point(20, 26)
        Me.LblAttempts.Name = "LblAttempts"
        Me.LblAttempts.Size = New System.Drawing.Size(47, 13)
        Me.LblAttempts.TabIndex = 8
        Me.LblAttempts.Text = "attempts"
        Me.LblAttempts.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Location = New System.Drawing.Point(361, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.BtnCancel, "This will close this application")
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Firebrick
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogin.Location = New System.Drawing.Point(331, 301)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Log In"
        Me.ToolTip1.SetToolTip(Me.BtnLogin, "click here to login")
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.Firebrick
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegister.Location = New System.Drawing.Point(80, 301)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegister.TabIndex = 7
        Me.BtnRegister.Text = "Register"
        Me.ToolTip1.SetToolTip(Me.BtnRegister, "Click here to register.")
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(23, 64)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(154, 20)
        Me.TxtUsername.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(23, 114)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(154, 20)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'LblHelp2
        '
        Me.LblHelp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp2.Location = New System.Drawing.Point(6, 61)
        Me.LblHelp2.Name = "LblHelp2"
        Me.LblHelp2.Size = New System.Drawing.Size(507, 49)
        Me.LblHelp2.TabIndex = 15
        Me.LblHelp2.Text = "If you don't have an account with us yet, enter your preferred Username, password" &
    " and click ""Regester""."
        '
        'ExistingUser
        '
        Me.ExistingUser.BackColor = System.Drawing.Color.Snow
        Me.ExistingUser.Controls.Add(Me.LblUsername)
        Me.ExistingUser.Controls.Add(Me.LblPassword)
        Me.ExistingUser.Controls.Add(Me.TxtPassword)
        Me.ExistingUser.Controls.Add(Me.TxtUsername)
        Me.ExistingUser.Location = New System.Drawing.Point(268, 113)
        Me.ExistingUser.Name = "ExistingUser"
        Me.ExistingUser.Size = New System.Drawing.Size(200, 182)
        Me.ExistingUser.TabIndex = 16
        Me.ExistingUser.TabStop = False
        Me.ExistingUser.Text = "Existing User"
        Me.ToolTip1.SetToolTip(Me.ExistingUser, "If you are an existing user please use your Username and Password that you create" &
        "d with us earlier.")
        '
        'NEWUser
        '
        Me.NEWUser.BackColor = System.Drawing.Color.Snow
        Me.NEWUser.Controls.Add(Me.LblNEWRePassword)
        Me.NEWUser.Controls.Add(Me.TxtNEWRePassword)
        Me.NEWUser.Controls.Add(Me.LblNEWUsername)
        Me.NEWUser.Controls.Add(Me.LblNEWPassword)
        Me.NEWUser.Controls.Add(Me.TxtNEWPassword)
        Me.NEWUser.Controls.Add(Me.TxtNEWUsername)
        Me.NEWUser.Location = New System.Drawing.Point(23, 113)
        Me.NEWUser.Name = "NEWUser"
        Me.NEWUser.Size = New System.Drawing.Size(200, 182)
        Me.NEWUser.TabIndex = 17
        Me.NEWUser.TabStop = False
        Me.NEWUser.Text = "New User"
        Me.ToolTip1.SetToolTip(Me.NEWUser, "If you would like to make an account with us please enter you're preferred:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User" &
        "name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and confirm password you typed in earlier")
        '
        'LblNEWRePassword
        '
        Me.LblNEWRePassword.AutoSize = True
        Me.LblNEWRePassword.Location = New System.Drawing.Point(17, 121)
        Me.LblNEWRePassword.Name = "LblNEWRePassword"
        Me.LblNEWRePassword.Size = New System.Drawing.Size(93, 13)
        Me.LblNEWRePassword.TabIndex = 14
        Me.LblNEWRePassword.Text = "Retype Password "
        '
        'TxtNEWRePassword
        '
        Me.TxtNEWRePassword.Location = New System.Drawing.Point(20, 137)
        Me.TxtNEWRePassword.Name = "TxtNEWRePassword"
        Me.TxtNEWRePassword.Size = New System.Drawing.Size(154, 20)
        Me.TxtNEWRePassword.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TxtNEWRePassword, "Please re-enter your password again.")
        Me.TxtNEWRePassword.UseSystemPasswordChar = True
        '
        'LblNEWUsername
        '
        Me.LblNEWUsername.AutoSize = True
        Me.LblNEWUsername.Location = New System.Drawing.Point(17, 25)
        Me.LblNEWUsername.Name = "LblNEWUsername"
        Me.LblNEWUsername.Size = New System.Drawing.Size(80, 13)
        Me.LblNEWUsername.TabIndex = 3
        Me.LblNEWUsername.Text = "Your Username"
        '
        'LblNEWPassword
        '
        Me.LblNEWPassword.AutoSize = True
        Me.LblNEWPassword.Location = New System.Drawing.Point(17, 75)
        Me.LblNEWPassword.Name = "LblNEWPassword"
        Me.LblNEWPassword.Size = New System.Drawing.Size(78, 13)
        Me.LblNEWPassword.TabIndex = 4
        Me.LblNEWPassword.Text = "Your Password"
        '
        'TxtNEWPassword
        '
        Me.TxtNEWPassword.Location = New System.Drawing.Point(20, 91)
        Me.TxtNEWPassword.Name = "TxtNEWPassword"
        Me.TxtNEWPassword.Size = New System.Drawing.Size(154, 20)
        Me.TxtNEWPassword.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TxtNEWPassword, "Password must be at least 8 characters long.")
        Me.TxtNEWPassword.UseSystemPasswordChar = True
        '
        'TxtNEWUsername
        '
        Me.TxtNEWUsername.Location = New System.Drawing.Point(20, 41)
        Me.TxtNEWUsername.Name = "TxtNEWUsername"
        Me.TxtNEWUsername.Size = New System.Drawing.Size(154, 20)
        Me.TxtNEWUsername.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TxtNEWUsername, "Username must be at least 5 characters long.")
        '
        'lblCNo
        '
        Me.lblCNo.AutoSize = True
        Me.lblCNo.Location = New System.Drawing.Point(7, 26)
        Me.lblCNo.Name = "lblCNo"
        Me.lblCNo.Size = New System.Drawing.Size(19, 13)
        Me.lblCNo.TabIndex = 18
        Me.lblCNo.Text = "co"
        Me.lblCNo.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NEWUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ExistingUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblHelp2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnLogin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnRegister)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LineBlack)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblHelp1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Snow
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnHelp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblWrongUP)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblAttempts)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnCancel)
        Me.SplitContainer1.Size = New System.Drawing.Size(522, 401)
        Me.SplitContainer1.SplitterDistance = 347
        Me.SplitContainer1.TabIndex = 19
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Firebrick
        Me.BtnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnHelp.FlatAppearance.BorderSize = 0
        Me.BtnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnHelp.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnHelp.Location = New System.Drawing.Point(442, 16)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(75, 23)
        Me.BtnHelp.TabIndex = 19
        Me.BtnHelp.Text = "Help"
        Me.ToolTip1.SetToolTip(Me.BtnHelp, "If you have any difficulty compleating this stage of identity verification please" &
        ", click on this button.")
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 0
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'MainLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(546, 426)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Globe Trotter Hotel Booking System Login"
        Me.ExistingUser.ResumeLayout(False)
        Me.ExistingUser.PerformLayout()
        Me.NEWUser.ResumeLayout(False)
        Me.NEWUser.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LineBlack As Label
    Friend WithEvents LblHelp1 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblWrongUP As Label
    Friend WithEvents LblAttempts As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblHelp2 As Label
    Friend WithEvents ExistingUser As GroupBox
    Friend WithEvents NEWUser As GroupBox
    Friend WithEvents LblNEWRePassword As Label
    Friend WithEvents TxtNEWRePassword As TextBox
    Friend WithEvents LblNEWUsername As Label
    Friend WithEvents LblNEWPassword As Label
    Friend WithEvents TxtNEWPassword As TextBox
    Friend WithEvents TxtNEWUsername As TextBox
    Friend WithEvents lblCNo As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnHelp As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
