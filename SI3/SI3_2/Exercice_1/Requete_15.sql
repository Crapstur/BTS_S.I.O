SELECT client.*, VILLREPR, NOMEREPR
FROM client, representant
WHERE client.NUMEREPR = representant.NUMEREPR;