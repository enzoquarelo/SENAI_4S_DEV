import React from "react";
import './Title.css'

const Title = ({ titleText, highlightNumber, highlightColor, textColor }) => {

    const parts = titleText.split(highlightNumber);
  
    return (
      <h1 style={{ color: textColor }}>
        {parts[0]}<span style={{ color: highlightColor }}>{highlightNumber}</span>{parts[1]}
      </h1>
    );
  };

export default Title;