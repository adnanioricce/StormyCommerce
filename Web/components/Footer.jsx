import React from 'react'
import PaymentsSVG from '../static/assets/icons/payments.svg'
function Footer({style}) {
  return (
    <footer style={style}>
      <p className="main-content">
        © 2019 Wittoeft LTDA - CNPJ: 18.391.981/0001-00 - Todos os 
        direitos reservados.
        Em caso de divergência de preços no site, o valor válido é o do Carrinho de Compras.
        Preços e condições de pagamento podem variar de acordo com a disponibilidade dos produtos.
      </p>
      <div className="payment-methods">
        <p>Métodos de Pagamento:</p>
        <img src={PaymentsSVG} alt="Métodos de Pagamento"/>
      </div>
    </footer>
  )
}

export default Footer
