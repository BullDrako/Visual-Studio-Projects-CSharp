-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-03-2017 a las 13:03:53
-- Versión del servidor: 10.1.19-MariaDB
-- Versión de PHP: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ebookshop`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertBook` (IN `titol` VARCHAR(50), IN `autor` VARCHAR(50), IN `preu` FLOAT, IN `quantity` INT(11))  NO SQL
    SQL SECURITY INVOKER
INSERT INTO book VALUES(null, titol, autor, preu, quantity)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `selectID1` (INOUT `id` INT(11), INOUT `titol` VARCHAR(50), INOUT `autor` VARCHAR(50), INOUT `preu` FLOAT, INOUT `quantity` INT(11))  NO SQL
    SQL SECURITY INVOKER
select * from books where id = 1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `book`
--

CREATE TABLE `book` (
  `id` int(11) NOT NULL,
  `title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci NOT NULL,
  `author` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `price` float NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `book`
--

INSERT INTO `book` (`id`, `title`, `author`, `price`, `quantity`) VALUES
(1, 'titulo1', 'autor1', 20, 23),
(2, 'titulo2', 'autor2', 30, 25),
(3, 'TitolC', 'AutorC', 45, 55),
(4, 'TitolC2', 'AutorC2', 44, 57),
(6, 'titolPre', 'autorPre', 77, 10),
(7, 'titolStored', 'autorStored', 11, 22);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `book`
--
ALTER TABLE `book`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `book`
--
ALTER TABLE `book`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
