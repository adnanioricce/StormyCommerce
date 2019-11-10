import { Component } from "react";
import { Grid, Row, Col, Table } from "react-bootstrap";
import Card from "../../../components/Card/Card";
import CategoryClient from "stormycommerce-api-client/output/categoryClient";
export default class ListCategories extends Component{
    constructor(props){
        super(props);
        this.state = {
            categories:[]
        }
    }
    async componentDidMount(){
        const client = new CategoryClient();
        this.setState({categories: await client.getAll()});
    }
    render(){
        return (
            <Grid fluid>            
            <Row>
                <Col md={12}>
                <CustomButton bsStyle="primary">Adicionar Nova Categoria</CustomButton>
                    <Card
                        title="Categorias"
                        category="Categoria"
                        ctTableFullWidth
                        ctTableResponsive
                        content={
                            <Table hover>
                                <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Imagem de capa</th>  
                                        <th>Nome</th> 
                                        <th>slug</th>  
                                        <th>Ordem de Visualização</th>
                                        <th>Descrição</th>                                                                                                                     
                                    </tr>
                                </thead>
                                <tbody>
                                    <>{this.state.products.map(prop =>{                                                                                                                                               
                                        return <tr>
                                            {CategoryRow(prop)}
                                            <CustomButton bsStyle="warning">Editar</CustomButton>
                                            <CustomButton bsStyle="danger">Deletar</CustomButton>
                                        </tr>;
                                    })}</>                                                                        
                                </tbody>
                            </Table>
                        }/>
                </Col>
            </Row>            
        </Grid>
        )
    }
}
function CategoryRow(props) {
    return <>
        <td>{props.id}</td>
        <td>{props.thumbnailImage}</td>
        <td>{props.name}</td>
        <td>{props.slug}</td>
        <td>{props.displayOrder}</td>
        <td>{props.description}</td>
    </>
}