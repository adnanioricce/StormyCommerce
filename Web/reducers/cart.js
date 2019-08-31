import { produce } from 'immer';
import { consts } from '../actions';

export default (state = [], action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.addProductToCart: {
        draft.push(action.product);
        break;
      }
      default: {
        return state;
      }
    }
    return draft;
  });
