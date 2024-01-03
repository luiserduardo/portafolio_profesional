<?php
require_once('../../db/db.php');
require_once('fpdf/fpdf.php');

if (isset($_POST['gradeid']) && isset($_POST['subjectid'])) {

    // Obtener los valores POST
    $gradeid = $_POST['gradeid'];
    $subjectid = $_POST['subjectid'];

    // Para obtener el grado
    $gradeQuery = "SELECT nombre FROM grado WHERE id = ?";
    if ($gradeStmt = $con->prepare($gradeQuery)) {
        $gradeStmt->bind_param("i", $gradeid);
        $gradeStmt->execute();
        $gradeResult = $gradeStmt->get_result();

        if ($gradeResult && $gradeRow = $gradeResult->fetch_assoc()) {
            $gradeName = $gradeRow['nombre'];
        } else {
            $gradeName = "Grado Desconocido";
        }

        $gradeStmt->close();
    } else {
        echo "Error al obtener el grado";
        exit();
    }

    $query = "SELECT score.score, score.date_register, sb.nombre AS subject_name, estudiantes.nombre as student_name
              FROM score 
              INNER JOIN asignaturas AS sb ON score.id_subject = sb.id
              INNER JOIN estudiantes ON score.student_id = estudiantes.id
              WHERE score.id_subject = ? AND estudiantes.id_grade = ?";

    if ($stmt = $con->prepare($query)) {
        $stmt->bind_param("ii", $subjectid, $gradeid);
        $stmt->execute();
        $result = $stmt->get_result();

        if ($result) {

            // Crear un nuevo objeto PDF
            $pdf = new FPDF();
            $pdf->AddPage();

            //título
            $pdf->SetFont('Arial', 'B', 16);
            $row = $result->fetch_assoc();
            $pdf->Cell(0, 10, $row['subject_name'], 0, 1, 'C');
            $pdf->Ln();
            $pdf->Cell(0, 10, "Grado: " . $gradeName, 0, 1, 'C');
            $pdf->Ln();

            // Cabecera c
            $pdf->SetFont('Arial', 'B', 11);
            $pdf->SetX(40);
            $pdf->Cell(40, 10, 'Estudiante', 1);
            $pdf->Cell(40, 10, 'Nota', 1);
            $pdf->Cell(50, 10, 'Fecha', 1);
            $pdf->Ln(); // Salto 


            // $pdf->Image('logo.png', 10, 20, 30); 

            while ($row = $result->fetch_assoc()) {
                $pdf->SetFont('Arial', '', 9);
                $pdf->SetX(40);
                $pdf->Cell(40, 10, $row['student_name'], 1);
                $pdf->Cell(40, 10, $row['score'], 1);
                $pdf->Cell(50, 10, $row['date_register'], 1);
                $pdf->Ln();
            }

            // Generar el PDF
            $pdf->Output();


            exit();
        } else {
            echo "La consulta SQL no devolvió resultados.";
        }
    } else {
        echo "Error ";
    }

    $stmt->close();
}

$con->close();
