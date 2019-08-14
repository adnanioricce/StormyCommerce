import * as React from 'react'
import {useRouter} from 'next/router';
import menuToggleArrowSVG from '../static/assets/icons/menuToggleArrow.svg'
import menuItems from '../static/consts/menuItems';
export default React.forwardRef(({ isActive  }, ref) => {
  const [translateXValue, setTranslateXValue] = React.useState(-100);
  const Router = useRouter();
  React.useEffect(() => {
    if (isActive) {
      setTranslateXValue(0);
    } else {
      setTranslateXValue(-100);
    }
  }, [isActive])
  const itens = menuItems.map((menuItem, index) => {
    const [ subMenuIsActive, setSubMenuIsActive ] = React.useState(false)
    function handleClick(e){
      if(e.subItems){
        setSubMenuIsActive(!subMenuIsActive);
      }else{
        const {prefix, label} = e
        const link = prefix?`/${prefix}/${label.toLowerCase()}`:'/'+label.toLowerCase()

        Router.push(link)
      }
    }
    return (
      <div className="menu-item"  key={index}>
        
        <p className='label' onClick={()=>handleClick(menuItem)}>{menuItem.label}{menuItem.subItems && (
          <img className='menu-toggle-arrow' src={menuToggleArrowSVG} style={{transform: `rotate(${subMenuIsActive?180:0}deg)`}}/>
        )}</p>
        {(menuItem.subItems && subMenuIsActive) && (
          <div className='menu-sub-item-container'>
          {
            menuItem.subItems.map((e, index) => {
              e.prefix = menuItem.prefix;
              return (
                <div className="menu-sub-item" onClick={()=>handleClick(e)} key={index}>
                  <p className='label'>{e.label}</p>
                </div>
              )
            })
          }
          </div>
        )
        }
      </div>
    )
  })
  return (
    <div className='menu' ref={ref} style={{ transform: `translateX(${translateXValue}%)` }}>
      {itens}
    </div>
  )
})