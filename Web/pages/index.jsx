import * as React from 'react';
import '../static/styles/main.scss'
import Nav from '../components/Nav';
import Slide from '../components/Slide'
import Products from '../components/Products';
import Categories from '../components/Categories';
export default ()=>(
  <div>
    <Nav/>
    <Slide/>
    <Products/>
    <Categories/>
  </div>
)
