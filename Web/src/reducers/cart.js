import { produce } from 'immer';
import { consts } from '../actions';

function formatItem(product, quantity) {
  return { product, quantity };
}
export default (state = [], action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.setCartProducts: {
        return action.products;
      }
      case consts.addProductToCart: {
        const { quantity, product } = action;
        console.log(product);
        const index = draft.findIndex(item => item.product.id === product.id);
        if (index !== -1) {
          draft[index].quantity += quantity;
        } else {
          draft.push(formatItem(product, quantity));
        }
        break;
      }
      case consts.removeProductFromCart: {
        const { quantity, product } = action;
        const index = draft.findIndex(item => item.product.id === product.id);
        if (index !== -1 && draft[index].quantity - quantity <= 0) {
          draft.filter((element, currentIndex) => currentIndex !== index);
        } else if (index !== -1) {
          draft[index].quantity -= quantity;
        }
        break;
      }
      case consts.deleteProductFromCart: {
        const { product } = action;
        draft = draft.filter(
          currentProduct => currentProduct.id !== product.id
        );
        break;
      }
      case consts.resetCart: {
        draft = [];
        break;
      }
      default: {
        return state;
      }
    }
    return draft;
  });
