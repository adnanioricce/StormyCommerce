import React from 'react';
import { useRouter } from 'next/router';
import Nav from '../components/Nav';
import Page from '../components/Page';
import api from '../services/api';
import Footer from '../components/Footer';
import Breadcumb from '../components/Breadcumb';
import FavoriteFloater from '../components/FavoriteFloater';
import TitleWithFloater from '../components/TitleWithFloater';
import Title from '../components/Title';
import Description from '../components/Description';
import Button from '../components/Button';
import ProductOptionsController from '../components/ProductOptionsController';

function product() {
  const { query } = useRouter();
  const { id: productID } = query;
  const [isLoading, setIsLoading] = React.useState(true);
  const [currentProduct, setCurrentProduct] = React.useState(null);
  React.useEffect(() => {
    api.get(`products`).then(({ data: products }) => {
      console.log(products);
      setCurrentProduct(products[productID]);
      console.log(products[productID]);
      setIsLoading(false);
    });
  }, [productID]);
  console.log(currentProduct);
  return (
    <Page>
      <Nav />

      {isLoading === false && currentProduct && (
        <div className="product-page-container">
          <Breadcumb paths={[currentProduct.category, currentProduct.name]} />
          <TitleWithFloater label={currentProduct.name}>
            <FavoriteFloater
              style={{ top: 0, left: '10%' }}
              isFavorited={currentProduct.isFavorited}
            />
          </TitleWithFloater>
          <div className="product-display-container">
            <img
              className="image"
              src={currentProduct.image}
              alt={currentProduct.name}
            />
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
