CREATE TABLE Armateur(Code Integer,
                      Nom VARCHAR(50),
                      Adresse VARCHAR(100),
PRIMARY KEY (Code));

ALTER TABLE BATEAU ADD Code INTEGER;

ALTER TABLE BATEAU ADD FOREIGN KEY (code) REFERENCES Armateur(Code);