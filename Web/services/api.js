import { Client } from "./stormyClient";
import axios from 'axios';
// Eu vou exigir https em produção,então prefira usar o mesmo quando estiver desenvolvendo.
const ipAddress = '172.17.0.2';
//80 para http
const port = '443';
const baseURL = `https://${ipAddress}:${port}`;
// const port = 5000;
const api = axios.create({
  baseURL: baseURL,  
});
export default api;