SELECT NumeroInterimaire, Nom, Prenom, DateNaissance
FROM interimaire
WHERE DateNaissance BETWEEN '1970/01/01' AND '1979/12/31'
ORDER BY DateNaissance DESC ;