import * as React from 'react';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import RegisterForm from '../components/RegisterForm';
import Title from '../components/Title';
import userSVG from '../static/assets/icons/user.svg';
// import Button from '../components/Button';
import { useSetState } from 'react-use';
import { render } from 'react-dom';

export default class Login extends React.Component {
  constructor(props){
    super(props);   
    this.handleLoginClick = this.handleLoginClick.bind(this); 
    this.handleLogoutClick = this.handleLogoutClick.bind(this);    
    this.state = {
      isLogin: true,
      form:null
    }
  }    
  handleLoginClick = () => {
    this.setState({isLogin:!this.state.isLogin})
  }
  handleLogoutClick = (e) => {
    this.setState({islogin:!this.state.isLogin})
  }  
  render(){  
    console.log("working")  
    const islogin = this.state.isLogin;    
    let button;
    let form;
    if(islogin){
      form = loginForm();
      button = Button({label:'Entrar',onClick:this.handleLoginClick});
    }else {
      form = registerForm();
      button = Button({label:'Registrar',onClick:this.handleLogoutClick});
    }
    return (
        <Page>
          {form}
          {button}  
      </Page>
    )
  }
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
const Button = ({optionName,onClick}) => {
  return(
    <button onClick={onClick}>
      {optionName}
    </button>
  )
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

