import * as React from 'react';
export default ({label, border=true})=>{
  
  return(
    <div className='header' style={{border: border===false ? 'none': 'solid 1px black'}}>
      <p>{label}</p>
    </div>
  )
}