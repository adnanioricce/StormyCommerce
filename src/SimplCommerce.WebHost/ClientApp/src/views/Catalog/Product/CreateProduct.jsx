import React,{ Component } from "react";
import {  Form,FormControl,HelpBlock,ControlLabel,FormGroup  } from 'react-bootstrap';
import CustomButton from "components/CustomButton/CustomButton";
// import { CategoryClient }from "stormycommerce-api-client/output/services/categoryClient";
export default class CreateProduct extends Component{
    constructor(props){
        super(props);
        this.state = {
            product:{},
            categories:[],
            vendors:[]
        }        
    }
    async componentDidMount(){        
        const categories = await fetch("https://stormycommerceapi.azurewebsites.net/api/Category/list");
            console.log(categories);
            this.setState({categories:categories});        
    }
    async handleSubmit(e){
        console.log(e);
    }
    render(){
        return(
            <form method="POST" action="https://stormycommerceapi.azurewebsites.net/api/product/create">                               
                <FormGroup controlId="formBasicText">
                    <ControlLabel for="productId">Id</ControlLabel>
                    <FormControl type="number" name="productId" value="" id="productId" placeholder="Id"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="productName">Nome do Produto *</ControlLabel>
                    <FormControl type="text" name="productName" id="productName" placeholder="Nome do Produto"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="slug">Slug</ControlLabel>
                    <FormControl type="text" name="slug" id="slug" placeholder="Slug"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="quantityPerUnity">Quantidade por unidade</ControlLabel>
                    <FormControl type="number" name="quantityPerUnity" id="quantityPerUnity" placeholder="Quantidade por unidade"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="unitSize">Tamanho por unidade *</ControlLabel>
                    <FormControl type="number" name="unitSize" id="unitSize" placeholder="Tamanho por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="unitPrice">Preço por unidade *</ControlLabel>
                    <FormControl type="number" name="unitPrice" id="unitPrice" placeholder="Preço por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="discount">Desconto</ControlLabel>
                    <FormControl type="number" name="discount" id="discount" placeholder="Desconto"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="unitWeight">Peso por unidade(KG) *</ControlLabel>
                    <FormControl type="number" name="unitWeight" id="unitWeight" placeholder="Peso por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="unitsOnOrder">Unidades Vendidas *</ControlLabel>
                    <FormControl type="number" name="unitsOnOrder" id="unitsOnOrder" placeholder="Unidades Vendidas"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="unitsInStock">Unidades em Estoque *</ControlLabel>
                    <FormControl type="number" name="unitsInStock" id="unitsInStock" placeholder="Unidades em Estoque"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="price">Preço *</ControlLabel>
                    <FormControl type="text" name="price" id="price" placeholder="Preço"/>
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="thumbnailImage">Imagem de Capa *</ControlLabel>
                    <FormControl type="file" name="thumbnailImage" id="thumbnailImage" placeholder="thumbnailImage"/>
                    {/* <Form.Text color="muted">
                        Selecione um arquivo de imagem. 
                        Formatos Suportados:png e jpg.
                    </Form.Text> */}
                </FormGroup>                
                <FormGroup>
                    <ControlLabel for="medias">Imagens</ControlLabel>
                    <FormControl multiple type="file" name="medias" id="medias" placeholder="Imagens"/>
                    {/* <Form.Text color="muted">
                        Selecione um ou mais arquivos de imagem. 
                        Formatos Suportados:png e jpg.
                    </Form.Text> */}
                </FormGroup>
                <FormGroup>
                    <ControlLabel for="category">Categoria</ControlLabel>
                    <FormControl componentClass="select" type="select" name="category" id="category" placeholder="Categoria">
                        {this.state.categories.map(c => <option key={c.name} value={c.name}>{c.name}</option>)}
                    </FormControl>
                </FormGroup>    
                <FormGroup>                    
                    <ControlLabel for="vendor">Fornecedor</ControlLabel>
                    <FormControl componentClass="select" type="select" name="vendor" id="vendor" placeholder="Fornecedor"/>
                </FormGroup>            
                <FormGroup>
                    <CustomButton type="submit">Confirmar</CustomButton>
                </FormGroup>
            </form>
        )
    }
}