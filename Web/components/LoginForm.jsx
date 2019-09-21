import * as React from 'react';
import { Formik, Form, Field } from 'formik';
import { useRouter } from 'next/router';
import Link from 'next/link';
import Button from './Button';
import { AuthenticationClient } from '../services/AuthenticationClient';
import { SignInVm } from '../models/identity/SignInVm'
import redirect from '../util/redirect';
export default () => {
  const router = useRouter();
  const authClient = new AuthenticationClient();
  const submitHandler = async function (loginVm) {    
    console.log(loginVm);
    const model = new SignInVm(loginVm);
    console.log(model);
    const response = await authClient.login(model);
    console.log(response);
  }
  // {
  //   "email": "stormycommerce@gmail.com",
  //   "password": "!P4ssword",
  //   "confirmPassword": "!P4ssword",
  //   "userName": "stormydev"
  // }
  // submitHandler({userName:'devusername',password:'!D4vpassword',email:'stormycommerce@gmail.com'})
  return (
    <>
      <Formik
        initialValues={{     
          userName:'stormydev',     
          email: '',
          password: ''
        }}
        //NOTE:O backend já tem validações, mas pra ajudar o usuário, é melhor fazer isso aqui tambem.
        validate={values => {
          let errors = {};
          if(!values.email){
            errors.email = "Obrigatório";
          } else if(!/^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i.test(values.email)){
            errors.email = "Invalid email address";
          }
          return erros;
        }}
        onSubmit={(values,{setSubmitting}) => {
          console.log(values);
          setTimeout(async () => {
            alert(JSON.stringify(values,null,2));
            await submitHandler(values);
            setSubmitting(false);
            redirect({},'/');
          },400)          
        }}
        
      >
        {() => (
          <Form className="login-form" >
            <Field className="form-field" name="email" type="email" placeholder="Email" />
            <Field className="form-field" name="password" type="password" placeholder="Senha" />
            <FormButton type="submit" label="Entrar" />
            <FormButton
              className="button google"
              onClick={() => console.log(router)}
              label="Entrar com Google"
            />
            <FormButton
              className="button facebook"
              onClick={() => console.log(router)}
              label="Entrar com facebook"
            />
            {/* <FormButton
              styleType="secondary"
              onClick={() => console.log(router)}
              label="Cadastrar"
            /> */}
            <Link href="lost-password">
              <p className="lost-password-label">Esqueci minha senha</p>
            </Link>
          </Form>
        )}
      </Formik>
    </>
  );
};

const FormButton = ({ ...props }) => (
  <Button style={{ margin: '5px 0px' }} {...props} />
);
// const FormField = ({ ...props }) => <input className="form-field" {...props} />;
