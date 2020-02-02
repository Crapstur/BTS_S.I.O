Public Class Exercice_0

    'Boutton Exercice 1
    Private Sub ButtonExo1_Click(sender As Object, e As EventArgs) Handles ButtonExo1.Click
        FormSaisieMouvements.ShowDialog()
    End Sub

    'Boutton Exercice 2
    Private Sub ButtonExo2_Click(sender As Object, e As EventArgs) Handles ButtonExo2.Click
        Exercice_2.ShowDialog()

    End Sub

    'Boutton Exercice 3
    Private Sub ButtonExo3_Click(sender As Object, e As EventArgs) Handles ButtonExo3.Click
        Exercice_3.ShowDialog()
    End Sub

    'Boutton Exercice 4
    Private Sub ButtonExo4_Click(sender As Object, e As EventArgs) Handles ButtonExo4.Click
        Exercice_4.ShowDialog()

    End Sub

    'Boutton Exercice 5
    Private Sub ButtonExo5_Click(sender As Object, e As EventArgs) Handles ButtonExo5.Click
        Exercice_5.ShowDialog()

    End Sub

    'Boutton Exercice 6
    Private Sub ButtonExo6_Click(sender As Object, e As EventArgs) Handles ButtonExo6.Click
        Exercice_6.ShowDialog()

    End Sub

    ' Boutton Fermer
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        Me.Close()
    End Sub
End Class