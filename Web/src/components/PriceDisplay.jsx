/* eslint-disable react/jsx-one-expression-per-line */
import * as React from 'react';
import toPrice from '../util/toPrice';

export default ({ price, oldPrice }) => {
  const priceParcelado = `R$ ${(price / 3).toFixed(2)}`;
  return (
    <div className="price-display-container">
      <h1>{`${oldPrice ? `De ${toPrice(oldPrice)}` : ''} Por ${toPrice(
        price
      )}`}
      </h1>
      <span>
        ou <b>6x</b> de <b>{priceParcelado}</b> sem juros
      </span>
    </div>
  );
};
