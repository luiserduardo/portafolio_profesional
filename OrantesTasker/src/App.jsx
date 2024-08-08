import { useState } from 'react'; // Importa el hook useState de React.
import './App.css'; // Importa los estilos generales de la aplicación.
import "./Estilos/footer.css"; // Importa los estilos específicos para el footer.
import "./Estilos/header.css"; // Importa los estilos específicos para el header.
import { TodoAdd } from './components/TodoAdd'; // Importa el componente TodoAdd para agregar nuevas tareas.
import { TodoList } from './components/TodoList'; // Importa el componente TodoList para mostrar la lista de tareas.
import { useTodo } from './hooks/useTodo'; // Importa el hook personalizado useTodo para gestionar el estado y las operaciones de las tareas.
import Header from './components/Header'; // Importa el componente Header.
import Footer from './components/Footer'; // Importa el componente Footer.

function App() {
  // Desestructuración del hook useTodo, que proporciona el estado y las funciones para gestionar las tareas.
  const {
    todos, // Lista de todas las tareas.
    todosCount, // Contador total de tareas.
    pendingTodosCount, // Contador de tareas pendientes.
    handleNewTodo, // Función para agregar una nueva tarea.
    handleDeleteTodo, // Función para eliminar una tarea.
    handleCompleteTodo, // Función para marcar una tarea como completada.
    handleUpdateTodo, // Función para actualizar una tarea existente.
  } = useTodo();

  const [filter, setFilter] = useState('all'); // Estado para manejar el filtro de tareas: 'all', 'pendientes', 'completadas'.

  return (
    <div className="app-container"> 
      {/* Contenedor principal de la aplicación */}
      <Header /> 
      {/* Componente de cabecera */}
      <div className='card-to-do'> 
        {/* Contenedor para la tarjeta de la lista de tareas */}
        <h1>Lista de tareas</h1> 
        {/* Título de la sección de tareas */}
        <div className='counter-todos'> 
          {/* Contenedor para los contadores de tareas */}
          <h3>
            N° Tareas: <span>{todosCount}</span> 
            {/* Muestra el número total de tareas */}
          </h3>
          <h3>
            Pendientes: <span>{pendingTodosCount}</span> 
            {/* Muestra el número de tareas pendientes */}
          </h3>
        </div>

        <div className='add-todo'>
          {/* Contenedor para la sección de agregar nuevas tareas */}
          <h3>Agregar Tarea</h3>
          <TodoAdd handleNewTodo={handleNewTodo} />
          {/* Componente para agregar una nueva tarea, pasando la función handleNewTodo como prop */}
        </div>

        <div className='filter'>
          {/* Contenedor para los botones de filtro */}
          <button onClick={() => setFilter('all')}>Todas</button>
          {/* Botón para mostrar todas las tareas */}
          <button onClick={() => setFilter('pendientes')}>Pendientes</button>
          {/* Botón para mostrar solo las tareas pendientes */}
          <button onClick={() => setFilter('completadas')}>Completadas</button>
          {/* Botón para mostrar solo las tareas completadas */}
        </div>

        <TodoList
          todos={todos} 
          /* Lista de todas las tareas, pasada como prop */
          filter={filter} 
          /* Filtro actual, pasado como prop */
          handleUpdateTodo={handleUpdateTodo} 
          /* Función para actualizar una tarea, pasada como prop */
          handleDeleteTodo={handleDeleteTodo} 
          /* Función para eliminar una tarea, pasada como prop */
          handleCompleteTodo={handleCompleteTodo} 
          /* Función para completar una tarea, pasada como prop */
        />
      </div>
      <Footer /> 
      {/* Componente de pie de página */}
    </div>
  );
}

export default App; 
// Exporta el componente App como el componente principal de la aplicación.
