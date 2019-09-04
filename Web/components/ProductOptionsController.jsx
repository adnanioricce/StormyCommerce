import React from 'react';
import { useDispatch } from 'react-redux';
import ColorSelector from './ColorSelector';
import SelectInput from './SelectInput';
import Title from './Title';
import QuantityChooser from './QuantityChooser';
import Button from './Button';
import PriceDisplay from './PriceDisplay';
import Separator from './Separator';
import actions from '../actions';

function ProductOptionsController({ currentProduct }) {
  const [currentColor, setCurrentColor] = React.useState('red');
  const [currentSize, setCurrentSize] = React.useState(15);
  const dispatch = useDispatch();
  const { price, oldPrice } = currentProduct;
  const handleAddToCart = () => {
    dispatch(actions.addProductToCart(currentProduct));
  };
  return (
    <div className="product-options-controller">
      <Title
        label={currentProduct.name}
        style={{ justifyContent: 'left', marginBottom: 0 }}
      />
      <PriceDisplay price={price} oldPrice={oldPrice} />
      <Separator />
      <Section label="Cor">
        <ColorSelector
          activeColor={currentColor}
          setActiveColor={setCurrentColor}
          options={[
            { value: 'red', color: 'red' },
            { value: 'purple', color: 'purple' }
          ]}
        />
      </Section>
      <Section label="Tamanho">
        <SelectInput
          defaultOption={currentSize}
          setCurrentOption={setCurrentSize}
          options={[{ label: 15, value: 15 }, { label: 16, value: 16 }]}
        />
      </Section>
      <Section label="Quantidade">
        <QuantityChooser />
      </Section>
      <Separator />
      <Button onClick={handleAddToCart} label="Adicionar ao Carrinho" />
    </div>
  );
}
const SectionTitle = ({ label }) => (
  <Title
    label={label}
    style={{ margin: 0, marginBottom: 5, fontSize: '10px' }}
  />
);

const Section = ({ label, children }) => (
  <div style={{ margin: '5px 10px' }}>
    <SectionTitle label={label} />
    {children}
  </div>
);
export default ProductOptionsController;
