Module Exercice_11_bis
    Sub main()
        Console.ForegroundColor = ConsoleColor.Yellow
        Dim i As Integer
        Dim comapo(3), comburton(3), caburton(3), indkm(3), mtprime(3), remtotal As Double
        Dim nom() = {"A", "B", "C"}
        Dim anc(3) As Integer
        Dim qtapo(3) As Integer
        Dim qtburton(3) As Integer
        Dim nbkm(3) As Integer
        Dim remrepr(3) As Double

        remtotal = 0

        Const ind1km = 0.15
        Const txprime1 = 0.05
        Const txprime2 = 0.1
        Const fixe = 1100
        Const pxapo = 180
        Const pxburton = 350
        Const txcom1 = 0.04
        Const txcom2 = 0.06
        Const txcom3 = 0.1

        For i = 0 To 2
            Console.Write("Saisir l'ancienneté: ")
            anc(i) = Console.ReadLine
            Console.Write("Saisir la quantité de APO Blend vendu: ")
            qtapo(i) = Console.ReadLine
            Console.Write("Saisir la quantité de Burton vendu: ")
            qtburton(i) = Console.ReadLine
            Console.Write("Saisir le nombre de km parcouru: ")
            nbkm(i) = Console.ReadLine

            caburton(i) = qtburton(i) * pxburton
            indkm(i) = ind1km * nbkm(i)

            If indkm(i) > 350 Then
                indkm(i) = 350
            End If

            If anc(i) < 5 Then
                mtprime(i) = 0
            ElseIf anc(i) <= 10 Then
                mtprime(i) = fixe * txprime1
            Else mtprime(i) = fixe * txprime2
            End If

            If qtapo(i) >= 50 Then
                comapo(i) = txcom2 * ((qtapo(i) * pxapo) - 49 * pxapo)
            Else comapo(i) = 0
            End If

            If qtburton(i) <= 20 Then
                comburton(i) = qtburton(i) * pxburton * txcom1
            ElseIf qtburton(i) <= 50 Then
                comburton(i) = 20 * pxburton * txcom1 + (qtburton(i) - 20) * pxburton * txcom2
            Else comburton(i) = 20 * pxburton * txcom1 + 30 * pxburton * txcom2 + (qtburton(i) - 50) * pxburton * txcom3
            End If

            remrepr(i) = fixe + indkm(i) + mtprime(i) + comapo(i) + comburton(i)
            remtotal = remtotal + remrepr(i)

            Console.WriteLine("Nom du représentant: " & nom(i))
            Console.WriteLine("Rémunération du représentant: " & remrepr(i))
        Next

        Console.WriteLine("Rémunération total: " & remtotal)
        Console.Read()
    End Sub
End Module
