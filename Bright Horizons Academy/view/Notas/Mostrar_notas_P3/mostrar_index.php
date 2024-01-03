<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mostrar Notas</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link rel="shortcut icon" href="../../../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../../../resources/css/normalize.css">
    <link rel="stylesheet" href="../../../resources/css/estilosNotas.css">
    <link rel="stylesheet" href="../../../resources/css/notas.css">

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
    
    <div id="centrado">
        <!-- Buscar barra -->
        <div id="busqueda_contenedor">
            <label for="busqueda">Buscar:</label>
            <input type="text" id="busqueda" required>
            <button id="buscarBtn">Buscar</button>
        </div>

        <!-- Generar -->
        <button id="generarBtn">Generar</button>

        <section class="opciones-generar" id="opcionesGenerar">
            <!-- Para generar PDF -->

            <form action="../generar/pdf/generar_pdf2.php" method="post" id="abrirPDF">
                <input type="hidden" name="gradeid" id="gradeid">
                <input type="hidden" name="subjectid" id="subjectid">
                <input type="hidden" name="sectionid" id="sectionid">
                <input type="submit" value="Generar PDF">
            </form>

            <!-- Para generar excel -->
            <form action="../generar/excel/generar_excel2.php" method="post" id="abrirExcel">
                <input type="hidden" name="gradeid" id="gradeid">
                <input type="hidden" name="subjectid" id="subjectid">
                <input type="hidden" name="sectionid" id="sectionid">
                <input type="submit" value="Generar Excel">
            </form>
        </section>

        <form action="obtener_notas.php" method="post">
            <div class="container col-md-4">
                <div class="form-group py-2">
                    <label for="grade"> Grado</label>
                    <select class="form-select" id="grade">
                        <option value="">Seleccionar grado</option>
                        <?php
                        require_once '../db/db.php';
                        $query = "SELECT * FROM grado";
                        $result = $con->query($query);
                        if ($result->num_rows > 0) {
                            while ($row = $result->fetch_assoc()) {
                                echo "<option value='" . $row['id'] . "'>" . $row['nombre'] . "</option>";
                            }
                        }
                        ?>
                    </select>
                </div>
                <div class="form-group py-2">
                    <div class="form-group py-2">
                        <label for="section">Sección</label>
                        <select class="form-select" id="section" name="section">
                            <option value="">Seleccionar sección</option>
                            <?php
                            $query = "SELECT * FROM section";
                            $result = $con->query($query);
                            if ($result->num_rows > 0) {
                                while ($row = $result->fetch_assoc()) {
                                    echo "<option value='" . $row['id'] . "'>" . $row['name'] . "</option>";
                                }
                            }
                            ?>
                        </select>
                    </div>
                    <div class="form-group py-2 ">
                        <label for="subject">Asignatura</label>
                        <select class="form-select" id="subject" name="asignatura">
                            <option value="">Seleccionar asignatura</option>
                            <?php
                            $query = "SELECT * FROM asignaturas";
                            $result = $con->query($query);
                            if ($result->num_rows > 0) {
                                while ($row = $result->fetch_assoc()) {
                                    echo "<option value='" . $row['id'] . "'>" . $row['nombre'] . "</option>";
                                }
                            }
                            ?>
                        </select>
                    </div>

                    <input type="button" value="Mostrar notas" id="Mostrar_notas">
                </div>
            </div>
        </form>

        <!-- Tabla -->
        <div id="tabla_notas">
            <!-- La tabla de notas se mostrará aquí -->
        </div>

        <div id="tabla_busqueda">
            <!-- La tabla de resultados de búsqueda se mostrará aquí -->
        </div>
    </div>

    <script src="../botones/botones.js"></script>
    <script src="mostrar_notas.js"></script>
    <script src="../generar/Js/pdf_excel_2.js"></script>

    <footer class="footer">
        <section class="footer__copy container">
            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>


</body>

</html>