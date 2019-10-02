export const consts = {
  fetchProducts: 'PRODUCTS/FETCH_PRODUCTS',
  setProducts: 'PRODUCTS/SET_PRODUCTS',
  addProductToCart: 'CART/ADD_PRODUCT',
  resetCart: 'CART/RESET',
  loginUser: 'USER/LOGIN',
  addProductToFavorites: 'FAVORITED_PRODUCTS/ADD',
  removeProductFromFavorites: 'FAVORITED_PRODUCTS/REMOVE',
  disconnectUser: 'USER/DISCONNECT',
  setFavoritedProducts: 'FAVORITED_PRODUCTS/SET',
  removeProductFromCart: 'CART/REMOVE_PRODUCT',
  deleteProductFromCart: 'CART/DELETE_PRODUCT',
  setCartProducts: 'CART/SET_PRODUCTS'
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
  addProductToCart: (product, quantity = 0) => ({
    type: consts.addProductToCart,
    product,
    quantity
  }),
  removeProductFromCart: (product, quantity = 0) => ({
    type: consts.removeProductFromCart,
    product,
    quantity
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
  }),
  setFavoritedProducts: products => ({
    type: consts.setFavoritedProducts,
    products
  }),
  deleteProductFromCart: product => ({
    type: consts.deleteProductFromCart,
    product
  }),
  setCartProducts: products => ({
    type: consts.setCartProducts,
    products
  })
};
export default actions;
