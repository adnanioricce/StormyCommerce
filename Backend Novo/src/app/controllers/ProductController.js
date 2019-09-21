import * as yup from "yup";
import Sequelize from "sequelize";
import Product from "../models/Product";

class ProductController {
  async store(req, res) {
    const schema = yup.object().shape({
      name: yup.string().required(),
      description: yup.string().required(),
      price: yup
        .number()
        .positive()
        .required(),
      old_price: yup.number().positive(),
      image: yup
        .string()
        .matches(
          /^(?:([a-z0-9+.-]+):\/\/)(?:\S+(?::\S*)?@)?(?:(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)*\.?)(?::\d{2,5})?(?:[/?#]\S*)?$/
        )
        .required(),
      photos: yup
        .array()
        .of(
          yup
            .string()
            .matches(
              /^(?:([a-z0-9+.-]+):\/\/)(?:\S+(?::\S*)?@)?(?:(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)*\.?)(?::\d{2,5})?(?:[/?#]\S*)?$/
            )
        )
        .required(),
      tags: yup
        .array()
        .of(yup.string())
        .required(),
      colors: yup
        .array()
        .of(
          yup.object({
            value: yup.string(),
            color: yup.string(),
          })
        )
        .required(),
      sizes: yup
        .array()
        .of(yup.string())
        .required(),
	  category: yup.string().required(),
      comments: yup.array().of(
        yup.object({
          userId: yup.number(),
          comment: yup.string(),
        })
      ),
    });
    try {
      await schema.validate(req.body);
    } catch (err) {
      return res.status(400).json(err.errors);
    }
    const productExists = await Product.findOne({
      where: { name: req.body.name },
    });
    if (productExists) {
      return res.status(400).json({ error: "that product already exists" });
    }
    const {
      name,
      description,
      price,
      // eslint-disable-next-line camelcase
      old_price,
      image,
      photos,
      colors,
      sizes,
    } = await Product.create(req.body);
    return res.json({
      name,
      description,
      price,
      old_price,
      image,
      photos,
      colors,
      sizes,
    });
  }

  async update(req, res) {
    const schema = yup.object().shape({
      name: yup.string().required(),
      description: yup.string(),
      price: yup.number().positive(),
      old_price: yup.number().positive(),
	  category: yup.string(),
      image: yup
        .string()
        .matches(
          /^(?:([a-z0-9+.-]+):\/\/)(?:\S+(?::\S*)?@)?(?:(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)*\.?)(?::\d{2,5})?(?:[/?#]\S*)?$/
        ),
      photos: yup
        .array()
        .of(
          yup
            .string()
            .matches(
              /^(?:([a-z0-9+.-]+):\/\/)(?:\S+(?::\S*)?@)?(?:(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)*\.?)(?::\d{2,5})?(?:[/?#]\S*)?$/
            )
        ),
      tags: yup.array().of(yup.string()),
      colors: yup.array().of(
        yup.object({
          value: yup.string(),
          color: yup.string(),
        })
      ),
      sizes: yup.array().of(yup.string()),
      comments: yup.array().of(
        yup.object({
          userId: yup.number(),
          comment: yup.string(),
        })
      ),
    });
    try {
      await schema.validate(req.body);
    } catch (err) {
      return res.status(400).json(err.errors);
    }

    const product = await Product.update(req.body);
    return res.json(product);
  }

  async list(req, res) {
    if (req.query.search) {
      const { search } = req.query;
      const [firstLetter, rest] = search;
      const term =
        search.length > 1
          ? firstLetter.toUpperCase() + rest
          : firstLetter.toUpperCase();
      const products = await Product.findAll({
        attributes: ["id", "name"],
        where: {
          name: { [Sequelize.Op.like]: `%${term}%` },
        },
      });
      return res.json(products);
    }
    const products = await Product.findAll();
    return res.json(products);
  }

  async listOne(req, res) {
    if (!req.params.id) {
      return res.status(400).json({ error: "no id informed" });
    }
    const product = await Product.findByPk(req.params.id);
    return res.json(product);
  }

  async listName(req, res) {
    if (!req.params.name) {
      return res.status(400).json({ error: "no id informed" });
    }
    const product = await Product.findOne({
      attributes: { exclude: ["created_at", "updated_at"] },
      where: { name: req.params.name },
    });
    return res.json(product);
  }
}
export default new ProductController();
