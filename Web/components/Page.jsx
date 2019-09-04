import React from 'react';
import '../static/styles/main.scss';
import Nav from './Nav';
import Footer from './Footer';

function Page({ children }) {
  React.useEffect(() => {
    if (window) {
      window.onunload = function() {
        console.log('oi');
      };
    }
  }, []);
  return (
    <div>
      <Nav />
      {children}
      <Footer />
    </div>
  );
}

export default Page;
