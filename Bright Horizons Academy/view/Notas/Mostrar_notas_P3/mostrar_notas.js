$(document).ready(function () {

    // Mostrar notas tomando como base 3 elementos, grado-seccion-asignatura

    // variables
    var gradeid = "";
    var seccionid = "";
    var subjectid = "";

    // Para controlar si las notas estan visibles (Estado)
    var notasVisibles = false;

    // Manejar cambios en los select
    $("#grade").on('change', function () {
        gradeid = $("#grade").val();
    });

    $("#section").on('change', function () {
        seccionid = $("#section").val();
    });

    $("#subject").on('change', function () {
        subjectid = $("#subject").val();
    });


    // Al dar clic en el botón "Mostrar notas"
    function mostrarNotas() {
        if (gradeid !== "" && seccionid !== "" && subjectid !== "") {
            $.ajax({
                method: "POST",
                url: "obtener_notas.php",
                data: {
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
                error: function (jqXHR, textStatus, errorThrown) {
                    console.error("Error en la solicitud");
                }
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

        // Resultados, row.student_name son tomados de "obtener_notas.php"

        var tablaHTML = '<table>';
        tablaHTML += '<thead><tr><th>Estudiante</th><th>Materia</th><th>Nota</th><th>Fecha de Registro</th></tr></thead>';
        tablaHTML += '<tbody>';
        resultados.forEach(function (row) {
            tablaHTML += `<tr><td>${row.student_name}</td><td>${row.subject_name}</td><td>${row.score}</td><td>${row.date_register}</td></tr>`;
        });
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