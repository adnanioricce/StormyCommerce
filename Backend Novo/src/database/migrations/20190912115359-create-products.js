module.exports = {
  up: (queryInterface, Sequelize) => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      
    */
    return queryInterface.createTable("products", {
      id: {
        type: Sequelize.INTEGER,
        allowNull: false,
        autoIncrement: true,
        primaryKey: true,
      },
      name: {
        type: Sequelize.STRING,
        allowNull: false,
      },
      description: {
        type: Sequelize.STRING(1000),
        allowNull: false,
      },
      price: {
        type: Sequelize.DECIMAL(10, 2),
        allowNull: false,
      },
      old_price: {
        type: Sequelize.DECIMAL(10, 2),
      },
      image: {
        type: Sequelize.STRING,
        allowNull: false,
      },
      photos: {
        type: Sequelize.ARRAY(Sequelize.STRING),
        allowNull: false,
      },
      tags: {
        type: Sequelize.ARRAY(Sequelize.STRING),
        allowNull: false,
      },
      colors: {
        type: Sequelize.ARRAY(Sequelize.JSON),
        allowNull: false,
      },
      sizes: {
        type: Sequelize.ARRAY(Sequelize.STRING),
        allowNull: false,
      },
      category: {
        type: Sequelize.STRING,
        allowNull: false,
      },
      // comments: {
      //   type: Sequelize.ARRAY(Sequelize.JSONTYPE),
      // },
      created_at: {
        allowNull: false,
        type: Sequelize.DATE,
      },
      updated_at: {
        allowNull: false,
        type: Sequelize.DATE,
      },
    });
  },

  down: queryInterface => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      
    */
    return queryInterface.dropTable("products");
  },
};
