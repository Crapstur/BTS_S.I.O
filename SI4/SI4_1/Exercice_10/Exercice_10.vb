Module Exercice_10
    Enum Activité
        Sportive = 0
        Culturelle = 1
        Manuelle = 2
    End Enum
    Sub Main()

        Dim Act As Activité
        Dim Cadre As String
        Dim NbrParticipant, Depense As Integer
        Dim NbrSportif, NbrCulturelle, NbrManuelle As Integer
        Dim DépensesTotale As Integer
        Dim DépensesTotMoy As Integer
        Dim PropSport, PropCult, PropMan As Integer


        DépensesTotale = 0
        DépensesTotMoy = 0
        NbrParticipant = 0
        Depense = 0
        NbrSportif = 0
        NbrCulturelle = 0
        NbrManuelle = 0
        PropSport = 0
        PropCult = 0
        PropMan = 0



        Do
            NbrParticipant = NbrParticipant + 1
            Console.WriteLine("     QUESTIONNAIRE")
            Console.WriteLine("")
            Console.WriteLine("1er question :")
            Console.WriteLine("")
            Console.WriteLine("Qu'elle activitée principale faite vous durant votre temps libre ?")
            Console.WriteLine("  0 -> Sportive")
            Console.WriteLine("  1 -> Culturelle")
            Console.WriteLine("  2 -> Manuelle")
            Act = Console.ReadLine

            Console.WriteLine("")
            Console.WriteLine("2eme question :")
            Console.WriteLine("")
            Console.WriteLine("Combien dépensez-vous pour cette activité ?")
            Depense = Console.ReadLine

            If Act = Activité.Sportive Then
                NbrSportif = NbrSportif + 1
            ElseIf Act = Activité.Culturelle Then
                NbrCulturelle = NbrCulturelle + 1
            ElseIf Act = Activité.Manuelle Then
                NbrManuelle = NbrManuelle + 1
            End If

            DépensesTotale = DépensesTotale + Depense

            Console.WriteLine("Y'a t'il un autre cadre ? (O -> OUI / N -> NON)")
            Cadre = Console.ReadLine
        Loop While Cadre = "O"

        DépensesTotMoy = DépensesTotale / NbrParticipant

        PropSport = (NbrSportif / NbrParticipant) * 100
        PropCult = (NbrCulturelle / NbrParticipant) * 100
        PropMan = (NbrManuelle / NbrParticipant) * 100


        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Nombre de participant au questionnaire : " & NbrParticipant)
        Console.WriteLine("")
        Console.WriteLine("Activitées sportives :")
        Console.WriteLine("Proportion des participants : " & PropSport & " %")

        Console.WriteLine("")
        Console.WriteLine("Activitées culturelles :")
        Console.WriteLine("Proportion des participants : " & PropCult & " %")

        Console.WriteLine("")
        Console.WriteLine("Activitées manuelles :")
        Console.WriteLine("Proportion des participants : " & PropMan & " %")

        Console.WriteLine("")
        Console.WriteLine("Les participants dépenses en moyenne : " & DépensesTotMoy & " euros dans les loisirs.")


        Console.Read()
    End Sub
End Module