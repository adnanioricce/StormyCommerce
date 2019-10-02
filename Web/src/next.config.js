const withSass = require('@zeit/next-sass');
const withImages = require('next-images');
const withTypescript = require('@zeit/next-typescript');
module.exports = withSass(
  withImages({
    useFileSystemPublicRoutes: false
  }),
  withTypescript()
);
