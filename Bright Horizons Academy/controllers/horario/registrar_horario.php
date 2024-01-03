<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtén los valores del formulario
    $grado = $_POST["grado"];
    $seccion = $_POST["seccion"];
    $dia = $_POST["dia"];
    $horas = $_POST["hora"];
    $materias = $_POST["materia"];

    // Realiza la conexión a la base de datos (Asegúrate de configurar tus credenciales)
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "users";

    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Error de conexión a la base de datos: " . $conn->connect_error);
    }

    // Obtén el ID del grado y la sección
    $grado_id = $_POST["grado"];
    $seccion_id = $_POST["seccion"];

    // Itera a través de las horas y materias para insertar múltiples registros en la tabla horario
    for ($i = 0; $i < count($horas); $i++) {
        $hora = $horas[$i];
        $materia = $materias[$i];

        // Construye la consulta SQL para insertar el horario
        $sql = "INSERT INTO horario (id_grado, id_section, dia, hora_inicio, hora_fin, materia)
                VALUES ('$grado_id', '$seccion_id', '$dia', '$hora', '$hora', '$materia')";

        if ($conn->query($sql) !== TRUE) {
            echo "Error al guardar el horario: " . $conn->error;
        }
    }

    // Después de guardar los horarios con éxito, puedes redirigir a una página de visualización
    header("Location: ../../view/ver_horarios.php");

    // Cierra la conexión a la base de datos
    $conn->close();
} else {
    // Redirecciona o muestra un mensaje de error si no se envió el formulario
    echo "Error: El formulario no se ha enviado correctamente.";
}
