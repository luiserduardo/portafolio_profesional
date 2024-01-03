<?php
require_once('../../db/db.php');
require_once('fpdf/fpdf.php');


if (isset($_POST['gradeid']) && isset($_POST['subjectid']) && isset($_POST['sectionid']) && isset($_POST['studenid'])) {

    // Obtener los valores POST
    $gradeid = $_POST['gradeid'];
    $subjectid = $_POST['subjectid'];
    $sectionid = $_POST['sectionid'];
    $studenid = $_POST['studenid'];



    // modificar esta parte por si mas adelante se quieren agregar nuevos datos
    $query = "SELECT score.score, score.date_register, sb.nombre AS subject_name, estudiantes.nombre AS student_name, grado.nombre AS grade_name
    FROM score 
    INNER JOIN asignaturas AS sb ON score.id_subject = sb.id
    INNER JOIN estudiantes ON score.student_id = estudiantes.id
    INNER JOIN grado ON estudiantes.id_grade = grado.id
    WHERE score.id_subject = ? AND estudiantes.id_section = ? AND estudiantes.id_grade = ? AND estudiantes.id = ?
    ";

    if ($stmt = $con->prepare($query)) {
        $stmt->bind_param("iiii", $subjectid, $gradeid, $sectionid, $studenid);
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
            $pdf->Cell(0, 10, $row['grade_name'], 0, 1, 'C');
            $pdf->Ln();
            $pdf->Cell(0, 10, 'Estudiante', $row['student_name'], 1, 'C');

            // Cabecera c
            $pdf->SetFont('Arial', 'B', 11);
            $pdf->SetX(60);
            $pdf->Cell(40, 10, 'Nota', 1);
            $pdf->Cell(50, 10, 'Fecha', 1);
            $pdf->Ln(); // Salto 


            // $pdf->Image('logo.png', 10, 20, 30); 

            while ($row = $result->fetch_assoc()) {
                $pdf->SetX(60);
                $pdf->SetFont('Arial', '', 9);
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
} else {
    echo "Error";
}

$con->close();
