import React from 'react';

// Este componente representa un elemento individual de producto que se muestra en la lista de productos.
function ProductItem({ product, addToCart }) {
  // Desestructura las propiedades del producto
  const { id, Nombre, descripcion, precio, img } = product;

  // Convierte el precio a un número decimal para el formato correcto
  const precioNumero = parseFloat(precio);

  return (
    <div className="producto">
      {/* Renderiza la imagen del producto */}
      <img
        src={img}
        alt={`Imagen de ${Nombre}`}
        className=" producto-img"
        loading="lazy"
      />
      {/* Renderiza el nombre del producto */}
      <h5 >{Nombre}</h5>
      {/* Renderiza la descripción del producto */}
      <p >{descripcion}</p>
      {/* Renderiza el precio del producto con el formato adecuado */}
      <p >Precio: ${precioNumero.toFixed(2)}</p>
      {/* Renderiza el botón para agregar el producto al carrito */}
      <button onClick={() => addToCart(product)}>
        Agregar al carrito
      </button>
    </div>
  );
}

export default ProductItem;
