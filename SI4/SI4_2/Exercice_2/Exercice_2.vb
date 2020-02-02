Module Exercice_2
    Function Arrondi(ByVal Moyenne As Single) As Single
        Dim Virgule As Single
        Dim Moyenne_A As Single

        Virgule = Moyenne - Int(Moyenne)

        If Virgule = 0 Then
            Moyenne_A = Moyenne
        ElseIf Virgule <= 0.25 Then
            Moyenne_A = Int(Moyenne) + 0.25
        ElseIf Virgule <= 0.5 Then
            Moyenne_A = Int(Moyenne) + 0.5
        ElseIf Virgule <= 0.75 Then
            Moyenne_A = Int(Moyenne) + 0.75
        Else
            Moyenne_A = Int(Moyenne) + 1
        End If

        Return (Moyenne_A)
    End Function
    Sub main()
        Dim Nbr_eleve, Nbr_Notes, i, j As Integer

        Console.WriteLine("Entrez le nombre d'eleves")
        Nbr_eleve = Console.ReadLine

        Dim Moyenne(Nbr_eleve) As Single
        Dim Nom(Nbr_eleve) As String
        Dim Moyenne_classe As Single

        While i < Nbr_eleve
            Console.Clear()

            Console.WriteLine("Entrez le nom de l'eleve")
            Nom(i) = Console.ReadLine

            Console.WriteLine("Entrez le nombre de note de l'eleve.")
            Nbr_Notes = Console.ReadLine

            j = 0
            While j < Nbr_Notes
                Console.WriteLine("Entrez la note de l'eleve.")
                Moyenne(i) += Console.ReadLine

                j += 1
            End While
            Moyenne(i) = Moyenne(i) / Nbr_Notes
            Moyenne(i) = Arrondi(Moyenne(i))
            Moyenne_classe += Moyenne(i)

            i += 1
        End While

        i = 0
        Console.Clear()

        While i < Nbr_eleve
            Console.WriteLine(Nom(i) & Space(10) & Moyenne(i))

            i += 1
        End While

        Console.Write("Moyenne de la classe" & Space(5) & Arrondi(Moyenne_classe / Nbr_eleve))


        Console.Read()
    End Sub
End Module