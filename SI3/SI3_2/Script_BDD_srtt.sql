-- phpMyAdmin SQL Dump
-- version 2.9.2
-- http://www.phpmyadmin.net
-- 
-- Serveur: localhost
-- Généré le : Mercredi 25 Septembre 2013 à 16:59
-- Version du serveur: 5.0.27
-- Version de PHP: 5.2.1
-- 
-- Base de données: `srtt`
-- 

-- --------------------------------------------------------

-- 
-- Structure de la table `agence`
-- 

CREATE TABLE `agence` (
  `CodeAgence` varchar(2) NOT NULL,
  `Adresse1` varchar(32) default NULL,
  `Adresse2` varchar(32) default NULL,
  `Codepostal` char(5) default NULL,
  `Ville` varchar(26) default NULL,
  `telephone` char(14) default NULL,
  `Fax` char(14) default NULL,
  `DescriptifSecteur` varchar(100) default NULL,
  PRIMARY KEY  (`CodeAgence`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Contenu de la table `agence`
-- 

INSERT INTO `agence` (`CodeAgence`, `Adresse1`, `Adresse2`, `Codepostal`, `Ville`, `telephone`, `Fax`, `DescriptifSecteur`) VALUES 
('BR', '4, la Rade', NULL, '29200', 'Brest', '0245122225', '0245122226', 'Finistère moins le secteur de Quimper, voir carte'),
('QU', '426, Bd de la Liberté', NULL, '29000', 'Quimper', '0244525862', '0244525863', 'Finistère moins le secteur de Brest, voir carte'),
('RN', 'La Bastide Blanche', '35, Bd Maurice Schumann', '35000', 'Rennes', '0256884665', '0256884666', 'Ille et Vilaine moins le secteur de Saint-Malo, voir carte'),
('SB', '56, rue du Général Fabre', NULL, '22000', 'Saint-Brieux', '0245552255', '0245552256', 'Côtes d''Armor'),
('SM', '34, chemin du littoral', NULL, '35400', 'Saint-Malo', '0215555557', '0215555558', 'Ille et Vilaine moins le secteur de Rennes, voir carte'),
('VN', '65, rue des petits champs', NULL, '56000', 'Vannes', '0256858566', '0256858567', 'Morbihan');

-- --------------------------------------------------------

-- 
-- Structure de la table `interimaire`
-- 

CREATE TABLE `interimaire` (
  `NumeroInterimaire` varchar(6) NOT NULL,
  `TitreCivilite` varchar(12) default NULL,
  `Nom` varchar(32) NOT NULL,
  `Prenom` varchar(20) default NULL,
  `Adresse1` varchar(32) default NULL,
  `Adresse2` varchar(32) default NULL,
  `Codepostal` char(5) default NULL,
  `Ville` varchar(26) default NULL,
  `Telephone` char(14) default NULL,
  `DateNaissance` datetime default NULL,
  `DateDebContrat` datetime default NULL,
  `DateFinContrat` datetime default NULL,
  `CodeAgence` varchar(2) default NULL,
  PRIMARY KEY  (`NumeroInterimaire`),
  KEY `CodeAgence` (`CodeAgence`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Contenu de la table `interimaire`
-- 

INSERT INTO `interimaire` (`NumeroInterimaire`, `TitreCivilite`, `Nom`, `Prenom`, `Adresse1`, `Adresse2`, `Codepostal`, `Ville`, `Telephone`, `DateNaissance`, `DateDebContrat`, `DateFinContrat`, `CodeAgence`) VALUES 
('980001', 'Monsieur', 'RENAUX', 'Claude', "77, Bd de l'Océan", NULL, '25200', 'Brest', '0225456660', '1980-08-12 00:00:00', NULL, NULL, 'BR'),
('980002', 'Monsieur', 'DOZON', 'Jean', '129, Boucle de Bellevue', NULL, '35300', 'Fougères', '0234565251', '1973-05-14 00:00:00', NULL, NULL, 'SM'),
('980003', 'Monsieur', 'ESTRADA', 'Georges', 'Le Pied du Pont', NULL, '25200', 'Brest', '0244558423', '1974-02-25 00:00:00', NULL, NULL, 'BR'),
('980004', 'Madame', 'JANNAS', 'Camille', '15, Rue Gramon', NULL, '25200', 'Brest', '0287253621', '1983-05-16 00:00:00', NULL, NULL, 'BR'),
('980005', 'Mademoiselle', 'NICHET', 'Antoinette', '15, Rue Renoir', NULL, '25200', 'Brest', '0225354520', '1959-04-18 00:00:00', NULL, NULL, 'BR'),
('980006', 'Monsieur', 'LE HEDEC', 'Jean', '6, Rue Jean Bart', NULL, '25200', 'Brest', '0256654521', '1990-03-14 00:00:00', NULL, NULL, 'BR'),
('980007', 'Monsieur', 'NARCISSIAN', 'Gilles', '50, Rue Louis Renard', NULL, '56000', 'Vannes', '0255558774', '1976-12-12 00:00:00', NULL, NULL, 'VN'),
('980008', 'Madame', 'GAOUAOU', 'Lilia', 'Rue Jean Jaures', NULL, '25200', 'Brest', '0292451245', '1989-05-23 00:00:00', NULL, NULL, 'BR'),
('980009', 'Monsieur', 'PEREZ', 'Hector', '65, Avenue du Général Sarrail', NULL, '25200', 'Brest', '0255533645', '1978-12-25 00:00:00', NULL, NULL, 'BR'),
('980010', 'Monsieur', 'ABDALLAH', 'NKebir', '11, Rue Gaston Thouret', NULL, '25200', 'Brest', '0245558551', '1991-09-12 00:00:00', NULL, NULL, 'BR'),
('980011', 'Madame', 'VIZIALE', 'Najette', '6, Route de St Mathieu', NULL, '56800', 'Ploermel', '0240555221', '1991-02-10 00:00:00', NULL, NULL, 'VN'),
('980012', 'Monsieur', 'BLANCO', 'Renaud', '58, Bd. St. Rulf', NULL, '25200', 'Brest', '0252221545', '1990-04-03 00:00:00', NULL, NULL, 'BR'),
('980013', 'Monsieur', 'CERBONE', 'Daniel', '6 rue de la Fontaine', 'NULL', '2200', 'Loudéac', 'NULL', '1995-06-08 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'SB'),
('980014', 'Monsieur', 'ANRACT', 'Philippe', 'Poste restante', NULL, '35000', 'Rennes', '0256152335', '1992-07-14 00:00:00', NULL, NULL, 'RN'),
('980015', 'Monsieur', 'GRANERO', 'Jérôme', 'Chemin des Bassaquets', NULL, '35000', 'Rennes', '0236655588', '1990-11-25 00:00:00', NULL, NULL, 'RN'),
('980016', 'Monsieur', 'RICOURT', 'Igor', 'Villa Romana', '55, Rue Richard Wagner', '22300', 'Lannion', NULL, '1972-12-05 00:00:00', NULL, NULL, 'SB');

-- 
-- Contraintes pour les tables exportées
-- 

-- 
-- Contraintes pour la table `interimaire`
-- 
ALTER TABLE `interimaire`
  ADD CONSTRAINT `interimaire_ibfk_1` FOREIGN KEY (`CodeAgence`) REFERENCES `agence` (`CodeAgence`);
