import React, { useState } from 'react';
import './App.css';
import Title from './components/Title/Titile'
import Input from './components/Input/Input';
import Container from "./components/Container/Container";
import search from "./assets/icons/material-symbols_search.svg";
import Button from './components/Button/Button';
import CardList from './components/CardList/CardList';
import AddTaskModal from './components/AddTaskModal/AddTaskModal';
import deleteIconDark from "./assets/icons/delete.png";
import deleteIconWhite from "./assets/icons/deleteWhite.svg";
import editIconDark from "./assets/icons/pencil.png";
import editIconWhite from "./assets/icons/pencilWhite.svg";
import Header from "./components/Header/Header";

function App() {
    const [tasks, setTasks] = useState([]); // Estado para armazenar as tarefas
    const [showModal, setShowModal] = useState(false); // Estado para mostrar/ocultar o modal
    const [taskToEdit, setTaskToEdit] = useState(null); // Estado para a tarefa a ser editada

    const handleAddTask = (description) => {
        setTasks([...tasks, { id: Date.now(), description, isChecked: false }]);
    };

    const handleDeleteTask = (taskId) => {
        setTasks(tasks.filter(task => task.id !== taskId));
    };

    const handleEditTask = (taskId, newDescription) => {
        setTasks(tasks.map(task => task.id === taskId ? { ...task, description: newDescription } : task));
        setTaskToEdit(null);
    };

    const toggleTaskCheckbox = (taskId) => {
        setTasks(tasks.map(task => task.id === taskId ? { ...task, isChecked: !task.isChecked } : task));
    };

    return (
        <Container
            width="740px"
            height="555px"
            backgroundColor="transparent"
            justifyContent="space-between"
            alignItems="flex-end"
        >
            <Container
                width={740}
                height={495}
                backgroundColor={"#1E123B"}
                borderRadius={10}
                justifyContent="flex-start"
                alignItems="center"
            >
                <Header />

                <Input
                    placeHolder="Procurar Tarefa"
                    width="300px"
                    height="40px"
                    icon={search}
                />

                {tasks.map(task => (
                    <CardList
                        key={task.id}
                        taskDescription={task.description}
                        backgroundColor={task.isChecked ? "#6C45CE" : "#FCFCFC"}
                        colorDescription={task.isChecked ? "#FCFCFC" : "#25282C"}
                        borderColor={task.isChecked ? "#FCFCFC" : "#25282C"}
                        deleteIcon={task.isChecked ? deleteIconWhite : deleteIconDark}
                        pencilIcon={task.isChecked ? editIconWhite : editIconDark}
                        isChecked={task.isChecked}
                        handleCheckboxChange={() => toggleTaskCheckbox(task.id)}
                        handleDelete={() => handleDeleteTask(task.id)}
                        handleEdit={() => setTaskToEdit(task)}
                    />
                ))}

            </Container>

            <Button buttonText={"Nova Tarefa"} width={200} height={50} onClick={() => setShowModal(true)} />
            
            {showModal && (
                <AddTaskModal
                    onAddTask={(description) => {
                        handleAddTask(description);
                        setShowModal(false);
                    }}
                    onClose={() => setShowModal(false)}
                />
            )}

            {taskToEdit && (
                <AddTaskModal
                    onAddTask={(description) => handleEditTask(taskToEdit.id, description)}
                    onClose={() => setTaskToEdit(null)}
                />
            )}
        </Container>
    );
}

export default App;
