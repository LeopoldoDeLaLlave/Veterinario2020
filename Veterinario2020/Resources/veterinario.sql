-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-04-2020 a las 15:03:25
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
  `motivo` varchar(20) NOT NULL DEFAULT 'otro',
  `cometarios` varchar(100) DEFAULT NULL,
  `tipo_vacuna` varchar(20) DEFAULT NULL,
  `precio` varchar(15) DEFAULT NULL,
  `hora` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cita`
--

INSERT INTO `cita` (`n_cita`, `fecha`, `chip_mascota`, `motivo`, `cometarios`, `tipo_vacuna`, `precio`, `hora`) VALUES
(2, '2020-05-05', NULL, 'Peluquería', NULL, NULL, NULL, '16:30'),
(3, '2020-04-01', 1488542, 'Revisión', 'Realizada limpieza de boca', NULL, '54,38€', '18:00'),
(4, '2019-10-04', 456273, 'Vacuna', NULL, 'Rabia', '20,00€', '17:00'),
(5, '2020-05-06', NULL, 'Revisión', NULL, NULL, NULL, '18:00'),
(6, '2020-05-10', NULL, 'Vacuna', NULL, NULL, NULL, '17:30'),
(7, '2020-05-17', NULL, 'Otros', NULL, NULL, NULL, '19:30'),
(8, '2018-12-03', 42355472, 'Vacuna', NULL, 'Polivalente', '25,00€', '16:00');

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
(453266, '272727T', 'Jayyan', 'Caimás', 'Noruego', 'Verde', 0, 'Vista cansada', '', '2012-06-15', 'Hembra'),
(456273, '12457843N', 'Denver', 'Perro', 'Bulldog francés', 'negro', 0, '', '', '2016-06-22', 'Macho'),
(1488542, '12457843N', 'Parkis', 'Conejo', 'Enano', 'Canela', 1, 'Epilepsia', 'Oxcarbazepina', '2017-09-02', 'Macho'),
(2556467, '272727T', 'Popeye', 'Perro', 'Mastín', 'Blanco', 0, '', '', '2018-07-15', 'Macho'),
(4365377, '37289463D', 'Pepito', 'Camaleón', 'africano', 'Depende', 0, '', '', '2017-02-25', 'Hembra'),
(42355472, '04062016J', 'Neo', 'Perro', 'Chihuahua-peruano', 'Gris-Rosa', 0, '', '', '2015-11-30', 'Macho'),
(64267785, '272727T', 'Sr Cangrejo', 'Nutria', 'Sueca', 'Gris', 0, '', '', '2016-11-15', 'Hembra'),
(64527367, '272727T', 'Willi', 'Conejo', 'datch enano', 'blanco y negro', 0, '', '', '2016-06-01', 'Hembra');

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
('12457843N', 0, 'Mónica', 'Gaztambide', 'monica_lcdp1@gmail.com', '626387528', 'C/ Estocolmo 3, 3ºC. 28087, Madrid', '2019-06-01', '$2a$10$nrEYD/fVPBTrrFT5tpT5U.78mhw6coeEmdRtvU7JrySRboWk1N3Ze'),
('272727T', 0, 'Antonio', 'del Pin', 'tonydelpin97@gmail.com', '6782219283', 'C/ Feijoo 10, 2ºB. 28010', '2020-04-14', '$2a$10$rZQRni2ecGxFao1BUoyVYu2YzcGu3VMbXXMWYiYghczuSusiu9DYC'),
('45275384P', 1, 'Javier', 'del Bosque', 'bosque.j@gmail.com', '645829384', NULL, '2015-07-04', '$2a$10$aThBOsWAUHGfiZ/wsIiD.eiDKDf6goSSTjSKL7vgVMxjrnN48pgGa');

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
  MODIFY `n_cita` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`chip_mascota`) REFERENCES `mascota` (`n_chip`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
