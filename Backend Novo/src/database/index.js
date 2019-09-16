import Sequelize from "sequelize";
import databaseConfig from "../config/database";
import Product from "../app/models/Product";
import User from "../app/models/User";

const models = [Product, User];
class Database {
  constructor() {
    this.init();
  }

  init() {
    this.connection = new Sequelize(databaseConfig);
    models.map(model => model.init(this.connection));
  }
}

export default new Database();
