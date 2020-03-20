Public Class Exercice_6

    Dim Act As Integer
    Dim NbrTour As Integer
    Dim NbrSportif, NbrCulturelle, NbrManuelle As Integer
    Dim Depense As Double


    ' Boutton Refaire. '
    Private Sub ButtonRefaire_Click(sender As Object, e As EventArgs) Handles ButtonRefaire.Click
        TextBoxQ2.Text = ""
        ComboBoxQ1.SelectedIndex = -1

        GroupBoxQuestionnaire.Visible = True
        GroupBoxAffichage.Visible = False
        GroupBoxQuestionnaire.Location = New System.Drawing.Point(16, 81)
        GroupBoxQuestionnaire.Width = 798
        GroupBoxQuestionnaire.Height = 311
        TextBoxAffMoy.Text = String.Empty
        Depense = 0

        NbrCulturelle = 0
        NbrManuelle = 0
        NbrSportif = 0
        Me.Width = 848
        Me.Height = 485
        NbrTour = 0

    End Sub


    ' Lancement de l'exercice 6 '
    Private Sub Exercice_6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NbrCulturelle = 0
        NbrManuelle = 0
        NbrSportif = 0
        Me.Width = 848
        Me.Height = 485
        NbrTour = 0

        GroupBoxQuestionnaire.Visible = True
        GroupBoxAffichage.Visible = False
        GroupBoxQuestionnaire.Location = New System.Drawing.Point(28, 66)
        GroupBoxQuestionnaire.Width = 798
        GroupBoxQuestionnaire.Height = 311

    End Sub


    ' Button Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        GroupBoxQuestionnaire.Visible = False
        GroupBoxAffichage.Visible = False
        ButtonCadreSuivant.Visible = True

        TextBoxQ2.Text = ""
        TextBoxAffMoy.Text = String.Empty
        Depense = 0
        NbrSportif = 0
        NbrCulturelle = 0
        NbrManuelle = 0
        NbrTour = 0


        Me.Close()
    End Sub

    ' Button Enregistrement '
    Private Sub ButtonCadreSuivant_Click(sender As Object, e As EventArgs) Handles ButtonCadreSuivant.Click

        Act = ComboBoxQ1.SelectedIndex

        Select Case Act
            Case 0
                NbrSportif += 1
            Case 1
                NbrManuelle += 1
            Case 2
                NbrCulturelle += 1
        End Select

        If TextBoxQ2.Text <> "" Then
            Depense += CDbl(TextBoxQ2.Text)
        End If

        TextBoxQ2.Text = ""
        ComboBoxQ1.SelectedIndex = -1

        NbrTour += 1

    End Sub

    ' Button Terminer --> Affichage '
    Private Sub ButtonTerminer_Click(sender As Object, e As EventArgs) Handles ButtonTerminer.Click

        TextBoxQ2.Text = ""
        ComboBoxQ1.SelectedIndex = -1

        TextBoxAffSport.Text = Math.Round(((NbrSportif / NbrTour) * 100), 2)
        TextBoxAffMan.Text = Math.Round(((NbrManuelle / NbrTour) * 100), 2)
        TextBoxAffCult.Text = Math.Round(((NbrCulturelle / NbrTour) * 100), 2)
        TextBoxAffMoy.Text = Math.Round(Depense / NbrTour)
        TextBoxAffNbrParticipant.Text = Math.Round(NbrTour)


        GroupBoxQuestionnaire.Visible = False
        GroupBoxAffichage.Visible = True
        GroupBoxAffichage.Location = New System.Drawing.Point(16, 81)
        GroupBoxAffichage.Width = 798
        GroupBoxAffichage.Height = 311


    End Sub
End Class