webpackHotUpdate("static\\development\\pages\\product.js",{

/***/ "./components/ColorSelector.jsx":
/*!**************************************!*\
  !*** ./components/ColorSelector.jsx ***!
  \**************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var react_use__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! react-use */ "./node_modules/react-use/esm/index.js");
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");
/* harmony import */ var _Title__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./Title */ "./components/Title.jsx");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ColorSelector.jsx";





function ColorSelector(_ref) {
  var options = _ref.options,
      activeColor = _ref.activeColor,
      setActiveColor = _ref.setActiveColor;

  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(false),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      isPopupActive = _React$useState2[0],
      setIsPopupActive = _React$useState2[1];

  react__WEBPACK_IMPORTED_MODULE_1___default.a.useEffect(function () {
    if (isPopupActive && window) {
      window.document.body.style.overflow = 'hidden';
    } else if (window) {
      window.document.body.style.overflow = 'auto';
    }
  }, [isPopupActive]);
  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(react__WEBPACK_IMPORTED_MODULE_1___default.a.Fragment, null, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(ColorPopup, {
    state: [isPopupActive, setIsPopupActive, activeColor, setActiveColor],
    options: options,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 17
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_Title__WEBPACK_IMPORTED_MODULE_4__["default"], {
    label: "Cor",
    style: {
      margin: '5px 0',
      fontSize: '10px'
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 21
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], {
    className: "color-selector",
    style: {
      backgroundColor: activeColor
    },
    tag: "div",
    onClick: function onClick() {
      setIsPopupActive(true);
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 22
    },
    __self: this
  }));
}

var ColorPopup = function ColorPopup(_ref2) {
  var state = _ref2.state,
      options = _ref2.options;

  var _state = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(state, 4),
      isPopupActive = _state[0],
      setIsPopupActive = _state[1],
      activeColor = _state[2],
      setActiveColor = _state[3];

  var popupRef = react__WEBPACK_IMPORTED_MODULE_1___default.a.useRef(null);
  Object(react_use__WEBPACK_IMPORTED_MODULE_2__["useClickAway"])(popupRef, function () {
    setIsPopupActive(false);
  });
  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "color-popup-overlay",
    style: {
      transition: 'opacity .3s ease-in-out',
      pointerEvents: isPopupActive ? 'all' : 'none',
      opacity: isPopupActive ? 1 : 0
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 40
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "color-popup",
    ref: popupRef,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 48
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "color-popup-header",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 49
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_Title__WEBPACK_IMPORTED_MODULE_4__["default"], {
    label: "Selecione uma cor",
    style: {
      color: 'white',
      fontSize: 10
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 50
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "color-popup-body",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 55
    },
    __self: this
  }, options.map(function (_ref3, index) {
    var value = _ref3.value,
        color = _ref3.color;

    var handleColorClick = function handleColorClick() {
      setActiveColor(value);
      setIsPopupActive(false);
    };

    return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], {
      key: index,
      className: color === activeColor ? 'color-popup-box selected' : 'color-popup-box',
      style: {
        backgroundColor: color
      },
      onClick: handleColorClick,
      tag: "div",
      __source: {
        fileName: _jsxFileName,
        lineNumber: 62
      },
      __self: this
    });
  }))));
};

/* harmony default export */ __webpack_exports__["default"] = (ColorSelector);

/***/ })

})
//# sourceMappingURL=product.js.612d46da6eac4d5e3a75.hot-update.js.map