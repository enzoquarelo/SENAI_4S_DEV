import './App.css';
import Title from './components/Title/Titile';
import Input from './components/Input/Input';
import Container from "./components/Container/Container";
import search from "./assets/icons/material-symbols_search.svg"
import Button from './components/Button/Button';
function App() {
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
      </Container>

      <Button buttonText={"Nova Tarefa"} width={200} height={50} />
    </Container>
  );
}

export default App;
