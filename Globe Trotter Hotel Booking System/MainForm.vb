Public Class MainForm
    Dim diff As String
    Dim startdate, enddate As Date
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If TxtPrefix.Text = "" Then
            'If one of the fields is empty then message saying that the field is empty, and label of the field will have to get red
            MsgBox("You did not enter your Prefix. Please choose your Prefix from drop-down menu by clicking the arrow pointing downwards")
            LblPrefix.ForeColor = Color.Red
        ElseIf TxtName.Text = "" Then
            MsgBox("You did not enter your Name. Please enter your Name and fill any other empty fields")
            LblName.ForeColor = Color.Red
        ElseIf TxtSurname.Text = "" Then
            MsgBox("You did not enter your Surname. Please enter your Surename and fill any other empty fields")
            LblSurename.ForeColor = Color.Red
        ElseIf TxtEmail.Text = "" Then
            MsgBox("You did not enter your Email. Please enter your Email and fill any other empty fields")
            LblEmail.ForeColor = Color.Red
        ElseIf TxtPhoneNo.Text = "" Then
            MsgBox("You did not enter your Phone No. Please enter your Phone No. and fill any other empty fields")
            LblMobile.ForeColor = Color.Red
        ElseIf TxtHouseNo.Text = "" Then
            MsgBox("You did not enter your House No. Please enter your House No. and fill any other empty fields")
            LblHouseNo.ForeColor = Color.Red
        ElseIf TxtAddress.Text = "" Then
            MsgBox("You did not enter your Address. Please enter your Address and fill any other empty fields")
            LblAddress.ForeColor = Color.Red
        ElseIf TxtTown.Text = "" Then
            MsgBox("You did not enter your Town. Please enter your Town and fill any other empty fields")
            LblTown.ForeColor = Color.Red
        ElseIf TxtCounty.Text = "" Then
            MsgBox("You did not enter your County. Please enter your County and fill any other empty fields")
            LblCounty.ForeColor = Color.Red
        ElseIf TxtCountry.Text = "" Then
            MsgBox("You did not enter your Country. Please enter your Country and fill any other empty fields")
            LblCountry.ForeColor = Color.Red
        ElseIf TxtPostecode.Text = "" Then
            MsgBox("You did not enter your Postecode. Please enter your Postecode and fill any other empty fields")
            LblPosteCode.ForeColor = Color.Red
        ElseIf DTPStart.Text = DTPEnd.Text Then
            'if start and end days are the same then...
            MsgBox("You can not set today's day as the book out day. If you did not set the book out day you need to do it now.")
            BtnNext.Enabled = False
            LblStart.ForeColor = Color.Red
            LblEnd.ForeColor = Color.Red
            'message must be shown, label for start and end date must be red colour
        ElseIf diff = 0 Then
            'if the difference between days is equal to 0 then...
            MsgBox("You cannot set book out day before or on book in day. please change the book out day now.")
            BtnNext.Enabled = False
            LblEnd.ForeColor = Color.Red
            'button next must be disabled and label of end date get red.
        Else
            Country_Choice.Show()
            Me.Hide()
            Country_Choice.LblDays.Text = LblDays.Text
            Summary.TxtFullname.Text = TxtPrefix.Text & Space(1) & TxtName.Text & Space(1) & TxtSurname.Text
            ' space(1) equal to how many times there will be space inserted before the next thing will be written.
            Summary.TxtEmail.Text = TxtEmail.Text
            Summary.TxtPhoneNo.Text = TxtPhoneNo.Text
            Summary.TxtHouseNo.Text = TxtHouseNo.Text
            Summary.TxtAddress.Text = TxtAddress.Text
            Summary.TxtTown.Text = TxtTown.Text
            Summary.TxtCounty.Text = TxtCounty.Text
            Summary.TxtCountry.Text = TxtCountry.Text
            Summary.TxtPostecode.Text = TxtPostecode.Text
            Summary.LblCheckin_.Text = DTPStart.Text
            Summary.LblCheckout_.Text = DTPEnd.Text
            'if non of the statements above are true then country_choice form must be shown and text copied from textboxes to summery form.
        End If
    End Sub

    Private Sub DTPStart_ValueChanged(sender As Object, e As EventArgs) Handles DTPStart.ValueChanged
        If DTPStart.Value < Today Then
            MsgBox("You can not set day before today as the book in day. Please choose today's day or later.")
            BtnNext.Enabled = False
            DTPEnd.Enabled = False
        Else
            BtnNext.Enabled = True
            DTPEnd.Enabled = True
        End If
    End Sub

    Private Sub DTPEnd_ValueChanged(sender As Object, e As EventArgs) Handles DTPEnd.ValueChanged
        If DTPEnd.Value = DTPStart.Value Then
            MsgBox("You can not set bookout day as bookin day. Chose the next day after the bookin day.")
            BtnNext.Enabled = False
        ElseIf DTPEnd.Value < DTPStart.Value Then
            MsgBox("You can not set book out day before book in day. Please choose at least one day after the book in day.")
            BtnNext.Enabled = False
        Else
            BtnNext.Enabled = True
            startdate = DTPStart.Value
            enddate = DTPEnd.Value
            diff = DateDiff(DateInterval.Day, startdate, enddate) + 1
            LblDays.Text = diff
        End If
    End Sub

    Private Sub TxtPhoneNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPhoneNo.KeyPress

        Dim AllowedChars As String = "-0123456789()"
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only numbers allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtName_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtName.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtName.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar

        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm "
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If

    End Sub

    Private Sub TxtSurname_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtSurname.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtSurname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar

        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm "
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtAddress_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtAddress.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtAddress.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm,. "
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtTown_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtTown.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtTown.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm"
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtCounty_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCounty.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtCounty.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm"
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtCountry_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCountry.KeyPress

        Static PreviousLetter As Char
        If PreviousLetter = " "c Or TxtCountry.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
        Dim AllowedChars As String = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm"
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only letters allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub TxtHouseNo_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtHouseNo.KeyPress
        Dim AllowedChars As String = "0123456789"
        If e.KeyChar <> ControlChars.Back Then
            If AllowedChars.IndexOf(e.KeyChar) = -1 Then
                'Invalid charrecter
                e.Handled = True


                MessageBox.Show("Only numbers allowed to be used in this field.")
            End If
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPStart.MinDate = Today
        DTPEnd.MinDate = Today
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        MainLogin.Close()
    End Sub
End Class