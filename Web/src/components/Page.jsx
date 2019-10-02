import React from 'react';
import '../static/styles/main.scss';
import Nav from './Nav';
import Footer from './Footer';

function Page({ children }) {
  React.useEffect(() => {
    if (window) {
      window.onunload = function() {};
    }
  }, []);
  return (
    <div>
      <Nav />
      <div className="body">{children}</div>
      <Footer />
    </div>
  );
}

export default Page;
