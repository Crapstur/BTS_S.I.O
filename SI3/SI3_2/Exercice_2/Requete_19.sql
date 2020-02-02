SELECT CodeAgence As Agence, COUNT(*) As Nombre_Interimaire
FROM interimaire
GROUP BY CodeAgence ;