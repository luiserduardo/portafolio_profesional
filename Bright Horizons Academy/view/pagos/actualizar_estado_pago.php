<?php
// Verifica si se recibieron los datos necesarios
if (isset($_POST['pagoId']) && isset($_POST['estado'])) {
    // Conectar a la base de datos
    $conexion = mysqli_connect("localhost", "root", "", "users");

    // Verificar la conexión
    if (!$conexion) {
        die("Error al conectar a la base de datos: " . mysqli_connect_error());
    }

    // Recuperar los datos de la solicitud POST
    $pagoId = $_POST['pagoId'];
    $estado = $_POST['estado'];

    // Actualizar el estado en la base de datos
    $consulta = "UPDATE pagos SET estado = '$estado' WHERE id_pago = $pagoId";

    if (mysqli_query($conexion, $consulta)) {
        // La actualización se realizó con éxito
        echo "Estado de pago actualizado correctamente.";
    } else {
        // Hubo un error en la actualización
        echo "Error al actualizar el estado de pago: " . mysqli_error($conexion);
    }

    // Cerrar la conexión a la base de datos
    mysqli_close($conexion);
} else {
    // Datos insuficientes en la solicitud POST
    echo "Faltan datos para actualizar el estado de pago.";
}
?>
