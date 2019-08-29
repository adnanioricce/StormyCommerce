import * as React from 'react';

export default ({ options = [] }) => {
  return (
    <>
      <select className="select-input">
        {options.map(
          ({ label: optionLabel, value: optionValue }, optionIndex) => {
            return (
              <option key={optionIndex} value={optionValue}>
                {optionLabel}
              </option>
            );
          }
        )}
      </select>
    </>
  );
};
