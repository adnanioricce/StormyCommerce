import * as React from 'react';
import { useDispatch } from 'react-redux';
import Button from './Button';
import actions from '../actions';

export default () => {
  const dispatch = useDispatch();
  function handleExit() {
    dispatch(actions.disconnect());
  }
  return (
    <div className="acess-menu" style={{ margin: '50px auto' }}>
      <AcessButton label="Dados Pessoais" />
      <AcessButton label="Endereços" />
      <AcessButton label="Pedidos" />
      <AcessButton
        label="Sair"
        className="button google"
        onClick={handleExit}
      />
    </div>
  );
};
const AcessButton = ({ ...props }) => (
  <Button styleType="secondary" style={{ margin: '10px auto' }} {...props} />
);
