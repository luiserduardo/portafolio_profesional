
// // esperar carga pagina
$(document).ready(function () {
    // Mostrar/ocultar el carrito
    $('#mostrarLibro').click(function () {
        $('.carrito').toggle();
    });
    // <!-- edu -->

    // Agregar 
    $('#contenedor-Libros').on('click', '.boton-agregar', function () {
        // Id item
        const itemID = $(this).attr('id'); // Obtener el ID del producto
        // nombre
        // busca dato hermono
        const nombre = $(this).siblings('h3').first().text();
        // text(); obtener el contenido
        // crear un elemento
        const libro = `<li>${nombre}</li>`;
        // agregar
        $('#listaLibros').append(libro);
    });
});
