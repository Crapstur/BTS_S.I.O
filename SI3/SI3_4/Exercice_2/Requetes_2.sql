INSERT INTO emplacement('NumEmplac', 'NomEmplac', 'LongueurEmplac', 'TirantEauMax', 'TarifJournalier', 'CodeTypeFret') VALUES ('1', "La Rapière", 200, 20, 400, 12)
INSERT INTO emplacement('NumEmplac', 'NomEmplac', 'LongueurEmplac', 'TirantEauMax', 'TarifJournalier', 'CodeTypeFret') VALUES ('1', "LE cachalot", 150, 60, 800, 5)
INSERT INTO emplacement('NumEmplac', 'NomEmplac', 'LongueurEmplac', 'TirantEauMax', 'TarifJournalier', 'CodeTypeFret') VALUES ('1', "La baleine", 500, 643, 126, 1)



UPDATE EMPLACEMENT SET TarifJournalier = TarifJournalier * 1.05
WHERE LongueurEmplac > 38;