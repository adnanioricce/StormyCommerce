import produce from "immer";
import {actions,appUser} from '../actions/appUser';
// import AuthenticationClient from '../services/AuthenticationClient';
// const client = new AuthenticationClient();

export default (state,action) => {
    produce(state,() => {
        switch(action.type){
            case actions.currentUser:
                return appUser;
            default: actions.currentUser
                return appUser;
        }
    })    
}