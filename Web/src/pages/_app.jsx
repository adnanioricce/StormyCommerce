/* eslint-disable no-underscore-dangle */
import App from 'next/app';
import React from 'react';
import { Provider } from 'react-redux';
import { PersistGate } from 'redux-persist/integration/react';
import withReduxStore from '../createStore';
import LoadingScreen from '../components/LoadingScreen';
import Loading from '../components/Loading';

class MyApp extends App {
  render() {
    const { Component, pageProps, reduxStore } = this.props;
    return (
      <Provider store={reduxStore}>
        <PersistGate persistor={reduxStore.__PERSISTOR} loading={<Loading />}>
          <Component {...pageProps} />
          <LoadingScreen />
        </PersistGate>
      </Provider>
    );
  }
}

export default withReduxStore(MyApp);
