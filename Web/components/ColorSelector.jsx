import React from 'react';
import { useClickAway } from 'react-use';
import InteractiveElement from './InteractiveElement';

function ColorSelector({ options, activeColor, setActiveColor }) {
  const [isPopupActive, setIsPopupActive] = React.useState(false);
  const colorSelectorRef = React.useRef();
  React.useEffect(() => {
    console.log(isPopupActive);
  }, [isPopupActive]);
  return (
    <>
      <InteractiveElement
        ref={colorSelectorRef}
        className="color-selector"
        style={{ backgroundColor: activeColor }}
        tag="div"
        onClick={e => {
          if (e.target === colorSelectorRef.current) {
            setIsPopupActive(currentValue => !currentValue);
          }
        }}
      >
        <ColorMenu
          colorSelectorRef={colorSelectorRef}
          state={[isPopupActive, setIsPopupActive, activeColor, setActiveColor]}
          options={options}
        />
      </InteractiveElement>
    </>
  );
}
const ColorBox = ({ value, color }, index, closeMenu, activeColor) => {
  const handleColorClick = () => {
    // setActiveColor(value);
    closeMenu(value);
  };
  return (
    <InteractiveElement
      key={index}
      className={
        color === activeColor
          ? 'color-box-container selected'
          : 'color-box-container'
      }
      onClick={handleColorClick}
      tag="div"
    >
      <div className="color-popup-box" style={{ backgroundColor: color }} />
    </InteractiveElement>
  );
};

const ColorMenu = ({ state, options, colorSelectorRef }) => {
  const [isPopupActive, setIsPopupActive, activeColor, setActiveColor] = state;
  const popupRef = React.useRef(null);
  const colorBodyRef = React.useRef(null);
  const closeMenu = value => {
    setActiveColor(value);
    setIsPopupActive(false);
  };
  useClickAway(popupRef, e => {
    if (
      e.target !== colorSelectorRef.current &&
      e.target !== colorBodyRef.current
    ) {
      setIsPopupActive(false);
    }
  });
  return (
    <>
      {isPopupActive && (
        <div className="color-popup" ref={popupRef}>
          <div className="color-popup-body" ref={colorBodyRef}>
            {options.map((e, index) =>
              ColorBox(e, index, closeMenu, activeColor)
            )}
          </div>
        </div>
      )}
    </>
  );
};

export default ColorSelector;
