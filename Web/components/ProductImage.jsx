import * as React from 'react';
import ReactImageMagnify from 'react-image-magnify';
import FavoriteFloater from './FavoriteFloater';
import ExtraImages from './ExtraImages';

export default ({ currentProduct }) => {
  const { medias } = currentProduct.medias;
  const [thumbnailImage, setCurrentImage] = React.useState(currentProduct.thumbnailImage);
  return (
    <div className="product-image-container">
      <div className="product-image">
        <ReactImageMagnify
          enlargedImagePosition="over"
          {...{
            smallImage: {
              alt: 'Wristwatch by Ted Baker London',
              isFluidWidth: true,
              src: thumbnailImage
            },
            largeImage: {
              src: thumbnailImage,
              width: 1200,
              height: 1800
            },
            lensStyle: { backgroundColor: 'rgba(0,0,0,.6)' }
          }}
        />

        <FavoriteFloater
          style={{ top: -1, left: -1 }}
          // Favorited é definido por cada usuário 
          // não é um campo presente em produtos
          // mas na entidade WishListItem
          // isFavorited={currentProduct.isFavorited}
        />
      </div>
      <ExtraImages images={medias} setCurrentImage={setCurrentImage}/>
    </div>
  );
};
