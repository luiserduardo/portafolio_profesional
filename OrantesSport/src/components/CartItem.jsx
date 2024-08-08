import React from 'react';

// Componente funcional CartItem que representa un elemento de la lista del carrito
function CartItem({ product, removeFromCart, removeAllFromCart, totalByProduct }) {
  // Función para eliminar una unidad del producto del carrito
  const handleRemoveOne = () => {
    removeFromCart(product.id);
  };

  // Función para eliminar todas las unidades del producto del carrito
  const handleRemoveAll = () => {
    removeAllFromCart(product.id);
  };

  // Retorna una fila de tabla que muestra la información del producto en el carrito
  return (
    <tr>
      {/* Columna que muestra la información del producto */}
      <td>
        <div className="product-info">
          {/* Imagen del producto */}
          <img
            src={product.img}
            alt={`Imagen de ${product.Nombre}`}
            className="cart-product-img"
          />
          {/* Nombre y precio del producto */}
          <div>
            <p>{product.Nombre}</p>
            <p>Precio: ${product.precio.toFixed(2)}</p>
          </div>
        </div>
      </td>
      {/* Columna que muestra la cantidad de unidades del producto */}
      <td>{product.quantity}</td>
      {/* Columna que muestra el total por producto */}
      <td>${totalByProduct.toFixed(2)}</td>
      {/* Columna con botón para eliminar una unidad del producto */}
      <td>
        <button className="cart-button" onClick={handleRemoveOne}>
          Eliminar uno
        </button>
      </td>
      {/* Columna con botón para eliminar todas las unidades del producto */}
      <td>
        <button className="cart-button" onClick={handleRemoveAll}>
          Eliminar todos
        </button>
      </td>
    </tr>
  );
}

// Exporta el componente CartItem
export default CartItem;
