CREATE TABLE BATEAU (NumBateau SMALLINT,
                     NomBateau VARCHAR,
                     Tonnage SMALLINT,
                     LongueurBateau SMALLINT,
                     TirantEau SMALLINT,
PRIMARY KEY (NumBateau));


CREATE TABLE AGENT (CodeAgent INTEGER,
                    NomAgent VARCHAR(20),
                    AdresseAgent VARCHAR(100),
                    TélAgent CHAR(10),
                    FaxAgent VARCHAR(30),
PRIMARY KEY (CodeAgent))


CREATE TABLE TYPE_FRET (CodeTypeFret INTEGER,
                       LibelléFret VARCHAR(30),
PRIMARY KEY (CodeTypeFret))


CREATE TABLE EMPLACEMENT(NumEmplac TINYINT,
                         NomEmplac VARCHAR(30),
                         LongueurEmplac SMALLINT,
                         TirantEauMax VARCHAR(30),
                         TarifJournalier VARCHAR(20),
                         CodeTypeFret INTEGER,
PRIMARY KEY (NumEmplac),
FOREIGN KEY (CodeTypeFret) REFERENCES TYPE_FRET(CodeTypeFret))


CREATE TABLE SÉJOUR(NumSéjour INTEGER,
                    DateArrivée DATE,
                    DuréeSéjour SMALLINT,
                    NumEmplac TINYINT,
                    NumBateau SMALLINT,
                    CodeAgent TINYINT,
PRIMARY KEY (NumSéjour),
FOREIGN KEY  (NumEmplac) REFERENCES EMPLACEMENT(NumEmplac),
FOREIGN KEY (NumBateau) REFERENCES BATEAU(NumBateau),
FOREIGN KEY (CodeAgent) REFERENCES AGENT(CodeAgent))


CREATE TABLE TRANSPORTER(NumBateau SMALLINT,
                         CodeTypeFret INTEGER,
                         QtéFret INTEGER,
PRIMARY KEY (NumBateau,CodeTypeFret),
FOREIGN KEY (NumBateau) REFERENCES BATEAU(NumBateau),
FOREIGN KEY (CodeTypeFret) REFERENCES TYPE_FRET(CodeTypeFret));