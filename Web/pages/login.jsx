import * as React from 'react';
import Link from 'next/link';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import RegisterForm from '../components/RegisterForm';
import Title from '../components/Title';
import userSVG from '../static/assets/icons/user.svg';
import * as FormButton from 'formik';
// import Button from '../components/Button';
import { useSetState } from 'react-use';
import { render } from 'react-dom';
import { AuthenticationClient } from "../services/AuthenticationClient";
export default class Login extends React.Component {  
  constructor(props){
    super(props);   
    this.handleLoginClick = this.handleLoginClick.bind(this); 
    this.handleLogoutClick = this.handleLogoutClick.bind(this);    
    this.state = {
      isLogin: true,
      form:null,            
    }
    

  }    
  handleLoginClick = () => {
    this.setState({isLogin:!this.state.isLogin})
  }
  handleLogoutClick = () => {
    this.setState({islogin:!this.state.isLogin})
  }  
  render(){  
    console.log("working")                  
    return (
        <Page>
          <Title label="Acessar" />            
          <img className="user-icon" src={userSVG} alt="Usuario" />      
          <LoginForm />          
      </Page>
    )
  }
}
const loginForm = () => {
  return (
    <>      
      <Title label="Acessar" />            
      <img className="user-icon" src={userSVG} alt="Usuario" />      
      <LoginForm />
    </>
  );
}  

