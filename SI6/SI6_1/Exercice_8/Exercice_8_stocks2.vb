Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Exercice_8_stocks2
    Dim Connexion As MySqlConnection


    ' Fonction Clear '
    Public Sub Clear()
        Me.DataGridViewProd.Rows.Clear()
    End Sub

    ' Lancement de l exercice '
    Private Sub Exercice_1_8_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerActualiser.Enabled = True
        Connexion = New MySqlConnection("server=localhost; userid=root; database=gestioncommerciale")
        Try
            Connexion.Open()
            Dim CommandeAffProd As MySqlCommand = New MySqlCommand("Select * From produit", Connexion)
            Dim ResultatAffProd As MySqlDataReader = CommandeAffProd.ExecuteReader
            Dim I As Integer
            While ResultatAffProd.Read()
                DataGridViewProd.Rows.Add(Convert.ToString(ResultatAffProd("REFEPROD")),
                                          Convert.ToString(ResultatAffProd("DESIPROD")),
                                          Convert.ToString(ResultatAffProd("PUHTPROD")),
                                          Convert.ToString(ResultatAffProd("TTVAPROD")),
                                          Convert.ToString(ResultatAffProd("QTESPROD")))

                DataGridViewProd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                DataGridViewProd.Rows(I).HeaderCell.Value = CStr(I + 1)
                DataGridViewProd.Rows(I).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                I += 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DataGridViewProd.Show()
            Connexion.Close()
        End Try
    End Sub

    ' Boutton Fermer '
    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
        Me.Close()
    End Sub

    Private Sub TimerActualiser_Tick(sender As Object, e As EventArgs) Handles TimerActualiser.Tick
        Clear()
        Try
            Connexion.Open()
            Dim CommandeAffProd As MySqlCommand = New MySqlCommand("Select * From produit", Connexion)
            Dim ResultatAffProd As MySqlDataReader = CommandeAffProd.ExecuteReader
            Dim I As Integer
            While ResultatAffProd.Read()
                DataGridViewProd.Rows.Add(Convert.ToString(ResultatAffProd("REFEPROD")),
                                          Convert.ToString(ResultatAffProd("DESIPROD")),
                                          Convert.ToString(ResultatAffProd("PUHTPROD")),
                                          Convert.ToString(ResultatAffProd("TTVAPROD")),
                                          Convert.ToString(ResultatAffProd("QTESPROD")))

                DataGridViewProd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                DataGridViewProd.Rows(I).HeaderCell.Value = CStr(I + 1)
                DataGridViewProd.Rows(I).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                I += 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DataGridViewProd.Show()
            Connexion.Close()
        End Try

    End Sub
End Class