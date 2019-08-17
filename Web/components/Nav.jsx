import React from 'react'
import logoSVG from '../static/assets/logo.svg'
import hamburguerMenuSVG from '../static/assets/icons/hamburguerMenu.svg';
import hamburguerCloseMenuSVG from '../static/assets/icons/hamburguerCloseMenu.svg';
import shoppingCartSVG from '../static/assets/icons/shoppingCart.svg'
import Menu from './Menu';
import {useClickAway} from 'react-use';
import ShopCartMenu from './ShopCartMenu';
import { useRouter } from 'next/router';
const Nav = () => {
  const Router = useRouter();
  const [isMenuActive, setIsMenuActive] = React.useState(false);
  const [isShopCartMenuActive, setIsShopCartMenuActive] = React.useState(false)
  const menuRef = React.useRef()
  const navRef = React.useRef()
  const hamburguerMenuRef = React.useRef();
  function handleHamburguerMenu(e){
    e.preventDefault()
    setIsMenuActive(!isMenuActive);
  }
  function handleShopCartMenu(e){
    setIsShopCartMenuActive(!isShopCartMenuActive)
  }
  React.useEffect(()=>{
    if(document){
      document.body.style.paddingTop = '10vh';
    }
  }, [])
  function handleLogoClick(){
    if (Router.pathname==='/' ){
      window &&  window.scrollTo({
        top: 0,
        behavior: 'smooth'
      });
    }else{
      Router.replace('/')
    }
  }
  // React.useEffect(()=>{
  //   // Não executa o resto se o documento não estiver disponivel
  //   if(!document) return  
  //   const {body} = document
  //   if(isMenuActive){
  //     body.style.overflow = 'hidden';
  //   }else{
  //     body.style.overflow = 'auto';
  //   }
  // }, [isMenuActive])
  // useClickAway(menuRef, (e) => {
  //   if(isMenuActive && e.target!== navRef.current && e.target !== hamburguerMenuRef.current){
  //     setIsMenuActive(false)
  //   }else{
  //     // setIsMenuActive(true)
  //   }
  // }, ['mousedown']);
  return (
    <nav ref={navRef}> 
      <Menu ref={menuRef} isActive={isMenuActive}/>
      <ShopCartMenu isActive={isShopCartMenuActive}/>
      <img 
        ref={hamburguerMenuRef}
        className='hamburguer-menu' 
        onClick={handleHamburguerMenu} 
        src={isMenuActive?hamburguerCloseMenuSVG:hamburguerMenuSVG}
      />
      <img className='logo' onClick={handleLogoClick} src={logoSVG}/>
      <img 
        onClick={handleShopCartMenu} 
        className='shopping-cart' 
        src={isShopCartMenuActive?hamburguerCloseMenuSVG:shoppingCartSVG}/>
    </nav>
  )
}

export default Nav
