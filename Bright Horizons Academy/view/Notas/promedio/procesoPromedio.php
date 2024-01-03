<?php

header('Content-Type: application/json');

require_once('../db/db.php');

// Prueba 1...
// $sql = "SELECT g.nombre AS grado, AVG(s.score) AS promedio
// FROM estudiantes e
// INNER JOIN score s ON e.id = s.student_id
// INNER JOIN grado g ON e.id_grade = g.id
// WHERE g.nombre = 'Primer año'
// GROUP BY g.nombre";


$grado_deseado = $_POST["grado"]; 


$sql = "SELECT a.nombre AS asignatura, AVG(s.score) AS promedio
FROM score s
INNER JOIN estudiantes e ON s.student_id = e.id
INNER JOIN asignaturas a ON s.id_subject = a.id
INNER JOIN grado g ON e.id_grade = g.id
WHERE g.nombre = '$grado_deseado'
GROUP BY a.nombre";

// selecciona nombre de asignaturas como asignaturas, saca el promedio del campo score de la tabla score como promedio
// de la tabla score
// unir estudiantes con score id igual a estudiantes id
// unir asignaturas con score id_subject igual a asignaturas id
// donde grado nombre sea igual al dato mandado por post
// agrupar por nombre grado

$result = $con->query($sql);

$data = array();
while ($row = $result->fetch_assoc()) {
    $data[] = $row;
}

$con->close();

// Devolver los datos en formato JSON
echo json_encode($data);
