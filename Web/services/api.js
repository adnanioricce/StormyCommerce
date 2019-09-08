import axios from 'axios';
// Eu vou exigir https em produção,então prefira usar o mesmo quando estiver desenvolvendo.
const baseURL = '192.168.0.106';
const port = 5000;
const api = axios.create({
  baseURL: `http://${baseURL}:${port}/api/`
});

export default api;
