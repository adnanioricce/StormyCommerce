import { produce } from 'immer';
import { consts } from '../actions';

export default (state = [], action) =>
  produce(state, () => {
    console.log(action);
    switch (action.type) {
      case consts.setProducts: {
        return action.products;
      }
      default: {
        return state;
      }
    }
  });
