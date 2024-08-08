import { useState } from 'react';

// Función personalizada useForm que maneja el estado de un formulario
export const useForm = (initialForm = {}) => {
    // Utiliza el hook useState para almacenar el estado del formulario
	const [formState, setFormState] = useState(initialForm);

    // Función onInputChange para manejar el cambio en los inputs del formulario
	const onInputChange = e => {
        // Obtiene el nombre y el valor del input que cambió
		const name = e.target.name;
		const value = e.target.value;

        // Actualiza el estado del formulario con el nuevo valor del input
		setFormState({
			...formState,
			[name]: value,
		});
	};

    // Función onResetForm para restablecer el formulario al estado inicial
	const onResetForm = () => {
		setFormState(initialForm);
	};

    // Retorna el estado actual del formulario y las funciones para manejarlo
	return {
		...formState,
		formState,
		onInputChange,
		onResetForm,
	};
};
