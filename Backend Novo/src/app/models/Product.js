import Sequelize, { Model } from "sequelize";

class Product extends Model {
  static init(sequelize) {
    super.init(
      {
        name: Sequelize.STRING,
        description: Sequelize.STRING,
        price: Sequelize.DECIMAL(10, 2),
        old_price: Sequelize.DECIMAL(10, 2),
        image: Sequelize.STRING,
        photos: Sequelize.ARRAY(Sequelize.STRING),
        tags: Sequelize.ARRAY(Sequelize.STRING),
        colors: Sequelize.ARRAY(Sequelize.JSON),
        sizes: Sequelize.ARRAY(Sequelize.STRING),
      },
      {
        sequelize,
      }
    );
  }
}

export default Product;
