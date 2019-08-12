import * as React from 'react';
import '../static/styles/main.scss'
import Nav from '../components/Nav';
import Slide from '../components/Slide'
import Header from '../components/Header';
import Products from '../components/Products';
export default ()=>(
  <div>
    <Nav/>
    <Slide/>
    <Header label='Destaques'/>
    <Products/>
  </div>
)
