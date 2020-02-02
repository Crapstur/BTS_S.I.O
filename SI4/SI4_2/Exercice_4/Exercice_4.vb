Module Exercice_4
    Function COUTEL(Durée As Integer) As Single
        Dim h, m, s As Integer
        Dim CoutTel As Single

        h = Int(Durée / 3600)
        Durée = Durée - (h * 3600)

        m = Int(Durée / 60)
        Durée = Durée - (m * 60)

        s = Durée

        If s <> 0 Then
            m += 1
        End If

        CoutTel = (h * 7) + (m * 0.25)

        Return CoutTel
    End Function

    Structure Cout
        Dim Numero As Integer
        Dim Nom As String
        Dim Durée As Integer
        Dim Couts As Single
    End Structure
    Sub main()

        Dim i, NbrEmpl As Integer

        Console.WriteLine("Combien d'employés avez vous ?")
        NbrEmpl = Console.ReadLine

        Dim Tab(NbrEmpl) As Cout

        While i < NbrEmpl
            Console.Clear()
            Console.WriteLine("Entrez le numéro de l'employé.")
            Tab(i).Numero = Console.ReadLine

            Console.WriteLine("Entrez le nom de l'employé.")
            Tab(i).Nom = Console.ReadLine

            Console.WriteLine("Entrez la durée des communications de l'employé.")
            Tab(i).Durée = Console.ReadLine

            Tab(i).Couts = COUTEL(Tab(i).Durée)

            i += 1
        End While


        i = 0
        Console.WriteLine("{0} {1} {2} {3}", "Numéro", "Nom", "Durée", "Cout")

        While i < NbrEmpl
            Console.WriteLine("{0} {1} {2} {3}", Tab(i).Numero, Tab(i).Nom, Tab(i).Durée, Tab(i).Couts)

            i += 1
        End While
        Console.Read()
    End Sub
End Module