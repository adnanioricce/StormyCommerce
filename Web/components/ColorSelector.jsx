import React from 'react';
import { useClickAway } from 'react-use';
import InteractiveElement from './InteractiveElement';
import Title from './Title';

function ColorSelector({ options, activeColor, setActiveColor }) {
  const [isPopupActive, setIsPopupActive] = React.useState(false);
  React.useEffect(() => {
    if (isPopupActive && window) {
      window.document.body.style.overflow = 'hidden';
    } else if (window) {
      window.document.body.style.overflow = 'auto';
    }
  }, [isPopupActive]);
  return (
    <>
      <ColorPopup
        state={[isPopupActive, setIsPopupActive, activeColor, setActiveColor]}
        options={options}
      />
      <Title label="Cor" style={{ margin: '5px 0', fontSize: '10px' }} />
      <InteractiveElement
        className="color-selector"
        style={{ backgroundColor: activeColor }}
        tag="div"
        onClick={() => {
          setIsPopupActive(true);
        }}
      />
    </>
  );
}
const ColorPopup = ({ state, options }) => {
  const [isPopupActive, setIsPopupActive, activeColor, setActiveColor] = state;
  const popupRef = React.useRef(null);
  useClickAway(popupRef, () => {
    setIsPopupActive(false);
  });
  return (
    <div
      className="color-popup-overlay"
      style={{
        transition: 'opacity .3s ease-in-out',
        pointerEvents: isPopupActive ? 'all' : 'none',
        opacity: isPopupActive ? 1 : 0
      }}
    >
      <div className="color-popup" ref={popupRef}>
        <div className="color-popup-header">
          <Title
            label="Selecione uma cor"
            style={{ color: 'white', fontSize: 10 }}
          />
        </div>
        <div className="color-popup-body">
          {options.map(({ value, color }, index) => {
            const handleColorClick = () => {
              setActiveColor(value);
              setIsPopupActive(false);
            };
            return (
              <InteractiveElement
                key={index}
                className={
                  color === activeColor
                    ? 'color-popup-box selected'
                    : 'color-popup-box'
                }
                style={{ backgroundColor: color }}
                onClick={handleColorClick}
                tag="div"
              />
            );
          })}
        </div>
      </div>
    </div>
  );
};
export default ColorSelector;
