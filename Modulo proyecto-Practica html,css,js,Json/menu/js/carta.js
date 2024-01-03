function generarCartas() {
	// Obtener el contenedor donde se mostrarán las cartas
	let contenedor = document.getElementById("cartas");
	
	// Recorrer el array del JSON y generar una carta para cada elemento
	stockAlimentos.forEach(alimento => {
		// Crear el elemento de la carta
		let carta = document.createElement("div");
		carta.classList.add("carta");
		
		// Crear la imagen de la carta y agregarla a la carta
		let imagen = document.createElement("img");
		imagen.src = alimento.img;
		carta.appendChild(imagen);
		
		// Agregar un evento al pasar el mouse por encima de la imagen para mostrar la información
		imagen.addEventListener("mouseover", function() {
			// Crear el elemento de información y agregarlo a la carta
			let info = document.createElement("div");
			info.classList.add("info");
			info.innerHTML = `
				<h3>${alimento.nombre}</h3>
				<p>${alimento.desc}</p>
				<p>Precio: $${alimento.precio}</p>
			`;
			carta.appendChild(info);
		});
		
		// Agregar un evento al quitar el mouse de la imagen para ocultar la información
		imagen.addEventListener("mouseout", function() {
			// Obtener el elemento de información y quitarlo de la carta
			let info = carta.querySelector(".info");
			carta.removeChild(info);
		});
		
		// Agregar la carta al contenedor
		contenedor.appendChild(carta);
	});
}
