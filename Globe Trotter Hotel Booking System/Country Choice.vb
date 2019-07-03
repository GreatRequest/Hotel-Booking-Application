Public Class Country_Choice
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        MainForm.Close()
        MainLogin.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub ChkBxSpain_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxSpain.CheckedChanged
        If ChkBxSpain.Checked = True Then
            ChkBxItaly.Enabled = False
            ChkBxItaly.Checked = False
            ChkBxGermany.Enabled = False
            ChkBxGermany.Checked = False
            ChkBxEngland.Enabled = False
            ChkBxEngland.Checked = False

            RadBtnMadrid.Enabled = True
            RadBtnBarcelona.Enabled = True
            RadBtnValencia.Enabled = True

            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            Summary.LblDisCountry.Text = ChkBxSpain.Text

            LblBookFee_.Text = "10"
        Else
            ChkBxItaly.Enabled = True
            ChkBxGermany.Enabled = True
            ChkBxEngland.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub ChkBxItaly_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxItaly.CheckedChanged
        If ChkBxItaly.Checked = True Then
            ChkBxSpain.Enabled = False
            ChkBxSpain.Checked = False
            ChkBxGermany.Enabled = False
            ChkBxGermany.Checked = False
            ChkBxEngland.Enabled = False
            ChkBxEngland.Checked = False

            RadBtnRome.Enabled = True
            RadBtnPisa.Enabled = True
            RadBtnVenice.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            Summary.LblDisCountry.Text = ChkBxItaly.Text

            LblBookFee_.Text = "5"
        Else
            ChkBxSpain.Enabled = True
            ChkBxGermany.Enabled = True
            ChkBxEngland.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub ChkBxGermany_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxGermany.CheckedChanged
        If ChkBxGermany.Checked = True Then
            ChkBxSpain.Enabled = False
            ChkBxSpain.Checked = False
            ChkBxItaly.Enabled = False
            ChkBxItaly.Checked = False
            ChkBxEngland.Enabled = False
            ChkBxEngland.Checked = False

            RadBtnBerlin.Enabled = True
            RadBtnHamburg.Enabled = True
            RadBtnDusseldorf.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            Summary.LblDisCountry.Text = ChkBxGermany.Text

            LblBookFee_.Text = "20"
        Else
            ChkBxSpain.Enabled = True
            ChkBxItaly.Enabled = True
            ChkBxEngland.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub ChkBxEngland_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxEngland.CheckedChanged
        If ChkBxEngland.Checked = True Then
            ChkBxSpain.Enabled = False
            ChkBxSpain.Checked = False
            ChkBxItaly.Enabled = False
            ChkBxItaly.Checked = False
            ChkBxGermany.Enabled = False
            ChkBxGermany.Checked = False

            RadBtnLondon.Enabled = True
            RadBtnManchester.Enabled = True
            RadBtnBirmingham.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False

            Summary.LblDisCountry.Text = ChkBxEngland.Text

            LblBookFee_.Text = "15"
        Else
            ChkBxSpain.Enabled = True
            ChkBxItaly.Enabled = True
            ChkBxGermany.Enabled = True

            RadBtnMadrid.Enabled = False
            RadBtnBarcelona.Enabled = False
            RadBtnValencia.Enabled = False
            RadBtnRome.Enabled = False
            RadBtnPisa.Enabled = False
            RadBtnVenice.Enabled = False
            RadBtnBerlin.Enabled = False
            RadBtnHamburg.Enabled = False
            RadBtnDusseldorf.Enabled = False
            RadBtnLondon.Enabled = False
            RadBtnManchester.Enabled = False
            RadBtnBirmingham.Enabled = False

            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub ChkBx3Star_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx3Star.CheckedChanged
        If ChkBx3Star.Checked = True Then
            ChkBx4Star.Enabled = False
            ChkBx4Star.Checked = False
            ChkBx5Star.Enabled = False
            ChkBx5Star.Checked = False
            BtnNext.Enabled = True
            Summary.lblStars.Text = "5 Stars"
            Summary.LblPrcePrNght_.Text = "£130"
            LblBookPeriod_.Text = LblDays.Text * 130

            LblNo20VAT_.Text = (CDbl(LblBookFee_.Text) + CDbl(LblBookPeriod_.Text)).ToString
            Lbl20VAT_.Text = LblNo20VAT_.Text + ((20 / 100) * LblNo20VAT_.Text)
        Else
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            BtnNext.Enabled = False

            LblBookPeriod_.Text = LblBookPeriod_.Text - (LblDays.Text * 130)

            LblNo20VAT_.Text = "0"
            Lbl20VAT_.Text = "0"
        End If
    End Sub

    Private Sub ChkBx4Star_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx4Star.CheckedChanged
        If ChkBx4Star.Checked = True Then
            ChkBx3Star.Enabled = False
            ChkBx3Star.Checked = False
            ChkBx5Star.Enabled = False
            ChkBx5Star.Checked = False
            BtnNext.Enabled = True
            Summary.lblStars.Text = "4 Stars"
            Summary.LblPrcePrNght_.Text = "£200"
            LblBookPeriod_.Text = LblDays.Text * 200

            LblNo20VAT_.Text = (CDbl(LblBookFee_.Text) + CDbl(LblBookPeriod_.Text)).ToString
            Lbl20VAT_.Text = LblNo20VAT_.Text + ((20 / 100) * LblNo20VAT_.Text)
        Else
            ChkBx3Star.Enabled = True
            ChkBx5Star.Enabled = True
            BtnNext.Enabled = False

            LblBookPeriod_.Text = LblBookPeriod_.Text - (LblDays.Text * 200)

            LblNo20VAT_.Text = "0"
            Lbl20VAT_.Text = "0"
        End If
    End Sub

    Private Sub ChkBx5Star_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx5Star.CheckedChanged
        If ChkBx5Star.Checked = True Then
            ChkBx4Star.Enabled = False
            ChkBx4Star.Checked = False
            ChkBx3Star.Enabled = False
            ChkBx3Star.Checked = False
            BtnNext.Enabled = True
            Summary.lblStars.Text = "5 Stars"
            Summary.LblPrcePrNght_.Text = "£270"
            LblBookPeriod_.Text = LblDays.Text * 270

            LblNo20VAT_.Text = (CDbl(LblBookFee_.Text) + CDbl(LblBookPeriod_.Text)).ToString
            Lbl20VAT_.Text = LblNo20VAT_.Text + ((20 / 100) * LblNo20VAT_.Text)
        Else
            ChkBx4Star.Enabled = True
            ChkBx3Star.Enabled = True
            BtnNext.Enabled = False

            LblBookPeriod_.Text = LblBookPeriod_.Text - (LblDays.Text * 270)

            LblNo20VAT_.Text = "0"
            Lbl20VAT_.Text = "0"
        End If
    End Sub
    Private Sub RadBtnMadrid_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnMadrid.CheckedChanged
        If RadBtnMadrid.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 7
            Summary.LblDisCity.Text = RadBtnMadrid.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If

    End Sub

    Private Sub RadBtnBarcelona_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnBarcelona.CheckedChanged
        If RadBtnBarcelona.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 8
            Summary.LblDisCity.Text = RadBtnBarcelona.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnValencia_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnValencia.CheckedChanged
        If RadBtnValencia.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 18
            Summary.LblDisCity.Text = RadBtnValencia.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnRome_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnRome.CheckedChanged
        If RadBtnRome.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 14
            Summary.LblDisCity.Text = RadBtnRome.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnPisa_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnPisa.CheckedChanged
        If RadBtnPisa.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 12
            Summary.LblDisCity.Text = RadBtnPisa.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnVenice_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnVenice.CheckedChanged
        If RadBtnVenice.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 11
            Summary.LblDisCity.Text = RadBtnVenice.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnBerlin_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnBerlin.CheckedChanged
        If RadBtnBerlin.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 10
            Summary.LblDisCity.Text = RadBtnBerlin.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnHamburg_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnHamburg.CheckedChanged
        If RadBtnHamburg.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 13
            Summary.LblDisCity.Text = RadBtnHamburg.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnDusseldorf_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnDusseldorf.CheckedChanged
        If RadBtnDusseldorf.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 8
            Summary.LblDisCity.Text = RadBtnDusseldorf.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnLondon_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnLondon.CheckedChanged
        If RadBtnLondon.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 15
            Summary.LblDisCity.Text = RadBtnLondon.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnManchester_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnManchester.CheckedChanged
        If RadBtnManchester.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 11
            Summary.LblDisCity.Text = RadBtnManchester.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub RadBtnBirmingham_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnBirmingham.CheckedChanged
        If RadBtnBirmingham.Checked = True Then
            ChkBx3Star.Enabled = True
            ChkBx4Star.Enabled = True
            ChkBx5Star.Enabled = True
            LblBookFee_.Text = LblBookFee_.Text + 12
            Summary.LblDisCity.Text = RadBtnBirmingham.Text
        Else
            ChkBx3Star.Enabled = False
            ChkBx4Star.Enabled = False
            ChkBx5Star.Enabled = False
            LblBookFee_.Text = "0"
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.Hide()
        Summary.Show()
        Summary.LblDays.Text = LblDays.Text
        Summary.LblBookFee_.Text = LblBookFee_.Text
        Summary.LblBookPeriod_.Text = LblBookPeriod_.Text
        Summary.LblNo20VAT_.Text = LblNo20VAT_.Text
        Summary.Lbl20VAT_.Text = Lbl20VAT_.Text
        Summary.LblName_.Text = Summary.TxtFullname.Text
    End Sub
End Class