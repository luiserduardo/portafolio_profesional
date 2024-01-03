// Obtenemos el elemento del contador
var contador = document.getElementById("contador");

// Obtenemos el valor actual del contador desde el almacenamiento local
var contadorActual = localStorage.getItem("contador");

// Si el contador no existe en el almacenamiento local, lo inicializamos a cero
if (!contadorActual) {
  contadorActual = 0;
}

// Incrementamos el contador en uno
contadorActual++;

// Actualizamos el elemento del contador en la página
contador.innerHTML = contadorActual;

// Guardamos el nuevo valor del contador en el almacenamiento local
localStorage.setItem("contador", contadorActual);
