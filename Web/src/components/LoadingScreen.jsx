import * as React from 'react';
import Router from 'next/router';
import Loading from './Loading';
import '../static/styles/components/_loadingScreen.scss';

export default () => {
  const [isOn, setIsOn] = React.useState(false);
  const handleRouteChange = url => {
    console.log('App is changing to: ', url);
    setIsOn(true);
  };
  const handleRouteComplete = url => {
    setIsOn(false);
  };
  React.useEffect(() => {
    Router.events.on('routeChangeStart', handleRouteChange);
    Router.events.on('routeChangeComplete', handleRouteComplete);
    return () => {
      Router.events.off('routeChangeStart', handleRouteChange);
      Router.events.off('routeChangeComplete', handleRouteComplete);
    };
  }, []);

  return (
    <div className={isOn ? 'loading-screen active' : 'loading-screen'}>
      <Loading />
    </div>
  );
};
