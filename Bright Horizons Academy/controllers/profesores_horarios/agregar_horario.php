<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agregar horarios</title>
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../resources/css/style.css">
    <link rel="stylesheet" href="../../resources/css/em2.css">
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

                <li class="option">
                    <a><button class="nav__dropdown-toggle">Profesores</button></a>
                    <div class="lista">
                        <p class="element"> <a href="../../view/secambioname.php" class="choice">G profesores</a></p>
                        <p class="element"> <a href="agregar_horario.php" class="choice">Asistencias
                            </a></p>
                    </div>
                </li>

                <li class="option">
                    <a><button class="nav__dropdown-toggle2">Estudiantes</button></a>
                    <div class="lista2">
                        <p class="element"> <a href="../estudiante/adestudiantes.php" class="choice">G estudiantes</a>
                        </p>
                        <p class="element"> <a href="../../view/calendario/Admin/calendario.html" class="choice">G calendario</a>
                        </p>
                        <p class="element"> <a href="../../view/Notas/index.html" class="choice">Notas</a></p>
                        <p class="element"> <a href="../../view/pagos/index_pagos.php" class="choice">Pagos</a></p>
                        <p class="element"> <a href="horario.php" class="choice">Horario</a></p>
                    </div>
                </li>

                <li class="option">
                    <a><button class="nav__dropdown-toggle3">Otros</button></a>
                    <div class="lista3">
                        <p class="element"> <a href="../../view/admin_libros.php" class="choice">Biblioteca </a> </p>
                        <p class="element"> <a href="../../view/registro.html" class="choice">Usuarios</a></p>
                        <p class="element"> <a href="../../view/comentario.php" class="choice">Comentarios</a></p>

                    </div>
                </li>



                <li class="nav__items">
                    <a href="../../view/login.html" class="nav__links">Cerrar sesión</a>
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

    <div id="centrado">
        <button id="botonagregar">Agregar horario de profesor</button>
    </div>



    <div id="miModal" class="modal">
        <div class="modal-contenido">
            <span class="cerrar" id="botonCerrar">&times;</span>
            <form action="agregar_horario.php" method="post" class="modal-formulario2">
                Fecha: <input type="date" name="fecha" required><br>
                Hora Inicio: <input type="time" name="hora_inicio" required><br>
                Hora Fin: <input type="time" name="hora_fin" required><br>
                Profesor:
                <select name="id_profesor" required>
                    <option value="">Seleccione un profesor</option>
                    <?php
                    $con = mysqli_connect("localhost", "root", "", "users");
                    if (mysqli_connect_errno()) {
                        die("Error al conectar con la base de datos: " . mysqli_connect_error());
                    }

                    $query = "SELECT id, nombre FROM profesores";
                    $result = mysqli_query($con, $query);

                    if (!$result) {
                        die("Error en la consulta: " . mysqli_error($con));
                    }

                    while ($row = mysqli_fetch_array($result)) {
                        echo "<option value='" . $row['id'] . "'>" . $row['nombre'] . "</option>";
                    }

                    mysqli_close($con);
                    ?>
                </select><br>
                <input type="submit" value="Agregar">
            </form>
        </div>
    </div>


    <div id="centrado">
        <button id="botonagregar2" class="botonhorario">Busqueda por fecha</button>
    </div>


    <div id="miModal2" class="modal2">
        <div class="modal-contenido2">
            <span class="cerrar2" id="botonCerrar2">&times;</span>
            <form action="buscar_horario.php" method="post" class="modal-formulario">
                <label for="fecha">Buscar por fecha:</label>
                <input type="date" name="fecha" required>
                <input type="submit" value="Buscar">
            </form>
        </div>
    </div>

    <br>
    <section id="lista-profesores" class="container">

        <?php

        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $fecha = $_POST['fecha'];
            $hora_inicio = $_POST['hora_inicio'];
            $hora_fin = $_POST['hora_fin'];
            $id_profesor = $_POST['id_profesor'];

            // Realizar la conexión a la base de datos
            $con = mysqli_connect("localhost", "root", "", "users");

            // Verificar si hubo un error en la conexión
            if (mysqli_connect_errno()) {
                die("Error al conectar con la base de datos: " . mysqli_connect_error());
            }

            // Crear la consulta SQL para insertar datos
            $insert_query = "INSERT INTO horarios (fecha, hora_inicio, hora_fin, id_profesor) 
         VALUES ('$fecha', '$hora_inicio', '$hora_fin', $id_profesor)";

            // Ejecutar la consulta
            $result_insert = mysqli_query($con, $insert_query);

            // Verificar si hubo un error en la consulta
            if (!$result_insert) {
                die("Error al insertar los datos: " . mysqli_error($con));
            }

            // Cerrar la conexión a la base de datos
            mysqli_close($con);

            // Recargar la página actual
            echo "<script>window.location.href='agregar_horario.php';</script>";
            exit();
        }


        // Mostrar la tabla de horarios
        $con = mysqli_connect("localhost", "root", "", "users");
        if (mysqli_connect_errno()) {
            die("Error al conectar con la base de datos: " . mysqli_connect_error());
        }

        $query = "SELECT horarios.*, profesores.nombre AS nombre_profesor 
          FROM horarios 
          INNER JOIN profesores ON horarios.id_profesor = profesores.id";
        $result = mysqli_query($con, $query);

        if (!$result) {
            die("Error en la consulta: " . mysqli_error($con));
        }

        echo "<table border='1'>
        <tr>
            <th>ID</th>
            <th>Fecha</th>
            <th>Hora Inicio</th>
            <th>Hora Fin</th>
            <th>Profesor</th>
        </tr>";

        while ($row = mysqli_fetch_array($result)) {
            echo "<tr>";
            echo "<td>" . $row['id'] . "</td>";
            echo "<td>" . $row['fecha'] . "</td>";
            echo "<td>" . $row['hora_inicio'] . "</td>";
            echo "<td>" . $row['hora_fin'] . "</td>";
            echo "<td>" . $row['nombre_profesor'] . "</td>";
            echo "</tr>";
        }

        echo "</table>";

        mysqli_close($con);
        ?>


    </section>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="../../resources/js/em2.js"></script>
    <script src="../../resources/js/des.js"></script>
    <script src="../../resources/js/slider.js"></script>
    <script src="../../resoures/js/questions.js"></script>
    <script src="../../resources/js/menu.js"></script>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>