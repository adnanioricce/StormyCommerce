export default hasUser => {
  if (hasUser) {
    return [
      {
        label: 'Perfil',
        prefix: 'user',
        subItems: [
          { label: 'Informações', link: '' },
          { label: 'Sair', link: 'leave' }
        ]
      },
      {
        label: 'Produtos',
        prefix: 'products',
        subItems: [
          { label: 'Ver todos', link: 'all' },
          { label: 'Camisetas' },
          { label: 'Bermudas' },
          { label: 'Casacos' },
          { label: 'Acessorios' }
        ]
      },
      {
        label: 'Contato',
        link: 'contact'
      }
    ];
  }
  return [
    {
      label: 'Entrar',
      link: 'login'
    },
    {
      label: 'Produtos',
      prefix: 'products',
      subItems: [
        { label: 'Ver todos', link: 'all' },
        { label: 'Camisetas' },
        { label: 'Bermudas' },
        { label: 'Casacos' },
        { label: 'Acessorios' }
      ]
    },
    {
      label: 'Contato',
      link: 'contact'
    }
  ];
};
