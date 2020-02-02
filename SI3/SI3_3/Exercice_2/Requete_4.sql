SELECT numGenre, COUNT(*) As NbLivre
FROM livre
GROUP BY numGenre
ORDER BY NbLivre DESC