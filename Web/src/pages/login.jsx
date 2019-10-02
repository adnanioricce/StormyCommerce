import * as React from 'react';
import { useRouter } from 'next/router';
import { useSelector, shallowEqual } from 'react-redux';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import Title from '../components/Title';
import UserAvatar from '../components/UserAvatar';

export default () => {
  const router = useRouter();
  const user = useSelector(state => state.user, shallowEqual);
  React.useEffect(() => {
    // if user is false
    console.log(user);
    if (user.name) {
      router.push('/user');
    }
  });
  return (
    <Page>
      <Title label="Acessar" />

      <UserAvatar />
      <LoginForm />
    </Page>
  );
};
