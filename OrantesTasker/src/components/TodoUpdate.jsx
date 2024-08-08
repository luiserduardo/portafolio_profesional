import React, { useRef, useState } from 'react'; // Importa la biblioteca React, useRef y useState
import { FaEdit } from 'react-icons/fa'; // Importa el icono de edición
import { useForm } from '../hooks/useForm'; // Importa el hook useForm

// Componente funcional TodoUpdate para actualizar una tarea
export const TodoUpdate = ({ todo, handleUpdateTodo }) => {
    const { updateDescription, onInputChange } = useForm({ // Inicializa el hook useForm
        updateDescription: todo.description, // Descripción actual de la tarea
    });

    const [disabled, setDisabled] = useState(true); // Estado para habilitar/deshabilitar la edición
    const focusInputRef = useRef(); // Referencia al input para enfocarlo

    // Función para manejar la actualización de la tarea
    const onSubmitUpdate = e => {
        e.preventDefault(); // Evita que se envíe el formulario

        const id = todo.id; // ID de la tarea
        const description = updateDescription; // Nueva descripción de la tarea

        handleUpdateTodo(id, description); // Llama a la función para actualizar la tarea

        setDisabled(!disabled); // Cambia el estado para habilitar/deshabilitar la edición

        focusInputRef.current.focus(); // Enfoca el input de descripción
    };

    return (
        <form onSubmit={onSubmitUpdate}> {/* Formulario para actualizar la tarea */}
            <input
                type='text'
                className={`input-update ${todo.done ? 'text-decoration-dashed' : ''}`} // Aplica una clase si la tarea está completada
                name='updateDescription'
                value={updateDescription} // Valor del input de descripción
                onChange={onInputChange} // Manejador del cambio en el input
                placeholder='¿Qué hay que hacer?' // Placeholder del input
                readOnly={disabled} // Determina si el input es de solo lectura
                ref={focusInputRef} // Referencia al input para enfocarlo
            />

            <button className='btn-edit' type='submit'> {/* Botón para enviar el formulario de actualización */}
                <FaEdit /> {/* Icono de edición */}
            </button>
        </form>
    );
};
