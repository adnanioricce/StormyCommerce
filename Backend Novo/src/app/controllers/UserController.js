import * as yup from "yup";
import User from "../models/User";

class UserController {
  async store(req, res) {
    const schema = yup.object().shape({
      name: yup.string().required(),
      email: yup
        .string()
        .email()
        .required(),
      cpf: yup
        .string()
        .matches(/^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}-?[0-9]{2}$/)
        .required(),
      phone: yup
        .string()
        .matches(/\(\d{2,}\) \d{4,}\-\d{4}/)
        .required(),
      gender: yup
        .string()
        .oneOf(["m", "f"])
        .required(),
      birth: yup.date().required(),
      adresses: yup.array().of(
        yup.object().shape({
          street: yup.string(),
          number: yup.number(),
          type: yup.string().oneOf(["house", "building"]),
        })
      ),
      favorited_products: yup.array().of(yup.number().min(1)),
    });
    try {
      await schema.validate(req.body);
    } catch (err) {
      return res.status(400).json(err.errors);
    }

    const userExists = await User.findOne({ where: { email: req.body.email } });
    if (userExists) {
      return res.status(400).json({
        error: `That user already exists`,
      });
    }
    const {
      name,
      email,
      cpf,
      phone,
      gender,
      birth,
      andresses,
      // eslint-disable-next-line camelcase
      favorited_products,
    } = await User.create(req.body);
    return res.json({
      name,
      email,
      cpf,
      phone,
      gender,
      birth,
      andresses,
      favorited_products,
    });
  }

  async update(req, res) {
    const schema = yup.object().shape({
      name: yup.string(),
      email: yup.string().email(),
      oldPassword: yup.string().min(6),
      password: yup
        .string()
        .min(6)
        .when("oldPassword", (oldPassword, field) =>
          oldPassword ? field.required() : field
        ),
      cpf: yup.string().matches(/[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}-?[0-9]{2}/),
      phone: yup.string().matches(/\(\d{2,}\) \d{4,}\-\d{4}/),
      gender: yup.string().oneOf(["m", "f"]),
      adresses: yup.array().of(
        yup.object().shape({
          street: yup.string(),
          number: yup.number(),
          type: yup.string().oneOf(["house", "building"]),
        })
      ),
      birth: yup.date(),
      favorited_products: yup.array().of(yup.number().min(1)),
    });

    try {
      await schema.validate(req.body);
    } catch (err) {
      return res.status(400).json(err.erros);
    }

    const { email, oldPassword } = req.body;
    const user = await User.findByPk(req.userId);
    if (email !== user.email) {
      const userExists = await User.findOne({
        where: { email },
      });
      if (userExists) {
        return res.status(400).json({
          error: `That user already exists`,
        });
      }
    }

    if (oldPassword && !(await user.checkPassword(oldPassword))) {
      return res.status(401).json({ error: "password doesn't match" });
    }

    const {
      name,
      cpf,
      phone,
      gender,
      birth,
      andresses,
      // eslint-disable-next-line camelcase
      favorited_products,
    } = await user.update(req.body);

    return res.json({
      name,
      email,
      cpf,
      phone,
      gender,
      birth,
      andresses,
      // eslint-disable-next-line camelcase
      favorited_products,
    });
  }

  async index(req, res) {
    const { userId } = req;
    const user = User.findByPk(userId, {
      attributes: { exclude: ["created_at", "updated_at"] },
    });
    return res.json(user);
  }
}
export default new UserController();
