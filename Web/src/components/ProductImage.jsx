import * as React from 'react';
import ReactImageMagnify from 'react-image-magnify';
import FavoriteFloater from './FavoriteFloater';
import ExtraImages from './ExtraImages';

export default ({ currentProduct }) => {
  const { photos } = currentProduct;
  const [currentImage, setCurrentImage] = React.useState(photos[0]);
  return (
    <div className="product-image-container">
      <div className="product-image">
        <ReactImageMagnify
          enlargedImagePosition="over"
          {...{
            smallImage: {
              isFluidWidth: true,
              src: currentImage
            },
            largeImage: {
              src: currentImage,
              width: 1200,
              height: 1800
            },
            lensStyle: { backgroundColor: 'rgba(0,0,0,.6)' }
          }}
        />

        <FavoriteFloater
          style={{ top: -1, left: -1 }}
          productId={currentProduct.id}
        />
      </div>
      <ExtraImages images={photos} setCurrentImage={setCurrentImage} />
    </div>
  );
};
