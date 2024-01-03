$(document).ready(function () {
    // Filtrar por mes
    $('#mesFilter').change(function () {
        var selectedMes = $(this).val();

        $('#tablaPagos tr').each(function () {
            var mesSelect = $(this).find('.mes-select');
            var mes = mesSelect.val();

            if (selectedMes === 'todos' || selectedMes === mes) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });

    // Manejar la lógica para bloquear el campo "Estado" y actualizar la base de datos
    $('.estado-select').change(function () {
        var selectedValue = $(this).val();
        $(this).prop('disabled', true);

        // Obtener el ID del pago desde el atributo "data-pago-id"
        var pagoId = $(this).data('pago-id');

        // Enviar una solicitud AJAX para actualizar el estado en la base de datos
        $.post('actualizar_estado_pago.php', { pagoId: pagoId, estado: selectedValue });
    });

    // Manejar la confirmación y actualización de datos
    $('.confirm-button').click(function () {
        var pagoId = $(this).data('pago-id');
        var mesSelect = $('[data-pago-id="' + pagoId + '"] .mes-select');
        var estadoSelect = $('[data-pago-id="' + pagoId + '"] .estado-select');
        var selectedMes = mesSelect.val();
        var selectedEstado = estadoSelect.val();

        // Enviar una solicitud AJAX para actualizar los datos en la base de datos
        $.post('actualizar_datos_pago.php', {
            pagoId: pagoId,
            mes: selectedMes,
            estado: selectedEstado
        });

        // Desactivar el botón de confirmación
        $(this).prop('disabled', true);
    });
});
