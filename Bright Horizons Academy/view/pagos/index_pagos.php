<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestión de Pagos</title>
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../resources/css/pagos.css">
    <link rel="stylesheet" href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Poppins:wght@500;600&display=swap">
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap" rel="stylesheet" />
    <link rel="stylesheet" href="../../resources/css/classroom.css">

</head>

<body>
    <nav class="navbar">
        <div class="logo">
            <img src="../../resources/img/logoo2.png" />
            <h2>Bright Horizon Academy</h2>
        </div>
        <div class="links">
            <a href="../pagos/index_pagos.php">Inicio</a>
            <div class="dropdown">
                <a href="#">Explore
                    <img src="../../resources/img/chevron.png" />
                </a>
                <div class="menu">
                    <a href="../pagos/registrar_pago.php"> Registrar pagos</a>
                    <a href="../pagos/buscar_pago.php"> Buscar pago</a>
                </div>
            </div>
            <a href="../admin.php" class="join-link"> Salir </a>
        </div>
    </nav>
    <br><br><br>
    <h2>Lista de Pagos</h2>


    <table id="tablaPagos">
        <tr>
            <th>ID Pago</th>
            <th>ID Estudiante</th>
            <th>Pago Mensual</th>
            <th>Pago Matrícula</th>
            <th>Becado</th>
            <th>Mes</th>
            <th>Estado</th>
            <th>Confirmar</th>
        </tr>

        <?php
        // Conectar a la base de datos
        $conexion = mysqli_connect("localhost", "root", "", "users");

        // Verificar la conexión
        if (!$conexion) {
            die("Error al conectar a la base de datos: " . mysqli_connect_error());
        }

        // Consulta para obtener la lista de pagos
        $consulta = "SELECT * FROM pagos";
        $resultado = mysqli_query($conexion, $consulta);

        // Mostrar los resultados en la tabla
        while ($fila = mysqli_fetch_assoc($resultado)) {
            echo "<tr>";
            echo "<td>" . $fila['id_pago'] . "</td>";
            echo "<td>" . $fila['id_estudiante'] . "</td>";
            echo "<td>" . $fila['pago_mensual'] . "</td>";
            echo "<td>" . $fila['pago_matricula'] . "</td>";
            echo "<td>" . $fila['becado'] . "</td>";
            echo "<td>";
            echo "<select class='mes-select' data-original-value='" . $fila['mes'] . "' data-pago-id='" . $fila['id_pago'] . "'>";
            echo "<option value='enero'>Enero</option>";
            echo "<option value='febrero'>Febrero</option>";
            // Agrega opciones para los demás meses
            echo "</select>";
            echo "</td>";
            echo "<td>";
            echo "<select class='estado-select' data-pago-id='" . $fila['id_pago'] . "'>";
            echo "<option value='pendiente' " . ($fila['estado'] == 'pendiente' ? 'selected' : '') . ">Pendiente</option>";
            echo "<option value='pagado' " . ($fila['estado'] == 'pagado' ? 'selected' : '') . ">Pagado</option>";
            echo "</select>";
            echo "</td>";
            echo "<td><button class='confirm-button' data-pago-id='" . $fila['id_pago'] . "'>Confirmar</button></td>";
            echo "</tr>";
        }

        // Cerrar la conexión a la base de datos
        mysqli_close($conexion);
        ?>
    </table>
    <script src="../../resources/js/pagos.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

</body>

</html>