/* eslint-disable no-underscore-dangle */
import App from 'next/app';
import React from 'react';
import { Provider } from 'react-redux';
import { PersistGate } from 'redux-persist/integration/react';
import withReduxStore from '../createStore';

class MyApp extends App {
  render() {
    const { Component, pageProps, reduxStore } = this.props;
    return (
      <Provider store={reduxStore}>
        <PersistGate persistor={reduxStore.__PERSISTOR} loading={null}>
          <Component {...pageProps} />
        </PersistGate>
      </Provider>
    );
  }
}

export default withReduxStore(MyApp);
