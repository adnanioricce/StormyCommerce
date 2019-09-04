import * as React from 'react';

export default React.forwardRef((props, ref) => {
  return (
    <props.tag
      role="button"
      tabIndex={0}
      onKeyPress={e => e.key === 'Enter' && props.onClick && props.onClick(e)}
      ref={ref}
      {...props}
    />
  );
});
