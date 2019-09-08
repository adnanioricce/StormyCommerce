import React from 'react';
import favoritedSVG from '../static/assets/icons/favorited.svg';
import favoriteSVG from '../static/assets/icons/favorite.svg';

function FavoriteFloater({ isFavorited, style }) {
  return (
    <div className="favorite-container" style={style}>
      <img className="favorite" src={favoriteSVG} alt="Favoritar" />
      <img
        className={isFavorited ? 'favorited active' : 'favorited'}
        src={favoritedSVG}
        alt="Favoritado"
      />
    </div>
  );
}

export default FavoriteFloater;
