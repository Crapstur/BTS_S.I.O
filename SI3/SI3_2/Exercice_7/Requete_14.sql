SELECT SUM(Montant_Facture) As Chiffre_Affaire
FROM (SELECT FAC_ID, SUM(LIF_QTE * LIF_MONTANT) AS Montant_Facture
    FROM t_ligne_facture
    GROUP BY FAC_ID)
    Total_Facture
