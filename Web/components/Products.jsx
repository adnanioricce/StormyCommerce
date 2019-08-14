import * as React from 'react';
import favoriteSVG from '../static/assets/icons/favorite.svg'
import Header from './Header';
export default ()=>{
  const [products, setProducts] = React.useState([])
  React.useEffect(()=>{
    fetch('http://localhost:5000/api/products')
    .then(response=>response.json())
    .then(res=>setProducts(res))
  }, [])
  return (
    <>
      <Header label='Destaques'/>
      <div className='products-container'>
        {products.map(product)}
      </div>
    </>
  )
}
const product=( product, index)=>{
  // const [image, setImage] = React.useState('');
  // React.useEffect(()=>{
  //   fetch(product.image).then(
  //     res=>console.log(res)
  //   )
  // }, [])
  return(
    <div className="product" key={index}>
      <img className='image' src={product.image}/> 
      <img className='favorite' src={favoriteSVG}/>
      <div className="info">
        <p className='title'>{product.name}</p>
        <p className="price">{`R$ ${product.price.toFixed(2)}`}</p>
      </div>
      
    </div>
  )
}