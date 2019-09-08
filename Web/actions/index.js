export const consts = {
  favorite: 'PRODUCTS/FAVORITE',
  fetchProducts: 'PRODUCTS/FETCH_PRODUCTS',
  setProducts: 'PRODUCTS/SET_PRODUCTS',
  addProductToCart: 'CART/ADD_PRODUCT'
};
const products = {
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
  })
};
export default {
  ...products
};
