SELECT AVG(TRF_CHB_PRIX) As Tarif_moyen_chambre
FROM (SELECT CHB_ID, TRF_CHB_PRIX
      FROM tj_trf_chb
      WHERE trf_date_debut
      BETWEEN "2014-01-01" AND "2014-12-31")
      Tarif_Chambre;