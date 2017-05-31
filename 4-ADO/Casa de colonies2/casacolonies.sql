-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-04-2017 a las 20:32:07
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `casacolonies`
--
CREATE DATABASE IF NOT EXISTS `casacolonies` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish2_ci;
USE `casacolonies`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actividad_casa`
--

CREATE TABLE `actividad_casa` (
  `codigo_actividad` int(11) NOT NULL,
  `codigo_casa` int(11) NOT NULL,
  `nivel` int(11) NOT NULL,
  `calidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `actividad_casa`
--

INSERT INTO `actividad_casa` (`codigo_actividad`, `codigo_casa`, `nivel`, `calidad`) VALUES
(1, 1, 7, 7),
(2, 1, 1, 1),
(3, 2, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activitat`
--

CREATE TABLE `activitat` (
  `codigo` int(11) NOT NULL,
  `descripcion` varchar(50) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `activitat`
--

INSERT INTO `activitat` (`codigo`, `descripcion`) VALUES
(1, 'natacio'),
(2, 'escalada'),
(3, 'esqui');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administrador`
--

CREATE TABLE `administrador` (
  `dni` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `num_SS` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `titulacion` varchar(20) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `administrador`
--

INSERT INTO `administrador` (`dni`, `num_SS`, `titulacion`) VALUES
('22222222B', '123456789AB', 'admin'),
('33333333C', '987654321CD', 'super');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administra_casa`
--

CREATE TABLE `administra_casa` (
  `dni_administrador` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `codigo_casa` int(11) NOT NULL,
  `año` int(11) NOT NULL,
  `sueldo` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `administra_casa`
--

INSERT INTO `administra_casa` (`dni_administrador`, `codigo_casa`, `año`, `sueldo`) VALUES
('22222222B', 1, 2017, 1500);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `casa`
--

CREATE TABLE `casa` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `litoral` tinyint(1) NOT NULL,
  `codigo_comarca` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `casa`
--

INSERT INTO `casa` (`codigo`, `nombre`, `litoral`, `codigo_comarca`) VALUES
(1, 'casa 1', 1, 1),
(2, 'casa 2', 1, 2),
(5, 'casa 3', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comarca`
--

CREATE TABLE `comarca` (
  `codigo_comarca` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `comarca`
--

INSERT INTO `comarca` (`codigo_comarca`, `nombre`) VALUES
(1, 'barcelones'),
(2, 'tarragones');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inscripciones_casa_tanda`
--

CREATE TABLE `inscripciones_casa_tanda` (
  `carnet_niño` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `nombre_casa` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `numero_inscripcion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `inscripciones_casa_tanda`
--

INSERT INTO `inscripciones_casa_tanda` (`carnet_niño`, `fecha_inicio`, `nombre_casa`, `numero_inscripcion`) VALUES
(1, '2017-05-15', 'casa 1', 1),
(2, '2000-01-01', 'casa 4', 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monitor`
--

CREATE TABLE `monitor` (
  `dni` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `fecha_nacimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `monitor`
--

INSERT INTO `monitor` (`dni`, `fecha_nacimiento`) VALUES
('11111111A', '1950-03-01');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monitor_tanda_casa`
--

CREATE TABLE `monitor_tanda_casa` (
  `dni` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `fecha_tanda` date NOT NULL,
  `codigo_casa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `monitor_tanda_casa`
--

INSERT INTO `monitor_tanda_casa` (`dni`, `fecha_tanda`, `codigo_casa`) VALUES
('11111111A', '2017-05-15', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monitor_tareas_tanda`
--

CREATE TABLE `monitor_tareas_tanda` (
  `dni_monitor` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `codigo_tarea` int(11) NOT NULL,
  `fecha_inicio_tanda` date NOT NULL,
  `dia_tarea` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `monitor_tareas_tanda`
--

INSERT INTO `monitor_tareas_tanda` (`dni_monitor`, `codigo_tarea`, `fecha_inicio_tanda`, `dia_tarea`) VALUES
('11111111A', 1, '2017-04-16', '2017-04-02'),
('11111111B', 1, '2017-04-16', '2017-04-02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `niño`
--

CREATE TABLE `niño` (
  `carnet` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `apellidos` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `direccion` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `sexo` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `año_nacimiento` int(4) NOT NULL,
  `codigo_poblacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `niño`
--

INSERT INTO `niño` (`carnet`, `nombre`, `apellidos`, `direccion`, `sexo`, `año_nacimiento`, `codigo_poblacion`) VALUES
(1, 'pep', 'perez lopez', 'carrer fals, 123', 'home', 1990, 1),
(2, 'felip', 'perez lopez', 'carrer fals, 123', 'home', 2000, 1),
(1111111, 'algo2', 'algo2', 'algo2', 'algo2', 1960, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `niño_emparentado`
--

CREATE TABLE `niño_emparentado` (
  `carnet_niño` int(11) NOT NULL,
  `carnet_hermano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `niño_emparentado`
--

INSERT INTO `niño_emparentado` (`carnet_niño`, `carnet_hermano`) VALUES
(1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `dni` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `apellidos` varchar(40) COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` int(11) NOT NULL,
  `email` varchar(30) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`dni`, `nombre`, `apellidos`, `telefono`, `email`) VALUES
('11111111A', 'jordi', 'jimenez', 612345678, 'jjimenez@gmail.com'),
('22222222B', 'carles', 'hernandez', 623456789, 'chernandez@gmail.com'),
('33333333C', 'pere', 'fernandez ', 698765432, 'pfernandez@gmail.com'),
('algo', 'algo', 'algo', 123465798, 'algo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `poblacio`
--

CREATE TABLE `poblacio` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `poblacio`
--

INSERT INTO `poblacio` (`codigo`, `nombre`) VALUES
(0, 'algo'),
(1, 'el prat de llobregat');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tanda`
--

CREATE TABLE `tanda` (
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `tanda`
--

INSERT INTO `tanda` (`fecha_inicio`, `fecha_fin`) VALUES
('2017-05-15', '2017-05-31'),
('2017-06-01', '2017-06-15');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tareas`
--

CREATE TABLE `tareas` (
  `codigo_tareas` int(11) NOT NULL,
  `descripcion` varchar(50) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `tareas`
--

INSERT INTO `tareas` (`codigo_tareas`, `descripcion`) VALUES
(1, 'escalada rocodrom');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `actividad_casa`
--
ALTER TABLE `actividad_casa`
  ADD PRIMARY KEY (`codigo_actividad`,`codigo_casa`);

--
-- Indices de la tabla `activitat`
--
ALTER TABLE `activitat`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `administrador`
--
ALTER TABLE `administrador`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `administra_casa`
--
ALTER TABLE `administra_casa`
  ADD PRIMARY KEY (`dni_administrador`,`codigo_casa`);

--
-- Indices de la tabla `casa`
--
ALTER TABLE `casa`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `comarca`
--
ALTER TABLE `comarca`
  ADD PRIMARY KEY (`codigo_comarca`);

--
-- Indices de la tabla `inscripciones_casa_tanda`
--
ALTER TABLE `inscripciones_casa_tanda`
  ADD PRIMARY KEY (`carnet_niño`,`fecha_inicio`);

--
-- Indices de la tabla `monitor`
--
ALTER TABLE `monitor`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `monitor_tanda_casa`
--
ALTER TABLE `monitor_tanda_casa`
  ADD PRIMARY KEY (`dni`,`fecha_tanda`);

--
-- Indices de la tabla `monitor_tareas_tanda`
--
ALTER TABLE `monitor_tareas_tanda`
  ADD PRIMARY KEY (`dni_monitor`,`codigo_tarea`,`fecha_inicio_tanda`);

--
-- Indices de la tabla `niño`
--
ALTER TABLE `niño`
  ADD PRIMARY KEY (`carnet`);

--
-- Indices de la tabla `niño_emparentado`
--
ALTER TABLE `niño_emparentado`
  ADD PRIMARY KEY (`carnet_niño`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `poblacio`
--
ALTER TABLE `poblacio`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `tanda`
--
ALTER TABLE `tanda`
  ADD PRIMARY KEY (`fecha_inicio`);

--
-- Indices de la tabla `tareas`
--
ALTER TABLE `tareas`
  ADD PRIMARY KEY (`codigo_tareas`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `activitat`
--
ALTER TABLE `activitat`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `casa`
--
ALTER TABLE `casa`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `comarca`
--
ALTER TABLE `comarca`
  MODIFY `codigo_comarca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tareas`
--
ALTER TABLE `tareas`
  MODIFY `codigo_tareas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
