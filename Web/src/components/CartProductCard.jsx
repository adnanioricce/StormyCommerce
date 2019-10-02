import * as React from 'react';
import { useRouter } from 'next/router';
import { useDispatch } from 'react-redux';
import toPrice from '../util/toPrice';
import closeSVG from '../static/assets/icons/menu-cart-card-close-icon.svg';
import InteractiveElement from './InteractiveElement';
import actions from '../actions';

const CartProductCard = (cartProduct, index) => {
  const { image, name, price } = cartProduct.product;
  const dispatch = useDispatch();
  const route = useRouter();
  function handleClick() {
    route.push(`/products/${name.replace(/\s/g, '-')}`);
  }
  function handleDelete() {
    dispatch(actions.deleteProductFromCart(cartProduct));
  }
  return (
    <div className="cart-product-card" key={index}>
      <InteractiveElement
        tag="div"
        className="main-content"
        onClick={handleClick}
      >
        <div className="photo">
          <img src={image} alt={`${name}'s representation`} />
        </div>
        <div className="info">
          <div className="title">
            <p>{name}</p>
          </div>
          <div className="price">{toPrice(price)}</div>
          <div className="quantity-display">{`${cartProduct.quantity}x`}</div>
        </div>
      </InteractiveElement>
      <InteractiveElement tag="div" className="delete" onClick={handleDelete}>
        <img src={closeSVG} alt="delete product" />
      </InteractiveElement>
    </div>
  );
};
export default CartProductCard;
