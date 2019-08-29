import React from 'react';
import ColorSelector from './ColorSelector';
import SelectInput from './SelectInput';
import Title from './Title';

function ProductOptionsController() {
  const [currentColor, setCurrentColor] = React.useState('red');
  const [currentSize, setCurrentSize] = React.useState(15);
  return (
    <div className="product-options-controller">
      <SectionTitle label="Cor" />
      <ColorSelector
        activeColor={currentColor}
        setActiveColor={setCurrentColor}
        options={[
          { value: 'red', color: 'red' },
          { value: 'yellow', color: 'yellow' }
        ]}
      />
      <SectionTitle label="Tamanho" />
      <SelectInput
        defaultOption={currentSize}
        setCurrentOption={setCurrentSize}
        options={[{ label: 15, value: 15 }, { label: 16, value: 16 }]}
      />
    </div>
  );
}
const SectionTitle = ({ label }) => (
  <Title
    label={label}
    style={{ marginTop: '10px', marginBottom: '5px', fontSize: '10px' }}
  />
);
export default ProductOptionsController;
