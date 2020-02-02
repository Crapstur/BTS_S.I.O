Module Exercice_14_bis
    Function Arrondi(ByVal Pourcent As Double) As Single
        Dim Virgule As Single
        Dim Pourcent_A As Single

        Virgule = Pourcent - Int(Pourcent)
        Virgule = Format(Virgule, "0.0")

        If Virgule = 0 Or Virgule = 0.5 Then
            Pourcent_A = Pourcent
        ElseIf Virgule < 0.5 Then
            Pourcent_A = Pourcent - Virgule
        ElseIf Virgule > 0.5 Then
            Pourcent_A = Int(Pourcent) + 1
        End If

        Return (Pourcent_A)
    End Function

    Sub main()
        Dim Tab(5, 5) As Double
        Dim Tab_Nom(5) As String
        Dim Tab_Tot(5) As Double
        Dim Tab_PCA(6) As Double
        Dim Nombre_Repr, i, j As Integer

        Console.WriteLine("Combien de representant avez vous ?")
        Nombre_Repr = Console.ReadLine

        i = 0
        While i < Nombre_Repr
            Console.Clear()

            Console.WriteLine("Entrez le nom de représentant.")
            Tab_Nom(i) = Console.ReadLine
            j = 1
            While j < 5
                Console.WriteLine("Entrez le CA du trimestre " & j)
                Tab(i, j) = Console.ReadLine

                'Cumul
                Tab(i, 5) += Tab(i, j)

                Tab_Tot(j - 1) += Tab(i, j)

                j += 1
            End While
            Tab_Tot(4) += Tab(i, 5)

            i += 1
        End While

        i = 0
        While i < Nombre_Repr
            Tab_PCA(i) = (Tab(i, 5) / Tab_Tot(4)) * 100
            Tab_PCA(i) = Arrondi(Tab_PCA(i))
            Tab_PCA(5) += Tab_PCA(i)

            i += 1
        End While



        Console.Clear()


        'Affichage

        'Console.WriteLine("Nom Repr" & Space(2) & "|" & Space(2) & "Trimestre 1" & Space(2) & "|" & Space(2) & "Trimestre 2" &
        '                  Space(2) & "|" & Space(2) & "Trimestre 3" & Space(2) & "|" & Space(2) & "Trimestre 4" & Space(2) & "|" &
        '                  Space(2) & "   Cumul   " & Space(2) & "|" & Space(2) & "   % du CA   ")

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", "Nom Repr", "Trimestre 1", "Trimestre 2", "Trimestre 3", "Trimestre 4", "Cumul", "% du CA")

        i = 0
        While i < Nombre_Repr
            Console.Write(Tab_Nom(i))
            Console.Write(Space(4) & "|" & Space(3))
            j = 1
            While j <= 5
                Console.Write(Format(Tab(i, j), "0.00"))
                Console.Write(Space(5) & "|" & Space(5))
                j += 1
            End While
            Console.Write(Tab_PCA(i) & " %")
            Console.WriteLine("")
            i += 1
        End While

        'Console.WriteLine("Totaux :  " & "|" & Space(3) & Format(Tab_Tot(0), "0.00") & Space(4) & "|" & Space(3) & Format(Tab_Tot(1), "0.00") &
        '                  Space(3) & "|" & Space(3) & Format(Tab_Tot(2), "0.00") & Space(3) & "|" & Space(3) & Format(Tab_Tot(3), "0.00") &
        '                  Space(3) & "|" & Space(3) & Format(Tab_Tot(4), "0.00") & Space(3) & "|" & Space(7) & Arrondi(Tab_PCA(5)) & " %")

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", "Totaux :  ", Format(Tab_Tot(0), "0.00"), Format(Tab_Tot(1), "0.00"), Format(Tab_Tot(2), "0.00"), Format(Tab_Tot(3), "0.00"), Format(Tab_Tot(4), "0.00"), Arrondi(Tab_PCA(5)) & " %"))

        Console.Read()
    End Sub
End Module