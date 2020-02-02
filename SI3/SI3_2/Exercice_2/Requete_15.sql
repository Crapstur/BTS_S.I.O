SELECT NumeroInterimaire, Nom,  DateNaissance, agence.CodeAgence
FROM interimaire, agence
WHERE agence.CodeAgence = interimaire.CodeAgence
AND DescriptifSecteur = 'Morbihan' ;