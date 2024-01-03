<?php
// var_dump($_POST);

require_once '../db/db.php';

// Verificar datos enviador por post
if (isset($_POST['gradeid']) && isset($_POST['seccionid']) && isset($_POST['subjectid'])) {


    // Verificacion 
    if ($con->connect_error) {
        die("Error de conexión a la base de datos: " . $con->connect_error);
    }

    // Obtener los valores de POST
    $gradeid = $_POST['gradeid'];
    $seccionid = $_POST['seccionid'];
    $subjectid = $_POST['subjectid'];

    // Verificar si se realiza una búsqueda
    if (isset($_POST['busqueda'])) {
        // Busqueda del texto
        $busqueda = $_POST['busqueda'];


        // Consulta para obtener las notas y nombre de materias
        $query = "SELECT score.score, score.date_register, sb.nombre AS subject_name, estudiantes.nombre as student_name
    FROM score 
    INNER JOIN asignaturas AS sb ON score.id_subject = sb.id
    INNER JOIN estudiantes ON score.student_id = estudiantes.id
    WHERE score.id_subject = $subjectid
    AND estudiantes.id_grade = $gradeid
    AND estudiantes.id_section = $seccionid
    AND (estudiantes.nombre LIKE '%$busqueda%' OR score.score LIKE '%$busqueda%')";


        //    Para comprobación de errores echo $query; 
        $result = $con->query($query);

        if ($result) {
            $resultados = array();
            while ($row = $result->fetch_assoc()) {
                $resultados[] = $row;
            }
            echo json_encode($resultados);
        } else {
            echo "Error ";
        }
    } else {
        // Mostrar todas las notas
        $query = "SELECT score.id, score.score, score.date_register, sb.nombre AS subject_name, estudiantes.nombre as student_name
FROM score 
INNER JOIN asignaturas AS sb ON score.id_subject = sb.id
INNER JOIN estudiantes ON score.student_id = estudiantes.id
WHERE score.id_subject = $subjectid
AND estudiantes.id_grade = $gradeid";

        $result = $con->query($query);

        if ($result) {
            $row = $result->fetch_assoc();

            // Para evitar error se comprueba si existe materia y estudiante
            if (isset($row['subject_name']) || isset($row['student_name'])) {
                echo "<h1>" . $row['subject_name'] . "</h1>";
                echo "<table>";
                echo "<tr><th>Estudiante</th><th>Nota</th><th>Fecha de Registro</th><th>Acción</th></tr>";

                while ($row = $result->fetch_assoc()) {
                    echo "<tr>";
                    echo "<td>" . $row['student_name'] . "</td>";
                    echo "<td>" . $row['score'] . "</td>";
                    echo "<td>" . $row['date_register'] . "</td>";
                    echo "<td>";
                    echo "<a href='../editar/editar.php?id=" . $row['id'] . "'>Editar</a>";
                    echo " | ";
                    echo "<a href='../eliminar/eliminar.php?id=" . $row['id'] . "'>Eliminar</a>";
                    echo "</td>";
                    echo "</tr>";
                }

                echo "</table>";
            }
        } else {
            echo "No hay datos registrados ";
        }
    }

    $con->close();
}