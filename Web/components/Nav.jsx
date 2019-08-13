import React from 'react'
import logoSVG from '../static/assets/logo.svg'
import hamburguerMenuSVG from '../static/assets/icons/hamburguerMenu.svg';
import hamburguerCloseMenuSVG from '../static/assets/icons/hamburguerCloseMenu.svg';
import shoppingCartSVG from '../static/assets/icons/shoppingCart.svg'
import Menu from './Menu';
import {useClickAway} from 'react-use';
const Nav = () => {
  const [isMenuActive, setIsMenuActive] = React.useState(false);
  const menuRef = React.useRef()
  const navRef = React.useRef()
  const hamburguerMenuRef = React.useRef();
  function handleHamburguerMenu(e){
    e.preventDefault()
    setIsMenuActive(!isMenuActive);
  }
  React.useEffect(()=>{
    if(document){
      document.body.style.paddingTop = '10vh';
    }
  }, [])
  React.useEffect(()=>{
    // Não executa o resto se o documento não estiver disponivel
    if(!document) return  
    const {body} = document
    if(isMenuActive){
      body.style.overflow = 'hidden';
    }else{
      body.style.overflow = 'auto';
    }
  }, [isMenuActive])
  useClickAway(menuRef, (e) => {
    if(isMenuActive && e.target!== navRef.current && e.target !== hamburguerMenuRef.current){
      setIsMenuActive(false)
    }else{
      // setIsMenuActive(true)
    }
  }, ['mousedown']);
  return (
    <nav ref={navRef}> 
      <Menu ref={menuRef} isActive={isMenuActive}/>
      <img 
        ref={hamburguerMenuRef}
        className='hamburguer-menu' 
        onClick={handleHamburguerMenu} 
        src={isMenuActive?hamburguerCloseMenuSVG:hamburguerMenuSVG}
      />
      <img className='logo' src={logoSVG}/>
      <img className='shopping-cart' src={shoppingCartSVG}/>
    </nav>
  )
}

export default Nav
