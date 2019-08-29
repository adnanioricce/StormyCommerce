import React from 'react';
import { useRouter } from 'next/router';
import Nav from '../components/Nav';
import Page from '../components/Page';
import api from '../services/api';
import Footer from '../components/Footer';
import Breadcumb from '../components/Breadcumb';
import FavoriteFloater from '../components/FavoriteFloater';
import Title from '../components/Title';
import Description from '../components/Description';
import Button from '../components/Button';
import ProductOptionsController from '../components/ProductOptionsController';
import ProductImage from '../components/ProductImage';

function product() {
  const { query } = useRouter();
  const { id: productID } = query;
  const [isLoading, setIsLoading] = React.useState(true);
  const [currentProduct, setCurrentProduct] = React.useState(null);
  React.useEffect(() => {
    api.get(`products`).then(({ data: products }) => {
      setCurrentProduct(products[productID]);
      setIsLoading(false);
    });
  }, [productID]);
  return (
    <Page>
      <Nav />

      {isLoading === false && currentProduct && (
        <div className="product-page-container">
          <Breadcumb paths={[currentProduct.category, currentProduct.name]} />
          <Title label={currentProduct.name} />
          <div className="product-display-container">
            <ProductImage currentProduct={currentProduct} />

            <ProductOptionsController />
          </div>

          <Description text={currentProduct.description} />
          <Button label="Adicionar ao carrinho" />
        </div>
      )}
      <Footer />
    </Page>
  );
}

export default product;
