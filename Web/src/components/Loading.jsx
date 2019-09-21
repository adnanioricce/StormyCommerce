import * as React from 'react';
import '../static/styles/components/_loading.scss';
import loadingBG from '../static/assets/icons/loading-bg.svg';
import icon from '../static/assets/icons/loading-brand-logo.svg';

export default () => {
  return (
    <div className="loading">
      <img className="loading-bg" src={loadingBG} alt="loading-background" />
      <img className="loading-icon" src={icon} alt="loading-icon" />
    </div>
  );
};
