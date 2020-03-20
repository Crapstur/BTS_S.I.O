Public Class Exercice_5
    Dim PrimeAnc, PrimeCA, RemBrut As Double

    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        TextBoxFixe.Text = String.Empty
        TextBoxPrimeAnc.Text = String.Empty
        TextBoxCaPrime.Text = String.Empty
        TextBoxRemBrut.Text = String.Empty
        ComboBoxAnc.SelectedIndex = -1
        ComboBoxCARepr.SelectedIndex = -1
        PrimeAnc = 0
        PrimeCA = 0
        RemBrut = 0

        GroupBoxRemu.Visible = False
        Me.Close()
    End Sub

    ' Boutton Calculer '
    Private Sub ButtonCalculer_Click(sender As Object, e As EventArgs) Handles ButtonCalculer.Click
        Const Fixe = 2000


        If (ComboBoxCARepr.SelectedIndex > -1) And (ComboBoxAnc.SelectedIndex > -1) Then

            Select Case ComboBoxAnc.SelectedItem.ToString()
                Case "Inférieur à 3 ans"
                    PrimeAnc = 0
                Case "Entre 3 et 10 ans (Non compris)"
                    PrimeAnc = Fixe * 0.05
                Case "Plus de 10 ans"
                    PrimeAnc = Fixe * 0.1
            End Select

            Select Case ComboBoxCARepr.SelectedItem.ToString()
                Case "Inférieur à 100 000 €"
                    PrimeCA = 0
                Case "Compris entre 100 000 € et 200 000 € (non compris)"
                    PrimeCA = 700
                Case "Supérieur ou égal à 200 000 €"
                    PrimeCA = 1500
            End Select
        End If

        RemBrut = PrimeCA + PrimeAnc + Fixe

        TextBoxNom.Text = TextBoxNom.Text
        TextBoxFixe.Text = Fixe
        TextBoxPrimeAnc.Text = PrimeAnc
        TextBoxCaPrime.Text = PrimeCA
        TextBoxRemBrut.Text = RemBrut


        GroupBoxRemu.Visible = True
        TextBoxNomAff.Text = TextBoxNom.Text
    End Sub

    ' Boutton Effacer '
    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        TextBoxFixe.Text = String.Empty
        TextBoxPrimeAnc.Text = String.Empty
        TextBoxCaPrime.Text = String.Empty
        TextBoxRemBrut.Text = String.Empty
        ComboBoxAnc.SelectedIndex = -1
        ComboBoxCARepr.SelectedIndex = -1
        PrimeAnc = 0
        PrimeCA = 0
        RemBrut = 0

        GroupBoxRemu.Visible = False
    End Sub
End Class