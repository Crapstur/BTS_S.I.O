SELECT NOMEREPR, Count(*) AS NbrClient
FROM client, representant
WHERE client.NUMEREPR = representant.NUMEREPR
GROUP BY NOMEREPR