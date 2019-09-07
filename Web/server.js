const { createServer } = require('http');
const remotedev = require('remotedev-server');
const next = require('next');
const routes = require('./routes');

if (process.env.NODE_ENV !== 'production') {
  remotedev({ hostname: 'localhost', port: 3333 });
}

const app = next({ dev: process.env.NODE_ENV !== 'production' });
const handler = routes.getRequestHandler(app);

app.prepare().then(() => {
  createServer(handler).listen(3000);
});
