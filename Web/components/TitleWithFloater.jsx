import * as React from 'react';
import Title from './Title';

export default ({ children, label }) => {
  console.log(children);
  return (
    <div className="title-floater-container">
      <Title label={label} style={{ minHeight: 40 }} />
      {children}
    </div>
  );
};
