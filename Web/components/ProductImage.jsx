import * as React from 'react';
import ReactImageMagnify from 'react-image-magnify';
import FavoriteFloater from './FavoriteFloater';

export default ({ currentProduct }) => {
  return (
    <div className="product-image">
      {/* <img src={currentProduct.image} alt={currentProduct.name} /> */}
      <ReactImageMagnify
        enlargedImagePosition="over"
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
          },
          lensStyle: { backgroundColor: 'rgba(0,0,0,.6)' }
        }}
      />
      <FavoriteFloater
        style={{ top: -1, left: -1 }}
        isFavorited={currentProduct.isFavorited}
      />
    </div>
  );
};
