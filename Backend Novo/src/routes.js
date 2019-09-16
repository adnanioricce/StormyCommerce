import express, { Router } from "express";
import UserController from "./app/controllers/UserController";
import SessionController from "./app/controllers/SessionController";
import auth from "./app/middlewares/auth";
import ProductController from "./app/controllers/ProductController";

const routes = new Router();
routes.all("*", function(req, res, next) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Methods", "PUT, GET, POST, DELETE, OPTIONS");
  res.header("Access-Control-Allow-Headers", "Content-Type");
  res.header("Access-Control-Allow-Credentials", "true");
  next();
});
routes.post("/products", ProductController.store);
routes.get("/products", ProductController.list);
routes.get("/products/:id", ProductController.listOne);
routes.get("/products/one/:name", ProductController.listName);
routes.post("/users", UserController.store);
routes.post("/sessions", SessionController.store);
routes.use("/files", express.static(`${__dirname}/files`));
routes.use(auth);
routes.get("/users", UserController.index);
routes.put("/users", UserController.update);

export default routes;
