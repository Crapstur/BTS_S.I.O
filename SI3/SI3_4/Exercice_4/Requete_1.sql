
                                /*  CREATION DES TABLES */

create table moniteur (numeromoniteur integer,
                       nommoniteur VARCHAR(40),
                       prenommoniteur VARCHAR(40),
                       ruemoniteur VARCHAR(100),
                       villemoniteur varchar(50),
                       codepostalmoniteur char(5),
                       telephonemoniteur char(10),
                       anneeembauchemoniteur YEAR,
PRIMARY key (numeromoniteur));

create table typepermis (codetypepermis integer,
                         designationtypepermis VARCHAR(15),
                         tarifhorairelecon float,
                         tarifforfaitlecon float,
PRIMARY key (codetypepermis));

create table typevehicule (codetypevehicule integer,
                           designationtype VARCHAR(15),
                           marquetype varchar(20),
PRIMARY key (codetypevehicule));

create table eleve (numeleve integer,
                    nomeleve VARCHAR(15),
                    adresseeleve varchar(100),
                    adresseville VARCHAR(30),
                    dateinscription DATE,
                    codetypepermis INTEGER,
PRIMARY key (numeleve),
foreign key (codetypepermis) REFERENCES typepermis(codetypepermis));

create table vehicule (numeroimmatriculation Char(9),
                       codetypevehicule INTEGER,
                       dateaquisition date,
PRIMARY key (numeroimmatriculation),
foreign key (codetypevehicule) references typevehicule(codetypevehicule));

create table leçon (numlecon integer,
                    heuredeblecon datetime,
                    heurefinlecon datetime,
                    ruemoniteur VARCHAR(100),
                    numeromoniteur integer,
                    numeroimmatriculation varchar(10),
                    numeleve varchar(10),
PRIMARY key (numlecon),
FOREIGN key (numeromoniteur) references moniteur(numeromoniteur),
FOREIGN key (numeroimmatriculation) references vehicule(numeroimmatriculation),
FOREIGN key (numeleve) REFERENCES eleve(numeleve));

                            /*  INSERTION DE DONNEES DANS LES TABLES */

INSERT INTO eleve('numeleve', 'nomeleve', 'adresseeleve', 'adresseville', 'dateinscription', 'codetypepermis') VALUES (1,"SISR","5 place de la rubeole","Chevre",'2020-01-12',4)
INSERT INTO typepermis('codetypepermis', 'designationtypepermis', 'tarifhorairelecon', 'tarifforfaitlecon') VALUES (4,"Bombardier",450,449)
INSERT INTO typepermis('codetypepermis', 'designationtypepermis', 'tarifhorairelecon', 'tarifforfaitlecon') VALUES (3,"AquaPoney",5000,32)
INSERT INTO typepermis('codetypepermis', 'designationtypepermis', 'tarifhorairelecon', 'tarifforfaitlecon') VALUES (2,"Avion de chasse",1000000,500000)
INSERT INTO typevehicule('codetypevehicule', 'designationtype', 'marquetype') VALUES (1,"Mirage2000N","Mirage")
INSERT INTO typevehicule('codetypevehicule', 'designationtype', 'marquetype') VALUES (2,"Clavier/Souris","Razer")
INSERT INTO typevehicule('codetypevehicule', 'designationtype', 'marquetype') VALUES (3,"Beluga","AirBus")
INSERT INTO vehicule('numeroimmatriculation', 'codetypevehicule', 'dateaquisition') VALUES ("AB-123-YZ",1,'2020-02-02')
INSERT INTO moniteur('numeromoniteur', 'nommoniteur', 'prenommoniteur', 'ruemoniteur', 'villemoniteur', 'codepostalmoniteur', 'telephonemoniteur', 'anneeembauchemoniteur') VALUES (25, 'Mich-Mich', 'LeBG', 'Rue des Pamplemousses', 'Mouans-Sartoux', '06370', '0102030405', 2005);
INSERT INTO lecon('numlecon', 'heuredeblecon', 'heurefinlecon', 'ruemoniteur', 'numeromoniteur', 'numeroimmatriculation', 'numeleve') VALUES ('54', '12:10:12', '13:10:10', 'Rue des lapins', '25', 'AB-123-YZ', '1');
