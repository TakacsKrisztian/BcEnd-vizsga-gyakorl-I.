-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Feb 23. 10:25
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `osztalynaplo`
--
CREATE DATABASE IF NOT EXISTS `osztalynaplo` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `osztalynaplo`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jegyek`
--
-- Létrehozva: 2024. Feb 22. 10:08
--

DROP TABLE IF EXISTS `jegyek`;
CREATE TABLE `jegyek` (
  `id` int(11) NOT NULL,
  `jegy_szammal` int(1) DEFAULT NULL,
  `jegy_szoveggel` varchar(10) DEFAULT NULL,
  `beiras_datuma` date DEFAULT NULL,
  `modositas_datuma` date DEFAULT NULL,
  `id_tanarok` int(11) DEFAULT NULL,
  `id_tantargyak` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `jegyek`:
--   `id_tanarok`
--       `tanarok` -> `id`
--   `id_tantargyak`
--       `tantargyak` -> `id`
--

--
-- A tábla adatainak kiíratása `jegyek`
--

INSERT INTO `jegyek` (`id`, `jegy_szammal`, `jegy_szoveggel`, `beiras_datuma`, `modositas_datuma`, `id_tanarok`, `id_tantargyak`) VALUES
(1, 3, 'közepes', '2022-04-25', '2023-02-18', 1, 1),
(2, 1, 'elégtelen', '2022-05-21', '2022-04-27', 1, 2),
(3, 2, 'elégséges', '2022-12-22', '2022-06-25', 3, 2),
(4, 5, 'jeles', '2022-09-18', '2022-11-10', 4, 4),
(5, 2, 'elégséges', '2022-07-13', '2022-09-15', 5, 5),
(6, 4, 'jó', '2022-04-14', '2022-10-25', 6, 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tanarok`
--
-- Létrehozva: 2024. Feb 22. 10:08
-- Utolsó frissítés: 2024. Feb 23. 09:23
--

DROP TABLE IF EXISTS `tanarok`;
CREATE TABLE `tanarok` (
  `id` int(11) NOT NULL,
  `vezetek_nev` varchar(30) DEFAULT NULL,
  `kereszt_nev` varchar(30) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `nem` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `tanarok`:
--

--
-- A tábla adatainak kiíratása `tanarok`
--

INSERT INTO `tanarok` (`id`, `vezetek_nev`, `kereszt_nev`, `email`, `nem`) VALUES
(1, 'Roseann', 'Leys', 'rleys0@cdc.gov', 'Nő'),
(2, 'Andriana', 'Benardet', 'abenardet1@cbsnews.com', 'Nő'),
(3, 'Donny', 'McElroy', 'dmcelroy2@loc.gov', 'Férfi'),
(4, 'Bert', 'Pretley', 'bpretley3@theglobeandmail.com', 'Nő'),
(5, 'Oberon', 'Gaymar', 'ogaymar4@360.cn', 'Férfi'),
(6, 'Laughton', 'Tatham', 'ltatham5@weibo.com', 'Férfi'),
(7, 'Farkas', 'Zoltán', 'farkasz@kkszki.hu', 'férfi');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tantargyak`
--
-- Létrehozva: 2024. Feb 22. 10:08
-- Utolsó frissítés: 2024. Feb 23. 09:23
--

DROP TABLE IF EXISTS `tantargyak`;
CREATE TABLE `tantargyak` (
  `id` int(11) NOT NULL,
  `tantargy_nev` varchar(20) DEFAULT NULL,
  `tantargy_leiras` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `tantargyak`:
--

--
-- A tábla adatainak kiíratása `tantargyak`
--

INSERT INTO `tantargyak` (`id`, `tantargy_nev`, `tantargy_leiras`) VALUES
(1, 'Matematika', 'Gyakorlat'),
(2, 'Magyar', 'Elmélet'),
(3, 'Történelem', 'Elmélet'),
(4, 'Angol', 'Elmélet'),
(5, 'SzakmaiAngol', 'Gyakorlat'),
(6, 'Informatika', 'Gyakorlat'),
(7, 'BackEnd', 'A FrontEnd-hez szükséges adatbázis, és kezelése.');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jegyek`
--
ALTER TABLE `jegyek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_tanarok` (`id_tanarok`),
  ADD KEY `id_tantargyak` (`id_tantargyak`);

--
-- A tábla indexei `tanarok`
--
ALTER TABLE `tanarok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `tantargyak`
--
ALTER TABLE `tantargyak`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jegyek`
--
ALTER TABLE `jegyek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `tanarok`
--
ALTER TABLE `tanarok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `tantargyak`
--
ALTER TABLE `tantargyak`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jegyek`
--
ALTER TABLE `jegyek`
  ADD CONSTRAINT `jegyek_ibfk_1` FOREIGN KEY (`id_tanarok`) REFERENCES `tanarok` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `jegyek_ibfk_2` FOREIGN KEY (`id_tantargyak`) REFERENCES `tantargyak` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;


--
-- Metaadat
--
USE `phpmyadmin`;

--
-- A(z) jegyek tábla metaadatai
--

--
-- A(z) tanarok tábla metaadatai
--

--
-- A(z) tantargyak tábla metaadatai
--

--
-- A(z) osztalynaplo adatbázis metaadatai
--
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
