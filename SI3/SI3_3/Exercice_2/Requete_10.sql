INSERT INTO pret(numlivre,numAdherent,datePret,dateRetourPrevue,dateRetourReelle)
VALUES('5','19', CURDATE(), ADDDATE(CURDATE(), INTERVAL 14 DAY))