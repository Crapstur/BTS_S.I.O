Module Exercice_3
    Function Frais(ByVal NbKm As Integer, ByVal NbCv As Integer) As Double
        Dim Montant1, Montant2, Montant3 As Double
        'Création des tableaux avec Indice de départ à 0

        Dim Tarif1() = {1.94, 2.33, 2.59, 2.75, 2.86, 3.1, 3.17, 3.34, 3.41, 3.66, 3.73}
        Dim Tarif2() = {1.75, 2.1, 2.33, 2.47, 2.57, 2.79, 2.85, 3, 3.07, 3.29, 3.36}
        Dim Tarif3() = {1.36, 1.63, 1.81, 1.92, 2, 2.17, 2.22, 2.34, 2.39, 2.56, 2.61}
        If NbCv > 13 Then
            NbCv = 13
        End If
        If NbKm < 5000 Then
            Montant1 = NbKm * Tarif1(NbCv - 3)
            Montant2 = 0
            Montant3 = 0
        ElseIf NbKm < 10000 Then
            Montant1 = 4999 * Tarif1(NbCv - 3)
            Montant2 = (NbKm - 4999) * Tarif2(NbCv - 3)
            Montant3 = 0
        Else
            Montant1 = 4999 * Tarif1(NbCv - 3)
            Montant2 = 5001 * Tarif2(NbCv - 3)
            Montant3 = (NbKm - 10000) * Tarif3(NbCv - 3)
        End If
        Return Montant1 + Montant2 + Montant3
    End Function
    Sub Main() ' version avec affichage au final avec un tableau 
        'Déclaration
        Dim Total As Double = 0
        Dim NbRep, NbKm, NbCv As Integer


        ' Entrer le nombre de représentant.
        Console.Write("Entrer le nombre de représentants : ")
        NbRep = Console.ReadLine
        Dim numrep(NbRep) As Integer
        Dim Nomrep(NbRep) As String
        Dim fraisKM(NbRep) As Single

        'Itération principale
        For i = 0 To NbRep - 1
            'Entrées
            Console.Write("Entrer le numéro du représentant " & i + 1 & ":")
            numrep(i) = Console.ReadLine
            Console.Write("Entrer le nom du représentant  " & i + 1 & ":")
            Nomrep(i) = Console.ReadLine
            Console.Write("Entrer le nombre de kilomètres : ")
            NbKm = Console.ReadLine
            Console.Write("Entrer la puissance du véhicule : ")
            NbCv = Console.ReadLine
            fraisKM(i) = Frais(NbKm, NbCv)

            Total = Total + fraisKM(i)
        Next

        For i = 0 To NbRep - 1

            Console.WriteLine("{0},{1},{2}", numrep(i), Nomrep(i), fraisKM(i))
            Console.WriteLine()
        Next i
        'Affichage du Cumul
        Console.WriteLine("Le total des remboursements est de :" & Total)
        Console.ReadLine()
    End Sub

End Module