$(function () {
  $('nav a').click(function (e) {
    e.preventDefault();

    const url = $(this).attr('href'); // Utilizamos const en lugar de var para declarar la constante url

    $.ajax({
      url: url,
      success: function (data) {
        $('#aquicontent').html(data);
      }
    });
  });
});

