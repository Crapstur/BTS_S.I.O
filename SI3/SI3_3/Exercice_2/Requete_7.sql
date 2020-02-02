SELECT titre, annee
FROM livre
WHERE annee = (SELECT MIN(annee)
             FROM livre
             WHERE titre like "%Dalton%")