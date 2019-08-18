import * as React from 'react';
import favoriteSVG from '../static/assets/icons/favorite.svg';
import Header from './Header';
import favoritedSVG from '../static/assets/icons/favorited.svg';
import {useRouter} from 'next/router';
import Link from 'next/link'
export default ()=>{
  const [products, setProducts] = React.useState([])
  const route = useRouter()
  React.useEffect(()=>{
    fetch('http://localhost:5000/api/products')
    .then(response=>response.json())
    .then(res=>setProducts(res))
  }, [])
  return (
    <>
      <Header label='Destaques'/>
      <div className='products-container'>
        {products.map((...params)=>product(...params, route))}
      </div>
    </>
  )
}
const product=( product, index, algo, route )=>{
  const {isFavorited} = product
  // const [image, setImage] = React.useState('');
  // React.useEffect(()=>{
  //   fetch(product.image).then(
  //     res=>console.log(res)
  //   )
  // }, [])
  function handleProductClick(){
    console.log(route)
    route.query={productID: index}
    route.push('/product')
  }
  return(
    <Link href={`/product?id=${index}`}>
      <div onClick={handleProductClick} className="product" key={index}>
        <img className='image' src={product.image}/> 
        <img className='favorite' src={favoriteSVG}/>
        <img className={isFavorited?'favorited active':'favorited'} src={favoritedSVG}/>
        <div className="info">
          <p className='title'>{product.name}</p>
          <p className="price">{`R$ ${product.price.toFixed(2)}`}</p>
        </div>
        
      </div>
    </Link>
  )
}