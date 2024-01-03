var chart;

$(document).ready(function () {
    $('#submitBtn').click(function () {
        var gradoSeleccionado = $('#grado').val();

        // Eliminar el gráfico anterior si existe, por que? Se daba el problema de que al seleccionar otra opcion esta no cambiaba
        if (chart) {
            chart.destroy();
            // para destruir el grafico
        }

        // Enviar el grado seleccionado al servidor, parte de solicitud ajax por medio de post
        $.post("procesoPromedio.php", {

            grado: gradoSeleccionado
        }, function (data) {
            if (Array.isArray(data) && data.length > 0) {
                // Array.isArray sirve para saber si el dato es una array
                // data.length para determinar la cantidad de elementos

                // Procesa los datos y genera gráficos
                var labels = data.map(item => item.asignatura);
                // De donde sale Asignatura? Asignatura sale de la consulta, recordar que en este contexto Asignatura = Asignatura.nombre
                // es equivalente a var labels = data.map(item => item['Asignatura.nombre']);
                // data es un arreglo, .map es una funcion que se utiliza para iterar cada elemnetos y crear un nuevo array
                // => especifica como se debe de aplicar la funcion map
                // item => item.grado extrae la propiedad de cada elementos (item) Asignatura

                var promedios = data.map(item => item.promedio);

                var ctx = document.getElementById('chart-container').getContext('2d');

                chart = new Chart(ctx, {
                    // la linea anterior se encarga de instanciar(crear un objeto a partir de una clase) un nuevo objeto llamado Chart

                    type: 'bar',
                    // define el tipo de grafico type: 'bar',

                    data: {
                        labels: labels,
                        // label contiene los valores
                        datasets: [{
                            label: 'Promedio de Notas',
                            data: promedios,
                            backgroundColor: 'rgba(50,150,200,0.3)',
                            borderColor: 'rgba(50,150,200,1)',
                            borderWidth: 2
                        }]
                    },
                });
            } else {
                console.error("Los datos recibidos no son válidos.");
            }
        }).fail(function () {
            console.error("Error en la solicitud AJAX.");
        });
    });
});