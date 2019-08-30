import axios from 'axios';

const baseURL = '192.168.0.106';
const port = 5000;
const api = axios.create({
  baseURL: `http://${baseURL}:${port}/api/`,
  headers: {
    Authorization:
      'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMCIsImVtYWlsIjoiYWRtaW5Ac2ltcGxjb21tZXJjZS5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsIm5iZiI6MTU2Njc1NDUxNiwiZXhwIjoxNTY2NzU2MzE2LCJpc3MiOiJTaW1wbENvbW1lcmNlIiwiYXVkIjoiQW55b25lIn0.QSQ0fDOyZIDGDoVxdmjn_yEsk32FjRTgPKTXfR1rXq4'
  }
});

export default api;
