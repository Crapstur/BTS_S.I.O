SELECT produit.REFEPROD, DESIPROD
FROM facture, facturer, produit
WHERE facture.NUMEFACT = facturer.NUMEFACT
AND facturer.REFEPROD = produit.REFEPROD
AND NUMECLIE = 100011;