import React from 'react';
import Nav from '../components/Nav';
import Page from '../components/Page';
import api from '../services/api';
import Footer from '../components/Footer';
import Breadcumb from '../components/Breadcumb';
import Title from '../components/Title';
import Description from '../components/Description';
import ProductOptionsController from '../components/ProductOptionsController';
import ProductImage from '../components/ProductImage';
import RelatedProducts from '../components/RelatedProducts';

function product({ currentProduct }) {
  // const [isLoading, setIsLoading] = React.useState(false);
  // const [currentProduct, setCurrentProduct] = React.useState(null);
  // React.useEffect(() => {
  //   api.get(`products`).then(({ data: products }) => {
  //     setCurrentProduct(products[productID]);
  //     setIsLoading(false);
  //   });
  // }, [productID]);
  return (
    <Page>
      <Nav />

      {currentProduct && (
        <div className="product-page-container">
          <Breadcumb paths={[currentProduct.category, currentProduct.name]} />

          <div className="product-display-container">
            <ProductImage currentProduct={currentProduct} />

            <ProductOptionsController currentProduct={currentProduct} />
          </div>

          <Description text={currentProduct.description} />
          <RelatedProducts currentProduct={currentProduct} />
        </div>
      )}
      <Footer />
    </Page>
  );
}

product.getInitialProps = async ({ query }, ...props) => {
  const response = await api.get('/products');
  const { data: products } = response;
  const currentProduct = products.filter(e => e.name === query.name)[0];
  return { ...props, currentProduct };
};

export default product;
