
var contenedorItem = document.getElementById('contenedor-Libros');
// Json solicitud
fetch('json/cargar_libros/movies.json')
.then(response => response.json())
.then(data => {
// <!-- edu -->
    data.forEach(item => {
        const div = document.createElement('div');
        div.classList.add('item');
        div.innerHTML = `
  <img src=${item.poster} alt="">
  <h3> Título:  ${item.titulo}</h3>
    <a id="detalle${item.id}" class="boton-detalle" href="main.html">Detalle <i class="fas fa-shopping-cart"></i></a>
  `;

        contenedorItem.appendChild(div);

    });
});