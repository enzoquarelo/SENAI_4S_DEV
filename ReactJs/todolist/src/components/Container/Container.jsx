import React from 'react';
import './Container.css';

const Container = ({ 
    children, 
    width = '100%', 
    height = '100%', 
    backgroundColor, 
    borderRadius, 
    justifyContent = 'center', 
    alignItems = 'center'       
}) => {
    const style = {
        width,
        height,
        backgroundColor,
        borderRadius,
        display: 'flex',
        justifyContent,
        alignItems
    };

    return (
        <div className='container' style={style}>
            {children}
        </div>
    );
};

export default Container;