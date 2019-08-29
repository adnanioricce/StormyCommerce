import React from 'react';
import ColorSelector from './ColorSelector';
import SelectInput from './SelectInput';

function ProductOptionsController() {
  const [activeColor, setActiveColor] = React.useState('red');
  console.log(activeColor);
  return (
    <div className="product-options-controller">
      <ColorSelector
        activeColor={activeColor}
        setActiveColor={setActiveColor}
        options={[
          { value: 'red', color: 'red' },
          { value: 'yellow', color: 'yellow' }
        ]}
      />
      <SelectInput
        options={[{ label: 15, value: 15 }, { label: 16, value: 16 }]}
      />
    </div>
  );
}

export default ProductOptionsController;
