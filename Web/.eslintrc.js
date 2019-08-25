module.exports = {
  env: {
    browser: true,
    es6: true,
  },
  extends: [
    'airbnb',
    'prettier'
  ],
  globals: {
    Atomics: 'readonly',
    SharedArrayBuffer: 'readonly',
  },
  parserOptions: {
    ecmaFeatures: {
      jsx: true,
    },
    ecmaVersion: 2018,
    sourceType: 'module',
  },
  plugins: [
    'react',
    'prettier'
  ],
  rules: {
    'prettier/prettier': 'error',
    'linebreak-style': 0,
    'no-console': 0,
    'react/prop-types': 0,
    "react/jsx-props-no-spreading": 0,
    "no-param-reassign": 0,
    'no-noninteractive-element-to-interactive-role': [0],
    'react/no-array-index-key': 0
  },
};
