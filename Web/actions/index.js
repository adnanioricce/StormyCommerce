export const consts = {
  favorite: 'PRODUCTS/FAVORITE',
  fetchProducts: 'PRODUCTS/FETCHPRODUCTS',
  setProducts: 'PRODUCTS/SETPRODUCTS'
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
  })
};
export default {
  ...products
};
