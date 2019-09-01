import * as React from 'react';
import { useSelector, shallowEqual } from 'react-redux';
import Title from './Title';
import Button from './Button';
import toPrice from '../util/toPrice';

const MenuButton = ({ ...props }) => (
  <Button
    styleType="secondary"
    style={{ margin: '5px auto', width: '80%', fontSize: '.8rem' }}
    {...props}
  />
);

const CartProductCard = (cartProduct, index) => {
  const { image, name, price } = cartProduct;
  return (
    <div className="cart-product-card" key={index}>
      <div className="photo">
        <img src={image} alt={`${name}'s representation`} />
      </div>
      <div className="info">
        <div className="title">
          <p>{name}</p>
        </div>
        <div className="price">{toPrice(price)}</div>
      </div>
    </div>
  );
};

export default ({ isActive }) => {
  const cartProducts = useSelector(state => state.cartProducts, shallowEqual);
  return (
    <div
      className="menu"
      style={{
        left: 'unset',
        right: 0,
        borderRight: 'none',
        transform: `translateX(${isActive ? 0 : 100}%)`
      }}
    >
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
