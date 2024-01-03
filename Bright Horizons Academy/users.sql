-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 27-10-2023 a las 09:55:25
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `users`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignaturas`
--

DROP TABLE IF EXISTS `asignaturas`;
CREATE TABLE IF NOT EXISTS `asignaturas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `asignaturas`
--

INSERT INTO `asignaturas` (`id`, `nombre`) VALUES
(1, 'Matemáticas'),
(2, 'Lengua\r\n\r\n'),
(3, 'Física'),
(4, 'Historia'),
(5, 'Inglés'),
(6, 'Química');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencias`
--

DROP TABLE IF EXISTS `asistencias`;
CREATE TABLE IF NOT EXISTS `asistencias` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_estudiante` int NOT NULL,
  `grado` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `seccion` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `asistencia` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `asistencias`
--

INSERT INTO `asistencias` (`id`, `id_estudiante`, `grado`, `seccion`, `asistencia`, `fecha`) VALUES
(30, 23, 'Tercer Año', 'G', 'Presente', '2023-08-24'),
(31, 24, 'Segundo Año', 'F', 'Ausente', '2023-08-24'),
(32, 25, 'Primer Año', 'G', 'Presente', '2023-08-24'),
(33, 26, 'Tercer Año', 'G', 'Ausente', '2023-08-24'),
(34, 27, 'Segundo Año', 'F', 'Presente', '2023-08-24'),
(35, 28, 'Primer Año', 'G', 'Ausente', '2023-08-24'),
(36, 29, 'Tercer Año', 'F', 'Presente', '2023-08-24'),
(37, 30, 'Segundo Año', 'G', 'Ausente', '2023-08-24'),
(38, 31, 'Primer Año', 'F', 'Presente', '2023-08-24'),
(39, 32, 'Tercer Año', 'G', 'Ausente', '2023-08-24');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `calificaciones`
--

DROP TABLE IF EXISTS `calificaciones`;
CREATE TABLE IF NOT EXISTS `calificaciones` (
  `id` int NOT NULL AUTO_INCREMENT,
  `estudiante_id` int NOT NULL,
  `asignatura_id` int NOT NULL,
  `calificacion` float NOT NULL,
  PRIMARY KEY (`id`),
  KEY `estudiante_id` (`estudiante_id`),
  KEY `asignatura_id` (`asignatura_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargo`
--

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE IF NOT EXISTS `cargo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descripicion` varchar(250) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cargo`
--

INSERT INTO `cargo` (`id`, `descripicion`) VALUES
(1, 'administrador'),
(2, 'usuario\r\n'),
(3, 'profesor'),
(4, 'bibliotecario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clases`
--

DROP TABLE IF EXISTS `clases`;
CREATE TABLE IF NOT EXISTS `clases` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `grado` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `seccion` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `clave_acceso` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `tutor_id` int NOT NULL,
  `clave_admin` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tutor_id` (`tutor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clases`
--

INSERT INTO `clases` (`id`, `nombre`, `grado`, `seccion`, `clave_acceso`, `tutor_id`, `clave_admin`) VALUES
(4, 'Ciencias', '2', 'G', 'hola', 1, '1'),
(5, 'Matemáticas', '2', 'G', '123', 1, '1'),
(6, 'Lengua', '1°', 'G', '1', 1, '1'),
(7, 'literatura', '2', 'G', '1', 1, '1'),
(8, 'Sociales', '1°', 'C', '1', 2, '2'),
(12, 'Geografía', '2G', 'B', '1', 1, '1'),
(13, 'Sociales', 'Tercero', 'A', '12345', 1, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comentarios`
--

DROP TABLE IF EXISTS `comentarios`;
CREATE TABLE IF NOT EXISTS `comentarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `clase_id` int DEFAULT NULL,
  `estudiante_id` int DEFAULT NULL,
  `comentario` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `clase_id` (`clase_id`),
  KEY `estudiante_id` (`estudiante_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `comentarios`
--

INSERT INTO `comentarios` (`id`, `clase_id`, `estudiante_id`, `comentario`, `fecha`) VALUES
(1, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 17:36:23'),
(2, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 17:36:24'),
(3, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 17:36:39'),
(4, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 17:41:30'),
(5, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 17:41:32'),
(6, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 19:18:46'),
(7, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-08 19:18:49'),
(8, 6, 2, '¿Cuál es la próxima actividad?', '2023-10-10 02:05:26'),
(9, 6, 1, 'ohalaa', '2023-10-10 18:04:10'),
(10, 6, 1, '¿Cuál es la próxima actividad?', '2023-10-10 20:11:21'),
(11, 4, 1, '¿Cuál es la próxima actividad?', '2023-10-27 08:30:23'),
(12, 5, 1, '¿Cuál es la próxima actividad?', '2023-10-27 08:33:14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

DROP TABLE IF EXISTS `cursos`;
CREATE TABLE IF NOT EXISTS `cursos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cursos`
--

INSERT INTO `cursos` (`id`, `nombre`) VALUES
(7, 'Matemáticas'),
(8, 'Física'),
(9, 'Química'),
(10, 'Historia'),
(11, 'Inglés'),
(12, 'Lengua');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantes`
--

DROP TABLE IF EXISTS `estudiantes`;
CREATE TABLE IF NOT EXISTS `estudiantes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `direccion` varchar(200) COLLATE utf8mb4_general_ci NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `numero_identificacion` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `id_section` int DEFAULT NULL,
  `id_grade` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_section` (`id_section`),
  KEY `id_grade` (`id_grade`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `estudiantes`
--

INSERT INTO `estudiantes` (`id`, `nombre`, `direccion`, `fecha_nacimiento`, `numero_identificacion`, `id_section`, `id_grade`) VALUES
(44, 'Juan Perez', 'Calle 123, Ciudad A', '2002-05-15', '1234567890', 1, 5),
(45, 'María López', 'Avenida XYZ, Ciudad B', '2003-03-20', '9876543210', 1, 1),
(46, 'Jorge Martínez', 'Calle 789, Ciudad B', '2001-11-05', '7890123456', 1, 1),
(47, 'Laura Sánchez', 'Avenida DEF, Ciudad A', '2002-06-30', '2345678901', 1, 1),
(48, 'Sandra Torres', 'Avenida GHI, Ciudad A', '2001-09-20', '4321098765', 1, 1),
(49, 'Patricia Vargas', 'Avenida JKL, Ciudad C', '2002-07-25', '6543210987', 1, 1),
(50, 'Raúl Martínez', 'Calle 345, Ciudad A', '2003-01-05', '9876543210', 1, 1),
(51, 'Carlos García', 'Calle 456, Ciudad A', '2002-08-10', '4567890123', 1, 1),
(52, 'Ana Rodríguez', 'Avenida ABC, Ciudad C', '2004-01-25', '6543210987', 1, 1),
(53, 'José Ramírez', 'Calle 567, Ciudad C', '2003-04-15', '3456789012', 1, 1),
(54, 'Pedro González', 'Calle 890, Ciudad B', '2004-02-10', '5432109876', 1, 1),
(55, 'Manuel Silva', 'Calle 234, Ciudad A', '2003-05-30', '7654321098', 1, 1),
(56, 'Carmen Pérez', 'Avenida MNO, Ciudad B', '2001-10-15', '8765432109', 1, 1),
(57, 'Luis Morales', 'Avenida PQR, Ciudad C', '2002-03-08', '2345678901', 1, 1),
(58, 'Isabel López', 'Calle 901, Ciudad A', '2001-12-12', '4567890123', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantes_login`
--

DROP TABLE IF EXISTS `estudiantes_login`;
CREATE TABLE IF NOT EXISTS `estudiantes_login` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `numero_identificacion` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `contrasena` varchar(250) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `estudiantes_login`
--

INSERT INTO `estudiantes_login` (`id`, `nombre`, `numero_identificacion`, `contrasena`) VALUES
(1, 'Pablo', '202202', 'pablojose1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `eventos`
--

DROP TABLE IF EXISTS `eventos`;
CREATE TABLE IF NOT EXISTS `eventos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(150) NOT NULL,
  `inicio` date NOT NULL,
  `fin` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `eventos`
--

INSERT INTO `eventos` (`id`, `titulo`, `inicio`, `fin`) VALUES
(13, 'Conferencia de Orientación', '2023-10-08', '2023-10-08'),
(14, 'Actividad de Voluntariado', '2023-11-15', '2023-11-15'),
(18, 'Conferencia de Educación', '2023-08-05', '2023-08-06'),
(23, 'Presentación Musical', '2023-08-15', '2023-08-16'),
(24, 'Seminario de Ciencia', '2023-08-17', '2023-08-18'),
(26, 'Reunión de Padres', '2023-08-21', '2023-08-22'),
(27, 'Actividad de Voluntariado', '2023-08-23', '2023-08-24'),
(28, 'Concurso de Matemáticas', '2023-08-25', '2023-08-26'),
(29, 'Día del Deporte', '2023-08-27', '2023-08-28'),
(30, 'Conferencia de Literatura', '2023-08-29', '2023-08-30'),
(31, 'Preparación para el Nuevo Mes', '2023-08-31', '2023-09-01'),
(32, 'Reunión de padres', '2023-08-22', '2023-08-22');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grado`
--

DROP TABLE IF EXISTS `grado`;
CREATE TABLE IF NOT EXISTS `grado` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `grado`
--

INSERT INTO `grado` (`id`, `nombre`) VALUES
(1, 'Primer año'),
(2, 'Segundo Grado'),
(3, 'Tercer Grado'),
(4, 'Segundo año'),
(5, 'Quinto Grado'),
(6, 'Sexto Grado'),
(7, 'Séptimo Grado'),
(8, 'Octavo Grado'),
(9, 'Noveno Grado'),
(11, 'Cuarto Grado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horario`
--

DROP TABLE IF EXISTS `horario`;
CREATE TABLE IF NOT EXISTS `horario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_grado` int DEFAULT NULL,
  `id_section` int DEFAULT NULL,
  `dia` varchar(10) NOT NULL,
  `hora_inicio` time NOT NULL,
  `hora_fin` time NOT NULL,
  `materia` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_grado` (`id_grado`),
  KEY `id_section` (`id_section`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `horario`
--

INSERT INTO `horario` (`id`, `id_grado`, `id_section`, `dia`, `hora_inicio`, `hora_fin`, `materia`) VALUES
(1, 1, 1, 'Lunes', '21:34:00', '21:34:00', 'MAte'),
(2, 1, 1, 'Lunes', '05:34:00', '05:34:00', 'MAte'),
(3, 1, 1, 'Lunes', '17:36:00', '17:36:00', 'MAte'),
(4, 1, 1, 'Lunes', '17:36:00', '17:36:00', 'MAte'),
(5, 1, 1, 'Lunes', '17:40:00', '17:40:00', 'MAte'),
(6, 1, 1, 'Lunes', '17:41:00', '17:41:00', 'MAte'),
(7, 1, 1, 'Lunes', '17:40:00', '17:40:00', 'MAte'),
(8, 1, 1, 'Lunes', '05:34:00', '05:34:00', 'MAte'),
(9, 1, 1, 'Lunes', '21:34:00', '21:34:00', 'MAte'),
(10, 1, 1, 'Lunes', '05:34:00', '05:34:00', 'MAte'),
(11, 1, 1, 'Lunes', '17:36:00', '17:36:00', 'MAte'),
(12, 1, 1, 'Lunes', '17:36:00', '17:36:00', 'MAte'),
(13, 1, 1, 'Lunes', '17:40:00', '17:40:00', 'MAte'),
(14, 1, 1, 'Lunes', '17:41:00', '17:41:00', 'MAte'),
(15, 1, 1, 'Lunes', '17:40:00', '17:40:00', 'MAte'),
(16, 1, 1, 'Lunes', '05:34:00', '05:34:00', 'MAte');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horarios`
--

DROP TABLE IF EXISTS `horarios`;
CREATE TABLE IF NOT EXISTS `horarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `hora_inicio` time NOT NULL,
  `hora_fin` time NOT NULL,
  `id_profesor` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_profesor` (`id_profesor`)
) ENGINE=InnoDB AUTO_INCREMENT=193 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `horarios`
--

INSERT INTO `horarios` (`id`, `fecha`, `hora_inicio`, `hora_fin`, `id_profesor`) VALUES
(18, '2023-08-26', '10:00:00', '12:00:00', 31),
(20, '2023-08-27', '08:00:00', '10:00:00', 33),
(21, '2023-08-27', '12:00:00', '14:00:00', 34),
(26, '2023-10-17', '18:59:00', '07:59:00', 33),
(82, '2023-10-19', '12:54:00', '13:54:00', 31),
(83, '2023-10-19', '12:54:00', '13:54:00', 31),
(84, '2023-10-19', '12:54:00', '13:54:00', 31),
(85, '2023-10-19', '12:54:00', '13:54:00', 31),
(86, '2023-10-19', '12:54:00', '13:54:00', 31),
(87, '2023-10-19', '12:54:00', '13:54:00', 31),
(88, '2023-10-19', '12:54:00', '13:54:00', 31),
(89, '2023-10-19', '12:54:00', '13:54:00', 31),
(90, '2023-10-19', '12:54:00', '13:54:00', 31),
(91, '2023-10-19', '12:54:00', '13:54:00', 31),
(92, '2023-10-19', '12:54:00', '13:54:00', 31),
(93, '2023-10-19', '12:54:00', '13:54:00', 31),
(94, '2023-10-19', '12:54:00', '13:54:00', 31),
(95, '2023-10-19', '12:54:00', '13:54:00', 31),
(96, '2023-10-19', '12:54:00', '13:54:00', 31),
(97, '2023-10-19', '12:54:00', '13:54:00', 31),
(98, '2023-10-19', '12:54:00', '13:54:00', 31),
(99, '2023-10-19', '12:54:00', '13:54:00', 31),
(100, '2023-10-19', '12:54:00', '13:54:00', 31),
(101, '2023-10-19', '12:54:00', '13:54:00', 31),
(102, '2023-10-19', '12:54:00', '13:54:00', 31),
(103, '2023-10-19', '12:54:00', '13:54:00', 31),
(104, '2023-10-19', '12:54:00', '13:54:00', 31),
(105, '2023-10-19', '12:54:00', '13:54:00', 31),
(106, '2023-10-19', '12:54:00', '13:54:00', 31),
(107, '2023-10-19', '12:54:00', '13:54:00', 31),
(108, '2023-10-19', '12:54:00', '13:54:00', 31),
(109, '2023-10-19', '12:54:00', '13:54:00', 31),
(110, '2023-10-19', '12:54:00', '13:54:00', 31),
(111, '2023-10-19', '12:54:00', '13:54:00', 31),
(112, '2023-10-19', '12:54:00', '13:54:00', 31),
(113, '2023-10-19', '12:54:00', '13:54:00', 31),
(114, '2023-10-19', '12:54:00', '13:54:00', 31),
(115, '2023-10-19', '12:54:00', '13:54:00', 31),
(116, '2023-10-19', '12:54:00', '13:54:00', 31),
(117, '2023-10-19', '12:54:00', '13:54:00', 31),
(118, '2023-10-19', '12:54:00', '13:54:00', 31),
(119, '2023-10-19', '12:54:00', '13:54:00', 31),
(120, '2023-10-19', '12:54:00', '13:54:00', 31),
(121, '2023-10-19', '12:54:00', '13:54:00', 31),
(122, '2023-10-19', '12:54:00', '13:54:00', 31),
(123, '2023-10-19', '12:54:00', '13:54:00', 31),
(124, '2023-10-19', '12:54:00', '13:54:00', 31),
(125, '2023-10-19', '12:54:00', '13:54:00', 31),
(126, '2023-10-19', '12:54:00', '13:54:00', 31),
(127, '2023-10-19', '12:54:00', '13:54:00', 31),
(128, '2023-10-19', '12:54:00', '13:54:00', 31),
(129, '2023-10-19', '12:54:00', '13:54:00', 31),
(130, '2023-10-19', '12:54:00', '13:54:00', 31),
(131, '2023-10-19', '12:54:00', '13:54:00', 31),
(132, '2023-10-19', '12:54:00', '13:54:00', 31),
(133, '2023-10-19', '12:54:00', '13:54:00', 31),
(134, '2023-10-19', '12:54:00', '13:54:00', 31),
(135, '2023-10-19', '12:54:00', '13:54:00', 31),
(136, '2023-10-19', '12:54:00', '13:54:00', 31),
(137, '2023-10-19', '12:54:00', '13:54:00', 31),
(138, '2023-10-19', '12:54:00', '13:54:00', 31),
(139, '2023-10-19', '12:54:00', '13:54:00', 31),
(140, '2023-10-19', '12:54:00', '13:54:00', 31),
(141, '2023-10-19', '12:54:00', '13:54:00', 31),
(142, '2023-10-19', '12:54:00', '13:54:00', 31),
(143, '2023-10-19', '12:54:00', '13:54:00', 31),
(144, '2023-10-19', '12:54:00', '13:54:00', 31),
(145, '2023-10-19', '12:54:00', '13:54:00', 31),
(146, '2023-10-19', '12:54:00', '13:54:00', 31),
(147, '2023-10-19', '12:54:00', '13:54:00', 31),
(148, '2023-10-19', '12:54:00', '13:54:00', 31),
(149, '2023-10-19', '12:54:00', '13:54:00', 31),
(150, '2023-10-19', '12:54:00', '13:54:00', 31),
(151, '2023-10-19', '12:54:00', '13:54:00', 31),
(152, '2023-10-19', '12:54:00', '13:54:00', 31),
(153, '2023-10-19', '12:54:00', '13:54:00', 31),
(154, '2023-10-19', '12:54:00', '13:54:00', 31),
(155, '2023-10-19', '12:54:00', '13:54:00', 31),
(156, '2023-10-19', '12:54:00', '13:54:00', 31),
(157, '2023-10-19', '12:54:00', '13:54:00', 31),
(158, '2023-10-19', '12:54:00', '13:54:00', 31),
(159, '2023-10-19', '12:54:00', '13:54:00', 31),
(160, '2023-10-19', '12:54:00', '13:54:00', 31),
(161, '2023-10-19', '12:54:00', '13:54:00', 31),
(162, '2023-10-19', '12:54:00', '13:54:00', 31),
(163, '2023-10-19', '12:54:00', '13:54:00', 31),
(164, '2023-10-19', '12:54:00', '13:54:00', 31),
(165, '2023-10-19', '12:54:00', '13:54:00', 31),
(166, '2023-10-19', '12:54:00', '13:54:00', 31),
(167, '2023-10-19', '12:54:00', '13:54:00', 31),
(168, '2023-10-19', '12:54:00', '13:54:00', 31),
(169, '2023-10-19', '12:54:00', '13:54:00', 31),
(170, '2023-10-19', '12:54:00', '13:54:00', 31),
(171, '2023-10-19', '12:54:00', '13:54:00', 31),
(172, '2023-10-19', '12:54:00', '13:54:00', 31),
(173, '2023-10-19', '12:54:00', '13:54:00', 31),
(174, '2023-10-19', '12:54:00', '13:54:00', 31),
(175, '2023-10-19', '12:54:00', '13:54:00', 31),
(176, '2023-10-19', '12:54:00', '13:54:00', 31),
(177, '2023-10-19', '12:54:00', '13:54:00', 31),
(178, '2023-10-19', '12:54:00', '13:54:00', 31),
(179, '2023-10-19', '12:54:00', '13:54:00', 31),
(180, '2023-10-19', '12:54:00', '13:54:00', 31),
(181, '2023-10-19', '12:54:00', '13:54:00', 31),
(182, '2023-10-19', '12:54:00', '13:54:00', 31),
(183, '2023-10-19', '12:54:00', '13:54:00', 31),
(184, '2023-10-19', '12:54:00', '13:54:00', 31),
(185, '2023-10-19', '12:54:00', '13:54:00', 31),
(192, '2023-10-06', '00:01:00', '00:01:00', 34);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libros`
--

DROP TABLE IF EXISTS `libros`;
CREATE TABLE IF NOT EXISTS `libros` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `isbn` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `cantidad_disponible` int NOT NULL,
  `foto_libro` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `libros`
--

INSERT INTO `libros` (`id`, `titulo`, `isbn`, `cantidad_disponible`, `foto_libro`) VALUES
(1, 'Yo antes de ti', '9782811210014', 10, 'https://m.media-amazon.com/images/I/81yACTXLo9L._AC_UF894,1000_QL80_.jpg'),
(2, 'Cien años de soledad', '9780060114183', 2, 'https://internacionallibrosyregalos.com/cdn/shop/products/CIENANOSDESOLEDAD_300x.jpg?v=1641419696'),
(3, '1984', '9780140817744', 3, 'https://images.cdn1.buscalibre.com/fit-in/360x360/10/42/10426f9e9ae4f7cd9eb5d33cef5aa143.jpg'),
(4, 'Don Quijote de la Mancha', '9788437633770', 20, 'https://www.elejandria.com/covers/Don_Quijote_de_la_Mancha-Cervantes_Miguel-lg.png'),
(5, 'El principito', '9783140464079', 30, 'https://m.media-amazon.com/images/I/71AVK5VIAzL._AC_UF1000,1000_QL80_.jpg'),
(6, 'Marianela', '9788437603803', 1, 'https://lassinsosten.files.wordpress.com/2019/11/libro-marianela-benito-perez-galdos-d_nq_np_856952-mla25798241148_072017-f.jpg'),
(7, 'Rebeldes', '9781484494622', 16, 'https://www.loqueleo.com/mx/uploads/2017/02/rebeldes-2.jpg'),
(8, 'Orgullo y prejuicio', '9780140430721', 9, 'https://www.penguinlibros.com/co/2492523/orgullo-y-prejuicio.jpg'),
(9, 'En busca del tiempo perdido', '9783518468081', 2, 'https://images.cdn2.buscalibre.com/fit-in/360x360/04/0b/040bfd4a2227338020431d81c7d3c121.jpg'),
(10, 'Crimen y castigo', '9788420741468', 11, 'https://global-uploads.webflow.com/6034d7d1f3e0f52c50b2adee/6254541d8ae4df16d4e69bc8_6034d7d1f3e0f54529b2b1a1_Crimen-y-castigo-fiodor-dostoyevski-editorial-alma.jpeg'),
(11, 'El gato negro', '9780582417748', 10, 'https://imgv2-1-f.scribdassets.com/img/word_document/590391433/original/216x287/91b612b12b/1689889778?v=1'),
(12, 'Los hombres me explican cosas', '9781608464661', 1, 'https://capitanswing.com/wp-content/uploads/RebeccaSolnit_LosHombresMeExplicanCosas.jpg'),
(13, 'Ilíada', '9780140445046', 3, 'https://simehbucket.s3.amazonaws.com/images/5a2d2f9c29b2605bc4176f80682a5cde-full.jpg'),
(14, 'Pinocho', '9788804393108', 25, 'https://images.cdn2.buscalibre.com/fit-in/360x360/9c/69/9c69ad90ee45ed432d8e38b23d8fd9da.jpg'),
(15, 'Juventud en Éxtasis', '9789687277011', 40, 'https://assets.lectulandia.com/b/ab/Carlos%20Cuauhtemoc%20Sanchez/Juventud%20en%20extasis%20(5)/big.jpg'),
(16, 'Los ojos de mi princesa', '9786077627463', 12, 'https://m.media-amazon.com/images/I/41yHjChsqjL.jpg'),
(17, 'Lazarillo de Tormes', '9788467052282', 15, 'https://imagessl6.casadellibro.com/a/l/t0/66/9788483088166.jpg'),
(18, 'Oliver Twist', '9788490659151', 7, 'https://www.elejandria.com/covers/Oliver_Twist-Charles_Dickens-lg.png'),
(19, 'El abrazo', '9788467533095', 3, 'https://www.normainfantilyjuvenil.com/mx/uploads/2019/05/7706894116980.jpg'),
(20, 'El viejo y el mar', '9788499089980', 6, 'https://lsjbbtc.files.wordpress.com/2022/05/image-13.png?w=683'),
(21, 'El extraño caso del doctor Jekyll y el señor Hyde', '9788477025320', 4, 'https://www.loqueleo.com/hn/uploads/2018/06/el-extrano-caso-del-dr-jekyll-y-mr-hyde_1.jpg'),
(22, 'Bajo la misma estrella', '9788415594017', 9, 'https://3.bp.blogspot.com/-g9Zo9kec7O8/UTkzDaNQKmI/AAAAAAAAAqQ/gIS7aLArFlE/s1600/9788415594048.jpg'),
(23, 'Popol Vuh', '9788491049241', 40, 'https://covers.alibrate.com/b/5a0cfb67bac1cbf7023c1f32/cd069040-b588-4c1e-b3ce-209e53fd8ade/share'),
(24, 'El amor en tiempos de cólera', '9788497592451', 1, 'https://internacionallibrosyregalos.com/cdn/shop/products/978607072916_816x.jpg?v=1596057442');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE IF NOT EXISTS `pagos` (
  `id_pago` int NOT NULL AUTO_INCREMENT,
  `id_estudiante` int NOT NULL,
  `pago_mensual` decimal(10,2) NOT NULL,
  `pago_matricula` decimal(10,2) NOT NULL,
  `becado` enum('si','no') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `mes` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `estado` enum('pagado','pendiente') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'pendiente',
  PRIMARY KEY (`id_pago`),
  KEY `id_estudiante` (`id_estudiante`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id_pago`, `id_estudiante`, `pago_mensual`, `pago_matricula`, `becado`, `mes`, `estado`) VALUES
(16, 39, '30.00', '200.00', 'si', 'Enero', 'pendiente'),
(17, 59, '30.00', '200.00', 'si', 'Enero', 'pendiente'),
(18, 44, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(19, 45, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(20, 46, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(21, 47, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(22, 48, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(23, 49, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(24, 50, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(25, 51, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(26, 52, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(27, 53, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(28, 54, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(29, 55, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(30, 56, '30.00', '200.00', 'si', 'Febrero', 'pendiente'),
(31, 57, '30.00', '200.00', 'si', 'Febrero', 'pendiente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamos`
--

DROP TABLE IF EXISTS `prestamos`;
CREATE TABLE IF NOT EXISTS `prestamos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_estudiante` int NOT NULL,
  `id_libro` int NOT NULL,
  `fecha_prestamo` date NOT NULL,
  `fecha_devolucion` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_estudiante` (`id_estudiante`),
  KEY `id_libro` (`id_libro`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `prestamos`
--

INSERT INTO `prestamos` (`id`, `id_estudiante`, `id_libro`, `fecha_prestamo`, `fecha_devolucion`) VALUES
(17, 1, 6, '2023-10-27', '2023-10-27');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesores`
--

DROP TABLE IF EXISTS `profesores`;
CREATE TABLE IF NOT EXISTS `profesores` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `apellido` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `correo` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `telefono` varchar(15) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `salario` decimal(10,2) DEFAULT NULL,
  `fecha_contrato` date DEFAULT NULL,
  `cursos` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `cursos_id` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `profesores`
--

INSERT INTO `profesores` (`id`, `nombre`, `apellido`, `correo`, `telefono`, `salario`, `fecha_contrato`, `cursos`, `cursos_id`) VALUES
(31, 'Carlos', 'Rodriguez', 'carlos@example.com', '789654123', '2200.00', '2023-08-24', 'Química', 7),
(32, 'Ana', 'Martinez', 'ana@example.com', '456123789', '1900.00', '2023-08-24', 'Historia', 7),
(33, 'Luis', 'Garcia', 'luis@example.com', '789123456', '2100.00', '2023-08-24', 'Inglés', 7),
(34, 'Laura', 'Hernandez', 'laura@example.com', '123789456', '1800.00', '2023-08-24', 'Lengua', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `score`
--

DROP TABLE IF EXISTS `score`;
CREATE TABLE IF NOT EXISTS `score` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_id` int NOT NULL,
  `score` decimal(10,0) NOT NULL,
  `descripcion` varchar(250) NOT NULL,
  `date_register` timestamp NOT NULL,
  `id_subject` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=136 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `score`
--

INSERT INTO `score` (`id`, `student_id`, `score`, `descripcion`, `date_register`, `id_subject`) VALUES
(1, 36, '1', '', '2023-09-26 03:08:39', 1),
(2, 36, '10', '', '2023-09-26 03:33:25', 1),
(3, 39, '1', '', '2023-10-11 22:40:30', 1),
(4, 43, '3', '', '2023-10-11 22:47:19', 2),
(6, 58, '1', '', '2023-10-12 00:18:03', 1),
(7, 43, '1', '', '2023-10-12 00:28:13', 1),
(8, 43, '5', '', '2023-10-12 00:28:22', 1),
(9, 59, '10', '', '2023-10-12 01:03:21', 1),
(10, 59, '10', '', '2023-10-12 01:03:24', 1),
(11, 43, '6', '', '2023-10-12 16:28:16', 2),
(12, 43, '10', '', '2023-10-12 16:28:28', 2),
(13, 44, '10', '', '2023-10-21 19:33:30', 1),
(14, 39, '6', '', '2023-10-21 19:35:56', 1),
(15, 45, '10', '', '2023-10-27 08:52:40', 1),
(16, 44, '8', 'Descripción 1', '2023-10-27 15:00:00', 1),
(17, 45, '9', 'Descripción 2', '2023-10-27 15:15:00', 1),
(18, 46, '7', 'Descripción 3', '2023-10-27 15:30:00', 1),
(19, 50, '6', 'Descripción 4', '2023-10-27 15:45:00', 1),
(20, 51, '9', 'Descripción 5', '2023-10-27 16:00:00', 1),
(21, 52, '8', 'Descripción 6', '2023-10-27 16:15:00', 1),
(22, 53, '7', 'Descripción 7', '2023-10-27 16:30:00', 1),
(23, 54, '6', 'Descripción 8', '2023-10-27 16:45:00', 1),
(24, 55, '9', 'Descripción 9', '2023-10-27 17:00:00', 1),
(25, 56, '8', 'Descripción 10', '2023-10-27 17:15:00', 1),
(26, 57, '7', 'Descripción 11', '2023-10-27 17:30:00', 1),
(27, 58, '6', 'Descripción 12', '2023-10-27 17:45:00', 1),
(28, 59, '9', 'Descripción 13', '2023-10-27 18:00:00', 1),
(29, 44, '8', 'Descripción 14', '2023-10-27 18:15:00', 1),
(30, 45, '9', 'Descripción 15', '2023-10-27 18:30:00', 1),
(31, 46, '7', 'Descripción 16', '2023-10-27 18:45:00', 1),
(32, 47, '6', 'Descripción 17', '2023-10-27 19:00:00', 1),
(33, 48, '9', 'Descripción 18', '2023-10-27 19:15:00', 1),
(34, 49, '8', 'Descripción 19', '2023-10-27 19:30:00', 1),
(35, 50, '7', 'Descripción 20', '2023-10-27 19:45:00', 1),
(36, 51, '6', 'Descripción 21', '2023-10-27 20:00:00', 1),
(37, 52, '9', 'Descripción 22', '2023-10-27 20:15:00', 1),
(38, 53, '8', 'Descripción 23', '2023-10-27 20:30:00', 1),
(39, 54, '7', 'Descripción 24', '2023-10-27 20:45:00', 1),
(40, 55, '6', 'Descripción 25', '2023-10-27 21:00:00', 1),
(41, 56, '9', 'Descripción 26', '2023-10-27 21:15:00', 1),
(42, 57, '8', 'Descripción 27', '2023-10-27 21:30:00', 1),
(43, 58, '7', 'Descripción 28', '2023-10-27 21:45:00', 1),
(44, 59, '6', 'Descripción 29', '2023-10-27 22:00:00', 1),
(45, 44, '9', 'Descripción 30', '2023-10-27 22:15:00', 1),
(46, 44, '8', 'Descripción 1', '2023-10-27 15:00:00', 2),
(47, 45, '9', 'Descripción 2', '2023-10-27 15:15:00', 2),
(48, 46, '7', 'Descripción 3', '2023-10-27 15:30:00', 2),
(49, 50, '6', 'Descripción 4', '2023-10-27 15:45:00', 2),
(50, 51, '9', 'Descripción 5', '2023-10-27 16:00:00', 2),
(51, 52, '8', 'Descripción 6', '2023-10-27 16:15:00', 2),
(52, 53, '7', 'Descripción 7', '2023-10-27 16:30:00', 2),
(53, 54, '6', 'Descripción 8', '2023-10-27 16:45:00', 2),
(54, 55, '9', 'Descripción 9', '2023-10-27 17:00:00', 2),
(55, 56, '8', 'Descripción 10', '2023-10-27 17:15:00', 2),
(56, 57, '7', 'Descripción 11', '2023-10-27 17:30:00', 2),
(57, 58, '6', 'Descripción 12', '2023-10-27 17:45:00', 2),
(58, 59, '9', 'Descripción 13', '2023-10-27 18:00:00', 2),
(59, 44, '8', 'Descripción 14', '2023-10-27 18:15:00', 2),
(60, 45, '9', 'Descripción 15', '2023-10-27 18:30:00', 2),
(61, 46, '7', 'Descripción 16', '2023-10-27 18:45:00', 2),
(62, 47, '6', 'Descripción 17', '2023-10-27 19:00:00', 2),
(63, 48, '9', 'Descripción 18', '2023-10-27 19:15:00', 2),
(64, 49, '8', 'Descripción 19', '2023-10-27 19:30:00', 2),
(65, 50, '7', 'Descripción 20', '2023-10-27 19:45:00', 2),
(66, 51, '6', 'Descripción 21', '2023-10-27 20:00:00', 2),
(67, 52, '9', 'Descripción 22', '2023-10-27 20:15:00', 2),
(68, 53, '8', 'Descripción 23', '2023-10-27 20:30:00', 2),
(69, 54, '7', 'Descripción 24', '2023-10-27 20:45:00', 2),
(70, 55, '6', 'Descripción 25', '2023-10-27 21:00:00', 2),
(71, 56, '9', 'Descripción 26', '2023-10-27 21:15:00', 2),
(72, 57, '8', 'Descripción 27', '2023-10-27 21:30:00', 2),
(73, 58, '7', 'Descripción 28', '2023-10-27 21:45:00', 2),
(74, 59, '6', 'Descripción 29', '2023-10-27 22:00:00', 2),
(75, 44, '9', 'Descripción 30', '2023-10-27 22:15:00', 2),
(76, 44, '8', 'Descripción 1', '2023-10-27 15:00:00', 3),
(77, 45, '9', 'Descripción 2', '2023-10-27 15:15:00', 3),
(78, 46, '7', 'Descripción 3', '2023-10-27 15:30:00', 3),
(79, 50, '6', 'Descripción 4', '2023-10-27 15:45:00', 3),
(80, 51, '9', 'Descripción 5', '2023-10-27 16:00:00', 3),
(81, 52, '8', 'Descripción 6', '2023-10-27 16:15:00', 3),
(82, 53, '7', 'Descripción 7', '2023-10-27 16:30:00', 3),
(83, 54, '6', 'Descripción 8', '2023-10-27 16:45:00', 3),
(84, 55, '9', 'Descripción 9', '2023-10-27 17:00:00', 3),
(85, 56, '8', 'Descripción 10', '2023-10-27 17:15:00', 3),
(86, 57, '7', 'Descripción 11', '2023-10-27 17:30:00', 3),
(87, 58, '6', 'Descripción 12', '2023-10-27 17:45:00', 3),
(88, 59, '9', 'Descripción 13', '2023-10-27 18:00:00', 3),
(89, 44, '8', 'Descripción 14', '2023-10-27 18:15:00', 3),
(90, 45, '9', 'Descripción 15', '2023-10-27 18:30:00', 3),
(91, 46, '7', 'Descripción 16', '2023-10-27 18:45:00', 3),
(92, 47, '6', 'Descripción 17', '2023-10-27 19:00:00', 3),
(93, 48, '9', 'Descripción 18', '2023-10-27 19:15:00', 3),
(94, 49, '8', 'Descripción 19', '2023-10-27 19:30:00', 3),
(95, 50, '7', 'Descripción 20', '2023-10-27 19:45:00', 3),
(96, 51, '6', 'Descripción 21', '2023-10-27 20:00:00', 3),
(97, 52, '9', 'Descripción 22', '2023-10-27 20:15:00', 3),
(98, 53, '8', 'Descripción 23', '2023-10-27 20:30:00', 3),
(99, 54, '7', 'Descripción 24', '2023-10-27 20:45:00', 3),
(100, 55, '6', 'Descripción 25', '2023-10-27 21:00:00', 3),
(101, 56, '9', 'Descripción 26', '2023-10-27 21:15:00', 3),
(102, 57, '8', 'Descripción 27', '2023-10-27 21:30:00', 3),
(103, 58, '7', 'Descripción 28', '2023-10-27 21:45:00', 3),
(104, 59, '6', 'Descripción 29', '2023-10-27 22:00:00', 3),
(105, 44, '9', 'Descripción 30', '2023-10-27 22:15:00', 3),
(106, 44, '8', 'Descripción 1', '2023-10-27 15:00:00', 4),
(107, 45, '9', 'Descripción 2', '2023-10-27 15:15:00', 4),
(108, 46, '7', 'Descripción 3', '2023-10-27 15:30:00', 4),
(109, 50, '6', 'Descripción 4', '2023-10-27 15:45:00', 4),
(110, 51, '9', 'Descripción 5', '2023-10-27 16:00:00', 4),
(111, 52, '8', 'Descripción 6', '2023-10-27 16:15:00', 4),
(112, 53, '7', 'Descripción 7', '2023-10-27 16:30:00', 4),
(113, 54, '6', 'Descripción 8', '2023-10-27 16:45:00', 4),
(114, 55, '9', 'Descripción 9', '2023-10-27 17:00:00', 4),
(115, 56, '8', 'Descripción 10', '2023-10-27 17:15:00', 4),
(116, 57, '7', 'Descripción 11', '2023-10-27 17:30:00', 4),
(117, 58, '6', 'Descripción 12', '2023-10-27 17:45:00', 4),
(118, 59, '9', 'Descripción 13', '2023-10-27 18:00:00', 4),
(119, 44, '8', 'Descripción 14', '2023-10-27 18:15:00', 4),
(120, 45, '9', 'Descripción 15', '2023-10-27 18:30:00', 4),
(121, 46, '7', 'Descripción 16', '2023-10-27 18:45:00', 4),
(122, 47, '6', 'Descripción 17', '2023-10-27 19:00:00', 4),
(123, 48, '9', 'Descripción 18', '2023-10-27 19:15:00', 4),
(124, 49, '8', 'Descripción 19', '2023-10-27 19:30:00', 4),
(125, 50, '7', 'Descripción 20', '2023-10-27 19:45:00', 4),
(126, 51, '6', 'Descripción 21', '2023-10-27 20:00:00', 4),
(127, 52, '9', 'Descripción 22', '2023-10-27 20:15:00', 4),
(128, 53, '8', 'Descripción 23', '2023-10-27 20:30:00', 4),
(129, 54, '7', 'Descripción 24', '2023-10-27 20:45:00', 4),
(130, 55, '6', 'Descripción 25', '2023-10-27 21:00:00', 4),
(131, 56, '9', 'Descripción 26', '2023-10-27 21:15:00', 4),
(132, 57, '8', 'Descripción 27', '2023-10-27 21:30:00', 4),
(133, 58, '7', 'Descripción 28', '2023-10-27 21:45:00', 4),
(134, 59, '6', 'Descripción 29', '2023-10-27 22:00:00', 4),
(135, 44, '9', 'Descripción 30', '2023-10-27 22:15:00', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `section`
--

DROP TABLE IF EXISTS `section`;
CREATE TABLE IF NOT EXISTS `section` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(15) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `section`
--

INSERT INTO `section` (`id`, `name`) VALUES
(1, 'A'),
(2, ' B'),
(3, ' C'),
(4, ' D'),
(5, ' E'),
(6, ' F'),
(7, ' G'),
(8, ' H'),
(9, ' I'),
(10, ' J');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabla_contacto`
--

DROP TABLE IF EXISTS `tabla_contacto`;
CREATE TABLE IF NOT EXISTS `tabla_contacto` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `correo` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `mensaje` text COLLATE utf8mb4_general_ci NOT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tabla_contacto`
--

INSERT INTO `tabla_contacto` (`id`, `nombre`, `correo`, `mensaje`, `fecha_creacion`) VALUES
(7, 'Juan Pérez', 'juan@example.com', 'Mensaje 1', '2023-10-27 15:00:00'),
(8, 'María López', 'maria@example.com', 'Mensaje 2', '2023-10-27 15:15:00'),
(9, 'Jorge Martínez', 'jorge@example.com', 'Mensaje 3', '2023-10-27 15:30:00'),
(10, 'Laura Sánchez', 'laura@example.com', 'Mensaje 4', '2023-10-27 15:45:00'),
(11, 'Sandra Torres', 'sandra@example.com', 'Mensaje 5', '2023-10-27 16:00:00'),
(12, 'Patricia Vargas', 'patricia@example.com', 'Mensaje 6', '2023-10-27 16:15:00'),
(13, 'Raúl Martínez', 'raul@example.com', 'Mensaje 7', '2023-10-27 16:30:00'),
(14, 'Carlos García', 'carlos@example.com', 'Mensaje 8', '2023-10-27 16:45:00'),
(15, 'Ana Rodríguez', 'ana@example.com', 'Mensaje 9', '2023-10-27 17:00:00'),
(16, 'José Ramírez', 'jose@example.com', 'Mensaje 10', '2023-10-27 17:15:00'),
(17, 'Pedro González', 'pedro@example.com', 'Mensaje 11', '2023-10-27 17:30:00'),
(18, 'Manuel Silva', 'manuel@example.com', 'Mensaje 12', '2023-10-27 17:45:00'),
(19, 'Carmen Pérez', 'carmen@example.com', 'Mensaje 13', '2023-10-27 18:00:00'),
(20, 'Luis Morales', 'luis@example.com', 'Mensaje 14', '2023-10-27 18:15:00'),
(21, 'Isabel López', 'isabel@example.com', 'Mensaje 15', '2023-10-27 18:30:00'),
(22, 'Nombre 16', 'correo16@example.com', 'Mensaje 16', '2023-10-27 18:45:00'),
(23, 'Nombre 17', 'correo17@example.com', 'Mensaje 17', '2023-10-27 19:00:00'),
(24, 'Nombre 18', 'correo18@example.com', 'Mensaje 18', '2023-10-27 19:15:00'),
(25, 'Nombre 19', 'correo19@example.com', 'Mensaje 19', '2023-10-27 19:30:00'),
(26, 'Nombre 20', 'correo20@example.com', 'Mensaje 20', '2023-10-27 19:45:00'),
(27, 'Nombre 21', 'correo21@example.com', 'Mensaje 21', '2023-10-27 20:00:00'),
(28, 'Nombre 22', 'correo22@example.com', 'Mensaje 22', '2023-10-27 20:15:00'),
(29, 'Nombre 23', 'correo23@example.com', 'Mensaje 23', '2023-10-27 20:30:00'),
(30, 'Nombre 24', 'correo24@example.com', 'Mensaje 24', '2023-10-27 20:45:00'),
(31, 'Nombre 25', 'correo25@example.com', 'Mensaje 25', '2023-10-27 21:00:00'),
(32, 'Nombre 26', 'correo26@example.com', 'Mensaje 26', '2023-10-27 21:15:00'),
(33, 'Nombre 27', 'correo27@example.com', 'Mensaje 27', '2023-10-27 21:30:00'),
(34, 'Nombre 28', 'correo28@example.com', 'Mensaje 28', '2023-10-27 21:45:00'),
(35, 'Nombre 29', 'correo29@example.com', 'Mensaje 29', '2023-10-27 22:00:00'),
(36, 'Nombre 30', 'correo30@example.com', 'Mensaje 30', '2023-10-27 22:15:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `usuario` varchar(255) NOT NULL,
  `contraseña` varchar(255) NOT NULL,
  `id_cargo` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `usuario`, `contraseña`, `id_cargo`) VALUES
(1, 'Luis Eduardo', 'Admin', '$2y$10$ITuhhO8bhsMex3IgK/5Xf.IHpGcyiTK7ajFQYPvaoFxZPXfo5QqqK', 1),
(12, 'Sosa', 'Sosa', '$2y$10$icwM2uiut9eIful1OVmX9OiVRzz3YpX5hSjgESBJ71OX9md..8Wru', 1),
(13, 'Sosa1', 'Sosa1', '$2y$10$eid6wAKxerMGmAq9SBIiveuVHMDnK2T/sNFQN9eXWI5sbQ0JpW8.S', 2),
(14, 'Sosa2', 'Sosa2', '$2y$10$SGT2CSuu4MiYsHSnk.yyguPLOS642uO9/7GWr0xtNpWvJcbstY3ra', 3),
(15, 'Sosa3', 'Sosa3', '$2y$10$FtmHRoV.iQ.VLSpwJC5/HO1E0OuGfqZSzXuYceVkYsLyo6QGEBppm', 4),
(16, 'Luis Eduardo', 'Juan Pérez', '$2y$10$MiUhjc9FGdblKgULSQFBK.FmQTIZOtw57tZDx8kqBbuIcuXkYOykG', 2),
(17, 'Luis Eduardo Lopez Orantes', 'Estudiante1', '$2y$10$DGoD/NWdxvGc5p7S2JwA9u.Lkf2AVBfNHxAYtxnsKT0bR886rL2/.', 2),
(18, 'Estudiante2', 'Estudiante2', '$2y$10$tmAokuPv4jXDvy1v9U2s6urHN2FZlwXoaxQDsV3XRIGJv3bs7Gzty', 3),
(19, 'Papa', 'Papa', '$2y$10$T0lPTb1bmPwIbLuDU.ULdeuP0iqT0RvQ/sag.rWxU1sWLXUQLQ5b.', 1),
(20, 'Estudiante3', 'Estudiante3', '$2y$10$eQYCa.cQlTaV/HsIg2N6o.6sngVvRiGdcdgT9qE7ZMatEO5i4T8x2', 1),
(21, 'Estudiante4', 'Estudiante4', '$2y$10$1vjHhpgC4g/3MlWO86yWgOXK.35v7nBzv1cIg6/tXTL3N.ZfsLZOS', 1),
(22, 'Estudiante5', 'Estudiante5', '$2y$10$ba2cJ3DBkjnBFtg9q95DDO3aWD9xBz0aleWeVvG.hTVrxdOudojUq', 1),
(23, 'prueba2', 'prueba2', '$2y$10$dWw1F7QUnAKl75unasvWo.TH7xmzTYn5Gp1avjgBLPRfWMImWuR0m', 2),
(25, 'Sosa8', 'Sosa8', '$2y$10$w7CfoIt1IF1HO0pxfYrT3u/VKyZwoUtOLRjbHavWxs5F1UZI8JLCi', 4),
(26, 'Luis Eduardo', 'Luis Eduardo', '$2y$10$kszQb6ilBjS0nqaLKZRWIOpw.y7VVsicSpbP4YHsRDodijcy0gXQK', 1),
(27, 'Luis Eduardo Lopez Orantes', 'Luis Eduardo Lopez Orantes', '$2y$10$0y24pA56tKw6TfqmaiGjy.RWtTqlAvjmnKjGpfqPyldZUJyrg1UB6', 4),
(28, 'Eduardo', 'Eduardo', '$2y$10$/N4vugy1xbUv8D3eBzzAkexEutA9smg1NzNkbeuXNTz2g0pVw2vp.', 3);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `calificaciones`
--
ALTER TABLE `calificaciones`
  ADD CONSTRAINT `calificaciones_ibfk_1` FOREIGN KEY (`estudiante_id`) REFERENCES `estudiantes` (`id`),
  ADD CONSTRAINT `calificaciones_ibfk_2` FOREIGN KEY (`asignatura_id`) REFERENCES `asignaturas` (`id`);

--
-- Filtros para la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD CONSTRAINT `estudiantes_ibfk_1` FOREIGN KEY (`id_section`) REFERENCES `section` (`id`),
  ADD CONSTRAINT `estudiantes_ibfk_4` FOREIGN KEY (`id_grade`) REFERENCES `grado` (`id`),
  ADD CONSTRAINT `estudiantes_ibfk_5` FOREIGN KEY (`id_grade`) REFERENCES `grado` (`id`);

--
-- Filtros para la tabla `horario`
--
ALTER TABLE `horario`
  ADD CONSTRAINT `horario_ibfk_1` FOREIGN KEY (`id_grado`) REFERENCES `grado` (`id`),
  ADD CONSTRAINT `horario_ibfk_2` FOREIGN KEY (`id_section`) REFERENCES `section` (`id`);

--
-- Filtros para la tabla `horarios`
--
ALTER TABLE `horarios`
  ADD CONSTRAINT `horarios_ibfk_1` FOREIGN KEY (`id_profesor`) REFERENCES `profesores` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD CONSTRAINT `prestamos_ibfk_1` FOREIGN KEY (`id_estudiante`) REFERENCES `estudiantes_login` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prestamos_ibfk_2` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
