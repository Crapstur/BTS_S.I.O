Module Exercice_11_2
    Sub main()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Dim nom As String
        Dim anc, qtapo, qtburton, nbkm, i As Integer
        Dim comapo, comburton, caburton, indkm, mtprime, remrepr, remtotal As Double
        Const ind1km = 0.15
        Const txprime1 = 0.05
        Const txprime2 = 0.1
        Const fixe = 1100
        Const pxapo = 180
        Const pxburton = 350
        Const txcom1 = 0.04
        Const txcom2 = 0.06
        Const txcom3 = 0.1

        For i = 1 To 3
            Console.Write("Saisir le nom: ")
            nom = Console.ReadLine
            Console.Write("Saisir l'ancienneté: ")
            anc = Console.ReadLine
            Console.Write("Saisir la quantité de APO Blend vendu: ")
            qtapo = Console.ReadLine
            Console.Write("Saisir la quantité de Burton vendu: ")
            qtburton = Console.ReadLine
            Console.Write("Saisir le nombre de km parcouru: ")
            nbkm = Console.ReadLine

            caburton = qtburton * pxburton
            indkm = ind1km * nbkm

            If indkm > 350 Then
                indkm = 350
            End If

            If anc < 5 Then
                mtprime = 0
            ElseIf anc <= 10 Then
                mtprime = fixe * txprime1
            Else mtprime = fixe * txprime2
            End If

            If qtapo >= 50 Then
                comapo = txcom2 * ((qtapo * pxapo) - 49 * pxapo)
            Else comapo = 0
            End If

            If qtburton <= 20 Then
                comburton = qtburton * pxburton * 0.04
            ElseIf qtburton <= 50 Then
                comburton = 20 * pxburton * 0.04 + (qtburton - 20) * pxburton * 0.06
            Else comburton = 20 * pxburton * 0.04 + 30 * pxburton * 0.06 + (qtburton - 50) * pxburton * 0.1
            End If

            remrepr = fixe + indkm + mtprime + comapo + comburton
            remtotal = remtotal + remrepr

            Console.WriteLine("Nom du représentant: " & nom)
            Console.WriteLine("Rémunération du représentant: " & remrepr)
        Next

        Console.WriteLine("Rémunération total: " & remtotal)
        Console.Read()
    End Sub

End Module
