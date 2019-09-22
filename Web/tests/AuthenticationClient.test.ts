import { SignInVm } from "../models/identity/SignInVm";
import { AuthenticationClient } from "../services/AuthenticationClient";
// import Axios from "axios";
const fs = require('fs');
// const axios = require('axios');
// const https = require('https');
require('https').globalAgent.options = {
    pfx:fs.readFileSync(process.env.APPDATA + '\\ASP.NET\\Https\\SimplCommerce.WebHost.pfx'),
    passphrase:"simpldevpassword"
};
// const agent = new https.Agent({
//     ca:fs.readFileSync('%APPDATA%/ASP.NET/Https/SimplCommerce.WebHost.pfx')
// })
// import * as test from 'babel-jest';
// describe()
describe('should return token when send SignInVm for user with existing credentials',() => {it('login',async () => {    
    const model = new SignInVm({email:"stormycommerce@gmail.com",password:'!D4vpassword'});
    const client = new AuthenticationClient("https://localhost");
    const response = await client.login(model);
    expect(response).toBe('');
})    
});
// test('should return 200 status code');