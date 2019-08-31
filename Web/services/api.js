import axios from 'axios';

const baseURL = '192.168.0.106';
const port = 5000;
const api = axios.create({
  baseURL: `http://${baseURL}:${port}/api/`
});

export default api;
