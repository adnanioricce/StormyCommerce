import * as React from 'react'
import {useRouter} from 'next/router';
const itensMenu = [
  {
    label: "Acessar"
  }
  ,
  {
    label: 'Produtos',
    subItems: [
      { label: "Camisetas", prefix: 'produtos' },
      { label: "Bermudas", prefix: 'produtos' },
      { label: "Acessorios", prefix: 'produtos' }
    ]
  },
  {
    label: 'Contato'
  }
]
export default React.forwardRef(({ isActive  }, ref) => {
  const [translateXValue, setTranslateXValue] = React.useState(-100);
  const Router = useRouter();
  React.useEffect(() => {
    if (isActive) {
      setTranslateXValue(0);
    } else {
      setTranslateXValue(-100);
    }
  }, [isActive])
  const itens = itensMenu.map((e, index) => {
    const [ subMenuIsActive, setSubMenuIsActive ] = React.useState(false)
    function handleClick(e){
      if(e.subItems){
        setSubMenuIsActive(!subMenuIsActive);
      }else{
        const {prefix, label} = e
        const link = prefix?`${prefix}/${label.toLowerCase()}`:'/'+label.toLowerCase()

        Router.push(link)
      }
    }
    return (
      <div className="menu-item"  key={index}>
        
        <p className='label' onClick={()=>handleClick(e)}>{e.label}</p>
        {(e.subItems && subMenuIsActive) && (
          <div className='menu-sub-item-container'>
          {
            e.subItems.map((e, index) => {
              return (
                <div className="menu-sub-item" onClick={()=>handleClick(e)} key={index}>
                  <p className='label'>{e.label}</p>
                </div>
              )
            })
          }
          </div>
        )
        }
      </div>
    )
  })
  return (
    <div className='menu' ref={ref} style={{ transform: `translateX(${translateXValue}%)` }}>
      {itens}
    </div>
  )
})