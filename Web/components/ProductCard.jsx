import * as React from 'react';
import Link from 'next/link';
import FavoriteFloater from './FavoriteFloater';
import InteractiveElement from './InteractiveElement';
import toPrice from '../util/toPrice';
import {ProductDto} from '../models/catalog/ProductDto';
const ProductCard = (props, index) => {
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
  console.log(props);
  return (
    
    <div className="product-card" key={index}>
      <FavoriteFloater
        style={{ top: -1, right: -1 }}
        // isFavorited={isFavorited}
      />
      {console.log(this)}
      <Link
        href={`/produtos/${props.productName.replace(/\s/g, '-')}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          tag="img"
          className="image"
          src={props.thumbnailImage}
          alt={props.productName}
        />
      </Link>
      <Link
        href={`/produtos/${props.productName.replace(/\s/g, '-')}`}
        // as={`/produtos/${name.replace(/\s/g, '-')}`}
      >
        <InteractiveElement
          onClick={handleProductClick}
          className="info"
          tag="div"
        >
          <p className="title">{props.productName}</p>
          {/* Price já é uma string */}
          <p className="price">{props.price}</p>
        </InteractiveElement>
      </Link>
    </div>
  );
};

export default ProductCard;
