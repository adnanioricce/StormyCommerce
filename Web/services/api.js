import axios from 'axios';

const baseURL = 'localhost';
const port = 5000;
const api = axios.create({
  baseURL: `http://${baseURL}:${port}/api/`,
  withCredentials: true,
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json'
  }
});

export default api;
