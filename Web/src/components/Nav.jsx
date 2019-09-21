import React from 'react';
import { useRouter } from 'next/router';
import logoSVG from '../static/assets/logo.svg';
import hamburguerMenuSVG from '../static/assets/icons/hamburguerMenu.svg';
import hamburguerCloseMenuSVG from '../static/assets/icons/hamburguerCloseMenu.svg';
import shoppingCartSVG from '../static/assets/icons/shoppingCart.svg';

import Menu from './Menu';
import ShopCartMenu from './ShopCartMenu';
import InteractiveElement from './InteractiveElement';
import SearchBar from './SearchBar';

const Nav = () => {
  const Router = useRouter();
  const [isMenuActive, setIsMenuActive] = React.useState(false);
  const [isShopCartMenuActive, setIsShopCartMenuActive] = React.useState(false);
  const menuRef = React.useRef();
  const navRef = React.useRef();
  const hamburguerMenuRef = React.useRef();
  function handleHamburguerMenu(e) {
    e.preventDefault();
    setIsMenuActive(!isMenuActive);
  }
  function handleShopCartMenu() {
    setIsShopCartMenuActive(!isShopCartMenuActive);
  }
  // React.useEffect(() => {
  //   if (document && navRef.current) {
  //     const navBarHeight = navRef.current.getBoundingClientRect().height * 1.5;
  //     document.body.style.paddingTop = `${navBarHeight}px`;
  //   }
  // }, [navRef]);
  function handleLogoClick() {
    if (Router.pathname === '/' && window) {
      window.scrollTo({
        top: 0,
        behavior: 'smooth'
      });
    } else {
      Router.replace('/');
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
      <Menu ref={menuRef} isActive={isMenuActive} />
      <ShopCartMenu isActive={isShopCartMenuActive} />
      <InteractiveElement
        src={isMenuActive ? hamburguerCloseMenuSVG : hamburguerMenuSVG}
        ref={hamburguerMenuRef}
        onClick={handleHamburguerMenu}
        className="hamburguer-menu"
        alt="Hamburguer Menu"
        tag="img"
      />
      <InteractiveElement
        className="logo"
        onClick={handleLogoClick}
        src={logoSVG}
        alt="Logo"
        tag="img"
      />
      <InteractiveElement
        onClick={handleShopCartMenu}
        className="shopping-cart"
        src={isShopCartMenuActive ? hamburguerCloseMenuSVG : shoppingCartSVG}
        alt="Carrinho de Compras"
        tag="img"
      />
      <SearchBar />
    </nav>
  );
};

export default Nav;
