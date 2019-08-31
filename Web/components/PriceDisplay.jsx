/* eslint-disable react/jsx-one-expression-per-line */
import * as React from 'react';

export default ({ price, oldPrice }) => {
  const priceParcelado = `R$ ${(price / 3).toFixed(2)}`;
  return (
    <div className="price-display-container">
      <h1>{`${oldPrice ? `De: R$ ${oldPrice}` : ''}Por: R$ ${price}`}</h1>
      <span>
        ou <b>6x</b> de <b>{priceParcelado}</b> sem juros
      </span>
    </div>
  );
};
