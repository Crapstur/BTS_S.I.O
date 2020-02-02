SELECT NumeroInterimaire, Nom, Prenom,  DateNaissance, agence.Ville, agence.telephone
FROM interimaire, agence
WHERE agence.CodeAgence = interimaire.CodeAgence ;