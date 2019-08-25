import React from 'react';
import ColorSelector from './ColorSelector';

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
    </div>
  );
}

export default ProductOptionsController;
