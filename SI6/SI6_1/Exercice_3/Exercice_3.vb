Public Class Exercice_3
    Dim Academie As String


    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        Me.Close()
        Exercice_0.Show()
    End Sub

    ' Liste Académies '
    Private Sub ComboBoxAcad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAcad.SelectedIndexChanged
        Academie = ComboBoxAcad.Text

        TextBoxVacToussain.Text = "19 / 10 / 2019 - 4 / 11 / 2019"
        TextBoxVacNoel.Text = "21 / 12 / 2019 - 6 / 1 / 2020"

        Select Case Academie
            Case "Besançon", "Bordeaux", "Clermont-Ferrand", "Dijon", "Grenoble", "Limoges", "Lyon", "Poitiers" : TextBoxZone.Text = "A"
                TextBoxVacHiver.Text = "22 / 02 / 2020 - 09 / 03 / 2020"
                TextBoxVacPrintemps.Text = "18 / 04 / 2020 - 04 / 05 / 2020"
            Case "Aix - Marseille", "Amiens", "Caen", "Lille", "Nancy-Metz", "Nantes", "Nice", "Orléans-Tours", "Reims", "Rennes", "Rouen", "Strasbourg" : TextBoxZone.Text = "B"
                TextBoxVacHiver.Text = "15 / 02 / 2020 - 02 / 03 / 2020"
                TextBoxVacPrintemps.Text = "11 / 04 / 2020 - 27 / 04 / 2020"
            Case "Créteil", "Montpelllier", "Paris", "Toulouse", "Versaille" : TextBoxZone.Text = "C"
                TextBoxVacHiver.Text = "8 / 2 / 2020 - 24 / 2 / 2020"
                TextBoxVacPrintemps.Text = "04 / 04 / 2020 - 20 / 04 / 2020"
        End Select

    End Sub

End Class