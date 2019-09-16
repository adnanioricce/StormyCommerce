module.exports = {
  up: queryInterface => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      return queryInterface.bulkInsert('People', [{
        name: 'John Doe',
        isBetaMember: false
      }], {});
    */
    return queryInterface.bulkInsert("users", [
      {
        name: "danilex",
        email: "danilex@stormy.com",
        password_hash:
          "$2b$08$sHSeZPX0M9LASHAwjBtvAOKBfMzZqBScJ0ZU2v5bLkIKNcvx4f0K2",
        cpf: "111.111.111-11",
        phone: "(11) 99025-6442",
        gender: "m",
        birth: "2002-01-14",
        favorited_products: null,
        created_at: new Date(),
        updated_at: new Date(),
      },
    ]);
  },

  down: queryInterface => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      
    */
    return queryInterface.bulkDelete("users", null, {});
  },
};
