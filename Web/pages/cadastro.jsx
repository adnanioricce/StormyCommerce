import * as React from 'react';
import Page from '../components/Page';
import LoginForm from '../components/LoginForm';
import RegisterForm from '../components/RegisterForm';
import Title from '../components/Title';
import userSVG from '../static/assets/icons/user.svg';
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
    return (<Page>
        <Title label="Registrar" />            
        <img className="user-icon" src={userSVG} alt="Usuario" />      
        <RegisterForm/>
      </Page>
    )
  }
}