import * as React from 'react';
import '../static/styles/main.scss';
import Slide from '../components/Slide';
import Categories from '../components/Categories';
import Page from '../components/Page';
import api from '../services/api';
import Header from '../components/Header';
import ProductCard from '../components/ProductCard';
const HomePage = (products) => {
  const productCards = Object.values(products);
  console.log(productCards);
  return (
    <Page>
      <Slide />
      <Header label="Destaques" />
      <div className="products-container">
      {productCards.map(p => ProductCard(p,p.id))}
      </div>
      <Categories />
    </Page>
  );
};

HomePage.getInitialProps = async () => {
  const response = await api.getAllProducts(0,50);    
  return response;
};
function objectMap(object, mapFn) {
  return Object.keys(object).reduce(function(result, key) {
    result[key] = mapFn(object[key])
    return result
  }, {})
}
export default HomePage;
