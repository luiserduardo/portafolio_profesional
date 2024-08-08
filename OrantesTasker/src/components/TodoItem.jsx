import React from 'react'; // Importa la biblioteca React
import { FaTrash } from 'react-icons/fa'; // Importa el icono de eliminación de la biblioteca react-icons
import { TodoUpdate } from './TodoUpdate'; // Importa el componente TodoUpdate

// Componente funcional TodoItem para representar un elemento de la lista de tareas
export const TodoItem = ({
	todo, // Propiedad que representa la tarea
	handleUpdateTodo, // Función para actualizar una tarea
	handleDeleteTodo, // Función para eliminar una tarea
	handleCompleteTodo, // Función para marcar una tarea como completada
}) => {
	return (
		<li> {/* Elemento de lista */}
			<span onClick={() => handleCompleteTodo(todo.id)}> {/* Span para marcar la tarea como completada */}
				<label className={`container-done ${todo.done ? 'active' : ''}`}></label> {/* Etiqueta para mostrar el estado de completado de la tarea */}
			</span>
			<TodoUpdate todo={todo} handleUpdateTodo={handleUpdateTodo} /> {/* Componente TodoUpdate para actualizar la tarea */}
			<button className='btn-delete' onClick={() => handleDeleteTodo(todo.id)}> {/* Botón para eliminar la tarea */}
				<FaTrash /> {/* Icono de eliminación */}
			</button>
		</li>
	);
};
