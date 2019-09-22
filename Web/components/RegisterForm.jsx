import { useRouter } from "next/router";
import { AuthenticationClient } from "../services/AuthenticationClient";
import { Formik, Form, Field } from 'formik';
import Link from 'next/link';
import Button from './Button';
import { SignUpVm } from "../models/identity/SignUpVm";
// import Button from './Button';
//TODO:Eu poderia ter evitado tudo isso com um if sem prejudicar a legibilidade disso?
export default () => {
    const router = useRouter();
    const authClient = new AuthenticationClient();
    const submitHandler = async function (registerVm){
        const response = await authClient.register(registerVm);
        console.log(response);
    }
    submitHandler(new SignUpVm({userName:"devusername",email:"stormycommerce@gmail.com",password:"!D4vpassword",confirmPassword:"!D4vpassword"}))
    return (
        <>
            <Formik
                initialValues={{                    
                    userName:'',
                    email:'',                    
                    password:'',
                    confirmPassword:'',
                    
                }}                
                // onSubmit={values => alert(JSON.stringify(values,null,2))}
                onSubmit={values => submitHandler(new SignUpVm({userName:values.userName,email:values.email,password:values.password,confirmPassword:values.confirmPassword}))}>
                {/*TODO:um estilo pro form de cadastro? */}
                {/*TODO:Validações */}
                <Form className="login-form">
                    <FormField name="username" type="username" placeholder="Nome de usuário"/> 
                    <FormField name="email" type="email" placeholder="Email" />                    
                    <FormField name="password" type="password" placeholder="Senha" />
                    <FormField name="confirmPassword" type="password" placeholder="Confirme sua senha"/>
                    <FormButton type="submit" label="Registrar" />
                    <FormButton
                        className="button google"
                        onClick={() => console.log(router)}
                        label="Registrar com Google"/>
                    <FormButton
                        className="button facebook"
                        onClick={() => console.log(router)}
                        label="Registrar com facebook"/>                    
                    <Link href="lost-password">
                    <p className="lost-password-label">Esqueci minha senha</p>
                    </Link>
                </Form>
            </Formik>
        </>
    )
}
const FormButton = ({ ...props }) => (
    <Button style={{ margin: '5px 0px' }} {...props} />
  );
const FormField = ({ ...props }) => <input className="form-field" {...props} />;