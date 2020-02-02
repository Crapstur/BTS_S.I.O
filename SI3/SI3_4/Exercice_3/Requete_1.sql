
                                /*  CREATION DES TABLES */

CREATE TABLE DEPARTEMENT(code VARCHAR(30),
                         libelle VARCHAR (30),
PRIMARY KEY (code));

CREATE TABLE EXPOSITION (numero SMALLINT,
                         libelle VARCHAR(50),
                         dateDebut DATE,
                         dateFin DATE,
PRIMARY KEY (numero));

CREATE TABLE INSTITUTION (numero SMALLINT,
                          nom VARCHAR(30),
                          categorie VARCHAR(80),
PRIMARY KEY (numero));

CREATE TABLE OBJET (numeroInventaire INTEGER,
                    codeBarre VARCHAR(50),
                    libelle VARCHAR(50),
                    description1 text,
                    codeStatut SMALLINT,
                    dateAcquisition DATE,
                    hauteur VARCHAR(5),
                    largeur VARCHAR(5),
                    profondeur VARCHAR(5),
                    poids VARCHAR(5),
                    urlImage VARCHAR(500),
                    enPlateau SMALLINT,
                    codeDépartement VARCHAR(30),
PRIMARY KEY (numeroInventaire),
FOREIGN KEY (codeDépartement) REFERENCES DEPARTEMENT(code));

CREATE TABLE CONVENTIONPRET (numero INTEGER,
                            sens VARCHAR(10),
                            numeroInstitution SMALLINT,
                            numeroExposition SMALLINT,
PRIMARY KEY (numero),
FOREIGN KEY (numeroInstitution) REFERENCES INSTITUTION(numero),
FOREIGN KEY (numeroExposition) REFERENCES EXPOSITION(numero));

CREATE TABLE CONTENUPRET (numeroPret INTEGER,
                          numeroInventaire INTEGER,
                          datePret DATE,
                          dateRetourPret DATE,
PRIMARY KEY (numeroPret, numeroInventaire),
FOREIGN KEY (numeroPret) REFERENCES CONVENTIONPRET(numero),
FOREIGN KEY (numeroInventaire) REFERENCES OBJET(numeroInventaire));


                            /*  INSERTION DE DONNEES DANS LES TABLES */

INSERT INTO departement('code', 'libelle') VALUES (06, "Alpes-Maritimes")
INSERT INTO exposition('numero', 'libelle', 'dateDebut', 'dateFin') VALUES (1, "La belle etoile", '2019-06-19', '2019-07-19')
INSERT INTO institution('numero', 'nom', 'categorie') VALUES (12, "SNCF", "Contemporain")
INSERT INTO objet('numeroInventaire', 'codeBarre', 'libelle', 'description1', 'codeStatut', 'dateAcquisition', 'hauteur', 'largeur', 'profondeur', 'poids', 'urlImage', 'enPlateau', 'codeDépartement') VALUES (12, 29219, "La salière", "Sel la Baleine", 289, '2019-12-09', 29, 12, 91, 211, "http://romain-capouillez.fr", 1, 06)
INSERT INTO conventiopret('numero', 'sens', 'numeroInstitution', 'numeroExposition') VALUES (2, "fait", 2, 3)
INSERT INTO contenupret('numeroPret', 'numeroInventaire', 'datePret', 'dateRetourPret') VALUES (1, 1, '2018-12-19', '2020-12-20')
