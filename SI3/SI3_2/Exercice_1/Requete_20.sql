SELECT NOMEREPR, PRENREPR
FROM representant, client, facture
WHERE representant.NUMEREPR = client.NUMEREPR
AND facture.NUMECLIE = client.NUMECLIE
AND DATEFACT = '2009-01-01';