import React from 'react';
import '../static/styles/main.scss';
import Nav from './Nav';
import Footer from './Footer';

function Page({ children }) {
  return (
    <div>
      <Nav />
      {children}
      <Footer />
    </div>
  );
}

export default Page;
