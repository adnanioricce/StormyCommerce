import * as React from 'react';
import FavoriteFloater from './FavoriteFloater';
import ReactImageMagnify from 'react-image-magnify';

export default ({ currentProduct }) => {
  return (
    <div className="product-image">
      {/* <img src={currentProduct.image} alt={currentProduct.name} /> */}
      <ReactImageMagnify
        {...{
          smallImage: {
            alt: 'Wristwatch by Ted Baker London',
            isFluidWidth: true,
            src: currentProduct.image
          },
          largeImage: {
            src: currentProduct.image,
            width: 1200,
            height: 1800
          }
        }}
     
      />
      <FavoriteFloater
        style={{ top: 0, left: 0 }}
        isFavorited={currentProduct.isFavorited}
      />
    </div>
  );
};
