Module Exercice_12
    Structure Produit
        Dim refeprod, desiprod As String
        Dim puht As Double
        Dim qteprod As Integer
    End Structure
    Sub main()
        Dim produit1, produit2, produit3 As Produit
        Dim qtetotal As Integer

        qtetotal = 0
        'produit 1
        Console.WriteLine("Entrez les données : (Référence du PREMIER produit,Désignation du PREMIER produit,Prix unitaire hors taxe du PREMIER,Et quantitée en stock du PREMIER produit")
        produit1.refeprod = Console.ReadLine
        produit1.desiprod = Console.ReadLine
        produit1.puht = Console.ReadLine
        produit1.qteprod = Console.ReadLine
        'produit 2
        Console.WriteLine("Entrez les données : (Référence du PREMIER produit,Désignation du SECOND produit,Prix unitaire hors taxe du SECOND,Et quantitée en stock du SECOND produit")
        produit2.refeprod = Console.ReadLine
        produit2.desiprod = Console.ReadLine
        produit2.puht = Console.ReadLine
        produit2.qteprod = Console.ReadLine
        'produit 3
        Console.WriteLine("Entrez les données : (Référence du PREMIER produit,Désignation du TROISIÈME produit,Prix unitaire hors taxe du TROISIÈME,Et quantitée en stock du TROISIÈME produit")
        produit3.refeprod = Console.ReadLine
        produit3.desiprod = Console.ReadLine
        produit3.puht = Console.ReadLine
        produit3.qteprod = Console.ReadLine

        Console.Clear()

        qtetotal = produit1.qteprod + produit2.qteprod + produit3.qteprod

        Console.WriteLine(produit1.refeprod & Space(5) & produit1.desiprod & Space(5) & produit1.puht & Space(5) & produit1.qteprod)
        Console.WriteLine(produit2.refeprod & Space(5) & produit2.desiprod & Space(5) & produit2.puht & Space(5) & produit2.qteprod)
        Console.WriteLine(produit3.refeprod & Space(5) & produit3.desiprod & Space(5) & produit3.puht & Space(5) & produit3.qteprod)
        Console.WriteLine("Quantitée totale : " & qtetotal)
        Console.ReadKey()
    End Sub
End Module