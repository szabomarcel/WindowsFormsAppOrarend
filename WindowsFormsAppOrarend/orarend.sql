-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Dec 06. 18:43
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `orarend`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orak`
--

CREATE TABLE `orak` (
  `oraid` int(10) UNSIGNED NOT NULL,
  `tantargy` varchar(30) NOT NULL,
  `sorszam` int(11) NOT NULL COMMENT 'Az óra sorszáma a napon belül',
  `hetnapja` enum('hétfő','kedd','szerda','csütörtök','péntek') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `orak`
--

INSERT INTO `orak` (`oraid`, `tantargy`, `sorszam`, `hetnapja`) VALUES
(1, 'Matek', 1, 'hétfő'),
(2, 'Magyar', 2, 'hétfő'),
(3, 'Tesnevelés', 3, 'hétfő'),
(4, 'Irodalom és Nyelvtan', 4, 'hétfő'),
(5, 'Informatika', 5, 'hétfő'),
(6, 'Ének', 6, 'hétfő'),
(7, 'Matek', 1, 'kedd'),
(8, 'Irodalom és nyelvtan', 2, 'kedd'),
(9, 'Történelem', 3, 'kedd'),
(10, 'Informatika', 4, 'kedd'),
(11, 'Tesnevelés', 5, 'kedd'),
(12, 'Életvitel és Kiltúra', 6, 'kedd'),
(13, 'Ének', 1, 'szerda'),
(14, 'Irodalom és Nyelvtan', 2, 'szerda'),
(15, 'Történelem', 3, 'szerda'),
(16, 'Informatik', 4, 'szerda'),
(17, 'Ének', 5, 'szerda'),
(18, 'Testnevelés', 6, 'szerda'),
(19, 'Történelem', 1, 'csütörtök'),
(20, 'Mozgókép ismeret', 2, 'csütörtök'),
(21, 'Informatika', 3, 'csütörtök'),
(22, 'Ének', 4, 'csütörtök'),
(23, 'Matek', 5, 'csütörtök'),
(24, 'Testnevelés', 6, 'csütörtök'),
(25, 'Biológia', 1, 'péntek'),
(26, 'Biológia', 2, 'péntek'),
(27, 'Kémia', 3, 'péntek'),
(28, 'Kémia', 4, 'péntek'),
(29, 'Testnevelés', 5, 'péntek'),
(30, 'Ének', 6, 'péntek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tanarok`
--

CREATE TABLE `tanarok` (
  `tanarid` int(10) UNSIGNED NOT NULL,
  `tanarnev` varchar(30) NOT NULL,
  `jelszo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `orak`
--
ALTER TABLE `orak`
  ADD PRIMARY KEY (`oraid`);

--
-- A tábla indexei `tanarok`
--
ALTER TABLE `tanarok`
  ADD PRIMARY KEY (`tanarid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `orak`
--
ALTER TABLE `orak`
  MODIFY `oraid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT a táblához `tanarok`
--
ALTER TABLE `tanarok`
  MODIFY `tanarid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
