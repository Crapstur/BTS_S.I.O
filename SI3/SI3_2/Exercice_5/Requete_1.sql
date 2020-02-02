SELECT ENTRAINEMENT.DateEntrainement, ENTRAINEMENT.HeureDebut, ENTRAINEMENT.HeureFin, PISCINE.NomPiscine, PLAN_ENTRAINEMENT.DistanceAParcourir, PLAN_ENTRAINEMENT.DistanceParcourue
FROM ENTRAINEMENT, PISCINE, PLAN_ENTRAINEMENT
WHERE PISCINE.NumPiscine = ENTRAINEMENT.NumPiscine
AND ENTRAINEMENT.NumEntrainement = PLAN_ENTRAINEMENT.NumEntrainement
AND NumLicense = '2413'
AND DateEntrainement > '2013-09-01'
ORDER BY ENTRAINEMENT.DateEntrainement DESC ;