import { SignInVm } from "../models/identity/SignInVm";
import { AuthenticationClient } from "../services/AuthenticationClient";

describe('should return token when send SignInVm for user with existing credentials',() => {it('login',async () => {    
    const model = new SignInVm({email:"stormycommerce@gmail.com",password:'!D4vpassword'});
    const client = new AuthenticationClient("https://localhost");
    const response = await client.login(model);
    expect(response).toBe('');
})    
});
// test('should return 200 status code');