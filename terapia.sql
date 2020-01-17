-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-01-2020 a las 22:03:51
-- Versión del servidor: 10.1.38-MariaDB
-- Versión de PHP: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `terapia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `atencion`
--

CREATE TABLE `atencion` (
  `ID_ATE` int(12) NOT NULL,
  `FEC_ATE` datetime NOT NULL,
  `CED_EMP_ATE` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `atencion_detalle`
--

CREATE TABLE `atencion_detalle` (
  `ID_DET` int(12) NOT NULL,
  `FEC_DET` datetime NOT NULL,
  `AREA_DET` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `OBJ_DET` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `ACT_DET` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `CED_PAC_PER` int(10) NOT NULL,
  `ID_ATE_PER` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `CED_EMP` int(10) NOT NULL,
  `APE1_EMP` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `APE2_EMP` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `NOM1_EMP` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `NOM2_EMP` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ESP_EMP` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `DIR_EMP` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `TEL_EMP` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `EMAIL_EMP` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientes`
--

CREATE TABLE `pacientes` (
  `CED_PAC` int(10) NOT NULL,
  `APE1_PAC` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `APE2_PAC` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `NOM1_PAC` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `NOM2_PAC` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `FEC_NAC_PAC` date NOT NULL,
  `GEN_PAC` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `FEC_ING_PAC` date NOT NULL,
  `TEL_PAC` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `DIR_PAC` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `MOTIVO_CONSULTA` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `ANTESC_PATOLOG_PERSO` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `ANTESC_PATOLOG_FAMIL` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `DIAGNOSTICO` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `TRATAMIENTO` varchar(500) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID_USU` int(12) NOT NULL,
  `CAR_USU` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CON_USU` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `CED_EMP_PER` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `atencion`
--
ALTER TABLE `atencion`
  ADD PRIMARY KEY (`ID_ATE`),
  ADD KEY `CED_EMP_ATE` (`CED_EMP_ATE`);

--
-- Indices de la tabla `atencion_detalle`
--
ALTER TABLE `atencion_detalle`
  ADD PRIMARY KEY (`ID_DET`),
  ADD KEY `CED_PAC_PER` (`CED_PAC_PER`),
  ADD KEY `ID_ATE_PER` (`ID_ATE_PER`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`CED_EMP`);

--
-- Indices de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`CED_PAC`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID_USU`),
  ADD KEY `CED_EMP_PER` (`CED_EMP_PER`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `atencion`
--
ALTER TABLE `atencion`
  MODIFY `ID_ATE` int(12) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `atencion_detalle`
--
ALTER TABLE `atencion_detalle`
  MODIFY `ID_DET` int(12) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID_USU` int(12) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `atencion`
--
ALTER TABLE `atencion`
  ADD CONSTRAINT `CED_EMP_ATE` FOREIGN KEY (`CED_EMP_ATE`) REFERENCES `empleados` (`CED_EMP`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `atencion_detalle`
--
ALTER TABLE `atencion_detalle`
  ADD CONSTRAINT `CED_PAC_PER` FOREIGN KEY (`CED_PAC_PER`) REFERENCES `pacientes` (`CED_PAC`) ON UPDATE CASCADE,
  ADD CONSTRAINT `ID_ATE_PER` FOREIGN KEY (`ID_ATE_PER`) REFERENCES `atencion` (`ID_ATE`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `CED_EMP_PER` FOREIGN KEY (`CED_EMP_PER`) REFERENCES `empleados` (`CED_EMP`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
