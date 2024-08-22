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
    handleCheckboxChange,
    handleDelete,
    handleEdit
}) => {
    const checkboxBorderColor = isChecked ? '#00FF00' : '#8758FF'; 

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
                <button className='button' style={{ borderColor: borderColor }} onClick={handleDelete}>
                    <img src={deleteIcon} alt="Delete" />
                </button>
                <button className='button' style={{ borderColor: borderColor }} onClick={handleEdit}>
                    <img src={pencilIcon} alt="Edit" />
                </button>
            </div>
        </div>
    );
};

export default CardList;
