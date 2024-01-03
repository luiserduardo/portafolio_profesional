<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Horario Individual</title>
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../resources/css/horario.css">
    <link rel="stylesheet" href="../../resources/css/style.css">
    <link rel="stylesheet" href="../../resources/css/em2.css">
</head>

<body>
    <div class="horario-container">
        <?php
        // Verifica si se ha enviado el formulario
        if ($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["grado"]) && isset($_GET["seccion"])) {
            // Obtén los valores del grado y sección desde la URL
            $grado_id = $_GET["grado"];
            $seccion_id = $_GET["seccion"];

            // Realiza la conexión a la base de datos (Asegúrate de configurar tus credenciales)
            $servername = "localhost";
            $username = "root";
            $password = "";
            $dbname = "users";

            $conn = new mysqli($servername, $username, $password, $dbname);

            if ($conn->connect_error) {
                die("Error de conexión a la base de datos: " . $conn->connect_error);
            }

            // Consulta la base de datos para obtener los nombres de grado y sección
            $grado_query = "SELECT nombre FROM grado WHERE id = $grado_id";
            $seccion_query = "SELECT name FROM section WHERE id = $seccion_id";

            $grado_result = $conn->query($grado_query);
            $seccion_result = $conn->query($seccion_query);

            $grado_nombre = "";
            $seccion_nombre = "";

            if ($grado_result->num_rows > 0 && $seccion_result->num_rows > 0) {
                $grado_nombre = $grado_result->fetch_assoc()["nombre"];
                $seccion_nombre = $seccion_result->fetch_assoc()["name"];
            }

            // Consulta la base de datos para obtener los horarios correspondientes
            $sql = "SELECT * FROM horario WHERE id_grado = $grado_id AND id_section = $seccion_id ORDER BY dia, hora_inicio";
            $result = $conn->query($sql);

            if ($result->num_rows > 0) {
                $currentDay = "";
                echo "<h2>Horario para $grado_nombre - Sección $seccion_nombre</h2>";
                while ($row = $result->fetch_assoc()) {
                    if ($currentDay != $row["dia"]) {
                        if ($currentDay != "") {
                            echo "</tbody></table><br>"; // Cerrar la tabla del día anterior
                        }
                        echo "<h3>" . $row["dia"] . "</h3>"; // Mostrar el nuevo día
                        echo "<table>";
                        echo "<thead><tr><th>Hora</th><th>Materia</th></tr></thead>";
                        echo "<tbody>";
                        $currentDay = $row["dia"];
                    }
                    echo "<tr>";
                    echo "<td>" . $row["hora_inicio"] . " - " . $row["hora_fin"] . "</td>";
                    echo "<td>" . $row["materia"] . "</td>";
                    echo "</tr>";
                }
                echo "</tbody></table>";
            } else {
                echo "No se encontraron horarios para $grado_nombre - Sección $seccion_nombre.";
            }

            // Cierra la conexión a la base de datos
            $conn->close();
        } else {
            echo "Error: No se proporcionaron datos válidos.";
        }
        ?>
        <br>
        <button onclick="history.go(-1)">Volver</button> <!-- Botón para regresar a la página anterior -->
    </div>
    <footer class="footer">

        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>