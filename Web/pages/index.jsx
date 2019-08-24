import * as React from 'react';
import '../static/styles/main.scss';
import Nav from '../components/Nav';
import Slide from '../components/Slide';
import Products from '../components/Products';
import Categories from '../components/Categories';
import Footer from '../components/Footer';
import Page from '../components/Page';

export default () => (
  <Page>
    <Nav />
    <Slide />
    <Products />
    <Categories />
    <Footer />
  </Page>
);
