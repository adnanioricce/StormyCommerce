import * as React from 'react';
import { useRouter } from 'next/router';
import { useSelector, shallowEqual, useDispatch } from 'react-redux';
import Header from './Header';
import ProductCard from './ProductCard';
import actions from '../actions';

export default () => {
  const products = useSelector(state => state.products, shallowEqual);
  const dispatch = useDispatch();
  React.useEffect(() => {
    dispatch(actions.getProducts());
  }, []);
  const route = useRouter();
  console.log(products, dispatch);
  return (
    <>
      <Header label="Destaques" />
      <div className="products-container">
        {products.map((...params) => ProductCard(...params, route))}
      </div>
    </>
  );
};
