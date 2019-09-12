import * as React from 'react';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import Title from '../components/Title';
import userSVG from '../static/assets/icons/user.svg';
import Button from '../components/Button';

export default () => {
  let isLogin = true;
  let form;
  if(isLogin){
    form = loginForm;
  } else {
    form = registerForm;
  }

  return (
    <Page>
      {form()}
      <Button onHandle={() => !isLoggedIn}/>      
    </Page>
  )
};
const loginForm = () => {
  return (
    <>      
      <Title label="Acessar" />            
      <img className="user-icon" src={userSVG} alt="Usuario" />      
      <LoginForm />
    </>
  );
}
const registerForm = () => {    
  return (
    <>      
      <Title label="Registrar" />            
      <img className="user-icon" src={userSVG} alt="Usuario" />      
      <RegisterForm/>          
    </>
  );
}