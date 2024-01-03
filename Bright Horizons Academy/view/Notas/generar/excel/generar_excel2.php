<?php
require_once '../../db/db.php';
require 'vendor/autoload.php';

use PhpOffice\PhpSpreadsheet\Spreadsheet;
use PhpOffice\PhpSpreadsheet\IOFactory;

$spreadsheet = new Spreadsheet();

$spreadsheet->getProperties()
    ->setCreator("Institucional")
    ->setLastModifiedBy("Institucional")
    ->setTitle("Datos de la Tabla")
    ->setSubject("Datos de la Tabla")
    ->setDescription("Datos de la tabla en un archivo Excel")
    ->setKeywords("excel datos tabla")
    ->setCategory("Datos");

// Crea una hoja 
$sheet = $spreadsheet->getActiveSheet();

// Títulos d
$sheet->setCellValue('A1', 'Estudiante');
$sheet->setCellValue('B1', 'Asignatura');
$sheet->setCellValue('C1', 'Nota');
$sheet->setCellValue('D1', 'Fecha');

// Verifica la coensxion
if ($con->connect_error) {
    die("Error de conexión: " . $con->connect_error);
}

$query = "SELECT score.score, score.date_register, sb.nombre AS subject_name, estudiantes.nombre as student_name
FROM score 
INNER JOIN asignaturas AS sb ON score.id_subject = sb.id
INNER JOIN estudiantes  ON score.student_id = estudiantes.id";

$result = $con->query($query);

// Ayuda a controlar las filas, porque una ya está ocupada para los títulosss
$rowNumber = 2;

// Agrega los datos
while ($row = $result->fetch_assoc()) {
    $sheet->setCellValue('A' . $rowNumber, $row['student_name']);
    $sheet->setCellValue('B' . $rowNumber, $row['subject_name']);
    $sheet->setCellValue('C' . $rowNumber, $row['score']);
    $sheet->setCellValue('D' . $rowNumber, $row['date_register']);

    $rowNumber++;
}

$con->close();

header('Content-Type: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet');
header('Content-Disposition: attachment;filename="Notas.xlsx"');
header('Cache-Control: max-age=0');

$writer = IOFactory::createWriter($spreadsheet, 'Xlsx');
$writer->save('php://output');
exit; // ara evitar que se imprima "error"
