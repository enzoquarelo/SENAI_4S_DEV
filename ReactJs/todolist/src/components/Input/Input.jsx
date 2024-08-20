import React from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import './Input.css'

const Input = ({ placeHolder, width, height, icon}) => {
  return (
        <div className="inputContainer" style={{width: width, height: height}}>
          <img src={icon} alt="" className="input-icon"/>
          <input className="input" placeholder={placeHolder}/>
        </div>
    );

};

export default Input;