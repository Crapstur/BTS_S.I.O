Public Class Exercice_7_bis

    Dim Nom = {"Augier", "Galabert"}
    Dim Prenom = {"Denis", "Nicolas"}
    Dim TauxHoraire() = {20.0, 12.25, 13}
    Dim NbH25(2) As Integer
    Dim NbH50(2) As Integer
    Dim TotalSalBrut As Single
    Dim i As Integer = 0
    Dim j As Integer = 0


    Const NbrHeureMois = 151.67

    ' Fonction Calculer '
    Public Sub Calculer()
        ' Efface les listeBox.
        Clear()

        ' Rempli les listesBox '
        For i = 0 To (Nom.Length - 1)
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

    ' Fonction Clear '
    Public Sub Clear()
        ' Efface les listeBox. '
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
        Calculer()

    End Sub

    ' Boutton Effacer '
    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        ' Efface les listeBox. '
        Clear()
    End Sub

    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        ' Efface les listeBox. '
        Clear()

        NbH25(0) = 0
        NbH25(1) = 0

        NbH50(0) = 0
        NbH50(1) = 0


        Me.Close()
    End Sub

    ' Load '
    Private Sub Exercice_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 999
        Me.Height = 406
        GroupBox1Debut.Visible = True
        GroupBox1Debut.Location = New System.Drawing.Point(0, 0)
        GroupBox1Debut.Width = 999
        GroupBox1Debut.Height = 406
        i = 0
        j = 0

        TextBoxNbrH25.ReadOnly = False
        TextBoxNbrH50.ReadOnly = False

        ButtonEnregistrer.Visible = True


        LabelNomRepr.Text = Nom(j)
        LabelPrenomRepr.Text = Prenom(j)

    End Sub

    ' Boutton Enregistrer '
    Private Sub ButtonEnregistrer_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrer.Click
        NbH25(i) = CInt(TextBoxNbrH25.Text)
        NbH50(i) = CInt(TextBoxNbrH50.Text)

        TextBoxNbrH25.Text = String.Empty
        TextBoxNbrH50.Text = String.Empty
        i += 1
        j += 1

        If j < Nom.Length Then
            LabelNomRepr.Text = Nom(j)
            LabelPrenomRepr.Text = Prenom(j)
        Else
            LabelNomRepr.Text = ""
            LabelPrenomRepr.Text = ""

            TextBoxNbrH25.ReadOnly = True
            TextBoxNbrH50.ReadOnly = True
            ButtonEnregistrer.Visible = False


        End If



    End Sub

    ' Boutton Afficher '
    Private Sub ButtonAfficher_Click(sender As Object, e As EventArgs) Handles ButtonAfficher.Click
        GroupBox1Debut.Visible = False

        Calculer()

    End Sub
End Class