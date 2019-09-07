const express = require('express')
const router = express.Router()
const productsList = require('./productsList')
router.use('/imgs', express.static(__dirname + '/imgs'))

router.get('/', (res, req)=>{
  // res.rs.setHeader('Access-Control-Allow-Origin', 'http://localhost:3000');
  res.res.json(productsList)})
module.exports = router;