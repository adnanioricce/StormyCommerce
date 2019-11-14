import { Component } from "react";
// import CustomerClient from "stormycommerce-api-client";
import Card from "../../../components/Card/Card";
import { Grid, Row, Col, Table,ListGroup,ListGroupItem,ListGroupItemHeading,ListGroupItemText  } from "react-bootstrap";
export default class ListCustomer extends Component{
    constructor(props){
        super(props);
        this.state = {
            customers:[]
        }
    }
    async componentDidMount(){
        // const client = new CustomerClient("https://stormycommerceapi.azurewebsites.net");
        // this.setState({customers: await client.getCustomers()});
        console.log(this);
    }
    render(){
        return <Grid fluid>            
        <Row>
            <Col md={12}>            
                <Card
                    title="Clientes"
                    category="Cliente"
                    ctTableFullWidth
                    ctTableResponsive
                    content={
                        <Table hover>
                            <thead>
                                <tr>
                                    <th>Nome de Usuário</th>
                                    <th>Nome Completo</th>
                                    <th>Email</th>  
                                    <th>CPF</th> 
                                    <th>Numero de Celular</th>                                      
                                    <th>Endereço de Cobrança</th>
                                    <th>Endereço de Entrega</th>                                                                                                                                                      
                                </tr>
                            </thead>
                            <tbody>
                                <>{this.state.customers.map(c =>{                                                                                                                                               
                                    return <tr>
                                        {CustomerRow(c)}                                                                                
                                    </tr>;
                                })}</>                                                                        
                            </tbody>
                        </Table>
                    }/>
            </Col>
        </Row>            
    </Grid>
    }
}
function CustomerRow(props) {
    return <>
        <td>{props.userName}</td>
        <td>{props.fullName}</td>
        <td>{props.email}</td>
        <td>{props.cpf}</td>
        <td>{props.phoneNumber}</td>
        <td>
            <Card title="Endereço de Cobrança" content={
                <ListGroup>
                    {CustomerAddress(props.defaultBillingAddress)}                    
                </ListGroup>
            }/>            
        </td>
        <td>
            <Card title="Endereço de Entrega" content={
                <ListGroup>
                    {CustomerAddress(props.defaultShippingAddress)}
                </ListGroup>
            }/>
        </td>
    </>
}
function CustomerAddress(props) {
    return <ListGroup>
        <ListItem name="Id" value={props.id}/>
        <ListItem name="Rua" value={props.street}/>
        <ListItem name="Endereço 1" value={props.firstAddress}/>
        <ListItem name="Endereço 2" value={props.secondAddress}/>
        <ListItem name="Cidade" value={props.city}/>
        <ListItem name="Bairro" value={props.district}/>
        <ListItem name="Estado" value={props.state}/>
        <ListItem name="CEP" value={props.postalCode}/>
        <ListItem name="Complemento" value={props.complement}/>
        <ListItem name="Numero de Telefone" value={props.phoneNumber}/>
        <ListItem name="Pais" value={props.country}/>
        <ListItem name="Quem Recebe" value={props.whoReceives}/>                
    </ListGroup>
}
function ListItem(props) {
    return <ListGroupItem>
        <ListGroupItemHeading>{props.name}</ListGroupItemHeading>
            <ListGroupItemText>
                {props.value}
            </ListGroupItemText>
    </ListGroupItem>
}