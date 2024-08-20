import React from "react";
import './Button.css'

const Button = ({ buttonText, color = "", height, width,justifyContent }) => {
    return (
        <button className="button" style={{backgroundColor: color, width: width, height: height, justifyContent: justifyContent}}>
            {buttonText}
        </button>
    );

};

export default Button;