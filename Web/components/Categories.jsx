import * as React from 'react';
import categories from '../static/consts/categories'
import Header from './Header';
import {useRouter} from 'next/router';
export default ()=>{
  return (
    <>
      <Header label='Categorias'/>
      <div className="categories-card-container">
        {categories.map(categoryCard)}
      </div>
      
    </>
  )
  
}
const categoryCard = (category, index)=>{
  const Router = useRouter();
  function handleCategoryClick(){
    Router.push('/'+category.link)
  }
  return (
    <div className="category-card" key={index} onClick={handleCategoryClick}>
      <img src={category.photo} alt={category.label} className="photo"/>
      <p className="label">{category.label}</p>
    </div>
  )
}