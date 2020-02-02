Module Exercice_14
    Structure CA_Repr
        Dim Nom As String
        Dim Trimestre_1 As Double
        Dim Trimestre_2 As Double
        Dim Trimestre_3 As Double
        Dim Trimestre_4 As Double
        Dim Cumul As Double
        Dim pourcent_CA As Integer
    End Structure
    Sub main()
        Dim Tab(5) As CA_Repr
        Dim i As Integer
        Dim Totaux As String
        Dim tab_total(6) As Double

        Const Nbr_représentant = 5
        Totaux = "Totaux"

        'Saisi des différents trimestres'
        While i < Nbr_représentant
            Console.Clear()

            Console.WriteLine("Entrez le nom du représentant")
            Tab(i).Nom = Console.ReadLine

            Console.WriteLine("Entrez le chiffre d'affaire du 1er trimestre")
            Tab(i).Trimestre_1 = Console.ReadLine
            tab_total(0) += Tab(i).Trimestre_1

            Console.WriteLine("Entrez le chiffre d'affaire du 2eme trimestre")
            Tab(i).Trimestre_2 = Console.ReadLine
            tab_total(1) += Tab(i).Trimestre_2

            Console.WriteLine("Entrez le chiffre d'affaire du 3eme trimestre")
            Tab(i).Trimestre_3 = Console.ReadLine
            tab_total(2) += Tab(i).Trimestre_3

            Console.WriteLine("Entrez le chiffre d'affaire du 4eme trimestre")
            Tab(i).Trimestre_4 = Console.ReadLine
            tab_total(3) += Tab(i).Trimestre_4

            Tab(i).Cumul = Tab(i).Trimestre_1 + Tab(i).Trimestre_2 + Tab(i).Trimestre_3 + Tab(i).Trimestre_4
            tab_total(4) += Tab(i).Cumul

            i += 1
        End While

        'Calcule % du CA'
        i = 0
        While i < Nbr_représentant
            Tab(i).pourcent_CA = (Tab(i).Cumul / tab_total(4)) * 100
            tab_total(5) += Tab(i).pourcent_CA
            i += 1
        End While


        Console.Clear()

        'Affichage'
        i = 0
        Console.WriteLine("")
        Console.WriteLine("Nom Repr" & Space(2) & "|" & Space(2) & "Trimestre 1" & Space(2) & "|" & Space(2) & "Trimestre 2" & Space(2) & "|" & Space(2) &
                          "Trimestre 3" & Space(2) & "|" & Space(2) & "Trimestre 4" & Space(2) & "|" & Space(3) & "Cumul" & Space(5) & "|" & Space(5) & "% du CA")

        While i < Nbr_représentant
            Console.WriteLine(Tab(i).Nom & Space(5) & "|" & Space(5) & Tab(i).Trimestre_1 & Space(5) & "|" & Space(5) & Tab(i).Trimestre_2 & Space(5) & "|" &
                              Space(5) & Tab(i).Trimestre_3 & Space(5) & "|" & Space(5) & Tab(i).Trimestre_4 & Space(5) & "|" & Space(5) & Tab(i).Cumul & Space(5) &
                              "|" & Space(5) & Tab(i).pourcent_CA & "%")

            i += 1
        End While

        Console.Write(Totaux)
        Console.Write(Space(5) & "|" & Space(5) & tab_total(0) & Space(5) & "|" & Space(5) & tab_total(1) & Space(5) & "|" & Space(5) & tab_total(2) & Space(5) &
                      "|" & Space(5) & tab_total(3) & Space(5) & "|" & Space(5) & tab_total(4) & Space(5) & "|" & Space(5) & tab_total(5) & "%")

        Console.Read()
    End Sub
End Module
