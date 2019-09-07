const urlBase = '192.168.0.106'
const port = 5000
const url = `http://${urlBase}:${port}/api/products/imgs`
const productsList = [
  {
    name: 'Camiseta Stylish',
    price: 25.00,
    oldPrice: 35,
    category: 'camisetas',
    images: [
      nameToImageUrl('Camiseta Stylish'),
      nameToImageUrl('Calça Masculina Preta'),
      nameToImageUrl('Calça Masculina Preta'),
      nameToImageUrl('Camiseta Stylish'),
      nameToImageUrl('Camiseta Stylish'),
      nameToImageUrl('Calça Masculina Preta'),
      nameToImageUrl('Calça Masculina Preta'),
      ],
    description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
  },
  {
    name: 'Calça Masculina Preta',
    price: 64.00,
	category: 'calças',
    description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
    isFavorited: true,
  },
  {
    name: 'Casaco Italy',
    price: 55.99,
	category: 'casatos',
    description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.',
  },
  {
    name: 'Bone Fe',
    price: 20.99,
	category: 'acessorios',
    description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.',
    isFavorited: true,
  },
  {
    name: 'Colar Onyx',
	  category: 'acessorios',
    price: 10.00,
    description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.',
  },
].map(e=>
  ({...e, 
      image: nameToImageUrl(e.name),
      images: e.images || [
        nameToImageUrl(e.name),
        nameToImageUrl(e.name),
        nameToImageUrl(e.name),
        nameToImageUrl(e.name)
        ]
    }
  ))
module.exports = productsList


function nameToImageUrl(name){
  return `${url}/${name.replace( /\s/g, '_')}.jpg`
}