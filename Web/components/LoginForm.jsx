import * as React from 'react';
import { Formik, Form, Field } from 'formik';
import { useRouter } from 'next/router';
import Link from 'next/link';
import axios from 'axios';
import Button from './Button';
import api from '../services/api';

export default () => {
  const router = useRouter();
  return (
    <>
      <Formik
        initialValues={{
          email: '',
          password: ''
        }}
        onSubmit={async values => {
          console.log(values);
          const response = await fetch('http://localhost:5000/api/sessions', {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
              withCredentials: true
            },
            body: JSON.stringify({
              email: 'danilex@stormy.com',
              password: '123456'
            })
          });
          console.log(response);
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
const FormField = ({ ...props }) => <input className="form-field" {...props} />;
