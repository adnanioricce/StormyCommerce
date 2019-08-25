import { createStore, applyMiddleware } from 'redux';
import createSagaMiddleware from 'redux-saga';
import sagas from './sagas';
import reducers from './reducers';

const saga = createSagaMiddleware();

export default initialState => {
  const store = createStore(reducers, initialState, applyMiddleware(saga));

  saga.run(sagas);

  return store;
};
