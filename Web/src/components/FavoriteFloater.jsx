import React from 'react';
import { useDispatch, useSelector, shallowEqual } from 'react-redux';
import favoritedSVG from '../static/assets/icons/favorited.svg';
import favoriteSVG from '../static/assets/icons/favorite.svg';
import actions from '../actions';
import InteractiveElement from './InteractiveElement';

function FavoriteFloater({ style, productId }) {
  const favoritedProducts = useSelector(
    state => state.user.favoritedProducts,
    shallowEqual
  );
  const dispatch = useDispatch();
  const isFavorited = favoritedProducts.includes(productId);
  function handleClick() {
    if (isFavorited) {
      dispatch(actions.unFavoriteProduct(productId));
    } else {
      dispatch(actions.favoriteProduct(productId));
    }
  }
  return (
    <InteractiveElement
      tag="div"
      className="favorite-container"
      style={style}
      onClick={handleClick}
    >
      <img className="favorite" src={favoriteSVG} alt="Favoritar" />
      <img
        className={isFavorited ? 'favorited active' : 'favorited'}
        src={favoritedSVG}
        alt="Favoritado"
      />
    </InteractiveElement>
  );
}

export default FavoriteFloater;
