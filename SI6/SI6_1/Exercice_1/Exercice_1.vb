Public Class FormSaisieMouvements

    'Liste produits
    Private Sub ComboBoxProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProduit.SelectedIndexChanged

    End Sub

    'Boutton Entrée
    Private Sub RadioButtonEntrée_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEntrée.CheckedChanged
        LabelQuantitée.Text = "Quantité entrée : "
    End Sub

    'Boutton sortie
    Private Sub RadioButtonSortie_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSortie.CheckedChanged
        LabelQuantitée.Text = "Quantité sortie : "
    End Sub

    'Date mouvement
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    'Zone saisie quantitées.
    Private Sub TextBoxQuantitée_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQuantitée.TextChanged

    End Sub


    'Boutton Annuler
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    'Boutton OK
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        'Description du code qui permettra la mise à jour du stock.
    End Sub

End Class
