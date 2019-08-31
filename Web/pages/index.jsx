import * as React from 'react';
import '../static/styles/main.scss';
import Nav from '../components/Nav';
import Slide from '../components/Slide';
import Products from '../components/Products';
import Categories from '../components/Categories';
import Footer from '../components/Footer';
import Page from '../components/Page';
import api from '../services/api';

const HomePage = ({ products }) => {
  return (
    <Page>
      <Nav />
      <Slide />
      <Products products={products} />
      <Categories />
      <Footer />
    </Page>
  );
};

HomePage.getInitialProps = async () => {
  const response = await api.get('/products');
  const { data: products } = response;
  return { products };
};

export default HomePage;
