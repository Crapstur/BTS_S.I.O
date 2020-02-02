
                                /*  CREATION DES TABLES */

Create Table REPRESENTANT (R_nro Smallint,
                           R_nom Varchar(30),
                           R_adresse Varchar(100),
                           R_telephone Char(10),
                           R_datembauch Date,
                           R_cv Text,
Primary Key (R_nro));

Create Table ZONE (Zone_Code Smallint,
                   R_nro Smallint,
Primary Key (Zone_Code),
Foreign Key (R_nro) References REPRESENTANT(R_nro));

Create Table DEPARTEMENT(Dep_nro Char(2) Not Null, 
                         Dep_nom Varchar(30), 
                         Zone_code Smallint,
Primary Key (Dep_nro),
Foreign Key (Zone_code) References ZONE(Zone_Code));

Create Table CLIENT (C_nro Smallint,
                     C_rs Varchar(30),
                     C_adresse Varchar(100),
                     C_reponsable Varchar(30),
                     C_telephone Char(10),
                     Zone_code Smallint,
Primary Key (C_nro),
Foreign Key (Zone_code) References Zone(Zone_Code));


                            /*  INSERTION DE DONNEES DANS LES TABLES */

INSERT INTO client('C_rs', 'C_adresse', 'C_reponsable', 'C_telephone', 'Zone_code') VALUES ("PoliceMunicipale","12 avenue de la WWIII","Hugo","0102030405",3)
INSERT INTO departement('Dep_nro', 'Dep_nom', 'Zone_code') VALUES (06,"Alpes-Maritimes",3)
INSERT INTO representant('R_nom', 'R_adresse', 'R_telephone', 'R_datembauch', 'R_cv') VALUES ("Hugo","58 Impasse de la libertée","0102030405",'2012-06-15',"https://romain-capouillez.fr/curiculum-vitae/")
INSERT INTO zone('Zone_Code', 'R_nro') VALUES (3,1)
