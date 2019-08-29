webpackHotUpdate("static\\development\\pages\\product.js",{

/***/ "./pages/product.jsx":
/*!***************************!*\
  !*** ./pages/product.jsx ***!
  \***************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! next/router */ "./node_modules/next/dist/client/router.js");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _components_Nav__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../components/Nav */ "./components/Nav.jsx");
/* harmony import */ var _components_Page__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../components/Page */ "./components/Page.jsx");
/* harmony import */ var _services_api__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../services/api */ "./services/api.js");
/* harmony import */ var _components_Footer__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../components/Footer */ "./components/Footer.jsx");
/* harmony import */ var _components_Breadcumb__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../components/Breadcumb */ "./components/Breadcumb.jsx");
/* harmony import */ var _components_FavoriteFloater__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../components/FavoriteFloater */ "./components/FavoriteFloater.jsx");
/* harmony import */ var _components_TitleWithFloater__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ../components/TitleWithFloater */ "./components/TitleWithFloater.jsx");
/* harmony import */ var _components_Title__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ../components/Title */ "./components/Title.jsx");
/* harmony import */ var _components_Description__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ../components/Description */ "./components/Description.jsx");
/* harmony import */ var _components_Button__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ../components/Button */ "./components/Button.jsx");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\pages\\product.jsx";













function product() {
  var _useRouter = Object(next_router__WEBPACK_IMPORTED_MODULE_2__["useRouter"])(),
      query = _useRouter.query;

  var productID = query.id;

  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(true),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      isLoading = _React$useState2[0],
      setIsLoading = _React$useState2[1];

  var _React$useState3 = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(null),
      _React$useState4 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState3, 2),
      currentProduct = _React$useState4[0],
      setCurrentProduct = _React$useState4[1];

  react__WEBPACK_IMPORTED_MODULE_1___default.a.useEffect(function () {
    _services_api__WEBPACK_IMPORTED_MODULE_5__["default"].get("products").then(function (_ref) {
      var products = _ref.data;
      console.log(products);
      setCurrentProduct(products[productID]);
      console.log(products[productID]);
      setIsLoading(false);
    });
  }, [productID]);
  console.log(currentProduct);
  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Page__WEBPACK_IMPORTED_MODULE_4__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 29
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Nav__WEBPACK_IMPORTED_MODULE_3__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 30
    },
    __self: this
  }), isLoading === false && currentProduct && react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-page-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 33
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Breadcumb__WEBPACK_IMPORTED_MODULE_7__["default"], {
    paths: [currentProduct.category, currentProduct.name],
    __source: {
      fileName: _jsxFileName,
      lineNumber: 34
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_TitleWithFloater__WEBPACK_IMPORTED_MODULE_9__["default"], {
    label: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 35
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_FavoriteFloater__WEBPACK_IMPORTED_MODULE_8__["default"], {
    style: {
      top: 0,
      left: '10%'
    },
    isFavorited: currentProduct.isFavorited,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 36
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-display-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 41
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("img", {
    className: "image",
    src: currentProduct.image,
    alt: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 42
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(ProductOptionsController, {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 47
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Description__WEBPACK_IMPORTED_MODULE_11__["default"], {
    text: currentProduct.description,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 50
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Button__WEBPACK_IMPORTED_MODULE_12__["default"], {
    label: "Adicionar ao carrinho",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 51
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Footer__WEBPACK_IMPORTED_MODULE_6__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 54
    },
    __self: this
  }));
}

/* harmony default export */ __webpack_exports__["default"] = (product);

/***/ })

})
//# sourceMappingURL=product.js.c1f6f6c65ce12ae8ec32.hot-update.js.map