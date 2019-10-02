import * as React from 'react';
import plusSVG from '../static/assets/icons/plus.svg';
import minusSVG from '../static/assets/icons/minus.svg';
import InteractiveElement from './InteractiveElement';

export default ({
  initialValue = 1,
  setValue = null,
  minValue = 0,
  maxValue = 99
}) => {
  const [quantity, setQuantity] = React.useState(initialValue);
  // const timer = React.useRef();
  const verifyQuantity = currentQuantity => {
    if (currentQuantity < maxValue && currentQuantity > minValue) {
      return true;
    }
    return false;
  };
  const handlePlusAction = () => {
    if (quantity < maxValue) {
      setQuantity(currentValue => currentValue + 1);
    }
  };
  const handleMinusAction = () => {
    if (quantity > minValue) {
      setQuantity(currentValue => currentValue - 1);
    }
  };
  const handleInputChange = e => {
    const targetValue = Number(e.target.value);
    const newValue = quantity === 0 ? targetValue.toString() : targetValue;
    setQuantity(newValue);
  };
  // React.useEffect(() => {
  //   clearTimeout(timer.current);
  //   timer.current = setTimeout(() => {
  //     if (verifyQuantity(quantity) === false) {
  //       setQuantity(minValue);
  //     }
  //   }, 1000);
  // }, [quantity]);
  React.useEffect(() => {
    if (setValue) {
      setValue(quantity);
    }
  }, [quantity]);
  function handleBlurInput() {
    if (verifyQuantity(quantity) === false) {
      setQuantity(minValue);
    }
  }
  return (
    <div className="quantity-chooser">
      <InteractiveElement
        tag="div"
        onClick={handleMinusAction}
        className="minus-button"
      >
        <img src={minusSVG} alt="Botão de diminuir a quantidade" />
      </InteractiveElement>
      <input
        onChange={handleInputChange}
        onBlur={handleBlurInput}
        type="number"
        value={quantity}
      />
      <InteractiveElement
        tag="div"
        onClick={handlePlusAction}
        className="plus-button"
      >
        <img src={plusSVG} alt="Botão que aumenta a quantidade" />
      </InteractiveElement>
    </div>
  );
};
