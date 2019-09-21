import * as React from 'react';

export default ({ text, style }) => (
  <div className="description" style={style}>
    <p>{text}</p>
  </div>
);
