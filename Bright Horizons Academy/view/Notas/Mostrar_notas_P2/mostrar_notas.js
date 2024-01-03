$(document).ready(function () {
    var gradeid = "";
    var subjectid = "";
    // Para controlar si las notas estan visibles (Estado)
    var notasVisibles = false;

    $("#grade").on('change', function () {
        gradeid = $("#grade").val();
    });

    $("#subject").on('change', function () {
        subjectid = $("#subject").val();
    });

    // Función para mostrar las notas 
    function mostrarNotas() {
        if (gradeid !== "" && subjectid !== "") {
           
            $.ajax({
                method: "POST",
                url: "obtener_notas.php",
                data: {
                    gradeid: gradeid,
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
            alert("Por favor, selecciona un estudiante antes de mostrar las notas.");
        }
    }

    // Función para ocultar las notas
    function ocultarNotas() {
        // Vaciar tabla de notas
        $("#tabla_notas").html("");
        // Cambiar el estado a "notas no visibles"
        notasVisibles = false;

    }


    // Función para mostrar los resultados de búsqueda
    function mostrarResultadosBusqueda(resultados) {
        var tablaHTML = '<table>';
        tablaHTML += '<thead><tr><th>Estudiante</th><th>Nota</th><th>Fecha de Registro</th></tr></thead>';
        tablaHTML += '<tbody>';
        resultados.forEach(function (row) {
            tablaHTML += `<tr><td>${row.student_name}</td><td>${row.score}</td><td>${row.date_register}</td></tr>`;
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
                    busqueda: textoBusqueda
                },
                dataType: "json",
                success: function (data) {
                    // Mostrar los resultados de búsqueda 
                    mostrarResultadosBusqueda(data);
                    // Cambiar el estado a al buscar aa "notas no visibls
                    notasVisibles = false;
                    // Vaciar la tabla principal
                    $("#tabla_notas").html("");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    // jqXHR es un objeto que da info sobre el estado de la silicitud
                    // textStatus cadena sobre el error
                    // errorThrown descripcion detallada del problema
                    console.error("Error en la solicitud  " + textStatus, errorThrown);
                }
            });
        }
    });


});
