SELECT NOMECLIE, SUM(PUHTURER * QTEFURER) AS Chiffre_Affaire
FROM facture, facturer, client
WHERE facturer.NUMEFACT = facture.NUMEFACT
AND client.NUMECLIE = facture.NUMECLIE
GROUP BY NOMECLIE
HAVING Chiffre_Affaire > 5000;