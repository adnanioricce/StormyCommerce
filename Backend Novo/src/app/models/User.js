import Sequelize, { Model } from "sequelize";
import bcrypt from "bcrypt";

class User extends Model {
  static init(sequelize) {
    super.init(
      {
        name: Sequelize.STRING,
        email: Sequelize.STRING,
        password: Sequelize.VIRTUAL,
        password_hash: Sequelize.STRING,
        cpf: Sequelize.STRING,
        phone: Sequelize.STRING,
        gender: Sequelize.CHAR(1),
        birth: Sequelize.DATE(),
        adresses: Sequelize.ARRAY(Sequelize.JSONB),
        favorited_products: Sequelize.ARRAY(Sequelize.INTEGER),
        cart_products: Sequelize.JSONB,
      },
      {
        sequelize,
      }
    );
    this.addHook("beforeSave", async user => {
      if (user.password) {
        user.password_hash = await bcrypt.hash(user.password, 8);
      }
    });
  }

  checkPassword(password) {
    return bcrypt.compare(password, this.password_hash);
  }
}

export default User;
