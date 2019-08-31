import React from 'react';
import { shallowEqual, useSelector, useDispatch } from 'react-redux';
import { useRouter } from 'next/router';
import ProductCard from './ProductCard';
import actions from '../actions';
import Title from './Title';

const RelatedProducts = ({ currentProduct }) => {
  console.log(`showing related products of ${currentProduct.name}`);
  const products = useSelector(state => state.products, shallowEqual);
  const route = useRouter();
  const dispatch = useDispatch();
  React.useEffect(() => {
    if (products.length === 0) {
      dispatch(actions.fetchProducts());
    }
  }, []);
  console.log(products);
  return (
    <>
      <Title label="Relacionados" />
      <div className="related-products">
        {products && products.map((...params) => ProductCard(...params, route))}
      </div>
    </>
  );
};

export default RelatedProducts;
