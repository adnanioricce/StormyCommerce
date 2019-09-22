import ProductClient from '../services/productClient';
import axios from 'axios';
// Eu vou exigir https em produção,então prefira usar o mesmo quando estiver desenvolvendo.
const ipAddress = 'localhost';
//80 para http
process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = 0
const port = '443';
const baseURL = `https://${ipAddress}:${port}`;
// const port = 5000;
const client = axios.create();
const apiClient = new ProductClient(baseURL,client)
export default apiClient;
