import * as React from 'react';
import api from '../services/api';
import Page from '../components/Page';
import filterSVG from '../static/assets/icons/filter.svg';
import searchSVG from '../static/assets/icons/search.svg';
import orderSVG from '../static/assets/icons/order.svg';
import ProductCard from '../components/ProductCard';

const ProductsListModifier = ({}) => {
  return (
    <div className="product-list-modifiers-container">
      <div className="modifier">
        <img src={filterSVG} alt="filtrar produtos" />
        <p>Filtrar</p>
      </div>
      <div className="modifier">
        <img src={searchSVG} alt="pesquisar produtos" />
        <p>Pesquisar</p>
      </div>
      <div className="modifier">
        <img src={orderSVG} alt="ordenar produtos" />
        <p>Ordenar</p>
      </div>
    </div>
  );
};

const ProductsCounter = ({ productsQuantity }) => {
  return (
    <div className="products-quantity">
      <p>
        {productsQuantity}
        items encontrados
      </p>
    </div>
  );
};

const Products = ({ products }) => {
  // console.log(products);

  return (
    <Page>
      <ProductsListModifier />
      <ProductsCounter productsQuantity={products.length} />
      <div className="productsPage-container">{products.map(ProductCard)}</div>
    </Page>
  );
};

Products.getInitialProps = async () => {
  const response = await api.get('/products');
  const { data: products } = response;
  return { products };
};

export default Products;
