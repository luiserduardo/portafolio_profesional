
import React from 'react';
import logo from '../components/recursos/logo.png';



function Header() {
  return (
    // cargar header
    <header className="contenedor-contenido1">
      {/* cargar div */}
      <div className="contenido1">

        {/* Logo */}
        <div className="contendor-logo">
          {/* cargar img */}
          <img className="imagen" src={logo} alt="Logo de Orantes" />
          {/* cargar h1 */}
          <h1><a href="/">Orante's Sports</a></h1>
        </div>

        {/* Atención al cliente */}
        <div className="customer-soporte">
          {/* cargar div */}
          <div className="contenido-customer-soporte">
            <span className="texto">Soporte al cliente</span>
            <span className="numero">523-7174-8645</span>
          </div>
        </div>



      </div>
    </header>);
}
// Exportar
export default Header;
