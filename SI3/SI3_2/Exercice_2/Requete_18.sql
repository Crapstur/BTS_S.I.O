SELECT Ville, COUNT(*) As Nombre_Intérimaire
FROM interimaire
WHERE Ville = 'Brest'
GROUP BY Ville ;