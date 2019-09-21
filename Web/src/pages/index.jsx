import * as React from 'react';
import '../static/styles/main.scss';
import Slide from '../components/Slide';
import Products from '../components/Products';
import Categories from '../components/Categories';
import Page from '../components/Page';
import api from '../services/api';

const HomePage = ({ products }) => {
  console.log(products);
  return (
    <Page>
      <Slide />
      <Products products={products} />
      <Categories />
    </Page>
  );
};

HomePage.getInitialProps = async () => {
  const response = await api.get('/products');
  const { data: products } = response;
  return { products };
};

export default HomePage;
