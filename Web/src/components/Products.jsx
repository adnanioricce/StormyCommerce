import * as React from 'react';
import Header from './Header';
import ProductCard from './ProductCard';

export default ({props}) => {
  console.log(props);
  return (
    <>
      <Header label="Destaques" />
      <div className="products-container">{props.map(p => console.log(ProductCard(p,p.Id)))}</div>
    </>
  );
};
