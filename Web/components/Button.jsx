import React from 'react';
import InteractiveElement from './InteractiveElement';

export default function Button({ label, styleType = 'primary',onHandle,...props }) {
  let onHandle = onHandle;
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
