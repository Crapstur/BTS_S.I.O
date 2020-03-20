Public Class Exercice_7

    Dim Nom = {"Augier", "Galabert"}
    Dim Prenom = {"Denis", "Nicolas"}
    Dim TauxHoraire = {20.0, 12.25}
    Dim NbH25 = {8, 2}
    Dim NbH50 = {3, 0}
    Dim TotalSalBrut As Single

    Const NbrHeureMois = 151.67


    ' Fonction Clear '
    Public Sub Clear()
        ' Efface les listeBox.
        ListBoxNom.Items.Clear()
        ListBoxPrenom.Items.Clear()
        ListBoxNbHMois.Items.Clear()
        ListBoxTxHoraire.Items.Clear()
        ListBoxSalBase.Items.Clear()
        ListBoxNbH25.Items.Clear()
        ListBoxNbH50.Items.Clear()
        ListBoxMtH25.Items.Clear()
        ListBoxMtH50.Items.Clear()
        ListBoxSalBrut.Items.Clear()

        TotalSalBrut = 0
        TextBoxAffSalBrut.Text = String.Empty

    End Sub

    ' Boutton Calculer '
    Private Sub ButtonCalculer_Click(sender As Object, e As EventArgs) Handles ButtonCalculer.Click
        ' Efface les listeBox. '
        Clear()

        ' Rempli les listesBox. '
        For i = 0 To 1
            ListBoxNom.Items.Add(Nom(i))
            ListBoxPrenom.Items.Add(Prenom(i))
            ListBoxNbHMois.Items.Add(NbrHeureMois)
            ListBoxTxHoraire.Items.Add(TauxHoraire(i))
            ListBoxSalBase.Items.Add(Math.Round((TauxHoraire(i) * NbrHeureMois), 2))
            ListBoxNbH25.Items.Add(NbH25(i))
            ListBoxNbH50.Items.Add(NbH50(i))
            ListBoxMtH25.Items.Add(Math.Round((NbH25(i) * TauxHoraire(i) * 1.25), 2))
            ListBoxMtH50.Items.Add(Math.Round((NbH50(i) * TauxHoraire(i) * 1.5), 2))
            ListBoxSalBrut.Items.Add(Math.Round(((TauxHoraire(i) * NbrHeureMois) + (NbH25(i) * TauxHoraire(i) * 1.25) +
                                                (NbH50(i) * TauxHoraire(i) * 1.5)), 2))

            TotalSalBrut += Math.Round(((TauxHoraire(i) * NbrHeureMois) + (NbH25(i) * TauxHoraire(i) * 1.25) +
                                                (NbH50(i) * TauxHoraire(i) * 1.5)), 2)
            TextBoxAffSalBrut.Text = TotalSalBrut

        Next

    End Sub


    ' Boutton effacer '
    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        ' Efface les listeBox. '
        Clear()
    End Sub

    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        ' Efface les listeBox. '
        Clear()

        Me.Close()
    End Sub

    ' Load '
    Private Sub Exercice_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 999
        Me.Height = 394

    End Sub
End Class