import * as React from 'react';
import { Formik, Form, Field } from 'formik';
import { useRouter } from 'next/router';
import Link from 'next/link';
import axios from 'axios';
import Button from './Button';
import api from '../services/api';
import actions, { consts } from '../actions';
import { useDispatch } from 'react-redux';

export default () => {
  const router = useRouter();
  const [error, setError] = React.useState(null)
  const dispatch = useDispatch()
  return (
    <>
      <Formik
        initialValues={{
          email: '',
          password: ''
        }}
        onSubmit={async values => {
          console.log(values);
          let response;
          try{
            response = await api.post("/sessions", values)
            const {user, token} = response.data
            dispatch(actions.login(user, token))
          }catch(err){
            console.log(err)
            setError(err.response && err.response.data.error)
          }
          console.log(response)
        }}
      >
        {() => (
          <Form className="login-form">
            <FormField name="email" type="email" placeholder="Email" />
            <FormField name="password" type="password" placeholder="Senha" />
            <FormButton type="submit" label="Entrar" />
            <FormButton className="button google" label="Entrar com Google" />
            <FormButton
              className="button facebook"
              label="Entrar com facebook"
            />
            <FormButton styleType="secondary" type="submit" label="Cadastrar" />
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
const FormField = ({ ...props }) => <Field className="form-field" {...props} />;
