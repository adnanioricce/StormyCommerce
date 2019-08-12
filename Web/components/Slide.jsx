import * as React from 'react'
import nextSlideSVG from '../static/assets/slides/nextSlide.svg';
import previousSlideSVG from '../static/assets/slides/previousSlide.svg';
export default ()=>{
  const [index, setIndex] = React.useState(2);
  const imgRef = React.useRef();
  const [width, setWidth] = React.useState(0)
  const [images, setImages] = React.useState([0, 1, 2, 3, 4]);
  const [slideWidth, setSlideWidth] = React.useState(0);
  const [slideHeight, setSlideHeight] = React.useState(0);
  const [slides, setSlides] = React.useState(null);
  const timer = React.useRef()
  React.useEffect(()=>{
    setWidth(window.innerWidth);
  }, [])
  React.useEffect(()=>{
    const newSlides = images.map((e, eIndex)=>(
      <div ref={imgRef} key={e} className={eIndex === index ? 'main image' : 'image'}>
        <img  src={`/static/assets/slides/${e}.svg`}/>
      </div>
    ))
    setSlides(newSlides)
  }, [index, images])
  React.useEffect(()=>{
    if(imgRef.current){
      setSlideWidth(imgRef.current.offsetWidth);
      setSlideHeight(imgRef.current.offsetHeight);
    }
  })

  function handleNextSlide(){
    if(index<=images.length-2){
      setIndex(index+1)
    }
    
  }
  function handlePreviousSlide(){
    if(index!==0){
      setIndex(index-1)
    }
  }
  React.useEffect(()=>{
    // setTimeout(()=>{
    //   handleNextSlide()
    // }, 500)
    clearTimeout(timer.current)
    timer.current = setTimeout(()=>{
      if(index<=images.length-2){
        setIndex(index+1)
      }else{
        setIndex(0)
      }
      
    }, 4000)
    
  }, [index])
  
  const modifier = width<=425 ? 0 : (-0.12*slideWidth)
  return (
    <div className="overflow-not-allower">
      <div className="Slide" style={{transform: `translateX(${((index*slideWidth)+modifier)*-1}px)`}}>
          
        {slides}
      </div>
      <div className="slide-controller" style={{width: slideWidth, height: slideHeight}}>
        <img onClick={handlePreviousSlide} src={previousSlideSVG} alt=""/>
        <img onClick={handleNextSlide} src={nextSlideSVG} alt=""/>
      </div>
    </div>
  )
}