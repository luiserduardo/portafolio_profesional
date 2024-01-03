// $('#inputBuscar') busca el elemento
// on evento que se dispara llenar input
$('#inputBuscar').on('input', function () {
    
    const valorBusqueda = $(this).val().toLowerCase();
    // this referencia el elemento seleccionado
    // val() obtener valor
    $('.item').each(function () {
        // text obtiene contenido
        const nombreItem = $(this).find('h3').text().toLowerCase();
        if (nombreItem.includes(valorBusqueda)) {
            $(this).show();
        } else {
            $(this).hide();
        }
    });
});


