import { produce } from 'immer';
import { consts } from '../actions';

export default (state = { favoritedProducts: [] }, action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.loginUser: {
        const { token, user } = action;
        console.log(user);
        return {
          favoritedProducts: user.favorited_products || [],
          ...user,
          token
        };
      }
      case consts.disconnectUser: {
        return { favoritedProducts: [] };
      }
      case consts.addProductToFavorites: {
        const { productId } = action;
        draft.favoritedProducts = [...draft.favoritedProducts, productId];
        break;
      }
      case consts.removeProductFromFavorites: {
        const { productId } = action;
        draft.favoritedProducts = draft.favoritedProducts.filter(
          id => id !== productId
        );
        break;
      }
      default: {
        return draft;
      }
    }
    return draft;
  });
