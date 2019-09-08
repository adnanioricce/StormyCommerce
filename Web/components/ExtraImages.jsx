import * as React from 'react';
import InteractiveElement from './InteractiveElement';

const ImagesList = (imageSource, index, setCurrentImage, ref) => {
  const handleImageClick = () => {
    setCurrentImage(imageSource);
  };
  return (
    <InteractiveElement
      ref={ref}
      tag="img"
      onClick={handleImageClick}
      src={imageSource}
      key={index}
      alt="ExtraImage"
      className="extra-image"
    />
  );
};

export default ({ images, setCurrentImage }) => {
  const imageListItemRef = React.useRef(null);
  const [imagesTotalSize, setImagesTotalSize] = React.useState(0);
  const imagesContainerRef = React.useRef(null);
  const [imageContainerSize, setImageContainerSize] = React.useState(0);
  const [
    isImageListOverflowingContainer,
    setIsImageListOverflowingContainer
  ] = React.useState(false);
  React.useEffect(() => {
    if (document && imageListItemRef.current) {
      const { current: image } = imageListItemRef;
      setImagesTotalSize(image.getBoundingClientRect().width * images.length);
    }
  }, []);
  React.useEffect(() => {
    if (document && imagesContainerRef.current) {
      const { current: imagesContainerElement } = imagesContainerRef;
      setImageContainerSize(
        imagesContainerElement.getBoundingClientRect().width
      );
    }
  }, []);
  React.useEffect(() => {
    if (imagesTotalSize > imageContainerSize) {
      setIsImageListOverflowingContainer(true);
    } else {
      setIsImageListOverflowingContainer(false);
    }
  }, [imagesTotalSize, imageContainerSize, setIsImageListOverflowingContainer]);
  return (
    <div
      className="extra-images-container"
      style={{
        justifyContent: isImageListOverflowingContainer
          ? 'flex-start'
          : 'center'
      }}
      ref={imagesContainerRef}
    >
      {images.map((image, index) =>
        ImagesList(image, index, setCurrentImage, imageListItemRef)
      )}
    </div>
  );
};
