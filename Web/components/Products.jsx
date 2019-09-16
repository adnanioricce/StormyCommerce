import * as React from 'react';
import Header from './Header';
import ProductCard from './ProductCard';

export default ({ products = [] }) => {
  console.log(products);
  return (
    <>
      <Header label="Destaques" />
      <div className="products-container">{products.map(ProductCard)}</div>
    </>
  );
};
