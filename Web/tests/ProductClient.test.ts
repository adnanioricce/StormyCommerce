import ProductClient from "../services/productClient";
describe('should return ProductDto when pass id',() => {
    it('getProductById',async () =>{
        // const id = 1;
        const client = new ProductClient();
        const response = await client.getAllProducts(0,10);
        expect(response.length).toBe(10);
    })
})
