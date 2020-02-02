SELECT SECTEURDEMANDE.id, SECTEURDEMANDE.nom, COUNT(DEMANDEUR.id) As NbrDemande
FROM SECTEURDEMANDE, DEMANDELOGEMENT
WHERE SECTEURDEMANDE.id = DEMANDELOGEMENT.id
GROUP BY SECTEURDEMANDE.id, SECTEURDEMANDE.nom
HAVING NbrDemande > 150 ;