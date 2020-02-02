SELECT AVG(Delai_Paiement) as Delai_Moyen
FROM (SELECT DATEDIFF(FAC_PMT_DATE, FAC_DATE) As Delai_Paiement
      FROM t_facture)
      Delai