import { all, takeLatest, put, call } from 'redux-saga/effects';
import actions, { consts } from '../actions';
import api from '../services/api';

function* favoriteProduct({ productID }) {
  yield console.log(`favoritando produto com id ${productID}`);
}
function* fetchProducts() {
  const allProducts = yield call(api.get, '/products');
  yield put(actions.setProducts(allProducts.data));
}
function* watchListAll() {
  yield takeLatest(consts.favorite, favoriteProduct);
  yield takeLatest(consts.fetchProducts, fetchProducts);
}
function* sagas() {
  yield all([watchListAll()]);
}
export default sagas;
