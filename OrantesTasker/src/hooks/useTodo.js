import { useEffect, useReducer } from 'react'; // Importa los hooks useEffect y useReducer de React
import { todoReducer } from '../todoreducer'; // Importa el reducer para las tareas

// Hook personalizado useTodo para gestionar el estado y las operaciones relacionadas con las tareas
export const useTodo = () => {
    // Define el estado inicial de las tareas como un array vacío
	const initialState = [];

    // Función de inicialización para obtener las tareas almacenadas en el almacenamiento local
    const init = () => {
        return JSON.parse(localStorage.getItem('todos')) || [] // Retorna las tareas almacenadas o un array vacío si no hay tareas almacenadas
    }

    // Utiliza el hook useReducer para gestionar la lógica de las acciones sobre las tareas, pasando el reducer, el estado inicial y la función de inicialización
	const [todos, dispatch] = useReducer(
		todoReducer,
		initialState,
		init
	);

    // Calcula la cantidad total de tareas y la cantidad de tareas pendientes
    const todosCount = todos.length;
    const pendingTodosCount = todos.filter(todo => !todo.done).length;

    // Utiliza useEffect para actualizar el almacenamiento local cada vez que cambia el estado de las tareas
    useEffect(() => {
        localStorage.setItem('todos', JSON.stringify(todos)); // Guarda las tareas en el almacenamiento local en formato JSON
    }, [todos]);

    // Funciones para realizar operaciones sobre las tareas
	const handleNewTodo = todo => {
		const action = {
			type: 'Add Todo', // Tipo de acción: agregar tarea
			payload: todo, // Carga útil: la nueva tarea
		};

		dispatch(action); // Envía la acción al reducer
	};

	const handleDeleteTodo = id => {
		const action = {
			type: 'Delete Todo', // Tipo de acción: eliminar tarea
			payload: id, // Carga útil: el ID de la tarea a eliminar
		};

		dispatch(action); // Envía la acción al reducer
	};

	const handleCompleteTodo = id => {
		const action = {
			type: 'Complete Todo', // Tipo de acción: completar tarea
			payload: id, // Carga útil: el ID de la tarea a marcar como completada
		};

		dispatch(action); // Envía la acción al reducer
	};

	const handleUpdateTodo = (id, description) => {
		const action = {
			type: 'Update Todo', // Tipo de acción: actualizar tarea
			payload: {
				id,
				description,
			}, // Carga útil: el ID de la tarea y su nueva descripción
		};

		dispatch(action); // Envía la acción al reducer
	};

    // Retorna un objeto que incluye el estado actual de las tareas, la cantidad total de tareas, la cantidad de tareas pendientes y funciones para realizar operaciones sobre las tareas
    return {
        todos,
        todosCount,
        pendingTodosCount,
        handleNewTodo,
        handleDeleteTodo,
        handleCompleteTodo,
        handleUpdateTodo
    };
};
