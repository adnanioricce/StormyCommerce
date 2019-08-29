import * as React from 'react';
import Select from 'react-select';

export default ({
  options = [],
  setCurrentOption = null,
  defaultOption = null
}) => {
  function handleChange(e) {
    if (setCurrentOption) {
      setCurrentOption(e.value);
    }
  }
  return (
    <>
      <Select
        className="select-input-container"
        classNamePrefix="select-input"
        closeMenuOnScroll
        defaultValue={defaultOption || options[0]}
        onChange={handleChange}
        options={options}
      />
    </>
  );
};
