import './App.css';
import Title from './components/Title/Titile';
import Input from './components/Input/Input';
import Container from "./components/Container/Container";
import search from "./assets/icons/material-symbols_search.svg";
import Button from './components/Button/Button';
import CardList from './components/CardList/CardList';
import { useState } from 'react';

import deleteIconDark from "./assets/icons/delete.png"
import deleteIconWhite from "./assets/icons/deleteWhite.svg"

import editIconDark from "./assets/icons/pencil.png"
import editIconWhite from "./assets/icons/pencilWhite.svg"

function App() {
    const [isChecked, setIsChecked] = useState(false);

    const handleCheckboxChange = () => {
        setIsChecked(!isChecked);
    };

    const cardBackgroundColor = isChecked ? "#6C45CE" : "#FCFCFC";
    const textColor = isChecked ? "#FCFCFC" : "#25282C";
    const buttonBorderColor = isChecked ? "#FCFCFC" : "#25282C";
    const deleteIcon = isChecked ? deleteIconWhite : deleteIconDark;
    const editeIcon = isChecked ? editIconWhite : editIconDark;

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
                <Title
                    titleText="Terça-Feira, 24 de julho"
                    highlightNumber="24"
                    highlightColor="#8758FF"
                    textColor="#FCFCFC"
                />

                <Input
                    placeHolder="Procurar Tarefa"
                    width="300px"
                    height="40px"
                    icon={search}
                />

                <CardList 
                    taskDescription="Descrição da Tarefa" 
                    backgroundColor={cardBackgroundColor}
                    colorDescription={textColor}
                    borderColor={buttonBorderColor}
                    deleteIcon={deleteIcon}  
                    pencilIcon={editeIcon}
                    isChecked={isChecked} // Passando o estado
                    handleCheckboxChange={handleCheckboxChange} // Passando a função de mudança
                />

            </Container>

            <Button buttonText={"Nova Tarefa"} width={200} height={50} />
        </Container>
    );
}

export default App;