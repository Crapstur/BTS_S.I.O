Module Exercice_7
    Enum Statut
        Cadre = 1
        Non_Cadre = 2
    End Enum
    Sub Main()

        Dim Anc, jour_congé, Age As Integer
        Dim Stat As Statut

        Console.WriteLine("Entrez l'anciennete du salarie (en mois)")
        Anc = Console.ReadLine

        Console.WriteLine("Entrez le statut de l'employer (1 pour cadre, 2 pour non-cadre)")
        Stat = Console.ReadLine

        If Anc < 12 Then
            jour_congé = 2 * Anc
        ElseIf Anc >= 12 Then
            jour_congé = 30
        End If

        If Stat = 1 Then
            Console.WriteLine("Entrez l'age de l'employer (en années)")
            Age = Console.ReadLine
            If Age >= 40 And Anc > 60 Then
                jour_congé = jour_congé + 4
            ElseIf Age >= 35 And Anc >= 36 Then
                jour_congé = jour_congé + 2
            End If
            Console.Write("L'age du salarier est de  : " & Age)
            Console.WriteLine(" ans")
        End If

        Console.Write("L'anciennete du salarie (en mois) est de : " & Anc)
        Console.WriteLine(" mois")
        Console.Write("Le nombre de jour de congé accorder au salarier est de : " & jour_congé)
        Console.WriteLine(" jours")

        Console.Read()
    End Sub

End Module
