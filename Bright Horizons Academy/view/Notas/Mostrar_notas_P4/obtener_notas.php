<?php
require_once '../db/db.php';

// var_dump($_POST)
if (isset($_POST['gradeid']) && isset($_POST['seccionid']) && isset($_POST['subjectid']) && isset($_POST['studentid'])) {


    // Obtener los valores de POST
    $gradeid = $_POST['gradeid'];
    $seccionid = $_POST['seccionid'];
    $subjectid = $_POST['subjectid'];
    $studentid = $_POST['studentid'];

    if (isset($_POST['busqueda'])) {
        $busqueda = $_POST['busqueda'];

        $query = "SELECT s.score, s.date_register, st.nombre AS student_name, sb.nombre AS subject_name
                  FROM score AS s
                  INNER JOIN estudiantes AS st ON s.student_id = st.id
                  INNER JOIN asignaturas AS sb ON s.id_subject = sb.id
                  WHERE st.id_grade = $gradeid
                  AND st.id_section = $seccionid
                  AND s.id_subject = $subjectid
                  AND st.id = $studentid
                  AND (st.nombre LIKE '%$busqueda%' OR s.score LIKE '%$busqueda%')";

        $result = $con->query($query);

        if ($result) {
            $resultados = array();
            while ($row = $result->fetch_assoc()) {
                $resultados[] = $row;
            }
            echo json_encode($resultados);
        } else {
            echo "Error";
        }
    } else {
        // no busqueda 
        $query = "SELECT s.id, s.score, s.date_register, st.nombre AS student_name, sb.nombre AS subject_name
        FROM score AS s
        INNER JOIN estudiantes AS st ON s.student_id = st.id
        INNER JOIN asignaturas AS sb ON s.id_subject = sb.id
        WHERE st.id_grade = $gradeid
        AND st.id_section = $seccionid
        AND s.id_subject = $subjectid
        AND st.id = $studentid";

        $result = $con->query($query);

        $row = $result->fetch_assoc();

        if ($result->num_rows > 0) {

            echo "<h1>" . $row['subject_name'] . "</h1>";
            echo "<table>";
            echo "<tr><th>Estudiante</th><th>Materia</th><th>Nota</th><th>Fecha de Registro</th><th>Acción</th></tr>";

            while ($row = $result->fetch_assoc()) {
                echo "<tr>";
                echo "<td>" . $row['student_name'] . "</td>";
                echo "<td>" . $row['subject_name'] . "</td>";
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
        } else {
            echo "No se encontraron registros.";
        }
    }

    $con->close();
} else {
    echo "Faltan datos necesarios para obtener las notas.";
}