SELECT facture.NUMEFACT, SUM(PUHTURER * QTEFURER) AS Montant_Facture
FROM facture, facturer
WHERE facturer.NUMEFACT = facture.NUMEFACT
GROUP BY facture.NUMEFACT
HAVING Montant_Facture > 500;