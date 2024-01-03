// Obtener el contenedor de productos
const contenedorProductos = document.getElementById('contenedor-productos');

// Inyectar el HTML de los productos en el contenedor
stockAlimentos.forEach((producto) => {
    const div = document.createElement('div');
    div.classList.add('producto');
    div.innerHTML = `
        <img src=${producto.img} alt="">
        <h3>${producto.nombre}</h3>
        <p>${producto.desc}</p>
        <p>tipo: ${producto.tipo}</p>
        <p class="precioProducto">Precio:$ ${producto.precio}</p>
    `;
    contenedorProductos.appendChild(div);
});

// Obtener elementos del carrito
const contenedorCarrito = document.getElementById('carrito-contenedor');
const botonVaciar = document.getElementById('vaciar-carrito');
const contadorCarrito = document.getElementById('contadorCarrito');
const cantidad = document.getElementById('cantidad');
const precioTotal = document.getElementById('precioTotal');
const cantidadTotal = document.getElementById('cantidadTotal');

let carrito = [];

// Agregar producto al carrito
const agregarAlCarrito = (prodId) => {
    const existe = carrito.some(prod => prod.id === prodId);

    if (existe) {
        carrito.forEach(prod => {
            if (prod.id === prodId) prod.cantidad++;
        });
    } else {
        const item = stockAlimentos.find(prod => prod.id === prodId);
        carrito.push(item);
    }

    actualizarCarrito();
};

// Eliminar producto del carrito
const eliminarDelCarrito = (prodId) => {
    const item = carrito.find(prod => prod.id === prodId);
    const indice = carrito.indexOf(item);

    carrito.splice(indice, 1);
    actualizarCarrito();
};

// Actualizar el contenido del carrito
const actualizarCarrito = () => {
    contenedorCarrito.innerHTML = "";

    carrito.forEach(prod => {
        const div = document.createElement('div');
        div.className = 'productoEnCarrito';
        div.innerHTML = `
            <p>${prod.nombre}</p>
            <p>Precio:$${prod.precio}</p>
            <p>Cantidad: <span id="cantidad">${prod.cantidad}</span></p>
            <button onclick="eliminarDelCarrito(${prod.id})" class="boton-eliminar">
                <i class="fas fa-trash-alt"></i>
            </button>
        `;

        contenedorCarrito.appendChild(div);
        localStorage.setItem('carrito', JSON.stringify(carrito));
    });

    contadorCarrito.innerText = carrito.length;
    precioTotal.innerText = carrito.reduce((acc, prod) => acc + prod.cantidad * prod.precio, 0);
};
