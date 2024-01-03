<?php
require_once 'conexionbiblio.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores del formulario
    $nombre = $_POST['nombre'];
    $correo = $_POST['correo'];
    $mensaje = $_POST['mensaje'];

    // Realizar las validaciones
    if (empty($nombre) || empty($correo) || empty($mensaje)) {
        echo "Por favor, completa todos los campos.";
        exit;
    }

    if (!filter_var($correo, FILTER_VALIDATE_EMAIL)) {
        echo "Por favor, ingresa un correo electrónico válido.";
        exit;
    }

    // Preparar la consulta SQL para insertar los datos en la tabla correspondiente
    $sql = "INSERT INTO tabla_contacto (nombre, correo, mensaje) VALUES ('$nombre', '$correo', '$mensaje')";

    // Ejecutar la consulta
    if ($conn->query($sql) === TRUE) {
        echo "Gracias por contactarnos. Nos pondremos en contacto contigo pronto.";
        echo "<script>
        setTimeout(function() {
            alert('Gracias por contactarnos. Nos pondremos en contacto contigo pronto.');
            window.location.href = '../view/contacto.html'; // Redirige a la nueva página
        }, 1000); // 2000 milisegundos (2 segundos)
        </script>";
    } else {
        echo "Error al procesar el formulario: " . $conn->error;
    }

    // Cerrar la conexión a la base de datos
    $conn->close();
}
