import { produce } from 'immer';
import { consts } from '../actions';

export default (state = [], action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.addProductToFavorites: {
        const { productId } = action;
        draft.push(productId);
        break;
      }
      case consts.removeProductFromFavorites: {
        const { productId } = action;
        draft = draft.filter(id => productId !== id);
        break;
      }
      case consts.setFavoritedProducts: {
        const { products } = action;
        return products;
      }
      default: {
        return state;
      }
    }
    return draft;
  });
