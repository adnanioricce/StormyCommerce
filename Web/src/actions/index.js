export const consts = {
  favorite: 'PRODUCTS/FAVORITE',
  fetchProducts: 'PRODUCTS/FETCH_PRODUCTS',
  setProducts: 'PRODUCTS/SET_PRODUCTS',
  addProductToCart: 'CART/ADD_PRODUCT',
  resetCart: 'CART/RESET',
  loginUser: 'USER/LOGIN',
  addProductToFavorites: 'USER/FAVORITE_PRODUCT',
  removeProductFromFavorites: 'USER/UNFAVORITE_PRODUCT',
  disconnectUser: 'USER/DISCONNECT'
};
const actions = {
  favorite: productID => ({
    type: consts.favorite,
    productID
  }),
  setProducts: productsArray => ({
    type: consts.setProducts,
    products: productsArray
  }),
  fetchProducts: () => ({
    type: consts.fetchProducts
  }),
  addProductToCart: product => ({
    type: consts.addProductToCart,
    product
  }),
  login: (user, token) => ({
    type: consts.loginUser,
    user,
    token
  }),
  disconnect: () => ({
    type: consts.disconnectUser
  }),
  resetCart: () => ({
    type: consts.resetCart
  }),
  favoriteProduct: productId => ({
    type: consts.addProductToFavorites,
    productId
  }),
  unFavoriteProduct: productId => ({
    type: consts.removeProductFromFavorites,
    productId
  })
};
export default actions;
