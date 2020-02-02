Module Exercice_6
    Sub Main()

        Dim Academie As String
        Dim Zone_Academie As String
        Dim Vac_Hiver As String
        Dim Vac_Printemps As String

        Const Toussain = "19 / 10 / 2019 - 4 / 11 / 2019"
        Const Noel = "21 / 12 / 2019 - 6 / 1 / 2020"

        'Vac_Hiver = ""
        'Zone_Academie = ""
        'Vac_Printemps = ""

        Console.WriteLine("Entrez le nom de votre academie")
        Academie = Console.ReadLine

        Select Case Academie
            Case "Besançon", "Bordeaux", "Clermont-Ferrand", "Dijon", "Grenoble", "Limoges", "Lyon", "Poitiers" : Zone_Academie = "A"
                Vac_Hiver = "22 / 02 / 2020 - 09 / 03 / 2020"
                Vac_Printemps = "18 / 04 / 2020 - 04 / 05 / 2020"
            Case "Aix - Marseille", "Amiens", "Caen", "Lille", "Nancy-Metz", "Nantes", "Nice", "Orléans-Tours", "Reims", "Rennes", "Rouen", "Strasbourg" : Zone_Academie = "B"
                Vac_Hiver = "15 / 02 / 2020 - 02 / 03 / 2020"
                Vac_Printemps = "11 / 04 / 2020 - 27 / 04 / 2020"
            Case "Créteil", "Montpelllier", "Paris", "Toulouse", "Versaille" : Zone_Academie = "C"
                Vac_Hiver = "8 / 2 / 2020 - 24 / 2 / 2020"
                Vac_Printemps = "04 / 04 / 2020 - 20 / 04 / 2020"
            Case Else
                Console.WriteLine("Academie inexistante.")

                Console.Read()
                Exit Sub
        End Select

        Console.WriteLine("Academie : " & Academie)
        Console.WriteLine("Zone Academie : " & Zone_Academie)
        Console.WriteLine("Les dates des vacances de Toussain sont : " & Toussain)
        Console.WriteLine("Les dates des vacances de Noel sont : " & Noel)
        Console.WriteLine("Les dates des vacances d'Hiver sont : " & Vac_Hiver)
        Console.WriteLine("Les dates des vacances de Printemps sont : " & Vac_Printemps)


        Console.Read()
    End Sub

End Module
