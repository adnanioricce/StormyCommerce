import * as React from 'react';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import Title from '../components/Title';
import userSVG from '../static/assets/icons/user.svg';

export default () => {
  return (
    <Page>
      <Title label="Acessar" />
      <img className="user-icon" src={userSVG} alt="Usuario" />
      <LoginForm />
    </Page>
  );
};
