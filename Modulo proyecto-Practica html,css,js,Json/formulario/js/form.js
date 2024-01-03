const form = document.querySelector('form');
const nombreInput = document.querySelector('input[name="nombre"]');
const emailInput = document.querySelector('input[name="email"]');
const mensajeInput = document.querySelector('textarea[name="mensaje"]');
const enviadoDiv = document.querySelector('.enviado');

form.addEventListener('submit', function(event) {
    event.preventDefault();
    if (!nombreInput.value) {
        alert('Por favor, ingrese su nombre.');
        nombreInput.focus();
    } else if (!emailInput.value) {
        alert('Por favor, ingrese su correo electrónico.');
        emailInput.focus();
    } else if (!validateEmail(emailInput.value)) {
        alert('Por favor, ingrese un correo electrónico válido.');
        emailInput.focus();
    } else if (!mensajeInput.value) {
        alert('Por favor, ingrese un mensaje.');
        mensajeInput.focus();
    } else {
        form.submit();
        document.getElementById('mensaje-enviado').style.display = 'block';
    }
});


function validateEmail(email) {
    const re = /\S+@\S+\.\S+/;
    return re.test(email);
}


