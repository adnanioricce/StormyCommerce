import * as React from 'react';
import userSVG from '../static/assets/icons/user.svg';

export default () => {
  return (
    <div className="user-avatar">
      <img className="user-icon" src={userSVG} alt="Usuario" />
    </div>
  );
};
