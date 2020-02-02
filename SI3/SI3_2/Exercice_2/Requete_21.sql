SELECT Ville, COUNT(*) As Nombre_Interimaire
FROM interimaire
GROUP BY Ville
HAVING Nombre_Interimaire >= 2 ;