import React from 'react';

function Breadcumb({ paths = [] }) {
  return (
    <div className="breadcumb">
      {['Loja', ...paths]
        .reduce((arr, element, index, array) => {
          return index >= array.length - 1
            ? [...arr, element]
            : [...arr, element, '/'];
        }, [])
        .map((e, index) => {
          return (
            <p className="breadcumb-path" key={index}>
              {e}
            </p>
          );
        })}
    </div>
  );
}

export default Breadcumb;
