<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Promedio de Notas por Grado</title>
    <!-- link css -->
    <link rel="shortcut icon" href="../../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../../resources/css/estilosNotas.css">
    <link rel="stylesheet" href="../../../resources/css/notas.css">

    <!-- script -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script src="promedio.js"></script>

</head>

<body>
    <header class="hero">
        <nav class="nav container">
            <div class="nav__logo">
                <h2 class="nav__title">Bright Horizons Academy.</h2>
            </div>

            <ul class="nav__link nav__link--menu">

                <li class="nav__items">
                    <a href="../../../view/admin.php" class="nav__links">Inicio</a>
                </li>

                <li class="nav__items">
                    <a href="../../../view/login.html" class="nav__links">Cerrar sesión</a>
                </li>

                <img src="../../../resources/img/close.svg" class="nav__close">
            </ul>

            <div class="nav__menu">
                <img src="../../../resources/img/menu.svg" class="nav__img">
            </div>
        </nav>


        <section class="hero__container container">
            <h1 class="hero__title">Sistema de gestión escolar</h1>
            <p class="hero__title">Gestión de notas</p>
        </section>
    </header>
    <div class="bloquePromedios ">
        <!-- formulario -->
        <form id="gradoForm">
            <label for="grado">Selecciona un grado:</label>
            <select id="grado" name="grado">
                <option value="">Seleccionar grado</option>
                <?php
                require_once '../db/db.php';
                $query = "SELECT * FROM grado";
                $result = $con->query($query);
                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<option value='" . $row['nombre'] . "'>" . $row['nombre'] . "</option>";
                    }
                }
                ?>
            </select>
            <button type="button" id="submitBtn">Generar Gráfico</button>
        </form>

        <!-- Grafico -->
        <canvas id="chart-container"></canvas>
    </div>
    <footer class="footer">
        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
</body>

</html>