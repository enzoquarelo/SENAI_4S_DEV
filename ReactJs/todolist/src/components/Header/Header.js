import React from 'react';
import './Header.css';

// Componente Header: Exibe o título e a data atual no cabeçalho
const Header = () => {
  const today = new Date();

  // Opções para formatar dia da semana, dia e mês separadamente
  const weekdayOptions = { weekday: 'long' };
  const dayOptions = { day: 'numeric' };
  const monthOptions = { month: 'long' };

  // Formata cada parte da data
  const weekday = today.toLocaleDateString('pt-BR', weekdayOptions);
  const day = today.toLocaleDateString('pt-BR', dayOptions);
  const month = today.toLocaleDateString('pt-BR', monthOptions);

  // Função para deixar a primeira letra maiúscula
  const capitalizeFirstLetter = (string) => {
    return string.charAt(0).toUpperCase() + string.slice(1);
  };

  return (
    <header className="header">
      <h1>
        {/* Capitaliza o weekday e o month, e estiliza o day */}
        {capitalizeFirstLetter(weekday)},
        <span className="day"> {day}</span> de {capitalizeFirstLetter(month)}
      </h1>
    </header>
  );
};

export default Header;
