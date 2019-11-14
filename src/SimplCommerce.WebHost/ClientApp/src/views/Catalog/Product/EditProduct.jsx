import { Component } from "react";

export default class EditProduct extends Component{
    constructor(props){
        super(props);
        this.state = {
            id:0,
            product:{}
        }    
        this.submitHandler = this.submitHandler.bind(this);     
        this.changeHandler = this.changeHandler.bind(this);   
    }
    async submitHandler(e) {
        // const Client = new ProductClient("https://stormycommerceapi.azurewebsites.net");
        // await Client.editProduct(e.target.value);
        console.log(e);
    }
    changeHandler(e){
        this.setState({product:e.target.value});
        e.preventDefault();
    }
    componentWillMount(){
        const productClient = new ProductClient("https://stormycommerceapi.azurewebsites.net");        
        productClient.getProductById(this.state.id).then((data) => console.log(data));        
    }
    render(){
        return(
            <Form method="POST" action="https://stormycommerceapi.azurewebsites.net/api/Product/create" onChange={this.changeHandler}>
                <FormGroup>
                    <Label for="productId">Id</Label>
                    <Input type="number" value={`${this.state.product.id}`} name="productId" id="productId" placeholder="Id" />
                </FormGroup>
                <FormGroup>
                    <Label for="productName">Nome do Produto *</Label>
                    <Input type="text" name={`${this.state.product.productName}`} id="productName" placeholder="Nome do Produto"/>
                </FormGroup>
                <FormGroup>
                    <Label for="slug">Slug</Label>
                    <Input type="text" value={`${this.state.product.slug}`} name="slug" id="slug" placeholder="Slug"/>
                </FormGroup>
                <FormGroup>
                    <Label for="quantityPerUnity">Quantidade por unidade</Label>
                    <Input type="number" value={`${this.state.product.quantityPerUnity}`} name="quantityPerUnity" id="quantityPerUnity" placeholder="Quantidade por unidade"/>
                </FormGroup>
                <FormGroup>
                    <Label for="unitSize">Tamanho por unidade *</Label>
                    <Input type="number" value={`${this.state.product.unitSize}`} name="unitSize" id="unitSize" placeholder="Tamanho por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <Label for="unitPrice">Preço por unidade *</Label>
                    <Input type="number" value={`${this.state.product.unitPrice}`} name="unitPrice" id="unitPrice" placeholder="Preço por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <Label for="discount">Desconto</Label>
                    <Input type="number" value={`${this.state.product.discount}`} name="discount" id="discount" placeholder="Desconto"/>
                </FormGroup>
                <FormGroup>
                    <Label for="unitWeight">Peso por unidade(KG) *</Label>
                    <Input type="number" value={`${this.state.product.unitWeight}`} name="unitWeight" id="unitWeight" placeholder="Peso por Unidade"/>
                </FormGroup>
                <FormGroup>
                    <Label for="unitsOnOrder">Unidades Vendidas *</Label>
                    <Input type="number" value={`${this.state.product.unitsOnOrder}`} name="unitsOnOrder" id="unitsOnOrder" placeholder="Unidades Vendidas"/>
                </FormGroup>
                <FormGroup>
                    <Label for="unitsInStock">Unidades em Estoque *</Label>
                    <Input type="number" value={`${this.state.product.unitsInStock}`} name="unitsInStock" id="unitsInStock" placeholder="Unidades em Estoque"/>
                </FormGroup>
                <FormGroup>
                    <Label for="price">Preço *</Label>
                    <Input type="text" value={`${this.state.product.price}`} name="price" id="price" placeholder="Preço"/>
                </FormGroup>
                <FormGroup>
                    <Label for="thumbnailImage">Imagem de Capa *</Label>
                    <Input type="file" value={`${this.state.product.thumbnailImage}`} name="thumbnailImage" id="thumbnailImage" placeholder="thumbnailImage"/>
                    <FormText color="muted">
                        Selecione um arquivo de imagem. 
                        Formatos Suportados:png e jpg.
                    </FormText>
                </FormGroup>                
                <FormGroup>
                    <Label for="medias">Imagens</Label>
                    <Input multiple type="file" name="medias" id="medias" placeholder="Imagens"/>
                    <FormText color="muted">
                        Selecione um ou mais arquivos de imagem. 
                        Formatos Suportados:png e jpg.
                    </FormText>
                </FormGroup>
                <FormGroup>
                    <Label for="category">Categoria</Label>
                    <Input type="select" value={`${this.state.product.category.name}`} name="category" id="category" placeholder="Categoria"/>
                </FormGroup>    
                <FormGroup>
                    {/* Vendor não é um fornecedor... */}
                    <Label for="vendor">Fornecedor</Label>
                    <Input type="select" value={`${this.state.product.vendor}`} name="vendor" id="vendor" placeholder="Fornecedor"/>
                </FormGroup>            
                <FormGroup>
                    <CustomButton onSubmit={this.submitHandler}>Confirmar</CustomButton>
                </FormGroup>
            </Form>
        )
    }
}