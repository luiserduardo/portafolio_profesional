var imagenes = ["img/comida2.jpg",
                "img/comida3.jpg",
                "img/comida4.jpg",
                "img/comida5.jpg",
                "img/comida6.jpg",
                "img/comida7.jpg"
               ];

document.Imagen.src = imagenes[0];

var SliderIzquierdo = document.querySelector(".slider-izquierdo");
var SliderDerecho = document.querySelector(".slider-derecho");
var Contador = 0;

function MoverDerecha(){
    Contador++;
    if(Contador > imagenes.length - 1)
        {
            Contador = 0;
        }
    document.Imagen.src = imagenes[Contador];
}
SliderDerecho.addEventListener("click", MoverDerecha);


function MoverIzquierda(){
    Contador--;
    if(Contador < 0)
        {
        Contador = imagenes.length - 1;
        }
    document.Imagen.src = imagenes[Contador];
}
SliderIzquierdo.addEventListener("click", MoverIzquierda);