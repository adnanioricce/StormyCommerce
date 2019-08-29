import * as React from 'react';
import FavoriteFloater from './FavoriteFloater';

export default ({ currentProduct }) => {
  return (
    <div className="image">
      <img
        className="image"
        src={currentProduct.image}
        alt={currentProduct.name}
      />
      <FavoriteFloater
        style={{ top: 0, left: 0 }}
        isFavorited={currentProduct.isFavorited}
      />
    </div>
  );
};
