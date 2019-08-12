import React from 'react'
import logoSVG from '../static/assets/logo.svg'
import hamburguerMenuSVG from '../static/assets/icons/hamburguerMenu.svg';
import hamburguerCloseMenuSVG from '../static/assets/icons/hamburguerCloseMenu.svg';
import shoppingCartSVG from '../static/assets/icons/shoppingCart.svg'
import Menu from './Menu';
const Nav = () => {
  const [isMenuActive, setIsMenuActive] = React.useState(false);
  const [navHeight, setNavHeight] = React.useState(0)
  const navRef = React.useRef();
  function handleHamburguerMenu(){
    setIsMenuActive(!isMenuActive);
  }
  React.useEffect(()=>{
    if(navRef.current){
      setNavHeight(navRef.current.offsetHeight)
    } 
  }, [navRef])
  return (
    <nav ref={navRef}> 
      <Menu isActive={isMenuActive} offset={navHeight}/>
      <div onClick={handleHamburguerMenu}><img className='hamburguer-menu' src={isMenuActive?hamburguerCloseMenuSVG:hamburguerMenuSVG}/>}</div>
      <img className='logo' src={logoSVG}/>
      <img className='shopping-cart' src={shoppingCartSVG}/>
    </nav>
  )
}

export default Nav
