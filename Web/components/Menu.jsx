import * as React from 'react'
export default ({isActive, offset})=>{
  const [translateXValue, setTranslateXValue] = React.useState(-100);
  const [height, setHeight] = React.useState(0);
  React.useEffect(()=>{
    if(isActive){
      setTranslateXValue(0);
    }else{
      setTranslateXValue(-100);
    }
  }, [isActive])
  React.useEffect(()=>{
    setHeight(window.innerHeight);
  }, [])
  console.log(offset, height)
  return (
    <div className='menu' style={{transform: `translateX(${translateXValue}%)`, height: height-offset, top: offset}}>

    </div>
  )
}