Public Class MainLogin
    Dim counter As Integer = 3
    'Here I said that "counter" is a number and said that this number would be equal to 3
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        'This will close the form that is currently open. in this case, it will be this form and the whole application.
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        '"Register" button
        If TxtNEWUsername.Text = "" Or TxtNEWPassword.Text = "" Then
            'If the user did not type their preferred username and password then...
            MsgBox("Please enter the password and username to register.")
        ElseIf TxtNEWRePassword.Text <> TxtNEWPassword.Text Then
            'If the user did not enter their password again correctly system would not allow the user to proceed.
            'Otherwise if password don’t much error is then shown
            MsgBox("Password did not Match!, Please Re-type your password.", MsgBoxStyle.Critical)
            TxtNEWPassword.Clear()
            'Password to be cleared
            TxtNEWRePassword.Clear()
            'Retype password to be cleared
            LblNEWPassword.ForeColor = Color.Red
            LblNEWRePassword.ForeColor = Color.Red
            'Both password and retype password lables must be red for user to see the mistake.
            LblWrongUP.Text = "Password did not Match!"
            'Label Wrong Username, Password should show "Password did not Match!"
            LblWrongUP.Visible = True
            'Label Wrong Username, Password should become visible to the user.
            LblWrongUP.ForeColor = Color.Red
            'Label Wrong Username, Password should be read to bring users attention
        Else
            'If none of the above is true then this will happen
            counter = 3
            'just to say that counter is 3 again. otherwise, it shows error on the main form
            My.Settings.Username = TxtNEWUsername.Text
            'Setting saves username
            My.Settings.Password = TxtNEWPassword.Text
            'Setting saves password
            My.Settings.Save()
            'Here I tell to program that username and password is something that must be saved.

            MsgBox("You have been successfully registered on Globe-Trotter Hotel Booking System. Now when you come back just enter your username and password in existing user fields.")
            Me.Hide()
            'Current form must be hidden but not closed.
            MainForm.Show()
            'MainForm must be shown and ready for the user to use.
            TxtNEWUsername.Clear()
            'Text where user wrote they username must be cleared.
            TxtNEWPassword.Clear()
            'Text where user wrote they Password must be cleared.
            'Lastly, a message box comes out to say that user has been registered correctly and open MainForm page.
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        '"Login" button
        If TxtUsername.Text = "Admin" And TxtPassword.Text = "admin" Then
            'If the user typed Admin in username field and admin in password field then...
            counter = 3
            'just to say that counter is 3 again. otherwise, it shows error on the main form
            Me.Hide()
            'Current form must be hidden but not closed.
            MainForm.Show()
            'MainForm must be shown and ready for the user to use.
        ElseIf TxtUsername.Text = "" And TxtPassword.Text = "" Then
            'else if username and password are empty then...
            MsgBox("Please enter your username and password before login in")
            'Message box appears and says, "Please enter your username and password to login in"
            LblWrongUP.Text = "No username or password!"
            'Label Wrong Username, Password should show "No username or password!"
            LblWrongUP.Visible = True
            'Label Wrong Username, Password should become visible for user
            LblWrongUP.ForeColor = Color.Red
            'Label Wrong Username, Password should become red
        Else
            'Else if password and username are not Admin and Admin then ...
            MsgBox("Incorrect username or password, try again")
            'Message shows Incorrect username or password, try again
            TxtUsername.Clear()
            TxtPassword.Clear()
            'Both password and username textboxes must be cleared
            counter = counter - 1
            'Counter must decrease on 1 counter (3) -1
            LblAttempts.Text = "Attempts Left!!!"
            'Label attempts must show this text "Attempts Left!!!"
            lblCNo.Text = counter
            'Then Label counter must show how many attempts left or the number of counters
            lblCNo.Visible = True
            'Label counter must be shown and show number
            LblAttempts.Visible = True
            'Label with attempts must show
            LblWrongUP.Text = "Username or password entered is incorrect!"
            'Label wrong Username, Password must now show "Username or password entered is incorrect!"
            LblWrongUP.Visible = True
            'Label wrong Username, Password must now be show
            LblWrongUP.ForeColor = Color.Red
            'Label wrong Username, Password must now be red
            LblUsername.Visible = True
            'label username must be shown
            LblUsername.ForeColor = Color.Red
            'label username must be read
            LblPassword.Visible = True
            'Label password must be shown
            LblPassword.ForeColor = Color.Red
            'Label password must be red

            'here if username or password do not much system will tell that one or both are incorrect and start countdown so that user won’t have unlimited tries to unlock application.
        End If
        If counter = 2 Then
            'if counter gets to number 2 then...
            MsgBox("You have 2 attempts left!")
            'just to say user has two attempts left
        End If
        If counter = 1 Then
            'if counter gets to number 1
            MsgBox("you have only 1 attempt left. If you fail on next attempt system will be locked for you.")
            'just to say user have one attempt left
        End If
        If counter = 0 Then
            'if counter gets to 0 then...
            MsgBox("Sorry you don’t have any more attempts. your account is locked. Try again in 10 min.")
            BtnLogin.Enabled = False
            'button login must be disabled
            BtnRegister.Enabled = False
            'button register must be disabled
            'here the user is left with no available attempts and will be locked out.
        End If
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        '"Help" button
        MsgBox("If you having problems login in to form here is the username and password.
Username: Admin
Password: admin")
        'this is to help people log in as this application is not for commercial use and will not actually allow users to register password and username is predefined.
    End Sub
End Class