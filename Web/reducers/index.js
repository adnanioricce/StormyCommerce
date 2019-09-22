import { combineReducers } from 'redux';
import products from './products';
import cart from './cart';
import { appUser } from '../actions/appUser';
export default combineReducers({
  products,
  cartProducts: cart,
  appUser:appUser
});
