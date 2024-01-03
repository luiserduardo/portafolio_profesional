<!DOCTYPE html>
<html lang="en">

<head>
    <title>Formulario de Horarios</title>
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../resources/css/horarioo.css">
    <link rel="stylesheet" href="../../resources/css/style.css">
    <link rel="stylesheet" href="../../resources/css/em2.css">
</head>

<body>
    <h1>Crear Horario Escolar</h1>
    <form action="registrar_horario.php" method="POST">
        <label for="grado">Grado:</label>
        <select name="grado" required>
            <option value="">Seleccione el grado</option>
            <?php
            require '../../models/db_connection.php';

            $query = "SELECT id, nombre FROM grado ORDER BY nombre ASC";
            $result = mysqli_query($con, $query);

            if (mysqli_num_rows($result) > 0) {
                while ($row = mysqli_fetch_assoc($result)) {
                    echo "<option value='" . $row['id'] . "'>" . $row['nombre'] . "</option>";
                }
            } else {
                echo "<option disabled>No se encontraron grados.</option>";
            }

            mysqli_close($con);
            ?>
        </select><br>

        <label for="seccion">Sección:</label>
        <select name="seccion" required>
            <option value="">Seleccione la sección</option>
            <?php
            require '../../models/db_connection.php';

            $query = "SELECT id, name FROM section ORDER BY name ASC";
            $result = mysqli_query($con, $query);

            if (mysqli_num_rows($result) > 0) {
                while ($row = mysqli_fetch_assoc($result)) {
                    echo "<option value='" . $row['id'] . "'>" . $row['name'] . "</option>";
                }
            } else {
                echo "<option disabled>No se encontraron secciones.</option>";
            }

            mysqli_close($con);
            ?>
        </select>

        <br>
        <label for="dia">Día:</label>
        <input type="text" name="dia" required><br>

        <label for="hora_inicio">Hora de Inicio:</label>
        <input type="time" name="hora_inicio" required><br>

        <label for="hora_fin">Hora de Fin:</label>
        <input type="time" name="hora_fin" required><br>

        <div id="calendario">
            <h2>Calendario Escolar</h2>
            <table>
                <thead>
                    <tr>
                        <th>Hora</th>
                        <th>Materia</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    // Crear filas para cada hora del día
                    for ($i = 1; $i <= 8; $i++) {
                        echo "<tr>";
                        echo "<td><input type='time' name='hora[]' required></td>";
                        echo "<td><div class='materia-container'><input type='text' name='materia[]' required></div></td>";
                        echo "</tr>";
                    }
                    ?>
                </tbody>


            </table>
        </div>

        <input type="submit" value="Guardar Horario">
    </form>
    <script src="../../resources/js/em2.js"></script>
    <script src="../../resources/js/slider.js"></script>
    <script src="../../resoures/js/questions.js"></script>
    <script src="../../resources/js/menu.js"></script>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="../../resources/js/des.js"></script>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>