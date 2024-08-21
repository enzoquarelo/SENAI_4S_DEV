import React from 'react';
import './CardList.css';

const CardList = ({  
    taskDescription, 
    backgroundColor, 
    colorDescription, 
    borderColor, 
    deleteIcon, 
    pencilIcon, 
    isChecked,
    handleCheckboxChange
}) => {
    const checkboxBorderColor = isChecked ? '#00FF00' : '#8758FF'; // Exemplo de cores

    return (
        <div className='containerCard' style={{ backgroundColor: backgroundColor }}>
            <input 
                type="checkbox" 
                className='checkbox' 
                checked={isChecked}
                onChange={handleCheckboxChange} 
                style={{ borderColor: checkboxBorderColor }}
            />
            <h2 className='description' style={{ color: colorDescription }}>{taskDescription}</h2>

            <div className='containerButtons'>
                <button className='button' style={{ borderColor: borderColor }}>
                    <img src={deleteIcon} alt="" />
                </button>
                <button className='button' style={{ borderColor: borderColor }}>
                    <img src={pencilIcon} alt="" />
                </button>
            </div>
        </div>
    );
};

export default CardList;