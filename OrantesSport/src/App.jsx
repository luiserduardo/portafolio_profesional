// Importamos las dependencias necesarias desde React y React Router
import React, { useState } from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

// Importamos los componentes de la aplicación
import ProductList from "./components/ProductList";
import Cart from "./components/Cart";
import CheckoutForm from "./components/CheckoutForm";

// Importamos los datos de productos desde un archivo JSON
import productos from './productos/productos.json';

// Importamos los archivos de estilo CSS
import './App.css';
import "./Estilos/productos.css";
import "./Estilos/header.css";
import "./Estilos/footer.css";

// Importamos los componentes de cabecera y pie de página
import Header from "./components/Header";
import Footer from "./components/Footer";

function App() {
  // Declaramos el estado 'cart' y su función 'setCart' para gestionar el carrito de compras
  const [cart, setCart] = useState([]);

  // Función para agregar un producto al carrito
  const addToCart = (product) => {
    const existingProduct = cart.find(item => item.id === product.id);
    if (existingProduct) {
      // Si el producto ya existe en el carrito, incrementamos su cantidad
      setCart(cart.map(item =>
        item.id === product.id
          ? { ...item, quantity: item.quantity + 1 }
          : item
      ));
    } else {
      // Si el producto no existe en el carrito, lo agregamos con cantidad 1
      setCart([...cart, { ...product, quantity: 1 }]);
    }
  };

  // Función para eliminar un producto del carrito
  const removeFromCart = (productId) => {
    // Reducimos la cantidad del producto o lo eliminamos si la cantidad es 0
    setCart(cart.map(item =>
      item.id === productId
        ? { ...item, quantity: item.quantity - 1 }
        : item
    ).filter(item => item.quantity > 0));
  };

  // Función para manejar el proceso de pago
  const handleCheckout = (customerInfo) => {
    console.log('Customer Info:', customerInfo);
    alert('Proceso de pago completo. ¡Gracias por su compra!');
    setCart([]); // Vaciamos el carrito después del pago
  };

  return (
    // Configuramos el Router para manejar la navegación de la aplicación
    <Router>
      {/* Componente de cabecera */}
      <Header />
      <div>
        {/* Componente del carrito que muestra los productos añadidos */}
        <Cart cart={cart} removeFromCart={removeFromCart} />
        <Routes>
          {/* Ruta para el formulario de pago */}
          <Route path="/checkout" element={<CheckoutForm onCheckout={handleCheckout} />} />
          {/* Ruta principal que muestra la lista de productos */}
          <Route
            path="/"
            element={
              <div>
                <ProductList products={productos} addToCart={addToCart} />
              </div>
            }
          />
        </Routes>
      </div>
      {/* Componente de pie de página */}
      <Footer />
    </Router>
  );
}

// Exportamos el componente App como el componente principal de la aplicación
export default App;
