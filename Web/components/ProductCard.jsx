import * as React from 'react';
import Link from 'next/link';
import FavoriteFloater from './FavoriteFloater';
import InteractiveElement from './InteractiveElement';

const ProductCard = ({ isFavorited, name, image, price }, index) => {
  // const [image, setImage] = React.useState('');
  // React.useEffect(()=>{
  //   fetch(product.image).then(
  //     res=>console.log(res)
  //   )
  // }, [])
  function handleProductClick() {
    // route.query = { productID: index };
    // route.push(`/product?name=${name}`);
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  }
  return (
    <div className="product-card" key={index}>
      <FavoriteFloater
        style={{ top: -1, right: -1 }}
        isFavorited={isFavorited}
      />
      <Link href={`/product?name=${name}`} as={`/product/${name}`}>
        <InteractiveElement
          onClick={handleProductClick}
          tag="img"
          className="image"
          src={image}
          alt={name}
        />
      </Link>
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

export default ProductCard;
