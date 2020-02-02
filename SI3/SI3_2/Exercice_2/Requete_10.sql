SELECT NumeroInterimaire, Nom, Prenom
FROM interimaire, agence
WHERE interimaire.CodeAgence = agence.CodeAgence
AND agence.CodeAgence = 'VN'
AND DateNaissance > '1975/01/01' ;