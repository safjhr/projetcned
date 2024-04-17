-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 17 avr. 2024 à 16:13
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projetcned`
--
CREATE DATABASE IF NOT EXISTS `projetcned` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `projetcned`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

CREATE TABLE `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2022-04-15 00:00:00', '2022-04-18 00:00:00', 1),
(1, '2022-04-30 00:00:00', '2022-05-03 00:00:00', 4),
(1, '2022-05-22 00:00:00', '2022-05-28 00:00:00', 1),
(1, '2022-07-14 00:00:00', '2022-07-18 00:00:00', 3),
(1, '2022-09-22 00:00:00', '2022-09-27 00:00:00', 3),
(1, '2022-10-16 00:00:00', '2022-10-22 00:00:00', 1),
(2, '2022-02-24 00:00:00', '2022-02-28 00:00:00', 3),
(2, '2022-03-24 00:00:00', '2022-03-30 00:00:00', 3),
(2, '2022-04-11 00:00:00', '2022-04-11 00:00:00', 2),
(2, '2022-04-28 00:00:00', '2022-04-29 00:00:00', 4),
(2, '2022-08-16 00:00:00', '2022-08-24 00:00:00', 1),
(2, '2022-12-09 00:00:00', '2022-12-12 00:00:00', 4),
(2, '2022-12-22 00:00:00', '2022-12-25 00:00:00', 4),
(3, '2022-09-22 00:00:00', '2022-10-01 00:00:00', 2),
(4, '2022-01-07 00:00:00', '2022-01-16 00:00:00', 3),
(4, '2022-06-03 00:00:00', '2022-06-04 00:00:00', 2),
(4, '2022-06-05 00:00:00', '2022-06-06 00:00:00', 3),
(4, '2022-07-31 00:00:00', '2022-08-07 00:00:00', 4),
(4, '2022-08-18 00:00:00', '2022-08-27 00:00:00', 1),
(4, '2022-08-30 00:00:00', '2022-09-01 00:00:00', 2),
(4, '2022-09-12 00:00:00', '2022-09-15 00:00:00', 4),
(4, '2022-10-08 00:00:00', '2022-10-17 00:00:00', 2),
(4, '2022-12-05 00:00:00', '2022-12-11 00:00:00', 3),
(5, '2022-02-28 00:00:00', '2022-03-03 00:00:00', 2),
(5, '2022-03-08 00:00:00', '2022-03-14 00:00:00', 4),
(5, '2022-03-13 00:00:00', '2022-03-20 00:00:00', 1),
(5, '2022-05-23 00:00:00', '2022-05-28 00:00:00', 3),
(5, '2022-06-17 00:00:00', '2022-06-17 00:00:00', 4),
(5, '2022-11-01 00:00:00', '2022-11-08 00:00:00', 1),
(5, '2022-11-10 00:00:00', '2022-11-10 00:00:00', 3),
(6, '2020-01-01 00:00:00', '2020-01-02 00:00:00', 1),
(6, '2020-04-12 22:00:00', '2020-05-06 22:00:00', 3),
(6, '2020-05-25 00:00:00', '2020-05-30 00:00:00', 4),
(6, '2021-05-25 00:00:00', '2021-05-26 00:00:00', 4),
(6, '2024-09-29 00:00:00', '2024-09-30 00:00:00', 4),
(7, '2022-01-11 00:00:00', '2022-01-13 00:00:00', 1),
(7, '2022-03-21 00:00:00', '2022-03-23 00:00:00', 2),
(7, '2022-05-15 00:00:00', '2022-05-23 00:00:00', 2),
(7, '2022-07-06 00:00:00', '2022-07-12 00:00:00', 3),
(7, '2022-07-24 00:00:00', '2022-07-31 00:00:00', 4),
(7, '2022-08-24 00:00:00', '2022-08-28 00:00:00', 1),
(7, '2022-09-06 00:00:00', '2022-09-10 00:00:00', 2),
(7, '2022-12-30 00:00:00', '2023-01-08 00:00:00', 3),
(8, '2022-01-07 00:00:00', '2022-01-14 00:00:00', 4),
(9, '2022-03-20 00:00:00', '2022-03-26 00:00:00', 2),
(9, '2022-04-08 00:00:00', '2022-04-14 00:00:00', 3),
(9, '2022-05-21 00:00:00', '2022-05-23 00:00:00', 2),
(9, '2022-06-06 00:00:00', '2022-06-12 00:00:00', 1),
(9, '2022-10-14 00:00:00', '2022-10-18 00:00:00', 4),
(9, '2022-11-27 00:00:00', '2022-11-27 00:00:00', 2),
(9, '2022-12-19 00:00:00', '2022-12-21 00:00:00', 2),
(9, '2022-12-25 00:00:00', '2022-12-28 00:00:00', 3),
(10, '2022-01-04 00:00:00', '2022-01-06 00:00:00', 2),
(10, '2022-02-02 00:00:00', '2022-02-08 00:00:00', 1),
(10, '2022-03-09 00:00:00', '2022-03-10 00:00:00', 1),
(10, '2022-06-21 00:00:00', '2022-06-27 00:00:00', 4),
(10, '2022-09-20 00:00:00', '2022-09-27 00:00:00', 2),
(10, '2022-10-12 00:00:00', '2022-10-12 00:00:00', 4),
(10, '2022-10-28 00:00:00', '2022-11-01 00:00:00', 3),
(10, '2022-11-01 00:00:00', '2022-11-03 00:00:00', 3),
(10, '2022-12-02 00:00:00', '2022-12-09 00:00:00', 4),
(10, '2022-12-21 00:00:00', '2022-12-29 00:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

CREATE TABLE `motif` (
  `idmotif` int(11) NOT NULL,
  `libelle` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

CREATE TABLE `personnel` (
  `idpersonnel` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Leprince', 'Jean', '0648952176', 'leprincejulie@gmail.com', 2),
(2, 'Dupont', 'Luc', '0635526534', 'Dupontluc@gmail.com', 2),
(3, 'Duc', 'Marie', '0625431765', 'ducmarie@gmail.com', 3),
(4, 'Marchal', 'Léo', '0632675434', 'marchalleo@gmail.com', 1),
(5, 'Martin', 'Jaque', '0643256742', 'Martinjaque@gmail.com', 2),
(6, 'Fernandez', 'iris', '0648952176', 'fernandeziris@gmail.com', 2),
(7, 'Gomez', 'Jule', '0641236554', 'gomezjule@gmail.com', 2),
(8, 'Varonne', 'Cristion', '0609216654', 'varonnecristion@gmail.com', 2),
(9, 'Rolen', 'Roméo', '0645631898', 'rolenromeo@gmail.com', 3),
(10, 'Rey', 'Lola', '0654319905', 'Reylola@gmail.com', 1),
(36, 'jean', 'luc', '0987654323', 'jeanluc@gmail.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

CREATE TABLE `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('votre_login', 'c35a92cec1651b2b4e7eeda0b5d4dbe07b3b88eaa0962dd54d5c0fe9db02f3b4'),
('responsable', 'projetcned2510');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'admnistratif'),
(2, 'médiation cukturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `idmotif` (`idmotif`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `idservice` (`idservice`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `idmotif` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `idservice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
-- Création de l'utilisateur pour la base de données
CREATE USER 'safiyajhr'@'localhost' IDENTIFIED BY 'ds0oue9r';

-- Attribution des privilèges à l'utilisateur
GRANT ALL PRIVILEGES ON MaBaseDeDonnees.* TO 'safiyajhr'@'localhost';

-- Assurer que les modifications prennent effet
FLUSH PRIVILEGES;
