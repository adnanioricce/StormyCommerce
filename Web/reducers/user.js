import { produce } from 'immer';
import { consts } from '../actions';

export default (state = {}, action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.loginUser:{
        const {token, user} = action
        state={...user, token}
        break;
      }
      default: {
        return state;
      }
    }
    return draft;
  });
