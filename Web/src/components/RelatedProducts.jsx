import React from 'react';
import { useRouter } from 'next/router';
import ProductCard from './ProductCard';
import Title from './Title';

const RelatedProducts = ({ relatedProducts }) => {
  const route = useRouter();
  return (
    <>
      <Title label="Relacionados" />
      <div className="related-products">
        {relatedProducts &&
          relatedProducts.map((...params) => ProductCard(...params, route))}
      </div>
    </>
  );
};

export default RelatedProducts;
