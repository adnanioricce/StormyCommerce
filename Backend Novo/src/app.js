import express from "express";
import bodyParser from "body-parser";
import routes from "./routes";

class App {
  constructor() {
    this.server = express();
    this.middlewares();
    this.routes();
  }

  middlewares() {
    // this.server.use(bodyParser.json());
    this.server.use(express.json());
  }

  routes() {
    this.server.use("/api", routes);
  }
}

export default new App().server;
