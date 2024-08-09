-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 07-08-2024 a las 23:36:20
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.1.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inventario`
--

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `MayorCompraPartes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MayorCompraPartes` (IN `fecha_inicio` DATE, IN `fecha_final` DATE)   BEGIN 
    SELECT partes.nombre, marca.nombre AS marca, COUNT(*) AS Repeticiones 
    FROM partes 
    INNER JOIN marca ON partes.marca = marca.id_marca 
    WHERE partes.fecha_compra BETWEEN fecha_inicio AND fecha_final
    GROUP BY partes.nombre, marca.nombre
    ORDER BY Repeticiones DESC
    LIMIT 3;
END$$

DROP PROCEDURE IF EXISTS `MayorCompraVehiculos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MayorCompraVehiculos` (IN `fecha_inicio` DATE, IN `fecha_final` DATE)   BEGIN
    SELECT vehiculos.nombre, marca.nombre AS marca, COUNT(*) AS Repeticiones 
    FROM vehiculos 
    INNER JOIN marca ON vehiculos.marca = marca.id_marca 
    WHERE vehiculos.fecha_compra BETWEEN fecha_inicio AND fecha_final
    GROUP BY vehiculos.nombre, marca.nombre
    ORDER BY Repeticiones DESC
    LIMIT 3;
END$$

DROP PROCEDURE IF EXISTS `ObtenerCantidadVehiculos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCantidadVehiculos` (IN `fecha_inicio` DATE, IN `fecha_fin` DATE)   BEGIN
    SELECT 
        v.nombre AS nombre_vehiculo,
        m.nombre AS nombre_marca,
        COUNT(*) AS cantidad
    FROM 
        inventario AS i
    LEFT JOIN 
        vehiculos AS v ON v.id_vehiculo = i.id_elemento
    LEFT JOIN 
        marca AS m ON m.id_marca = v.marca
    JOIN  
        vehiculos ON i.id_elemento = vehiculos.id_vehiculo
    WHERE 
        i.tipo = 'vehiculo' AND vehiculos.fecha_compra BETWEEN fecha_inicio AND fecha_fin
    GROUP BY
        v.nombre,
        m.nombre
    ORDER BY
        cantidad DESC;
END$$

DROP PROCEDURE IF EXISTS `obtenerInventarioPartes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtenerInventarioPartes` (IN `fecha_inicio` DATE, IN `fecha_fin` DATE)   BEGIN
    SELECT 
        p.nombre AS nombre_parte,
        m.nombre AS nombre_marca,
        COUNT(*) AS cantidad
    FROM 
        inventario AS i
    LEFT JOIN 
        partes AS p ON p.id_parte = i.id_elemento
    LEFT JOIN 
        marca AS m ON m.id_marca = p.marca
    JOIN  
        partes ON i.id_elemento = partes.id_parte
    WHERE 
        i.tipo = 'parte' AND partes.fecha_compra BETWEEN fecha_inicio AND fecha_fin
    GROUP BY
        p.nombre,
        m.nombre
    ORDER BY
        cantidad DESC;
END$$

DROP PROCEDURE IF EXISTS `ObtenerTopPartes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerTopPartes` (IN `fecha_inicio` DATE, IN `fecha_fin` DATE)   BEGIN
    SELECT partes.nombre, marca.nombre AS nombre_marca, COUNT(*) AS Repeticiones
    FROM partes
    INNER JOIN marca ON partes.marca = marca.id_marca
    WHERE partes.fecha_compra BETWEEN fecha_inicio AND fecha_fin
    GROUP BY partes.nombre, partes.marca
    ORDER BY Repeticiones DESC
    LIMIT 3;
END$$

DROP PROCEDURE IF EXISTS `ObtenerTopVehiculos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerTopVehiculos` (IN `fecha_inicio` DATE, IN `fecha_fin` DATE)   BEGIN
    SELECT vehiculos.nombre, marca.nombre AS nombre_marca, COUNT(*) AS Repeticiones
    FROM vehiculos
    INNER JOIN marca ON vehiculos.marca = marca.id_marca
    WHERE vehiculos.fecha_compra BETWEEN fecha_inicio AND fecha_fin
    GROUP BY vehiculos.nombre, vehiculos.marca
    ORDER BY Repeticiones DESC
    LIMIT 3;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargo`
--

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE IF NOT EXISTS `cargo` (
  `id_cargo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  PRIMARY KEY (`id_cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `nombre`) VALUES
(1, 'Gerente'),
(2, 'Vendedor Vehiculos\r\n'),
(3, 'Vendedor Partes\r\n');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_clientes` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  `Apellido` varchar(255) NOT NULL,
  PRIMARY KEY (`id_clientes`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_clientes`, `Nombre`, `Apellido`) VALUES
(13, 'Luis Eduardo', 'López Orantes \r\n'),
(15, 'Luis Eduardo', 'López Orantes \r\n'),
(17, 'Luis Eduardo', 'Lopez Orantes'),
(18, 'Luis Eduardo ', 'Lopez Orantes'),
(19, 'Wendy Sucibel', 'Pone Pineda'),
(20, 'Napoleon Amilcar ', 'Lopez Motho'),
(21, 'Napoleon ', 'Lopez');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `detallepartes`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `detallepartes`;
CREATE TABLE IF NOT EXISTS `detallepartes` (
`Costo_venta` varchar(30)
,`fecha_venta` date
,`Nombre_Cliente` varchar(511)
,`Nombre_Empleado` varchar(511)
,`NumSerie` varchar(100)
,`Producto` varchar(100)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `detallevehiculos`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `detallevehiculos`;
CREATE TABLE IF NOT EXISTS `detallevehiculos` (
`Costo_venta` varchar(30)
,`Fecha_venta` date
,`Nombre_Cliente` varchar(511)
,`Nombre_Empleado` varchar(511)
,`NumSerie` varchar(255)
,`Producto` varchar(255)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `egresos`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `egresos`;
CREATE TABLE IF NOT EXISTS `egresos` (
`Ingreso_ventas` decimal(34,2)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empledos`
--

DROP TABLE IF EXISTS `empledos`;
CREATE TABLE IF NOT EXISTS `empledos` (
  `id_empledos` int NOT NULL AUTO_INCREMENT,
  `id_usuarios` int NOT NULL,
  `rol` int NOT NULL,
  PRIMARY KEY (`id_empledos`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `empledos`
--

INSERT INTO `empledos` (`id_empledos`, `id_usuarios`, `rol`) VALUES
(16, 123, 1),
(17, 124, 2),
(18, 125, 1),
(31, 31, 0),
(32, 32, 0),
(33, 33, 3),
(34, 130, 1),
(35, 131, 1),
(36, 132, 1),
(37, 133, 3),
(38, 134, 1),
(39, 135, 2),
(40, 136, 3);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `ingresos`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `ingresos`;
CREATE TABLE IF NOT EXISTS `ingresos` (
`Ingreso_ventas` double
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

DROP TABLE IF EXISTS `inventario`;
CREATE TABLE IF NOT EXISTS `inventario` (
  `id_inventario` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(10) NOT NULL,
  `id_elemento` int NOT NULL,
  `estado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_inventario`),
  KEY `idx_id_elemento` (`id_elemento`)
) ENGINE=InnoDB AUTO_INCREMENT=241 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`id_inventario`, `tipo`, `id_elemento`, `estado`) VALUES
(21, 'Vehiculo', 7, 'Vendido'),
(22, 'Vehiculo', 8, 'Vendido'),
(24, 'Vehiculo', 10, 'Vendido'),
(25, 'Vehiculo', 11, 'Vendido'),
(31, 'Vehiculo', 12, ''),
(32, 'Vehiculo', 13, 'Vendido'),
(33, 'Vehiculo', 14, 'Disponible'),
(34, 'Vehiculo', 15, 'Disponible'),
(35, 'Vehiculo', 76, 'Disponible'),
(36, 'Vehiculo', 77, 'Disponible'),
(37, 'Vehiculo', 78, 'Disponible'),
(38, 'Vehiculo', 79, 'Disponible'),
(39, 'Vehiculo', 80, 'Disponible'),
(40, 'Vehiculo', 81, 'Disponible'),
(41, 'Vehiculo', 82, 'Disponible'),
(42, 'Vehiculo', 83, 'Disponible'),
(43, 'Vehiculo', 84, 'Disponible'),
(46, 'Vehiculo', 87, 'Disponible'),
(47, 'Vehiculo', 88, 'Disponible'),
(48, 'Vehiculo', 89, 'Disponible'),
(49, 'Vehiculo', 90, 'Disponible'),
(72, 'Vehiculo', 122, 'Disponible'),
(73, 'Vehiculo', 123, 'Disponible'),
(74, 'Vehiculo', 124, 'Disponible'),
(75, 'Vehiculo', 125, 'Disponible'),
(76, 'Vehiculo', 126, 'Disponible'),
(77, 'Vehiculo', 127, 'Disponible'),
(78, 'Vehiculo', 128, 'Disponible'),
(79, 'Vehiculo', 129, 'Disponible'),
(80, 'Vehiculo', 130, 'Disponible'),
(81, 'Vehiculo', 131, 'Disponible'),
(82, 'Vehiculo', 132, 'Disponible'),
(83, 'Vehiculo', 133, 'Disponible'),
(84, 'Vehiculo', 134, 'Disponible'),
(85, 'Vehiculo', 135, 'Disponible'),
(86, 'Vehiculo', 136, 'Disponible'),
(102, 'Vehiculo', 138, 'Disponible'),
(103, 'Vehiculo', 139, 'Disponible'),
(104, 'Vehiculo', 140, 'Disponible'),
(105, 'Vehiculo', 141, 'Disponible'),
(106, 'Vehiculo', 142, 'Disponible'),
(107, 'Vehiculo', 143, 'Disponible'),
(108, 'Vehiculo', 144, 'Disponible'),
(109, 'Vehiculo', 145, 'Disponible'),
(110, 'Vehiculo', 146, 'Disponible'),
(111, 'Vehiculo', 147, 'Disponible'),
(112, 'Vehiculo', 148, 'Disponible'),
(113, 'Vehiculo', 149, 'Disponible'),
(114, 'Vehiculo', 150, 'Disponible'),
(115, 'Vehiculo', 151, 'Disponible'),
(117, 'Parte', 301, 'Disponible'),
(118, 'Parte', 302, 'Disponible'),
(119, 'Parte', 303, 'Disponible'),
(120, 'Parte', 304, 'Disponible'),
(121, 'Parte', 305, 'Disponible'),
(122, 'Parte', 306, 'Disponible'),
(123, 'Parte', 307, 'Disponible'),
(124, 'Parte', 308, 'Disponible'),
(125, 'Parte', 309, 'Disponible'),
(126, 'Parte', 310, 'Disponible'),
(127, 'Parte', 311, 'Disponible'),
(128, 'Parte', 312, 'Disponible'),
(129, 'Parte', 313, 'Disponible'),
(130, 'Parte', 314, 'Vendido'),
(131, 'Parte', 315, 'Disponible'),
(132, 'Parte', 316, 'Disponible'),
(133, 'Parte', 317, 'Disponible'),
(134, 'Parte', 318, 'Disponible'),
(135, 'Parte', 319, 'Disponible'),
(136, 'Parte', 320, 'Disponible'),
(137, 'Parte', 321, 'Vendido'),
(138, 'Parte', 322, 'Vendido'),
(139, 'Parte', 323, 'Vendido'),
(140, 'Parte', 324, 'Vendido'),
(141, 'Parte', 325, 'Vendido'),
(142, 'Parte', 326, 'Vendido'),
(143, 'Parte', 327, 'Vendido'),
(144, 'Parte', 328, 'Vendido'),
(145, 'Parte', 329, 'Vendido'),
(146, 'Parte', 330, 'Vendido'),
(237, 'Parte', 331, 'Disponible'),
(238, 'Vehiculo', 165, 'Disponible'),
(239, 'Parte', 332, 'Disponible'),
(240, 'Vehiculo', 166, 'Disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

DROP TABLE IF EXISTS `marca`;
CREATE TABLE IF NOT EXISTS `marca` (
  `id_marca` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca`, `nombre`) VALUES
(17, 'Honda'),
(18, 'Nissan'),
(19, 'Ford'),
(21, 'Volkswagen'),
(22, 'BMW');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `masvendidospartes`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `masvendidospartes`;
CREATE TABLE IF NOT EXISTS `masvendidospartes` (
`Marca_producto` varchar(255)
,`Nombre_producto` varchar(100)
,`Repeticiones` bigint
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `masvendidosvehiculos`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `masvendidosvehiculos`;
CREATE TABLE IF NOT EXISTS `masvendidosvehiculos` (
`Marca_producto` varchar(255)
,`Nombre_producto` varchar(255)
,`Repeticiones` bigint
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `mayorcompraparte`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `mayorcompraparte`;
CREATE TABLE IF NOT EXISTS `mayorcompraparte` (
`nombre_marca` varchar(255)
,`nombre_parte` varchar(100)
,`Repeticiones` bigint
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `mayorcomprvehiculo`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `mayorcomprvehiculo`;
CREATE TABLE IF NOT EXISTS `mayorcomprvehiculo` (
`marca` varchar(255)
,`nombre` varchar(255)
,`Repeticiones` bigint
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `partes`
--

DROP TABLE IF EXISTS `partes`;
CREATE TABLE IF NOT EXISTS `partes` (
  `id_parte` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `modelo` varchar(100) DEFAULT NULL,
  `marca` int DEFAULT NULL,
  `numeroSerie` varchar(100) DEFAULT NULL,
  `anio` int DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `proveedor` int DEFAULT NULL,
  `fecha_compra` date DEFAULT NULL,
  PRIMARY KEY (`id_parte`),
  KEY `marca` (`marca`),
  KEY `proveedor` (`proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=333 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `partes`
--

INSERT INTO `partes` (`id_parte`, `nombre`, `modelo`, `marca`, `numeroSerie`, `anio`, `costo`, `proveedor`, `fecha_compra`) VALUES
(301, 'Llanta', 'Standard', 17, 'LLNT123', 2023, '200.00', 1, '2024-03-31'),
(302, 'Filtro de aceite', 'Standard', 17, 'FILT123', 2022, '15.00', 1, '2024-03-31'),
(303, 'Batería', 'Standard', 17, 'BAT123', 2021, '100.00', 1, '2024-03-31'),
(304, 'Radiador', 'Standard', 17, 'RAD123', 2023, '300.00', 1, '2024-03-31'),
(305, 'Amortiguador', 'Standard', 17, 'AMOR123', 2024, '150.00', 1, '2024-03-31'),
(306, 'Pastillas de freno', 'Standard', 17, 'PFRN123', 2022, '50.00', 1, '2024-03-31'),
(307, 'Espejo lateral', 'Standard', 17, 'ESPL123', 2021, '80.00', 1, '2024-03-31'),
(308, 'Faros delanteros', 'Standard', 17, 'FARO123', 2023, '120.00', 1, '2024-03-31'),
(309, 'Alternador', 'Standard', 17, 'ALTN123', 2024, '180.00', 1, '2024-03-31'),
(310, 'Bobina de encendido', 'Standard', 17, 'BENC123', 2022, '70.00', 1, '2024-03-31'),
(311, 'Llanta', 'Standard', 18, 'LLNT456', 2023, '200.00', 2, '2024-03-31'),
(312, 'Filtro de aceite', 'Standard', 18, 'FILT456', 2022, '15.00', 2, '2024-03-31'),
(313, 'Batería', 'Standard', 17, 'BAT456ada', 2021, '100.00', 1, '2024-03-07'),
(314, 'Radiador', 'Standard', 18, 'RAD456', 2023, '300.00', 2, '2024-03-31'),
(315, 'Amortiguador', 'Standard', 18, 'AMOR456', 2024, '150.00', 2, '2024-03-31'),
(316, 'Pastillas de freno', 'Standard', 18, 'PFRN456', 2022, '50.00', 2, '2024-03-31'),
(317, 'Espejo lateral', 'Standard', 18, 'ESPL456', 2021, '80.00', 2, '2024-03-31'),
(318, 'Faros delanteros', 'Standard', 18, 'FARO456', 2023, '120.00', 2, '2024-03-31'),
(319, 'Alternador', 'Standard', 18, 'ALTN456', 2024, '180.00', 2, '2024-03-31'),
(320, 'Bobina de encendido', 'Standard', 18, 'BENC456', 2022, '70.00', 2, '2024-03-31'),
(321, 'Llanta', 'Standard', 19, 'LLNT789', 2023, '200.00', 3, '2024-03-31'),
(322, 'Filtro de aceite', 'Standard', 19, 'FILT789', 2022, '15.00', 3, '2024-03-31'),
(323, 'Batería', 'Standard', 19, 'BAT789', 2021, '100.00', 3, '2024-03-31'),
(324, 'Radiador', 'Standard', 19, 'RAD789', 2023, '300.00', 3, '2024-03-31'),
(325, 'Amortiguador', 'Standard', 19, 'AMOR789', 2024, '150.00', 3, '2024-03-31'),
(326, 'Pastillas de freno', 'Standard', 19, 'PFRN789', 2022, '50.00', 3, '2024-03-31'),
(327, 'Espejo lateral', 'Standard', 19, 'ESPL789', 2021, '80.00', 3, '2024-03-31'),
(328, 'Faros delanteros', 'Standard', 19, 'FARO789', 2023, '120.00', 3, '2024-03-31'),
(329, 'Alternador', 'Standard', 19, 'ALTN789', 2024, '180.00', 3, '2024-03-31'),
(330, 'Bobina de encendido', 'Standard', 19, 'BENC789', 2022, '70.00', 3, '2024-03-31'),
(331, 'dad', 'dad', 17, 'dad', 2003, '3424.00', 1, '2024-03-15'),
(332, 'dadada', 'adadad', 17, 'dad2', 2023, '2023.00', 1, '2024-03-07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE IF NOT EXISTS `proveedor` (
  `Id_proveedor` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`Id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`Id_proveedor`, `nombre`) VALUES
(1, 'Proveedor B'),
(2, 'Proveedor A'),
(3, 'Proveedor C'),
(6, 'Amilcar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

DROP TABLE IF EXISTS `rol`;
CREATE TABLE IF NOT EXISTS `rol` (
  `id_rol` int NOT NULL,
  `nombre` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `rol`
--

INSERT INTO `rol` (`id_rol`, `nombre`) VALUES
(1, 'Gerente'),
(2, 'Vendedor Vehiculos'),
(3, 'Vendedor Partes');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `id_cargo` int NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `usuario` varchar(255) NOT NULL,
  `contrasenia` varchar(255) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=137 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `id_cargo`, `nombre`, `apellidos`, `usuario`, `contrasenia`) VALUES
(126, 1, 'Eduardo', 'Eduardo', 'Eduardo', 'Eduardo'),
(129, 2, 'Juan', 'Juan', 'Juan', 'Juan'),
(135, 2, 'Amilcar', 'Amilcar', 'Amilcar', 'Amilcar'),
(136, 3, 'Usuario', 'Usuario', 'Usuario', 'Usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculos`
--

DROP TABLE IF EXISTS `vehiculos`;
CREATE TABLE IF NOT EXISTS `vehiculos` (
  `id_vehiculo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `modelo` varchar(255) NOT NULL,
  `marca` int NOT NULL,
  `numeroSerie` varchar(255) NOT NULL,
  `anio` varchar(255) NOT NULL,
  `costo` decimal(10,0) NOT NULL,
  `proveedor` int NOT NULL,
  `fecha_compra` date NOT NULL,
  PRIMARY KEY (`id_vehiculo`),
  KEY `marca` (`marca`),
  KEY `proveedor` (`proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=167 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `vehiculos`
--

INSERT INTO `vehiculos` (`id_vehiculo`, `nombre`, `modelo`, `marca`, `numeroSerie`, `anio`, `costo`, `proveedor`, `fecha_compra`) VALUES
(7, 'BMW X5', 'X5', 22, 'BMW142', '2021', '65', 1, '2024-03-07'),
(8, 'Honda Civic', 'Civic', 17, 'Honda123', '2022', '25', 1, '2024-03-07'),
(10, 'Honda CR-V', 'CR-V', 17, 'HondaUYHA', '2023', '35', 1, '2024-03-05'),
(11, 'BMW Serie 3', 'Serie 3', 22, 'BM123', '2022', '45000', 1, '2024-03-07'),
(12, 'BMW X5', 'X5', 22, 'BMW142', '2021', '65000', 1, '2024-03-07'),
(13, 'Honda Civic', 'Civic', 17, 'Honda123', '2022', '25000', 1, '2024-03-07'),
(14, 'Honda Accord', 'Honda', 17, 'Honda92l', '2021', '30000', 1, '2024-03-05'),
(15, 'Honda CR-V', 'CR-V', 17, 'HondaUYHA', '2023', '35000', 1, '2024-03-05'),
(76, 'Lexus RX', 'RX', 17, 'Lexus123', '2023', '55000', 1, '2024-03-16'),
(77, 'Lexus ES', 'ES', 17, 'Lexus456', '2022', '50000', 1, '2024-03-16'),
(78, 'Hyundai Sonata', 'Sonata', 17, 'Hyundai123', '2021', '30000', 1, '2024-03-17'),
(79, 'Hyundai Tucson', 'Tucson', 17, 'Hyundai456', '2023', '35000', 1, '2024-03-17'),
(80, 'Kia Optima', 'Optima', 17, 'Kia123', '2022', '28000', 1, '2024-03-18'),
(81, 'Kia Sorento', 'Sorento', 17, 'Kia456', '2024', '32000', 1, '2024-03-18'),
(82, 'Subaru Outback', 'Outback', 17, 'Subaru123', '2024', '30000', 1, '2024-03-01'),
(83, 'Subaru Forester', 'Forester', 17, 'Subaru456', '2021', '25000', 1, '2024-03-19'),
(84, 'Mazda CX-5', 'CX-5', 17, 'Mazda123', '2022', '28000', 1, '2024-03-20'),
(87, 'Jeep Wrangler', 'Wrangler', 17, 'Jeep456', '2024', '55000', 1, '2024-03-21'),
(88, 'Ram 1500', '1500', 17, '424434', '2023', '40000', 1, '2024-03-01'),
(89, 'Ram 2500', '2500', 17, 'Ram456', '2021', '50000', 1, '2024-03-22'),
(90, 'GMC Sierra', 'Sierra', 17, 'GMC123', '2022', '45000', 1, '2024-03-23'),
(121, 'Lexus RX', 'RX', 17, 'Lexus123', '2023', '55000', 1, '2024-03-16'),
(122, 'Lexus ES', 'ES', 17, 'Lexus456', '2022', '50000', 1, '2024-03-16'),
(123, 'Hyundai Sonata', 'Sonata', 17, 'Hyundai123', '2021', '30000', 1, '2024-03-17'),
(124, 'Hyundai Tucson', 'Tucson', 17, 'Hyundai456', '2023', '35000', 1, '2024-03-17'),
(125, 'Kia Optima', 'Optima', 17, 'Kia123', '2022', '28000', 1, '2024-03-18'),
(126, 'Kia Sorento', 'Sorento', 17, 'Kia456', '2024', '32000', 1, '2024-03-18'),
(127, 'Subaru Outback', 'Outback', 17, 'Subaru123', '2023', '30000', 1, '2024-03-19'),
(128, 'Subaru Forester', 'Forester', 17, 'Subaru456', '2021', '25000', 1, '2024-03-19'),
(129, 'Mazda CX-5', 'CX-5', 17, 'Mazda123', '2022', '28000', 1, '2024-03-20'),
(130, 'Mazda3', 'Mazda3', 17, 'Mazda456', '2023', '26000', 1, '2024-03-20'),
(131, 'Jeep Grand Cherokee', 'Grand Cherokee', 17, 'Jeep123', '2022', '45000', 1, '2024-03-21'),
(132, 'Jeep Wrangler', 'Wrangler', 17, 'Jeep456', '2024', '55000', 1, '2024-03-21'),
(133, 'Ram 1500', '1500', 17, 'Ram123', '2023', '40000', 1, '2024-03-22'),
(134, 'Ram 2500', '2500', 17, 'Ram456', '2021', '50000', 1, '2024-03-22'),
(135, 'GMC Sierra', 'Sierra', 17, 'GMC123', '2022', '45000', 1, '2024-03-23'),
(136, 'Ford Explorer', 'Explorer', 19, 'Ford789', '2023', '40000', 1, '2024-03-24'),
(137, 'Ford Escape', 'Escape', 19, 'Fordabc', '2022', '35000', 1, '2024-03-24'),
(138, 'Ford Edge', 'Edge', 19, 'Forddef', '2021', '30000', 1, '2024-03-25'),
(139, 'Ford Fusion', 'Fusion', 19, 'Fordghi', '2023', '28000', 1, '2024-03-25'),
(140, 'Ford Ranger', 'Ranger', 19, 'Fordjkl', '2024', '32000', 1, '2024-03-26'),
(141, 'Ford Bronco', 'Bronco', 19, 'Fordmno', '2022', '45000', 1, '2024-03-26'),
(142, 'Ford F-150', 'F-150', 19, 'Fordpqr', '2023', '50000', 1, '2024-03-27'),
(143, 'Ford Mustang Mach-E', 'Mustang Mach-E', 19, 'Fords12', '2021', '60000', 1, '2024-03-27'),
(144, 'Ford Fiesta', 'Fiesta', 19, 'Fordtuv', '2023', '20000', 1, '2024-03-28'),
(145, 'Ford EcoSport', 'EcoSport', 19, 'Fordwxy', '2022', '25000', 1, '2024-03-28'),
(146, 'Ford Transit Connect', 'Transit Connect', 19, 'Fordzab', '2021', '30000', 1, '2024-03-29'),
(147, 'Ford Expedition', 'Expedition', 19, 'Ford123', '2023', '55000', 1, '2024-03-29'),
(148, 'Ford Taurus', 'Taurus', 19, 'Ford456', '2024', '40000', 1, '2024-03-30'),
(149, 'Ford Focus RS', 'Focus RS', 19, 'Ford789', '2022', '35000', 1, '2024-03-30'),
(150, 'Ford GT', 'GT', 19, 'Fordabc', '2021', '70000', 1, '2024-03-31'),
(151, 'Nissan Sentra', 'Sentra', 18, 'Nissan123', '2022', '23000', 2, '2024-03-13'),
(152, 'Nissan Sentra', 'Sentra', 18, 'Nissan456', '2021', '23000', 2, '2024-03-13'),
(153, 'Nissan Sentra', 'Sentra', 18, 'Nissan789', '2023', '23000', 2, '2024-03-13'),
(154, 'Nissan Sentra', 'Sentra', 18, 'Nissanabc', '2024', '23000', 2, '2024-03-13'),
(155, 'Nissan Sentra', 'Sentra', 18, 'Nissanxyz', '2022', '23000', 2, '2024-03-13'),
(156, 'Nissan Sentra', 'Sentra', 18, 'Nissanpqr', '2021', '23000', 2, '2024-03-13'),
(157, 'Nissan Sentra', 'Sentra', 18, 'Nissanmno', '2023', '23000', 2, '2024-03-13'),
(158, 'Nissan Sentra', 'Sentra', 18, 'Nissanstu', '2024', '23000', 2, '2024-03-13'),
(159, 'Nissan Sentra', 'Sentra', 18, 'Nissanwxy', '2022', '23000', 2, '2024-03-13'),
(160, 'Nissan Sentra', 'Sentra', 18, 'Nissanghi', '2021', '23000', 2, '2024-03-13'),
(161, 'Nissan Sentra', 'Sentra', 18, 'Nissanjkl', '2023', '23000', 2, '2024-03-13'),
(162, 'Nissan Sentra', 'Sentra', 18, 'Nissanvwx', '2024', '23000', 2, '2024-03-13'),
(163, 'Nissan Sentra', 'Sentra', 18, 'Nissan123', '2022', '23000', 2, '2024-03-13'),
(164, 'Nissan Sentra', 'Sentra', 18, 'Nissan456', '2021', '23000', 2, '2024-03-13'),
(165, 'dad', 'dad', 17, 'dad', '2434', '2434', 1, '2024-03-01'),
(166, 'Nissa', 'Nissa', 19, 'Nissa', '2024', '3000', 6, '2024-03-08');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_venta` int NOT NULL AUTO_INCREMENT,
  `id_vendedor` int DEFAULT NULL,
  `id_cliente` int DEFAULT NULL,
  `id_elemento_inventario` int DEFAULT NULL,
  `tipo_elemento` varchar(10) DEFAULT NULL,
  `Costo` varchar(30) NOT NULL,
  `fecha_venta` date DEFAULT NULL,
  PRIMARY KEY (`id_venta`),
  KEY `id_vendedor` (`id_vendedor`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_elemento_inventario` (`id_elemento_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id_venta`, `id_vendedor`, `id_cliente`, `id_elemento_inventario`, `tipo_elemento`, `Costo`, `fecha_venta`) VALUES
(1, 17, 13, 7, 'Vehiculo', '3000', '2024-03-01'),
(2, 17, 13, 8, 'Vehiculo', '3000', '2024-03-06'),
(3, 17, 13, 10, 'Vehiculo', '3000', '2024-03-05'),
(4, 31, 13, 14, 'Vehiculo', '300000', '2024-03-08'),
(6, 17, 13, 11, 'Vehiculo', '300000', '2024-03-07'),
(7, 17, 21, 13, 'Vehiculo', '30000', '2024-03-01');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_inventario_partes`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_inventario_partes`;
CREATE TABLE IF NOT EXISTS `vista_inventario_partes` (
`estado` varchar(20)
,`id_inventario` int
,`modelo_elemento` varchar(100)
,`nombre_elemento` varchar(100)
,`nombre_marca` varchar(255)
,`numero_serie` varchar(100)
,`tipo` varchar(10)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_inventario_vehiculo`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_inventario_vehiculo`;
CREATE TABLE IF NOT EXISTS `vista_inventario_vehiculo` (
`estado` varchar(20)
,`id_inventario` int
,`modelo_elemento` varchar(255)
,`nombre_elemento` varchar(255)
,`nombre_marca` varchar(255)
,`numero_serie` varchar(255)
,`tipo` varchar(10)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_view`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_view`;
CREATE TABLE IF NOT EXISTS `vista_view` (
`Elemento` varchar(255)
,`estado` varchar(20)
,`id_inventario` int
,`Marca` varchar(11)
,`Modelo` varchar(255)
,`NumeroSerie` varchar(255)
,`tipo` varchar(10)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `detallepartes`
--
DROP TABLE IF EXISTS `detallepartes`;

DROP VIEW IF EXISTS `detallepartes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `detallepartes`  AS SELECT concat(`u`.`nombre`,' ',`u`.`apellidos`) AS `Nombre_Empleado`, `ve`.`fecha_venta` AS `fecha_venta`, concat(`c`.`Nombre`,' ',`c`.`Apellido`) AS `Nombre_Cliente`, `p`.`nombre` AS `Producto`, `p`.`numeroSerie` AS `NumSerie`, `ve`.`Costo` AS `Costo_venta` FROM ((((`usuarios` `u` join `empledos` `e` on((`u`.`id_usuario` = `e`.`id_usuarios`))) join `ventas` `ve` on((`e`.`id_empledos` = `ve`.`id_vendedor`))) join `partes` `p` on((`ve`.`id_elemento_inventario` = `p`.`id_parte`))) left join `clientes` `c` on((`ve`.`id_cliente` = `c`.`id_clientes`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `detallevehiculos`
--
DROP TABLE IF EXISTS `detallevehiculos`;

DROP VIEW IF EXISTS `detallevehiculos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `detallevehiculos`  AS SELECT concat(`u`.`nombre`,' ',`u`.`apellidos`) AS `Nombre_Empleado`, `ve`.`fecha_venta` AS `Fecha_venta`, concat(`c`.`Nombre`,' ',`c`.`Apellido`) AS `Nombre_Cliente`, `v`.`nombre` AS `Producto`, `v`.`numeroSerie` AS `NumSerie`, `ve`.`Costo` AS `Costo_venta` FROM ((((`usuarios` `u` join `empledos` `e` on((`u`.`id_usuario` = `e`.`id_usuarios`))) join `ventas` `ve` on((`e`.`id_empledos` = `ve`.`id_vendedor`))) join `vehiculos` `v` on((`ve`.`id_elemento_inventario` = `v`.`id_vehiculo`))) left join `clientes` `c` on((`ve`.`id_cliente` = `c`.`id_clientes`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `egresos`
--
DROP TABLE IF EXISTS `egresos`;

DROP VIEW IF EXISTS `egresos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `egresos`  AS SELECT sum(`vehiculos_y_partes`.`costo`) AS `Ingreso_ventas` FROM (`inventario` join (select `vehiculos`.`id_vehiculo` AS `id_vehiculo`,`vehiculos`.`costo` AS `costo` from `vehiculos` union all select `partes`.`id_parte` AS `id_parte`,`partes`.`costo` AS `costo` from `partes`) `vehiculos_y_partes` on((`id_elemento` = `vehiculos_y_partes`.`id_vehiculo`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `ingresos`
--
DROP TABLE IF EXISTS `ingresos`;

DROP VIEW IF EXISTS `ingresos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ingresos`  AS SELECT sum(`ventas`.`Costo`) AS `Ingreso_ventas` FROM `ventas``ventas`  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `masvendidospartes`
--
DROP TABLE IF EXISTS `masvendidospartes`;

DROP VIEW IF EXISTS `masvendidospartes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `masvendidospartes`  AS SELECT `v`.`nombre` AS `Nombre_producto`, `marca`.`nombre` AS `Marca_producto`, count(0) AS `Repeticiones` FROM (((((`usuarios` `u` join `empledos` `e` on((`u`.`id_usuario` = `e`.`id_usuarios`))) join `ventas` `ve` on((`e`.`id_empledos` = `ve`.`id_vendedor`))) join `partes` `v` on((`ve`.`id_elemento_inventario` = `v`.`id_parte`))) join `marca` on((`v`.`marca` = `marca`.`id_marca`))) left join `clientes` `c` on((`ve`.`id_cliente` = `c`.`id_clientes`))) GROUP BY `v`.`nombre`, `v`.`marca` ORDER BY `Repeticiones` DESC LIMIT 0, 33  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `masvendidosvehiculos`
--
DROP TABLE IF EXISTS `masvendidosvehiculos`;

DROP VIEW IF EXISTS `masvendidosvehiculos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `masvendidosvehiculos`  AS SELECT `v`.`nombre` AS `Nombre_producto`, `marca`.`nombre` AS `Marca_producto`, count(0) AS `Repeticiones` FROM (((((`usuarios` `u` join `empledos` `e` on((`u`.`id_usuario` = `e`.`id_usuarios`))) join `ventas` `ve` on((`e`.`id_empledos` = `ve`.`id_vendedor`))) join `vehiculos` `v` on((`ve`.`id_elemento_inventario` = `v`.`id_vehiculo`))) join `marca` on((`v`.`marca` = `marca`.`id_marca`))) left join `clientes` `c` on((`ve`.`id_cliente` = `c`.`id_clientes`))) GROUP BY `v`.`nombre`, `v`.`marca` LIMIT 0, 33  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `mayorcompraparte`
--
DROP TABLE IF EXISTS `mayorcompraparte`;

DROP VIEW IF EXISTS `mayorcompraparte`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mayorcompraparte`  AS SELECT `partes`.`nombre` AS `nombre_parte`, `marca`.`nombre` AS `nombre_marca`, count(0) AS `Repeticiones` FROM (`partes` join `marca` on((`partes`.`marca` = `marca`.`id_marca`))) GROUP BY `partes`.`nombre`, `marca`.`nombre` ORDER BY `Repeticiones` ASC LIMIT 0, 33  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `mayorcomprvehiculo`
--
DROP TABLE IF EXISTS `mayorcomprvehiculo`;

DROP VIEW IF EXISTS `mayorcomprvehiculo`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mayorcomprvehiculo`  AS SELECT `vehiculos`.`nombre` AS `nombre`, `marca`.`nombre` AS `marca`, count(0) AS `Repeticiones` FROM (`vehiculos` join `marca` on((`vehiculos`.`marca` = `marca`.`id_marca`))) GROUP BY `vehiculos`.`nombre`, `marca`.`nombre` ORDER BY `Repeticiones` DESC LIMIT 0, 33  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_inventario_partes`
--
DROP TABLE IF EXISTS `vista_inventario_partes`;

DROP VIEW IF EXISTS `vista_inventario_partes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_inventario_partes`  AS SELECT `i`.`id_inventario` AS `id_inventario`, `i`.`tipo` AS `tipo`, `p`.`nombre` AS `nombre_elemento`, `p`.`modelo` AS `modelo_elemento`, `m`.`nombre` AS `nombre_marca`, `p`.`numeroSerie` AS `numero_serie`, `i`.`estado` AS `estado` FROM ((`inventario` `i` left join `partes` `p` on(((`i`.`tipo` = 'parte') and (`i`.`id_elemento` = `p`.`id_parte`)))) left join `marca` `m` on((`p`.`marca` = `m`.`id_marca`))) WHERE (`i`.`tipo` = 'parte')  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_inventario_vehiculo`
--
DROP TABLE IF EXISTS `vista_inventario_vehiculo`;

DROP VIEW IF EXISTS `vista_inventario_vehiculo`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_inventario_vehiculo`  AS SELECT `i`.`id_inventario` AS `id_inventario`, `i`.`tipo` AS `tipo`, `v`.`nombre` AS `nombre_elemento`, `v`.`modelo` AS `modelo_elemento`, `m`.`nombre` AS `nombre_marca`, `v`.`numeroSerie` AS `numero_serie`, `i`.`estado` AS `estado` FROM ((`inventario` `i` left join `vehiculos` `v` on(((`i`.`tipo` = 'vehículo') and (`i`.`id_elemento` = `v`.`id_vehiculo`)))) left join `marca` `m` on((`v`.`marca` = `m`.`id_marca`))) WHERE (`i`.`tipo` = 'vehículo')  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_view`
--
DROP TABLE IF EXISTS `vista_view`;

DROP VIEW IF EXISTS `vista_view`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_view`  AS SELECT `i`.`id_inventario` AS `id_inventario`, `i`.`tipo` AS `tipo`, (case when (`i`.`tipo` = 'Vehiculo') then `v`.`nombre` when (`i`.`tipo` = 'parte') then `p`.`nombre` else 'Desconocido' end) AS `Elemento`, (case when (`i`.`tipo` = 'Vehiculo') then `v`.`modelo` when (`i`.`tipo` = 'parte') then `p`.`modelo` else 'Desconocido' end) AS `Modelo`, (case when (`i`.`tipo` = 'vehículo') then `v`.`marca` when (`i`.`tipo` = 'parte') then `p`.`marca` else 'Desconocido' end) AS `Marca`, (case when (`i`.`tipo` = 'Vehiculo') then `v`.`numeroSerie` when (`i`.`tipo` = 'parte') then `p`.`numeroSerie` else 'Desconocido' end) AS `NumeroSerie`, `i`.`estado` AS `estado` FROM ((`inventario` `i` left join `vehiculos` `v` on(((`i`.`tipo` = 'Vehiculo') and (`i`.`id_elemento` = `v`.`id_vehiculo`)))) left join `partes` `p` on(((`i`.`tipo` = 'parte') and (`i`.`id_elemento` = `p`.`id_parte`))))  ;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `partes`
--
ALTER TABLE `partes`
  ADD CONSTRAINT `partes_ibfk_1` FOREIGN KEY (`marca`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `partes_ibfk_2` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`Id_proveedor`);

--
-- Filtros para la tabla `vehiculos`
--
ALTER TABLE `vehiculos`
  ADD CONSTRAINT `vehiculos_ibfk_1` FOREIGN KEY (`marca`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `vehiculos_ibfk_2` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`Id_proveedor`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`id_vendedor`) REFERENCES `empledos` (`id_empledos`),
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_clientes`),
  ADD CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`id_elemento_inventario`) REFERENCES `inventario` (`id_elemento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
