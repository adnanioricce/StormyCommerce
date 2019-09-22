//Você poderia usar o modelo StormyCustomer, mas me pergunto da segurança disso...
export const appUser = {
    email:'',
    token:'',
    refreshToken:''
}
export const actionsTypes = {
    LOGIN:'api/Authentication/login',
    REGISTER:'api/Authentication/register',
    CONFIRM_EMAIL:'/api/Authentication/ConfirmEmail',
    REFRESH_TOKEN:'/api/Authentication/refresh_token',
    FORGOT_PASSWORD:'/api/Authentication/ForgotPassword',
    CURRENT_USER:'currentUser'
}
export const actions = {
    login: signInVm =>({
        type:actionsTypes.LOGIN,
        model:signInVm
    }),
    register: signUpVm => ({
        type:actionsTypes.REGISTER,
        model:signUpVm
    }),
    refreshToken: refreshTokenModel => ({
        type:actionsTypes.REFRESH_TOKEN,
        model:refreshTokenModel
    }),
    currentUser: getUser => ({
        type:actionsTypes.CURRENT_USER,
        model:getUser
    })
}
