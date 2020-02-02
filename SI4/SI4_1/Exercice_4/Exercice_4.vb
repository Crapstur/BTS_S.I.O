Module Exercice_4

    Sub Main()
        Dim Chiffre_Affaire_Mois, Prime_CA, Sal_Brut As Double

        Const Fixe = 1800

        Console.WriteLine("Entrez le chiffre d'affaire du mois")
        Chiffre_Affaire_Mois = Console.ReadLine

        If Chiffre_Affaire_Mois <= 25000 Then
            Prime_CA = 0.02 * Chiffre_Affaire_Mois
        Else Prime_CA = 0.05 * Chiffre_Affaire_Mois
        End If
        Sal_Brut = Fixe + Prime_CA


        Console.WriteLine("Le montant du salaire fixe est de : " & Fixe)
        Console.WriteLine("La prime sur chiffre d'affaire est de : " & Prime_CA)
        Console.WriteLine("Le montant du salaire brut est de : " & Sal_Brut)

        Console.Read()

    End Sub

End Module
