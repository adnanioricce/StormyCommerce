import React from 'react';
import InteractiveElement from './InteractiveElement';

export default function Button({ label, styleType = 'primary', ...props }) {
  return (
    <InteractiveElement
      className={styleType === 'primary' ? 'button' : 'button secondary'}
      tag="button"
      {...props}
    >
      <p>{label}</p>
    </InteractiveElement>
  );
}
