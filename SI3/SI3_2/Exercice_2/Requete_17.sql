SELECT NumeroInterimaire, Nom, Prenom
FROM agence, interimaire
WHERE agence.CodeAgence = interimaire.CodeAgence
AND ((agence.telephone LIKE '0245%') OR (agence.telephone LIKE '0244%'));