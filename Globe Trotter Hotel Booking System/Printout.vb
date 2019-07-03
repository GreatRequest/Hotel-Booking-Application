Public Class Printout
    Private WithEvents docToPrint As New Printing.PrintDocument
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDialogPrintoutForm.Document = docToPrint

        Dim result As DialogResult = PrintDialogPrintoutForm.ShowDialog()

        ' If the result is OK then print the document.
        If (result = DialogResult.OK) Then
            PrintForm.Print()
        End If
    End Sub
End Class