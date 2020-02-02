SELECT titre
FROM livre, auteur
WHERE livre.numAuteur = auteur.num
AND nom = "Zola"
ORDER BY annee