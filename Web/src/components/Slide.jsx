import * as React from 'react';
import nextSlideSVG from '../static/assets/slides/nextSlide.svg';
import previousSlideSVG from '../static/assets/slides/previousSlide.svg';
import InteractiveElement from './InteractiveElement';

export default () => {
  const [index, setIndex] = React.useState(2);
  const imgRef = React.useRef();
  const [images] = React.useState([0, 1, 2, 3, 4]);
  const [slideWidth, setSlideWidth] = React.useState(0);
  const [slides, setSlides] = React.useState(null);
  const timer = React.useRef();
  React.useEffect(() => {
    const newSlides = images.map((e, eIndex) => (
      <div
        ref={imgRef}
        key={e}
        className={eIndex === index ? 'main image' : 'image'}
      >
        <InteractiveElement
          tag="img"
          onClick={() => {
            setIndex(e);
          }}
          src={`/static/assets/slides/${e}.svg`}
          alt={`Slide numero ${e}`}
        />
      </div>
    ));
    setSlides(newSlides);
  }, [index, images]);
  React.useEffect(() => {
    if (imgRef.current) {
      setSlideWidth(imgRef.current.offsetWidth);
    }
  });

  function handleNextSlide() {
    if (index <= images.length - 2) {
      setIndex(index + 1);
    } else {
      setIndex(0);
    }
  }
  function handlePreviousSlide() {
    if (index !== 0) {
      setIndex(index - 1);
    } else {
      setIndex(images.length - 1);
    }
  }
  React.useEffect(() => {
    // setTimeout(()=>{
    //   handleNextSlide()
    // }, 500)
    clearTimeout(timer.current);
    timer.current = setTimeout(() => {
      if (index <= images.length - 2) {
        setIndex(index + 1);
      } else {
        setIndex(0);
      }
    }, 4000);
    return () => clearTimeout(timer.current);
  }, [index]);

  // const modifier = width<=425 ? 0 : (-0.12*slideWidth)
  return (
    <div className="overflow-not-allower">
      <div
        className="Slide"
        style={{ transform: `translateX(${index * slideWidth * -1}px)` }}
      >
        {slides}
      </div>
      <InteractiveElement
        className="left-slider-button"
        onClick={handlePreviousSlide}
        src={previousSlideSVG}
        alt="Botão Esquerdo do Slider"
        tag="img"
      />
      <InteractiveElement
        className="right-slider-button"
        onClick={handleNextSlide}
        src={nextSlideSVG}
        alt="Botão Direito do Slider"
        tag="img"
      />
    </div>
  );
};
