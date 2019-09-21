import React from 'react';
import Page from '../components/Page';
import emailSVG from '../static/assets/icons/email.svg';
import smartphoneSVG from '../static/assets/icons/smartphone.svg';
import Title from '../components/Title';

function contato() {
  return (
    <Page>
      <Title label="Contato" style={{ margin: '15px 0' }} />
      <ContactCardsContainer>
        <ContactCard
          icon={emailSVG}
          title="Email"
          label="contato@witthoeft.com"
        />
        <ContactCard
          icon={smartphoneSVG}
          title="Celular"
          label="+55 (11) 99045-7843"
        />
      </ContactCardsContainer>
    </Page>
  );
}
export default contato;
const ContactCard = ({ icon, title, label }) => (
  <div className="contact-card">
    <img src={icon} alt={`${title} icon`} className="icon" />
    <div className="info-container">
      <p className="title">{title}</p>
      <p className="label">{label}</p>
    </div>
  </div>
);
const ContactCardsContainer = ({ children }) => (
  <div className="contact-cards-container">{children}</div>
);
