import * as React from 'react';
import { Formik, Form, Field } from 'formik';
import { useRouter } from 'next/router';
import Link from 'next/link';
import { useDispatch } from 'react-redux';
import Button from './Button';
import api from '../services/api';
import actions from '../actions';

export default () => {
  const route = useRouter();
  const [error, setError] = React.useState(null);
  const dispatch = useDispatch();
  return (
    <div className="form-container">
      <Formik
        initialValues={{
          email: '',
          password: ''
        }}
        onSubmit={async values => {
          let response;
          try {
            response = await api.post('/sessions', values);
            const { user, token } = response.data;
            console.log(user, token);
            dispatch(actions.login(user, token));
            route.push('/user');
          } catch (err) {
            console.log(err);
            setError(err.response && err.response.data.error);
          }
        }}
      >
        {() => (
          <Form className="login-form">
            <FormField name="email" type="email" placeholder="Email" />
            <FormField name="password" type="password" placeholder="Senha" />
            <FormButton type="submit" label="Entrar" />
          </Form>
        )}
      </Formik>
      <FormButton className="button google" label="Entrar com Google" />
      <FormButton className="button facebook" label="Entrar com facebook" />
      <FormButton styleType="secondary" type="submit" label="Cadastrar" />
      <Link href="lost-password">
        <p className="lost-password-label">Esqueci minha senha</p>
      </Link>
    </div>
  );
};

const FormButton = ({ ...props }) => (
  <Button style={{ margin: '5px 0px' }} {...props} />
);
const FormField = ({ ...props }) => <Field className="form-field" {...props} />;
