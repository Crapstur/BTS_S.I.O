SELECT AVG(Delai_Paiement) as Delai_Moyen


SELECT FAC_ID, SUM(LIF_REMISE_MONTANT + ((LIF_REMISE_POURCENT / 100) * (LIF_MONTANT * LIF_QTE))) AS Somme_remise
FROM t_ligne_facture
GROUP BY FAC_ID


    'A FINIR PLUS TARD'