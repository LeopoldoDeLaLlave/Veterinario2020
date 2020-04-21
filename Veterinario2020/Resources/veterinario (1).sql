-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-04-2020 a las 17:31:40
-- Versión del servidor: 10.1.38-MariaDB
-- Versión de PHP: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `veterinario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `n_cita` int(15) NOT NULL,
  `fecha` date NOT NULL,
  `chip_mascota` int(15) DEFAULT NULL,
  `motivo` varchar(20) NOT NULL DEFAULT 'Otro',
  `comentarios` varchar(100) DEFAULT NULL,
  `tipo_vacuna` varchar(20) DEFAULT NULL,
  `precio` varchar(15) DEFAULT NULL,
  `hora` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cita`
--

INSERT INTO `cita` (`n_cita`, `fecha`, `chip_mascota`, `motivo`, `comentarios`, `tipo_vacuna`, `precio`, `hora`) VALUES
(1, '2020-05-17', NULL, 'Revisión', NULL, NULL, NULL, '18:00'),
(2, '2020-05-20', 46828764, 'Vacuna', NULL, NULL, NULL, '16:30'),
(3, '2020-05-15', 345266, 'Peluquería', NULL, NULL, NULL, '17:30'),
(4, '2020-05-24', NULL, 'Otros', NULL, NULL, NULL, '19:00'),
(8, '2020-05-21', NULL, 'Revisión', NULL, NULL, NULL, '20:00'),
(9, '2020-05-22', 2657878, 'Otros', NULL, NULL, NULL, '18:00'),
(10, '2020-05-22', NULL, 'Peluquería', NULL, NULL, NULL, '16:00'),
(11, '2020-04-20', 256456, 'Revisión', NULL, NULL, NULL, '17:00'),
(12, '2020-02-02', 256456, 'Revisión', 'Corte de uñas', '', '53,45€', '16:30'),
(13, '2020-03-03', 53145656, 'Vacuna', '', 'Rabia', '22,00€', '16:30'),
(14, '2020-04-29', 414534, 'Revisión', NULL, NULL, NULL, '18:00'),
(15, '2020-05-08', 53145656, 'Otros', NULL, NULL, NULL, '18:30'),
(16, '2020-07-09', NULL, 'Peluquería', NULL, NULL, NULL, '18:30');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mascota`
--

CREATE TABLE `mascota` (
  `n_chip` int(15) NOT NULL,
  `propietario` varchar(20) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `especie` varchar(20) NOT NULL,
  `raza` varchar(20) NOT NULL,
  `color` varchar(30) NOT NULL,
  `esterilizado` tinyint(1) NOT NULL DEFAULT '0',
  `patologias` varchar(100) DEFAULT NULL,
  `medicamentos` varchar(100) DEFAULT NULL,
  `f_nacimiento` date NOT NULL DEFAULT '2020-01-01',
  `sexo` varchar(6) DEFAULT 'Macho'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mascota`
--

INSERT INTO `mascota` (`n_chip`, `propietario`, `nombre`, `especie`, `raza`, `color`, `esterilizado`, `patologias`, `medicamentos`, `f_nacimiento`, `sexo`) VALUES
(256456, '12457843N', 'Zanahorias', 'Conejos', 'Enano', 'Canela', 0, '', '', '2018-09-12', 'Macho'),
(345266, '34748791P', 'Nova', 'Gato', 'Mestizo', 'Atigrado', 0, '', '', '2018-01-19', 'Hembra'),
(414534, '12457843N', 'Denver', 'Perro', 'Bulldog', 'Negro', 0, '', '', '2015-06-12', 'Macho'),
(2657878, '17283522H', 'Fiona', 'Camaleón', 'Nórdico', 'Depende', 0, 'Daltonismo', '', '2016-07-13', 'Macho'),
(4351543, '27272727T', 'Willi', 'Conejo', 'Dutch enano', 'Blanco y negro', 0, '', '', '2014-05-06', 'Hembra'),
(4552727, '17283522H', 'Stuart', 'Hamster', 'ruso', 'Blanco/BEige', 0, '', '', '2017-09-26', 'Macho'),
(5262577, '17283522H', 'Benito', 'Gato', 'Sphynx', 'Rosa', 0, '', '', '2018-12-29', 'Hembra'),
(6556254, '47839046Y', 'Ipa', 'Perro', 'GAlgo', 'Marrón', 0, '', '', '2018-02-11', 'Hembra'),
(45367897, '17283522H', 'Firulais', 'Perro', 'Galgo', 'Atigrado', 0, 'Leishmaniosis', 'Glucantime', '2002-11-15', 'Macho'),
(46828764, '17283522H', 'Pepito', 'Codorniz', 'Ibérica', 'Pardo', 0, '', '', '2018-04-13', 'Macho'),
(53145656, '04062016J', 'Neo', 'Perro', 'Chihuahua-peruano', 'gris/rosa', 0, 'Piedras en la vejiga', '', '2015-11-11', 'Macho'),
(54165117, '17283522H', 'Spiderman', 'Tortuga', 'Californiana', 'Verde', 0, '', '', '2002-11-15', 'Hembra'),
(56772657, '17283522H', 'Maraca', 'Caballo', 'Árabe', 'Isabelino', 0, '', '', '2011-08-26', 'Hembra'),
(62578584, '17283522H', 'Paco', 'Loro', 'Argentino', 'Verde-rojo-azul', 0, '', '', '2014-04-01', 'Macho');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `dni` varchar(20) NOT NULL,
  `administrador` tinyint(1) NOT NULL DEFAULT '0',
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `telefono` varchar(30) NOT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `fecha_alta` date NOT NULL,
  `contrasena` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`dni`, `administrador`, `nombre`, `apellido`, `email`, `telefono`, `direccion`, `fecha_alta`, `contrasena`) VALUES
('04062016J', 0, 'Berta', 'Sánchez', 'b.sanpi@gmail.com', '691258587', 'C/Fuencarral 95 1ºB Izq. 28004, Madrid', '2018-11-21', '$2a$10$nO/EMtTMFLkZTmL55gKIweHUI/Xgk6RXVOn1XGggqyv7Yl/hdH0cu'),
('12457843N', 0, 'Mónica', 'Gaztambide', 'monica_lcdp1@gmail.com', '626387528', 'C/ Estocolmo 3, 3ºC. 28087, Madrid', '2019-06-01', '$2a$10$.Mw64b9r7DHPsQ7s/CVq1ubTqDZjYaC6UaE1HLWH361OAbry/8A0y'),
('17283522H', 0, 'Pedro', 'Vallehermoso', 'pedrovallher@hotmail.com', '678947473', 'C/ Lavapiés 7, 4º interior izquierda. 28002, Madri', '2020-04-21', '$2a$10$wQ.MThs1pumNjUCzT3sjtuW4oHYzHAqQvAPsI5C2yr15o/LhE6wiu'),
('27272727T', 0, 'Antonio', 'del Pin', 'tonydelpin97@gmail.com', '678392836', 'C/Feijoo 10, 2ºB. MAdrid 28010', '2020-04-16', '$2a$10$TFzu2up4MEGfrASC9POLoOg21kM3tmFz4fdyeeHvZO2m.M9BUgPuu'),
('34748791P', 0, 'Jorge', 'Escorial', 'jorgep91@gmail.com', '726738212', 'C/ de la oca 58, 1º Izquierda. 28076 Madrid', '2020-04-19', '$2a$10$bZs5ElmvYgIgkVOa7A7EQe0gq9h5K4rdCCKcHHLcit8gZg9XttgMu'),
('45275384P', 1, 'Javier', 'del Bosque', 'bosque.j@gmail.com', '645829384', NULL, '2015-07-04', '$2a$10$aThBOsWAUHGfiZ/wsIiD.eiDKDf6goSSTjSKL7vgVMxjrnN48pgGa'),
('47839046Y', 0, 'Pilar', 'Escribá', 'escribapil@hotmail.com', '680020035', 'C/Fernández de los Ríos 77, bajo C. 28009, Madrid', '2020-04-21', '$2a$10$ofDDraV/eHaelNX.7vn4.eHDDDJYlflbKpSwut4qW259qF8f19EXy');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`n_cita`),
  ADD KEY `cita_ibfk_1` (`chip_mascota`);

--
-- Indices de la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD PRIMARY KEY (`n_chip`),
  ADD KEY `propietario` (`propietario`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`dni`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `n_cita` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`chip_mascota`) REFERENCES `mascota` (`n_chip`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Filtros para la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD CONSTRAINT `mascota_ibfk_1` FOREIGN KEY (`propietario`) REFERENCES `usuario` (`dni`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
