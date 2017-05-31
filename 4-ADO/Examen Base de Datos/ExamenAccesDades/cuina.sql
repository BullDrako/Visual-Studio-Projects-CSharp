-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-05-2017 a las 11:57:00
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cuina`
--
CREATE DATABASE IF NOT EXISTS `cuina` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci;
USE `cuina`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categories`
--

CREATE TABLE `categories` (
  `idCategoria` int(10) NOT NULL,
  `nomCategoria` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `categories`
--

INSERT INTO `categories` (`idCategoria`, `nomCategoria`) VALUES
(1, 'carn'),
(2, 'peix');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `receptes`
--

CREATE TABLE `receptes` (
  `nomRecepta` varchar(50) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `idCategoria` int(10) NOT NULL,
  `tempsPreparacioMinuts` int(10) NOT NULL,
  `ingredients` varchar(50) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcioPreparacio` varchar(100) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `dificultat` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `receptes`
--

INSERT INTO `receptes` (`nomRecepta`, `idCategoria`, `tempsPreparacioMinuts`, `ingredients`, `descripcioPreparacio`, `dificultat`) VALUES
('bistec', 1, 150, 'bistec, patates', 'primer, segon, despres', 4),
('salmo', 2, 200, 'salmo, patates', 'primer, despres', 5);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`idCategoria`);

--
-- Indices de la tabla `receptes`
--
ALTER TABLE `receptes`
  ADD PRIMARY KEY (`nomRecepta`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
