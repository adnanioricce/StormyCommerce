import * as React from 'react';
import { useSelector, shallowEqual } from 'react-redux';
import Title from './Title';
import Button from './Button';
import CartProductCard from './CartProductCard';

const MenuButton = ({ ...props }) => (
  <Button
    styleType="secondary"
    style={{ margin: '5px auto', width: '80%', fontSize: '.8rem' }}
    {...props}
  />
);

export default ({ isActive }) => {
  const cartProducts = useSelector(state => state.cartProducts, shallowEqual);
  return (
    <div className={isActive ? 'shop-cart-menu active' : 'shop-cart-menu'}>
      <Title label="Carrinho" />
      {cartProducts.length > 0 ? (
        <div className="cart-products-container">
          {cartProducts.map(CartProductCard)}
        </div>
      ) : (
        <div className="no-products-container">
          Você ainda não possui produtos no carrinho :(
        </div>
      )}

      <MenuButton styleType="primary" label="Finalizar" />
      <MenuButton label="Adicionar Cupom" />
      <MenuButton label="Calcular Frete" />
      <MenuButton label="Favoritos" />
    </div>
  );
};
