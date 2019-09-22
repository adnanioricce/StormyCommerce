import { all, takeLatest, put, call, select } from 'redux-saga/effects';
import actions, { consts } from '../actions';
import api from '../services/api';

function* favoriteProduct() {
  const user = yield select(state => state.user);
  const favoritedProducts = yield select(state => state.favoritedProducts);
  yield call(
    api.put,
    '/users',
    {
      email: user.email,
      favorited_products: favoritedProducts
    },
    { headers: { Authorization: `Bearer ${user.token}` } }
  );
}
function* userLogin() {
  const user = yield select(state => state.user);
  const { data: allUserInfo } = yield call(api.get, '/users', {
    headers: { Authorization: `Bearer ${user.token}` }
  });
  console.log(allUserInfo);
  const {
    favorited_products: favoritedProducts,
    cart_products: cartProducts
  } = allUserInfo;
  yield put(actions.setFavoritedProducts(favoritedProducts || []));
  yield put(actions.setCartProducts(cartProducts? JSON.parse(cartProducts): []));
}
function* userDisconnect() {
  yield put(actions.setFavoritedProducts([]));
  yield put(actions.setCartProducts([]));
}
function* fetchProducts() {
  const allProducts = yield call(api.get, '/products');
  yield put(actions.setProducts(allProducts.data));
}
function* updateUserCart() {
  const user = yield select(state => state.user);
  const cartProducts = yield select(state => state.cartProducts);
  console.log(cartProducts);
  yield call(
    api.put,
    '/users',
    {
      email: user.email,
      cart_products: JSON.stringify(cartProducts)
    },
    { headers: { Authorization: `Bearer ${user.token}` } }
  );
}
function* watchListAll() {
  yield takeLatest(consts.fetchProducts, fetchProducts);
  yield takeLatest(consts.addProductToFavorites, favoriteProduct);
  yield takeLatest(consts.removeProductFromFavorites, favoriteProduct);
  yield takeLatest(consts.addProductToCart, updateUserCart);
  yield takeLatest(consts.deleteProductFromCart, updateUserCart);
  yield takeLatest(consts.loginUser, userLogin);
  yield takeLatest(consts.disconnectUser, userDisconnect);
}
function* sagas() {
  yield all([watchListAll()]);
}
export default sagas;
