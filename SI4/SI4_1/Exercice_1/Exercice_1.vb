Module Exercice_1

    Sub Main()
        Dim Remise, Montant_Brut, Tx_Remise, Net_HT, Montant_TTC, TVA As Double

        Const TxTVA = 0.2

        Console.WriteLine("Entrez le montant brut H.T")
        Montant_Brut = Console.ReadLine

        Console.WriteLine("Entrez le taux de remise")
        Tx_Remise = Console.ReadLine

        Remise = Montant_Brut * Tx_Remise
        Net_HT = Montant_Brut - Remise
        TVA = Net_HT * TxTVA
        Montant_TTC = Net_HT + TVA

        Console.WriteLine("Le montant brut H.T est de : " & Montant_Brut)
        Console.WriteLine("La remise est de : " & Remise)
        Console.WriteLine("Le montant Net H.T est de : " & Net_HT)
        Console.WriteLine("La TVA est de : " & TVA)
        Console.WriteLine("Le montant TTC est de : " & Montant_TTC)

        Console.Read()

    End Sub

End Module