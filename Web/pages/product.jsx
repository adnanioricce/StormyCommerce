import React from 'react';
import { useRouter } from 'next/router';

function product(props) {
  const { query } = useRouter();
  const { id: productID } = query;
  console.log(productID);
  return <div />;
}

export default product;
