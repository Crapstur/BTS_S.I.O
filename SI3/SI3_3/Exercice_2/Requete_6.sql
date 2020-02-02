SELECT DISTINCT nom,prenom, COUNT(*)NbRetard
FROM pret, adherent
WHERE pret.numAdherent = adherent.num
AND dateRetourPrevue < dateRetourReelle
GROUP BY nom,prenom
HAVING NbRetard >='6'
ORDER BY NbRetard DESC