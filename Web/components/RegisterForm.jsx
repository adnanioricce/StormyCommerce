import { useRouter } from "next/router";
import api from '../services/api';
//TODO:Eu poderia ter evitado tudo isso com um if sem prejudicar a legibilidade disso?
export default () => {
    const router = useRouter();
    submitHandler = async function (registerVm){
        await api.register(registerVm);
    }
    return (
        <>
            <Formik
                initialValues={{
                    //TODO: Pesquise pra saber se isso é seguro
                    email:'',                    
                    password:''
                }}                
                // onSubmit={values => alert(JSON.stringify(values,null,2))}
                onSubmit={values => submitHandler(values)}>
                {/*TODO:um estilo pro form de cadastro? */}
                {/*TODO:Validações */}
                <Form className="login-form">
                    <FormField name="email" type="email" placeholder="Email" />                    
                    <FormField name="password" type="password" placeholder="Senha" />
                    <FormButton type="submit" label="Entrar" />
                    <FormButton
                        className="button google"
                        onClick={() => console.log(router)}
                        label="Entrar com Google"/>
                    <FormButton
                        className="button facebook"
                        onClick={() => console.log(router)}
                        label="Entrar com facebook"/>                    
                    <Link href="lost-password">
                    <p className="lost-password-label">Esqueci minha senha</p>
                    </Link>
                </Form>
            </Formik>
        </>
    )
}