<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Buscar Estudiante y Pagos</title>
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
  <br><br><br><br><br>


  <form action="" method="post">
    <label for="id_estudiante">ID del Estudiante:</label>
    <input type="text" name="id_estudiante" required>
    <input type="submit" value="Buscar">
  </form>

  <?php
  // Procesar la búsqueda cuando se envía el formulario
  if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Conectar a la base de datos
    $conexion = mysqli_connect("localhost", "root", "", "users");

    // Verificar la conexión
    if (!$conexion) {
      die("Error al conectar a la base de datos: " . mysqli_connect_error());
    }

    // Recuperar el ID del estudiante ingresado
    $id_estudiante = $_POST['id_estudiante'];

    // Consultar la información del estudiante y sus pagos
    $consulta_estudiante = "SELECT nombre FROM estudiantes WHERE id = '$id_estudiante'";
    $resultado_estudiante = mysqli_query($conexion, $consulta_estudiante);

    if ($resultado_estudiante && mysqli_num_rows($resultado_estudiante) > 0) {
      $fila_estudiante = mysqli_fetch_assoc($resultado_estudiante);
      $nombre_estudiante = $fila_estudiante['nombre'];

      echo "<h2>Información del Estudiante:</h2>";
      echo "ID del Estudiante: $id_estudiante<br>";
      echo "Nombre del Estudiante: $nombre_estudiante<br>";

      echo "<h2>Información de Pagos:</h2>";

      // Consultar los pagos del estudiante
      $consulta_pagos = "SELECT * FROM pagos WHERE id_estudiante = '$id_estudiante'";
      $resultado_pagos = mysqli_query($conexion, $consulta_pagos);

      if ($resultado_pagos && mysqli_num_rows($resultado_pagos) > 0) {
        echo "<table>";
        echo "<tr><th>ID Pago</th><th>Pago Mensual</th><th>Pago Matrícula</th><th>Becado</th><th>Mes</th><th>Estado</th></tr>";

        while ($fila_pago = mysqli_fetch_assoc($resultado_pagos)) {
          echo "<tr>";
          echo "<td>" . $fila_pago['id_pago'] . "</td>";
          echo "<td>" . $fila_pago['pago_mensual'] . "</td>";
          echo "<td>" . $fila_pago['pago_matricula'] . "</td>";
          echo "<td>" . $fila_pago['becado'] . "</td>";
          echo "<td>" . $fila_pago['mes'] . "</td>";
          echo "<td>" . $fila_pago['estado'] . "</td>";
          echo "</tr>";
        }

        echo "</table>";
      } else {
        echo "No se encontraron pagos para este estudiante.";
      }
    } else {
      echo "No se encontró un estudiante con el ID proporcionado.";
    }

    // Cerrar la conexión a la base de datos
    mysqli_close($conexion);
  }
  ?>

</body>

</html>