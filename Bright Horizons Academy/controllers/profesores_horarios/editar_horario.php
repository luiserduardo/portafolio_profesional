<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editar horario</title>
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
                    <a href="../controllers/admin.php" class="nav__links">Inicio</a>
                </li>

                <li class="nav__items">
                    <a href="../controllers/cerrar_sesion.php" class="nav__links">Cerrar sesión</a>
                </li>

                <img src="../images/close.svg" class="nav__close">
            </ul>

            <div class="nav__menu">
                <img src="../images/menu.svg" class="nav__img">
            </div>
        </nav>

        <section class="hero__container container">
            <h1 class="hero__title">Bright Horizons Academy</h1>
            <p class="hero__title">gestión de asistencia de profesores</p>
        </section>
    </header>
    <h1>Editar Horario</h1>

    <?php
    // Verificar si se ha enviado un ID a través de la URL
    if (isset($_GET['id'])) {
        $horario_id = $_GET['id'];

        // Conectar a la base de datos
        $con = mysqli_connect("localhost", "root", "", "users");
        if (mysqli_connect_errno()) {
            die("Error al conectar con la base de datos: " . mysqli_connect_error());
        }

        // Obtener el horario correspondiente al ID enviado
        $query = "SELECT * FROM horarios WHERE id = $horario_id";
        $result = mysqli_query($con, $query);

        // Verificar si el horario existe
        if (mysqli_num_rows($result) === 1) {
            $horario = mysqli_fetch_assoc($result);
        } else {
            die("Horario no encontrado.");
        }

        // Verificar si se ha enviado el formulario de edición
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $fecha = $_POST['fecha'];
            $hora_inicio = $_POST['hora_inicio'];
            $hora_fin = $_POST['hora_fin'];

            // Actualizar el horario en la base de datos
            $query_update = "UPDATE horarios SET fecha = '$fecha', hora_inicio = '$hora_inicio', hora_fin = '$hora_fin' WHERE id = $horario_id";
            if (mysqli_query($con, $query_update)) {
                echo "Horario actualizado exitosamente.";
                echo "<script>
                setTimeout(function() {
                    window.location.href='buscar_horario.php'; // Regresar a la página anterior
                }, 1000); // 3000 milisegundos (3 segundos)
            </script>";
            } else {
                echo "Error al actualizar el horario: " . mysqli_error($con);
            }
        }

        mysqli_close($con);
    } else {
        die("ID de horario no especificado.");
    }
    ?>

    <!-- Formulario de edición de horario -->
    <form action="editar_horario.php?id=<?php echo $horario_id; ?>" method="post">
        <label for="fecha">Fecha:</label>
        <input type="date" name="fecha" value="<?php echo $horario['fecha']; ?>" required>
        <br>
        <label for="hora_inicio">Hora Inicio:</label>
        <input type="time" name="hora_inicio" value="<?php echo $horario['hora_inicio']; ?>" required>
        <br>
        <label for="hora_fin">Hora Fin:</label>
        <input type="time" name="hora_fin" value="<?php echo $horario['hora_fin']; ?>" required>
        <br>
        <input type="submit" value="Guardar Cambios">
    </form>
    <br>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>