-- phpMyAdmin SQL Dump
-- version 2.9.2
-- http://www.phpmyadmin.net
-- 
-- Serveur: localhost
-- Généré le : Mercredi 04 Septembre 2013 à 10:20
-- Version du serveur: 5.0.27
-- Version de PHP: 5.2.1
-- 
-- Base de données: `gestion commerciale`
-- 

-- --------------------------------------------------------

-- 
-- Structure de la table `client`
-- 

CREATE TABLE `client` (
  `NUMECLIE` varchar(6) collate utf8_unicode_ci NOT NULL,
  `NOMECLIE` varchar(30) collate utf8_unicode_ci default NULL,
  `ADRECLIE` varchar(50) collate utf8_unicode_ci default NULL,
  `CODPCLIE` varchar(5) collate utf8_unicode_ci default NULL,
  `VILLCLIE` varchar(30) collate utf8_unicode_ci default NULL,
  `TELECLIE` varchar(10) collate utf8_unicode_ci default NULL,
  `NUMEREPR` varchar(5) collate utf8_unicode_ci NOT NULL,
  PRIMARY KEY  (`NUMECLIE`),
  KEY `FK_CLIENT_REPRESENTANT` (`NUMEREPR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 
-- Contenu de la table `client`
-- 

INSERT INTO `client` (`NUMECLIE`, `NOMECLIE`, `ADRECLIE`, `CODPCLIE`, `VILLCLIE`, `TELECLIE`, `NUMEREPR`) VALUES 
('100001', 'Digit Equipement', '25, rue des Pins', '06200', 'Valbonne', '0493564578', '2'),
('100002', 'F.D.T', '10, Impasse de la Poste', '06000', 'Nice', '0493564545', '2'),
('100010', 'Ecole Pugier', '10, av J Médecin', '06200', 'Nice', '0493656562', '2'),
('100011', 'Forum Immobilier', '5, Av de Grasse', '06500', 'Valbonne', '0493252525', '2'),
('100020', 'Habitable', '2, av de Valbonne', '06200', 'Nice', '0493565656', '2'),
('200005', 'Lycée Victor Hugo', 'Bd Desplaces', '13001', 'Marseille', NULL, '3'),
('300010', 'A.R.T', '20, rue de la mer', '83000', 'Toulon', '0494562154', '3');

-- --------------------------------------------------------

-- 
-- Structure de la table `facture`
-- 

CREATE TABLE `facture` (
  `NUMEFACT` varchar(5) collate utf8_unicode_ci NOT NULL,
  `DATEFACT` date default NULL,
  `NUMECLIE` varchar(6) collate utf8_unicode_ci NOT NULL,
  PRIMARY KEY  (`NUMEFACT`),
  KEY `FK_FACTURE_CLIENT` (`NUMECLIE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 
-- Contenu de la table `facture`
-- 

INSERT INTO `facture` (`NUMEFACT`, `DATEFACT`, `NUMECLIE`) VALUES 
('96001', '2009-01-01', '300010'),
('96002', '2009-01-01', '100001'),
('96003', '2009-02-01', '100002'),
('96004', '2009-05-01', '100001'),
('96005', '2009-10-01', '300010'),
('96006', '2009-01-20', '100011'),
('96007', '2009-01-22', '300010'),
('96008', '2009-01-22', '200005'),
('96009', '2009-01-25', '100011'),
('96010', '2009-01-28', '200005');

-- --------------------------------------------------------

-- 
-- Structure de la table `facturer`
-- 

CREATE TABLE `facturer` (
  `NUMEFACT` varchar(5) collate utf8_unicode_ci NOT NULL,
  `REFEPROD` varchar(5) collate utf8_unicode_ci NOT NULL,
  `PUHTURER` float default '0',
  `QTEFURER` smallint(6) default '0',
  PRIMARY KEY  (`NUMEFACT`,`REFEPROD`),
  KEY `FK_FACTURER_PRODUIT` (`REFEPROD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 
-- Contenu de la table `facturer`
-- 

INSERT INTO `facturer` (`NUMEFACT`, `REFEPROD`, `PUHTURER`, `QTEFURER`) VALUES 
('96001', '10001', 152.45, 1),
('96001', '10003', 91.47, 2),
('96002', '20005', 1372.04, 1),
('96003', '10003', 91.47, 2),
('96003', '20002', 609.8, 2),
('96003', '30006', 2439.18, 2),
('96004', '30007', 2850.8, 1),
('96005', '10001', 121.96, 5),
('96005', '30003', 1219.59, 5),
('96006', '10001', 121.96, 15),
('96007', '30009', 4116.12, 5),
('96008', '20005', 1372.04, 3),
('96008', '20010', 914.69, 3),
('96008', '30003', 1219.59, 3),
('96008', '30009', 3811.23, 3),
('96009', '20010', 914.69, 5),
('96010', '10001', 121.96, 1),
('96010', '20002', 609.8, 1);

-- --------------------------------------------------------

-- 
-- Structure de la table `produit`
-- 

CREATE TABLE `produit` (
  `REFEPROD` varchar(5) collate utf8_unicode_ci NOT NULL,
  `DESIPROD` varchar(30) collate utf8_unicode_ci default NULL,
  `PUHTPROD` float default '0',
  `TTVAPROD` float default '0',
  `QTESPROD` smallint(6) default '0',
  PRIMARY KEY  (`REFEPROD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 
-- Contenu de la table `produit`
-- 

INSERT INTO `produit` (`REFEPROD`, `DESIPROD`, `PUHTPROD`, `TTVAPROD`, `QTESPROD`) VALUES 
('10001', 'Home Works', 121.96, 19.6, 5),
('10003', 'Home Organizer', 91.47, 19.6, 15),
('10005', 'Home Navigator', 137.2, 19.6, 2),
('20001', 'Home Jet 1', 503.08, 19.6, 10),
('20002', 'Home Jet 2', 609.8, 19.6, 2),
('20005', 'Home Laser 4/600', 1221.12, 19.6, 3),
('20010', 'Home Laser 4/300', 914.69, 19.6, 10),
('30003', 'Home Power 500', 1219.59, 19.6, 20),
('30005', 'Home Power 1000', 1829.39, 19.6, 50),
('30006', 'Home Power 1100 8/500', 2362.96, 19.6, 10),
('30007', 'Home Power 1000 16/800', 2850.8, 19.6, 5),
('30009', 'Home Power 3000', 3811.23, 19.6, 10);

-- --------------------------------------------------------

-- 
-- Structure de la table `representant`
-- 

CREATE TABLE `representant` (
  `NUMEREPR` varchar(5) collate utf8_unicode_ci NOT NULL,
  `NOMEREPR` varchar(20) collate utf8_unicode_ci default NULL,
  `PRENREPR` varchar(15) collate utf8_unicode_ci default NULL,
  `ADREREPR` varchar(50) collate utf8_unicode_ci default NULL,
  `CODPREPR` varchar(5) collate utf8_unicode_ci default NULL,
  `VILLREPR` varchar(20) collate utf8_unicode_ci default NULL,
  PRIMARY KEY  (`NUMEREPR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 
-- Contenu de la table `representant`
-- 

INSERT INTO `representant` (`NUMEREPR`, `NOMEREPR`, `PRENREPR`, `ADREREPR`, `CODPREPR`, `VILLREPR`) VALUES 
('1', 'Durant', 'Patrick', '56, Av du Lycée', '83600', 'Fréjus'),
('2', 'Dupont', 'Eric', '45, Av du Collége', '06000', 'Nice'),
('3', 'Richard', 'Bernard', '12, Av de l''Ecole', '13001', 'Marseille');

-- 
-- Contraintes pour les tables exportées
-- 

-- 
-- Contraintes pour la table `client`
-- 
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`NUMEREPR`) REFERENCES `representant` (`NUMEREPR`);

-- 
-- Contraintes pour la table `facture`
-- 
ALTER TABLE `facture`
  ADD CONSTRAINT `facture_ibfk_1` FOREIGN KEY (`NUMECLIE`) REFERENCES `client` (`NUMECLIE`);

-- 
-- Contraintes pour la table `facturer`
-- 
ALTER TABLE `facturer`
  ADD CONSTRAINT `facturer_ibfk_1` FOREIGN KEY (`NUMEFACT`) REFERENCES `facture` (`NUMEFACT`),
  ADD CONSTRAINT `facturer_ibfk_2` FOREIGN KEY (`REFEPROD`) REFERENCES `produit` (`REFEPROD`);
