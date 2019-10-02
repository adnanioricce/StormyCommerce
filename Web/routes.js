const routes = require('next-routes');

module.exports = routes()
  .add('/', 'index')
  .add('/produtos/:name', 'product')
  .add('/login', 'login')
  .add('/contato', 'contato')
  .add('/cadastrar','cadastro');
