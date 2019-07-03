Imports System.IO
Public Class Summary
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim result As Integer = MessageBox.Show("You are about to be logged out.
After clicking on, yes all not saved information will be erased! Are you sure you want to do it?", "You are about to be logged out", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Please check provided information again and if you are happy with it, click on confirm next time.")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("You are now exiting the program. Any not saved information will be deleted but if you wish to make a new application form just start the program again.
Goodbye, and thank you for using our service.")
            Me.Close()
            Country_Choice.Close()
            MainForm.Close()
            MainLogin.Close()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Country_Choice.Show()
    End Sub

    Private Sub LblName__Click(sender As Object, e As EventArgs) Handles LblName_.Click

    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Printout.LblTodayDays.Text = Date.Now.ToString("MM/dd/yyyy")
        Dim RandGen As New Random
        ' The program will generate a number from 10000000 to 100000000
        Printout.LblInvoiceNo.Text = RandGen.Next(10000000, 100000000).ToString
        Printout.LblDays.Text = LblDays.Text
        Printout.TxtFullname.Text = TxtFullname.Text
        Printout.TxtEmail.Text = TxtEmail.Text
        Printout.TxtPhoneNo.Text = TxtPhoneNo.Text
        Printout.TxtHouseNo.Text = TxtHouseNo.Text
        Printout.TxtAddress.Text = TxtAddress.Text
        Printout.TxtTown.Text = TxtTown.Text
        Printout.TxtCounty.Text = TxtCounty.Text
        Printout.TxtCountry.Text = TxtCountry.Text
        Printout.TxtPostecode.Text = TxtPostecode.Text
        Printout.LblCheckin_.Text = LblCheckin_.Text
        Printout.LblCheckout_.Text = LblCheckout_.Text
        Printout.LblBookFee_.Text = LblBookFee_.Text
        Printout.LblBookPeriod_.Text = LblBookPeriod_.Text
        Printout.LblNo20VAT_.Text = LblNo20VAT_.Text
        Printout.Lbl20VAT_.Text = Lbl20VAT_.Text
        Printout.LblName_.Text = LblName_.Text
        Printout.LblDisCountry.Text = LblDisCountry.Text
        Printout.LblDisCity.Text = LblDisCity.Text
        Printout.lblStars.Text = lblStars.Text
        Printout.LblPrcePrNght_.Text = LblPrcePrNght_.Text
        Printout.Show()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim result As Integer = MessageBox.Show("You are about to save and close the application. Are you sure you want to do it?
Click No or Cancel to go back to program else click Yes.", "You are about to be logged out", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Please check all of the information again and if you are happy with it, click confirm, then click on yes next time.")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Please check all of the information again and if you are happy with it, click confirm, then click on yes next time.")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("You will now see the window popup. Please select where you want the information to be saved and click Save. The application will be closed after you finished.
Thank you for using our services.")
            Dim FileWriter As StreamWriter
            Dim Results As DialogResult
            Results = SaveFileDialog1.ShowDialog
            If Results = DialogResult.OK Then
                FileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
                FileWriter.WriteLine("Full Name: " + TxtFullname.Text)
                FileWriter.WriteLine("House No.: " + TxtHouseNo.Text)
                FileWriter.WriteLine("Address: " + TxtAddress.Text)
                FileWriter.WriteLine("Town: " + TxtTown.Text)
                FileWriter.WriteLine("County: " + TxtCounty.Text)
                FileWriter.WriteLine("Country: " + TxtCountry.Text)
                FileWriter.WriteLine("Postcode: " + TxtPostecode.Text)
                FileWriter.WriteLine("Telephone No.: " + TxtPhoneNo.Text)
                FileWriter.WriteLine("E-mail Address: " + TxtEmail.Text)
                FileWriter.WriteLine("Destination Country: " + LblDisCountry.Text)
                FileWriter.WriteLine("Destination City: " + LblDisCity.Text)
                FileWriter.WriteLine("Hotel Stars No.: " + lblStars.Text)
                FileWriter.WriteLine("Hotel Booking Fee: " + LblBookFee_.Text)
                FileWriter.WriteLine("Price For Booked Period: " + LblPrcePrNght_.Text)
                FileWriter.WriteLine("Book in Day: " + LblCheckin_.Text)
                FileWriter.WriteLine("Book out Day: " + LblCheckout_.Text)
                FileWriter.WriteLine("Total Excluding 20% VAT: £" + LblNo20VAT_.Text)
                FileWriter.WriteLine("Total Including 20% VAT: £" + Lbl20VAT_.Text)
                FileWriter.Close()
            End If
            Printout.Close()
            Me.Close()
            Country_Choice.Close()
            MainForm.Close()
            MainLogin.Close()
        End If
    End Sub
End Class