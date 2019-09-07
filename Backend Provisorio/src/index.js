const express = require('express');
const port = process.env.PORT || 5000;
const app = express()
const path = require('path');
let allowCrossDomain = function(req, res, next) {
  res.header('Access-Control-Allow-Origin', "*");
  res.header('Access-Control-Allow-Headers', "*");
  next();
}
app.use(allowCrossDomain);
app.use('/api/products', require('./products'));

app.listen(port, ()=>{
  console.log(`Server started on ${port}`)
})