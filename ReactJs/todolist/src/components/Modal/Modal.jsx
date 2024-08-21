import React from 'react';
import './Modal.css';
import Title from "../Title/Titile";
import Input from "../Input/Input";
import Butotn from "../Button/Button"

const Modal = ({ }) => {
    return (
        <div className='container'>
            <Title>Descreva sua tarefa</Title>

            <Input/>

        </div>
    );
};

export default Modal;