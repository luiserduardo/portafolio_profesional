import React, { useState } from 'react';
import { Link } from 'react-router-dom';

function CheckoutForm({ onCheckout }) {
  // Estados para los campos del formulario y los errores de validación
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [address, setAddress] = useState('');
  const [errors, setErrors] = useState({});
  // Estado para controlar la visibilidad del mensaje de confirmación
  const [paymentSuccess, setPaymentSuccess] = useState(false);

  // Función para validar los campos del formulario
  const validate = () => {
    const newErrors = {};
    if (!name) newErrors.name = 'El nombre es requerido';
    if (!email) {
      newErrors.email = 'El correo electrónico es requerido';
    } else if (!/\S+@\S+\.\S+/.test(email)) {
      newErrors.email = 'El correo electrónico no es válido';
    }
    if (!address) newErrors.address = 'La dirección es requerida';
    return newErrors;
  };

  // Función para manejar el envío del formulario
  const handleSubmit = (event) => {
    event.preventDefault();
    const validationErrors = validate();
    // Si hay errores de validación, se actualiza el estado de los errores
    if (Object.keys(validationErrors).length > 0) {
      setErrors(validationErrors);
    } else {
      // Si no hay errores, se realiza el pago y se muestra el mensaje de confirmación
      onCheckout({ name, email, address });
      setPaymentSuccess(true);
    }
  };

  return (
    <div className="container checkout-container">
      <h2>Formulario de Pago</h2>
      {paymentSuccess ? ( // Mostrar el mensaje de confirmación si el pago ha sido exitoso
        <div className="alert alert-success" role="alert">
          ¡Pago realizado con éxito! Gracias por su compra.
        </div>
      ) : (
        <form onSubmit={handleSubmit}>
          {/* Campos de entrada para nombre, correo electrónico y dirección */}
          <div className="mb-3">
            <label className="form-label">Nombre</label>
            <input
              type="text"
              className="form-control"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
            {errors.name && <div className="text-danger">{errors.name}</div>}
          </div>
          <div className="mb-3">
            <label className="form-label">Email</label>
            <input
              type="email"
              className="form-control"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            {errors.email && <div className="text-danger">{errors.email}</div>}
          </div>
          <div className="mb-3">
            <label className="form-label">Dirección</label>
            <input
              type="text"
              className="form-control"
              value={address}
              onChange={(e) => setAddress(e.target.value)}
            />
            {errors.address && <div className="text-danger">{errors.address}</div>}
          </div>
          {/* Botones para enviar el formulario y cancelar */}
          <button type="submit" className="btn btn-success">Pagar</button>
          <Link to="/">
            <button type="button" className="btn btn-secondary">Cancelar</button>
          </Link>
        </form>
      )}
    </div>
  );
}

export default CheckoutForm;
