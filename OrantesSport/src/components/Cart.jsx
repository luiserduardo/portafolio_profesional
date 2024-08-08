import React from 'react';
import CartItem from './CartItem'; // Importación del componente CartItem para mostrar los elementos del carrito
import { Link } from 'react-router-dom'; // Importación de Link para la navegación a la página de pago

function Cart({ cart, removeFromCart, removeAllFromCart }) {
  // Función para calcular el total por producto multiplicando el precio por la cantidad
  const calculateTotalByProduct = (product) => {
    return product.precio * product.quantity;
  };

  // Función para calcular el total general del carrito sumando los totales por producto
  const calculateTotal = () => {
    let total = 0;
    cart.forEach((product) => {
      total += calculateTotalByProduct(product);
    });
    return total;
  };

  return (
    <div className="cart-container">
      <h2 className="cart-title">Carrito</h2>
      {/* Condición para mostrar un mensaje si el carrito está vacío */}
      {cart.length === 0 ? (
        <p className="cart-message">No hay productos en el carrito.</p>
      ) : (
        <div>
          {/* Tabla para mostrar la lista de productos en el carrito */}
          <table className="table table-striped">
            <thead>
              <tr>
                <th>Producto</th>
                <th>Cantidad</th>
                <th>Total por Producto</th>
                <th>Acciones</th>
                <th>Acciones</th>
              </tr>
            </thead>
            <tbody>
              {/* Mapeo de cada producto en el carrito y renderizado del componente CartItem */}
              {cart.map((product) => (
                <CartItem
                  key={product.id}
                  product={product}
                  removeFromCart={removeFromCart}
                  removeAllFromCart={removeAllFromCart}
                  totalByProduct={calculateTotalByProduct(product)}
                />
              ))}
            </tbody>
          </table>
          {/* Muestra el total general del carrito */}
          <p className="cart-total">Total: ${calculateTotal().toFixed(2)}</p>
          {/* Botón para proceder al pago */}
          <Link to="/checkout">
            <button className="cart-button btn btn-success">Proceder al Pago</button>
          </Link>
        </div>
      )}
    </div>
  );
}

export default Cart;
