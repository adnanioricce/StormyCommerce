import * as React from 'react';
import { Formik, Form, Field } from 'formik';
import { useRouter } from 'next/router';
import Link from 'next/link';
import Button from './Button';
import api from '../services/api';
export default () => {
  const router = useRouter();
  submitHandler = async function (loginVm) {
    await api.login(loginVm);
  }
  return (
    <>
      <Formik
        initialValues={{
          email: '',
          password: ''
        }}
        onSubmit={values => login(values)}
      >
        {() => (
          <Form className="login-form">
            <FormField name="email" type="email" placeholder="Email" />
            <FormField name="password" type="password" placeholder="Senha" />
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
            <FormButton
              styleType="secondary"
              onClick={() => console.log(router)}
              label="Cadastrar"
            />
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
const FormField = ({ ...props }) => <input className="form-field" {...props} />;
