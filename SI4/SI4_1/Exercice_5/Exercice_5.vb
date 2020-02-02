Module Exercice_5
    Sub Main()

        Dim Anc, Prime, Prime_Totale, Prime_2 As Double
        Dim Sexe, Couple As Boolean

        Console.WriteLine("Entrez l'anciennete du salarie (en mois)")
        Anc = Console.ReadLine

        Console.WriteLine("Entrez si le mari et la femme son salarie dans l'entreprise (1 pour oui, 0 pour non)")
        Couple = Console.ReadLine

        Console.WriteLine("Entrez le sexe de salarie (1 pour Homme, 0 pour Femme)")
        Sexe = Console.ReadLine

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


        Console.WriteLine("L'anciennete du salarie (en mois) est de : " & Anc)
        Console.WriteLine("La prime en fonction de l'anciennete du salarie est de : " & Prime)
        Console.WriteLine("La prime 2 est de : " & Prime_2)
        Console.WriteLine("La prime totale accorde au salarie est de : " & Prime_Totale)
        Console.ReadLine()

    End Sub

End Module
