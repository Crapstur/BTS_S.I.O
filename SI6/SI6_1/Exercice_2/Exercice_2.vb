Public Class Exercice_2
    Dim Remise, MTTVA, MTTTC, Montant_Net As Double
    Dim MtBrut As Integer

    Private Sub Exercice_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        Me.Close()
    End Sub

    ' Boutton effacer '
    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click

        For each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

    End Sub

    ' Boutton calculer '
    Private Sub ButtonCalculer_Click(sender As Object, e As EventArgs) Handles ButtonCalculer.Click

        MtBrut = Val(TextBoxMtBrut.Text)
        Const TxTVA = 0.2
        Const TxRemise = 0.05

        If MtBrut >= 20000 Then
            Remise = MtBrut * TxRemise
        Else
            Remise = 0
        End If

        Montant_Net = MtBrut - Remise
        MTTVA = Montant_Net * TxTVA
        MTTTC = Montant_Net + MTTVA

        TextBoxMtBrutHT.Text = MtBrut
        TextBoxMtRemise.Text = Remise
        TextBoxMtNetHT.Text = Montant_Net
        TextBoxMtTVA.Text = MTTVA
        TextBoxMtTTC.Text = MTTTC

        Console.Read()
    End Sub

End Class