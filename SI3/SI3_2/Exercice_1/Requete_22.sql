SELECT client.NUMECLIE
FROM client, produit, facturer, facture
WHERE client.NUMECLIE = facture.NUMECLIE
AND facture.NUMEFACT = facturer.NUMEFACT
AND facturer.REFEPROD = produit.REFEPROD
AND PUHTPROD > 1500;