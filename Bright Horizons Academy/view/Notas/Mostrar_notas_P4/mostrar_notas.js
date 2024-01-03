$(document).ready(function () {
    // variables
    var gradeid = "";
    var seccionid = "";
    var subjectid = "";
    var studentid = "";

    // Para controlar si las notas estan visibles (Estado)
    var notasVisibles = false;

    // Manejar cambios en los select
    $("#grade").on('change', function () {
        gradeid = $("#grade").val();
        cargarEstudiantes();
    });

    $("#section").on('change', function () {
        seccionid = $("#section").val();
        cargarEstudiantes();
    });

    $("#subject").on('change', function () {
        subjectid = $("#subject").val();
        cargarEstudiantes();
    });

    $("#student").on('change', function () {
        studentid = $("#student").val();

    });



    // Función para cargar estudiantes en el dropdown
    function cargarEstudiantes() {
        if (gradeid !== "" && seccionid !== "") {
            $.ajax({
                method: "POST",
                url: "../agregar/response.php",
                data: {
                    id: gradeid,
                    sid: seccionid,
                },
                dataType: "html",
                success: function (data) {
                    $("#student").html(data);
                }
            });
        }
    }

    // Manejar el clic en el botón "Mostrar notas"
    function mostrarNotas() {
        if (gradeid !== "" && seccionid !== "" && subjectid !== "" && studentid !== "") {
            $.ajax({
                method: "POST",
                url: "obtener_notas.php",
                data: {
                    studentid: studentid,
                    gradeid: gradeid,
                    seccionid: seccionid,
                    subjectid: subjectid
                },
                dataType: "html",
                success: function (data) {
                    // Insertar los datos
                    $("#tabla_notas").html(data);

                    // Cambia el estado a "notas visibles"
                    notasVisibles = true;

                    // Vaciar la tabla de resultados de busqueda
                    $("#tabla_busqueda").html("");
                },

            });
        } else {
            alert("Por favor, selecciona los datos antes de mostrar las notas.");
        }
    }

    // Función para ocultar las notas
    function ocultarNotas() {
        // Vaciar tabla de notas
        $("#tabla_notas").html("");
        // Cambiar el estado a "notas no visibles"
        notasVisibles = false;

    }

    // / Función para mostrar los resultados de búsqueda
    function mostrarResultadosBusqueda(resultados) {
        var tablaHTML = '<table>';
        tablaHTML += '<thead><tr><th>Estudiante</th><th>Materia</th><th>Nota</th><th>Fecha de Registro</th></tr></thead>';
        tablaHTML += '<tbody>';

        // Iterar a través/ agregar filas a la tabla
        for (var i = 0; i < resultados.length; i++) {
            tablaHTML += '<tr>';
            tablaHTML += '<td>' + resultados[i].student_name + '</td>';
            tablaHTML += '<td>' + resultados[i].subject_name + '</td>';
            tablaHTML += '<td>' + resultados[i].score + '</td>';
            tablaHTML += '<td>' + resultados[i].date_register + '</td>';
            tablaHTML += '</tr>';
        }

        tablaHTML += '</tbody></table>';

        $("#tabla_busqueda").html(tablaHTML);
    }

    // Al dar clic en el botón "Mostrar Notas", alternar entre mostrar/ oultar
    $("#Mostrar_notas").on('click', function () {
        if (notasVisibles) {
            ocultarNotas();
        } else {
            mostrarNotas();
        }
    });

    // Agregar evento para el botón de búsqueda
    $("#buscarBtn").on('click', function () {
        var textoBusqueda = $("#busqueda").val().trim();
        if (textoBusqueda !== "") {
            $.ajax({
                method: "POST",
                url: "obtener_notas.php",
                data: {
                    gradeid: gradeid,
                    subjectid: subjectid,
                    seccionid: seccionid,
                    studentid: studentid,
                    busqueda: textoBusqueda
                },
                // Cambiar el tipo de datos a JSON
                dataType: "json",
                success: function (data) {
                    // Mostrar los resultados de búsqueda 
                    mostrarResultadosBusqueda(data);
                    // Cambiar el estado a al buscar aa "notas no visibls
                    notasVisibles = false;
                    // Vaciar la tabla principal
                    $("#tabla_notas").html("");
                }
            });
        }
    });
});