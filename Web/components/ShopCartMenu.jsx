import * as React from 'react'
export default ({isActive})=>{

  return (
    <div className='menu' style={{ left: 'unset', right: 0, transform: `translateX(${isActive? 0: 100}%)` }}>
    
    </div>
  )
}