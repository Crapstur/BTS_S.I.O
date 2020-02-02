INSERT INTO livre(ISBN, titre, prix, editeur, annee, langue, numAuteur, numGenre)
Values("2-07-036919-6", "Le Dernier Condamne", 7.50, "Folio", "1829", "Francais", NULL, 1)


UPDATE livre SET numAuteur = (SELECT num
                              FROM auteur
                              WHERE nom = "Hugo"
                              AND prenom = "Victor")
WHERE livre.titre = "Le Dernier jour d'un condamne"