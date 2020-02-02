Module Exercice_11
    Sub Main()

        Dim NbrKm As Integer
        Dim NbrApo As Integer
        Dim NbrBurton As Integer
        Dim i As Integer
        Dim Anc As Integer
        Dim CAApo, CABurton As Integer
        Dim PrimeApo, PrimeBurton, PrimeKm, PrimeAnc As Integer
        Dim RemRepr_1, RemRepr_2, RemRepr_3, RemTot As Integer

        Const Fixe = 1100
        Const PxBurton = 350
        Const PxApo = 180


        i = 1

        While i < 4
            Console.WriteLine("Représentant " & i & ":")

            Console.WriteLine("")
            Console.WriteLine("Entrez l'ancièneté du représentant.")
            Anc = Console.ReadLine

            Console.WriteLine("")
            Console.WriteLine("Entrez le nombre de KM parcouru par le représentant.")
            NbrKm = Console.ReadLine

            Console.WriteLine("")
            Console.WriteLine("Entrez le nombre de snow APO vendus par le représentant.")
            NbrApo = Console.ReadLine

            Console.WriteLine("")
            Console.WriteLine("Entrez le nombre de snow BURTON vendus par le représentant.")
            NbrBurton = Console.ReadLine

            CAApo = PxApo * NbrApo
            CABurton = PxBurton * NbrBurton

            'Calcule de la prime sur les snows APO
            If NbrApo > 50 Then
                PrimeApo = (6 / 100) * (CAApo - 180 * 49)
            Else PrimeApo = 0
            End If

            'Calcule de la prime sur les snows BURTON
            'If NbrBurton <= 20 Then
            'PrimeBurton = (4 / 100) * CABurton                                                                      'Avant correction'
            'ElseIf NbrBurton <= 50 Then
            'PrimeBurton = (6 / 100) * CABurton
            'Else PrimeBurton = (10 / 100) * CABurton
            'End If

            'Calcule de la prime sur les snows BURTON
            If NbrBurton <= 20 Then
                PrimeBurton = CABurton * 0.04
            ElseIf NbrBurton <= 50 Then
                PrimeBurton = 20 * PxBurton * 0.04 + (NbrBurton - 20) * PxBurton * 0.06
            Else PrimeBurton = 20 * PxBurton * 0.04 + 30 * PxBurton * 0.06 + (NbrBurton - 50) * PxBurton * 0.1        'Après correction
            End If

            'Calcule de la prime de frais de transport
            PrimeKm = 0.15 * NbrKm
            If PrimeKm > 350 Then
                PrimeKm = 350
            End If

            'Calcule de la prime sur l'ancièneté
            If Anc < 5 Then
                PrimeAnc = 0
            ElseIf Anc <= 10 Then
                PrimeAnc = (5 / 100) * Fixe
            Else PrimeAnc = (10 / 100) * Fixe
            End If

            Select Case i
                Case = 1
                    RemRepr_1 = Fixe + PrimeApo + PrimeAnc + PrimeBurton + PrimeKm
                    RemTot = RemTot + RemRepr_1
                Case = 2
                    RemRepr_2 = Fixe + PrimeApo + PrimeAnc + PrimeBurton + PrimeKm
                    RemTot = RemTot + RemRepr_2
                Case = 3
                    RemRepr_3 = Fixe + PrimeApo + PrimeAnc + PrimeBurton + PrimeKm
                    RemTot = RemTot + RemRepr_3
            End Select

            i += 1

            Console.WriteLine("")
            Console.WriteLine("")

        End While

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Représentant 1 :")
        Console.WriteLine("Rémunération : " & RemRepr_1)
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Représentant 2 :")
        Console.WriteLine("Rémunération : " & RemRepr_2)
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Représentant 3 :")
        Console.WriteLine("Rémunération : " & RemRepr_3)

        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("La rémunération totale est de : " & RemTot)


        Console.Read()
    End Sub
End Module