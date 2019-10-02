import * as React from 'react';

export default ({ label, border = true, ...props }) => {
  return (
    <div
      className="header"
      style={{ border: border === false ? 'none' : 'solid 1px black' }}
      {...props}
    >
      <p>{label}</p>
    </div>
  );
};
