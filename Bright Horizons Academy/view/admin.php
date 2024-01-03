<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin</title>
    <link rel="shortcut icon" href="../resources/img/hat.png" type="image/x-icon">
    <link rel="stylesheet" href="../resources/css/normalize.css">
    <link rel="stylesheet" href="../resources/css/style.css">
    <link rel="stylesheet" href="../resources/css/em2.css">
    <link rel="stylesheet" href="../resources/css/style2.css">
</head>

<body>
    <header class="hero">
        <nav class="nav container">
            <div class="nav__logo">
                <h2 class="nav__title">Bright Horizons Academy.</h2>
            </div>

            <ul class="nav__link nav__link--menu">

                <li class="nav__items">
                    <a href="admin.php" class="nav__links">Inicio</a>
                </li>

                <li class="option">
                    <a><button class="nav__dropdown-toggle">Profesores</button></a>
                    <div class="lista">
                        <p class="element"> <a href="secambioname.php" class="choice">G profesores</a></p>
                        <p class="element"> <a href="../controllers/profesores_horarios/agregar_horario.php" class="choice">Asistencias
                            </a></p>
                    </div>
                </li>

                <li class="option">
                    <a><button class="nav__dropdown-toggle2">Estudiantes</button></a>
                    <div class="lista2">
                        <p class="element"> <a href="../controllers/estudiante/adestudiantes.php" class="choice">G estudiantes</a>
                        </p>
                        <p class="element"> <a href="calendario/Admin/calendario.html" class="choice">G calendario</a>
                        </p>
                        <p class="element"> <a href="Notas/index.html" class="choice">Notas</a></p>
                        <p class="element"> <a href="pagos/index_pagos.php" class="choice">Pagos</a></p>
                        <p class="element"> <a href="../controllers/horario/horario.php" class="choice">Horario</a></p>
                    </div>
                </li>

                <li class="option">
                    <a><button class="nav__dropdown-toggle3">Otros</button></a>
                    <div class="lista3">
                        <p class="element"> <a href="admin_libros.php" class="choice">Biblioteca </a> </p>
                        <p class="element"> <a href="registro.html" class="choice">Usuarios</a></p>
                        <p class="element"> <a href="comentario.php" class="choice">Comentarios</a></p>

                    </div>
                </li>



                <li class="nav__items">
                    <a href="login.html" class="nav__links">Cerrar sesión</a>
                </li>



                <img src="../resources/img/close.svg" class="nav__close">
            </ul>

            <div class="nav__menu">
                <img src="../resources/img/menu.svg" class="nav__img">
            </div>
        </nav>

        <section class="hero__container container">
            <h1 class="hero__title">Bright Horizons Academy</h1>
            <p class="hero__title">Administrador</p>
            <a href="#" class="cta">Comienza ahora</a>
        </section>
    </header>

    </main>

    <footer class="footer">


        <section class="footer__copy container">

            <h3 class="footer__copyright">Derechos reservados &copy; Sistema de gestión escolar</h3>
        </section>
    </footer>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="../resources/js/slider.js"></script>
    <script src="../resoures/js/questions.js"></script>
    <script src="../resources/js/menu.js"></script>
    <script src="../resources/js/des.js"></script>
</body>

</html>