SELECT nom,prenom, COUNT(numAdherent) As NbPret
FROM pret, adherent
WHERE pret.numAdherent = adherent.num
GROUP BY numAdherent
HAVING NbPret >= '25'
ORDER BY Nom, prenom