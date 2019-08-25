import React from 'react';
import InteractiveElement from './InteractiveElement';

export default function Button({ label, type = 'primary', ...props }) {
  return (
    <InteractiveElement
      className={type === 'primary' ? 'button' : 'button secondary'}
      tag="button"
      {...props}
    >
      <p>{label}</p>
    </InteractiveElement>
  );
}
