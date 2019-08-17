import React from 'react'
import Page from '../components/Page'
import Nav from '../components/Nav';
import Footer from '../components/Footer';
import Header from '../components/Header';
import emailSVG from '../static/assets/icons/email.svg'
import smartphoneSVG from '../static/assets/icons/smartphone.svg';
function contato() {
  return (
    <Page>
      <Header label='Contato' border={false}/>
      <ContactCardsContainer>
        <ContactCard icon={emailSVG} title='Email' label='contato@witthoeft.com'/>
        <ContactCard icon={smartphoneSVG} title='Celular' label='+55 (11) 99045-7843'/>
      </ContactCardsContainer>
      
      <Nav/>
      <Footer style={{position: 'absolute', bottom: 0}}/>
    </Page>
  )
}

export default contato

const ContactCard = ({icon, title, label})=>(
  <div className="contact-card">
    <img src={icon} alt={`${title} icon`} className="icon"/>
    <div className="info-container">
      <p className="title">{title}</p>
      <p className="label">{label}</p>
    </div>
  </div>
)
const ContactCardsContainer = ({children})=>(
  <div className='contact-cards-container'>
    {children}
  </div>
  )