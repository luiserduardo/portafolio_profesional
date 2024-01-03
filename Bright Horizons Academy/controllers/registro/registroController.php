<?php
require_once('../../models/modelo.php'); //model
require_once('../config.php'); //config
$db = $GLOBALS['db']; // conexion desde config.php

$userModel = new UserModel($db);

// verifica si la solicitud http es de tipo POST
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nombre = $_POST['nombre'];
    $usuario = $_POST['usuario'];
    $contrasena = $_POST['contrasena'];
    $cargo = $_POST['cargo'];

    // Vrificar si hay algun campo vacío
    if (empty($nombre) || empty($usuario) || empty($contrasena) || empty($cargo)) {
        echo "Por favor, complete todos los campos.";
    } else {
        // campos llenos
        if ($userModel->createUser($nombre, $usuario, $contrasena, $cargo)) {
            echo "Usuario registrado exitosamente.";
            echo "<script>
            setTimeout(function() {
                alert('Usuario registrado exitosamente.');
                window.location.href = '../../view/login.html';
            }, 2000); // 2000 milisegundos (2 segundos)
        </script>";
        } else {
            echo "Error al registrar el usuario.";
        }
    }
}
