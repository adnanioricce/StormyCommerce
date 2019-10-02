import { CustomerClient } from '../services/customerClient';
//instanciando um 'cliente' para falar com o servidor
const client = new CustomerClient("https://stormycommerceapi.azurewebsites.net");
const authClient = new 
//definindo um "caso de teste"
describe('should return all existing customers on the server',() => {
	it('getCutomers',async () => {
		// const accessToken = await 				
		const response = await client.getCustomers();		
		//acho que não tem nenhum customer no sistema ainda
		expect(response.length).toBeGreaterThanOrEqual(0);
	}
});
// describe('should ')
describe('should get customer with given username or email',() => {
	it('getCustomerByEmailOrUsername',async () => {	
		const model = JSON.parse("../../../../createUserRequestData.json"); 	
		const token = authClient.login(new SignInVm(model));
		client.setAccessToken(token);
		const response = await client.getCustomerByEmailOrUsername(model.userName,model.email);
		expect(response.userName).toBe(model.userName);
		expect(response.email).toBe(model.email);		
	})
}
//TODO: 
//createCustomer 
//writeReview 