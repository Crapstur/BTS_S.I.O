SELECT NOMECLIE, VILLCLIE, facture.NUMEFACT, DATEFACT
FROM client, facture, produit, facturer
WHERE client.NUMECLIE = facture.NUMECLIE
AND facture.NUMEFACT = facturer.NUMEFACT
AND facturer.REFEPROD = produit.REFEPROD
AND produit.REFEPROD = 10001;