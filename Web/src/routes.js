const routes = require('next-routes');

module.exports = routes()
  .add('/', 'index')
  .add('/products/all', 'allProducts')
  .add('/products/:name', 'product')
  .add('/login', 'login')
  .add('/contact', 'contato')
  .add('/user', 'user')
  .add('/user/leave', 'leaveUser');
