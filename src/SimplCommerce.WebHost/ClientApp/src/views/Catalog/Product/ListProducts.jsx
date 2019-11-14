import React,{ Component } from "react";
import {Route,withRouter,Redirect} from "react-router";
import { Grid, Row, Col, Table } from "react-bootstrap";
import Card from "../../../components/Card/Card";
import CustomButton from "components/CustomButton/CustomButton";
// import { ProductDto } from "stormycommerce-api-client/output/models/catalog/ProductDto";
// import ProductCard from "./ProductCard";
export default class Product extends Component {
    constructor(props){
        super(props);
        this.state = {
          products:[],
          selectedProduct:{},
          productsCount:0,
          redirectToProduct:false,
          redirectToCreate:false
        }
        this.handleRowClick = this.handleRowClick.bind(this);
        this.handleCreateClick = this.handleCreateClick.bind(this);
      }    
    handleRowClick = (e) => {
        console.log(e.target.value);
        this.setState({selectedProduct:e.target.value,
        redirectToProduct:true,
        redirectToCreate:false});        
    }
    handleCreateClick(){        
        this.setState({redirectToCreate:true,
        redirectToProduct:false});
    }
    objectMap(object, mapFn) {
        return Object.keys(object).reduce(function(result, key) {
          result[key] = mapFn(object[key])
          return result
        }, {})
      }   
    mapToTable(obj){
        for(const prop in obj){
            if(Object.prototype.hasOwnProperty.call(obj,prop)){
                return <td>{obj}</td>
            }
        }
    }
    async componentDidMount(){
        // const client = new ProductClient("https://stormycommerceapi.azurewebsites.net");        
        // const products = await client.getAllProducts();        
        // this.setState({products:products});
        console.log(this);
    }
    render(){        
    const redirectToProduct = this.state.redirectToProduct;
    const redirectToCreate = this.state.redirectToCreate;
    if(redirectToProduct) return <Redirect to={{
        path:"/editProduct",
        state:this.state.selectedProduct}}/>
    if(redirectToCreate) return <Redirect to={{
        path:"/Catalog/Product/CreateProduct"}}/>
    return <Grid fluid>            
            <Row>
                <Col md={12}>
                <CustomButton onClick={this.handleCreateClick} bsStyle="primary">Adicionar novo produto</CustomButton>
                    <Card
                        title="Catalogo"
                        category="Produto"
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
                                        <th>Quantidade por unidade</th>
                                        <th>Tamanho por unidade</th>  
                                        <th>Unidade por Preço</th> 
                                        <th>Desconto</th> 
                                        <th>Peso por Unidade</th> 
                                        <th>Unidades em estoque</th> 
                                        <th>Unidades vendidas</th> 
                                        <th>Preço</th>  
                                        <th>Preço anterior</th>                                          
                                    </tr>
                                </thead>
                                <tbody>
                                    <>{this.state.products.map(prop =>{                                                                                                                                               
                                        return <tr key={prop.id}>
                                        {ProductRow(prop)}                                                                                
                                        </tr>                                        
                                    })}
                                    <CustomButton  bsStyle="danger">Deletar</CustomButton></>                                                                        
                                </tbody>
                            </Table>
                        }/>
                </Col>
            </Row>
            
        </Grid>
    }
}

function ProductRow(props){
    console.log(props);
    return <>
        <td>{props.id}</td>
        <td><img src={props.thumbnailImage}/></td>
        <td>{props.productName}</td>
        <td>{props.slug}</td>
        <td>{props.quantityPerUnity}</td>
        <td>{props.unitSize}</td>
        <td>{props.unitPrice}</td>
        <td>{props.discount}</td>
        <td>{props.unitWeight}</td>
        <td>{props.unitsInStock}</td>
        <td>{props.unitsOnOrder}</td>        
        <td>{props.price}</td>
        <td>{props.oldPrice}</td>             
    </>
}