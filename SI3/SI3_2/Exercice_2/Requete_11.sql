SELECT NumeroInterimaire, Nom, Prenom, DateNaissance, Ville
FROM interimaire
WHERE Ville IN ('Brest', 'Vannes')
And DateNaissance BETWEEN '1975/01/01' AND '1980/12/31' ;