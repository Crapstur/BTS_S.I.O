Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Exercice_8
    Dim Connexion As MySqlConnection

    'Boutton Entrée '
    Private Sub RadioButtonEntrée_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEntrée.CheckedChanged
        LabelQuantitée.Text = "Quantité entrée : "
        ButtonValider.Text = "Ajouter"
    End Sub

    'Boutton sortie '
    Private Sub RadioButtonSortie_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSortie.CheckedChanged
        LabelQuantitée.Text = "Quantité sortie : "
        ButtonValider.Text = "Supprimer"
    End Sub

    'Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        ' Exercice_8_stocks1.Close() '
        Exercice_8_stocks2.Close()

        Me.Close()
    End Sub

    'Boutton Valider '
    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Try
            Connexion.Open()
            If Connexion.State = ConnectionState.Closed Then
                Connexion.Open()
            End If
            If RadioButtonEntrée.Checked Then
                Dim CommandeMaj As MySqlCommand = New MySqlCommand("Update produit Set QTESPROD = QTESPROD + @PQuantité Where REFEPROD = @PProduit", Connexion)
                CommandeMaj.Parameters.AddWithValue("@PQuantité", TextBoxQuantitée.Text)
                CommandeMaj.Parameters.AddWithValue("@PProduit", ComboBoxProduit.SelectedItem)
                CommandeMaj.ExecuteNonQuery()
            ElseIf RadioButtonSortie.Checked Then
                Dim CommandeMaj As MySqlCommand = New MySqlCommand("Update produit Set QTESPROD = QTESPROD - @PQuantité Where REFEPROD = @PProduit", Connexion)
                CommandeMaj.Parameters.AddWithValue("@PQuantité", TextBoxQuantitée.Text)
                CommandeMaj.Parameters.AddWithValue("@PProduit", ComboBoxProduit.SelectedItem)
                CommandeMaj.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connexion.Close()
        End Try

    End Sub

    ' Lancement de l'exercice '
    Private Sub Exercice_8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion = New MySqlConnection("server=localhost; userid=root; database=gestioncommerciale")
        Try
            Connexion.Open()
            If Connexion.State = ConnectionState.Closed Then
                Connexion.Open()
            End If
            Dim CommandeReff As MySqlCommand = New MySqlCommand("Select REFEPROD From produit", Connexion)
            Dim ResultatReff As MySqlDataReader = CommandeReff.ExecuteReader
            While ResultatReff.Read()
                ComboBoxProduit.Items.Add(ResultatReff("REFEPROD"))
            End While
        Catch ex As Exception
            Beep()
            MessageBox.Show("Connexion Failed")
        Finally
            Connexion.Close()
        End Try

    End Sub

    ' Boutton Afficher les stocks '
    Private Sub ButtonAffStock_Click(sender As Object, e As EventArgs) Handles ButtonAffStock.Click
        ' Exercice_8_stocks1.Show() '
        Exercice_8_stocks2.Show()
    End Sub
End Class
