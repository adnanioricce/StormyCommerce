import axios from 'axios';

const baseURL = '192.168.0.111';
const port = 5000;
const api = axios.create({
  baseURL: `http://${baseURL}:${port}/api/`,
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json'
  }
});

export default api;
