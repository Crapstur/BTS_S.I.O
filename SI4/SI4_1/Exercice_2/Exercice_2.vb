Module Exercice_2

    Sub Main()
        Dim Chiffre_Affaire, PRICA, Sal_Brut As Double

        Const Fixe = 1800

        Console.WriteLine("Entrez le chiffre d'affaire")
        Chiffre_Affaire = Console.ReadLine

        PRICA = 0.05 * Chiffre_Affaire
        Sal_Brut = Fixe + PRICA

        Console.WriteLine("Le montant du fixe est de : " & Fixe)
        Console.WriteLine("Le montant de la prime de chiffre d'affaire est de : " & PRICA)
        Console.WriteLine("Le montant du salaire brut est de : " & Sal_Brut)

        Console.Read()

    End Sub

End Module
