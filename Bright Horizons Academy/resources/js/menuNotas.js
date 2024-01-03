$(document).ready(function () {
    // Función para abrir y cerrar el menú desplegable
    function toggleDropdown() {
        var dropdown = $(".dropdown-content");
        dropdown.toggle();
    }

    // Agregar un evento clic al botón del menú
    $(".dropbtn").click(toggleDropdown);

    // Cerrar el menú desplegable cuando se hace clic en cualquier otro lugar de la página
    $(document).click(function (event) {
        if (!$(event.target).is(".dropbtn")) {
            var dropdowns = $(".dropdown-content");
            dropdowns.hide();
        }
    });
});
