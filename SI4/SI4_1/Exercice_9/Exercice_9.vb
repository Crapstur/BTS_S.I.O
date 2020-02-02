Module Exercice_9
    Sub Main()

        Dim Nom, Prenom As String
        Dim NomUser, Password As String
        Dim DateNaissance As String
        Dim Sexe, DepNaissance As String

        Console.WriteLine("Entrez le nom de l'élève.")
        Nom = Console.ReadLine
        Console.WriteLine("Entrez le prénom de l'élève.")
        Prenom = Console.ReadLine
        Console.WriteLine("Entrez la date de naissance de l'élève. (jj/mm/aaaa)")
        DateNaissance = Console.ReadLine
        Console.WriteLine("Entrez le département de naissance de l'élève. (Ex : 06)")
        DepNaissance = Console.ReadLine
        Console.WriteLine("Entrez le sexe de l'élève. (2 Femme / 1 Homme)")
        Sexe = Console.ReadLine

        NomUser = LCase(Left(Prenom, 1) + Nom)
        Password = Right(DateNaissance, 4) + Mid(DateNaissance, 4, 2) + Left(DateNaissance, 2) + Sexe + DepNaissance

        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.Write("" & Prenom)
        Console.Write(" ")
        Console.WriteLine("" & Nom)
        Console.WriteLine("Nom utilisateur : " & NomUser)
        Console.WriteLine("Mot de passe : " & Password)
        Console.Read()
    End Sub
End Module