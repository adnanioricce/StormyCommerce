import { combineReducers } from 'redux';
import products from './products';
import cart from './cart';
import user from './user';
import favoritedProducts from './favoritedProducts';

export default combineReducers({
  products,
  cartProducts: cart,
  user,
  favoritedProducts
});
