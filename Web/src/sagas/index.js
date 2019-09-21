import { all, takeLatest, put, call, select } from 'redux-saga/effects';
import actions, { consts } from '../actions';
import api from '../services/api';

function* favoriteProduct() {
  const user = yield select(state => state.user);
  const response = yield call(
    api.put,
    '/users',
    {
      email: user.email,
      favorited_products: user.favoritedProducts
    },
    { headers: { Authorization: `Bearer ${user.token}` } }
  );
  console.log(response);
}
function* fetchProducts() {
  const allProducts = yield call(api.get, '/products');
  yield put(actions.setProducts(allProducts.data));
}
function* watchListAll() {
  yield takeLatest(consts.fetchProducts, fetchProducts);
  yield takeLatest(consts.addProductToFavorites, favoriteProduct);
  yield takeLatest(consts.removeProductFromFavorites, favoriteProduct);
}
function* sagas() {
  yield all([watchListAll()]);
}
export default sagas;
