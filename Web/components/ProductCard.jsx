import * as React from 'react';
import FavoriteFloater from './FavoriteFloater';
import InteractiveElement from './InteractiveElement';

export default (
  { isFavorited, name, image, price, id },
  index,
  algo,
  route
) => {
  // const [image, setImage] = React.useState('');
  // React.useEffect(()=>{
  //   fetch(product.image).then(
  //     res=>console.log(res)
  //   )
  // }, [])
  function handleProductClick() {
    // route.query = { productID: index };
    route.push(`/product?id=${index}`);
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  }
  return (
    <div className="product-card" key={index}>
      <InteractiveElement
        onClick={handleProductClick}
        tag="img"
        className="image"
        src={image}
        alt={name}
      />
      <FavoriteFloater
        style={{ top: -1, right: -1 }}
        isFavorited={isFavorited}
      />
      <InteractiveElement
        onClick={handleProductClick}
        className="info"
        tag="div"
      >
        <p className="title">{name}</p>
        <p className="price">{`R$ ${price.toFixed(2)}`}</p>
      </InteractiveElement>
    </div>
  );
};
