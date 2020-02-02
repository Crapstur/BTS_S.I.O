Module Exercice_8
    Sub Main()

        Dim Age As Integer
        Dim NbrTotJAbs30_Moins, NbrTotJAbs30_40, NbrTotJAbs40_50, NbrTotJAbs50_Plus As Double
        Dim NbrJourAbs, JourAbs30_Moins, JourAbs30_40, JourAbs40_50, JourAbs50_Plus As Integer
        Dim Employe30_Moins, Employe30_40, Employe40_50, Employe50_Plus As Integer
        Dim Autre_Employe As String

        Do
            Console.WriteLine("Entrez l'age de l'employer.")
            Age = Console.ReadLine

            Console.WriteLine("Entrez le nombre de jour d'absence de l'employer.")
            NbrJourAbs = Console.ReadLine

            Select Case Age
                Case Is < 30
                    JourAbs30_Moins = JourAbs30_Moins + NbrJourAbs
                    If NbrJourAbs <> 0 Then
                        Employe30_Moins = Employe30_Moins + 1
                    End If
                Case 30 To 39
                    JourAbs30_40 = JourAbs30_40 + NbrJourAbs
                    If NbrJourAbs <> 0 Then
                        Employe30_40 = Employe30_40 + 1
                    End If
                Case 40 To 49
                    JourAbs40_50 = JourAbs40_50 + NbrJourAbs
                    If NbrJourAbs <> 0 Then
                        Employe40_50 = Employe40_50 + 1
                    End If
                Case Is >= 50
                    JourAbs50_Plus = JourAbs50_Plus + NbrJourAbs
                    If NbrJourAbs <> 0 Then
                        Employe50_Plus = Employe50_Plus + 1
                    End If
            End Select



            Console.WriteLine("Avez-vous d'autre employer a inscrire ? (O pour OUI / N pour NON)")
            Autre_Employe = Console.ReadLine
        Loop While Autre_Employe = "O"

        NbrTotJAbs30_Moins = JourAbs30_Moins / Employe30_Moins
        NbrTotJAbs30_40 = JourAbs30_40 / Employe30_40
        NbrTotJAbs40_50 = JourAbs40_50 / Employe40_50
        NbrTotJAbs50_Plus = JourAbs50_Plus / Employe50_Plus

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Salaries entre 30 et MOINS ans")
        Console.WriteLine("Nombre employe absent : " & Employe30_Moins)
        Console.WriteLine("Nombre jour absence : " & JourAbs30_Moins)
        Console.WriteLine("Nombre jour absence moyen : " & NbrTotJAbs30_Moins)

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Salaries entre 30 et 40 ans")
        Console.WriteLine("Nombre employe absent : " & Employe30_40)
        Console.WriteLine("Nombre jour absence : " & JourAbs30_40)
        Console.WriteLine("Nombre jour absence moyen : " & NbrTotJAbs30_40)

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Salaries entre 40 et 50 ans")
        Console.WriteLine("Nombre employe absent : " & Employe40_50)
        Console.WriteLine("Nombre jour absence : " & JourAbs40_50)
        Console.WriteLine("Nombre jour absence moyen : " & NbrTotJAbs40_50)

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Salaries entre 50 et plus")
        Console.WriteLine("Nombre employe absent : " & Employe50_Plus)
        Console.WriteLine("Nombre jour absence : " & JourAbs50_Plus)
        Console.WriteLine("Nombre jour absence moyen : " & NbrTotJAbs50_Plus)

        Console.Read()
    End Sub
End Module