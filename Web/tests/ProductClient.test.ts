import ProductClient from "../services/ProductClient";
const fs = require('fs');
require('https').globalAgent.options.pfx = fs.readFileSync(process.env.APPDATA + '\\ASP.NET\\Https\\SimplCommerce.WebHost.pfx');
require('https').globalAgent.options.passphrase = "simpldevpassword";
describe('should return ProductDto when pass id',() => {
    it('getProductById',async () =>{
        // const id = 1;
        const client = new ProductClient();
        const response = await client.getAllProducts(0,10);
        expect(response.length).toBe(10);
    })
})