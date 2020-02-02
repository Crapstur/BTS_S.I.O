SELECT NumeroInterimaire, Nom, DateNaissance, Ville
FROM interimaire
WHERE Ville NOT IN ('Brest')
AND DateNaissance < '1980/12/01' ;