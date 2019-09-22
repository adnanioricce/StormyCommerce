const dispathToProps = (dispatch) => {
    return {
        loadUserFromToken: () => {
            let token = sessionStorage.getItem('jwtToken');
  	 	    if(!token || token === '') {
                   //if there is no token, dont bother
                   //Or no?
  	 		return;
            }
        },
        // dispatch(meFromToken(token)).then();
    }
}