Module Exercice_13
    Structure Matériel
        Dim Dési As String
        Dim PuHT As Integer
        Dim Qte As Integer
    End Structure
    Sub main()
        Dim NomClient As String
        Dim NbrMate As Integer
        Dim mat(3) As Matériel
        Dim totalht As Integer
        Dim couthor = {92, 148, 180}
        Dim remise As Integer
        Dim mainoeuvre As Integer
        Dim codehor, nbrh As Integer
        Dim mtmainoeuvre As Integer
        Dim prixfinale As Integer

        Console.WriteLine("Entrez le nom du client :")
        NomClient = Console.ReadLine

        Console.WriteLine("Combien de matière ou matériel avez-vous utilisé ?")
        NbrMate = Console.ReadLine

        'Matières'
        For i = 0 To (NbrMate - 1)
            Console.WriteLine("Entrez le matériel utilisé.")
            mat(i).Dési = Console.ReadLine
            Console.WriteLine("Entrez le Prix unitaire Hors Taxes.")
            mat(i).PuHT = Console.ReadLine
            Console.WriteLine("Entrez la quantitée utilisé")
            mat(i).Qte = Console.ReadLine

            TotalHT = TotalHT + (mat(i).PuHT * mat(i).Qte)
        Next

        'Remise sur le Totale'
        If TotalHT < 1000 Then
            remise = TotalHT * 0.1
        ElseIf TotalHT >= 1000 And TotalHT < 5000 Then
            remise = TotalHT * 0.15
        Else
            remise = TotalHT * 0.2
        End If

        Console.WriteLine("Avez-vous pris de la main d'oeuvre ? (1 -> Oui | 2 -> Non)")
        MainOeuvre = Console.ReadLine

        'Main Oeuvre'
        If MainOeuvre = 1 Then
            Console.WriteLine("Entrez le code horaire dans lequel vous êtes.")
            CodeHor = Console.ReadLine

            Console.WriteLine("Entrez le nombre d'heure prise pour la main d'oeuvre.")
            NbrH = Console.ReadLine

            Select Case CodeHor
                Case 1 : MtMainOeuvre = NbrH * couthor(0)
                Case 2 : MtMainOeuvre = NbrH * couthor(1)
                Case 3 : MtMainOeuvre = NbrH * couthor(2)
            End Select
        Else
            MtMainOeuvre = 0
        End If

        prixfinale = TotalHT - remise + MtMainOeuvre

        Console.Clear()

        Console.WriteLine("Client : " & NomClient)
        For i = 0 To (NbrMate - 1)
            Console.WriteLine("Désignation du produit : " & mat(i).Dési)
            Console.WriteLine("Prix unitaire Hors Taxe : " & mat(i).PuHT & " euros")
            Console.WriteLine("Quantité utilisée : " & mat(i).Qte)

        Next

        If MainOeuvre = 1 Then
            Console.WriteLine("Main d'oeuvre :")
            Console.WriteLine("")
            Console.WriteLine("Vous avez pris " & NbrH & " heures")
            Console.WriteLine("Le code horaire est" & CodeHor)
            Console.WriteLine("Le montant de la main d'oeuvre est de " & MtMainOeuvre & " euros")
        End If

        Console.WriteLine("La remise est de " & remise & " euros")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Le prix finale est de " & prixfinale & " euros")


        Console.Read()
    End Sub
End Module