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
    // window.scrollTo({
    //   top: 0,
    //   behavior: 'smooth'
    // });
  }
  return (
    <div className="product-card" key={index}>
      <FavoriteFloater
        style={{ top: -1, right: -1 }}
        isFavorited={isFavorited}
      />
      <Link
        href={`/product?name=${name}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          tag="img"
          className="image"
          src={image}
          alt={name}
        />
      </Link>
      <Link
        href={`/product?name=${name}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          className="info"
          tag="div"
        >
          <p className="title">{name}</p>
          <p className="price">{`R$ ${price.toFixed(2)}`}</p>
        </InteractiveElement>
      </Link>
    </div>
  );
};

export default ProductCard;
