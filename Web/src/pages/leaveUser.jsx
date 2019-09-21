import * as React from 'react';
import { useRouter } from 'next/router';
import { useDispatch } from 'react-redux';
import actions from '../actions';

export default () => {
  const dispatch = useDispatch();
  const route = useRouter();
  React.useEffect(() => {
    dispatch(actions.disconnect());
    route.push('/');
  });
  return <></>;
};
