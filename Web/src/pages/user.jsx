import * as React from 'react';
import { useSelector, shallowEqual } from 'react-redux';
import { useRouter } from 'next/router';
import Page from '../components/Page';
import UserAvatar from '../components/UserAvatar';
import Header from '../components/Header';
import UserAcessMenu from '../components/UserAcessMenu';

export default () => {
  const user = useSelector(state => state.user, shallowEqual);
  const router = useRouter();
  React.useEffect(() => {
    // if user is false
    console.log(user);
    if (!user.name) {
      router.push('/login');
    }
  });
  return (
    <Page>
      <Header
        label={user.name}
        style={{ margin: '5px auto', border: 'none' }}
        border={false}
      />
      <UserAvatar />
      <UserAcessMenu />
    </Page>
  );
};
