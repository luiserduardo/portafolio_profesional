<!DOCTYPE html>
<html lang="en">

<head>
    <title>Horarios</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../resources/css/horario.css">
    <link rel="shortcut icon" href="../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../resources/css/normalize.css">
    <link rel="stylesheet" href="../resources/css/estilos.css">
</head>

<body>
    <header class="hero">
        <nav class="nav container">
            <div class="nav__logo">
                <img class="nav__logo" src="../resources/img/logoo2.png" alt="">
                <h2 class="nav__title">Bright Horizons Academy</h2>
            </div>

            <ul class="nav__link nav__link--menu">
                <li class="nav__items">
                    <a href="cliente.php" class="nav__links">Inicio</a>
                </li>
                <li class="nav__items">
                    <a href="calendario/usuarios/calendario.html" class="nav__links">Calendario</a>
                </li>
                <li class="nav__items">
                    <a href="contacto.html" class="nav__links">Contáctanos</a>
                </li>

                <li class="nav__items">
                    <a href="../controllers/login/login.php" class="nav__links">Biblioteca</a>
                </li>
                <li class="nav__items">
                    <a href="ver_horarios.php" class="nav__links">Horarios</a>
                </li>
                <li class="nav__items">
                    <a href="classroom/classroom.php" class="nav__links">Class</a>
                </li>
                <li class="nav__items">
                    <a href="login.html" class="nav__links">Cerrar sesión</a>
                </li>

                <img src="../resources/img/close.svg" class="nav__close">
            </ul>

            <div class="nav__menu">
                <img src="../resources/imgmenu.svg" class="nav__img">
            </div>
        </nav>

        <section class="hero__container container">
            <h1 class="hero__title">Bright Horizons Academy</h1>
            <p class="hero__title">Horarios</p>
        </section>
    </header>

    <div class="recuadros-grados-secciones">
        <?php
        // Realiza la conexión a la base de datos (Asegúrate de configurar tus credenciales)
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "users";

        $conn = new mysqli($servername, $username, $password, $dbname);

        if ($conn->connect_error) {
            die("Error de conexión a la base de datos: " . $conn->connect_error);
        }

        // Consulta la base de datos para obtener los grados y secciones disponibles
        $sql = "SELECT DISTINCT id_grado, id_section FROM horario";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $grado_id = $row["id_grado"];
                $seccion_id = $row["id_section"];

                // Consulta los nombres de grados y secciones utilizando las tablas grado y section
                $grado_query = "SELECT nombre FROM grado WHERE id = $grado_id";
                $seccion_query = "SELECT name FROM section WHERE id = $seccion_id";

                $grado_result = $conn->query($grado_query);
                $seccion_result = $conn->query($seccion_query);

                if ($grado_result->num_rows > 0 && $seccion_result->num_rows > 0) {
                    $grado_nombre = $grado_result->fetch_assoc()["nombre"];
                    $seccion_nombre = $seccion_result->fetch_assoc()["name"];
                    echo "<a class='recuadro' href='../controllers/horario/horario_individual.php?grado=$grado_id&seccion=$seccion_id'>";
                    echo "<div class='contenido-recuadro'>$grado_nombre - $seccion_nombre</div>";
                    echo "</a>";
                }
            }
        } else {
            echo "No se encontraron grados y secciones.";
        }

        // Cierra la conexión a la base de datos
        $conn->close();
        ?>
    </div>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>