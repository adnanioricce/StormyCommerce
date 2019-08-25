import * as React from 'react';
import Link from 'next/link';

import FavoriteFloater from './FavoriteFloater';

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
    console.log(route);
    route.query = { productID: index };
    route.push('/product');
  }
  return (
    <Link href={`/product?id=${index}`} key={id}>
      <div
        onClick={handleProductClick}
        className="product"
        key={index}
        role="button"
        onKeyPress={e => e.key === 'Enter' && handleProductClick()}
        tabIndex={0}
      >
        <img className="image" src={image} alt={name} />
        <FavoriteFloater
          style={{ position: 'absolute', top: -1, right: -1 }}
          isFavorited={isFavorited}
        />
        <div className="info">
          <p className="title">{name}</p>
          <p className="price">{`R$ ${price.toFixed(2)}`}</p>
        </div>
      </div>
    </Link>
  );
};
