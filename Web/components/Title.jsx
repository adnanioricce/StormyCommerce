import * as React from 'react';

export default ({ label, style }) => (
  <div className="title-container" style={style}>
    <h1>{label}</h1>
  </div>
);
