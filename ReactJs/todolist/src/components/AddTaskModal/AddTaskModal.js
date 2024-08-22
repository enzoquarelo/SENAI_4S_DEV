import React, { useState } from 'react';
import './AddTaskModal.css';

// Componente AddTaskModal: Modal para adicionar uma nova tarefa
const AddTaskModal = ({ onAddTask, onClose }) => {
  const [taskDescription, setTaskDescription] = useState(''); // Estado local para armazenar a descrição da nova tarefa

  const handleAddTask = () => {
    onAddTask(taskDescription); // Chama a função para adicionar a nova tarefa
    setTaskDescription(''); // Limpa o campo de entrada
    onClose(); // Fecha o modal
  };

  return (
    <div className="modal">
      <div className="modal-content">
        <h1>Descreva sua tarefa</h1>
        <input
          type="text"
          value={taskDescription} // Valor atual do campo de entrada
          onChange={(e) => setTaskDescription(e.target.value)} // Atualiza o estado da descrição da tarefa
          placeholder="Digite a tarefa..." // Placeholder para o campo de entrada
        />
        <button onClick={handleAddTask}>Adicionar</button> {/* Botão para adicionar a tarefa */}
        <button onClick={onClose}>Cancelar</button> {/* Botão para cancelar e fechar o modal */}
      </div>
    </div>
  );
};

export default AddTaskModal;
