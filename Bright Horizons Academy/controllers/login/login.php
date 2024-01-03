<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="../../resources/img/hat.png" type="image/x-icon">
    <title>Inicio de Sesión - Estudiantes</title>
    <link rel="stylesheet" href="../../resources/css/biblio.css">

</head>

<body>
    <div class="container">
        <img class="logo" src="../../resources/img/R.png" alt="Logo">
        <h1>Inicio de Sesión - Biblioteca</h1>
        <form action="../estudiante/login_estudiante.php" method="post">
            <label for="nombre">Nombre:</label>
            <input type="text" name="nombre" required>

            <label for="numero_identificacion">Número de Identificación:</label>
            <input type="password" name="numero_identificacion" required>

            <input type="submit" value="Iniciar Sesión">


        </form>

        <br>
        <a href="../../view/cliente.php" class="btn">Ir a la Página Principal</a>

    </div>
</body>

</html>