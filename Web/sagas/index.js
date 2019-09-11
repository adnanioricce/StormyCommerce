import { all, takeLatest, put, call } from 'redux-saga/effects';
import actions, { consts } from '../actions';
// import { Client } from '../services/stormyClient';
import api from '../services/api';
function* favoriteProduct({ productID }) {
  yield console.log(`favoritando produto com id ${productID}`);
}
function* fetchProducts() {
  const client = new Client("https://172.17.0.2:443");  
  const allProducts = client.getAllProducts(1,10);
  yield put(actions.setProducts(allProducts.data));
}
function* watchListAll() {
  // yield takeLatest(consts.favorite, favoriteProduct);
  yield takeLatest(consts.fetchProducts, fetchProducts);
}
function* sagas() {
  yield all([watchListAll()]);
}
export default sagas;
