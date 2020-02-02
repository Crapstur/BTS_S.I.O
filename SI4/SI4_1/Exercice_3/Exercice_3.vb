Module Exercice_3

    Sub Main()
        Dim Montant_Brut, Remise, MTTVA, MTTTC, Montant_Net As Double

        Const TxTVA = 0.2
        Const TxRemise = 0.05

        Console.WriteLine("Entrez le montant brut H.T")
        Montant_Brut = Console.ReadLine

        If Montant_Brut >= 20000 Then
            Remise = Montant_Brut * TxRemise
        Else Remise = 0
        End If
        Montant_Net = Montant_Brut - Remise
        MTTVA = Montant_Net * TxTVA
        MTTTC = Montant_Net + MTTVA

        Console.WriteLine("Le montant brut H.T est de : " & Montant_Brut)
        Console.WriteLine("Le montant de la remise est de : " & Remise)
        Console.WriteLine("Le montant Net H.T est de : " & Montant_Net)
        Console.WriteLine("Le montant de la TVA est de : " & MTTVA)
        Console.WriteLine("Le montant TTC est de : " & MTTTC)

        Console.Read()

    End Sub

End Module
