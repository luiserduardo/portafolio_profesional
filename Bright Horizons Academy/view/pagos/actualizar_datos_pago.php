<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Conectar a la base de datos
    $conexion = mysqli_connect("localhost", "root", "", "users");

    // Verificar la conexión
    if (!$conexion) {
        die("Error al conectar a la base de datos: " . mysqli_connect_error());
    }

    // Recuperar los datos enviados a través de la solicitud POST
    $pagoId = $_POST['pagoId'];
    $mes = $_POST['mes'];
    $estado = $_POST['estado'];

    // Preparar una consulta para actualizar los datos
    $consulta = "UPDATE pagos SET mes = '$mes', estado = '$estado' WHERE id_pago = '$pagoId'";

    // Ejecutar la consulta
    $resultado = mysqli_query($conexion, $consulta);

    if ($resultado) {
        echo "Datos actualizados con éxito";
    } else {
        echo "Error al actualizar los datos: " . mysqli_error($conexion);
    }

    // Cerrar la conexión a la base de datos
    mysqli_close($conexion);
} else {
    echo "Acceso no permitido";
}
?>
