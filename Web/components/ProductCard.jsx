import * as React from 'react';
import Link from 'next/link';
import FavoriteFloater from './FavoriteFloater';
import InteractiveElement from './InteractiveElement';
import toPrice from '../util/toPrice';

const ProductCard = ({ isFavorited, productName, thumbnailImage, price }, index) => {
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
        // isFavorited={isFavorited}
      />
      <Link
        href={`/produtos/${name.replace(/\s/g, '-')}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          tag="img"
          className="image"
          src={thumbnailImage}
          alt={productName}
        />
      </Link>
      <Link
        href={`/produtos/${productName.replace(/\s/g, '-')}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          className="info"
          tag="div"
        >
          <p className="title">{productName}</p>
          {/* Price já é uma string */}
          <p className="price">{price}</p>
        </InteractiveElement>
      </Link>
    </div>
  );
};

export default ProductCard;
