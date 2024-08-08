import React from 'react';
import { TodoItem } from './TodoItem';

// Componente funcional TodoList para representar la lista de tareas
export const TodoList = ({
    // Lista de todas las tareas
    todos,
    // Filtro para mostrar solo tareas pendientes o completadas
    filter,
    // Función para actualizar una tarea
    handleUpdateTodo,
    // Función para eliminar una tarea
    handleDeleteTodo,
    // Función para marcar una tarea como completada
    handleCompleteTodo,
}) => {
        // Filtra las tareas según el filtro seleccionado

    const filteredTodos = todos.filter(todo => {
        if (filter === 'pendientes') {
            return !todo.done; // Devuelve las tareas no completadas
        } else if (filter === 'completadas') {
            return todo.done; // Devuelve las tareas completadas
        } else {
            return true; // Devuelve todas las tareas
        }
    });

    return (
        <ul> {/* Lista no ordenada para mostrar las tareas */}
            {filteredTodos.map(todo => (
                <TodoItem
                    key={todo.id}
                    todo={todo}
                    handleUpdateTodo={handleUpdateTodo}
                    handleDeleteTodo={handleDeleteTodo}
                    handleCompleteTodo={handleCompleteTodo}
                />
            ))}
        </ul>
    );
};

