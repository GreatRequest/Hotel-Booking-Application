<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCounty = New System.Windows.Forms.Label()
        Me.LblHouseNo = New System.Windows.Forms.Label()
        Me.LblCountry = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblPosteCode = New System.Windows.Forms.Label()
        Me.LblStart = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblMobile = New System.Windows.Forms.Label()
        Me.TxtCounty = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.LblEnd = New System.Windows.Forms.Label()
        Me.TxtPostecode = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.DTPStart = New System.Windows.Forms.DateTimePicker()
        Me.TxtHouseNo = New System.Windows.Forms.TextBox()
        Me.DTPEnd = New System.Windows.Forms.DateTimePicker()
        Me.TxtTown = New System.Windows.Forms.TextBox()
        Me.TxtPrefix = New System.Windows.Forms.ComboBox()
        Me.LblPrefix = New System.Windows.Forms.Label()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.LblHelp1 = New System.Windows.Forms.Label()
        Me.LblDatePick = New System.Windows.Forms.Label()
        Me.LblSurename = New System.Windows.Forms.Label()
        Me.LblDaysAmount = New System.Windows.Forms.Label()
        Me.LblDays = New System.Windows.Forms.Label()
        Me.LblHelp2 = New System.Windows.Forms.Label()
        Me.LineBlack = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblDays)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblDaysAmount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LineBlack)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblHelp2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblSurename)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblDatePick)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblHelp1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSurname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblPrefix)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPrefix)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTPEnd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtHouseNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTPStart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPostecode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblEnd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtCounty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblMobile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPhoneNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblTown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblStart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblPosteCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblHouseNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblCounty)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Snow
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnNext)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Size = New System.Drawing.Size(615, 440)
        Me.SplitContainer1.SplitterDistance = 388
        Me.SplitContainer1.TabIndex = 54
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Firebrick
        Me.BtnNext.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnNext.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnNext.Location = New System.Drawing.Point(535, 12)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 14
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Location = New System.Drawing.Point(454, 12)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "You will be able to change the information if needed. Click ""Back"" if you need to" &
    " do so."
        '
        'LblCounty
        '
        Me.LblCounty.AutoSize = True
        Me.LblCounty.Location = New System.Drawing.Point(6, 259)
        Me.LblCounty.Name = "LblCounty"
        Me.LblCounty.Size = New System.Drawing.Size(40, 13)
        Me.LblCounty.TabIndex = 36
        Me.LblCounty.Text = "County"
        '
        'LblHouseNo
        '
        Me.LblHouseNo.AutoSize = True
        Me.LblHouseNo.Location = New System.Drawing.Point(6, 220)
        Me.LblHouseNo.Name = "LblHouseNo"
        Me.LblHouseNo.Size = New System.Drawing.Size(58, 13)
        Me.LblHouseNo.TabIndex = 37
        Me.LblHouseNo.Text = "House No."
        '
        'LblCountry
        '
        Me.LblCountry.AutoSize = True
        Me.LblCountry.Location = New System.Drawing.Point(112, 259)
        Me.LblCountry.Name = "LblCountry"
        Me.LblCountry.Size = New System.Drawing.Size(43, 13)
        Me.LblCountry.TabIndex = 35
        Me.LblCountry.Text = "Country"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(6, 142)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(57, 13)
        Me.LblEmail.TabIndex = 38
        Me.LblEmail.Text = "Your Email"
        '
        'LblPosteCode
        '
        Me.LblPosteCode.AutoSize = True
        Me.LblPosteCode.Location = New System.Drawing.Point(220, 259)
        Me.LblPosteCode.Name = "LblPosteCode"
        Me.LblPosteCode.Size = New System.Drawing.Size(52, 13)
        Me.LblPosteCode.TabIndex = 33
        Me.LblPosteCode.Text = "Postcode"
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Location = New System.Drawing.Point(6, 333)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(70, 13)
        Me.LblStart.TabIndex = 39
        Me.LblStart.Text = "Book In Date"
        '
        'LblTown
        '
        Me.LblTown.AutoSize = True
        Me.LblTown.Location = New System.Drawing.Point(220, 220)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(34, 13)
        Me.LblTown.TabIndex = 31
        Me.LblTown.Text = "Town"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(70, 220)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(45, 13)
        Me.LblAddress.TabIndex = 40
        Me.LblAddress.Text = "Address"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.Snow
        Me.TxtName.Location = New System.Drawing.Point(67, 119)
        Me.TxtName.MaxLength = 20
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 2
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.BackColor = System.Drawing.Color.Snow
        Me.TxtPhoneNo.Location = New System.Drawing.Point(9, 197)
        Me.TxtPhoneNo.MaxLength = 11
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(312, 20)
        Me.TxtPhoneNo.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Snow
        Me.TxtEmail.Location = New System.Drawing.Point(9, 158)
        Me.TxtEmail.MaxLength = 40
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(312, 20)
        Me.TxtEmail.TabIndex = 4
        '
        'LblMobile
        '
        Me.LblMobile.AutoSize = True
        Me.LblMobile.Location = New System.Drawing.Point(6, 181)
        Me.LblMobile.Name = "LblMobile"
        Me.LblMobile.Size = New System.Drawing.Size(83, 13)
        Me.LblMobile.TabIndex = 43
        Me.LblMobile.Text = "Your Mobile No."
        '
        'TxtCounty
        '
        Me.TxtCounty.BackColor = System.Drawing.Color.Snow
        Me.TxtCounty.Location = New System.Drawing.Point(9, 275)
        Me.TxtCounty.MaxLength = 10
        Me.TxtCounty.Name = "TxtCounty"
        Me.TxtCounty.Size = New System.Drawing.Size(100, 20)
        Me.TxtCounty.TabIndex = 9
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(64, 103)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(35, 13)
        Me.LblName.TabIndex = 44
        Me.LblName.Text = "Name"
        '
        'TxtCountry
        '
        Me.TxtCountry.BackColor = System.Drawing.Color.Snow
        Me.TxtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCountry.Location = New System.Drawing.Point(115, 275)
        Me.TxtCountry.MaxLength = 10
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(100, 20)
        Me.TxtCountry.TabIndex = 10
        '
        'LblEnd
        '
        Me.LblEnd.AutoSize = True
        Me.LblEnd.Location = New System.Drawing.Point(163, 334)
        Me.LblEnd.Name = "LblEnd"
        Me.LblEnd.Size = New System.Drawing.Size(78, 13)
        Me.LblEnd.TabIndex = 45
        Me.LblEnd.Text = "Book Out Date"
        '
        'TxtPostecode
        '
        Me.TxtPostecode.BackColor = System.Drawing.Color.Snow
        Me.TxtPostecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPostecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostecode.Location = New System.Drawing.Point(221, 275)
        Me.TxtPostecode.MaxLength = 10
        Me.TxtPostecode.Name = "TxtPostecode"
        Me.TxtPostecode.Size = New System.Drawing.Size(100, 20)
        Me.TxtPostecode.TabIndex = 11
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.Snow
        Me.TxtAddress.Location = New System.Drawing.Point(73, 236)
        Me.TxtAddress.MaxLength = 40
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(142, 20)
        Me.TxtAddress.TabIndex = 7
        '
        'DTPStart
        '
        Me.DTPStart.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.DTPStart.CalendarTitleBackColor = System.Drawing.Color.Red
        Me.DTPStart.CausesValidation = False
        Me.DTPStart.Location = New System.Drawing.Point(9, 350)
        Me.DTPStart.MinDate = New Date(2017, 10, 19, 0, 0, 0, 0)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.Size = New System.Drawing.Size(148, 20)
        Me.DTPStart.TabIndex = 12
        '
        'TxtHouseNo
        '
        Me.TxtHouseNo.BackColor = System.Drawing.Color.Snow
        Me.TxtHouseNo.Location = New System.Drawing.Point(9, 236)
        Me.TxtHouseNo.MaxLength = 3
        Me.TxtHouseNo.Name = "TxtHouseNo"
        Me.TxtHouseNo.Size = New System.Drawing.Size(55, 20)
        Me.TxtHouseNo.TabIndex = 6
        '
        'DTPEnd
        '
        Me.DTPEnd.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.DTPEnd.CalendarTitleBackColor = System.Drawing.Color.Red
        Me.DTPEnd.CausesValidation = False
        Me.DTPEnd.Location = New System.Drawing.Point(163, 350)
        Me.DTPEnd.MinDate = New Date(2017, 10, 19, 0, 0, 0, 0)
        Me.DTPEnd.Name = "DTPEnd"
        Me.DTPEnd.Size = New System.Drawing.Size(148, 20)
        Me.DTPEnd.TabIndex = 13
        '
        'TxtTown
        '
        Me.TxtTown.BackColor = System.Drawing.Color.Snow
        Me.TxtTown.Location = New System.Drawing.Point(221, 236)
        Me.TxtTown.MaxLength = 10
        Me.TxtTown.Name = "TxtTown"
        Me.TxtTown.Size = New System.Drawing.Size(100, 20)
        Me.TxtTown.TabIndex = 8
        '
        'TxtPrefix
        '
        Me.TxtPrefix.BackColor = System.Drawing.Color.Firebrick
        Me.TxtPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtPrefix.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtPrefix.FormattingEnabled = True
        Me.TxtPrefix.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "Miss", "Dr"})
        Me.TxtPrefix.Location = New System.Drawing.Point(11, 118)
        Me.TxtPrefix.MaxLength = 5
        Me.TxtPrefix.Name = "TxtPrefix"
        Me.TxtPrefix.Size = New System.Drawing.Size(50, 21)
        Me.TxtPrefix.TabIndex = 1
        '
        'LblPrefix
        '
        Me.LblPrefix.AutoSize = True
        Me.LblPrefix.Location = New System.Drawing.Point(6, 103)
        Me.LblPrefix.Name = "LblPrefix"
        Me.LblPrefix.Size = New System.Drawing.Size(33, 13)
        Me.LblPrefix.TabIndex = 30
        Me.LblPrefix.Text = "Prefix"
        '
        'TxtSurname
        '
        Me.TxtSurname.BackColor = System.Drawing.Color.Snow
        Me.TxtSurname.Location = New System.Drawing.Point(173, 119)
        Me.TxtSurname.MaxLength = 20
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.Size = New System.Drawing.Size(148, 20)
        Me.TxtSurname.TabIndex = 3
        '
        'LblHelp1
        '
        Me.LblHelp1.AutoSize = True
        Me.LblHelp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp1.ForeColor = System.Drawing.Color.DarkRed
        Me.LblHelp1.Location = New System.Drawing.Point(6, 37)
        Me.LblHelp1.Name = "LblHelp1"
        Me.LblHelp1.Size = New System.Drawing.Size(428, 17)
        Me.LblHelp1.TabIndex = 18
        Me.LblHelp1.Text = "We need some additional information for your application."
        '
        'LblDatePick
        '
        Me.LblDatePick.AutoSize = True
        Me.LblDatePick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatePick.Location = New System.Drawing.Point(6, 307)
        Me.LblDatePick.Name = "LblDatePick"
        Me.LblDatePick.Size = New System.Drawing.Size(229, 17)
        Me.LblDatePick.TabIndex = 32
        Me.LblDatePick.Text = "You may pick a day from here:"
        '
        'LblSurename
        '
        Me.LblSurename.AutoSize = True
        Me.LblSurename.Location = New System.Drawing.Point(173, 103)
        Me.LblSurename.Name = "LblSurename"
        Me.LblSurename.Size = New System.Drawing.Size(55, 13)
        Me.LblSurename.TabIndex = 51
        Me.LblSurename.Text = "Surename"
        '
        'LblDaysAmount
        '
        Me.LblDaysAmount.AutoSize = True
        Me.LblDaysAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDaysAmount.Location = New System.Drawing.Point(328, 350)
        Me.LblDaysAmount.Name = "LblDaysAmount"
        Me.LblDaysAmount.Size = New System.Drawing.Size(124, 17)
        Me.LblDaysAmount.TabIndex = 52
        Me.LblDaysAmount.Text = "Number of Days"
        '
        'LblDays
        '
        Me.LblDays.AutoSize = True
        Me.LblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDays.Location = New System.Drawing.Point(451, 350)
        Me.LblDays.Name = "LblDays"
        Me.LblDays.Size = New System.Drawing.Size(17, 17)
        Me.LblDays.TabIndex = 53
        Me.LblDays.Text = "0"
        '
        'LblHelp2
        '
        Me.LblHelp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp2.ForeColor = System.Drawing.Color.DarkRed
        Me.LblHelp2.Location = New System.Drawing.Point(6, 54)
        Me.LblHelp2.Name = "LblHelp2"
        Me.LblHelp2.Size = New System.Drawing.Size(598, 38)
        Me.LblHelp2.TabIndex = 19
        Me.LblHelp2.Text = "To compleat your registration we need to collect some information about you. Plea" &
    "se fill any information asked below."
        '
        'LineBlack
        '
        Me.LineBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LineBlack.Location = New System.Drawing.Point(9, 35)
        Me.LineBlack.Name = "LineBlack"
        Me.LineBlack.Size = New System.Drawing.Size(595, 2)
        Me.LineBlack.TabIndex = 17
        Me.LineBlack.Text = "1"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Firebrick
        Me.LblTitle.Location = New System.Drawing.Point(49, -1)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(507, 35)
        Me.LblTitle.TabIndex = 16
        Me.LblTitle.Text = "Globe Trotter Hotel Booking System"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(639, 464)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Globe Trotter Hotel Booking System Mainform"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents LblDays As Label
    Friend WithEvents LblDaysAmount As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents LineBlack As Label
    Friend WithEvents LblHelp2 As Label
    Friend WithEvents LblSurename As Label
    Friend WithEvents LblDatePick As Label
    Friend WithEvents LblHelp1 As Label
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents LblPrefix As Label
    Friend WithEvents TxtPrefix As ComboBox
    Friend WithEvents TxtTown As TextBox
    Friend WithEvents DTPEnd As DateTimePicker
    Friend WithEvents TxtHouseNo As TextBox
    Friend WithEvents DTPStart As DateTimePicker
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPostecode As TextBox
    Friend WithEvents LblEnd As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents TxtCounty As TextBox
    Friend WithEvents LblMobile As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhoneNo As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblTown As Label
    Friend WithEvents LblStart As Label
    Friend WithEvents LblPosteCode As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblCountry As Label
    Friend WithEvents LblHouseNo As Label
    Friend WithEvents LblCounty As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Label5 As Label
End Class
