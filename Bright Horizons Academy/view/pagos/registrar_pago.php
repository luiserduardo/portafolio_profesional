<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Registrar Nuevo Pago</title>
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
  <br><br><br><br><br><br>
  <?php
  // Procesar el formulario cuando se envía
  if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Conectar a la base de datos
    $conexion = mysqli_connect("localhost", "root", "", "users");

    // Verificar la conexión
    if (!$conexion) {
      die("Error al conectar a la base de datos: " . mysqli_connect_error());
    }

    // Recuperar datos del formulario
    $id_estudiante = $_POST['id_estudiante'];
    $pago_mensual = $_POST['pago_mensual'];
    $pago_matricula = $_POST['pago_matricula'];
    $becado = $_POST['becado'];
    $mes = $_POST['mes'];

    // Insertar los datos del pago en la base de datos
    $sql = "INSERT INTO pagos (id_estudiante, pago_mensual, pago_matricula, becado, mes) VALUES ('$id_estudiante', '$pago_mensual', '$pago_matricula', '$becado', '$mes')";

    if (mysqli_query($conexion, $sql)) {
      echo "Pago registrado exitosamente.";
    } else {
      echo "Error al registrar el pago: " . mysqli_error($conexion);
    }

    // Cerrar la conexión a la base de datos
    mysqli_close($conexion);
  }
  ?>

  <form action="registrar_pago.php" method="post">
    <label for="id_estudiante">ID del Estudiante:</label>
    <input type="text" name="id_estudiante" required>

    <label for="pago_mensual">Pago Mensual:</label>
    <input type="text" name="pago_mensual" required>

    <label for="pago_matricula">Pago Matrícula:</label>
    <input type="text" name="pago_matricula" required>

    <label for="becado">¿Es becado?</label>
    <input type="radio" name="becado" value="si"> Sí
    <input type="radio" name="becado" value="no" checked> No

    <label for="mes">Mes:</label>
    <select name="mes">
      <option value="Enero">Enero</option>
      <option value="Febrero">Febrero</option>
      <option value="Marzo">Marzo</option>
      <option value="Abril">Abril</option>
      <option value="Mayo">Mayo</option>
      <option value="Junio">Junio</option>
      <option value="Julio">Julio</option>
      <option value="Agosto">Agosto</option>
      <option value="Septiembre">Septiembre</option>
      <option value="Octubre">Octubre</option>
      <option value="Noviembre">Noviembre</option>
      <option value="Diciembre">Diciembre</option>

      <!-- Agregar opciones para los demás meses -->
    </select>

    <input type="submit" value="Registrar Pago">
  </form>
</body>

</html>