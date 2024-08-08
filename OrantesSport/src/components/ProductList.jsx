import React from 'react';
import ProductItem from './ProductItem';

function ProductList({ products, addToCart }) {
  // La función ProductList representa un componente que muestra una lista de productos.
  // Toma dos propiedades como argumentos: `products` y `addToCart`.

  return (
    <div className="container" aria-label="Lista de productos">
      {/* Comprueba si la lista de productos está vacía */}
      {products.length === 0 ? (
        // Si no hay productos disponibles, muestra un mensaje indicando que no hay productos.
        <p>No hay productos disponibles en este momento.</p>
      ) : (
        // Si hay productos disponibles, renderiza cada producto utilizando el componente ProductItem.
        <div className="productos-pagina">
          {/* Mapea la lista de productos y renderiza cada uno usando el componente ProductItem */}
          {products.map((product) => (
            <ProductItem
              key={product.id}
              product={product}
              addToCart={addToCart}
            />
          ))}
        </div>
      )}
    </div>
  );
}

export default ProductList;
