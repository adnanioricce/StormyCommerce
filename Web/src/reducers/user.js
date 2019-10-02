import { produce } from 'immer';
import { consts } from '../actions';

export default (state = {}, action) =>
  produce(state, draft => {
    switch (action.type) {
      case consts.loginUser: {
        const { token, user } = action;
        return {
          email: user.email,
          name: user.name,
          token
        };
      }
      case consts.disconnectUser: {
        return {};
      }
      default: {
        return draft;
      }
    }
    return draft;
  });
