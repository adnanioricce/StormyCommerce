function cleanEntry(obj) {
  return JSON.stringify(obj).replace(/"/g, '\\"');
}
function cleanArray(arr) {
  return `{"${arr.map(e => cleanEntry(e)).join('", "')}"}`;
}

module.exports = {
  up: queryInterface => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      
    */
    return queryInterface.bulkInsert(
      "products",
      [
        {
          id: 6,
          name: "Camiseta Stylish",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
          price: "9.99",
          old_price: null,
          image:
            "http://localhost:5000/api/files/products/Camiseta_Stylish.jpg",
          photos: [
            "http://localhost:5000/api/files/products/Camiseta_Stylish.jpg",
            "http://localhost:5000/api/files/products/Camiseta_Stylish.jpg",
            "http://localhost:5000/api/files/products/Camiseta_Stylish.jpg",
          ],
          tags: ["camisa", "camiseta", "stylish"],
          colors: cleanArray([
            {
              value: "black",
              color: "#000000",
            },
            {
              value: "white",
              color: "#ffffff",
            },
            {
              value: "grey",
              color: "gray",
            },
          ]),
          sizes: ["P", "M", "G", "GG"],
          created_at: new Date(),
          updated_at: new Date(),
        },
        {
          id: 7,
          name: "Calça Masculina Preta",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
          price: "63.99",
          old_price: "70.00",
          image:
            "http://localhost:5000/api/files/products/Calça_Masculina_Preta.jpg",
          photos: [
            "http://localhost:5000/api/files/products/Calça_Masculina_Preta.jpg",
            "http://localhost:5000/api/files/products/Calça_Masculina_Preta.jpg",
          ],
          tags: ["calça", "masculina", "preta"],
          colors: cleanArray([
            {
              value: "black",
              color: "#000000",
            },
            {
              value: "purple",
              color: "purple",
            },
            {
              value: "grey",
              color: "grey",
            },
          ]),
          sizes: ["P", "M", "G", "GG"],
          created_at: new Date(),
          updated_at: new Date(),
        },
        {
          id: 10,
          name: "Casaco Italy",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
          price: "55.99",
          old_price: null,
          image: "http://localhost:5000/api/files/products/Casaco_Italy.jpg",
          photos: [
            "http://localhost:5000/api/files/products/Casaco_Italy.jpg",
            "http://localhost:5000/api/files/products/Casaco_Italy.jpg",
          ],
          tags: ["calça", "masculina", "preta"],
          colors: cleanArray([
            {
              value: "black",
              color: "#000000",
            },
            {
              value: "purple",
              color: "purple",
            },
            {
              value: "red",
              color: "red",
            },
          ]),
          sizes: ["P", "M", "G", "GG"],
          created_at: new Date(),
          updated_at: new Date(),
        },
        {
          id: 11,
          name: "Bone Fe",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
          price: "55.99",
          old_price: "60.00",
          image: "http://localhost:5000/api/files/products/Bone_Fe.jpg",
          photos: [
            "http://localhost:5000/api/files/products/Bone_Fe.jpg",
            "http://localhost:5000/api/files/products/Bone_Fe.jpg",
          ],
          tags: ["bone", "fe"],
          colors: cleanArray([
            {
              value: "black",
              color: "#000000",
            },
            {
              value: "yellow",
              color: "yellow",
            },
            {
              value: "purple",
              color: "purple",
            },
          ]),
          sizes: ["P", "M", "G", "GG"],
          created_at: new Date(),
          updated_at: new Date(),
        },
        {
          id: 12,
          name: "Colar Onyx",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare lectus mauris, eget vulputate lorem faucibus nec. Nulla facilisi. Duis sollicitudin efficitur consequat. Donec mattis ullamcorper nulla, sagittis condimentum purus. Vivamus sed aliquet ligula, at luctus tellus. Duis laoreet magna vitae ligula vulputate, vitae euismod dui viverra. Aliquam erat volutpat.",
          price: "14.99",
          old_price: null,
          image: "http://localhost:5000/api/files/products/Colar_Onyx.jpg",
          photos: [
            "http://localhost:5000/api/files/products/Colar_Onyx.jpg",
            "http://localhost:5000/api/files/products/Colar_Onyx.jpg",
          ],
          tags: ["colar", "onyx"],
          colors: cleanArray([
            {
              value: "black",
              color: "#000000",
            },
            {
              value: "white",
              color: "white",
            },
            {
              value: "orange",
              color: "orange",
            },
          ]),
          sizes: ["14", "12", "11"],
          created_at: new Date(),
          updated_at: new Date(),
        },
      ],
      {}
    );
  },

  down: queryInterface => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      
    */
    return queryInterface.bulkDelete("products", null, {});
  },
};
