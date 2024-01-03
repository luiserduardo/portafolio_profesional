// acceder al contenedor
const contenedorItem = document.getElementById('contenedor-Libros');
// Json solicitud
// api
// idicamos url
fetch('json/cargar_libros/movies.json')
// then luego sirve para accder a la repuesta, tratar formato json
  .then(response => response.json())
  .then(data => {
  // <!-- edu -->
    data.forEach(item => {
      const div = document.createElement('div');
      div.classList.add('item');
      div.innerHTML = `
      <img src=${item.poster} alt="">
      <h3> Título:  ${item.titulo}</h3>
      <h3>Género: ${item.genero}</h3>
      <h3>Año: ${item.anio}</h3>
        <h3> Director:  ${item.director}</h3>
        <h3> Sinopsis:  ${item.sinop}</h3>
        <button id="agregar${item.id}" class="boton-agregar">Agregar <i class="fas fa-shopping-cart"></i></button>
      `;

      contenedorItem.appendChild(div);

    });
  });