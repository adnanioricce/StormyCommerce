webpackHotUpdate("static\\development\\pages\\product.js",{

/***/ "./components/ProductOptionsController.jsx":
/*!*************************************************!*\
  !*** ./components/ProductOptionsController.jsx ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _ColorSelector__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./ColorSelector */ "./components/ColorSelector.jsx");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ProductOptionsController.jsx";



function ProductOptionsController() {
  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(null),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      activeColor = _React$useState2[0],
      setActiveColor = _React$useState2[1];

  var getActiveColor = function getActiveColor(color) {
    return setActiveColor(color);
  };

  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-options-controller",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_ColorSelector__WEBPACK_IMPORTED_MODULE_2__["default"], {
    getActiveColor: getActiveColor,
    options: [{
      value: 'red',
      color: 'red'
    }, {
      value: 'yellow',
      color: 'yellow'
    }],
    __source: {
      fileName: _jsxFileName,
      lineNumber: 9
    },
    __self: this
  }));
}

/* harmony default export */ __webpack_exports__["default"] = (ProductOptionsController);

/***/ })

})
//# sourceMappingURL=product.js.332089ff982f1c6905e4.hot-update.js.map