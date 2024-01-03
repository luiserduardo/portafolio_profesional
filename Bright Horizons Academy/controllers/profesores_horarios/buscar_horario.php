<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Buscar Horario por Fecha</title>
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../resources/css/estilos.css">
    <link rel="stylesheet" href="../../resources/css/style.css">
</head>

<body>
    <header class="hero">
        <nav class="nav container">
            <div class="nav__logo">
                <h2 class="nav__title">Bright Horizons Academy.</h2>
            </div>

            <ul class="nav__link nav__link--menu">

                <li class="nav__items">
                    <a href="../../view/admin.php" class="nav__links">Inicio</a>
                </li>

                <li class="nav__items">
                    <a href="../cerrar_sesion.php" class="nav__links">Cerrar sesión</a>
                </li>

                <img src="../../resoruces/img/close.svg" class="nav__close">
            </ul>

            <div class="nav__menu">
                <img src="../../resoruces/img/menu.svg" class="nav__img">
            </div>
        </nav>

        <section class="hero__container container">
            <h1 class="hero__title">Bright Horizons Academy</h1>
            <p class="hero__title">gestión de asistencia de profesores</p>
        </section>
    </header>
    <br>
    <h1>Buscar Horario por Fecha</h1>

    <!-- Formulario de búsqueda por fecha -->
    <form action="buscar_horario.php" method="post">
        <label for="fecha">Buscar por fecha:</label>
        <input type="date" name="fecha" required>
        <input type="submit" value="Buscar">
    </form>
    <br>

    <section id="lista-profesores" class="container">
        <?php
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $fecha = $_POST['fecha'];

            // Conectar a la base de datos
            $con = mysqli_connect("localhost", "root", "", "users");
            if (mysqli_connect_errno()) {
                die("Error al conectar con la base de datos: " . mysqli_connect_error());
            }

            // Obtener la lista de horarios por fecha
            $query = "SELECT horarios.*, profesores.nombre AS nombre_profesor 
                  FROM horarios 
                  INNER JOIN profesores ON horarios.id_profesor = profesores.id 
                  WHERE horarios.fecha = '$fecha'";
            $result = mysqli_query($con, $query);

            // Mostrar la tabla de horarios encontrados
            echo "<h2>Horarios encontrados para la fecha: $fecha</h2>";
            echo "<table border='1'>
                <tr>
                    <th>ID</th>
                    <th>Fecha</th>
                    <th>Hora Inicio</th>
                    <th>Hora Fin</th>
                    <th>Profesor</th>
                    <th>Acciones</th>
                </tr>";

            while ($row = mysqli_fetch_array($result)) {
                echo "<tr>";
                echo "<td>" . $row['id'] . "</td>";
                echo "<td>" . $row['fecha'] . "</td>";
                echo "<td>" . $row['hora_inicio'] . "</td>";
                echo "<td>" . $row['hora_fin'] . "</td>";
                echo "<td>" . $row['nombre_profesor'] . "</td>";
                echo "<td><a href='editar_horario.php?id=" . $row['id'] . "'>Editar</a> | <a href='eliminar_horario.php?id=" . $row['id'] . "'>Eliminar</a></td>";
                echo "</tr>";
            }

            echo "</table>";

            mysqli_close($con);
        }
        ?>
    </section>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>

</body>

</html>