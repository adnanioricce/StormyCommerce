/* eslint-disable react/jsx-one-expression-per-line */
import * as React from 'react';

export default ({ price, oldPrice }) => {
  const priceParcelado = `R$ ${(price / 3).toFixed(2)}`;
  return (
    <div className="price-display-container">
      <h1>{`${oldPrice ? `De R$ ${oldPrice.toFixed(2)}` : ''} Por R$ ${price.toFixed(2)}`}</h1>
      <span>
        ou <b>6x</b> de <b>{priceParcelado}</b> sem juros
      </span>
    </div>
  );
};
