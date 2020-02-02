Public Class Exercice_4
    Dim Anc, Prime, Prime_Totale, Prime_2 As Double
    Dim Sexe, Couple As Boolean

    ' Boutton Effacer
    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        ' Effacer les TextBox
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        ' Effacer les RadioButton
        RadioButtonSHomme.Checked = False
        RadioButtonSFemme.Checked = False
        RadioButtonConjOui.Checked = False
        RadioButtonConjNon.Checked = False


    End Sub

    ' Boutton Calculer
    Private Sub ButtonCalculer_Click(sender As Object, e As EventArgs) Handles ButtonCalculer.Click

        Anc = CDbl(TextBoxAnc.Text)

        If Anc < 4 Then
            Prime = 0
        ElseIf Anc <= 11 Then
            Prime = 500
        ElseIf Anc <= 36 Then
            Prime = 1200
        Else Prime = 1800

        End If

        If Sexe And Couple Then
            Prime_2 = 0
            Prime_Totale = Prime + Prime_2
        Else
            Prime_2 = 200
            Prime_Totale = Prime + Prime_2
        End If

        TextBoxPrime.Text = Prime_Totale

    End Sub

    ' Boutton Femme
    Private Sub RadioButtonSFemme_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSFemme.CheckedChanged
        Sexe = False
    End Sub

    ' Boutton Homme
    Private Sub RadioButtonSHomme_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSHomme.CheckedChanged
        Sexe = True
    End Sub

    ' Boutton Fermer
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        Me.Close()
    End Sub

End Class