(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["static\\development\\pages\\product.js"],{

/***/ "./components/Breadcumb.jsx":
/*!**********************************!*\
  !*** ./components/Breadcumb.jsx ***!
  \**********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/toConsumableArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/toConsumableArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Breadcumb.jsx";


function Breadcumb(_ref) {
  var _ref$paths = _ref.paths,
      paths = _ref$paths === void 0 ? [] : _ref$paths;
  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "breadcumb",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, ['Loja'].concat(Object(_babel_runtime_corejs2_helpers_esm_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__["default"])(paths)).reduce(function (arr, element, index, array) {
    return index >= array.length - 1 ? [].concat(Object(_babel_runtime_corejs2_helpers_esm_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__["default"])(arr), [element]) : [].concat(Object(_babel_runtime_corejs2_helpers_esm_toConsumableArray__WEBPACK_IMPORTED_MODULE_0__["default"])(arr), [element, '/']);
  }, []).map(function (e, index) {
    return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("p", {
      className: "breadcumb-path",
      key: index,
      __source: {
        fileName: _jsxFileName,
        lineNumber: 14
      },
      __self: this
    }, e);
  }));
}

/* harmony default export */ __webpack_exports__["default"] = (Breadcumb);

/***/ }),

/***/ "./components/Button.jsx":
/*!*******************************!*\
  !*** ./components/Button.jsx ***!
  \*******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return Button; });
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_extends__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/extends */ "./node_modules/@babel/runtime-corejs2/helpers/esm/extends.js");
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_objectWithoutProperties__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/objectWithoutProperties */ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutProperties.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");


var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Button.jsx";


function Button(_ref) {
  var label = _ref.label,
      _ref$type = _ref.type,
      type = _ref$type === void 0 ? 'primary' : _ref$type,
      props = Object(_babel_runtime_corejs2_helpers_esm_objectWithoutProperties__WEBPACK_IMPORTED_MODULE_1__["default"])(_ref, ["label", "type"]);

  return react__WEBPACK_IMPORTED_MODULE_2___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], Object(_babel_runtime_corejs2_helpers_esm_extends__WEBPACK_IMPORTED_MODULE_0__["default"])({
    className: type === 'primary' ? 'button' : 'button secondary',
    tag: "button"
  }, props, {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 6
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_2___default.a.createElement("p", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 11
    },
    __self: this
  }, label));
}

/***/ }),

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

/***/ }),

/***/ "./components/Description.jsx":
/*!************************************!*\
  !*** ./components/Description.jsx ***!
  \************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Description.jsx";

/* harmony default export */ __webpack_exports__["default"] = (function (_ref) {
  var text = _ref.text,
      style = _ref.style;
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "description",
    style: style,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 4
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, text));
});

/***/ }),

/***/ "./components/FavoriteFloater.jsx":
/*!****************************************!*\
  !*** ./components/FavoriteFloater.jsx ***!
  \****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/assets/icons/favorited.svg */ "./static/assets/icons/favorited.svg");
/* harmony import */ var _static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/icons/favorite.svg */ "./static/assets/icons/favorite.svg");
/* harmony import */ var _static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\FavoriteFloater.jsx";




function FavoriteFloater(_ref) {
  var isFavorited = _ref.isFavorited,
      style = _ref.style;
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "favorite-container",
    style: style,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 7
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("img", {
    className: "favorite",
    src: _static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2___default.a,
    alt: "Favoritar",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("img", {
    className: isFavorited ? 'favorited active' : 'favorited',
    src: _static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1___default.a,
    alt: "Favoritado",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 9
    },
    __self: this
  }));
}

/* harmony default export */ __webpack_exports__["default"] = (FavoriteFloater);

/***/ }),

/***/ "./components/Footer.jsx":
/*!*******************************!*\
  !*** ./components/Footer.jsx ***!
  \*******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/assets/icons/payments.svg */ "./static/assets/icons/payments.svg");
/* harmony import */ var _static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Footer.jsx";



function Footer(_ref) {
  var style = _ref.style;
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("footer", {
    style: style,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("p", {
    className: "main-content",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 6
    },
    __self: this
  }, "\xA9 2019 Wittoeft LTDA - CNPJ: 18.391.981/0001-00 - Todos os direitos reservados. Em caso de diverg\xEAncia de pre\xE7os no site, o valor v\xE1lido \xE9 o do Carrinho de Compras. Pre\xE7os e condi\xE7\xF5es de pagamento podem variar de acordo com a disponibilidade dos produtos."), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "payment-methods",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 12
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("p", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 13
    },
    __self: this
  }, "M\xE9todos de Pagamento:"), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("img", {
    src: _static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1___default.a,
    alt: "M\xE9todos de Pagamento",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 14
    },
    __self: this
  })));
}

/* harmony default export */ __webpack_exports__["default"] = (Footer);

/***/ }),

/***/ "./components/InteractiveElement.jsx":
/*!*******************************************!*\
  !*** ./components/InteractiveElement.jsx ***!
  \*******************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_extends__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/extends */ "./node_modules/@babel/runtime-corejs2/helpers/esm/extends.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\InteractiveElement.jsx";

/* harmony default export */ __webpack_exports__["default"] = (react__WEBPACK_IMPORTED_MODULE_1__["forwardRef"](function (props, ref) {
  return react__WEBPACK_IMPORTED_MODULE_1__["createElement"](props.tag, Object(_babel_runtime_corejs2_helpers_esm_extends__WEBPACK_IMPORTED_MODULE_0__["default"])({
    role: "button",
    tabIndex: 0,
    onKeyPress: function onKeyPress(e) {
      return e.key === 'Enter' && props.onClick && props.onClick(e);
    },
    ref: ref
  }, props, {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }));
}));

/***/ }),

/***/ "./components/Menu.jsx":
/*!*****************************!*\
  !*** ./components/Menu.jsx ***!
  \*****************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! next/router */ "./node_modules/next/dist/client/router.js");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../static/assets/icons/menuToggleArrow.svg */ "./static/assets/icons/menuToggleArrow.svg");
/* harmony import */ var _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _static_consts_menuItems__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../static/consts/menuItems */ "./static/consts/menuItems.js");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Menu.jsx";




/* harmony default export */ __webpack_exports__["default"] = (react__WEBPACK_IMPORTED_MODULE_1__["forwardRef"](function (_ref, ref) {
  var isActive = _ref.isActive;

  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1__["useState"](-100),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      translateXValue = _React$useState2[0],
      setTranslateXValue = _React$useState2[1];

  var Router = Object(next_router__WEBPACK_IMPORTED_MODULE_2__["useRouter"])();
  react__WEBPACK_IMPORTED_MODULE_1__["useEffect"](function () {
    if (isActive) {
      setTranslateXValue(0);
    } else {
      setTranslateXValue(-100);
    }
  }, [isActive]);
  var itens = _static_consts_menuItems__WEBPACK_IMPORTED_MODULE_4__["default"].map(function (menuItem, index) {
    var _React$useState3 = react__WEBPACK_IMPORTED_MODULE_1__["useState"](false),
        _React$useState4 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState3, 2),
        subMenuIsActive = _React$useState4[0],
        setSubMenuIsActive = _React$useState4[1];

    function handleClick(e) {
      if (e.subItems) {
        setSubMenuIsActive(!subMenuIsActive);
      } else {
        var prefix = e.prefix,
            label = e.label;
        var link = prefix ? "/".concat(prefix, "/").concat(label.toLowerCase()) : '/' + label.toLowerCase();
        Router.push(link);
      }
    }

    return react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
      className: "menu-item",
      key: index,
      __source: {
        fileName: _jsxFileName,
        lineNumber: 28
      },
      __self: this
    }, react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("p", {
      className: "label",
      onClick: function onClick() {
        return handleClick(menuItem);
      },
      __source: {
        fileName: _jsxFileName,
        lineNumber: 30
      },
      __self: this
    }, menuItem.label, menuItem.subItems && react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("img", {
      className: "menu-toggle-arrow",
      src: _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_3___default.a,
      style: {
        transform: "rotate(".concat(subMenuIsActive ? 180 : 0, "deg)")
      },
      __source: {
        fileName: _jsxFileName,
        lineNumber: 31
      },
      __self: this
    })), menuItem.subItems && subMenuIsActive && react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
      className: "menu-sub-item-container",
      __source: {
        fileName: _jsxFileName,
        lineNumber: 34
      },
      __self: this
    }, menuItem.subItems.map(function (e, index) {
      e.prefix = menuItem.prefix;
      return react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
        className: "menu-sub-item",
        onClick: function onClick() {
          return handleClick(e);
        },
        key: index,
        __source: {
          fileName: _jsxFileName,
          lineNumber: 39
        },
        __self: this
      }, react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("p", {
        className: "label",
        __source: {
          fileName: _jsxFileName,
          lineNumber: 40
        },
        __self: this
      }, e.label));
    })));
  });
  return react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
    className: "menu",
    ref: ref,
    style: {
      transform: "translateX(".concat(translateXValue, "%)")
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 52
    },
    __self: this
  }, itens);
}));

/***/ }),

/***/ "./components/Nav.jsx":
/*!****************************!*\
  !*** ./components/Nav.jsx ***!
  \****************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! next/router */ "./node_modules/next/dist/client/router.js");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../static/assets/logo.svg */ "./static/assets/logo.svg");
/* harmony import */ var _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../static/assets/icons/hamburguerMenu.svg */ "./static/assets/icons/hamburguerMenu.svg");
/* harmony import */ var _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../static/assets/icons/hamburguerCloseMenu.svg */ "./static/assets/icons/hamburguerCloseMenu.svg");
/* harmony import */ var _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../static/assets/icons/shoppingCart.svg */ "./static/assets/icons/shoppingCart.svg");
/* harmony import */ var _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../static/assets/icons/search.svg */ "./static/assets/icons/search.svg");
/* harmony import */ var _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_7___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_7__);
/* harmony import */ var _Menu__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./Menu */ "./components/Menu.jsx");
/* harmony import */ var _ShopCartMenu__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./ShopCartMenu */ "./components/ShopCartMenu.jsx");
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Nav.jsx";











var Nav = function Nav() {
  var Router = Object(next_router__WEBPACK_IMPORTED_MODULE_2__["useRouter"])();

  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(false),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      isMenuActive = _React$useState2[0],
      setIsMenuActive = _React$useState2[1];

  var _React$useState3 = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState(false),
      _React$useState4 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState3, 2),
      isShopCartMenuActive = _React$useState4[0],
      setIsShopCartMenuActive = _React$useState4[1];

  var menuRef = react__WEBPACK_IMPORTED_MODULE_1___default.a.useRef();
  var navRef = react__WEBPACK_IMPORTED_MODULE_1___default.a.useRef();
  var hamburguerMenuRef = react__WEBPACK_IMPORTED_MODULE_1___default.a.useRef();

  function handleHamburguerMenu(e) {
    e.preventDefault();
    setIsMenuActive(!isMenuActive);
  }

  function handleShopCartMenu() {
    setIsShopCartMenuActive(!isShopCartMenuActive);
  }

  react__WEBPACK_IMPORTED_MODULE_1___default.a.useEffect(function () {
    if (document) {
      document.body.style.paddingTop = '15vh';
    }
  }, []);

  function handleLogoClick() {
    if (Router.pathname === '/' && window) {
      window.scrollTo({
        top: 0,
        behavior: 'smooth'
      });
    } else {
      Router.replace('/');
    }
  } // React.useEffect(()=>{
  //   // Não executa o resto se o documento não estiver disponivel
  //   if(!document) return
  //   const {body} = document
  //   if(isMenuActive){
  //     body.style.overflow = 'hidden';
  //   }else{
  //     body.style.overflow = 'auto';
  //   }
  // }, [isMenuActive])
  // useClickAway(menuRef, (e) => {
  //   if(isMenuActive && e.target!== navRef.current && e.target !== hamburguerMenuRef.current){
  //     setIsMenuActive(false)
  //   }else{
  //     // setIsMenuActive(true)
  //   }
  // }, ['mousedown']);


  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("nav", {
    ref: navRef,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 59
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_Menu__WEBPACK_IMPORTED_MODULE_8__["default"], {
    ref: menuRef,
    isActive: isMenuActive,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 60
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_ShopCartMenu__WEBPACK_IMPORTED_MODULE_9__["default"], {
    isActive: isShopCartMenuActive,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 61
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_10__["default"], {
    src: isMenuActive ? _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_5___default.a : _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_4___default.a,
    ref: hamburguerMenuRef,
    onClick: handleHamburguerMenu,
    className: "hamburguer-menu",
    alt: "Hamburguer Menu",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 62
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_10__["default"], {
    className: "logo",
    onClick: handleLogoClick,
    src: _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_3___default.a,
    alt: "Logo",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 70
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_10__["default"], {
    onClick: handleShopCartMenu,
    className: "shopping-cart",
    src: isShopCartMenuActive ? _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_5___default.a : _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_6___default.a,
    alt: "Carrinho de Compras",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 77
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "search-bar",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 84
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("input", {
    type: "search",
    placeholder: "Digite Aqui",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 85
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_10__["default"], {
    src: _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_7___default.a,
    alt: "Pesquisar",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 86
    },
    __self: this
  })));
};

/* harmony default export */ __webpack_exports__["default"] = (Nav);

/***/ }),

/***/ "./components/Page.jsx":
/*!*****************************!*\
  !*** ./components/Page.jsx ***!
  \*****************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/styles/main.scss */ "./static/styles/main.scss");
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Page.jsx";



function Page(_ref) {
  var children = _ref.children;
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, children);
}

/* harmony default export */ __webpack_exports__["default"] = (Page);

/***/ }),

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
  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1___default.a.useState('red'),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      activeColor = _React$useState2[0],
      setActiveColor = _React$useState2[1];

  console.log(activeColor);
  return react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-options-controller",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_ColorSelector__WEBPACK_IMPORTED_MODULE_2__["default"], {
    activeColor: activeColor,
    setActiveColor: setActiveColor,
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

/***/ }),

/***/ "./components/ShopCartMenu.jsx":
/*!*************************************!*\
  !*** ./components/ShopCartMenu.jsx ***!
  \*************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ShopCartMenu.jsx";

/* harmony default export */ __webpack_exports__["default"] = (function (_ref) {
  var isActive = _ref.isActive;
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "menu",
    style: {
      left: 'unset',
      right: 0,
      transform: "translateX(".concat(isActive ? 0 : 100, "%)")
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  });
});

/***/ }),

/***/ "./components/Title.jsx":
/*!******************************!*\
  !*** ./components/Title.jsx ***!
  \******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Title.jsx";

/* harmony default export */ __webpack_exports__["default"] = (function (_ref) {
  var label = _ref.label,
      style = _ref.style;
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "title-container",
    style: style,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 4
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("h1", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, label));
});

/***/ }),

/***/ "./components/TitleWithFloater.jsx":
/*!*****************************************!*\
  !*** ./components/TitleWithFloater.jsx ***!
  \*****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _Title__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./Title */ "./components/Title.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\TitleWithFloater.jsx";


/* harmony default export */ __webpack_exports__["default"] = (function (_ref) {
  var children = _ref.children,
      label = _ref.label;
  console.log(children);
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "title-floater-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 7
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_Title__WEBPACK_IMPORTED_MODULE_1__["default"], {
    label: label,
    style: {
      minHeight: 40
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: this
  }), children);
});

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/array/from.js":
/*!*******************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/array/from.js ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/array/from */ "./node_modules/core-js/library/fn/array/from.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/array/is-array.js":
/*!***********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/array/is-array.js ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/array/is-array */ "./node_modules/core-js/library/fn/array/is-array.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/get-iterator.js":
/*!*********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/get-iterator.js ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/get-iterator */ "./node_modules/core-js/library/fn/get-iterator.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/is-iterable.js":
/*!********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/is-iterable.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/is-iterable */ "./node_modules/core-js/library/fn/is-iterable.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/assign.js":
/*!**********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/assign.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/assign */ "./node_modules/core-js/library/fn/object/assign.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/create.js":
/*!**********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/create.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/create */ "./node_modules/core-js/library/fn/object/create.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js":
/*!*******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js ***!
  \*******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/define-property */ "./node_modules/core-js/library/fn/object/define-property.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-own-property-symbols */ "./node_modules/core-js/library/fn/object/get-own-property-symbols.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js":
/*!********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/keys.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/keys */ "./node_modules/core-js/library/fn/object/keys.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/promise.js":
/*!****************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/promise.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/promise */ "./node_modules/core-js/library/fn/promise.js");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithHoles.js":
/*!***************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithHoles.js ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _arrayWithHoles; });
/* harmony import */ var _core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/array/is-array */ "./node_modules/@babel/runtime-corejs2/core-js/array/is-array.js");
/* harmony import */ var _core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0__);

function _arrayWithHoles(arr) {
  if (_core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0___default()(arr)) return arr;
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithoutHoles.js":
/*!******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithoutHoles.js ***!
  \******************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _arrayWithoutHoles; });
/* harmony import */ var _core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/array/is-array */ "./node_modules/@babel/runtime-corejs2/core-js/array/is-array.js");
/* harmony import */ var _core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0__);

function _arrayWithoutHoles(arr) {
  if (_core_js_array_is_array__WEBPACK_IMPORTED_MODULE_0___default()(arr)) {
    for (var i = 0, arr2 = new Array(arr.length); i < arr.length; i++) {
      arr2[i] = arr[i];
    }

    return arr2;
  }
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/asyncToGenerator.js":
/*!*****************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/asyncToGenerator.js ***!
  \*****************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _asyncToGenerator; });
/* harmony import */ var _core_js_promise__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/promise */ "./node_modules/@babel/runtime-corejs2/core-js/promise.js");
/* harmony import */ var _core_js_promise__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_promise__WEBPACK_IMPORTED_MODULE_0__);


function asyncGeneratorStep(gen, resolve, reject, _next, _throw, key, arg) {
  try {
    var info = gen[key](arg);
    var value = info.value;
  } catch (error) {
    reject(error);
    return;
  }

  if (info.done) {
    resolve(value);
  } else {
    _core_js_promise__WEBPACK_IMPORTED_MODULE_0___default.a.resolve(value).then(_next, _throw);
  }
}

function _asyncToGenerator(fn) {
  return function () {
    var self = this,
        args = arguments;
    return new _core_js_promise__WEBPACK_IMPORTED_MODULE_0___default.a(function (resolve, reject) {
      var gen = fn.apply(self, args);

      function _next(value) {
        asyncGeneratorStep(gen, resolve, reject, _next, _throw, "next", value);
      }

      function _throw(err) {
        asyncGeneratorStep(gen, resolve, reject, _next, _throw, "throw", err);
      }

      _next(undefined);
    });
  };
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js":
/*!***************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _classCallCheck; });
function _classCallCheck(instance, Constructor) {
  if (!(instance instanceof Constructor)) {
    throw new TypeError("Cannot call a class as a function");
  }
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js":
/*!************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js ***!
  \************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _createClass; });
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js");
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__);


function _defineProperties(target, props) {
  for (var i = 0; i < props.length; i++) {
    var descriptor = props[i];
    descriptor.enumerable = descriptor.enumerable || false;
    descriptor.configurable = true;
    if ("value" in descriptor) descriptor.writable = true;

    _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default()(target, descriptor.key, descriptor);
  }
}

function _createClass(Constructor, protoProps, staticProps) {
  if (protoProps) _defineProperties(Constructor.prototype, protoProps);
  if (staticProps) _defineProperties(Constructor, staticProps);
  return Constructor;
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/extends.js":
/*!********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/extends.js ***!
  \********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _extends; });
/* harmony import */ var _core_js_object_assign__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/assign */ "./node_modules/@babel/runtime-corejs2/core-js/object/assign.js");
/* harmony import */ var _core_js_object_assign__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_assign__WEBPACK_IMPORTED_MODULE_0__);

function _extends() {
  _extends = _core_js_object_assign__WEBPACK_IMPORTED_MODULE_0___default.a || function (target) {
    for (var i = 1; i < arguments.length; i++) {
      var source = arguments[i];

      for (var key in source) {
        if (Object.prototype.hasOwnProperty.call(source, key)) {
          target[key] = source[key];
        }
      }
    }

    return target;
  };

  return _extends.apply(this, arguments);
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArray.js":
/*!****************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArray.js ***!
  \****************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _iterableToArray; });
/* harmony import */ var _core_js_array_from__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/array/from */ "./node_modules/@babel/runtime-corejs2/core-js/array/from.js");
/* harmony import */ var _core_js_array_from__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_array_from__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _core_js_is_iterable__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../core-js/is-iterable */ "./node_modules/@babel/runtime-corejs2/core-js/is-iterable.js");
/* harmony import */ var _core_js_is_iterable__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_core_js_is_iterable__WEBPACK_IMPORTED_MODULE_1__);


function _iterableToArray(iter) {
  if (_core_js_is_iterable__WEBPACK_IMPORTED_MODULE_1___default()(Object(iter)) || Object.prototype.toString.call(iter) === "[object Arguments]") return _core_js_array_from__WEBPACK_IMPORTED_MODULE_0___default()(iter);
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArrayLimit.js":
/*!*********************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArrayLimit.js ***!
  \*********************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _iterableToArrayLimit; });
/* harmony import */ var _core_js_get_iterator__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/get-iterator */ "./node_modules/@babel/runtime-corejs2/core-js/get-iterator.js");
/* harmony import */ var _core_js_get_iterator__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_get_iterator__WEBPACK_IMPORTED_MODULE_0__);

function _iterableToArrayLimit(arr, i) {
  var _arr = [];
  var _n = true;
  var _d = false;
  var _e = undefined;

  try {
    for (var _i = _core_js_get_iterator__WEBPACK_IMPORTED_MODULE_0___default()(arr), _s; !(_n = (_s = _i.next()).done); _n = true) {
      _arr.push(_s.value);

      if (i && _arr.length === i) break;
    }
  } catch (err) {
    _d = true;
    _e = err;
  } finally {
    try {
      if (!_n && _i["return"] != null) _i["return"]();
    } finally {
      if (_d) throw _e;
    }
  }

  return _arr;
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableRest.js":
/*!****************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableRest.js ***!
  \****************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _nonIterableRest; });
function _nonIterableRest() {
  throw new TypeError("Invalid attempt to destructure non-iterable instance");
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableSpread.js":
/*!******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableSpread.js ***!
  \******************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _nonIterableSpread; });
function _nonIterableSpread() {
  throw new TypeError("Invalid attempt to spread non-iterable instance");
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutProperties.js":
/*!************************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutProperties.js ***!
  \************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _objectWithoutProperties; });
/* harmony import */ var _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/get-own-property-symbols */ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js");
/* harmony import */ var _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _objectWithoutPropertiesLoose__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./objectWithoutPropertiesLoose */ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutPropertiesLoose.js");


function _objectWithoutProperties(source, excluded) {
  if (source == null) return {};
  var target = Object(_objectWithoutPropertiesLoose__WEBPACK_IMPORTED_MODULE_1__["default"])(source, excluded);
  var key, i;

  if (_core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_0___default.a) {
    var sourceSymbolKeys = _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_0___default()(source);

    for (i = 0; i < sourceSymbolKeys.length; i++) {
      key = sourceSymbolKeys[i];
      if (excluded.indexOf(key) >= 0) continue;
      if (!Object.prototype.propertyIsEnumerable.call(source, key)) continue;
      target[key] = source[key];
    }
  }

  return target;
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutPropertiesLoose.js":
/*!*****************************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/objectWithoutPropertiesLoose.js ***!
  \*****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _objectWithoutPropertiesLoose; });
/* harmony import */ var _core_js_object_keys__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/keys */ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js");
/* harmony import */ var _core_js_object_keys__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_keys__WEBPACK_IMPORTED_MODULE_0__);

function _objectWithoutPropertiesLoose(source, excluded) {
  if (source == null) return {};
  var target = {};

  var sourceKeys = _core_js_object_keys__WEBPACK_IMPORTED_MODULE_0___default()(source);

  var key, i;

  for (i = 0; i < sourceKeys.length; i++) {
    key = sourceKeys[i];
    if (excluded.indexOf(key) >= 0) continue;
    target[key] = source[key];
  }

  return target;
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js":
/*!**************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js ***!
  \**************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _slicedToArray; });
/* harmony import */ var _arrayWithHoles__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./arrayWithHoles */ "./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithHoles.js");
/* harmony import */ var _iterableToArrayLimit__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./iterableToArrayLimit */ "./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArrayLimit.js");
/* harmony import */ var _nonIterableRest__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./nonIterableRest */ "./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableRest.js");



function _slicedToArray(arr, i) {
  return Object(_arrayWithHoles__WEBPACK_IMPORTED_MODULE_0__["default"])(arr) || Object(_iterableToArrayLimit__WEBPACK_IMPORTED_MODULE_1__["default"])(arr, i) || Object(_nonIterableRest__WEBPACK_IMPORTED_MODULE_2__["default"])();
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/toConsumableArray.js":
/*!******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/toConsumableArray.js ***!
  \******************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _toConsumableArray; });
/* harmony import */ var _arrayWithoutHoles__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./arrayWithoutHoles */ "./node_modules/@babel/runtime-corejs2/helpers/esm/arrayWithoutHoles.js");
/* harmony import */ var _iterableToArray__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./iterableToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/iterableToArray.js");
/* harmony import */ var _nonIterableSpread__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./nonIterableSpread */ "./node_modules/@babel/runtime-corejs2/helpers/esm/nonIterableSpread.js");



function _toConsumableArray(arr) {
  return Object(_arrayWithoutHoles__WEBPACK_IMPORTED_MODULE_0__["default"])(arr) || Object(_iterableToArray__WEBPACK_IMPORTED_MODULE_1__["default"])(arr) || Object(_nonIterableSpread__WEBPACK_IMPORTED_MODULE_2__["default"])();
}

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js":
/*!******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js ***!
  \******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function _interopRequireDefault(obj) {
  return obj && obj.__esModule ? obj : {
    "default": obj
  };
}

module.exports = _interopRequireDefault;

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/regenerator/index.js":
/*!******************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/regenerator/index.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! regenerator-runtime */ "./node_modules/regenerator-runtime/runtime.js");


/***/ }),

/***/ "./node_modules/axios/index.js":
/*!*************************************!*\
  !*** ./node_modules/axios/index.js ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! ./lib/axios */ "./node_modules/axios/lib/axios.js");

/***/ }),

/***/ "./node_modules/axios/lib/adapters/xhr.js":
/*!************************************************!*\
  !*** ./node_modules/axios/lib/adapters/xhr.js ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");
var settle = __webpack_require__(/*! ./../core/settle */ "./node_modules/axios/lib/core/settle.js");
var buildURL = __webpack_require__(/*! ./../helpers/buildURL */ "./node_modules/axios/lib/helpers/buildURL.js");
var parseHeaders = __webpack_require__(/*! ./../helpers/parseHeaders */ "./node_modules/axios/lib/helpers/parseHeaders.js");
var isURLSameOrigin = __webpack_require__(/*! ./../helpers/isURLSameOrigin */ "./node_modules/axios/lib/helpers/isURLSameOrigin.js");
var createError = __webpack_require__(/*! ../core/createError */ "./node_modules/axios/lib/core/createError.js");

module.exports = function xhrAdapter(config) {
  return new Promise(function dispatchXhrRequest(resolve, reject) {
    var requestData = config.data;
    var requestHeaders = config.headers;

    if (utils.isFormData(requestData)) {
      delete requestHeaders['Content-Type']; // Let the browser set it
    }

    var request = new XMLHttpRequest();

    // HTTP basic authentication
    if (config.auth) {
      var username = config.auth.username || '';
      var password = config.auth.password || '';
      requestHeaders.Authorization = 'Basic ' + btoa(username + ':' + password);
    }

    request.open(config.method.toUpperCase(), buildURL(config.url, config.params, config.paramsSerializer), true);

    // Set the request timeout in MS
    request.timeout = config.timeout;

    // Listen for ready state
    request.onreadystatechange = function handleLoad() {
      if (!request || request.readyState !== 4) {
        return;
      }

      // The request errored out and we didn't get a response, this will be
      // handled by onerror instead
      // With one exception: request that using file: protocol, most browsers
      // will return status as 0 even though it's a successful request
      if (request.status === 0 && !(request.responseURL && request.responseURL.indexOf('file:') === 0)) {
        return;
      }

      // Prepare the response
      var responseHeaders = 'getAllResponseHeaders' in request ? parseHeaders(request.getAllResponseHeaders()) : null;
      var responseData = !config.responseType || config.responseType === 'text' ? request.responseText : request.response;
      var response = {
        data: responseData,
        status: request.status,
        statusText: request.statusText,
        headers: responseHeaders,
        config: config,
        request: request
      };

      settle(resolve, reject, response);

      // Clean up request
      request = null;
    };

    // Handle browser request cancellation (as opposed to a manual cancellation)
    request.onabort = function handleAbort() {
      if (!request) {
        return;
      }

      reject(createError('Request aborted', config, 'ECONNABORTED', request));

      // Clean up request
      request = null;
    };

    // Handle low level network errors
    request.onerror = function handleError() {
      // Real errors are hidden from us by the browser
      // onerror should only fire if it's a network error
      reject(createError('Network Error', config, null, request));

      // Clean up request
      request = null;
    };

    // Handle timeout
    request.ontimeout = function handleTimeout() {
      reject(createError('timeout of ' + config.timeout + 'ms exceeded', config, 'ECONNABORTED',
        request));

      // Clean up request
      request = null;
    };

    // Add xsrf header
    // This is only done if running in a standard browser environment.
    // Specifically not if we're in a web worker, or react-native.
    if (utils.isStandardBrowserEnv()) {
      var cookies = __webpack_require__(/*! ./../helpers/cookies */ "./node_modules/axios/lib/helpers/cookies.js");

      // Add xsrf header
      var xsrfValue = (config.withCredentials || isURLSameOrigin(config.url)) && config.xsrfCookieName ?
        cookies.read(config.xsrfCookieName) :
        undefined;

      if (xsrfValue) {
        requestHeaders[config.xsrfHeaderName] = xsrfValue;
      }
    }

    // Add headers to the request
    if ('setRequestHeader' in request) {
      utils.forEach(requestHeaders, function setRequestHeader(val, key) {
        if (typeof requestData === 'undefined' && key.toLowerCase() === 'content-type') {
          // Remove Content-Type if data is undefined
          delete requestHeaders[key];
        } else {
          // Otherwise add header to the request
          request.setRequestHeader(key, val);
        }
      });
    }

    // Add withCredentials to request if needed
    if (config.withCredentials) {
      request.withCredentials = true;
    }

    // Add responseType to request if needed
    if (config.responseType) {
      try {
        request.responseType = config.responseType;
      } catch (e) {
        // Expected DOMException thrown by browsers not compatible XMLHttpRequest Level 2.
        // But, this can be suppressed for 'json' type as it can be parsed by default 'transformResponse' function.
        if (config.responseType !== 'json') {
          throw e;
        }
      }
    }

    // Handle progress if needed
    if (typeof config.onDownloadProgress === 'function') {
      request.addEventListener('progress', config.onDownloadProgress);
    }

    // Not all browsers support upload events
    if (typeof config.onUploadProgress === 'function' && request.upload) {
      request.upload.addEventListener('progress', config.onUploadProgress);
    }

    if (config.cancelToken) {
      // Handle cancellation
      config.cancelToken.promise.then(function onCanceled(cancel) {
        if (!request) {
          return;
        }

        request.abort();
        reject(cancel);
        // Clean up request
        request = null;
      });
    }

    if (requestData === undefined) {
      requestData = null;
    }

    // Send the request
    request.send(requestData);
  });
};


/***/ }),

/***/ "./node_modules/axios/lib/axios.js":
/*!*****************************************!*\
  !*** ./node_modules/axios/lib/axios.js ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./utils */ "./node_modules/axios/lib/utils.js");
var bind = __webpack_require__(/*! ./helpers/bind */ "./node_modules/axios/lib/helpers/bind.js");
var Axios = __webpack_require__(/*! ./core/Axios */ "./node_modules/axios/lib/core/Axios.js");
var mergeConfig = __webpack_require__(/*! ./core/mergeConfig */ "./node_modules/axios/lib/core/mergeConfig.js");
var defaults = __webpack_require__(/*! ./defaults */ "./node_modules/axios/lib/defaults.js");

/**
 * Create an instance of Axios
 *
 * @param {Object} defaultConfig The default config for the instance
 * @return {Axios} A new instance of Axios
 */
function createInstance(defaultConfig) {
  var context = new Axios(defaultConfig);
  var instance = bind(Axios.prototype.request, context);

  // Copy axios.prototype to instance
  utils.extend(instance, Axios.prototype, context);

  // Copy context to instance
  utils.extend(instance, context);

  return instance;
}

// Create the default instance to be exported
var axios = createInstance(defaults);

// Expose Axios class to allow class inheritance
axios.Axios = Axios;

// Factory for creating new instances
axios.create = function create(instanceConfig) {
  return createInstance(mergeConfig(axios.defaults, instanceConfig));
};

// Expose Cancel & CancelToken
axios.Cancel = __webpack_require__(/*! ./cancel/Cancel */ "./node_modules/axios/lib/cancel/Cancel.js");
axios.CancelToken = __webpack_require__(/*! ./cancel/CancelToken */ "./node_modules/axios/lib/cancel/CancelToken.js");
axios.isCancel = __webpack_require__(/*! ./cancel/isCancel */ "./node_modules/axios/lib/cancel/isCancel.js");

// Expose all/spread
axios.all = function all(promises) {
  return Promise.all(promises);
};
axios.spread = __webpack_require__(/*! ./helpers/spread */ "./node_modules/axios/lib/helpers/spread.js");

module.exports = axios;

// Allow use of default import syntax in TypeScript
module.exports.default = axios;


/***/ }),

/***/ "./node_modules/axios/lib/cancel/Cancel.js":
/*!*************************************************!*\
  !*** ./node_modules/axios/lib/cancel/Cancel.js ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


/**
 * A `Cancel` is an object that is thrown when an operation is canceled.
 *
 * @class
 * @param {string=} message The message.
 */
function Cancel(message) {
  this.message = message;
}

Cancel.prototype.toString = function toString() {
  return 'Cancel' + (this.message ? ': ' + this.message : '');
};

Cancel.prototype.__CANCEL__ = true;

module.exports = Cancel;


/***/ }),

/***/ "./node_modules/axios/lib/cancel/CancelToken.js":
/*!******************************************************!*\
  !*** ./node_modules/axios/lib/cancel/CancelToken.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var Cancel = __webpack_require__(/*! ./Cancel */ "./node_modules/axios/lib/cancel/Cancel.js");

/**
 * A `CancelToken` is an object that can be used to request cancellation of an operation.
 *
 * @class
 * @param {Function} executor The executor function.
 */
function CancelToken(executor) {
  if (typeof executor !== 'function') {
    throw new TypeError('executor must be a function.');
  }

  var resolvePromise;
  this.promise = new Promise(function promiseExecutor(resolve) {
    resolvePromise = resolve;
  });

  var token = this;
  executor(function cancel(message) {
    if (token.reason) {
      // Cancellation has already been requested
      return;
    }

    token.reason = new Cancel(message);
    resolvePromise(token.reason);
  });
}

/**
 * Throws a `Cancel` if cancellation has been requested.
 */
CancelToken.prototype.throwIfRequested = function throwIfRequested() {
  if (this.reason) {
    throw this.reason;
  }
};

/**
 * Returns an object that contains a new `CancelToken` and a function that, when called,
 * cancels the `CancelToken`.
 */
CancelToken.source = function source() {
  var cancel;
  var token = new CancelToken(function executor(c) {
    cancel = c;
  });
  return {
    token: token,
    cancel: cancel
  };
};

module.exports = CancelToken;


/***/ }),

/***/ "./node_modules/axios/lib/cancel/isCancel.js":
/*!***************************************************!*\
  !*** ./node_modules/axios/lib/cancel/isCancel.js ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


module.exports = function isCancel(value) {
  return !!(value && value.__CANCEL__);
};


/***/ }),

/***/ "./node_modules/axios/lib/core/Axios.js":
/*!**********************************************!*\
  !*** ./node_modules/axios/lib/core/Axios.js ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");
var buildURL = __webpack_require__(/*! ../helpers/buildURL */ "./node_modules/axios/lib/helpers/buildURL.js");
var InterceptorManager = __webpack_require__(/*! ./InterceptorManager */ "./node_modules/axios/lib/core/InterceptorManager.js");
var dispatchRequest = __webpack_require__(/*! ./dispatchRequest */ "./node_modules/axios/lib/core/dispatchRequest.js");
var mergeConfig = __webpack_require__(/*! ./mergeConfig */ "./node_modules/axios/lib/core/mergeConfig.js");

/**
 * Create a new instance of Axios
 *
 * @param {Object} instanceConfig The default config for the instance
 */
function Axios(instanceConfig) {
  this.defaults = instanceConfig;
  this.interceptors = {
    request: new InterceptorManager(),
    response: new InterceptorManager()
  };
}

/**
 * Dispatch a request
 *
 * @param {Object} config The config specific for this request (merged with this.defaults)
 */
Axios.prototype.request = function request(config) {
  /*eslint no-param-reassign:0*/
  // Allow for axios('example/url'[, config]) a la fetch API
  if (typeof config === 'string') {
    config = arguments[1] || {};
    config.url = arguments[0];
  } else {
    config = config || {};
  }

  config = mergeConfig(this.defaults, config);
  config.method = config.method ? config.method.toLowerCase() : 'get';

  // Hook up interceptors middleware
  var chain = [dispatchRequest, undefined];
  var promise = Promise.resolve(config);

  this.interceptors.request.forEach(function unshiftRequestInterceptors(interceptor) {
    chain.unshift(interceptor.fulfilled, interceptor.rejected);
  });

  this.interceptors.response.forEach(function pushResponseInterceptors(interceptor) {
    chain.push(interceptor.fulfilled, interceptor.rejected);
  });

  while (chain.length) {
    promise = promise.then(chain.shift(), chain.shift());
  }

  return promise;
};

Axios.prototype.getUri = function getUri(config) {
  config = mergeConfig(this.defaults, config);
  return buildURL(config.url, config.params, config.paramsSerializer).replace(/^\?/, '');
};

// Provide aliases for supported request methods
utils.forEach(['delete', 'get', 'head', 'options'], function forEachMethodNoData(method) {
  /*eslint func-names:0*/
  Axios.prototype[method] = function(url, config) {
    return this.request(utils.merge(config || {}, {
      method: method,
      url: url
    }));
  };
});

utils.forEach(['post', 'put', 'patch'], function forEachMethodWithData(method) {
  /*eslint func-names:0*/
  Axios.prototype[method] = function(url, data, config) {
    return this.request(utils.merge(config || {}, {
      method: method,
      url: url,
      data: data
    }));
  };
});

module.exports = Axios;


/***/ }),

/***/ "./node_modules/axios/lib/core/InterceptorManager.js":
/*!***********************************************************!*\
  !*** ./node_modules/axios/lib/core/InterceptorManager.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

function InterceptorManager() {
  this.handlers = [];
}

/**
 * Add a new interceptor to the stack
 *
 * @param {Function} fulfilled The function to handle `then` for a `Promise`
 * @param {Function} rejected The function to handle `reject` for a `Promise`
 *
 * @return {Number} An ID used to remove interceptor later
 */
InterceptorManager.prototype.use = function use(fulfilled, rejected) {
  this.handlers.push({
    fulfilled: fulfilled,
    rejected: rejected
  });
  return this.handlers.length - 1;
};

/**
 * Remove an interceptor from the stack
 *
 * @param {Number} id The ID that was returned by `use`
 */
InterceptorManager.prototype.eject = function eject(id) {
  if (this.handlers[id]) {
    this.handlers[id] = null;
  }
};

/**
 * Iterate over all the registered interceptors
 *
 * This method is particularly useful for skipping over any
 * interceptors that may have become `null` calling `eject`.
 *
 * @param {Function} fn The function to call for each interceptor
 */
InterceptorManager.prototype.forEach = function forEach(fn) {
  utils.forEach(this.handlers, function forEachHandler(h) {
    if (h !== null) {
      fn(h);
    }
  });
};

module.exports = InterceptorManager;


/***/ }),

/***/ "./node_modules/axios/lib/core/createError.js":
/*!****************************************************!*\
  !*** ./node_modules/axios/lib/core/createError.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var enhanceError = __webpack_require__(/*! ./enhanceError */ "./node_modules/axios/lib/core/enhanceError.js");

/**
 * Create an Error with the specified message, config, error code, request and response.
 *
 * @param {string} message The error message.
 * @param {Object} config The config.
 * @param {string} [code] The error code (for example, 'ECONNABORTED').
 * @param {Object} [request] The request.
 * @param {Object} [response] The response.
 * @returns {Error} The created error.
 */
module.exports = function createError(message, config, code, request, response) {
  var error = new Error(message);
  return enhanceError(error, config, code, request, response);
};


/***/ }),

/***/ "./node_modules/axios/lib/core/dispatchRequest.js":
/*!********************************************************!*\
  !*** ./node_modules/axios/lib/core/dispatchRequest.js ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");
var transformData = __webpack_require__(/*! ./transformData */ "./node_modules/axios/lib/core/transformData.js");
var isCancel = __webpack_require__(/*! ../cancel/isCancel */ "./node_modules/axios/lib/cancel/isCancel.js");
var defaults = __webpack_require__(/*! ../defaults */ "./node_modules/axios/lib/defaults.js");
var isAbsoluteURL = __webpack_require__(/*! ./../helpers/isAbsoluteURL */ "./node_modules/axios/lib/helpers/isAbsoluteURL.js");
var combineURLs = __webpack_require__(/*! ./../helpers/combineURLs */ "./node_modules/axios/lib/helpers/combineURLs.js");

/**
 * Throws a `Cancel` if cancellation has been requested.
 */
function throwIfCancellationRequested(config) {
  if (config.cancelToken) {
    config.cancelToken.throwIfRequested();
  }
}

/**
 * Dispatch a request to the server using the configured adapter.
 *
 * @param {object} config The config that is to be used for the request
 * @returns {Promise} The Promise to be fulfilled
 */
module.exports = function dispatchRequest(config) {
  throwIfCancellationRequested(config);

  // Support baseURL config
  if (config.baseURL && !isAbsoluteURL(config.url)) {
    config.url = combineURLs(config.baseURL, config.url);
  }

  // Ensure headers exist
  config.headers = config.headers || {};

  // Transform request data
  config.data = transformData(
    config.data,
    config.headers,
    config.transformRequest
  );

  // Flatten headers
  config.headers = utils.merge(
    config.headers.common || {},
    config.headers[config.method] || {},
    config.headers || {}
  );

  utils.forEach(
    ['delete', 'get', 'head', 'post', 'put', 'patch', 'common'],
    function cleanHeaderConfig(method) {
      delete config.headers[method];
    }
  );

  var adapter = config.adapter || defaults.adapter;

  return adapter(config).then(function onAdapterResolution(response) {
    throwIfCancellationRequested(config);

    // Transform response data
    response.data = transformData(
      response.data,
      response.headers,
      config.transformResponse
    );

    return response;
  }, function onAdapterRejection(reason) {
    if (!isCancel(reason)) {
      throwIfCancellationRequested(config);

      // Transform response data
      if (reason && reason.response) {
        reason.response.data = transformData(
          reason.response.data,
          reason.response.headers,
          config.transformResponse
        );
      }
    }

    return Promise.reject(reason);
  });
};


/***/ }),

/***/ "./node_modules/axios/lib/core/enhanceError.js":
/*!*****************************************************!*\
  !*** ./node_modules/axios/lib/core/enhanceError.js ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


/**
 * Update an Error with the specified config, error code, and response.
 *
 * @param {Error} error The error to update.
 * @param {Object} config The config.
 * @param {string} [code] The error code (for example, 'ECONNABORTED').
 * @param {Object} [request] The request.
 * @param {Object} [response] The response.
 * @returns {Error} The error.
 */
module.exports = function enhanceError(error, config, code, request, response) {
  error.config = config;
  if (code) {
    error.code = code;
  }

  error.request = request;
  error.response = response;
  error.isAxiosError = true;

  error.toJSON = function() {
    return {
      // Standard
      message: this.message,
      name: this.name,
      // Microsoft
      description: this.description,
      number: this.number,
      // Mozilla
      fileName: this.fileName,
      lineNumber: this.lineNumber,
      columnNumber: this.columnNumber,
      stack: this.stack,
      // Axios
      config: this.config,
      code: this.code
    };
  };
  return error;
};


/***/ }),

/***/ "./node_modules/axios/lib/core/mergeConfig.js":
/*!****************************************************!*\
  !*** ./node_modules/axios/lib/core/mergeConfig.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ../utils */ "./node_modules/axios/lib/utils.js");

/**
 * Config-specific merge-function which creates a new config-object
 * by merging two configuration objects together.
 *
 * @param {Object} config1
 * @param {Object} config2
 * @returns {Object} New object resulting from merging config2 to config1
 */
module.exports = function mergeConfig(config1, config2) {
  // eslint-disable-next-line no-param-reassign
  config2 = config2 || {};
  var config = {};

  utils.forEach(['url', 'method', 'params', 'data'], function valueFromConfig2(prop) {
    if (typeof config2[prop] !== 'undefined') {
      config[prop] = config2[prop];
    }
  });

  utils.forEach(['headers', 'auth', 'proxy'], function mergeDeepProperties(prop) {
    if (utils.isObject(config2[prop])) {
      config[prop] = utils.deepMerge(config1[prop], config2[prop]);
    } else if (typeof config2[prop] !== 'undefined') {
      config[prop] = config2[prop];
    } else if (utils.isObject(config1[prop])) {
      config[prop] = utils.deepMerge(config1[prop]);
    } else if (typeof config1[prop] !== 'undefined') {
      config[prop] = config1[prop];
    }
  });

  utils.forEach([
    'baseURL', 'transformRequest', 'transformResponse', 'paramsSerializer',
    'timeout', 'withCredentials', 'adapter', 'responseType', 'xsrfCookieName',
    'xsrfHeaderName', 'onUploadProgress', 'onDownloadProgress', 'maxContentLength',
    'validateStatus', 'maxRedirects', 'httpAgent', 'httpsAgent', 'cancelToken',
    'socketPath'
  ], function defaultToConfig2(prop) {
    if (typeof config2[prop] !== 'undefined') {
      config[prop] = config2[prop];
    } else if (typeof config1[prop] !== 'undefined') {
      config[prop] = config1[prop];
    }
  });

  return config;
};


/***/ }),

/***/ "./node_modules/axios/lib/core/settle.js":
/*!***********************************************!*\
  !*** ./node_modules/axios/lib/core/settle.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var createError = __webpack_require__(/*! ./createError */ "./node_modules/axios/lib/core/createError.js");

/**
 * Resolve or reject a Promise based on response status.
 *
 * @param {Function} resolve A function that resolves the promise.
 * @param {Function} reject A function that rejects the promise.
 * @param {object} response The response.
 */
module.exports = function settle(resolve, reject, response) {
  var validateStatus = response.config.validateStatus;
  if (!validateStatus || validateStatus(response.status)) {
    resolve(response);
  } else {
    reject(createError(
      'Request failed with status code ' + response.status,
      response.config,
      null,
      response.request,
      response
    ));
  }
};


/***/ }),

/***/ "./node_modules/axios/lib/core/transformData.js":
/*!******************************************************!*\
  !*** ./node_modules/axios/lib/core/transformData.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

/**
 * Transform the data for a request or a response
 *
 * @param {Object|String} data The data to be transformed
 * @param {Array} headers The headers for the request or response
 * @param {Array|Function} fns A single function or Array of functions
 * @returns {*} The resulting transformed data
 */
module.exports = function transformData(data, headers, fns) {
  /*eslint no-param-reassign:0*/
  utils.forEach(fns, function transform(fn) {
    data = fn(data, headers);
  });

  return data;
};


/***/ }),

/***/ "./node_modules/axios/lib/defaults.js":
/*!********************************************!*\
  !*** ./node_modules/axios/lib/defaults.js ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function(process) {

var utils = __webpack_require__(/*! ./utils */ "./node_modules/axios/lib/utils.js");
var normalizeHeaderName = __webpack_require__(/*! ./helpers/normalizeHeaderName */ "./node_modules/axios/lib/helpers/normalizeHeaderName.js");

var DEFAULT_CONTENT_TYPE = {
  'Content-Type': 'application/x-www-form-urlencoded'
};

function setContentTypeIfUnset(headers, value) {
  if (!utils.isUndefined(headers) && utils.isUndefined(headers['Content-Type'])) {
    headers['Content-Type'] = value;
  }
}

function getDefaultAdapter() {
  var adapter;
  // Only Node.JS has a process variable that is of [[Class]] process
  if (typeof process !== 'undefined' && Object.prototype.toString.call(process) === '[object process]') {
    // For node use HTTP adapter
    adapter = __webpack_require__(/*! ./adapters/http */ "./node_modules/axios/lib/adapters/xhr.js");
  } else if (typeof XMLHttpRequest !== 'undefined') {
    // For browsers use XHR adapter
    adapter = __webpack_require__(/*! ./adapters/xhr */ "./node_modules/axios/lib/adapters/xhr.js");
  }
  return adapter;
}

var defaults = {
  adapter: getDefaultAdapter(),

  transformRequest: [function transformRequest(data, headers) {
    normalizeHeaderName(headers, 'Accept');
    normalizeHeaderName(headers, 'Content-Type');
    if (utils.isFormData(data) ||
      utils.isArrayBuffer(data) ||
      utils.isBuffer(data) ||
      utils.isStream(data) ||
      utils.isFile(data) ||
      utils.isBlob(data)
    ) {
      return data;
    }
    if (utils.isArrayBufferView(data)) {
      return data.buffer;
    }
    if (utils.isURLSearchParams(data)) {
      setContentTypeIfUnset(headers, 'application/x-www-form-urlencoded;charset=utf-8');
      return data.toString();
    }
    if (utils.isObject(data)) {
      setContentTypeIfUnset(headers, 'application/json;charset=utf-8');
      return JSON.stringify(data);
    }
    return data;
  }],

  transformResponse: [function transformResponse(data) {
    /*eslint no-param-reassign:0*/
    if (typeof data === 'string') {
      try {
        data = JSON.parse(data);
      } catch (e) { /* Ignore */ }
    }
    return data;
  }],

  /**
   * A timeout in milliseconds to abort a request. If set to 0 (default) a
   * timeout is not created.
   */
  timeout: 0,

  xsrfCookieName: 'XSRF-TOKEN',
  xsrfHeaderName: 'X-XSRF-TOKEN',

  maxContentLength: -1,

  validateStatus: function validateStatus(status) {
    return status >= 200 && status < 300;
  }
};

defaults.headers = {
  common: {
    'Accept': 'application/json, text/plain, */*'
  }
};

utils.forEach(['delete', 'get', 'head'], function forEachMethodNoData(method) {
  defaults.headers[method] = {};
});

utils.forEach(['post', 'put', 'patch'], function forEachMethodWithData(method) {
  defaults.headers[method] = utils.merge(DEFAULT_CONTENT_TYPE);
});

module.exports = defaults;

/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! ./../../process/browser.js */ "./node_modules/process/browser.js")))

/***/ }),

/***/ "./node_modules/axios/lib/helpers/bind.js":
/*!************************************************!*\
  !*** ./node_modules/axios/lib/helpers/bind.js ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


module.exports = function bind(fn, thisArg) {
  return function wrap() {
    var args = new Array(arguments.length);
    for (var i = 0; i < args.length; i++) {
      args[i] = arguments[i];
    }
    return fn.apply(thisArg, args);
  };
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/buildURL.js":
/*!****************************************************!*\
  !*** ./node_modules/axios/lib/helpers/buildURL.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

function encode(val) {
  return encodeURIComponent(val).
    replace(/%40/gi, '@').
    replace(/%3A/gi, ':').
    replace(/%24/g, '$').
    replace(/%2C/gi, ',').
    replace(/%20/g, '+').
    replace(/%5B/gi, '[').
    replace(/%5D/gi, ']');
}

/**
 * Build a URL by appending params to the end
 *
 * @param {string} url The base of the url (e.g., http://www.google.com)
 * @param {object} [params] The params to be appended
 * @returns {string} The formatted url
 */
module.exports = function buildURL(url, params, paramsSerializer) {
  /*eslint no-param-reassign:0*/
  if (!params) {
    return url;
  }

  var serializedParams;
  if (paramsSerializer) {
    serializedParams = paramsSerializer(params);
  } else if (utils.isURLSearchParams(params)) {
    serializedParams = params.toString();
  } else {
    var parts = [];

    utils.forEach(params, function serialize(val, key) {
      if (val === null || typeof val === 'undefined') {
        return;
      }

      if (utils.isArray(val)) {
        key = key + '[]';
      } else {
        val = [val];
      }

      utils.forEach(val, function parseValue(v) {
        if (utils.isDate(v)) {
          v = v.toISOString();
        } else if (utils.isObject(v)) {
          v = JSON.stringify(v);
        }
        parts.push(encode(key) + '=' + encode(v));
      });
    });

    serializedParams = parts.join('&');
  }

  if (serializedParams) {
    var hashmarkIndex = url.indexOf('#');
    if (hashmarkIndex !== -1) {
      url = url.slice(0, hashmarkIndex);
    }

    url += (url.indexOf('?') === -1 ? '?' : '&') + serializedParams;
  }

  return url;
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/combineURLs.js":
/*!*******************************************************!*\
  !*** ./node_modules/axios/lib/helpers/combineURLs.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


/**
 * Creates a new URL by combining the specified URLs
 *
 * @param {string} baseURL The base URL
 * @param {string} relativeURL The relative URL
 * @returns {string} The combined URL
 */
module.exports = function combineURLs(baseURL, relativeURL) {
  return relativeURL
    ? baseURL.replace(/\/+$/, '') + '/' + relativeURL.replace(/^\/+/, '')
    : baseURL;
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/cookies.js":
/*!***************************************************!*\
  !*** ./node_modules/axios/lib/helpers/cookies.js ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

module.exports = (
  utils.isStandardBrowserEnv() ?

  // Standard browser envs support document.cookie
    (function standardBrowserEnv() {
      return {
        write: function write(name, value, expires, path, domain, secure) {
          var cookie = [];
          cookie.push(name + '=' + encodeURIComponent(value));

          if (utils.isNumber(expires)) {
            cookie.push('expires=' + new Date(expires).toGMTString());
          }

          if (utils.isString(path)) {
            cookie.push('path=' + path);
          }

          if (utils.isString(domain)) {
            cookie.push('domain=' + domain);
          }

          if (secure === true) {
            cookie.push('secure');
          }

          document.cookie = cookie.join('; ');
        },

        read: function read(name) {
          var match = document.cookie.match(new RegExp('(^|;\\s*)(' + name + ')=([^;]*)'));
          return (match ? decodeURIComponent(match[3]) : null);
        },

        remove: function remove(name) {
          this.write(name, '', Date.now() - 86400000);
        }
      };
    })() :

  // Non standard browser env (web workers, react-native) lack needed support.
    (function nonStandardBrowserEnv() {
      return {
        write: function write() {},
        read: function read() { return null; },
        remove: function remove() {}
      };
    })()
);


/***/ }),

/***/ "./node_modules/axios/lib/helpers/isAbsoluteURL.js":
/*!*********************************************************!*\
  !*** ./node_modules/axios/lib/helpers/isAbsoluteURL.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


/**
 * Determines whether the specified URL is absolute
 *
 * @param {string} url The URL to test
 * @returns {boolean} True if the specified URL is absolute, otherwise false
 */
module.exports = function isAbsoluteURL(url) {
  // A URL is considered absolute if it begins with "<scheme>://" or "//" (protocol-relative URL).
  // RFC 3986 defines scheme name as a sequence of characters beginning with a letter and followed
  // by any combination of letters, digits, plus, period, or hyphen.
  return /^([a-z][a-z\d\+\-\.]*:)?\/\//i.test(url);
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/isURLSameOrigin.js":
/*!***********************************************************!*\
  !*** ./node_modules/axios/lib/helpers/isURLSameOrigin.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

module.exports = (
  utils.isStandardBrowserEnv() ?

  // Standard browser envs have full support of the APIs needed to test
  // whether the request URL is of the same origin as current location.
    (function standardBrowserEnv() {
      var msie = /(msie|trident)/i.test(navigator.userAgent);
      var urlParsingNode = document.createElement('a');
      var originURL;

      /**
    * Parse a URL to discover it's components
    *
    * @param {String} url The URL to be parsed
    * @returns {Object}
    */
      function resolveURL(url) {
        var href = url;

        if (msie) {
        // IE needs attribute set twice to normalize properties
          urlParsingNode.setAttribute('href', href);
          href = urlParsingNode.href;
        }

        urlParsingNode.setAttribute('href', href);

        // urlParsingNode provides the UrlUtils interface - http://url.spec.whatwg.org/#urlutils
        return {
          href: urlParsingNode.href,
          protocol: urlParsingNode.protocol ? urlParsingNode.protocol.replace(/:$/, '') : '',
          host: urlParsingNode.host,
          search: urlParsingNode.search ? urlParsingNode.search.replace(/^\?/, '') : '',
          hash: urlParsingNode.hash ? urlParsingNode.hash.replace(/^#/, '') : '',
          hostname: urlParsingNode.hostname,
          port: urlParsingNode.port,
          pathname: (urlParsingNode.pathname.charAt(0) === '/') ?
            urlParsingNode.pathname :
            '/' + urlParsingNode.pathname
        };
      }

      originURL = resolveURL(window.location.href);

      /**
    * Determine if a URL shares the same origin as the current location
    *
    * @param {String} requestURL The URL to test
    * @returns {boolean} True if URL shares the same origin, otherwise false
    */
      return function isURLSameOrigin(requestURL) {
        var parsed = (utils.isString(requestURL)) ? resolveURL(requestURL) : requestURL;
        return (parsed.protocol === originURL.protocol &&
            parsed.host === originURL.host);
      };
    })() :

  // Non standard browser envs (web workers, react-native) lack needed support.
    (function nonStandardBrowserEnv() {
      return function isURLSameOrigin() {
        return true;
      };
    })()
);


/***/ }),

/***/ "./node_modules/axios/lib/helpers/normalizeHeaderName.js":
/*!***************************************************************!*\
  !*** ./node_modules/axios/lib/helpers/normalizeHeaderName.js ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ../utils */ "./node_modules/axios/lib/utils.js");

module.exports = function normalizeHeaderName(headers, normalizedName) {
  utils.forEach(headers, function processHeader(value, name) {
    if (name !== normalizedName && name.toUpperCase() === normalizedName.toUpperCase()) {
      headers[normalizedName] = value;
      delete headers[name];
    }
  });
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/parseHeaders.js":
/*!********************************************************!*\
  !*** ./node_modules/axios/lib/helpers/parseHeaders.js ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var utils = __webpack_require__(/*! ./../utils */ "./node_modules/axios/lib/utils.js");

// Headers whose duplicates are ignored by node
// c.f. https://nodejs.org/api/http.html#http_message_headers
var ignoreDuplicateOf = [
  'age', 'authorization', 'content-length', 'content-type', 'etag',
  'expires', 'from', 'host', 'if-modified-since', 'if-unmodified-since',
  'last-modified', 'location', 'max-forwards', 'proxy-authorization',
  'referer', 'retry-after', 'user-agent'
];

/**
 * Parse headers into an object
 *
 * ```
 * Date: Wed, 27 Aug 2014 08:58:49 GMT
 * Content-Type: application/json
 * Connection: keep-alive
 * Transfer-Encoding: chunked
 * ```
 *
 * @param {String} headers Headers needing to be parsed
 * @returns {Object} Headers parsed into an object
 */
module.exports = function parseHeaders(headers) {
  var parsed = {};
  var key;
  var val;
  var i;

  if (!headers) { return parsed; }

  utils.forEach(headers.split('\n'), function parser(line) {
    i = line.indexOf(':');
    key = utils.trim(line.substr(0, i)).toLowerCase();
    val = utils.trim(line.substr(i + 1));

    if (key) {
      if (parsed[key] && ignoreDuplicateOf.indexOf(key) >= 0) {
        return;
      }
      if (key === 'set-cookie') {
        parsed[key] = (parsed[key] ? parsed[key] : []).concat([val]);
      } else {
        parsed[key] = parsed[key] ? parsed[key] + ', ' + val : val;
      }
    }
  });

  return parsed;
};


/***/ }),

/***/ "./node_modules/axios/lib/helpers/spread.js":
/*!**************************************************!*\
  !*** ./node_modules/axios/lib/helpers/spread.js ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


/**
 * Syntactic sugar for invoking a function and expanding an array for arguments.
 *
 * Common use case would be to use `Function.prototype.apply`.
 *
 *  ```js
 *  function f(x, y, z) {}
 *  var args = [1, 2, 3];
 *  f.apply(null, args);
 *  ```
 *
 * With `spread` this example can be re-written.
 *
 *  ```js
 *  spread(function(x, y, z) {})([1, 2, 3]);
 *  ```
 *
 * @param {Function} callback
 * @returns {Function}
 */
module.exports = function spread(callback) {
  return function wrap(arr) {
    return callback.apply(null, arr);
  };
};


/***/ }),

/***/ "./node_modules/axios/lib/utils.js":
/*!*****************************************!*\
  !*** ./node_modules/axios/lib/utils.js ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var bind = __webpack_require__(/*! ./helpers/bind */ "./node_modules/axios/lib/helpers/bind.js");
var isBuffer = __webpack_require__(/*! is-buffer */ "./node_modules/axios/node_modules/is-buffer/index.js");

/*global toString:true*/

// utils is a library of generic helper functions non-specific to axios

var toString = Object.prototype.toString;

/**
 * Determine if a value is an Array
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is an Array, otherwise false
 */
function isArray(val) {
  return toString.call(val) === '[object Array]';
}

/**
 * Determine if a value is an ArrayBuffer
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is an ArrayBuffer, otherwise false
 */
function isArrayBuffer(val) {
  return toString.call(val) === '[object ArrayBuffer]';
}

/**
 * Determine if a value is a FormData
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is an FormData, otherwise false
 */
function isFormData(val) {
  return (typeof FormData !== 'undefined') && (val instanceof FormData);
}

/**
 * Determine if a value is a view on an ArrayBuffer
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a view on an ArrayBuffer, otherwise false
 */
function isArrayBufferView(val) {
  var result;
  if ((typeof ArrayBuffer !== 'undefined') && (ArrayBuffer.isView)) {
    result = ArrayBuffer.isView(val);
  } else {
    result = (val) && (val.buffer) && (val.buffer instanceof ArrayBuffer);
  }
  return result;
}

/**
 * Determine if a value is a String
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a String, otherwise false
 */
function isString(val) {
  return typeof val === 'string';
}

/**
 * Determine if a value is a Number
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a Number, otherwise false
 */
function isNumber(val) {
  return typeof val === 'number';
}

/**
 * Determine if a value is undefined
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if the value is undefined, otherwise false
 */
function isUndefined(val) {
  return typeof val === 'undefined';
}

/**
 * Determine if a value is an Object
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is an Object, otherwise false
 */
function isObject(val) {
  return val !== null && typeof val === 'object';
}

/**
 * Determine if a value is a Date
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a Date, otherwise false
 */
function isDate(val) {
  return toString.call(val) === '[object Date]';
}

/**
 * Determine if a value is a File
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a File, otherwise false
 */
function isFile(val) {
  return toString.call(val) === '[object File]';
}

/**
 * Determine if a value is a Blob
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a Blob, otherwise false
 */
function isBlob(val) {
  return toString.call(val) === '[object Blob]';
}

/**
 * Determine if a value is a Function
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a Function, otherwise false
 */
function isFunction(val) {
  return toString.call(val) === '[object Function]';
}

/**
 * Determine if a value is a Stream
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a Stream, otherwise false
 */
function isStream(val) {
  return isObject(val) && isFunction(val.pipe);
}

/**
 * Determine if a value is a URLSearchParams object
 *
 * @param {Object} val The value to test
 * @returns {boolean} True if value is a URLSearchParams object, otherwise false
 */
function isURLSearchParams(val) {
  return typeof URLSearchParams !== 'undefined' && val instanceof URLSearchParams;
}

/**
 * Trim excess whitespace off the beginning and end of a string
 *
 * @param {String} str The String to trim
 * @returns {String} The String freed of excess whitespace
 */
function trim(str) {
  return str.replace(/^\s*/, '').replace(/\s*$/, '');
}

/**
 * Determine if we're running in a standard browser environment
 *
 * This allows axios to run in a web worker, and react-native.
 * Both environments support XMLHttpRequest, but not fully standard globals.
 *
 * web workers:
 *  typeof window -> undefined
 *  typeof document -> undefined
 *
 * react-native:
 *  navigator.product -> 'ReactNative'
 * nativescript
 *  navigator.product -> 'NativeScript' or 'NS'
 */
function isStandardBrowserEnv() {
  if (typeof navigator !== 'undefined' && (navigator.product === 'ReactNative' ||
                                           navigator.product === 'NativeScript' ||
                                           navigator.product === 'NS')) {
    return false;
  }
  return (
     true &&
    typeof document !== 'undefined'
  );
}

/**
 * Iterate over an Array or an Object invoking a function for each item.
 *
 * If `obj` is an Array callback will be called passing
 * the value, index, and complete array for each item.
 *
 * If 'obj' is an Object callback will be called passing
 * the value, key, and complete object for each property.
 *
 * @param {Object|Array} obj The object to iterate
 * @param {Function} fn The callback to invoke for each item
 */
function forEach(obj, fn) {
  // Don't bother if no value provided
  if (obj === null || typeof obj === 'undefined') {
    return;
  }

  // Force an array if not already something iterable
  if (typeof obj !== 'object') {
    /*eslint no-param-reassign:0*/
    obj = [obj];
  }

  if (isArray(obj)) {
    // Iterate over array values
    for (var i = 0, l = obj.length; i < l; i++) {
      fn.call(null, obj[i], i, obj);
    }
  } else {
    // Iterate over object keys
    for (var key in obj) {
      if (Object.prototype.hasOwnProperty.call(obj, key)) {
        fn.call(null, obj[key], key, obj);
      }
    }
  }
}

/**
 * Accepts varargs expecting each argument to be an object, then
 * immutably merges the properties of each object and returns result.
 *
 * When multiple objects contain the same key the later object in
 * the arguments list will take precedence.
 *
 * Example:
 *
 * ```js
 * var result = merge({foo: 123}, {foo: 456});
 * console.log(result.foo); // outputs 456
 * ```
 *
 * @param {Object} obj1 Object to merge
 * @returns {Object} Result of all merge properties
 */
function merge(/* obj1, obj2, obj3, ... */) {
  var result = {};
  function assignValue(val, key) {
    if (typeof result[key] === 'object' && typeof val === 'object') {
      result[key] = merge(result[key], val);
    } else {
      result[key] = val;
    }
  }

  for (var i = 0, l = arguments.length; i < l; i++) {
    forEach(arguments[i], assignValue);
  }
  return result;
}

/**
 * Function equal to merge with the difference being that no reference
 * to original objects is kept.
 *
 * @see merge
 * @param {Object} obj1 Object to merge
 * @returns {Object} Result of all merge properties
 */
function deepMerge(/* obj1, obj2, obj3, ... */) {
  var result = {};
  function assignValue(val, key) {
    if (typeof result[key] === 'object' && typeof val === 'object') {
      result[key] = deepMerge(result[key], val);
    } else if (typeof val === 'object') {
      result[key] = deepMerge({}, val);
    } else {
      result[key] = val;
    }
  }

  for (var i = 0, l = arguments.length; i < l; i++) {
    forEach(arguments[i], assignValue);
  }
  return result;
}

/**
 * Extends object a by mutably adding to it the properties of object b.
 *
 * @param {Object} a The object to be extended
 * @param {Object} b The object to copy properties from
 * @param {Object} thisArg The object to bind function to
 * @return {Object} The resulting value of object a
 */
function extend(a, b, thisArg) {
  forEach(b, function assignValue(val, key) {
    if (thisArg && typeof val === 'function') {
      a[key] = bind(val, thisArg);
    } else {
      a[key] = val;
    }
  });
  return a;
}

module.exports = {
  isArray: isArray,
  isArrayBuffer: isArrayBuffer,
  isBuffer: isBuffer,
  isFormData: isFormData,
  isArrayBufferView: isArrayBufferView,
  isString: isString,
  isNumber: isNumber,
  isObject: isObject,
  isUndefined: isUndefined,
  isDate: isDate,
  isFile: isFile,
  isBlob: isBlob,
  isFunction: isFunction,
  isStream: isStream,
  isURLSearchParams: isURLSearchParams,
  isStandardBrowserEnv: isStandardBrowserEnv,
  forEach: forEach,
  merge: merge,
  deepMerge: deepMerge,
  extend: extend,
  trim: trim
};


/***/ }),

/***/ "./node_modules/axios/node_modules/is-buffer/index.js":
/*!************************************************************!*\
  !*** ./node_modules/axios/node_modules/is-buffer/index.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

/*!
 * Determine if an object is a Buffer
 *
 * @author   Feross Aboukhadijeh <https://feross.org>
 * @license  MIT
 */

module.exports = function isBuffer (obj) {
  return obj != null && obj.constructor != null &&
    typeof obj.constructor.isBuffer === 'function' && obj.constructor.isBuffer(obj)
}


/***/ }),

/***/ "./node_modules/copy-to-clipboard/index.js":
/*!*************************************************!*\
  !*** ./node_modules/copy-to-clipboard/index.js ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var deselectCurrent = __webpack_require__(/*! toggle-selection */ "./node_modules/toggle-selection/index.js");

var defaultMessage = "Copy to clipboard: #{key}, Enter";

function format(message) {
  var copyKey = (/mac os x/i.test(navigator.userAgent) ? "⌘" : "Ctrl") + "+C";
  return message.replace(/#{\s*key\s*}/g, copyKey);
}

function copy(text, options) {
  var debug,
    message,
    reselectPrevious,
    range,
    selection,
    mark,
    success = false;
  if (!options) {
    options = {};
  }
  debug = options.debug || false;
  try {
    reselectPrevious = deselectCurrent();

    range = document.createRange();
    selection = document.getSelection();

    mark = document.createElement("span");
    mark.textContent = text;
    // reset user styles for span element
    mark.style.all = "unset";
    // prevents scrolling to the end of the page
    mark.style.position = "fixed";
    mark.style.top = 0;
    mark.style.clip = "rect(0, 0, 0, 0)";
    // used to preserve spaces and line breaks
    mark.style.whiteSpace = "pre";
    // do not inherit user-select (it may be `none`)
    mark.style.webkitUserSelect = "text";
    mark.style.MozUserSelect = "text";
    mark.style.msUserSelect = "text";
    mark.style.userSelect = "text";
    mark.addEventListener("copy", function(e) {
      e.stopPropagation();
      if (options.format) {
        e.preventDefault();
        e.clipboardData.clearData();
        e.clipboardData.setData(options.format, text);
      }
    });

    document.body.appendChild(mark);

    range.selectNodeContents(mark);
    selection.addRange(range);

    var successful = document.execCommand("copy");
    if (!successful) {
      throw new Error("copy command was unsuccessful");
    }
    success = true;
  } catch (err) {
    debug && console.error("unable to copy using execCommand: ", err);
    debug && console.warn("trying IE specific stuff");
    try {
      window.clipboardData.setData(options.format || "text", text);
      success = true;
    } catch (err) {
      debug && console.error("unable to copy using clipboardData: ", err);
      debug && console.error("falling back to prompt");
      message = format("message" in options ? options.message : defaultMessage);
      window.prompt(message, text);
    }
  } finally {
    if (selection) {
      if (typeof selection.removeRange == "function") {
        selection.removeRange(range);
      } else {
        selection.removeAllRanges();
      }
    }

    if (mark) {
      document.body.removeChild(mark);
    }
    reselectPrevious();
  }

  return success;
}

module.exports = copy;


/***/ }),

/***/ "./node_modules/core-js/library/fn/array/from.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/fn/array/from.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.string.iterator */ "./node_modules/core-js/library/modules/es6.string.iterator.js");
__webpack_require__(/*! ../../modules/es6.array.from */ "./node_modules/core-js/library/modules/es6.array.from.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Array.from;


/***/ }),

/***/ "./node_modules/core-js/library/fn/array/is-array.js":
/*!***********************************************************!*\
  !*** ./node_modules/core-js/library/fn/array/is-array.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.array.is-array */ "./node_modules/core-js/library/modules/es6.array.is-array.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Array.isArray;


/***/ }),

/***/ "./node_modules/core-js/library/fn/get-iterator.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/fn/get-iterator.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../modules/web.dom.iterable */ "./node_modules/core-js/library/modules/web.dom.iterable.js");
__webpack_require__(/*! ../modules/es6.string.iterator */ "./node_modules/core-js/library/modules/es6.string.iterator.js");
module.exports = __webpack_require__(/*! ../modules/core.get-iterator */ "./node_modules/core-js/library/modules/core.get-iterator.js");


/***/ }),

/***/ "./node_modules/core-js/library/fn/is-iterable.js":
/*!********************************************************!*\
  !*** ./node_modules/core-js/library/fn/is-iterable.js ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../modules/web.dom.iterable */ "./node_modules/core-js/library/modules/web.dom.iterable.js");
__webpack_require__(/*! ../modules/es6.string.iterator */ "./node_modules/core-js/library/modules/es6.string.iterator.js");
module.exports = __webpack_require__(/*! ../modules/core.is-iterable */ "./node_modules/core-js/library/modules/core.is-iterable.js");


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/assign.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/assign.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.assign */ "./node_modules/core-js/library/modules/es6.object.assign.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object.assign;


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/create.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/create.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.create */ "./node_modules/core-js/library/modules/es6.object.create.js");
var $Object = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object;
module.exports = function create(P, D) {
  return $Object.create(P, D);
};


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/define-property.js":
/*!*******************************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/define-property.js ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.define-property */ "./node_modules/core-js/library/modules/es6.object.define-property.js");
var $Object = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object;
module.exports = function defineProperty(it, key, desc) {
  return $Object.defineProperty(it, key, desc);
};


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/get-own-property-descriptor.js":
/*!*******************************************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/get-own-property-descriptor.js ***!
  \*******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.get-own-property-descriptor */ "./node_modules/core-js/library/modules/es6.object.get-own-property-descriptor.js");
var $Object = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object;
module.exports = function getOwnPropertyDescriptor(it, key) {
  return $Object.getOwnPropertyDescriptor(it, key);
};


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/get-own-property-symbols.js":
/*!****************************************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/get-own-property-symbols.js ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.symbol */ "./node_modules/core-js/library/modules/es6.symbol.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object.getOwnPropertySymbols;


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/get-prototype-of.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/get-prototype-of.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.get-prototype-of */ "./node_modules/core-js/library/modules/es6.object.get-prototype-of.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object.getPrototypeOf;


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/keys.js":
/*!********************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/keys.js ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.keys */ "./node_modules/core-js/library/modules/es6.object.keys.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object.keys;


/***/ }),

/***/ "./node_modules/core-js/library/fn/object/set-prototype-of.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/fn/object/set-prototype-of.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.object.set-prototype-of */ "./node_modules/core-js/library/modules/es6.object.set-prototype-of.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Object.setPrototypeOf;


/***/ }),

/***/ "./node_modules/core-js/library/fn/promise.js":
/*!****************************************************!*\
  !*** ./node_modules/core-js/library/fn/promise.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../modules/es6.object.to-string */ "./node_modules/core-js/library/modules/es6.object.to-string.js");
__webpack_require__(/*! ../modules/es6.string.iterator */ "./node_modules/core-js/library/modules/es6.string.iterator.js");
__webpack_require__(/*! ../modules/web.dom.iterable */ "./node_modules/core-js/library/modules/web.dom.iterable.js");
__webpack_require__(/*! ../modules/es6.promise */ "./node_modules/core-js/library/modules/es6.promise.js");
__webpack_require__(/*! ../modules/es7.promise.finally */ "./node_modules/core-js/library/modules/es7.promise.finally.js");
__webpack_require__(/*! ../modules/es7.promise.try */ "./node_modules/core-js/library/modules/es7.promise.try.js");
module.exports = __webpack_require__(/*! ../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Promise;


/***/ }),

/***/ "./node_modules/core-js/library/fn/reflect/construct.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/fn/reflect/construct.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.reflect.construct */ "./node_modules/core-js/library/modules/es6.reflect.construct.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Reflect.construct;


/***/ }),

/***/ "./node_modules/core-js/library/fn/symbol/index.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/fn/symbol/index.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.symbol */ "./node_modules/core-js/library/modules/es6.symbol.js");
__webpack_require__(/*! ../../modules/es6.object.to-string */ "./node_modules/core-js/library/modules/es6.object.to-string.js");
__webpack_require__(/*! ../../modules/es7.symbol.async-iterator */ "./node_modules/core-js/library/modules/es7.symbol.async-iterator.js");
__webpack_require__(/*! ../../modules/es7.symbol.observable */ "./node_modules/core-js/library/modules/es7.symbol.observable.js");
module.exports = __webpack_require__(/*! ../../modules/_core */ "./node_modules/core-js/library/modules/_core.js").Symbol;


/***/ }),

/***/ "./node_modules/core-js/library/fn/symbol/iterator.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/fn/symbol/iterator.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ../../modules/es6.string.iterator */ "./node_modules/core-js/library/modules/es6.string.iterator.js");
__webpack_require__(/*! ../../modules/web.dom.iterable */ "./node_modules/core-js/library/modules/web.dom.iterable.js");
module.exports = __webpack_require__(/*! ../../modules/_wks-ext */ "./node_modules/core-js/library/modules/_wks-ext.js").f('iterator');


/***/ }),

/***/ "./node_modules/core-js/library/modules/_a-function.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_a-function.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (it) {
  if (typeof it != 'function') throw TypeError(it + ' is not a function!');
  return it;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_add-to-unscopables.js":
/*!*********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_add-to-unscopables.js ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function () { /* empty */ };


/***/ }),

/***/ "./node_modules/core-js/library/modules/_an-instance.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_an-instance.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (it, Constructor, name, forbiddenField) {
  if (!(it instanceof Constructor) || (forbiddenField !== undefined && forbiddenField in it)) {
    throw TypeError(name + ': incorrect invocation!');
  } return it;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_an-object.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_an-object.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
module.exports = function (it) {
  if (!isObject(it)) throw TypeError(it + ' is not an object!');
  return it;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_array-includes.js":
/*!*****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_array-includes.js ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// false -> Array#indexOf
// true  -> Array#includes
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var toLength = __webpack_require__(/*! ./_to-length */ "./node_modules/core-js/library/modules/_to-length.js");
var toAbsoluteIndex = __webpack_require__(/*! ./_to-absolute-index */ "./node_modules/core-js/library/modules/_to-absolute-index.js");
module.exports = function (IS_INCLUDES) {
  return function ($this, el, fromIndex) {
    var O = toIObject($this);
    var length = toLength(O.length);
    var index = toAbsoluteIndex(fromIndex, length);
    var value;
    // Array#includes uses SameValueZero equality algorithm
    // eslint-disable-next-line no-self-compare
    if (IS_INCLUDES && el != el) while (length > index) {
      value = O[index++];
      // eslint-disable-next-line no-self-compare
      if (value != value) return true;
    // Array#indexOf ignores holes, Array#includes - not
    } else for (;length > index; index++) if (IS_INCLUDES || index in O) {
      if (O[index] === el) return IS_INCLUDES || index || 0;
    } return !IS_INCLUDES && -1;
  };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_bind.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_bind.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var invoke = __webpack_require__(/*! ./_invoke */ "./node_modules/core-js/library/modules/_invoke.js");
var arraySlice = [].slice;
var factories = {};

var construct = function (F, len, args) {
  if (!(len in factories)) {
    for (var n = [], i = 0; i < len; i++) n[i] = 'a[' + i + ']';
    // eslint-disable-next-line no-new-func
    factories[len] = Function('F,a', 'return new F(' + n.join(',') + ')');
  } return factories[len](F, args);
};

module.exports = Function.bind || function bind(that /* , ...args */) {
  var fn = aFunction(this);
  var partArgs = arraySlice.call(arguments, 1);
  var bound = function (/* args... */) {
    var args = partArgs.concat(arraySlice.call(arguments));
    return this instanceof bound ? construct(fn, args.length, args) : invoke(fn, args, that);
  };
  if (isObject(fn.prototype)) bound.prototype = fn.prototype;
  return bound;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_classof.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_classof.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// getting tag from 19.1.3.6 Object.prototype.toString()
var cof = __webpack_require__(/*! ./_cof */ "./node_modules/core-js/library/modules/_cof.js");
var TAG = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('toStringTag');
// ES3 wrong here
var ARG = cof(function () { return arguments; }()) == 'Arguments';

// fallback for IE11 Script Access Denied error
var tryGet = function (it, key) {
  try {
    return it[key];
  } catch (e) { /* empty */ }
};

module.exports = function (it) {
  var O, T, B;
  return it === undefined ? 'Undefined' : it === null ? 'Null'
    // @@toStringTag case
    : typeof (T = tryGet(O = Object(it), TAG)) == 'string' ? T
    // builtinTag case
    : ARG ? cof(O)
    // ES3 arguments fallback
    : (B = cof(O)) == 'Object' && typeof O.callee == 'function' ? 'Arguments' : B;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_cof.js":
/*!******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_cof.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

var toString = {}.toString;

module.exports = function (it) {
  return toString.call(it).slice(8, -1);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_core.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_core.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

var core = module.exports = { version: '2.6.9' };
if (typeof __e == 'number') __e = core; // eslint-disable-line no-undef


/***/ }),

/***/ "./node_modules/core-js/library/modules/_create-property.js":
/*!******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_create-property.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var $defineProperty = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js");
var createDesc = __webpack_require__(/*! ./_property-desc */ "./node_modules/core-js/library/modules/_property-desc.js");

module.exports = function (object, index, value) {
  if (index in object) $defineProperty.f(object, index, createDesc(0, value));
  else object[index] = value;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_ctx.js":
/*!******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_ctx.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// optional / simple context binding
var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");
module.exports = function (fn, that, length) {
  aFunction(fn);
  if (that === undefined) return fn;
  switch (length) {
    case 1: return function (a) {
      return fn.call(that, a);
    };
    case 2: return function (a, b) {
      return fn.call(that, a, b);
    };
    case 3: return function (a, b, c) {
      return fn.call(that, a, b, c);
    };
  }
  return function (/* ...args */) {
    return fn.apply(that, arguments);
  };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_defined.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_defined.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

// 7.2.1 RequireObjectCoercible(argument)
module.exports = function (it) {
  if (it == undefined) throw TypeError("Can't call method on  " + it);
  return it;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_descriptors.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_descriptors.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Thank's IE8 for his funny defineProperty
module.exports = !__webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js")(function () {
  return Object.defineProperty({}, 'a', { get: function () { return 7; } }).a != 7;
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/_dom-create.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_dom-create.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var document = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js").document;
// typeof document.createElement is 'object' in old IE
var is = isObject(document) && isObject(document.createElement);
module.exports = function (it) {
  return is ? document.createElement(it) : {};
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_enum-bug-keys.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_enum-bug-keys.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

// IE 8- don't enum bug keys
module.exports = (
  'constructor,hasOwnProperty,isPrototypeOf,propertyIsEnumerable,toLocaleString,toString,valueOf'
).split(',');


/***/ }),

/***/ "./node_modules/core-js/library/modules/_enum-keys.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_enum-keys.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// all enumerable object keys, includes symbols
var getKeys = __webpack_require__(/*! ./_object-keys */ "./node_modules/core-js/library/modules/_object-keys.js");
var gOPS = __webpack_require__(/*! ./_object-gops */ "./node_modules/core-js/library/modules/_object-gops.js");
var pIE = __webpack_require__(/*! ./_object-pie */ "./node_modules/core-js/library/modules/_object-pie.js");
module.exports = function (it) {
  var result = getKeys(it);
  var getSymbols = gOPS.f;
  if (getSymbols) {
    var symbols = getSymbols(it);
    var isEnum = pIE.f;
    var i = 0;
    var key;
    while (symbols.length > i) if (isEnum.call(it, key = symbols[i++])) result.push(key);
  } return result;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_export.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_export.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var ctx = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js");
var hide = __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js");
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var PROTOTYPE = 'prototype';

var $export = function (type, name, source) {
  var IS_FORCED = type & $export.F;
  var IS_GLOBAL = type & $export.G;
  var IS_STATIC = type & $export.S;
  var IS_PROTO = type & $export.P;
  var IS_BIND = type & $export.B;
  var IS_WRAP = type & $export.W;
  var exports = IS_GLOBAL ? core : core[name] || (core[name] = {});
  var expProto = exports[PROTOTYPE];
  var target = IS_GLOBAL ? global : IS_STATIC ? global[name] : (global[name] || {})[PROTOTYPE];
  var key, own, out;
  if (IS_GLOBAL) source = name;
  for (key in source) {
    // contains in native
    own = !IS_FORCED && target && target[key] !== undefined;
    if (own && has(exports, key)) continue;
    // export native or passed
    out = own ? target[key] : source[key];
    // prevent global pollution for namespaces
    exports[key] = IS_GLOBAL && typeof target[key] != 'function' ? source[key]
    // bind timers to global for call from export context
    : IS_BIND && own ? ctx(out, global)
    // wrap global constructors for prevent change them in library
    : IS_WRAP && target[key] == out ? (function (C) {
      var F = function (a, b, c) {
        if (this instanceof C) {
          switch (arguments.length) {
            case 0: return new C();
            case 1: return new C(a);
            case 2: return new C(a, b);
          } return new C(a, b, c);
        } return C.apply(this, arguments);
      };
      F[PROTOTYPE] = C[PROTOTYPE];
      return F;
    // make static versions for prototype methods
    })(out) : IS_PROTO && typeof out == 'function' ? ctx(Function.call, out) : out;
    // export proto methods to core.%CONSTRUCTOR%.methods.%NAME%
    if (IS_PROTO) {
      (exports.virtual || (exports.virtual = {}))[key] = out;
      // export proto methods to core.%CONSTRUCTOR%.prototype.%NAME%
      if (type & $export.R && expProto && !expProto[key]) hide(expProto, key, out);
    }
  }
};
// type bitmap
$export.F = 1;   // forced
$export.G = 2;   // global
$export.S = 4;   // static
$export.P = 8;   // proto
$export.B = 16;  // bind
$export.W = 32;  // wrap
$export.U = 64;  // safe
$export.R = 128; // real proto method for `library`
module.exports = $export;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_fails.js":
/*!********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_fails.js ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (exec) {
  try {
    return !!exec();
  } catch (e) {
    return true;
  }
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_for-of.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_for-of.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var ctx = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js");
var call = __webpack_require__(/*! ./_iter-call */ "./node_modules/core-js/library/modules/_iter-call.js");
var isArrayIter = __webpack_require__(/*! ./_is-array-iter */ "./node_modules/core-js/library/modules/_is-array-iter.js");
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var toLength = __webpack_require__(/*! ./_to-length */ "./node_modules/core-js/library/modules/_to-length.js");
var getIterFn = __webpack_require__(/*! ./core.get-iterator-method */ "./node_modules/core-js/library/modules/core.get-iterator-method.js");
var BREAK = {};
var RETURN = {};
var exports = module.exports = function (iterable, entries, fn, that, ITERATOR) {
  var iterFn = ITERATOR ? function () { return iterable; } : getIterFn(iterable);
  var f = ctx(fn, that, entries ? 2 : 1);
  var index = 0;
  var length, step, iterator, result;
  if (typeof iterFn != 'function') throw TypeError(iterable + ' is not iterable!');
  // fast case for arrays with default iterator
  if (isArrayIter(iterFn)) for (length = toLength(iterable.length); length > index; index++) {
    result = entries ? f(anObject(step = iterable[index])[0], step[1]) : f(iterable[index]);
    if (result === BREAK || result === RETURN) return result;
  } else for (iterator = iterFn.call(iterable); !(step = iterator.next()).done;) {
    result = call(iterator, f, step.value, entries);
    if (result === BREAK || result === RETURN) return result;
  }
};
exports.BREAK = BREAK;
exports.RETURN = RETURN;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_global.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_global.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// https://github.com/zloirock/core-js/issues/86#issuecomment-115759028
var global = module.exports =  true && window.Math == Math
  ? window : typeof self != 'undefined' && self.Math == Math ? self
  // eslint-disable-next-line no-new-func
  : Function('return this')();
if (typeof __g == 'number') __g = global; // eslint-disable-line no-undef


/***/ }),

/***/ "./node_modules/core-js/library/modules/_has.js":
/*!******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_has.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

var hasOwnProperty = {}.hasOwnProperty;
module.exports = function (it, key) {
  return hasOwnProperty.call(it, key);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_hide.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_hide.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var dP = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js");
var createDesc = __webpack_require__(/*! ./_property-desc */ "./node_modules/core-js/library/modules/_property-desc.js");
module.exports = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js") ? function (object, key, value) {
  return dP.f(object, key, createDesc(1, value));
} : function (object, key, value) {
  object[key] = value;
  return object;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_html.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_html.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var document = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js").document;
module.exports = document && document.documentElement;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_ie8-dom-define.js":
/*!*****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_ie8-dom-define.js ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = !__webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js") && !__webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js")(function () {
  return Object.defineProperty(__webpack_require__(/*! ./_dom-create */ "./node_modules/core-js/library/modules/_dom-create.js")('div'), 'a', { get: function () { return 7; } }).a != 7;
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/_invoke.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_invoke.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

// fast apply, http://jsperf.lnkit.com/fast-apply/5
module.exports = function (fn, args, that) {
  var un = that === undefined;
  switch (args.length) {
    case 0: return un ? fn()
                      : fn.call(that);
    case 1: return un ? fn(args[0])
                      : fn.call(that, args[0]);
    case 2: return un ? fn(args[0], args[1])
                      : fn.call(that, args[0], args[1]);
    case 3: return un ? fn(args[0], args[1], args[2])
                      : fn.call(that, args[0], args[1], args[2]);
    case 4: return un ? fn(args[0], args[1], args[2], args[3])
                      : fn.call(that, args[0], args[1], args[2], args[3]);
  } return fn.apply(that, args);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iobject.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iobject.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// fallback for non-array-like ES3 and non-enumerable old V8 strings
var cof = __webpack_require__(/*! ./_cof */ "./node_modules/core-js/library/modules/_cof.js");
// eslint-disable-next-line no-prototype-builtins
module.exports = Object('z').propertyIsEnumerable(0) ? Object : function (it) {
  return cof(it) == 'String' ? it.split('') : Object(it);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_is-array-iter.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_is-array-iter.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// check on default Array iterator
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
var ITERATOR = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator');
var ArrayProto = Array.prototype;

module.exports = function (it) {
  return it !== undefined && (Iterators.Array === it || ArrayProto[ITERATOR] === it);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_is-array.js":
/*!***********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_is-array.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 7.2.2 IsArray(argument)
var cof = __webpack_require__(/*! ./_cof */ "./node_modules/core-js/library/modules/_cof.js");
module.exports = Array.isArray || function isArray(arg) {
  return cof(arg) == 'Array';
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_is-object.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_is-object.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (it) {
  return typeof it === 'object' ? it !== null : typeof it === 'function';
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iter-call.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iter-call.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// call something on iterator step with safe closing on error
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
module.exports = function (iterator, fn, value, entries) {
  try {
    return entries ? fn(anObject(value)[0], value[1]) : fn(value);
  // 7.4.6 IteratorClose(iterator, completion)
  } catch (e) {
    var ret = iterator['return'];
    if (ret !== undefined) anObject(ret.call(iterator));
    throw e;
  }
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iter-create.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iter-create.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var create = __webpack_require__(/*! ./_object-create */ "./node_modules/core-js/library/modules/_object-create.js");
var descriptor = __webpack_require__(/*! ./_property-desc */ "./node_modules/core-js/library/modules/_property-desc.js");
var setToStringTag = __webpack_require__(/*! ./_set-to-string-tag */ "./node_modules/core-js/library/modules/_set-to-string-tag.js");
var IteratorPrototype = {};

// 25.1.2.1.1 %IteratorPrototype%[@@iterator]()
__webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js")(IteratorPrototype, __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator'), function () { return this; });

module.exports = function (Constructor, NAME, next) {
  Constructor.prototype = create(IteratorPrototype, { next: descriptor(1, next) });
  setToStringTag(Constructor, NAME + ' Iterator');
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iter-define.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iter-define.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var LIBRARY = __webpack_require__(/*! ./_library */ "./node_modules/core-js/library/modules/_library.js");
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var redefine = __webpack_require__(/*! ./_redefine */ "./node_modules/core-js/library/modules/_redefine.js");
var hide = __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js");
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
var $iterCreate = __webpack_require__(/*! ./_iter-create */ "./node_modules/core-js/library/modules/_iter-create.js");
var setToStringTag = __webpack_require__(/*! ./_set-to-string-tag */ "./node_modules/core-js/library/modules/_set-to-string-tag.js");
var getPrototypeOf = __webpack_require__(/*! ./_object-gpo */ "./node_modules/core-js/library/modules/_object-gpo.js");
var ITERATOR = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator');
var BUGGY = !([].keys && 'next' in [].keys()); // Safari has buggy iterators w/o `next`
var FF_ITERATOR = '@@iterator';
var KEYS = 'keys';
var VALUES = 'values';

var returnThis = function () { return this; };

module.exports = function (Base, NAME, Constructor, next, DEFAULT, IS_SET, FORCED) {
  $iterCreate(Constructor, NAME, next);
  var getMethod = function (kind) {
    if (!BUGGY && kind in proto) return proto[kind];
    switch (kind) {
      case KEYS: return function keys() { return new Constructor(this, kind); };
      case VALUES: return function values() { return new Constructor(this, kind); };
    } return function entries() { return new Constructor(this, kind); };
  };
  var TAG = NAME + ' Iterator';
  var DEF_VALUES = DEFAULT == VALUES;
  var VALUES_BUG = false;
  var proto = Base.prototype;
  var $native = proto[ITERATOR] || proto[FF_ITERATOR] || DEFAULT && proto[DEFAULT];
  var $default = $native || getMethod(DEFAULT);
  var $entries = DEFAULT ? !DEF_VALUES ? $default : getMethod('entries') : undefined;
  var $anyNative = NAME == 'Array' ? proto.entries || $native : $native;
  var methods, key, IteratorPrototype;
  // Fix native
  if ($anyNative) {
    IteratorPrototype = getPrototypeOf($anyNative.call(new Base()));
    if (IteratorPrototype !== Object.prototype && IteratorPrototype.next) {
      // Set @@toStringTag to native iterators
      setToStringTag(IteratorPrototype, TAG, true);
      // fix for some old engines
      if (!LIBRARY && typeof IteratorPrototype[ITERATOR] != 'function') hide(IteratorPrototype, ITERATOR, returnThis);
    }
  }
  // fix Array#{values, @@iterator}.name in V8 / FF
  if (DEF_VALUES && $native && $native.name !== VALUES) {
    VALUES_BUG = true;
    $default = function values() { return $native.call(this); };
  }
  // Define iterator
  if ((!LIBRARY || FORCED) && (BUGGY || VALUES_BUG || !proto[ITERATOR])) {
    hide(proto, ITERATOR, $default);
  }
  // Plug for library
  Iterators[NAME] = $default;
  Iterators[TAG] = returnThis;
  if (DEFAULT) {
    methods = {
      values: DEF_VALUES ? $default : getMethod(VALUES),
      keys: IS_SET ? $default : getMethod(KEYS),
      entries: $entries
    };
    if (FORCED) for (key in methods) {
      if (!(key in proto)) redefine(proto, key, methods[key]);
    } else $export($export.P + $export.F * (BUGGY || VALUES_BUG), NAME, methods);
  }
  return methods;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iter-detect.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iter-detect.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var ITERATOR = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator');
var SAFE_CLOSING = false;

try {
  var riter = [7][ITERATOR]();
  riter['return'] = function () { SAFE_CLOSING = true; };
  // eslint-disable-next-line no-throw-literal
  Array.from(riter, function () { throw 2; });
} catch (e) { /* empty */ }

module.exports = function (exec, skipClosing) {
  if (!skipClosing && !SAFE_CLOSING) return false;
  var safe = false;
  try {
    var arr = [7];
    var iter = arr[ITERATOR]();
    iter.next = function () { return { done: safe = true }; };
    arr[ITERATOR] = function () { return iter; };
    exec(arr);
  } catch (e) { /* empty */ }
  return safe;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iter-step.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iter-step.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (done, value) {
  return { value: value, done: !!done };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_iterators.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_iterators.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = {};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_library.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_library.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = true;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_meta.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_meta.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var META = __webpack_require__(/*! ./_uid */ "./node_modules/core-js/library/modules/_uid.js")('meta');
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var setDesc = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js").f;
var id = 0;
var isExtensible = Object.isExtensible || function () {
  return true;
};
var FREEZE = !__webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js")(function () {
  return isExtensible(Object.preventExtensions({}));
});
var setMeta = function (it) {
  setDesc(it, META, { value: {
    i: 'O' + ++id, // object ID
    w: {}          // weak collections IDs
  } });
};
var fastKey = function (it, create) {
  // return primitive with prefix
  if (!isObject(it)) return typeof it == 'symbol' ? it : (typeof it == 'string' ? 'S' : 'P') + it;
  if (!has(it, META)) {
    // can't set metadata to uncaught frozen object
    if (!isExtensible(it)) return 'F';
    // not necessary to add metadata
    if (!create) return 'E';
    // add missing metadata
    setMeta(it);
  // return object ID
  } return it[META].i;
};
var getWeak = function (it, create) {
  if (!has(it, META)) {
    // can't set metadata to uncaught frozen object
    if (!isExtensible(it)) return true;
    // not necessary to add metadata
    if (!create) return false;
    // add missing metadata
    setMeta(it);
  // return hash weak collections IDs
  } return it[META].w;
};
// add metadata on freeze-family methods calling
var onFreeze = function (it) {
  if (FREEZE && meta.NEED && isExtensible(it) && !has(it, META)) setMeta(it);
  return it;
};
var meta = module.exports = {
  KEY: META,
  NEED: false,
  fastKey: fastKey,
  getWeak: getWeak,
  onFreeze: onFreeze
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_microtask.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_microtask.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var macrotask = __webpack_require__(/*! ./_task */ "./node_modules/core-js/library/modules/_task.js").set;
var Observer = global.MutationObserver || global.WebKitMutationObserver;
var process = global.process;
var Promise = global.Promise;
var isNode = __webpack_require__(/*! ./_cof */ "./node_modules/core-js/library/modules/_cof.js")(process) == 'process';

module.exports = function () {
  var head, last, notify;

  var flush = function () {
    var parent, fn;
    if (isNode && (parent = process.domain)) parent.exit();
    while (head) {
      fn = head.fn;
      head = head.next;
      try {
        fn();
      } catch (e) {
        if (head) notify();
        else last = undefined;
        throw e;
      }
    } last = undefined;
    if (parent) parent.enter();
  };

  // Node.js
  if (isNode) {
    notify = function () {
      process.nextTick(flush);
    };
  // browsers with MutationObserver, except iOS Safari - https://github.com/zloirock/core-js/issues/339
  } else if (Observer && !(global.navigator && global.navigator.standalone)) {
    var toggle = true;
    var node = document.createTextNode('');
    new Observer(flush).observe(node, { characterData: true }); // eslint-disable-line no-new
    notify = function () {
      node.data = toggle = !toggle;
    };
  // environments with maybe non-completely correct, but existent Promise
  } else if (Promise && Promise.resolve) {
    // Promise.resolve without an argument throws an error in LG WebOS 2
    var promise = Promise.resolve(undefined);
    notify = function () {
      promise.then(flush);
    };
  // for other environments - macrotask based on:
  // - setImmediate
  // - MessageChannel
  // - window.postMessag
  // - onreadystatechange
  // - setTimeout
  } else {
    notify = function () {
      // strange IE + webpack dev server bug - use .call(global)
      macrotask.call(global, flush);
    };
  }

  return function (fn) {
    var task = { fn: fn, next: undefined };
    if (last) last.next = task;
    if (!head) {
      head = task;
      notify();
    } last = task;
  };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_new-promise-capability.js":
/*!*************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_new-promise-capability.js ***!
  \*************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// 25.4.1.5 NewPromiseCapability(C)
var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");

function PromiseCapability(C) {
  var resolve, reject;
  this.promise = new C(function ($$resolve, $$reject) {
    if (resolve !== undefined || reject !== undefined) throw TypeError('Bad Promise constructor');
    resolve = $$resolve;
    reject = $$reject;
  });
  this.resolve = aFunction(resolve);
  this.reject = aFunction(reject);
}

module.exports.f = function (C) {
  return new PromiseCapability(C);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-assign.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-assign.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// 19.1.2.1 Object.assign(target, source, ...)
var DESCRIPTORS = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js");
var getKeys = __webpack_require__(/*! ./_object-keys */ "./node_modules/core-js/library/modules/_object-keys.js");
var gOPS = __webpack_require__(/*! ./_object-gops */ "./node_modules/core-js/library/modules/_object-gops.js");
var pIE = __webpack_require__(/*! ./_object-pie */ "./node_modules/core-js/library/modules/_object-pie.js");
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var IObject = __webpack_require__(/*! ./_iobject */ "./node_modules/core-js/library/modules/_iobject.js");
var $assign = Object.assign;

// should work with symbols and should have deterministic property order (V8 bug)
module.exports = !$assign || __webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js")(function () {
  var A = {};
  var B = {};
  // eslint-disable-next-line no-undef
  var S = Symbol();
  var K = 'abcdefghijklmnopqrst';
  A[S] = 7;
  K.split('').forEach(function (k) { B[k] = k; });
  return $assign({}, A)[S] != 7 || Object.keys($assign({}, B)).join('') != K;
}) ? function assign(target, source) { // eslint-disable-line no-unused-vars
  var T = toObject(target);
  var aLen = arguments.length;
  var index = 1;
  var getSymbols = gOPS.f;
  var isEnum = pIE.f;
  while (aLen > index) {
    var S = IObject(arguments[index++]);
    var keys = getSymbols ? getKeys(S).concat(getSymbols(S)) : getKeys(S);
    var length = keys.length;
    var j = 0;
    var key;
    while (length > j) {
      key = keys[j++];
      if (!DESCRIPTORS || isEnum.call(S, key)) T[key] = S[key];
    }
  } return T;
} : $assign;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-create.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-create.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var dPs = __webpack_require__(/*! ./_object-dps */ "./node_modules/core-js/library/modules/_object-dps.js");
var enumBugKeys = __webpack_require__(/*! ./_enum-bug-keys */ "./node_modules/core-js/library/modules/_enum-bug-keys.js");
var IE_PROTO = __webpack_require__(/*! ./_shared-key */ "./node_modules/core-js/library/modules/_shared-key.js")('IE_PROTO');
var Empty = function () { /* empty */ };
var PROTOTYPE = 'prototype';

// Create object with fake `null` prototype: use iframe Object with cleared prototype
var createDict = function () {
  // Thrash, waste and sodomy: IE GC bug
  var iframe = __webpack_require__(/*! ./_dom-create */ "./node_modules/core-js/library/modules/_dom-create.js")('iframe');
  var i = enumBugKeys.length;
  var lt = '<';
  var gt = '>';
  var iframeDocument;
  iframe.style.display = 'none';
  __webpack_require__(/*! ./_html */ "./node_modules/core-js/library/modules/_html.js").appendChild(iframe);
  iframe.src = 'javascript:'; // eslint-disable-line no-script-url
  // createDict = iframe.contentWindow.Object;
  // html.removeChild(iframe);
  iframeDocument = iframe.contentWindow.document;
  iframeDocument.open();
  iframeDocument.write(lt + 'script' + gt + 'document.F=Object' + lt + '/script' + gt);
  iframeDocument.close();
  createDict = iframeDocument.F;
  while (i--) delete createDict[PROTOTYPE][enumBugKeys[i]];
  return createDict();
};

module.exports = Object.create || function create(O, Properties) {
  var result;
  if (O !== null) {
    Empty[PROTOTYPE] = anObject(O);
    result = new Empty();
    Empty[PROTOTYPE] = null;
    // add "__proto__" for Object.getPrototypeOf polyfill
    result[IE_PROTO] = O;
  } else result = createDict();
  return Properties === undefined ? result : dPs(result, Properties);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-dp.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-dp.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var IE8_DOM_DEFINE = __webpack_require__(/*! ./_ie8-dom-define */ "./node_modules/core-js/library/modules/_ie8-dom-define.js");
var toPrimitive = __webpack_require__(/*! ./_to-primitive */ "./node_modules/core-js/library/modules/_to-primitive.js");
var dP = Object.defineProperty;

exports.f = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js") ? Object.defineProperty : function defineProperty(O, P, Attributes) {
  anObject(O);
  P = toPrimitive(P, true);
  anObject(Attributes);
  if (IE8_DOM_DEFINE) try {
    return dP(O, P, Attributes);
  } catch (e) { /* empty */ }
  if ('get' in Attributes || 'set' in Attributes) throw TypeError('Accessors not supported!');
  if ('value' in Attributes) O[P] = Attributes.value;
  return O;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-dps.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-dps.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var dP = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js");
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var getKeys = __webpack_require__(/*! ./_object-keys */ "./node_modules/core-js/library/modules/_object-keys.js");

module.exports = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js") ? Object.defineProperties : function defineProperties(O, Properties) {
  anObject(O);
  var keys = getKeys(Properties);
  var length = keys.length;
  var i = 0;
  var P;
  while (length > i) dP.f(O, P = keys[i++], Properties[P]);
  return O;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-gopd.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-gopd.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var pIE = __webpack_require__(/*! ./_object-pie */ "./node_modules/core-js/library/modules/_object-pie.js");
var createDesc = __webpack_require__(/*! ./_property-desc */ "./node_modules/core-js/library/modules/_property-desc.js");
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var toPrimitive = __webpack_require__(/*! ./_to-primitive */ "./node_modules/core-js/library/modules/_to-primitive.js");
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var IE8_DOM_DEFINE = __webpack_require__(/*! ./_ie8-dom-define */ "./node_modules/core-js/library/modules/_ie8-dom-define.js");
var gOPD = Object.getOwnPropertyDescriptor;

exports.f = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js") ? gOPD : function getOwnPropertyDescriptor(O, P) {
  O = toIObject(O);
  P = toPrimitive(P, true);
  if (IE8_DOM_DEFINE) try {
    return gOPD(O, P);
  } catch (e) { /* empty */ }
  if (has(O, P)) return createDesc(!pIE.f.call(O, P), O[P]);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-gopn-ext.js":
/*!******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-gopn-ext.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// fallback for IE11 buggy Object.getOwnPropertyNames with iframe and window
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var gOPN = __webpack_require__(/*! ./_object-gopn */ "./node_modules/core-js/library/modules/_object-gopn.js").f;
var toString = {}.toString;

var windowNames =  true && window && Object.getOwnPropertyNames
  ? Object.getOwnPropertyNames(window) : [];

var getWindowNames = function (it) {
  try {
    return gOPN(it);
  } catch (e) {
    return windowNames.slice();
  }
};

module.exports.f = function getOwnPropertyNames(it) {
  return windowNames && toString.call(it) == '[object Window]' ? getWindowNames(it) : gOPN(toIObject(it));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-gopn.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-gopn.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.7 / 15.2.3.4 Object.getOwnPropertyNames(O)
var $keys = __webpack_require__(/*! ./_object-keys-internal */ "./node_modules/core-js/library/modules/_object-keys-internal.js");
var hiddenKeys = __webpack_require__(/*! ./_enum-bug-keys */ "./node_modules/core-js/library/modules/_enum-bug-keys.js").concat('length', 'prototype');

exports.f = Object.getOwnPropertyNames || function getOwnPropertyNames(O) {
  return $keys(O, hiddenKeys);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-gops.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-gops.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

exports.f = Object.getOwnPropertySymbols;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-gpo.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-gpo.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.9 / 15.2.3.2 Object.getPrototypeOf(O)
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var IE_PROTO = __webpack_require__(/*! ./_shared-key */ "./node_modules/core-js/library/modules/_shared-key.js")('IE_PROTO');
var ObjectProto = Object.prototype;

module.exports = Object.getPrototypeOf || function (O) {
  O = toObject(O);
  if (has(O, IE_PROTO)) return O[IE_PROTO];
  if (typeof O.constructor == 'function' && O instanceof O.constructor) {
    return O.constructor.prototype;
  } return O instanceof Object ? ObjectProto : null;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-keys-internal.js":
/*!***********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-keys-internal.js ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var arrayIndexOf = __webpack_require__(/*! ./_array-includes */ "./node_modules/core-js/library/modules/_array-includes.js")(false);
var IE_PROTO = __webpack_require__(/*! ./_shared-key */ "./node_modules/core-js/library/modules/_shared-key.js")('IE_PROTO');

module.exports = function (object, names) {
  var O = toIObject(object);
  var i = 0;
  var result = [];
  var key;
  for (key in O) if (key != IE_PROTO) has(O, key) && result.push(key);
  // Don't enum bug & hidden keys
  while (names.length > i) if (has(O, key = names[i++])) {
    ~arrayIndexOf(result, key) || result.push(key);
  }
  return result;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-keys.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-keys.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.14 / 15.2.3.14 Object.keys(O)
var $keys = __webpack_require__(/*! ./_object-keys-internal */ "./node_modules/core-js/library/modules/_object-keys-internal.js");
var enumBugKeys = __webpack_require__(/*! ./_enum-bug-keys */ "./node_modules/core-js/library/modules/_enum-bug-keys.js");

module.exports = Object.keys || function keys(O) {
  return $keys(O, enumBugKeys);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-pie.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-pie.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

exports.f = {}.propertyIsEnumerable;


/***/ }),

/***/ "./node_modules/core-js/library/modules/_object-sap.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_object-sap.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// most Object methods by ES6 should accept primitives
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var fails = __webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js");
module.exports = function (KEY, exec) {
  var fn = (core.Object || {})[KEY] || Object[KEY];
  var exp = {};
  exp[KEY] = exec(fn);
  $export($export.S + $export.F * fails(function () { fn(1); }), 'Object', exp);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_perform.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_perform.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (exec) {
  try {
    return { e: false, v: exec() };
  } catch (e) {
    return { e: true, v: e };
  }
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_promise-resolve.js":
/*!******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_promise-resolve.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var newPromiseCapability = __webpack_require__(/*! ./_new-promise-capability */ "./node_modules/core-js/library/modules/_new-promise-capability.js");

module.exports = function (C, x) {
  anObject(C);
  if (isObject(x) && x.constructor === C) return x;
  var promiseCapability = newPromiseCapability.f(C);
  var resolve = promiseCapability.resolve;
  resolve(x);
  return promiseCapability.promise;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_property-desc.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_property-desc.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function (bitmap, value) {
  return {
    enumerable: !(bitmap & 1),
    configurable: !(bitmap & 2),
    writable: !(bitmap & 4),
    value: value
  };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_redefine-all.js":
/*!***************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_redefine-all.js ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var hide = __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js");
module.exports = function (target, src, safe) {
  for (var key in src) {
    if (safe && target[key]) target[key] = src[key];
    else hide(target, key, src[key]);
  } return target;
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_redefine.js":
/*!***********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_redefine.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js");


/***/ }),

/***/ "./node_modules/core-js/library/modules/_set-proto.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_set-proto.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Works with __proto__ only. Old v8 can't work with null proto objects.
/* eslint-disable no-proto */
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var check = function (O, proto) {
  anObject(O);
  if (!isObject(proto) && proto !== null) throw TypeError(proto + ": can't set as prototype!");
};
module.exports = {
  set: Object.setPrototypeOf || ('__proto__' in {} ? // eslint-disable-line
    function (test, buggy, set) {
      try {
        set = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js")(Function.call, __webpack_require__(/*! ./_object-gopd */ "./node_modules/core-js/library/modules/_object-gopd.js").f(Object.prototype, '__proto__').set, 2);
        set(test, []);
        buggy = !(test instanceof Array);
      } catch (e) { buggy = true; }
      return function setPrototypeOf(O, proto) {
        check(O, proto);
        if (buggy) O.__proto__ = proto;
        else set(O, proto);
        return O;
      };
    }({}, false) : undefined),
  check: check
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_set-species.js":
/*!**************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_set-species.js ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var dP = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js");
var DESCRIPTORS = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js");
var SPECIES = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('species');

module.exports = function (KEY) {
  var C = typeof core[KEY] == 'function' ? core[KEY] : global[KEY];
  if (DESCRIPTORS && C && !C[SPECIES]) dP.f(C, SPECIES, {
    configurable: true,
    get: function () { return this; }
  });
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_set-to-string-tag.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_set-to-string-tag.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var def = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js").f;
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var TAG = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('toStringTag');

module.exports = function (it, tag, stat) {
  if (it && !has(it = stat ? it : it.prototype, TAG)) def(it, TAG, { configurable: true, value: tag });
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_shared-key.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_shared-key.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var shared = __webpack_require__(/*! ./_shared */ "./node_modules/core-js/library/modules/_shared.js")('keys');
var uid = __webpack_require__(/*! ./_uid */ "./node_modules/core-js/library/modules/_uid.js");
module.exports = function (key) {
  return shared[key] || (shared[key] = uid(key));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_shared.js":
/*!*********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_shared.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var SHARED = '__core-js_shared__';
var store = global[SHARED] || (global[SHARED] = {});

(module.exports = function (key, value) {
  return store[key] || (store[key] = value !== undefined ? value : {});
})('versions', []).push({
  version: core.version,
  mode: __webpack_require__(/*! ./_library */ "./node_modules/core-js/library/modules/_library.js") ? 'pure' : 'global',
  copyright: '© 2019 Denis Pushkarev (zloirock.ru)'
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/_species-constructor.js":
/*!**********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_species-constructor.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 7.3.20 SpeciesConstructor(O, defaultConstructor)
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");
var SPECIES = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('species');
module.exports = function (O, D) {
  var C = anObject(O).constructor;
  var S;
  return C === undefined || (S = anObject(C)[SPECIES]) == undefined ? D : aFunction(S);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_string-at.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_string-at.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var toInteger = __webpack_require__(/*! ./_to-integer */ "./node_modules/core-js/library/modules/_to-integer.js");
var defined = __webpack_require__(/*! ./_defined */ "./node_modules/core-js/library/modules/_defined.js");
// true  -> String#at
// false -> String#codePointAt
module.exports = function (TO_STRING) {
  return function (that, pos) {
    var s = String(defined(that));
    var i = toInteger(pos);
    var l = s.length;
    var a, b;
    if (i < 0 || i >= l) return TO_STRING ? '' : undefined;
    a = s.charCodeAt(i);
    return a < 0xd800 || a > 0xdbff || i + 1 === l || (b = s.charCodeAt(i + 1)) < 0xdc00 || b > 0xdfff
      ? TO_STRING ? s.charAt(i) : a
      : TO_STRING ? s.slice(i, i + 2) : (a - 0xd800 << 10) + (b - 0xdc00) + 0x10000;
  };
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_task.js":
/*!*******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_task.js ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var ctx = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js");
var invoke = __webpack_require__(/*! ./_invoke */ "./node_modules/core-js/library/modules/_invoke.js");
var html = __webpack_require__(/*! ./_html */ "./node_modules/core-js/library/modules/_html.js");
var cel = __webpack_require__(/*! ./_dom-create */ "./node_modules/core-js/library/modules/_dom-create.js");
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var process = global.process;
var setTask = global.setImmediate;
var clearTask = global.clearImmediate;
var MessageChannel = global.MessageChannel;
var Dispatch = global.Dispatch;
var counter = 0;
var queue = {};
var ONREADYSTATECHANGE = 'onreadystatechange';
var defer, channel, port;
var run = function () {
  var id = +this;
  // eslint-disable-next-line no-prototype-builtins
  if (queue.hasOwnProperty(id)) {
    var fn = queue[id];
    delete queue[id];
    fn();
  }
};
var listener = function (event) {
  run.call(event.data);
};
// Node.js 0.9+ & IE10+ has setImmediate, otherwise:
if (!setTask || !clearTask) {
  setTask = function setImmediate(fn) {
    var args = [];
    var i = 1;
    while (arguments.length > i) args.push(arguments[i++]);
    queue[++counter] = function () {
      // eslint-disable-next-line no-new-func
      invoke(typeof fn == 'function' ? fn : Function(fn), args);
    };
    defer(counter);
    return counter;
  };
  clearTask = function clearImmediate(id) {
    delete queue[id];
  };
  // Node.js 0.8-
  if (__webpack_require__(/*! ./_cof */ "./node_modules/core-js/library/modules/_cof.js")(process) == 'process') {
    defer = function (id) {
      process.nextTick(ctx(run, id, 1));
    };
  // Sphere (JS game engine) Dispatch API
  } else if (Dispatch && Dispatch.now) {
    defer = function (id) {
      Dispatch.now(ctx(run, id, 1));
    };
  // Browsers with MessageChannel, includes WebWorkers
  } else if (MessageChannel) {
    channel = new MessageChannel();
    port = channel.port2;
    channel.port1.onmessage = listener;
    defer = ctx(port.postMessage, port, 1);
  // Browsers with postMessage, skip WebWorkers
  // IE8 has postMessage, but it's sync & typeof its postMessage is 'object'
  } else if (global.addEventListener && typeof postMessage == 'function' && !global.importScripts) {
    defer = function (id) {
      global.postMessage(id + '', '*');
    };
    global.addEventListener('message', listener, false);
  // IE8-
  } else if (ONREADYSTATECHANGE in cel('script')) {
    defer = function (id) {
      html.appendChild(cel('script'))[ONREADYSTATECHANGE] = function () {
        html.removeChild(this);
        run.call(id);
      };
    };
  // Rest old browsers
  } else {
    defer = function (id) {
      setTimeout(ctx(run, id, 1), 0);
    };
  }
}
module.exports = {
  set: setTask,
  clear: clearTask
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-absolute-index.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-absolute-index.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var toInteger = __webpack_require__(/*! ./_to-integer */ "./node_modules/core-js/library/modules/_to-integer.js");
var max = Math.max;
var min = Math.min;
module.exports = function (index, length) {
  index = toInteger(index);
  return index < 0 ? max(index + length, 0) : min(index, length);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-integer.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-integer.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

// 7.1.4 ToInteger
var ceil = Math.ceil;
var floor = Math.floor;
module.exports = function (it) {
  return isNaN(it = +it) ? 0 : (it > 0 ? floor : ceil)(it);
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-iobject.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-iobject.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// to indexed object, toObject with fallback for non-array-like ES3 strings
var IObject = __webpack_require__(/*! ./_iobject */ "./node_modules/core-js/library/modules/_iobject.js");
var defined = __webpack_require__(/*! ./_defined */ "./node_modules/core-js/library/modules/_defined.js");
module.exports = function (it) {
  return IObject(defined(it));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-length.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-length.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 7.1.15 ToLength
var toInteger = __webpack_require__(/*! ./_to-integer */ "./node_modules/core-js/library/modules/_to-integer.js");
var min = Math.min;
module.exports = function (it) {
  return it > 0 ? min(toInteger(it), 0x1fffffffffffff) : 0; // pow(2, 53) - 1 == 9007199254740991
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-object.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-object.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 7.1.13 ToObject(argument)
var defined = __webpack_require__(/*! ./_defined */ "./node_modules/core-js/library/modules/_defined.js");
module.exports = function (it) {
  return Object(defined(it));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_to-primitive.js":
/*!***************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_to-primitive.js ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 7.1.1 ToPrimitive(input [, PreferredType])
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
// instead of the ES6 spec version, we didn't implement @@toPrimitive case
// and the second argument - flag - preferred type is a string
module.exports = function (it, S) {
  if (!isObject(it)) return it;
  var fn, val;
  if (S && typeof (fn = it.toString) == 'function' && !isObject(val = fn.call(it))) return val;
  if (typeof (fn = it.valueOf) == 'function' && !isObject(val = fn.call(it))) return val;
  if (!S && typeof (fn = it.toString) == 'function' && !isObject(val = fn.call(it))) return val;
  throw TypeError("Can't convert object to primitive value");
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_uid.js":
/*!******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_uid.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

var id = 0;
var px = Math.random();
module.exports = function (key) {
  return 'Symbol('.concat(key === undefined ? '' : key, ')_', (++id + px).toString(36));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_user-agent.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_user-agent.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var navigator = global.navigator;

module.exports = navigator && navigator.userAgent || '';


/***/ }),

/***/ "./node_modules/core-js/library/modules/_wks-define.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/_wks-define.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var LIBRARY = __webpack_require__(/*! ./_library */ "./node_modules/core-js/library/modules/_library.js");
var wksExt = __webpack_require__(/*! ./_wks-ext */ "./node_modules/core-js/library/modules/_wks-ext.js");
var defineProperty = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js").f;
module.exports = function (name) {
  var $Symbol = core.Symbol || (core.Symbol = LIBRARY ? {} : global.Symbol || {});
  if (name.charAt(0) != '_' && !(name in $Symbol)) defineProperty($Symbol, name, { value: wksExt.f(name) });
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/_wks-ext.js":
/*!**********************************************************!*\
  !*** ./node_modules/core-js/library/modules/_wks-ext.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

exports.f = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js");


/***/ }),

/***/ "./node_modules/core-js/library/modules/_wks.js":
/*!******************************************************!*\
  !*** ./node_modules/core-js/library/modules/_wks.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var store = __webpack_require__(/*! ./_shared */ "./node_modules/core-js/library/modules/_shared.js")('wks');
var uid = __webpack_require__(/*! ./_uid */ "./node_modules/core-js/library/modules/_uid.js");
var Symbol = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js").Symbol;
var USE_SYMBOL = typeof Symbol == 'function';

var $exports = module.exports = function (name) {
  return store[name] || (store[name] =
    USE_SYMBOL && Symbol[name] || (USE_SYMBOL ? Symbol : uid)('Symbol.' + name));
};

$exports.store = store;


/***/ }),

/***/ "./node_modules/core-js/library/modules/core.get-iterator-method.js":
/*!**************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/core.get-iterator-method.js ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var classof = __webpack_require__(/*! ./_classof */ "./node_modules/core-js/library/modules/_classof.js");
var ITERATOR = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator');
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
module.exports = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js").getIteratorMethod = function (it) {
  if (it != undefined) return it[ITERATOR]
    || it['@@iterator']
    || Iterators[classof(it)];
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/core.get-iterator.js":
/*!*******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/core.get-iterator.js ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var get = __webpack_require__(/*! ./core.get-iterator-method */ "./node_modules/core-js/library/modules/core.get-iterator-method.js");
module.exports = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js").getIterator = function (it) {
  var iterFn = get(it);
  if (typeof iterFn != 'function') throw TypeError(it + ' is not iterable!');
  return anObject(iterFn.call(it));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/core.is-iterable.js":
/*!******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/core.is-iterable.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var classof = __webpack_require__(/*! ./_classof */ "./node_modules/core-js/library/modules/_classof.js");
var ITERATOR = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('iterator');
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
module.exports = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js").isIterable = function (it) {
  var O = Object(it);
  return O[ITERATOR] !== undefined
    || '@@iterator' in O
    // eslint-disable-next-line no-prototype-builtins
    || Iterators.hasOwnProperty(classof(O));
};


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.array.from.js":
/*!****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.array.from.js ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var ctx = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js");
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var call = __webpack_require__(/*! ./_iter-call */ "./node_modules/core-js/library/modules/_iter-call.js");
var isArrayIter = __webpack_require__(/*! ./_is-array-iter */ "./node_modules/core-js/library/modules/_is-array-iter.js");
var toLength = __webpack_require__(/*! ./_to-length */ "./node_modules/core-js/library/modules/_to-length.js");
var createProperty = __webpack_require__(/*! ./_create-property */ "./node_modules/core-js/library/modules/_create-property.js");
var getIterFn = __webpack_require__(/*! ./core.get-iterator-method */ "./node_modules/core-js/library/modules/core.get-iterator-method.js");

$export($export.S + $export.F * !__webpack_require__(/*! ./_iter-detect */ "./node_modules/core-js/library/modules/_iter-detect.js")(function (iter) { Array.from(iter); }), 'Array', {
  // 22.1.2.1 Array.from(arrayLike, mapfn = undefined, thisArg = undefined)
  from: function from(arrayLike /* , mapfn = undefined, thisArg = undefined */) {
    var O = toObject(arrayLike);
    var C = typeof this == 'function' ? this : Array;
    var aLen = arguments.length;
    var mapfn = aLen > 1 ? arguments[1] : undefined;
    var mapping = mapfn !== undefined;
    var index = 0;
    var iterFn = getIterFn(O);
    var length, result, step, iterator;
    if (mapping) mapfn = ctx(mapfn, aLen > 2 ? arguments[2] : undefined, 2);
    // if object isn't iterable or it's array with default iterator - use simple case
    if (iterFn != undefined && !(C == Array && isArrayIter(iterFn))) {
      for (iterator = iterFn.call(O), result = new C(); !(step = iterator.next()).done; index++) {
        createProperty(result, index, mapping ? call(iterator, mapfn, [step.value, index], true) : step.value);
      }
    } else {
      length = toLength(O.length);
      for (result = new C(length); length > index; index++) {
        createProperty(result, index, mapping ? mapfn(O[index], index) : O[index]);
      }
    }
    result.length = index;
    return result;
  }
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.array.is-array.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.array.is-array.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 22.1.2.2 / 15.4.3.2 Array.isArray(arg)
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");

$export($export.S, 'Array', { isArray: __webpack_require__(/*! ./_is-array */ "./node_modules/core-js/library/modules/_is-array.js") });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.array.iterator.js":
/*!********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.array.iterator.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var addToUnscopables = __webpack_require__(/*! ./_add-to-unscopables */ "./node_modules/core-js/library/modules/_add-to-unscopables.js");
var step = __webpack_require__(/*! ./_iter-step */ "./node_modules/core-js/library/modules/_iter-step.js");
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");

// 22.1.3.4 Array.prototype.entries()
// 22.1.3.13 Array.prototype.keys()
// 22.1.3.29 Array.prototype.values()
// 22.1.3.30 Array.prototype[@@iterator]()
module.exports = __webpack_require__(/*! ./_iter-define */ "./node_modules/core-js/library/modules/_iter-define.js")(Array, 'Array', function (iterated, kind) {
  this._t = toIObject(iterated); // target
  this._i = 0;                   // next index
  this._k = kind;                // kind
// 22.1.5.2.1 %ArrayIteratorPrototype%.next()
}, function () {
  var O = this._t;
  var kind = this._k;
  var index = this._i++;
  if (!O || index >= O.length) {
    this._t = undefined;
    return step(1);
  }
  if (kind == 'keys') return step(0, index);
  if (kind == 'values') return step(0, O[index]);
  return step(0, [index, O[index]]);
}, 'values');

// argumentsList[@@iterator] is %ArrayProto_values% (9.4.4.6, 9.4.4.7)
Iterators.Arguments = Iterators.Array;

addToUnscopables('keys');
addToUnscopables('values');
addToUnscopables('entries');


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.assign.js":
/*!*******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.assign.js ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.3.1 Object.assign(target, source)
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");

$export($export.S + $export.F, 'Object', { assign: __webpack_require__(/*! ./_object-assign */ "./node_modules/core-js/library/modules/_object-assign.js") });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.create.js":
/*!*******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.create.js ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
$export($export.S, 'Object', { create: __webpack_require__(/*! ./_object-create */ "./node_modules/core-js/library/modules/_object-create.js") });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.define-property.js":
/*!****************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.define-property.js ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
// 19.1.2.4 / 15.2.3.6 Object.defineProperty(O, P, Attributes)
$export($export.S + $export.F * !__webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js"), 'Object', { defineProperty: __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js").f });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.get-own-property-descriptor.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.get-own-property-descriptor.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.6 Object.getOwnPropertyDescriptor(O, P)
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var $getOwnPropertyDescriptor = __webpack_require__(/*! ./_object-gopd */ "./node_modules/core-js/library/modules/_object-gopd.js").f;

__webpack_require__(/*! ./_object-sap */ "./node_modules/core-js/library/modules/_object-sap.js")('getOwnPropertyDescriptor', function () {
  return function getOwnPropertyDescriptor(it, key) {
    return $getOwnPropertyDescriptor(toIObject(it), key);
  };
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.get-prototype-of.js":
/*!*****************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.get-prototype-of.js ***!
  \*****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.9 Object.getPrototypeOf(O)
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var $getPrototypeOf = __webpack_require__(/*! ./_object-gpo */ "./node_modules/core-js/library/modules/_object-gpo.js");

__webpack_require__(/*! ./_object-sap */ "./node_modules/core-js/library/modules/_object-sap.js")('getPrototypeOf', function () {
  return function getPrototypeOf(it) {
    return $getPrototypeOf(toObject(it));
  };
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.keys.js":
/*!*****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.keys.js ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.2.14 Object.keys(O)
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var $keys = __webpack_require__(/*! ./_object-keys */ "./node_modules/core-js/library/modules/_object-keys.js");

__webpack_require__(/*! ./_object-sap */ "./node_modules/core-js/library/modules/_object-sap.js")('keys', function () {
  return function keys(it) {
    return $keys(toObject(it));
  };
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.set-prototype-of.js":
/*!*****************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.set-prototype-of.js ***!
  \*****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 19.1.3.19 Object.setPrototypeOf(O, proto)
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
$export($export.S, 'Object', { setPrototypeOf: __webpack_require__(/*! ./_set-proto */ "./node_modules/core-js/library/modules/_set-proto.js").set });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.object.to-string.js":
/*!**********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.object.to-string.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {



/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.promise.js":
/*!*************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.promise.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var LIBRARY = __webpack_require__(/*! ./_library */ "./node_modules/core-js/library/modules/_library.js");
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var ctx = __webpack_require__(/*! ./_ctx */ "./node_modules/core-js/library/modules/_ctx.js");
var classof = __webpack_require__(/*! ./_classof */ "./node_modules/core-js/library/modules/_classof.js");
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");
var anInstance = __webpack_require__(/*! ./_an-instance */ "./node_modules/core-js/library/modules/_an-instance.js");
var forOf = __webpack_require__(/*! ./_for-of */ "./node_modules/core-js/library/modules/_for-of.js");
var speciesConstructor = __webpack_require__(/*! ./_species-constructor */ "./node_modules/core-js/library/modules/_species-constructor.js");
var task = __webpack_require__(/*! ./_task */ "./node_modules/core-js/library/modules/_task.js").set;
var microtask = __webpack_require__(/*! ./_microtask */ "./node_modules/core-js/library/modules/_microtask.js")();
var newPromiseCapabilityModule = __webpack_require__(/*! ./_new-promise-capability */ "./node_modules/core-js/library/modules/_new-promise-capability.js");
var perform = __webpack_require__(/*! ./_perform */ "./node_modules/core-js/library/modules/_perform.js");
var userAgent = __webpack_require__(/*! ./_user-agent */ "./node_modules/core-js/library/modules/_user-agent.js");
var promiseResolve = __webpack_require__(/*! ./_promise-resolve */ "./node_modules/core-js/library/modules/_promise-resolve.js");
var PROMISE = 'Promise';
var TypeError = global.TypeError;
var process = global.process;
var versions = process && process.versions;
var v8 = versions && versions.v8 || '';
var $Promise = global[PROMISE];
var isNode = classof(process) == 'process';
var empty = function () { /* empty */ };
var Internal, newGenericPromiseCapability, OwnPromiseCapability, Wrapper;
var newPromiseCapability = newGenericPromiseCapability = newPromiseCapabilityModule.f;

var USE_NATIVE = !!function () {
  try {
    // correct subclassing with @@species support
    var promise = $Promise.resolve(1);
    var FakePromise = (promise.constructor = {})[__webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('species')] = function (exec) {
      exec(empty, empty);
    };
    // unhandled rejections tracking support, NodeJS Promise without it fails @@species test
    return (isNode || typeof PromiseRejectionEvent == 'function')
      && promise.then(empty) instanceof FakePromise
      // v8 6.6 (Node 10 and Chrome 66) have a bug with resolving custom thenables
      // https://bugs.chromium.org/p/chromium/issues/detail?id=830565
      // we can't detect it synchronously, so just check versions
      && v8.indexOf('6.6') !== 0
      && userAgent.indexOf('Chrome/66') === -1;
  } catch (e) { /* empty */ }
}();

// helpers
var isThenable = function (it) {
  var then;
  return isObject(it) && typeof (then = it.then) == 'function' ? then : false;
};
var notify = function (promise, isReject) {
  if (promise._n) return;
  promise._n = true;
  var chain = promise._c;
  microtask(function () {
    var value = promise._v;
    var ok = promise._s == 1;
    var i = 0;
    var run = function (reaction) {
      var handler = ok ? reaction.ok : reaction.fail;
      var resolve = reaction.resolve;
      var reject = reaction.reject;
      var domain = reaction.domain;
      var result, then, exited;
      try {
        if (handler) {
          if (!ok) {
            if (promise._h == 2) onHandleUnhandled(promise);
            promise._h = 1;
          }
          if (handler === true) result = value;
          else {
            if (domain) domain.enter();
            result = handler(value); // may throw
            if (domain) {
              domain.exit();
              exited = true;
            }
          }
          if (result === reaction.promise) {
            reject(TypeError('Promise-chain cycle'));
          } else if (then = isThenable(result)) {
            then.call(result, resolve, reject);
          } else resolve(result);
        } else reject(value);
      } catch (e) {
        if (domain && !exited) domain.exit();
        reject(e);
      }
    };
    while (chain.length > i) run(chain[i++]); // variable length - can't use forEach
    promise._c = [];
    promise._n = false;
    if (isReject && !promise._h) onUnhandled(promise);
  });
};
var onUnhandled = function (promise) {
  task.call(global, function () {
    var value = promise._v;
    var unhandled = isUnhandled(promise);
    var result, handler, console;
    if (unhandled) {
      result = perform(function () {
        if (isNode) {
          process.emit('unhandledRejection', value, promise);
        } else if (handler = global.onunhandledrejection) {
          handler({ promise: promise, reason: value });
        } else if ((console = global.console) && console.error) {
          console.error('Unhandled promise rejection', value);
        }
      });
      // Browsers should not trigger `rejectionHandled` event if it was handled here, NodeJS - should
      promise._h = isNode || isUnhandled(promise) ? 2 : 1;
    } promise._a = undefined;
    if (unhandled && result.e) throw result.v;
  });
};
var isUnhandled = function (promise) {
  return promise._h !== 1 && (promise._a || promise._c).length === 0;
};
var onHandleUnhandled = function (promise) {
  task.call(global, function () {
    var handler;
    if (isNode) {
      process.emit('rejectionHandled', promise);
    } else if (handler = global.onrejectionhandled) {
      handler({ promise: promise, reason: promise._v });
    }
  });
};
var $reject = function (value) {
  var promise = this;
  if (promise._d) return;
  promise._d = true;
  promise = promise._w || promise; // unwrap
  promise._v = value;
  promise._s = 2;
  if (!promise._a) promise._a = promise._c.slice();
  notify(promise, true);
};
var $resolve = function (value) {
  var promise = this;
  var then;
  if (promise._d) return;
  promise._d = true;
  promise = promise._w || promise; // unwrap
  try {
    if (promise === value) throw TypeError("Promise can't be resolved itself");
    if (then = isThenable(value)) {
      microtask(function () {
        var wrapper = { _w: promise, _d: false }; // wrap
        try {
          then.call(value, ctx($resolve, wrapper, 1), ctx($reject, wrapper, 1));
        } catch (e) {
          $reject.call(wrapper, e);
        }
      });
    } else {
      promise._v = value;
      promise._s = 1;
      notify(promise, false);
    }
  } catch (e) {
    $reject.call({ _w: promise, _d: false }, e); // wrap
  }
};

// constructor polyfill
if (!USE_NATIVE) {
  // 25.4.3.1 Promise(executor)
  $Promise = function Promise(executor) {
    anInstance(this, $Promise, PROMISE, '_h');
    aFunction(executor);
    Internal.call(this);
    try {
      executor(ctx($resolve, this, 1), ctx($reject, this, 1));
    } catch (err) {
      $reject.call(this, err);
    }
  };
  // eslint-disable-next-line no-unused-vars
  Internal = function Promise(executor) {
    this._c = [];             // <- awaiting reactions
    this._a = undefined;      // <- checked in isUnhandled reactions
    this._s = 0;              // <- state
    this._d = false;          // <- done
    this._v = undefined;      // <- value
    this._h = 0;              // <- rejection state, 0 - default, 1 - handled, 2 - unhandled
    this._n = false;          // <- notify
  };
  Internal.prototype = __webpack_require__(/*! ./_redefine-all */ "./node_modules/core-js/library/modules/_redefine-all.js")($Promise.prototype, {
    // 25.4.5.3 Promise.prototype.then(onFulfilled, onRejected)
    then: function then(onFulfilled, onRejected) {
      var reaction = newPromiseCapability(speciesConstructor(this, $Promise));
      reaction.ok = typeof onFulfilled == 'function' ? onFulfilled : true;
      reaction.fail = typeof onRejected == 'function' && onRejected;
      reaction.domain = isNode ? process.domain : undefined;
      this._c.push(reaction);
      if (this._a) this._a.push(reaction);
      if (this._s) notify(this, false);
      return reaction.promise;
    },
    // 25.4.5.1 Promise.prototype.catch(onRejected)
    'catch': function (onRejected) {
      return this.then(undefined, onRejected);
    }
  });
  OwnPromiseCapability = function () {
    var promise = new Internal();
    this.promise = promise;
    this.resolve = ctx($resolve, promise, 1);
    this.reject = ctx($reject, promise, 1);
  };
  newPromiseCapabilityModule.f = newPromiseCapability = function (C) {
    return C === $Promise || C === Wrapper
      ? new OwnPromiseCapability(C)
      : newGenericPromiseCapability(C);
  };
}

$export($export.G + $export.W + $export.F * !USE_NATIVE, { Promise: $Promise });
__webpack_require__(/*! ./_set-to-string-tag */ "./node_modules/core-js/library/modules/_set-to-string-tag.js")($Promise, PROMISE);
__webpack_require__(/*! ./_set-species */ "./node_modules/core-js/library/modules/_set-species.js")(PROMISE);
Wrapper = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js")[PROMISE];

// statics
$export($export.S + $export.F * !USE_NATIVE, PROMISE, {
  // 25.4.4.5 Promise.reject(r)
  reject: function reject(r) {
    var capability = newPromiseCapability(this);
    var $$reject = capability.reject;
    $$reject(r);
    return capability.promise;
  }
});
$export($export.S + $export.F * (LIBRARY || !USE_NATIVE), PROMISE, {
  // 25.4.4.6 Promise.resolve(x)
  resolve: function resolve(x) {
    return promiseResolve(LIBRARY && this === Wrapper ? $Promise : this, x);
  }
});
$export($export.S + $export.F * !(USE_NATIVE && __webpack_require__(/*! ./_iter-detect */ "./node_modules/core-js/library/modules/_iter-detect.js")(function (iter) {
  $Promise.all(iter)['catch'](empty);
})), PROMISE, {
  // 25.4.4.1 Promise.all(iterable)
  all: function all(iterable) {
    var C = this;
    var capability = newPromiseCapability(C);
    var resolve = capability.resolve;
    var reject = capability.reject;
    var result = perform(function () {
      var values = [];
      var index = 0;
      var remaining = 1;
      forOf(iterable, false, function (promise) {
        var $index = index++;
        var alreadyCalled = false;
        values.push(undefined);
        remaining++;
        C.resolve(promise).then(function (value) {
          if (alreadyCalled) return;
          alreadyCalled = true;
          values[$index] = value;
          --remaining || resolve(values);
        }, reject);
      });
      --remaining || resolve(values);
    });
    if (result.e) reject(result.v);
    return capability.promise;
  },
  // 25.4.4.4 Promise.race(iterable)
  race: function race(iterable) {
    var C = this;
    var capability = newPromiseCapability(C);
    var reject = capability.reject;
    var result = perform(function () {
      forOf(iterable, false, function (promise) {
        C.resolve(promise).then(capability.resolve, reject);
      });
    });
    if (result.e) reject(result.v);
    return capability.promise;
  }
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.reflect.construct.js":
/*!***********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.reflect.construct.js ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// 26.1.2 Reflect.construct(target, argumentsList [, newTarget])
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var create = __webpack_require__(/*! ./_object-create */ "./node_modules/core-js/library/modules/_object-create.js");
var aFunction = __webpack_require__(/*! ./_a-function */ "./node_modules/core-js/library/modules/_a-function.js");
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var fails = __webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js");
var bind = __webpack_require__(/*! ./_bind */ "./node_modules/core-js/library/modules/_bind.js");
var rConstruct = (__webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js").Reflect || {}).construct;

// MS Edge supports only 2 arguments and argumentsList argument is optional
// FF Nightly sets third argument as `new.target`, but does not create `this` from it
var NEW_TARGET_BUG = fails(function () {
  function F() { /* empty */ }
  return !(rConstruct(function () { /* empty */ }, [], F) instanceof F);
});
var ARGS_BUG = !fails(function () {
  rConstruct(function () { /* empty */ });
});

$export($export.S + $export.F * (NEW_TARGET_BUG || ARGS_BUG), 'Reflect', {
  construct: function construct(Target, args /* , newTarget */) {
    aFunction(Target);
    anObject(args);
    var newTarget = arguments.length < 3 ? Target : aFunction(arguments[2]);
    if (ARGS_BUG && !NEW_TARGET_BUG) return rConstruct(Target, args, newTarget);
    if (Target == newTarget) {
      // w/o altered newTarget, optimization for 0-4 arguments
      switch (args.length) {
        case 0: return new Target();
        case 1: return new Target(args[0]);
        case 2: return new Target(args[0], args[1]);
        case 3: return new Target(args[0], args[1], args[2]);
        case 4: return new Target(args[0], args[1], args[2], args[3]);
      }
      // w/o altered newTarget, lot of arguments case
      var $args = [null];
      $args.push.apply($args, args);
      return new (bind.apply(Target, $args))();
    }
    // with altered newTarget, not support built-in constructors
    var proto = newTarget.prototype;
    var instance = create(isObject(proto) ? proto : Object.prototype);
    var result = Function.apply.call(Target, instance, args);
    return isObject(result) ? result : instance;
  }
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.string.iterator.js":
/*!*********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.string.iterator.js ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var $at = __webpack_require__(/*! ./_string-at */ "./node_modules/core-js/library/modules/_string-at.js")(true);

// 21.1.3.27 String.prototype[@@iterator]()
__webpack_require__(/*! ./_iter-define */ "./node_modules/core-js/library/modules/_iter-define.js")(String, 'String', function (iterated) {
  this._t = String(iterated); // target
  this._i = 0;                // next index
// 21.1.5.2.1 %StringIteratorPrototype%.next()
}, function () {
  var O = this._t;
  var index = this._i;
  var point;
  if (index >= O.length) return { value: undefined, done: true };
  point = $at(O, index);
  this._i += point.length;
  return { value: point, done: false };
});


/***/ }),

/***/ "./node_modules/core-js/library/modules/es6.symbol.js":
/*!************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es6.symbol.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// ECMAScript 6 symbols shim
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var has = __webpack_require__(/*! ./_has */ "./node_modules/core-js/library/modules/_has.js");
var DESCRIPTORS = __webpack_require__(/*! ./_descriptors */ "./node_modules/core-js/library/modules/_descriptors.js");
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var redefine = __webpack_require__(/*! ./_redefine */ "./node_modules/core-js/library/modules/_redefine.js");
var META = __webpack_require__(/*! ./_meta */ "./node_modules/core-js/library/modules/_meta.js").KEY;
var $fails = __webpack_require__(/*! ./_fails */ "./node_modules/core-js/library/modules/_fails.js");
var shared = __webpack_require__(/*! ./_shared */ "./node_modules/core-js/library/modules/_shared.js");
var setToStringTag = __webpack_require__(/*! ./_set-to-string-tag */ "./node_modules/core-js/library/modules/_set-to-string-tag.js");
var uid = __webpack_require__(/*! ./_uid */ "./node_modules/core-js/library/modules/_uid.js");
var wks = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js");
var wksExt = __webpack_require__(/*! ./_wks-ext */ "./node_modules/core-js/library/modules/_wks-ext.js");
var wksDefine = __webpack_require__(/*! ./_wks-define */ "./node_modules/core-js/library/modules/_wks-define.js");
var enumKeys = __webpack_require__(/*! ./_enum-keys */ "./node_modules/core-js/library/modules/_enum-keys.js");
var isArray = __webpack_require__(/*! ./_is-array */ "./node_modules/core-js/library/modules/_is-array.js");
var anObject = __webpack_require__(/*! ./_an-object */ "./node_modules/core-js/library/modules/_an-object.js");
var isObject = __webpack_require__(/*! ./_is-object */ "./node_modules/core-js/library/modules/_is-object.js");
var toObject = __webpack_require__(/*! ./_to-object */ "./node_modules/core-js/library/modules/_to-object.js");
var toIObject = __webpack_require__(/*! ./_to-iobject */ "./node_modules/core-js/library/modules/_to-iobject.js");
var toPrimitive = __webpack_require__(/*! ./_to-primitive */ "./node_modules/core-js/library/modules/_to-primitive.js");
var createDesc = __webpack_require__(/*! ./_property-desc */ "./node_modules/core-js/library/modules/_property-desc.js");
var _create = __webpack_require__(/*! ./_object-create */ "./node_modules/core-js/library/modules/_object-create.js");
var gOPNExt = __webpack_require__(/*! ./_object-gopn-ext */ "./node_modules/core-js/library/modules/_object-gopn-ext.js");
var $GOPD = __webpack_require__(/*! ./_object-gopd */ "./node_modules/core-js/library/modules/_object-gopd.js");
var $GOPS = __webpack_require__(/*! ./_object-gops */ "./node_modules/core-js/library/modules/_object-gops.js");
var $DP = __webpack_require__(/*! ./_object-dp */ "./node_modules/core-js/library/modules/_object-dp.js");
var $keys = __webpack_require__(/*! ./_object-keys */ "./node_modules/core-js/library/modules/_object-keys.js");
var gOPD = $GOPD.f;
var dP = $DP.f;
var gOPN = gOPNExt.f;
var $Symbol = global.Symbol;
var $JSON = global.JSON;
var _stringify = $JSON && $JSON.stringify;
var PROTOTYPE = 'prototype';
var HIDDEN = wks('_hidden');
var TO_PRIMITIVE = wks('toPrimitive');
var isEnum = {}.propertyIsEnumerable;
var SymbolRegistry = shared('symbol-registry');
var AllSymbols = shared('symbols');
var OPSymbols = shared('op-symbols');
var ObjectProto = Object[PROTOTYPE];
var USE_NATIVE = typeof $Symbol == 'function' && !!$GOPS.f;
var QObject = global.QObject;
// Don't use setters in Qt Script, https://github.com/zloirock/core-js/issues/173
var setter = !QObject || !QObject[PROTOTYPE] || !QObject[PROTOTYPE].findChild;

// fallback for old Android, https://code.google.com/p/v8/issues/detail?id=687
var setSymbolDesc = DESCRIPTORS && $fails(function () {
  return _create(dP({}, 'a', {
    get: function () { return dP(this, 'a', { value: 7 }).a; }
  })).a != 7;
}) ? function (it, key, D) {
  var protoDesc = gOPD(ObjectProto, key);
  if (protoDesc) delete ObjectProto[key];
  dP(it, key, D);
  if (protoDesc && it !== ObjectProto) dP(ObjectProto, key, protoDesc);
} : dP;

var wrap = function (tag) {
  var sym = AllSymbols[tag] = _create($Symbol[PROTOTYPE]);
  sym._k = tag;
  return sym;
};

var isSymbol = USE_NATIVE && typeof $Symbol.iterator == 'symbol' ? function (it) {
  return typeof it == 'symbol';
} : function (it) {
  return it instanceof $Symbol;
};

var $defineProperty = function defineProperty(it, key, D) {
  if (it === ObjectProto) $defineProperty(OPSymbols, key, D);
  anObject(it);
  key = toPrimitive(key, true);
  anObject(D);
  if (has(AllSymbols, key)) {
    if (!D.enumerable) {
      if (!has(it, HIDDEN)) dP(it, HIDDEN, createDesc(1, {}));
      it[HIDDEN][key] = true;
    } else {
      if (has(it, HIDDEN) && it[HIDDEN][key]) it[HIDDEN][key] = false;
      D = _create(D, { enumerable: createDesc(0, false) });
    } return setSymbolDesc(it, key, D);
  } return dP(it, key, D);
};
var $defineProperties = function defineProperties(it, P) {
  anObject(it);
  var keys = enumKeys(P = toIObject(P));
  var i = 0;
  var l = keys.length;
  var key;
  while (l > i) $defineProperty(it, key = keys[i++], P[key]);
  return it;
};
var $create = function create(it, P) {
  return P === undefined ? _create(it) : $defineProperties(_create(it), P);
};
var $propertyIsEnumerable = function propertyIsEnumerable(key) {
  var E = isEnum.call(this, key = toPrimitive(key, true));
  if (this === ObjectProto && has(AllSymbols, key) && !has(OPSymbols, key)) return false;
  return E || !has(this, key) || !has(AllSymbols, key) || has(this, HIDDEN) && this[HIDDEN][key] ? E : true;
};
var $getOwnPropertyDescriptor = function getOwnPropertyDescriptor(it, key) {
  it = toIObject(it);
  key = toPrimitive(key, true);
  if (it === ObjectProto && has(AllSymbols, key) && !has(OPSymbols, key)) return;
  var D = gOPD(it, key);
  if (D && has(AllSymbols, key) && !(has(it, HIDDEN) && it[HIDDEN][key])) D.enumerable = true;
  return D;
};
var $getOwnPropertyNames = function getOwnPropertyNames(it) {
  var names = gOPN(toIObject(it));
  var result = [];
  var i = 0;
  var key;
  while (names.length > i) {
    if (!has(AllSymbols, key = names[i++]) && key != HIDDEN && key != META) result.push(key);
  } return result;
};
var $getOwnPropertySymbols = function getOwnPropertySymbols(it) {
  var IS_OP = it === ObjectProto;
  var names = gOPN(IS_OP ? OPSymbols : toIObject(it));
  var result = [];
  var i = 0;
  var key;
  while (names.length > i) {
    if (has(AllSymbols, key = names[i++]) && (IS_OP ? has(ObjectProto, key) : true)) result.push(AllSymbols[key]);
  } return result;
};

// 19.4.1.1 Symbol([description])
if (!USE_NATIVE) {
  $Symbol = function Symbol() {
    if (this instanceof $Symbol) throw TypeError('Symbol is not a constructor!');
    var tag = uid(arguments.length > 0 ? arguments[0] : undefined);
    var $set = function (value) {
      if (this === ObjectProto) $set.call(OPSymbols, value);
      if (has(this, HIDDEN) && has(this[HIDDEN], tag)) this[HIDDEN][tag] = false;
      setSymbolDesc(this, tag, createDesc(1, value));
    };
    if (DESCRIPTORS && setter) setSymbolDesc(ObjectProto, tag, { configurable: true, set: $set });
    return wrap(tag);
  };
  redefine($Symbol[PROTOTYPE], 'toString', function toString() {
    return this._k;
  });

  $GOPD.f = $getOwnPropertyDescriptor;
  $DP.f = $defineProperty;
  __webpack_require__(/*! ./_object-gopn */ "./node_modules/core-js/library/modules/_object-gopn.js").f = gOPNExt.f = $getOwnPropertyNames;
  __webpack_require__(/*! ./_object-pie */ "./node_modules/core-js/library/modules/_object-pie.js").f = $propertyIsEnumerable;
  $GOPS.f = $getOwnPropertySymbols;

  if (DESCRIPTORS && !__webpack_require__(/*! ./_library */ "./node_modules/core-js/library/modules/_library.js")) {
    redefine(ObjectProto, 'propertyIsEnumerable', $propertyIsEnumerable, true);
  }

  wksExt.f = function (name) {
    return wrap(wks(name));
  };
}

$export($export.G + $export.W + $export.F * !USE_NATIVE, { Symbol: $Symbol });

for (var es6Symbols = (
  // 19.4.2.2, 19.4.2.3, 19.4.2.4, 19.4.2.6, 19.4.2.8, 19.4.2.9, 19.4.2.10, 19.4.2.11, 19.4.2.12, 19.4.2.13, 19.4.2.14
  'hasInstance,isConcatSpreadable,iterator,match,replace,search,species,split,toPrimitive,toStringTag,unscopables'
).split(','), j = 0; es6Symbols.length > j;)wks(es6Symbols[j++]);

for (var wellKnownSymbols = $keys(wks.store), k = 0; wellKnownSymbols.length > k;) wksDefine(wellKnownSymbols[k++]);

$export($export.S + $export.F * !USE_NATIVE, 'Symbol', {
  // 19.4.2.1 Symbol.for(key)
  'for': function (key) {
    return has(SymbolRegistry, key += '')
      ? SymbolRegistry[key]
      : SymbolRegistry[key] = $Symbol(key);
  },
  // 19.4.2.5 Symbol.keyFor(sym)
  keyFor: function keyFor(sym) {
    if (!isSymbol(sym)) throw TypeError(sym + ' is not a symbol!');
    for (var key in SymbolRegistry) if (SymbolRegistry[key] === sym) return key;
  },
  useSetter: function () { setter = true; },
  useSimple: function () { setter = false; }
});

$export($export.S + $export.F * !USE_NATIVE, 'Object', {
  // 19.1.2.2 Object.create(O [, Properties])
  create: $create,
  // 19.1.2.4 Object.defineProperty(O, P, Attributes)
  defineProperty: $defineProperty,
  // 19.1.2.3 Object.defineProperties(O, Properties)
  defineProperties: $defineProperties,
  // 19.1.2.6 Object.getOwnPropertyDescriptor(O, P)
  getOwnPropertyDescriptor: $getOwnPropertyDescriptor,
  // 19.1.2.7 Object.getOwnPropertyNames(O)
  getOwnPropertyNames: $getOwnPropertyNames,
  // 19.1.2.8 Object.getOwnPropertySymbols(O)
  getOwnPropertySymbols: $getOwnPropertySymbols
});

// Chrome 38 and 39 `Object.getOwnPropertySymbols` fails on primitives
// https://bugs.chromium.org/p/v8/issues/detail?id=3443
var FAILS_ON_PRIMITIVES = $fails(function () { $GOPS.f(1); });

$export($export.S + $export.F * FAILS_ON_PRIMITIVES, 'Object', {
  getOwnPropertySymbols: function getOwnPropertySymbols(it) {
    return $GOPS.f(toObject(it));
  }
});

// 24.3.2 JSON.stringify(value [, replacer [, space]])
$JSON && $export($export.S + $export.F * (!USE_NATIVE || $fails(function () {
  var S = $Symbol();
  // MS Edge converts symbol values to JSON as {}
  // WebKit converts symbol values to JSON as null
  // V8 throws on boxed symbols
  return _stringify([S]) != '[null]' || _stringify({ a: S }) != '{}' || _stringify(Object(S)) != '{}';
})), 'JSON', {
  stringify: function stringify(it) {
    var args = [it];
    var i = 1;
    var replacer, $replacer;
    while (arguments.length > i) args.push(arguments[i++]);
    $replacer = replacer = args[1];
    if (!isObject(replacer) && it === undefined || isSymbol(it)) return; // IE8 returns string on undefined
    if (!isArray(replacer)) replacer = function (key, value) {
      if (typeof $replacer == 'function') value = $replacer.call(this, key, value);
      if (!isSymbol(value)) return value;
    };
    args[1] = replacer;
    return _stringify.apply($JSON, args);
  }
});

// 19.4.3.4 Symbol.prototype[@@toPrimitive](hint)
$Symbol[PROTOTYPE][TO_PRIMITIVE] || __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js")($Symbol[PROTOTYPE], TO_PRIMITIVE, $Symbol[PROTOTYPE].valueOf);
// 19.4.3.5 Symbol.prototype[@@toStringTag]
setToStringTag($Symbol, 'Symbol');
// 20.2.1.9 Math[@@toStringTag]
setToStringTag(Math, 'Math', true);
// 24.3.3 JSON[@@toStringTag]
setToStringTag(global.JSON, 'JSON', true);


/***/ }),

/***/ "./node_modules/core-js/library/modules/es7.promise.finally.js":
/*!*********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es7.promise.finally.js ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
// https://github.com/tc39/proposal-promise-finally

var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var core = __webpack_require__(/*! ./_core */ "./node_modules/core-js/library/modules/_core.js");
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var speciesConstructor = __webpack_require__(/*! ./_species-constructor */ "./node_modules/core-js/library/modules/_species-constructor.js");
var promiseResolve = __webpack_require__(/*! ./_promise-resolve */ "./node_modules/core-js/library/modules/_promise-resolve.js");

$export($export.P + $export.R, 'Promise', { 'finally': function (onFinally) {
  var C = speciesConstructor(this, core.Promise || global.Promise);
  var isFunction = typeof onFinally == 'function';
  return this.then(
    isFunction ? function (x) {
      return promiseResolve(C, onFinally()).then(function () { return x; });
    } : onFinally,
    isFunction ? function (e) {
      return promiseResolve(C, onFinally()).then(function () { throw e; });
    } : onFinally
  );
} });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es7.promise.try.js":
/*!*****************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es7.promise.try.js ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// https://github.com/tc39/proposal-promise-try
var $export = __webpack_require__(/*! ./_export */ "./node_modules/core-js/library/modules/_export.js");
var newPromiseCapability = __webpack_require__(/*! ./_new-promise-capability */ "./node_modules/core-js/library/modules/_new-promise-capability.js");
var perform = __webpack_require__(/*! ./_perform */ "./node_modules/core-js/library/modules/_perform.js");

$export($export.S, 'Promise', { 'try': function (callbackfn) {
  var promiseCapability = newPromiseCapability.f(this);
  var result = perform(callbackfn);
  (result.e ? promiseCapability.reject : promiseCapability.resolve)(result.v);
  return promiseCapability.promise;
} });


/***/ }),

/***/ "./node_modules/core-js/library/modules/es7.symbol.async-iterator.js":
/*!***************************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es7.symbol.async-iterator.js ***!
  \***************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ./_wks-define */ "./node_modules/core-js/library/modules/_wks-define.js")('asyncIterator');


/***/ }),

/***/ "./node_modules/core-js/library/modules/es7.symbol.observable.js":
/*!***********************************************************************!*\
  !*** ./node_modules/core-js/library/modules/es7.symbol.observable.js ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ./_wks-define */ "./node_modules/core-js/library/modules/_wks-define.js")('observable');


/***/ }),

/***/ "./node_modules/core-js/library/modules/web.dom.iterable.js":
/*!******************************************************************!*\
  !*** ./node_modules/core-js/library/modules/web.dom.iterable.js ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ./es6.array.iterator */ "./node_modules/core-js/library/modules/es6.array.iterator.js");
var global = __webpack_require__(/*! ./_global */ "./node_modules/core-js/library/modules/_global.js");
var hide = __webpack_require__(/*! ./_hide */ "./node_modules/core-js/library/modules/_hide.js");
var Iterators = __webpack_require__(/*! ./_iterators */ "./node_modules/core-js/library/modules/_iterators.js");
var TO_STRING_TAG = __webpack_require__(/*! ./_wks */ "./node_modules/core-js/library/modules/_wks.js")('toStringTag');

var DOMIterables = ('CSSRuleList,CSSStyleDeclaration,CSSValueList,ClientRectList,DOMRectList,DOMStringList,' +
  'DOMTokenList,DataTransferItemList,FileList,HTMLAllCollection,HTMLCollection,HTMLFormElement,HTMLSelectElement,' +
  'MediaList,MimeTypeArray,NamedNodeMap,NodeList,PaintRequestList,Plugin,PluginArray,SVGLengthList,SVGNumberList,' +
  'SVGPathSegList,SVGPointList,SVGStringList,SVGTransformList,SourceBufferList,StyleSheetList,TextTrackCueList,' +
  'TextTrackList,TouchList').split(',');

for (var i = 0; i < DOMIterables.length; i++) {
  var NAME = DOMIterables[i];
  var Collection = global[NAME];
  var proto = Collection && Collection.prototype;
  if (proto && !proto[TO_STRING_TAG]) hide(proto, TO_STRING_TAG, NAME);
  Iterators[NAME] = Iterators.Array;
}


/***/ }),

/***/ "./node_modules/nano-css/addon/__dev__/warnOnMissingDependencies.js":
/*!**************************************************************************!*\
  !*** ./node_modules/nano-css/addon/__dev__/warnOnMissingDependencies.js ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var pkgName = 'nano-css';

module.exports = function warnOnMissingDependencies (addon, renderer, deps) {
    var missing = [];

    for (var i = 0; i < deps.length; i++) {
        var name = deps[i];

        if (!renderer[name]) {
            missing.push(name);
        }
    }

    if (missing.length) {
        var str = 'Addon "' + addon + '" is missing the following dependencies:';

        for (var j = 0; j < missing.length; j++) {
            str += '\n require("' + pkgName + '/addon/' + missing[j] + '").addon(nano);';
        }

        throw new Error(str);
    }
};


/***/ }),

/***/ "./node_modules/nano-css/addon/cssom.js":
/*!**********************************************!*\
  !*** ./node_modules/nano-css/addon/cssom.js ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


exports.addon = function (renderer) {
    // CSSOM support only browser environment.
    if (!renderer.client) return;

    if (true) {
        __webpack_require__(/*! ./__dev__/warnOnMissingDependencies */ "./node_modules/nano-css/addon/__dev__/warnOnMissingDependencies.js")('cssom', renderer, ['sh']);
    }

    // Style sheet for media queries.
    document.head.appendChild(renderer.msh = document.createElement('style'));

    renderer.createRule = function (selector, prelude) {
        var rawCss = selector + '{}';
        if (prelude) rawCss = prelude + '{' + rawCss + '}';
        var sheet = prelude ? renderer.msh.sheet : renderer.sh.sheet;
        var index = sheet.insertRule(rawCss, sheet.cssRules.length);
        var rule = (sheet.cssRules || sheet.rules)[index];

        // Keep track of `index` where rule was inserted in the sheet. This is
        // needed for rule deletion.
        rule.index = index;

        if (prelude) {
            // If rule has media query (it has prelude), move style (CSSStyleDeclaration)
            // object to the "top" to normalize it with a rule without the media
            // query, so that both rules have `.style` property available.
            var selectorRule = (rule.cssRules || rule.rules)[0];
            rule.style = selectorRule.style;
            rule.styleMap = selectorRule.styleMap;
        }

        return rule;
    };
};


/***/ }),

/***/ "./node_modules/nano-css/addon/vcssom.js":
/*!***********************************************!*\
  !*** ./node_modules/nano-css/addon/vcssom.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var removeRule = __webpack_require__(/*! ./vcssom/removeRule */ "./node_modules/nano-css/addon/vcssom/removeRule.js").removeRule;

exports.addon = function (renderer) {
    // VCSSOM support only browser environment.
    if (!renderer.client) return;

    if (true) {
        __webpack_require__(/*! ./__dev__/warnOnMissingDependencies */ "./node_modules/nano-css/addon/__dev__/warnOnMissingDependencies.js")('cssom', renderer, ['createRule']); // cssom
    }

    var kebab = renderer.kebab;

    function VRule (selector, prelude) {
        this.rule = renderer.createRule(selector, prelude);
        this.decl = {};
    }
    VRule.prototype.diff = function (newDecl) {
        var oldDecl = this.decl;
        var style = this.rule.style;
        var property;
        for (property in oldDecl)
            if (newDecl[property] === undefined)
                style.removeProperty(property);
        for (property in newDecl)
            if (newDecl[property] !== oldDecl[property])
                style.setProperty(kebab(property), newDecl[property]);
        this.decl = newDecl;
    };
    VRule.prototype.del = function () {
        removeRule(this.rule);
    };

    function VSheet () {
        /**
         * {
         *   '<at-rule-prelude>': {
         *     '<selector>': {
         *       color: 'red
         *     }
         *   }
         * }
         */
        this.tree = {};
    }
    VSheet.prototype.diff = function (newTree) {
        var oldTree = this.tree;

        // Remove media queries not present in new tree.
        for (var prelude in oldTree) {
            if (newTree[prelude] === undefined) {
                var rules = oldTree[prelude];
                for (var selector in rules)
                    rules[selector].del();
            }
        }

        for (var prelude in newTree) {
            if (oldTree[prelude] === undefined) {
                // Whole media query is new.
                for (var selector in newTree[prelude]) {
                    var rule = new VRule(selector, prelude);
                    rule.diff(newTree[prelude][selector]);
                    newTree[prelude][selector] = rule;
                }
            } else {
                // Old tree already has rules with this media query.
                var oldRules = oldTree[prelude];
                var newRules = newTree[prelude];

                // Remove rules not present in new tree.
                for (var selector in oldRules)
                    if (!newRules[selector])
                        oldRules[selector].del();

                // Apply new rules.
                for (var selector in newRules) {
                    var rule = oldRules[selector];
                    if (rule) {
                        rule.diff(newRules[selector]);
                        newRules[selector] = rule;
                    } else {
                        rule = new VRule(selector, prelude);
                        rule.diff(newRules[selector]);
                        newRules[selector] = rule;
                    }
                }
            }
        }

        this.tree = newTree;
    };

    renderer.VRule = VRule;
    renderer.VSheet = VSheet;
};


/***/ }),

/***/ "./node_modules/nano-css/addon/vcssom/cssToTree.js":
/*!*********************************************************!*\
  !*** ./node_modules/nano-css/addon/vcssom/cssToTree.js ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function cssToTree (tree, css, selector, prelude) {
    var declarations = {};
    var hasDeclarations = false;
    var key, value;

    for (key in css) {
        value = css[key];
        if (typeof value !== 'object') {
            hasDeclarations = true;
            declarations[key] = value;
        }
    }

    if (hasDeclarations) {
        if (!tree[prelude]) tree[prelude] = {};
        tree[prelude][selector] = declarations;
    }

    for (key in css) {
        value = css[key];
        if (typeof value === 'object') {
            if (key[0] === '@') {
                cssToTree(tree, value, selector, key);
            } else {
                var hasCurrentSymbol = key.indexOf('&') > -1;
                var selectorParts = selector.split(',');
                if (hasCurrentSymbol) {
                    for (var i = 0; i < selectorParts.length; i++) {
                        selectorParts[i] = key.replace(/&/g, selectorParts[i]);
                    }
                } else {
                    for (var i = 0; i < selectorParts.length; i++) {
                        selectorParts[i] = selectorParts[i] + ' ' + key;
                    }
                }
                cssToTree(tree, value, selectorParts.join(','), prelude);
            }
        }
    }
};

exports.cssToTree = cssToTree;


/***/ }),

/***/ "./node_modules/nano-css/addon/vcssom/removeRule.js":
/*!**********************************************************!*\
  !*** ./node_modules/nano-css/addon/vcssom/removeRule.js ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function removeRule (rule) {
    var maxIndex = rule.index;
    var sh = rule.parentStyleSheet;
    var rules = sh.cssRules || sh.rules;
    maxIndex = Math.max(maxIndex, rules.length - 1);
    while (maxIndex >= 0) {
        if (rules[maxIndex] === rule) {
            sh.deleteRule(maxIndex);
            break;
        }
        maxIndex--;
    }
}

exports.removeRule = removeRule;


/***/ }),

/***/ "./node_modules/nano-css/index.js":
/*!****************************************!*\
  !*** ./node_modules/nano-css/index.js ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var KEBAB_REGEX = /[A-Z]/g;

var hash = function (str) {
    var hash = 5381, i = str.length;

    while (i) hash = (hash * 33) ^ str.charCodeAt(--i);

    return '_' + (hash >>> 0).toString(36);
};

exports.create = function (config) {
    config = config || {};
    var assign = config.assign || Object.assign;
    var client = "object" === 'object';

    // Check if we are really in browser environment.
    if (true) {
        if (client) {
            if ((typeof document !== 'object') || !document.getElementsByTagName('HTML')) {
                console.error(
                    'nano-css detected browser environment because of "window" global, but ' +
                    '"document" global seems to be defective.'
                );
            }
        }
    }

    var renderer = assign({
        raw: '',
        pfx: '_',
        client: client,
        assign: assign,
        stringify: JSON.stringify,
        kebab: function (prop) {
            return prop.replace(KEBAB_REGEX, '-$&').toLowerCase();
        },
        decl: function (key, value) {
            key = renderer.kebab(key);
            return key + ':' + value + ';';
        },
        hash: function (obj) {
            return hash(renderer.stringify(obj));
        },
        selector: function (parent, selector) {
            return parent + (selector[0] === ':' ? ''  : ' ') + selector;
        },
        putRaw: function (rawCssRule) {
            renderer.raw += rawCssRule;
        },
    }, config);

    if (renderer.client) {
        if (!renderer.sh)
            document.head.appendChild(renderer.sh = document.createElement('style'));

        if (true) {
            renderer.sh.setAttribute('data-nano-css-dev', '');

            // Test style sheet used in DEV mode to test if .insetRule() would throw.
            renderer.shTest = document.createElement('style');
            renderer.shTest.setAttribute('data-nano-css-dev-tests', '');
            document.head.appendChild(renderer.shTest);
        }

        renderer.putRaw = function (rawCssRule) {
            // .insertRule() is faster than .appendChild(), that's why we use it in PROD.
            // But CSS injected using .insertRule() is not displayed in Chrome Devtools,
            // that's why we use .appendChild in DEV.
            if (false) { var sheet; } else {
                // Test if .insertRule() works in dev mode. Unknown pseudo-selectors will throw when
                // .insertRule() is used, but .appendChild() will not throw.
                try {
                    renderer.shTest.sheet.insertRule(rawCssRule, renderer.shTest.sheet.cssRules.length);
                } catch (error) {
                    if (config.verbose) {
                        console.error(error);
                    }
                }

                // Insert pretty-printed CSS for dev mode.
                renderer.sh.appendChild(document.createTextNode(rawCssRule));
            }
        };
    }

    renderer.put = function (selector, decls, atrule) {
        var str = '';
        var prop, value;
        var postponed = [];

        for (prop in decls) {
            value = decls[prop];

            if ((value instanceof Object) && !(value instanceof Array)) {
                postponed.push(prop);
            } else {
                if (( true) && !renderer.sourcemaps) {
                    str += '    ' + renderer.decl(prop, value, selector, atrule) + '\n';
                } else {
                    str += renderer.decl(prop, value, selector, atrule);
                }
            }
        }

        if (str) {
            if (( true) && !renderer.sourcemaps) {
                str = '\n' + selector + ' {\n' + str + '}\n';
            } else {
                str = selector + '{' + str + '}';
            }
            renderer.putRaw(atrule ? atrule + '{' + str + '}' : str);
        }

        for (var i = 0; i < postponed.length; i++) {
            prop = postponed[i];

            if (prop[0] === "@" && prop !== "@font-face") {
                renderer.putAt(selector, decls[prop], prop);
            } else {
                renderer.put(renderer.selector(selector, prop), decls[prop], atrule);
            }
        }
    };

    renderer.putAt = renderer.put;

    return renderer;
};


/***/ }),

/***/ "./node_modules/next-server/dist/lib/mitt.js":
/*!***************************************************!*\
  !*** ./node_modules/next-server/dist/lib/mitt.js ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

/*
MIT License

Copyright (c) Jason Miller (https://jasonformat.com/)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _create = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/create */ "./node_modules/@babel/runtime-corejs2/core-js/object/create.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

function mitt() {
  var all = (0, _create["default"])(null);
  return {
    on: function on(type, handler) {
      ;
      (all[type] || (all[type] = [])).push(handler);
    },
    off: function off(type, handler) {
      if (all[type]) {
        // tslint:disable-next-line:no-bitwise
        all[type].splice(all[type].indexOf(handler) >>> 0, 1);
      }
    },
    emit: function emit(type) {
      for (var _len = arguments.length, evts = new Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
        evts[_key - 1] = arguments[_key];
      }

      ;
      (all[type] || []).slice().map(function (handler) {
        handler.apply(void 0, evts);
      });
    }
  };
}

exports["default"] = mitt;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router-context.js":
/*!*************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router-context.js ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

var __importStar = void 0 && (void 0).__importStar || function (mod) {
  if (mod && mod.__esModule) return mod;
  var result = {};
  if (mod != null) for (var k in mod) {
    if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
  }
  result["default"] = mod;
  return result;
};

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

var React = __importStar(__webpack_require__(/*! react */ "./node_modules/react/index.js"));

exports.RouterContext = React.createContext(null);

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router/rewrite-url-for-export.js":
/*!****************************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router/rewrite-url-for-export.js ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _slicedToArray2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

function rewriteUrlForNextExport(url) {
  var _url$split = url.split('#'),
      _url$split2 = (0, _slicedToArray2["default"])(_url$split, 2),
      pathname = _url$split2[0],
      hash = _url$split2[1]; // tslint:disable-next-line


  var _pathname$split = pathname.split('?'),
      _pathname$split2 = (0, _slicedToArray2["default"])(_pathname$split, 2),
      path = _pathname$split2[0],
      qs = _pathname$split2[1];

  path = path.replace(/\/$/, ''); // Append a trailing slash if this path does not have an extension

  if (!/\.[^/]+\/?$/.test(path)) path += "/";
  if (qs) path += '?' + qs;
  if (hash) path += '#' + hash;
  return path;
}

exports.rewriteUrlForNextExport = rewriteUrlForNextExport;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router/router.js":
/*!************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router/router.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _regenerator = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/regenerator */ "./node_modules/@babel/runtime-corejs2/regenerator/index.js"));

var _asyncToGenerator2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/asyncToGenerator */ "./node_modules/@babel/runtime-corejs2/helpers/esm/asyncToGenerator.js"));

var _slicedToArray2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js"));

var _promise = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/promise */ "./node_modules/@babel/runtime-corejs2/core-js/promise.js"));

var _assign = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/assign */ "./node_modules/@babel/runtime-corejs2/core-js/object/assign.js"));

var _classCallCheck2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/classCallCheck */ "./node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js"));

var _createClass2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/createClass */ "./node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

var __importDefault = void 0 && (void 0).__importDefault || function (mod) {
  return mod && mod.__esModule ? mod : {
    "default": mod
  };
};

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

var url_1 = __webpack_require__(/*! url */ "./node_modules/url/url.js");

var mitt_1 = __importDefault(__webpack_require__(/*! ../mitt */ "./node_modules/next-server/dist/lib/mitt.js"));

var utils_1 = __webpack_require__(/*! ../utils */ "./node_modules/next-server/dist/lib/utils.js");

var rewrite_url_for_export_1 = __webpack_require__(/*! ./rewrite-url-for-export */ "./node_modules/next-server/dist/lib/router/rewrite-url-for-export.js");

var route_matcher_1 = __webpack_require__(/*! ./utils/route-matcher */ "./node_modules/next-server/dist/lib/router/utils/route-matcher.js");

var route_regex_1 = __webpack_require__(/*! ./utils/route-regex */ "./node_modules/next-server/dist/lib/router/utils/route-regex.js");

var is_dynamic_1 = __webpack_require__(/*! ./utils/is-dynamic */ "./node_modules/next-server/dist/lib/router/utils/is-dynamic.js");

function toRoute(path) {
  return path.replace(/\/$/, '') || '/';
}

var Router =
/*#__PURE__*/
function () {
  function Router(pathname, query, as, _ref) {
    var _this = this;

    var initialProps = _ref.initialProps,
        pageLoader = _ref.pageLoader,
        App = _ref.App,
        wrapApp = _ref.wrapApp,
        Component = _ref.Component,
        err = _ref.err,
        subscription = _ref.subscription;
    (0, _classCallCheck2["default"])(this, Router);

    this.onPopState = function (e) {
      if (!e.state) {
        // We get state as undefined for two reasons.
        //  1. With older safari (< 8) and older chrome (< 34)
        //  2. When the URL changed with #
        //
        // In the both cases, we don't need to proceed and change the route.
        // (as it's already changed)
        // But we can simply replace the state with the new changes.
        // Actually, for (1) we don't need to nothing. But it's hard to detect that event.
        // So, doing the following for (1) does no harm.
        var _pathname = _this.pathname,
            _query = _this.query;

        _this.changeState('replaceState', utils_1.formatWithValidation({
          pathname: _pathname,
          query: _query
        }), utils_1.getURL());

        return;
      } // Make sure we don't re-render on initial load,
      // can be caused by navigating back from an external site


      if (e.state.options && e.state.options.fromExternal) {
        return;
      } // If the downstream application returns falsy, return.
      // They will then be responsible for handling the event.


      if (_this._bps && !_this._bps(e.state)) {
        return;
      }

      var _e$state = e.state,
          url = _e$state.url,
          as = _e$state.as,
          options = _e$state.options;

      if (true) {
        if (typeof url === 'undefined' || typeof as === 'undefined') {
          console.warn('`popstate` event triggered but `event.state` did not have `url` or `as` https://err.sh/zeit/next.js/popstate-state-empty');
        }
      }

      _this.replace(url, as, options);
    }; // represents the current component key


    this.route = toRoute(pathname); // set up the component cache (by route keys)

    this.components = {}; // We should not keep the cache, if there's an error
    // Otherwise, this cause issues when when going back and
    // come again to the errored page.

    if (pathname !== '/_error') {
      this.components[this.route] = {
        Component: Component,
        props: initialProps,
        err: err
      };
    }

    this.components['/_app'] = {
      Component: App
    }; // Backwards compat for Router.router.events
    // TODO: Should be remove the following major version as it was never documented
    // @ts-ignore backwards compatibility

    this.events = Router.events;
    this.pageLoader = pageLoader;
    this.pathname = pathname;
    this.query = query;
    this.asPath = as;
    this.sub = subscription;
    this.clc = null;
    this._wrapApp = wrapApp;

    if (true) {
      // in order for `e.state` to work on the `onpopstate` event
      // we have to register the initial route upon initialization
      this.changeState('replaceState', utils_1.formatWithValidation({
        pathname: pathname,
        query: query
      }), as);
      window.addEventListener('popstate', this.onPopState);
      window.addEventListener('unload', function () {
        // Workaround for popstate firing on initial page load when
        // navigating back from an external site
        if (history.state) {
          var _history$state = history.state,
              url = _history$state.url,
              _as2 = _history$state.as,
              options = _history$state.options;

          _this.changeState('replaceState', url, _as2, (0, _assign["default"])({}, options, {
            fromExternal: true
          }));
        }
      });
    }
  }

  (0, _createClass2["default"])(Router, [{
    key: "update",
    value: function update(route, Component) {
      var data = this.components[route];

      if (!data) {
        throw new Error("Cannot update unavailable route: ".concat(route));
      }

      var newData = (0, _assign["default"])({}, data, {
        Component: Component
      });
      this.components[route] = newData; // pages/_app.js updated

      if (route === '/_app') {
        this.notify(this.components[this.route]);
        return;
      }

      if (route === this.route) {
        this.notify(newData);
      }
    }
  }, {
    key: "reload",
    value: function reload() {
      window.location.reload();
    }
    /**
     * Go back in history
     */

  }, {
    key: "back",
    value: function back() {
      window.history.back();
    }
    /**
     * Performs a `pushState` with arguments
     * @param url of the route
     * @param as masks `url` for the browser
     * @param options object you can define `shallow` and other options
     */

  }, {
    key: "push",
    value: function push(url) {
      var as = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : url;
      var options = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : {};
      return this.change('pushState', url, as, options);
    }
    /**
     * Performs a `replaceState` with arguments
     * @param url of the route
     * @param as masks `url` for the browser
     * @param options object you can define `shallow` and other options
     */

  }, {
    key: "replace",
    value: function replace(url) {
      var as = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : url;
      var options = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : {};
      return this.change('replaceState', url, as, options);
    }
  }, {
    key: "change",
    value: function change(method, _url, _as, options) {
      var _this2 = this;

      return new _promise["default"](function (resolve, reject) {
        // If url and as provided as an object representation,
        // we'll format them into the string version here.
        var url = typeof _url === 'object' ? utils_1.formatWithValidation(_url) : _url;
        var as = typeof _as === 'object' ? utils_1.formatWithValidation(_as) : _as; // Add the ending slash to the paths. So, we can serve the
        // "<page>/index.html" directly for the SSR page.

        if (false) {}

        _this2.abortComponentLoad(as); // If the url change is only related to a hash change
        // We should not proceed. We should only change the state.
        // WARNING: `_h` is an internal option for handing Next.js client-side
        // hydration. Your app should _never_ use this property. It may change at
        // any time without notice.


        if (!options._h && _this2.onlyAHashChange(as)) {
          _this2.asPath = as;
          Router.events.emit('hashChangeStart', as);

          _this2.changeState(method, url, as);

          _this2.scrollToHash(as);

          Router.events.emit('hashChangeComplete', as);
          return resolve(true);
        }

        var _url_1$parse = url_1.parse(url, true),
            pathname = _url_1$parse.pathname,
            query = _url_1$parse.query; // If asked to change the current URL we should reload the current page
        // (not location.reload() but reload getInitialProps and other Next.js stuffs)
        // We also need to set the method = replaceState always
        // as this should not go into the history (That's how browsers work)
        // We should compare the new asPath to the current asPath, not the url


        if (!_this2.urlIsNew(as)) {
          method = 'replaceState';
        } // @ts-ignore pathname is always a string


        var route = toRoute(pathname);
        var _options$shallow = options.shallow,
            shallow = _options$shallow === void 0 ? false : _options$shallow;

        if (is_dynamic_1.isDynamicRoute(route)) {
          var _url_1$parse2 = url_1.parse(as),
              asPathname = _url_1$parse2.pathname;

          var rr = route_regex_1.getRouteRegex(route);
          var routeMatch = route_matcher_1.getRouteMatcher(rr)(asPathname);

          if (!routeMatch) {
            console.error("Your `<Link>`'s `as` value is incompatible with the `href` value. This is invalid.");
            return resolve(false);
          } // Merge params into `query`, overwriting any specified in search


          (0, _assign["default"])(query, routeMatch);
        }

        Router.events.emit('routeChangeStart', as); // If shallow is true and the route exists in the router cache we reuse the previous result
        // @ts-ignore pathname is always a string

        _this2.getRouteInfo(route, pathname, query, as, shallow).then(function (routeInfo) {
          var error = routeInfo.error;

          if (error && error.cancelled) {
            return resolve(false);
          }

          Router.events.emit('beforeHistoryChange', as);

          _this2.changeState(method, url, as, options);

          var hash = window.location.hash.substring(1);

          if (true) {
            var appComp = _this2.components['/_app'].Component;
            window.next.isPrerendered = appComp.getInitialProps === appComp.origGetInitialProps && !routeInfo.Component.getInitialProps;
          } // @ts-ignore pathname is always defined


          _this2.set(route, pathname, query, as, (0, _assign["default"])({}, routeInfo, {
            hash: hash
          }));

          if (error) {
            Router.events.emit('routeChangeError', error, as);
            throw error;
          }

          Router.events.emit('routeChangeComplete', as);
          return resolve(true);
        }, reject);
      });
    }
  }, {
    key: "changeState",
    value: function changeState(method, url, as) {
      var options = arguments.length > 3 && arguments[3] !== undefined ? arguments[3] : {};

      if (true) {
        if (typeof window.history === 'undefined') {
          console.error("Warning: window.history is not available.");
          return;
        } // @ts-ignore method should always exist on history


        if (typeof window.history[method] === 'undefined') {
          console.error("Warning: window.history.".concat(method, " is not available"));
          return;
        }
      }

      if (method !== 'pushState' || utils_1.getURL() !== as) {
        // @ts-ignore method should always exist on history
        window.history[method]({
          url: url,
          as: as,
          options: options
        }, null, as);
      }
    }
  }, {
    key: "getRouteInfo",
    value: function getRouteInfo(route, pathname, query, as) {
      var _this3 = this;

      var shallow = arguments.length > 4 && arguments[4] !== undefined ? arguments[4] : false;
      var cachedRouteInfo = this.components[route]; // If there is a shallow route transition possible
      // If the route is already rendered on the screen.

      if (shallow && cachedRouteInfo && this.route === route) {
        return _promise["default"].resolve(cachedRouteInfo);
      }

      return new _promise["default"](function (resolve, reject) {
        if (cachedRouteInfo) {
          return resolve(cachedRouteInfo);
        }

        _this3.fetchComponent(route).then(function (Component) {
          return resolve({
            Component: Component
          });
        }, reject);
      }).then(function (routeInfo) {
        var Component = routeInfo.Component;

        if (true) {
          var _require = __webpack_require__(/*! react-is */ "./node_modules/next-server/node_modules/react-is/index.js"),
              isValidElementType = _require.isValidElementType;

          if (!isValidElementType(Component)) {
            throw new Error("The default export is not a React Component in page: \"".concat(pathname, "\""));
          }
        }

        return new _promise["default"](function (resolve, reject) {
          var ctx = {
            pathname: pathname,
            query: query,
            asPath: as
          };

          _this3.getInitialProps(Component, ctx).then(function (props) {
            // if data is inlined during prerender it is a string
            if (props && typeof props.pageProps === 'string') {
              props.pageProps = JSON.parse(props.pageProps);
            }

            routeInfo.props = props;
            _this3.components[route] = routeInfo;
            resolve(routeInfo);
          }, reject);
        });
      })["catch"](function (err) {
        return new _promise["default"](function (resolve) {
          if (err.code === 'PAGE_LOAD_ERROR') {
            // If we can't load the page it could be one of following reasons
            //  1. Page doesn't exists
            //  2. Page does exist in a different zone
            //  3. Internal error while loading the page
            // So, doing a hard reload is the proper way to deal with this.
            window.location.href = as; // Changing the URL doesn't block executing the current code path.
            // So, we need to mark it as a cancelled error and stop the routing logic.

            err.cancelled = true; // @ts-ignore TODO: fix the control flow here

            return resolve({
              error: err
            });
          }

          if (err.cancelled) {
            // @ts-ignore TODO: fix the control flow here
            return resolve({
              error: err
            });
          }

          resolve(_this3.fetchComponent('/_error').then(function (Component) {
            var routeInfo = {
              Component: Component,
              err: err
            };
            var ctx = {
              err: err,
              pathname: pathname,
              query: query
            };
            return new _promise["default"](function (resolve) {
              _this3.getInitialProps(Component, ctx).then(function (props) {
                routeInfo.props = props;
                routeInfo.error = err;
                resolve(routeInfo);
              }, function (gipErr) {
                console.error('Error in error page `getInitialProps`: ', gipErr);
                routeInfo.error = err;
                routeInfo.props = {};
                resolve(routeInfo);
              });
            });
          }));
        });
      });
    }
  }, {
    key: "set",
    value: function set(route, pathname, query, as, data) {
      this.route = route;
      this.pathname = pathname;
      this.query = query;
      this.asPath = as;
      this.notify(data);
    }
    /**
     * Callback to execute before replacing router state
     * @param cb callback to be executed
     */

  }, {
    key: "beforePopState",
    value: function beforePopState(cb) {
      this._bps = cb;
    }
  }, {
    key: "onlyAHashChange",
    value: function onlyAHashChange(as) {
      if (!this.asPath) return false;

      var _this$asPath$split = this.asPath.split('#'),
          _this$asPath$split2 = (0, _slicedToArray2["default"])(_this$asPath$split, 2),
          oldUrlNoHash = _this$asPath$split2[0],
          oldHash = _this$asPath$split2[1];

      var _as$split = as.split('#'),
          _as$split2 = (0, _slicedToArray2["default"])(_as$split, 2),
          newUrlNoHash = _as$split2[0],
          newHash = _as$split2[1]; // Makes sure we scroll to the provided hash if the url/hash are the same


      if (newHash && oldUrlNoHash === newUrlNoHash && oldHash === newHash) {
        return true;
      } // If the urls are change, there's more than a hash change


      if (oldUrlNoHash !== newUrlNoHash) {
        return false;
      } // If the hash has changed, then it's a hash only change.
      // This check is necessary to handle both the enter and
      // leave hash === '' cases. The identity case falls through
      // and is treated as a next reload.


      return oldHash !== newHash;
    }
  }, {
    key: "scrollToHash",
    value: function scrollToHash(as) {
      var _as$split3 = as.split('#'),
          _as$split4 = (0, _slicedToArray2["default"])(_as$split3, 2),
          hash = _as$split4[1]; // Scroll to top if the hash is just `#` with no value


      if (hash === '') {
        window.scrollTo(0, 0);
        return;
      } // First we check if the element by id is found


      var idEl = document.getElementById(hash);

      if (idEl) {
        idEl.scrollIntoView();
        return;
      } // If there's no element with the id, we check the `name` property
      // To mirror browsers


      var nameEl = document.getElementsByName(hash)[0];

      if (nameEl) {
        nameEl.scrollIntoView();
      }
    }
  }, {
    key: "urlIsNew",
    value: function urlIsNew(asPath) {
      return this.asPath !== asPath;
    }
    /**
     * Prefetch `page` code, you may wait for the data during `page` rendering.
     * This feature only works in production!
     * @param url of prefetched `page`
     */

  }, {
    key: "prefetch",
    value: function prefetch(url) {
      var _this4 = this;

      return new _promise["default"](function (resolve, reject) {
        // Prefetch is not supported in development mode because it would trigger on-demand-entries
        if (true) return;

        var _url_1$parse3 = url_1.parse(url),
            pathname = _url_1$parse3.pathname; // @ts-ignore pathname is always defined


        var route = toRoute(pathname);

        _this4.pageLoader.prefetch(route).then(resolve, reject);
      });
    }
  }, {
    key: "fetchComponent",
    value: function () {
      var _fetchComponent = (0, _asyncToGenerator2["default"])(
      /*#__PURE__*/
      _regenerator["default"].mark(function _callee(route) {
        var cancelled, cancel, Component, error;
        return _regenerator["default"].wrap(function _callee$(_context) {
          while (1) {
            switch (_context.prev = _context.next) {
              case 0:
                cancelled = false;

                cancel = this.clc = function () {
                  cancelled = true;
                };

                _context.next = 4;
                return this.pageLoader.loadPage(route);

              case 4:
                Component = _context.sent;

                if (!cancelled) {
                  _context.next = 9;
                  break;
                }

                error = new Error("Abort fetching component for route: \"".concat(route, "\""));
                error.cancelled = true;
                throw error;

              case 9:
                if (cancel === this.clc) {
                  this.clc = null;
                }

                return _context.abrupt("return", Component);

              case 11:
              case "end":
                return _context.stop();
            }
          }
        }, _callee, this);
      }));

      function fetchComponent(_x) {
        return _fetchComponent.apply(this, arguments);
      }

      return fetchComponent;
    }()
  }, {
    key: "getInitialProps",
    value: function () {
      var _getInitialProps = (0, _asyncToGenerator2["default"])(
      /*#__PURE__*/
      _regenerator["default"].mark(function _callee2(Component, ctx) {
        var cancelled, cancel, App, props, err;
        return _regenerator["default"].wrap(function _callee2$(_context2) {
          while (1) {
            switch (_context2.prev = _context2.next) {
              case 0:
                cancelled = false;

                cancel = function cancel() {
                  cancelled = true;
                };

                this.clc = cancel;
                App = this.components['/_app'].Component;
                _context2.next = 6;
                return utils_1.loadGetInitialProps(App, {
                  AppTree: this._wrapApp(App),
                  Component: Component,
                  router: this,
                  ctx: ctx
                });

              case 6:
                props = _context2.sent;

                if (cancel === this.clc) {
                  this.clc = null;
                }

                if (!cancelled) {
                  _context2.next = 12;
                  break;
                }

                err = new Error('Loading initial props cancelled');
                err.cancelled = true;
                throw err;

              case 12:
                return _context2.abrupt("return", props);

              case 13:
              case "end":
                return _context2.stop();
            }
          }
        }, _callee2, this);
      }));

      function getInitialProps(_x2, _x3) {
        return _getInitialProps.apply(this, arguments);
      }

      return getInitialProps;
    }()
  }, {
    key: "abortComponentLoad",
    value: function abortComponentLoad(as) {
      if (this.clc) {
        var e = new Error('Route Cancelled');
        e.cancelled = true;
        Router.events.emit('routeChangeError', e, as);
        this.clc();
        this.clc = null;
      }
    }
  }, {
    key: "notify",
    value: function notify(data) {
      this.sub(data, this.components['/_app'].Component);
    }
  }], [{
    key: "_rewriteUrlForNextExport",
    value: function _rewriteUrlForNextExport(url) {
      return rewrite_url_for_export_1.rewriteUrlForNextExport(url);
    }
  }]);
  return Router;
}();

Router.events = mitt_1["default"]();
exports["default"] = Router;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router/utils/is-dynamic.js":
/*!**********************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router/utils/is-dynamic.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
}); // Identify /[param]/ in route string

var TEST_ROUTE = /\/\[[^\/]+?\](?=\/|$)/;

function isDynamicRoute(route) {
  return TEST_ROUTE.test(route);
}

exports.isDynamicRoute = isDynamicRoute;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router/utils/route-matcher.js":
/*!*************************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router/utils/route-matcher.js ***!
  \*************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _keys = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/keys */ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

function getRouteMatcher(routeRegex) {
  var re = routeRegex.re,
      groups = routeRegex.groups;
  return function (pathname) {
    var routeMatch = re.exec(pathname);

    if (!routeMatch) {
      return false;
    }

    var params = {};
    (0, _keys["default"])(groups).forEach(function (slugName) {
      var m = routeMatch[groups[slugName]];

      if (m !== undefined) {
        params[slugName] = decodeURIComponent(m);
      }
    });
    return params;
  };
}

exports.getRouteMatcher = getRouteMatcher;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/router/utils/route-regex.js":
/*!***********************************************************************!*\
  !*** ./node_modules/next-server/dist/lib/router/utils/route-regex.js ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

function getRouteRegex(normalizedRoute) {
  // Escape all characters that could be considered RegEx
  var escapedRoute = (normalizedRoute.replace(/\/$/, '') || '/').replace(/[|\\{}()[\]^$+*?.-]/g, '\\$&');
  var groups = {};
  var groupIndex = 1;
  var parameterizedRoute = escapedRoute.replace(/\/\\\[([^\/]+?)\\\](?=\/|$)/g, function (_, $1) {
    return groups[$1 // Un-escape key
    .replace(/\\([|\\{}()[\]^$+*?.-])/g, '$1')] = groupIndex++, '/([^/]+?)';
  });
  return {
    re: new RegExp('^' + parameterizedRoute + '(?:/)?$', 'i'),
    groups: groups
  };
}

exports.getRouteRegex = getRouteRegex;

/***/ }),

/***/ "./node_modules/next-server/dist/lib/utils.js":
/*!****************************************************!*\
  !*** ./node_modules/next-server/dist/lib/utils.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _regenerator = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/regenerator */ "./node_modules/@babel/runtime-corejs2/regenerator/index.js"));

var _keys = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/keys */ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js"));

var _asyncToGenerator2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/asyncToGenerator */ "./node_modules/@babel/runtime-corejs2/helpers/esm/asyncToGenerator.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

(0, _defineProperty["default"])(exports, "__esModule", {
  value: true
});

var url_1 = __webpack_require__(/*! url */ "./node_modules/url/url.js");
/**
 * Utils
 */


function execOnce(fn) {
  var _this = this;

  var used = false;
  return function () {
    if (!used) {
      used = true;

      for (var _len = arguments.length, args = new Array(_len), _key = 0; _key < _len; _key++) {
        args[_key] = arguments[_key];
      }

      fn.apply(_this, args);
    }
  };
}

exports.execOnce = execOnce;

function getLocationOrigin() {
  var _window$location = window.location,
      protocol = _window$location.protocol,
      hostname = _window$location.hostname,
      port = _window$location.port;
  return "".concat(protocol, "//").concat(hostname).concat(port ? ':' + port : '');
}

exports.getLocationOrigin = getLocationOrigin;

function getURL() {
  var href = window.location.href;
  var origin = getLocationOrigin();
  return href.substring(origin.length);
}

exports.getURL = getURL;

function getDisplayName(Component) {
  return typeof Component === 'string' ? Component : Component.displayName || Component.name || 'Unknown';
}

exports.getDisplayName = getDisplayName;

function isResSent(res) {
  return res.finished || res.headersSent;
}

exports.isResSent = isResSent;

function loadGetInitialProps(_x, _x2) {
  return _loadGetInitialProps.apply(this, arguments);
}

function _loadGetInitialProps() {
  _loadGetInitialProps = (0, _asyncToGenerator2["default"])(
  /*#__PURE__*/
  _regenerator["default"].mark(function _callee(Component, ctx) {
    var message, res, props, _message;

    return _regenerator["default"].wrap(function _callee$(_context) {
      while (1) {
        switch (_context.prev = _context.next) {
          case 0:
            if (false) {}

            if (!(Component.prototype && Component.prototype.getInitialProps)) {
              _context.next = 4;
              break;
            }

            message = "\"".concat(getDisplayName(Component), ".getInitialProps()\" is defined as an instance method - visit https://err.sh/zeit/next.js/get-initial-props-as-an-instance-method for more information.");
            throw new Error(message);

          case 4:
            // when called from _app `ctx` is nested in `ctx`
            res = ctx.res || ctx.ctx && ctx.ctx.res;

            if (Component.getInitialProps) {
              _context.next = 7;
              break;
            }

            return _context.abrupt("return", {});

          case 7:
            _context.next = 9;
            return Component.getInitialProps(ctx);

          case 9:
            props = _context.sent;

            if (!(res && isResSent(res))) {
              _context.next = 12;
              break;
            }

            return _context.abrupt("return", props);

          case 12:
            if (props) {
              _context.next = 15;
              break;
            }

            _message = "\"".concat(getDisplayName(Component), ".getInitialProps()\" should resolve to an object. But found \"").concat(props, "\" instead.");
            throw new Error(_message);

          case 15:
            return _context.abrupt("return", props);

          case 16:
          case "end":
            return _context.stop();
        }
      }
    }, _callee);
  }));
  return _loadGetInitialProps.apply(this, arguments);
}

exports.loadGetInitialProps = loadGetInitialProps;
exports.urlObjectKeys = ['auth', 'hash', 'host', 'hostname', 'href', 'path', 'pathname', 'port', 'protocol', 'query', 'search', 'slashes'];

function formatWithValidation(url, options) {
  if (true) {
    if (url !== null && typeof url === 'object') {
      (0, _keys["default"])(url).forEach(function (key) {
        if (exports.urlObjectKeys.indexOf(key) === -1) {
          console.warn("Unknown key passed via urlObject into url.format: ".concat(key));
        }
      });
    }
  }

  return url_1.format(url, options);
}

exports.formatWithValidation = formatWithValidation;

/***/ }),

/***/ "./node_modules/next-server/node_modules/react-is/cjs/react-is.development.js":
/*!************************************************************************************!*\
  !*** ./node_modules/next-server/node_modules/react-is/cjs/react-is.development.js ***!
  \************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/** @license React v16.8.6
 * react-is.development.js
 *
 * Copyright (c) Facebook, Inc. and its affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */





if (true) {
  (function() {
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

// The Symbol used to tag the ReactElement-like types. If there is no native Symbol
// nor polyfill, then a plain number is used for performance.
var hasSymbol = typeof Symbol === 'function' && Symbol.for;

var REACT_ELEMENT_TYPE = hasSymbol ? Symbol.for('react.element') : 0xeac7;
var REACT_PORTAL_TYPE = hasSymbol ? Symbol.for('react.portal') : 0xeaca;
var REACT_FRAGMENT_TYPE = hasSymbol ? Symbol.for('react.fragment') : 0xeacb;
var REACT_STRICT_MODE_TYPE = hasSymbol ? Symbol.for('react.strict_mode') : 0xeacc;
var REACT_PROFILER_TYPE = hasSymbol ? Symbol.for('react.profiler') : 0xead2;
var REACT_PROVIDER_TYPE = hasSymbol ? Symbol.for('react.provider') : 0xeacd;
var REACT_CONTEXT_TYPE = hasSymbol ? Symbol.for('react.context') : 0xeace;
var REACT_ASYNC_MODE_TYPE = hasSymbol ? Symbol.for('react.async_mode') : 0xeacf;
var REACT_CONCURRENT_MODE_TYPE = hasSymbol ? Symbol.for('react.concurrent_mode') : 0xeacf;
var REACT_FORWARD_REF_TYPE = hasSymbol ? Symbol.for('react.forward_ref') : 0xead0;
var REACT_SUSPENSE_TYPE = hasSymbol ? Symbol.for('react.suspense') : 0xead1;
var REACT_MEMO_TYPE = hasSymbol ? Symbol.for('react.memo') : 0xead3;
var REACT_LAZY_TYPE = hasSymbol ? Symbol.for('react.lazy') : 0xead4;

function isValidElementType(type) {
  return typeof type === 'string' || typeof type === 'function' ||
  // Note: its typeof might be other than 'symbol' or 'number' if it's a polyfill.
  type === REACT_FRAGMENT_TYPE || type === REACT_CONCURRENT_MODE_TYPE || type === REACT_PROFILER_TYPE || type === REACT_STRICT_MODE_TYPE || type === REACT_SUSPENSE_TYPE || typeof type === 'object' && type !== null && (type.$$typeof === REACT_LAZY_TYPE || type.$$typeof === REACT_MEMO_TYPE || type.$$typeof === REACT_PROVIDER_TYPE || type.$$typeof === REACT_CONTEXT_TYPE || type.$$typeof === REACT_FORWARD_REF_TYPE);
}

/**
 * Forked from fbjs/warning:
 * https://github.com/facebook/fbjs/blob/e66ba20ad5be433eb54423f2b097d829324d9de6/packages/fbjs/src/__forks__/warning.js
 *
 * Only change is we use console.warn instead of console.error,
 * and do nothing when 'console' is not supported.
 * This really simplifies the code.
 * ---
 * Similar to invariant but only logs a warning if the condition is not met.
 * This can be used to log issues in development environments in critical
 * paths. Removing the logging code for production environments will keep the
 * same logic and follow the same code paths.
 */

var lowPriorityWarning = function () {};

{
  var printWarning = function (format) {
    for (var _len = arguments.length, args = Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
      args[_key - 1] = arguments[_key];
    }

    var argIndex = 0;
    var message = 'Warning: ' + format.replace(/%s/g, function () {
      return args[argIndex++];
    });
    if (typeof console !== 'undefined') {
      console.warn(message);
    }
    try {
      // --- Welcome to debugging React ---
      // This error was thrown as a convenience so that you can use this stack
      // to find the callsite that caused this warning to fire.
      throw new Error(message);
    } catch (x) {}
  };

  lowPriorityWarning = function (condition, format) {
    if (format === undefined) {
      throw new Error('`lowPriorityWarning(condition, format, ...args)` requires a warning ' + 'message argument');
    }
    if (!condition) {
      for (var _len2 = arguments.length, args = Array(_len2 > 2 ? _len2 - 2 : 0), _key2 = 2; _key2 < _len2; _key2++) {
        args[_key2 - 2] = arguments[_key2];
      }

      printWarning.apply(undefined, [format].concat(args));
    }
  };
}

var lowPriorityWarning$1 = lowPriorityWarning;

function typeOf(object) {
  if (typeof object === 'object' && object !== null) {
    var $$typeof = object.$$typeof;
    switch ($$typeof) {
      case REACT_ELEMENT_TYPE:
        var type = object.type;

        switch (type) {
          case REACT_ASYNC_MODE_TYPE:
          case REACT_CONCURRENT_MODE_TYPE:
          case REACT_FRAGMENT_TYPE:
          case REACT_PROFILER_TYPE:
          case REACT_STRICT_MODE_TYPE:
          case REACT_SUSPENSE_TYPE:
            return type;
          default:
            var $$typeofType = type && type.$$typeof;

            switch ($$typeofType) {
              case REACT_CONTEXT_TYPE:
              case REACT_FORWARD_REF_TYPE:
              case REACT_PROVIDER_TYPE:
                return $$typeofType;
              default:
                return $$typeof;
            }
        }
      case REACT_LAZY_TYPE:
      case REACT_MEMO_TYPE:
      case REACT_PORTAL_TYPE:
        return $$typeof;
    }
  }

  return undefined;
}

// AsyncMode is deprecated along with isAsyncMode
var AsyncMode = REACT_ASYNC_MODE_TYPE;
var ConcurrentMode = REACT_CONCURRENT_MODE_TYPE;
var ContextConsumer = REACT_CONTEXT_TYPE;
var ContextProvider = REACT_PROVIDER_TYPE;
var Element = REACT_ELEMENT_TYPE;
var ForwardRef = REACT_FORWARD_REF_TYPE;
var Fragment = REACT_FRAGMENT_TYPE;
var Lazy = REACT_LAZY_TYPE;
var Memo = REACT_MEMO_TYPE;
var Portal = REACT_PORTAL_TYPE;
var Profiler = REACT_PROFILER_TYPE;
var StrictMode = REACT_STRICT_MODE_TYPE;
var Suspense = REACT_SUSPENSE_TYPE;

var hasWarnedAboutDeprecatedIsAsyncMode = false;

// AsyncMode should be deprecated
function isAsyncMode(object) {
  {
    if (!hasWarnedAboutDeprecatedIsAsyncMode) {
      hasWarnedAboutDeprecatedIsAsyncMode = true;
      lowPriorityWarning$1(false, 'The ReactIs.isAsyncMode() alias has been deprecated, ' + 'and will be removed in React 17+. Update your code to use ' + 'ReactIs.isConcurrentMode() instead. It has the exact same API.');
    }
  }
  return isConcurrentMode(object) || typeOf(object) === REACT_ASYNC_MODE_TYPE;
}
function isConcurrentMode(object) {
  return typeOf(object) === REACT_CONCURRENT_MODE_TYPE;
}
function isContextConsumer(object) {
  return typeOf(object) === REACT_CONTEXT_TYPE;
}
function isContextProvider(object) {
  return typeOf(object) === REACT_PROVIDER_TYPE;
}
function isElement(object) {
  return typeof object === 'object' && object !== null && object.$$typeof === REACT_ELEMENT_TYPE;
}
function isForwardRef(object) {
  return typeOf(object) === REACT_FORWARD_REF_TYPE;
}
function isFragment(object) {
  return typeOf(object) === REACT_FRAGMENT_TYPE;
}
function isLazy(object) {
  return typeOf(object) === REACT_LAZY_TYPE;
}
function isMemo(object) {
  return typeOf(object) === REACT_MEMO_TYPE;
}
function isPortal(object) {
  return typeOf(object) === REACT_PORTAL_TYPE;
}
function isProfiler(object) {
  return typeOf(object) === REACT_PROFILER_TYPE;
}
function isStrictMode(object) {
  return typeOf(object) === REACT_STRICT_MODE_TYPE;
}
function isSuspense(object) {
  return typeOf(object) === REACT_SUSPENSE_TYPE;
}

exports.typeOf = typeOf;
exports.AsyncMode = AsyncMode;
exports.ConcurrentMode = ConcurrentMode;
exports.ContextConsumer = ContextConsumer;
exports.ContextProvider = ContextProvider;
exports.Element = Element;
exports.ForwardRef = ForwardRef;
exports.Fragment = Fragment;
exports.Lazy = Lazy;
exports.Memo = Memo;
exports.Portal = Portal;
exports.Profiler = Profiler;
exports.StrictMode = StrictMode;
exports.Suspense = Suspense;
exports.isValidElementType = isValidElementType;
exports.isAsyncMode = isAsyncMode;
exports.isConcurrentMode = isConcurrentMode;
exports.isContextConsumer = isContextConsumer;
exports.isContextProvider = isContextProvider;
exports.isElement = isElement;
exports.isForwardRef = isForwardRef;
exports.isFragment = isFragment;
exports.isLazy = isLazy;
exports.isMemo = isMemo;
exports.isPortal = isPortal;
exports.isProfiler = isProfiler;
exports.isStrictMode = isStrictMode;
exports.isSuspense = isSuspense;
  })();
}


/***/ }),

/***/ "./node_modules/next-server/node_modules/react-is/index.js":
/*!*****************************************************************!*\
  !*** ./node_modules/next-server/node_modules/react-is/index.js ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


if (false) {} else {
  module.exports = __webpack_require__(/*! ./cjs/react-is.development.js */ "./node_modules/next-server/node_modules/react-is/cjs/react-is.development.js");
}


/***/ }),

/***/ "./node_modules/next/dist/build/webpack/loaders/next-client-pages-loader.js?page=%2Fproduct&absolutePagePath=C%3A%5CUsers%5CDanilo%5CDocuments%5CGitHub%5CWithoffStore%5CWeb%5Cpages%5Cproduct.jsx!./":
/*!*********************************************************************************************************************************************************************************************************!*\
  !*** ./node_modules/next/dist/build/webpack/loaders/next-client-pages-loader.js?page=%2Fproduct&absolutePagePath=C%3A%5CUsers%5CDanilo%5CDocuments%5CGitHub%5CWithoffStore%5CWeb%5Cpages%5Cproduct.jsx ***!
  \*********************************************************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {


    (window.__NEXT_P=window.__NEXT_P||[]).push(["/product", function() {
      var page = __webpack_require__(/*! ./pages/product.jsx */ "./pages/product.jsx")
      if(true) {
        module.hot.accept(/*! ./pages/product.jsx */ "./pages/product.jsx", function() {
          if(!next.router.components["/product"]) return
          var updatedPage = __webpack_require__(/*! ./pages/product.jsx */ "./pages/product.jsx")
          next.router.update("/product", updatedPage.default || updatedPage)
        })
      }
      return { page: page.default || page }
    }]);
  

/***/ }),

/***/ "./node_modules/next/dist/client/router.js":
/*!*************************************************!*\
  !*** ./node_modules/next/dist/client/router.js ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault2 = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _construct2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/construct */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/construct.js"));

var _interopRequireWildcard = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireWildcard */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireWildcard.js");

var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

exports.__esModule = true;
exports.useRouter = useRouter;
exports.makePublicRouterInstance = makePublicRouterInstance;
exports.createRouter = exports.withRouter = exports["default"] = void 0;

var _extends2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/extends */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

var _react = _interopRequireDefault(__webpack_require__(/*! react */ "./node_modules/react/index.js"));

var _router2 = _interopRequireWildcard(__webpack_require__(/*! next-server/dist/lib/router/router */ "./node_modules/next-server/dist/lib/router/router.js"));

exports.Router = _router2["default"];
exports.NextRouter = _router2.NextRouter;

var _routerContext = __webpack_require__(/*! next-server/dist/lib/router-context */ "./node_modules/next-server/dist/lib/router-context.js");

var _withRouter = _interopRequireDefault(__webpack_require__(/*! ./with-router */ "./node_modules/next/dist/client/with-router.js"));

exports.withRouter = _withRouter["default"];
/* global window */

var singletonRouter = {
  router: null,
  // holds the actual router instance
  readyCallbacks: [],
  ready: function ready(cb) {
    if (this.router) return cb();

    if (true) {
      this.readyCallbacks.push(cb);
    }
  }
}; // Create public properties and methods of the router in the singletonRouter

var urlPropertyFields = ['pathname', 'route', 'query', 'asPath'];
var propertyFields = ['components'];
var routerEvents = ['routeChangeStart', 'beforeHistoryChange', 'routeChangeComplete', 'routeChangeError', 'hashChangeStart', 'hashChangeComplete'];
var coreMethodFields = ['push', 'replace', 'reload', 'back', 'prefetch', 'beforePopState']; // Events is a static property on the router, the router doesn't have to be initialized to use it

(0, _defineProperty["default"])(singletonRouter, 'events', {
  get: function get() {
    return _router2["default"].events;
  }
});
propertyFields.concat(urlPropertyFields).forEach(function (field) {
  // Here we need to use Object.defineProperty because, we need to return
  // the property assigned to the actual router
  // The value might get changed as we change routes and this is the
  // proper way to access it
  (0, _defineProperty["default"])(singletonRouter, field, {
    get: function get() {
      var router = getRouter();
      return router[field];
    }
  });
});
coreMethodFields.forEach(function (field) {
  // We don't really know the types here, so we add them later instead
  ;

  singletonRouter[field] = function () {
    var router = getRouter();
    return router[field].apply(router, arguments);
  };
});
routerEvents.forEach(function (event) {
  singletonRouter.ready(function () {
    _router2["default"].events.on(event, function () {
      var eventField = "on" + event.charAt(0).toUpperCase() + event.substring(1);
      var _singletonRouter = singletonRouter;

      if (_singletonRouter[eventField]) {
        try {
          _singletonRouter[eventField].apply(_singletonRouter, arguments);
        } catch (err) {
          // tslint:disable-next-line:no-console
          console.error("Error when running the Router event: " + eventField); // tslint:disable-next-line:no-console

          console.error(err.message + "\n" + err.stack);
        }
      }
    });
  });
});

function getRouter() {
  if (!singletonRouter.router) {
    var message = 'No router instance found.\n' + 'You should only use "next/router" inside the client side of your app.\n';
    throw new Error(message);
  }

  return singletonRouter.router;
} // Export the singletonRouter and this is the public API.


var _default = singletonRouter; // Reexport the withRoute HOC

exports["default"] = _default;

function useRouter() {
  return _react["default"].useContext(_routerContext.RouterContext);
} // INTERNAL APIS
// -------------
// (do not use following exports inside the app)
// Create a router and assign it as the singleton instance.
// This is used in client side when we are initilizing the app.
// This should **not** use inside the server.


var createRouter = function createRouter() {
  for (var _len = arguments.length, args = new Array(_len), _key = 0; _key < _len; _key++) {
    args[_key] = arguments[_key];
  }

  singletonRouter.router = (0, _construct2["default"])(_router2["default"], args);
  singletonRouter.readyCallbacks.forEach(function (cb) {
    return cb();
  });
  singletonRouter.readyCallbacks = [];
  return singletonRouter.router;
}; // This function is used to create the `withRouter` router instance


exports.createRouter = createRouter;

function makePublicRouterInstance(router) {
  var _router = router;
  var instance = {};

  for (var _i = 0, _urlPropertyFields = urlPropertyFields; _i < _urlPropertyFields.length; _i++) {
    var property = _urlPropertyFields[_i];

    if (typeof _router[property] === 'object') {
      instance[property] = (0, _extends2["default"])({}, _router[property]); // makes sure query is not stateful

      continue;
    }

    instance[property] = _router[property];
  } // Events is a static property on the router, the router doesn't have to be initialized to use it


  instance.events = _router2["default"].events;
  propertyFields.forEach(function (field) {
    // Here we need to use Object.defineProperty because, we need to return
    // the property assigned to the actual router
    // The value might get changed as we change routes and this is the
    // proper way to access it
    (0, _defineProperty["default"])(instance, field, {
      get: function get() {
        return _router[field];
      }
    });
  });
  coreMethodFields.forEach(function (field) {
    instance[field] = function () {
      return _router[field].apply(_router, arguments);
    };
  });
  return instance;
}

/***/ }),

/***/ "./node_modules/next/dist/client/with-router.js":
/*!******************************************************!*\
  !*** ./node_modules/next/dist/client/with-router.js ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireDefault2 = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

var _classCallCheck2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/classCallCheck */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js"));

var _createClass2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/createClass */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js"));

var _possibleConstructorReturn2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/possibleConstructorReturn */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/possibleConstructorReturn.js"));

var _getPrototypeOf2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/getPrototypeOf */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/getPrototypeOf.js"));

var _inherits2 = _interopRequireDefault2(__webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/inherits */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/inherits.js"));

var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

exports.__esModule = true;
exports["default"] = withRouter;

var _extends2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/extends */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js"));

var _react = _interopRequireDefault(__webpack_require__(/*! react */ "./node_modules/react/index.js"));

var _propTypes = _interopRequireDefault(__webpack_require__(/*! prop-types */ "./node_modules/prop-types/index.js"));

function withRouter(ComposedComponent) {
  var WithRouteWrapper =
  /*#__PURE__*/
  function (_react$default$Compon) {
    (0, _inherits2["default"])(WithRouteWrapper, _react$default$Compon);

    function WithRouteWrapper() {
      var _this;

      (0, _classCallCheck2["default"])(this, WithRouteWrapper);
      _this = (0, _possibleConstructorReturn2["default"])(this, (0, _getPrototypeOf2["default"])(WithRouteWrapper).apply(this, arguments));
      _this.context = void 0;
      return _this;
    }

    (0, _createClass2["default"])(WithRouteWrapper, [{
      key: "render",
      value: function render() {
        return _react["default"].createElement(ComposedComponent, (0, _extends2["default"])({
          router: this.context.router
        }, this.props));
      }
    }]);
    return WithRouteWrapper;
  }(_react["default"].Component);

  WithRouteWrapper.displayName = void 0;
  WithRouteWrapper.getInitialProps = void 0;
  WithRouteWrapper.contextTypes = {
    router: _propTypes["default"].object
  };
  WithRouteWrapper.getInitialProps = ComposedComponent.getInitialProps;

  if (true) {
    var name = ComposedComponent.displayName || ComposedComponent.name || 'Unknown';
    WithRouteWrapper.displayName = "withRouter(" + name + ")";
  }

  return WithRouteWrapper;
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/assign.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/assign.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/assign */ "./node_modules/core-js/library/fn/object/assign.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/create.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/create.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/create */ "./node_modules/core-js/library/fn/object/create.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js":
/*!*************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js ***!
  \*************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/define-property */ "./node_modules/core-js/library/fn/object/define-property.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js ***!
  \*************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-own-property-descriptor */ "./node_modules/core-js/library/fn/object/get-own-property-descriptor.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-prototype-of.js":
/*!**************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-prototype-of.js ***!
  \**************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-prototype-of */ "./node_modules/core-js/library/fn/object/get-prototype-of.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/set-prototype-of.js":
/*!**************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/set-prototype-of.js ***!
  \**************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/set-prototype-of */ "./node_modules/core-js/library/fn/object/set-prototype-of.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/reflect/construct.js":
/*!********************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/reflect/construct.js ***!
  \********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/reflect/construct */ "./node_modules/core-js/library/fn/reflect/construct.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol.js":
/*!*********************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol.js ***!
  \*********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/symbol */ "./node_modules/core-js/library/fn/symbol/index.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol/iterator.js":
/*!******************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol/iterator.js ***!
  \******************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/symbol/iterator */ "./node_modules/core-js/library/fn/symbol/iterator.js");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/assertThisInitialized.js":
/*!****************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/assertThisInitialized.js ***!
  \****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _assertThisInitialized; });
function _assertThisInitialized(self) {
  if (self === void 0) {
    throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
  }

  return self;
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js":
/*!*********************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/classCallCheck.js ***!
  \*********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _classCallCheck; });
function _classCallCheck(instance, Constructor) {
  if (!(instance instanceof Constructor)) {
    throw new TypeError("Cannot call a class as a function");
  }
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/construct.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/construct.js ***!
  \****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _construct; });
/* harmony import */ var _core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/reflect/construct */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/reflect/construct.js");
/* harmony import */ var _core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _setPrototypeOf__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./setPrototypeOf */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/setPrototypeOf.js");



function isNativeReflectConstruct() {
  if (typeof Reflect === "undefined" || !_core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0___default.a) return false;
  if (_core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0___default.a.sham) return false;
  if (typeof Proxy === "function") return true;

  try {
    Date.prototype.toString.call(_core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0___default()(Date, [], function () {}));
    return true;
  } catch (e) {
    return false;
  }
}

function _construct(Parent, args, Class) {
  if (isNativeReflectConstruct()) {
    _construct = _core_js_reflect_construct__WEBPACK_IMPORTED_MODULE_0___default.a;
  } else {
    _construct = function _construct(Parent, args, Class) {
      var a = [null];
      a.push.apply(a, args);
      var Constructor = Function.bind.apply(Parent, a);
      var instance = new Constructor();
      if (Class) Object(_setPrototypeOf__WEBPACK_IMPORTED_MODULE_1__["default"])(instance, Class.prototype);
      return instance;
    };
  }

  return _construct.apply(null, arguments);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js":
/*!******************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/createClass.js ***!
  \******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _createClass; });
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/define-property */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js");
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__);


function _defineProperties(target, props) {
  for (var i = 0; i < props.length; i++) {
    var descriptor = props[i];
    descriptor.enumerable = descriptor.enumerable || false;
    descriptor.configurable = true;
    if ("value" in descriptor) descriptor.writable = true;

    _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default()(target, descriptor.key, descriptor);
  }
}

function _createClass(Constructor, protoProps, staticProps) {
  if (protoProps) _defineProperties(Constructor.prototype, protoProps);
  if (staticProps) _defineProperties(Constructor, staticProps);
  return Constructor;
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/getPrototypeOf.js":
/*!*********************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/getPrototypeOf.js ***!
  \*********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _getPrototypeOf; });
/* harmony import */ var _core_js_object_get_prototype_of__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/get-prototype-of */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-prototype-of.js");
/* harmony import */ var _core_js_object_get_prototype_of__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_get_prototype_of__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../core-js/object/set-prototype-of */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/set-prototype-of.js");
/* harmony import */ var _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_1__);


function _getPrototypeOf(o) {
  _getPrototypeOf = _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_1___default.a ? _core_js_object_get_prototype_of__WEBPACK_IMPORTED_MODULE_0___default.a : function _getPrototypeOf(o) {
    return o.__proto__ || _core_js_object_get_prototype_of__WEBPACK_IMPORTED_MODULE_0___default()(o);
  };
  return _getPrototypeOf(o);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/inherits.js":
/*!***************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/inherits.js ***!
  \***************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _inherits; });
/* harmony import */ var _core_js_object_create__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/create */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/create.js");
/* harmony import */ var _core_js_object_create__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_create__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _setPrototypeOf__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./setPrototypeOf */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/setPrototypeOf.js");


function _inherits(subClass, superClass) {
  if (typeof superClass !== "function" && superClass !== null) {
    throw new TypeError("Super expression must either be null or a function");
  }

  subClass.prototype = _core_js_object_create__WEBPACK_IMPORTED_MODULE_0___default()(superClass && superClass.prototype, {
    constructor: {
      value: subClass,
      writable: true,
      configurable: true
    }
  });
  if (superClass) Object(_setPrototypeOf__WEBPACK_IMPORTED_MODULE_1__["default"])(subClass, superClass);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/possibleConstructorReturn.js":
/*!********************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/possibleConstructorReturn.js ***!
  \********************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _possibleConstructorReturn; });
/* harmony import */ var _helpers_esm_typeof__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../helpers/esm/typeof */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/typeof.js");
/* harmony import */ var _assertThisInitialized__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./assertThisInitialized */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/assertThisInitialized.js");


function _possibleConstructorReturn(self, call) {
  if (call && (Object(_helpers_esm_typeof__WEBPACK_IMPORTED_MODULE_0__["default"])(call) === "object" || typeof call === "function")) {
    return call;
  }

  return Object(_assertThisInitialized__WEBPACK_IMPORTED_MODULE_1__["default"])(self);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/setPrototypeOf.js":
/*!*********************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/setPrototypeOf.js ***!
  \*********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _setPrototypeOf; });
/* harmony import */ var _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/set-prototype-of */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/set-prototype-of.js");
/* harmony import */ var _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_0__);

function _setPrototypeOf(o, p) {
  _setPrototypeOf = _core_js_object_set_prototype_of__WEBPACK_IMPORTED_MODULE_0___default.a || function _setPrototypeOf(o, p) {
    o.__proto__ = p;
    return o;
  };

  return _setPrototypeOf(o, p);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/typeof.js":
/*!*************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/esm/typeof.js ***!
  \*************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _typeof; });
/* harmony import */ var _core_js_symbol_iterator__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/symbol/iterator */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol/iterator.js");
/* harmony import */ var _core_js_symbol_iterator__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_symbol_iterator__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _core_js_symbol__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../core-js/symbol */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/symbol.js");
/* harmony import */ var _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_core_js_symbol__WEBPACK_IMPORTED_MODULE_1__);



function _typeof2(obj) { if (typeof _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a === "function" && typeof _core_js_symbol_iterator__WEBPACK_IMPORTED_MODULE_0___default.a === "symbol") { _typeof2 = function _typeof2(obj) { return typeof obj; }; } else { _typeof2 = function _typeof2(obj) { return obj && typeof _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a === "function" && obj.constructor === _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a && obj !== _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a.prototype ? "symbol" : typeof obj; }; } return _typeof2(obj); }

function _typeof(obj) {
  if (typeof _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a === "function" && _typeof2(_core_js_symbol_iterator__WEBPACK_IMPORTED_MODULE_0___default.a) === "symbol") {
    _typeof = function _typeof(obj) {
      return _typeof2(obj);
    };
  } else {
    _typeof = function _typeof(obj) {
      return obj && typeof _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a === "function" && obj.constructor === _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a && obj !== _core_js_symbol__WEBPACK_IMPORTED_MODULE_1___default.a.prototype ? "symbol" : _typeof2(obj);
    };
  }

  return _typeof(obj);
}

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js":
/*!**********************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js ***!
  \**********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var _Object$assign = __webpack_require__(/*! ../core-js/object/assign */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/assign.js");

function _extends() {
  module.exports = _extends = _Object$assign || function (target) {
    for (var i = 1; i < arguments.length; i++) {
      var source = arguments[i];

      for (var key in source) {
        if (Object.prototype.hasOwnProperty.call(source, key)) {
          target[key] = source[key];
        }
      }
    }

    return target;
  };

  return _extends.apply(this, arguments);
}

module.exports = _extends;

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js":
/*!************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js ***!
  \************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function _interopRequireDefault(obj) {
  return obj && obj.__esModule ? obj : {
    "default": obj
  };
}

module.exports = _interopRequireDefault;

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireWildcard.js":
/*!*************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireWildcard.js ***!
  \*************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var _Object$getOwnPropertyDescriptor = __webpack_require__(/*! ../core-js/object/get-own-property-descriptor */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js");

var _Object$defineProperty = __webpack_require__(/*! ../core-js/object/define-property */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js");

function _interopRequireWildcard(obj) {
  if (obj && obj.__esModule) {
    return obj;
  } else {
    var newObj = {};

    if (obj != null) {
      for (var key in obj) {
        if (Object.prototype.hasOwnProperty.call(obj, key)) {
          var desc = _Object$defineProperty && _Object$getOwnPropertyDescriptor ? _Object$getOwnPropertyDescriptor(obj, key) : {};

          if (desc.get || desc.set) {
            _Object$defineProperty(newObj, key, desc);
          } else {
            newObj[key] = obj[key];
          }
        }
      }
    }

    newObj["default"] = obj;
    return newObj;
  }
}

module.exports = _interopRequireWildcard;

/***/ }),

/***/ "./node_modules/object-assign/index.js":
/*!***************************************************************************************************!*\
  !*** delegated ./node_modules/object-assign/index.js from dll-reference dll_01f9a3fa864a7b7414d8 ***!
  \***************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = (__webpack_require__(/*! dll-reference dll_01f9a3fa864a7b7414d8 */ "dll-reference dll_01f9a3fa864a7b7414d8"))("./node_modules/object-assign/index.js");

/***/ }),

/***/ "./node_modules/process/browser.js":
/*!*****************************************!*\
  !*** ./node_modules/process/browser.js ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

// shim for using process in browser
var process = module.exports = {};

// cached from whatever global is present so that test runners that stub it
// don't break things.  But we need to wrap it in a try catch in case it is
// wrapped in strict mode code which doesn't define any globals.  It's inside a
// function because try/catches deoptimize in certain engines.

var cachedSetTimeout;
var cachedClearTimeout;

function defaultSetTimout() {
    throw new Error('setTimeout has not been defined');
}
function defaultClearTimeout () {
    throw new Error('clearTimeout has not been defined');
}
(function () {
    try {
        if (typeof setTimeout === 'function') {
            cachedSetTimeout = setTimeout;
        } else {
            cachedSetTimeout = defaultSetTimout;
        }
    } catch (e) {
        cachedSetTimeout = defaultSetTimout;
    }
    try {
        if (typeof clearTimeout === 'function') {
            cachedClearTimeout = clearTimeout;
        } else {
            cachedClearTimeout = defaultClearTimeout;
        }
    } catch (e) {
        cachedClearTimeout = defaultClearTimeout;
    }
} ())
function runTimeout(fun) {
    if (cachedSetTimeout === setTimeout) {
        //normal enviroments in sane situations
        return setTimeout(fun, 0);
    }
    // if setTimeout wasn't available but was latter defined
    if ((cachedSetTimeout === defaultSetTimout || !cachedSetTimeout) && setTimeout) {
        cachedSetTimeout = setTimeout;
        return setTimeout(fun, 0);
    }
    try {
        // when when somebody has screwed with setTimeout but no I.E. maddness
        return cachedSetTimeout(fun, 0);
    } catch(e){
        try {
            // When we are in I.E. but the script has been evaled so I.E. doesn't trust the global object when called normally
            return cachedSetTimeout.call(null, fun, 0);
        } catch(e){
            // same as above but when it's a version of I.E. that must have the global object for 'this', hopfully our context correct otherwise it will throw a global error
            return cachedSetTimeout.call(this, fun, 0);
        }
    }


}
function runClearTimeout(marker) {
    if (cachedClearTimeout === clearTimeout) {
        //normal enviroments in sane situations
        return clearTimeout(marker);
    }
    // if clearTimeout wasn't available but was latter defined
    if ((cachedClearTimeout === defaultClearTimeout || !cachedClearTimeout) && clearTimeout) {
        cachedClearTimeout = clearTimeout;
        return clearTimeout(marker);
    }
    try {
        // when when somebody has screwed with setTimeout but no I.E. maddness
        return cachedClearTimeout(marker);
    } catch (e){
        try {
            // When we are in I.E. but the script has been evaled so I.E. doesn't  trust the global object when called normally
            return cachedClearTimeout.call(null, marker);
        } catch (e){
            // same as above but when it's a version of I.E. that must have the global object for 'this', hopfully our context correct otherwise it will throw a global error.
            // Some versions of I.E. have different rules for clearTimeout vs setTimeout
            return cachedClearTimeout.call(this, marker);
        }
    }



}
var queue = [];
var draining = false;
var currentQueue;
var queueIndex = -1;

function cleanUpNextTick() {
    if (!draining || !currentQueue) {
        return;
    }
    draining = false;
    if (currentQueue.length) {
        queue = currentQueue.concat(queue);
    } else {
        queueIndex = -1;
    }
    if (queue.length) {
        drainQueue();
    }
}

function drainQueue() {
    if (draining) {
        return;
    }
    var timeout = runTimeout(cleanUpNextTick);
    draining = true;

    var len = queue.length;
    while(len) {
        currentQueue = queue;
        queue = [];
        while (++queueIndex < len) {
            if (currentQueue) {
                currentQueue[queueIndex].run();
            }
        }
        queueIndex = -1;
        len = queue.length;
    }
    currentQueue = null;
    draining = false;
    runClearTimeout(timeout);
}

process.nextTick = function (fun) {
    var args = new Array(arguments.length - 1);
    if (arguments.length > 1) {
        for (var i = 1; i < arguments.length; i++) {
            args[i - 1] = arguments[i];
        }
    }
    queue.push(new Item(fun, args));
    if (queue.length === 1 && !draining) {
        runTimeout(drainQueue);
    }
};

// v8 likes predictible objects
function Item(fun, array) {
    this.fun = fun;
    this.array = array;
}
Item.prototype.run = function () {
    this.fun.apply(null, this.array);
};
process.title = 'browser';
process.browser = true;
process.env = {};
process.argv = [];
process.version = ''; // empty string to avoid regexp issues
process.versions = {};

function noop() {}

process.on = noop;
process.addListener = noop;
process.once = noop;
process.off = noop;
process.removeListener = noop;
process.removeAllListeners = noop;
process.emit = noop;
process.prependListener = noop;
process.prependOnceListener = noop;

process.listeners = function (name) { return [] }

process.binding = function (name) {
    throw new Error('process.binding is not supported');
};

process.cwd = function () { return '/' };
process.chdir = function (dir) {
    throw new Error('process.chdir is not supported');
};
process.umask = function() { return 0; };


/***/ }),

/***/ "./node_modules/prop-types/checkPropTypes.js":
/*!*********************************************************************************************************!*\
  !*** delegated ./node_modules/prop-types/checkPropTypes.js from dll-reference dll_01f9a3fa864a7b7414d8 ***!
  \*********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = (__webpack_require__(/*! dll-reference dll_01f9a3fa864a7b7414d8 */ "dll-reference dll_01f9a3fa864a7b7414d8"))("./node_modules/prop-types/checkPropTypes.js");

/***/ }),

/***/ "./node_modules/prop-types/factoryWithTypeCheckers.js":
/*!************************************************************!*\
  !*** ./node_modules/prop-types/factoryWithTypeCheckers.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/**
 * Copyright (c) 2013-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */



var ReactIs = __webpack_require__(/*! react-is */ "./node_modules/react-is/index.js");
var assign = __webpack_require__(/*! object-assign */ "./node_modules/object-assign/index.js");

var ReactPropTypesSecret = __webpack_require__(/*! ./lib/ReactPropTypesSecret */ "./node_modules/prop-types/lib/ReactPropTypesSecret.js");
var checkPropTypes = __webpack_require__(/*! ./checkPropTypes */ "./node_modules/prop-types/checkPropTypes.js");

var has = Function.call.bind(Object.prototype.hasOwnProperty);
var printWarning = function() {};

if (true) {
  printWarning = function(text) {
    var message = 'Warning: ' + text;
    if (typeof console !== 'undefined') {
      console.error(message);
    }
    try {
      // --- Welcome to debugging React ---
      // This error was thrown as a convenience so that you can use this stack
      // to find the callsite that caused this warning to fire.
      throw new Error(message);
    } catch (x) {}
  };
}

function emptyFunctionThatReturnsNull() {
  return null;
}

module.exports = function(isValidElement, throwOnDirectAccess) {
  /* global Symbol */
  var ITERATOR_SYMBOL = typeof Symbol === 'function' && Symbol.iterator;
  var FAUX_ITERATOR_SYMBOL = '@@iterator'; // Before Symbol spec.

  /**
   * Returns the iterator method function contained on the iterable object.
   *
   * Be sure to invoke the function with the iterable as context:
   *
   *     var iteratorFn = getIteratorFn(myIterable);
   *     if (iteratorFn) {
   *       var iterator = iteratorFn.call(myIterable);
   *       ...
   *     }
   *
   * @param {?object} maybeIterable
   * @return {?function}
   */
  function getIteratorFn(maybeIterable) {
    var iteratorFn = maybeIterable && (ITERATOR_SYMBOL && maybeIterable[ITERATOR_SYMBOL] || maybeIterable[FAUX_ITERATOR_SYMBOL]);
    if (typeof iteratorFn === 'function') {
      return iteratorFn;
    }
  }

  /**
   * Collection of methods that allow declaration and validation of props that are
   * supplied to React components. Example usage:
   *
   *   var Props = require('ReactPropTypes');
   *   var MyArticle = React.createClass({
   *     propTypes: {
   *       // An optional string prop named "description".
   *       description: Props.string,
   *
   *       // A required enum prop named "category".
   *       category: Props.oneOf(['News','Photos']).isRequired,
   *
   *       // A prop named "dialog" that requires an instance of Dialog.
   *       dialog: Props.instanceOf(Dialog).isRequired
   *     },
   *     render: function() { ... }
   *   });
   *
   * A more formal specification of how these methods are used:
   *
   *   type := array|bool|func|object|number|string|oneOf([...])|instanceOf(...)
   *   decl := ReactPropTypes.{type}(.isRequired)?
   *
   * Each and every declaration produces a function with the same signature. This
   * allows the creation of custom validation functions. For example:
   *
   *  var MyLink = React.createClass({
   *    propTypes: {
   *      // An optional string or URI prop named "href".
   *      href: function(props, propName, componentName) {
   *        var propValue = props[propName];
   *        if (propValue != null && typeof propValue !== 'string' &&
   *            !(propValue instanceof URI)) {
   *          return new Error(
   *            'Expected a string or an URI for ' + propName + ' in ' +
   *            componentName
   *          );
   *        }
   *      }
   *    },
   *    render: function() {...}
   *  });
   *
   * @internal
   */

  var ANONYMOUS = '<<anonymous>>';

  // Important!
  // Keep this list in sync with production version in `./factoryWithThrowingShims.js`.
  var ReactPropTypes = {
    array: createPrimitiveTypeChecker('array'),
    bool: createPrimitiveTypeChecker('boolean'),
    func: createPrimitiveTypeChecker('function'),
    number: createPrimitiveTypeChecker('number'),
    object: createPrimitiveTypeChecker('object'),
    string: createPrimitiveTypeChecker('string'),
    symbol: createPrimitiveTypeChecker('symbol'),

    any: createAnyTypeChecker(),
    arrayOf: createArrayOfTypeChecker,
    element: createElementTypeChecker(),
    elementType: createElementTypeTypeChecker(),
    instanceOf: createInstanceTypeChecker,
    node: createNodeChecker(),
    objectOf: createObjectOfTypeChecker,
    oneOf: createEnumTypeChecker,
    oneOfType: createUnionTypeChecker,
    shape: createShapeTypeChecker,
    exact: createStrictShapeTypeChecker,
  };

  /**
   * inlined Object.is polyfill to avoid requiring consumers ship their own
   * https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/is
   */
  /*eslint-disable no-self-compare*/
  function is(x, y) {
    // SameValue algorithm
    if (x === y) {
      // Steps 1-5, 7-10
      // Steps 6.b-6.e: +0 != -0
      return x !== 0 || 1 / x === 1 / y;
    } else {
      // Step 6.a: NaN == NaN
      return x !== x && y !== y;
    }
  }
  /*eslint-enable no-self-compare*/

  /**
   * We use an Error-like object for backward compatibility as people may call
   * PropTypes directly and inspect their output. However, we don't use real
   * Errors anymore. We don't inspect their stack anyway, and creating them
   * is prohibitively expensive if they are created too often, such as what
   * happens in oneOfType() for any type before the one that matched.
   */
  function PropTypeError(message) {
    this.message = message;
    this.stack = '';
  }
  // Make `instanceof Error` still work for returned errors.
  PropTypeError.prototype = Error.prototype;

  function createChainableTypeChecker(validate) {
    if (true) {
      var manualPropTypeCallCache = {};
      var manualPropTypeWarningCount = 0;
    }
    function checkType(isRequired, props, propName, componentName, location, propFullName, secret) {
      componentName = componentName || ANONYMOUS;
      propFullName = propFullName || propName;

      if (secret !== ReactPropTypesSecret) {
        if (throwOnDirectAccess) {
          // New behavior only for users of `prop-types` package
          var err = new Error(
            'Calling PropTypes validators directly is not supported by the `prop-types` package. ' +
            'Use `PropTypes.checkPropTypes()` to call them. ' +
            'Read more at http://fb.me/use-check-prop-types'
          );
          err.name = 'Invariant Violation';
          throw err;
        } else if ( true && typeof console !== 'undefined') {
          // Old behavior for people using React.PropTypes
          var cacheKey = componentName + ':' + propName;
          if (
            !manualPropTypeCallCache[cacheKey] &&
            // Avoid spamming the console because they are often not actionable except for lib authors
            manualPropTypeWarningCount < 3
          ) {
            printWarning(
              'You are manually calling a React.PropTypes validation ' +
              'function for the `' + propFullName + '` prop on `' + componentName  + '`. This is deprecated ' +
              'and will throw in the standalone `prop-types` package. ' +
              'You may be seeing this warning due to a third-party PropTypes ' +
              'library. See https://fb.me/react-warning-dont-call-proptypes ' + 'for details.'
            );
            manualPropTypeCallCache[cacheKey] = true;
            manualPropTypeWarningCount++;
          }
        }
      }
      if (props[propName] == null) {
        if (isRequired) {
          if (props[propName] === null) {
            return new PropTypeError('The ' + location + ' `' + propFullName + '` is marked as required ' + ('in `' + componentName + '`, but its value is `null`.'));
          }
          return new PropTypeError('The ' + location + ' `' + propFullName + '` is marked as required in ' + ('`' + componentName + '`, but its value is `undefined`.'));
        }
        return null;
      } else {
        return validate(props, propName, componentName, location, propFullName);
      }
    }

    var chainedCheckType = checkType.bind(null, false);
    chainedCheckType.isRequired = checkType.bind(null, true);

    return chainedCheckType;
  }

  function createPrimitiveTypeChecker(expectedType) {
    function validate(props, propName, componentName, location, propFullName, secret) {
      var propValue = props[propName];
      var propType = getPropType(propValue);
      if (propType !== expectedType) {
        // `propValue` being instance of, say, date/regexp, pass the 'object'
        // check, but we can offer a more precise error message here rather than
        // 'of type `object`'.
        var preciseType = getPreciseType(propValue);

        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + preciseType + '` supplied to `' + componentName + '`, expected ') + ('`' + expectedType + '`.'));
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createAnyTypeChecker() {
    return createChainableTypeChecker(emptyFunctionThatReturnsNull);
  }

  function createArrayOfTypeChecker(typeChecker) {
    function validate(props, propName, componentName, location, propFullName) {
      if (typeof typeChecker !== 'function') {
        return new PropTypeError('Property `' + propFullName + '` of component `' + componentName + '` has invalid PropType notation inside arrayOf.');
      }
      var propValue = props[propName];
      if (!Array.isArray(propValue)) {
        var propType = getPropType(propValue);
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + propType + '` supplied to `' + componentName + '`, expected an array.'));
      }
      for (var i = 0; i < propValue.length; i++) {
        var error = typeChecker(propValue, i, componentName, location, propFullName + '[' + i + ']', ReactPropTypesSecret);
        if (error instanceof Error) {
          return error;
        }
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createElementTypeChecker() {
    function validate(props, propName, componentName, location, propFullName) {
      var propValue = props[propName];
      if (!isValidElement(propValue)) {
        var propType = getPropType(propValue);
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + propType + '` supplied to `' + componentName + '`, expected a single ReactElement.'));
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createElementTypeTypeChecker() {
    function validate(props, propName, componentName, location, propFullName) {
      var propValue = props[propName];
      if (!ReactIs.isValidElementType(propValue)) {
        var propType = getPropType(propValue);
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + propType + '` supplied to `' + componentName + '`, expected a single ReactElement type.'));
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createInstanceTypeChecker(expectedClass) {
    function validate(props, propName, componentName, location, propFullName) {
      if (!(props[propName] instanceof expectedClass)) {
        var expectedClassName = expectedClass.name || ANONYMOUS;
        var actualClassName = getClassName(props[propName]);
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + actualClassName + '` supplied to `' + componentName + '`, expected ') + ('instance of `' + expectedClassName + '`.'));
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createEnumTypeChecker(expectedValues) {
    if (!Array.isArray(expectedValues)) {
      if (true) {
        if (arguments.length > 1) {
          printWarning(
            'Invalid arguments supplied to oneOf, expected an array, got ' + arguments.length + ' arguments. ' +
            'A common mistake is to write oneOf(x, y, z) instead of oneOf([x, y, z]).'
          );
        } else {
          printWarning('Invalid argument supplied to oneOf, expected an array.');
        }
      }
      return emptyFunctionThatReturnsNull;
    }

    function validate(props, propName, componentName, location, propFullName) {
      var propValue = props[propName];
      for (var i = 0; i < expectedValues.length; i++) {
        if (is(propValue, expectedValues[i])) {
          return null;
        }
      }

      var valuesString = JSON.stringify(expectedValues, function replacer(key, value) {
        var type = getPreciseType(value);
        if (type === 'symbol') {
          return String(value);
        }
        return value;
      });
      return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of value `' + String(propValue) + '` ' + ('supplied to `' + componentName + '`, expected one of ' + valuesString + '.'));
    }
    return createChainableTypeChecker(validate);
  }

  function createObjectOfTypeChecker(typeChecker) {
    function validate(props, propName, componentName, location, propFullName) {
      if (typeof typeChecker !== 'function') {
        return new PropTypeError('Property `' + propFullName + '` of component `' + componentName + '` has invalid PropType notation inside objectOf.');
      }
      var propValue = props[propName];
      var propType = getPropType(propValue);
      if (propType !== 'object') {
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type ' + ('`' + propType + '` supplied to `' + componentName + '`, expected an object.'));
      }
      for (var key in propValue) {
        if (has(propValue, key)) {
          var error = typeChecker(propValue, key, componentName, location, propFullName + '.' + key, ReactPropTypesSecret);
          if (error instanceof Error) {
            return error;
          }
        }
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createUnionTypeChecker(arrayOfTypeCheckers) {
    if (!Array.isArray(arrayOfTypeCheckers)) {
       true ? printWarning('Invalid argument supplied to oneOfType, expected an instance of array.') : undefined;
      return emptyFunctionThatReturnsNull;
    }

    for (var i = 0; i < arrayOfTypeCheckers.length; i++) {
      var checker = arrayOfTypeCheckers[i];
      if (typeof checker !== 'function') {
        printWarning(
          'Invalid argument supplied to oneOfType. Expected an array of check functions, but ' +
          'received ' + getPostfixForTypeWarning(checker) + ' at index ' + i + '.'
        );
        return emptyFunctionThatReturnsNull;
      }
    }

    function validate(props, propName, componentName, location, propFullName) {
      for (var i = 0; i < arrayOfTypeCheckers.length; i++) {
        var checker = arrayOfTypeCheckers[i];
        if (checker(props, propName, componentName, location, propFullName, ReactPropTypesSecret) == null) {
          return null;
        }
      }

      return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` supplied to ' + ('`' + componentName + '`.'));
    }
    return createChainableTypeChecker(validate);
  }

  function createNodeChecker() {
    function validate(props, propName, componentName, location, propFullName) {
      if (!isNode(props[propName])) {
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` supplied to ' + ('`' + componentName + '`, expected a ReactNode.'));
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createShapeTypeChecker(shapeTypes) {
    function validate(props, propName, componentName, location, propFullName) {
      var propValue = props[propName];
      var propType = getPropType(propValue);
      if (propType !== 'object') {
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type `' + propType + '` ' + ('supplied to `' + componentName + '`, expected `object`.'));
      }
      for (var key in shapeTypes) {
        var checker = shapeTypes[key];
        if (!checker) {
          continue;
        }
        var error = checker(propValue, key, componentName, location, propFullName + '.' + key, ReactPropTypesSecret);
        if (error) {
          return error;
        }
      }
      return null;
    }
    return createChainableTypeChecker(validate);
  }

  function createStrictShapeTypeChecker(shapeTypes) {
    function validate(props, propName, componentName, location, propFullName) {
      var propValue = props[propName];
      var propType = getPropType(propValue);
      if (propType !== 'object') {
        return new PropTypeError('Invalid ' + location + ' `' + propFullName + '` of type `' + propType + '` ' + ('supplied to `' + componentName + '`, expected `object`.'));
      }
      // We need to check all keys in case some are required but missing from
      // props.
      var allKeys = assign({}, props[propName], shapeTypes);
      for (var key in allKeys) {
        var checker = shapeTypes[key];
        if (!checker) {
          return new PropTypeError(
            'Invalid ' + location + ' `' + propFullName + '` key `' + key + '` supplied to `' + componentName + '`.' +
            '\nBad object: ' + JSON.stringify(props[propName], null, '  ') +
            '\nValid keys: ' +  JSON.stringify(Object.keys(shapeTypes), null, '  ')
          );
        }
        var error = checker(propValue, key, componentName, location, propFullName + '.' + key, ReactPropTypesSecret);
        if (error) {
          return error;
        }
      }
      return null;
    }

    return createChainableTypeChecker(validate);
  }

  function isNode(propValue) {
    switch (typeof propValue) {
      case 'number':
      case 'string':
      case 'undefined':
        return true;
      case 'boolean':
        return !propValue;
      case 'object':
        if (Array.isArray(propValue)) {
          return propValue.every(isNode);
        }
        if (propValue === null || isValidElement(propValue)) {
          return true;
        }

        var iteratorFn = getIteratorFn(propValue);
        if (iteratorFn) {
          var iterator = iteratorFn.call(propValue);
          var step;
          if (iteratorFn !== propValue.entries) {
            while (!(step = iterator.next()).done) {
              if (!isNode(step.value)) {
                return false;
              }
            }
          } else {
            // Iterator will provide entry [k,v] tuples rather than values.
            while (!(step = iterator.next()).done) {
              var entry = step.value;
              if (entry) {
                if (!isNode(entry[1])) {
                  return false;
                }
              }
            }
          }
        } else {
          return false;
        }

        return true;
      default:
        return false;
    }
  }

  function isSymbol(propType, propValue) {
    // Native Symbol.
    if (propType === 'symbol') {
      return true;
    }

    // falsy value can't be a Symbol
    if (!propValue) {
      return false;
    }

    // 19.4.3.5 Symbol.prototype[@@toStringTag] === 'Symbol'
    if (propValue['@@toStringTag'] === 'Symbol') {
      return true;
    }

    // Fallback for non-spec compliant Symbols which are polyfilled.
    if (typeof Symbol === 'function' && propValue instanceof Symbol) {
      return true;
    }

    return false;
  }

  // Equivalent of `typeof` but with special handling for array and regexp.
  function getPropType(propValue) {
    var propType = typeof propValue;
    if (Array.isArray(propValue)) {
      return 'array';
    }
    if (propValue instanceof RegExp) {
      // Old webkits (at least until Android 4.0) return 'function' rather than
      // 'object' for typeof a RegExp. We'll normalize this here so that /bla/
      // passes PropTypes.object.
      return 'object';
    }
    if (isSymbol(propType, propValue)) {
      return 'symbol';
    }
    return propType;
  }

  // This handles more types than `getPropType`. Only used for error messages.
  // See `createPrimitiveTypeChecker`.
  function getPreciseType(propValue) {
    if (typeof propValue === 'undefined' || propValue === null) {
      return '' + propValue;
    }
    var propType = getPropType(propValue);
    if (propType === 'object') {
      if (propValue instanceof Date) {
        return 'date';
      } else if (propValue instanceof RegExp) {
        return 'regexp';
      }
    }
    return propType;
  }

  // Returns a string that is postfixed to a warning about an invalid type.
  // For example, "undefined" or "of type array"
  function getPostfixForTypeWarning(value) {
    var type = getPreciseType(value);
    switch (type) {
      case 'array':
      case 'object':
        return 'an ' + type;
      case 'boolean':
      case 'date':
      case 'regexp':
        return 'a ' + type;
      default:
        return type;
    }
  }

  // Returns class name of the object, if any.
  function getClassName(propValue) {
    if (!propValue.constructor || !propValue.constructor.name) {
      return ANONYMOUS;
    }
    return propValue.constructor.name;
  }

  ReactPropTypes.checkPropTypes = checkPropTypes;
  ReactPropTypes.resetWarningCache = checkPropTypes.resetWarningCache;
  ReactPropTypes.PropTypes = ReactPropTypes;

  return ReactPropTypes;
};


/***/ }),

/***/ "./node_modules/prop-types/index.js":
/*!******************************************!*\
  !*** ./node_modules/prop-types/index.js ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

/**
 * Copyright (c) 2013-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

if (true) {
  var ReactIs = __webpack_require__(/*! react-is */ "./node_modules/react-is/index.js");

  // By explicitly using `prop-types` you are opting into new development behavior.
  // http://fb.me/prop-types-in-prod
  var throwOnDirectAccess = true;
  module.exports = __webpack_require__(/*! ./factoryWithTypeCheckers */ "./node_modules/prop-types/factoryWithTypeCheckers.js")(ReactIs.isElement, throwOnDirectAccess);
} else {}


/***/ }),

/***/ "./node_modules/prop-types/lib/ReactPropTypesSecret.js":
/*!*******************************************************************************************************************!*\
  !*** delegated ./node_modules/prop-types/lib/ReactPropTypesSecret.js from dll-reference dll_01f9a3fa864a7b7414d8 ***!
  \*******************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = (__webpack_require__(/*! dll-reference dll_01f9a3fa864a7b7414d8 */ "dll-reference dll_01f9a3fa864a7b7414d8"))("./node_modules/prop-types/lib/ReactPropTypesSecret.js");

/***/ }),

/***/ "./node_modules/punycode/punycode.js":
/*!*******************************************!*\
  !*** ./node_modules/punycode/punycode.js ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

/* WEBPACK VAR INJECTION */(function(module, global) {var __WEBPACK_AMD_DEFINE_RESULT__;/*! https://mths.be/punycode v1.4.1 by @mathias */
;(function(root) {

	/** Detect free variables */
	var freeExports =  true && exports &&
		!exports.nodeType && exports;
	var freeModule =  true && module &&
		!module.nodeType && module;
	var freeGlobal = typeof global == 'object' && global;
	if (
		freeGlobal.global === freeGlobal ||
		freeGlobal.window === freeGlobal ||
		freeGlobal.self === freeGlobal
	) {
		root = freeGlobal;
	}

	/**
	 * The `punycode` object.
	 * @name punycode
	 * @type Object
	 */
	var punycode,

	/** Highest positive signed 32-bit float value */
	maxInt = 2147483647, // aka. 0x7FFFFFFF or 2^31-1

	/** Bootstring parameters */
	base = 36,
	tMin = 1,
	tMax = 26,
	skew = 38,
	damp = 700,
	initialBias = 72,
	initialN = 128, // 0x80
	delimiter = '-', // '\x2D'

	/** Regular expressions */
	regexPunycode = /^xn--/,
	regexNonASCII = /[^\x20-\x7E]/, // unprintable ASCII chars + non-ASCII chars
	regexSeparators = /[\x2E\u3002\uFF0E\uFF61]/g, // RFC 3490 separators

	/** Error messages */
	errors = {
		'overflow': 'Overflow: input needs wider integers to process',
		'not-basic': 'Illegal input >= 0x80 (not a basic code point)',
		'invalid-input': 'Invalid input'
	},

	/** Convenience shortcuts */
	baseMinusTMin = base - tMin,
	floor = Math.floor,
	stringFromCharCode = String.fromCharCode,

	/** Temporary variable */
	key;

	/*--------------------------------------------------------------------------*/

	/**
	 * A generic error utility function.
	 * @private
	 * @param {String} type The error type.
	 * @returns {Error} Throws a `RangeError` with the applicable error message.
	 */
	function error(type) {
		throw new RangeError(errors[type]);
	}

	/**
	 * A generic `Array#map` utility function.
	 * @private
	 * @param {Array} array The array to iterate over.
	 * @param {Function} callback The function that gets called for every array
	 * item.
	 * @returns {Array} A new array of values returned by the callback function.
	 */
	function map(array, fn) {
		var length = array.length;
		var result = [];
		while (length--) {
			result[length] = fn(array[length]);
		}
		return result;
	}

	/**
	 * A simple `Array#map`-like wrapper to work with domain name strings or email
	 * addresses.
	 * @private
	 * @param {String} domain The domain name or email address.
	 * @param {Function} callback The function that gets called for every
	 * character.
	 * @returns {Array} A new string of characters returned by the callback
	 * function.
	 */
	function mapDomain(string, fn) {
		var parts = string.split('@');
		var result = '';
		if (parts.length > 1) {
			// In email addresses, only the domain name should be punycoded. Leave
			// the local part (i.e. everything up to `@`) intact.
			result = parts[0] + '@';
			string = parts[1];
		}
		// Avoid `split(regex)` for IE8 compatibility. See #17.
		string = string.replace(regexSeparators, '\x2E');
		var labels = string.split('.');
		var encoded = map(labels, fn).join('.');
		return result + encoded;
	}

	/**
	 * Creates an array containing the numeric code points of each Unicode
	 * character in the string. While JavaScript uses UCS-2 internally,
	 * this function will convert a pair of surrogate halves (each of which
	 * UCS-2 exposes as separate characters) into a single code point,
	 * matching UTF-16.
	 * @see `punycode.ucs2.encode`
	 * @see <https://mathiasbynens.be/notes/javascript-encoding>
	 * @memberOf punycode.ucs2
	 * @name decode
	 * @param {String} string The Unicode input string (UCS-2).
	 * @returns {Array} The new array of code points.
	 */
	function ucs2decode(string) {
		var output = [],
		    counter = 0,
		    length = string.length,
		    value,
		    extra;
		while (counter < length) {
			value = string.charCodeAt(counter++);
			if (value >= 0xD800 && value <= 0xDBFF && counter < length) {
				// high surrogate, and there is a next character
				extra = string.charCodeAt(counter++);
				if ((extra & 0xFC00) == 0xDC00) { // low surrogate
					output.push(((value & 0x3FF) << 10) + (extra & 0x3FF) + 0x10000);
				} else {
					// unmatched surrogate; only append this code unit, in case the next
					// code unit is the high surrogate of a surrogate pair
					output.push(value);
					counter--;
				}
			} else {
				output.push(value);
			}
		}
		return output;
	}

	/**
	 * Creates a string based on an array of numeric code points.
	 * @see `punycode.ucs2.decode`
	 * @memberOf punycode.ucs2
	 * @name encode
	 * @param {Array} codePoints The array of numeric code points.
	 * @returns {String} The new Unicode string (UCS-2).
	 */
	function ucs2encode(array) {
		return map(array, function(value) {
			var output = '';
			if (value > 0xFFFF) {
				value -= 0x10000;
				output += stringFromCharCode(value >>> 10 & 0x3FF | 0xD800);
				value = 0xDC00 | value & 0x3FF;
			}
			output += stringFromCharCode(value);
			return output;
		}).join('');
	}

	/**
	 * Converts a basic code point into a digit/integer.
	 * @see `digitToBasic()`
	 * @private
	 * @param {Number} codePoint The basic numeric code point value.
	 * @returns {Number} The numeric value of a basic code point (for use in
	 * representing integers) in the range `0` to `base - 1`, or `base` if
	 * the code point does not represent a value.
	 */
	function basicToDigit(codePoint) {
		if (codePoint - 48 < 10) {
			return codePoint - 22;
		}
		if (codePoint - 65 < 26) {
			return codePoint - 65;
		}
		if (codePoint - 97 < 26) {
			return codePoint - 97;
		}
		return base;
	}

	/**
	 * Converts a digit/integer into a basic code point.
	 * @see `basicToDigit()`
	 * @private
	 * @param {Number} digit The numeric value of a basic code point.
	 * @returns {Number} The basic code point whose value (when used for
	 * representing integers) is `digit`, which needs to be in the range
	 * `0` to `base - 1`. If `flag` is non-zero, the uppercase form is
	 * used; else, the lowercase form is used. The behavior is undefined
	 * if `flag` is non-zero and `digit` has no uppercase form.
	 */
	function digitToBasic(digit, flag) {
		//  0..25 map to ASCII a..z or A..Z
		// 26..35 map to ASCII 0..9
		return digit + 22 + 75 * (digit < 26) - ((flag != 0) << 5);
	}

	/**
	 * Bias adaptation function as per section 3.4 of RFC 3492.
	 * https://tools.ietf.org/html/rfc3492#section-3.4
	 * @private
	 */
	function adapt(delta, numPoints, firstTime) {
		var k = 0;
		delta = firstTime ? floor(delta / damp) : delta >> 1;
		delta += floor(delta / numPoints);
		for (/* no initialization */; delta > baseMinusTMin * tMax >> 1; k += base) {
			delta = floor(delta / baseMinusTMin);
		}
		return floor(k + (baseMinusTMin + 1) * delta / (delta + skew));
	}

	/**
	 * Converts a Punycode string of ASCII-only symbols to a string of Unicode
	 * symbols.
	 * @memberOf punycode
	 * @param {String} input The Punycode string of ASCII-only symbols.
	 * @returns {String} The resulting string of Unicode symbols.
	 */
	function decode(input) {
		// Don't use UCS-2
		var output = [],
		    inputLength = input.length,
		    out,
		    i = 0,
		    n = initialN,
		    bias = initialBias,
		    basic,
		    j,
		    index,
		    oldi,
		    w,
		    k,
		    digit,
		    t,
		    /** Cached calculation results */
		    baseMinusT;

		// Handle the basic code points: let `basic` be the number of input code
		// points before the last delimiter, or `0` if there is none, then copy
		// the first basic code points to the output.

		basic = input.lastIndexOf(delimiter);
		if (basic < 0) {
			basic = 0;
		}

		for (j = 0; j < basic; ++j) {
			// if it's not a basic code point
			if (input.charCodeAt(j) >= 0x80) {
				error('not-basic');
			}
			output.push(input.charCodeAt(j));
		}

		// Main decoding loop: start just after the last delimiter if any basic code
		// points were copied; start at the beginning otherwise.

		for (index = basic > 0 ? basic + 1 : 0; index < inputLength; /* no final expression */) {

			// `index` is the index of the next character to be consumed.
			// Decode a generalized variable-length integer into `delta`,
			// which gets added to `i`. The overflow checking is easier
			// if we increase `i` as we go, then subtract off its starting
			// value at the end to obtain `delta`.
			for (oldi = i, w = 1, k = base; /* no condition */; k += base) {

				if (index >= inputLength) {
					error('invalid-input');
				}

				digit = basicToDigit(input.charCodeAt(index++));

				if (digit >= base || digit > floor((maxInt - i) / w)) {
					error('overflow');
				}

				i += digit * w;
				t = k <= bias ? tMin : (k >= bias + tMax ? tMax : k - bias);

				if (digit < t) {
					break;
				}

				baseMinusT = base - t;
				if (w > floor(maxInt / baseMinusT)) {
					error('overflow');
				}

				w *= baseMinusT;

			}

			out = output.length + 1;
			bias = adapt(i - oldi, out, oldi == 0);

			// `i` was supposed to wrap around from `out` to `0`,
			// incrementing `n` each time, so we'll fix that now:
			if (floor(i / out) > maxInt - n) {
				error('overflow');
			}

			n += floor(i / out);
			i %= out;

			// Insert `n` at position `i` of the output
			output.splice(i++, 0, n);

		}

		return ucs2encode(output);
	}

	/**
	 * Converts a string of Unicode symbols (e.g. a domain name label) to a
	 * Punycode string of ASCII-only symbols.
	 * @memberOf punycode
	 * @param {String} input The string of Unicode symbols.
	 * @returns {String} The resulting Punycode string of ASCII-only symbols.
	 */
	function encode(input) {
		var n,
		    delta,
		    handledCPCount,
		    basicLength,
		    bias,
		    j,
		    m,
		    q,
		    k,
		    t,
		    currentValue,
		    output = [],
		    /** `inputLength` will hold the number of code points in `input`. */
		    inputLength,
		    /** Cached calculation results */
		    handledCPCountPlusOne,
		    baseMinusT,
		    qMinusT;

		// Convert the input in UCS-2 to Unicode
		input = ucs2decode(input);

		// Cache the length
		inputLength = input.length;

		// Initialize the state
		n = initialN;
		delta = 0;
		bias = initialBias;

		// Handle the basic code points
		for (j = 0; j < inputLength; ++j) {
			currentValue = input[j];
			if (currentValue < 0x80) {
				output.push(stringFromCharCode(currentValue));
			}
		}

		handledCPCount = basicLength = output.length;

		// `handledCPCount` is the number of code points that have been handled;
		// `basicLength` is the number of basic code points.

		// Finish the basic string - if it is not empty - with a delimiter
		if (basicLength) {
			output.push(delimiter);
		}

		// Main encoding loop:
		while (handledCPCount < inputLength) {

			// All non-basic code points < n have been handled already. Find the next
			// larger one:
			for (m = maxInt, j = 0; j < inputLength; ++j) {
				currentValue = input[j];
				if (currentValue >= n && currentValue < m) {
					m = currentValue;
				}
			}

			// Increase `delta` enough to advance the decoder's <n,i> state to <m,0>,
			// but guard against overflow
			handledCPCountPlusOne = handledCPCount + 1;
			if (m - n > floor((maxInt - delta) / handledCPCountPlusOne)) {
				error('overflow');
			}

			delta += (m - n) * handledCPCountPlusOne;
			n = m;

			for (j = 0; j < inputLength; ++j) {
				currentValue = input[j];

				if (currentValue < n && ++delta > maxInt) {
					error('overflow');
				}

				if (currentValue == n) {
					// Represent delta as a generalized variable-length integer
					for (q = delta, k = base; /* no condition */; k += base) {
						t = k <= bias ? tMin : (k >= bias + tMax ? tMax : k - bias);
						if (q < t) {
							break;
						}
						qMinusT = q - t;
						baseMinusT = base - t;
						output.push(
							stringFromCharCode(digitToBasic(t + qMinusT % baseMinusT, 0))
						);
						q = floor(qMinusT / baseMinusT);
					}

					output.push(stringFromCharCode(digitToBasic(q, 0)));
					bias = adapt(delta, handledCPCountPlusOne, handledCPCount == basicLength);
					delta = 0;
					++handledCPCount;
				}
			}

			++delta;
			++n;

		}
		return output.join('');
	}

	/**
	 * Converts a Punycode string representing a domain name or an email address
	 * to Unicode. Only the Punycoded parts of the input will be converted, i.e.
	 * it doesn't matter if you call it on a string that has already been
	 * converted to Unicode.
	 * @memberOf punycode
	 * @param {String} input The Punycoded domain name or email address to
	 * convert to Unicode.
	 * @returns {String} The Unicode representation of the given Punycode
	 * string.
	 */
	function toUnicode(input) {
		return mapDomain(input, function(string) {
			return regexPunycode.test(string)
				? decode(string.slice(4).toLowerCase())
				: string;
		});
	}

	/**
	 * Converts a Unicode string representing a domain name or an email address to
	 * Punycode. Only the non-ASCII parts of the domain name will be converted,
	 * i.e. it doesn't matter if you call it with a domain that's already in
	 * ASCII.
	 * @memberOf punycode
	 * @param {String} input The domain name or email address to convert, as a
	 * Unicode string.
	 * @returns {String} The Punycode representation of the given domain name or
	 * email address.
	 */
	function toASCII(input) {
		return mapDomain(input, function(string) {
			return regexNonASCII.test(string)
				? 'xn--' + encode(string)
				: string;
		});
	}

	/*--------------------------------------------------------------------------*/

	/** Define the public API */
	punycode = {
		/**
		 * A string representing the current Punycode.js version number.
		 * @memberOf punycode
		 * @type String
		 */
		'version': '1.4.1',
		/**
		 * An object of methods to convert from JavaScript's internal character
		 * representation (UCS-2) to Unicode code points, and back.
		 * @see <https://mathiasbynens.be/notes/javascript-encoding>
		 * @memberOf punycode
		 * @type Object
		 */
		'ucs2': {
			'decode': ucs2decode,
			'encode': ucs2encode
		},
		'decode': decode,
		'encode': encode,
		'toASCII': toASCII,
		'toUnicode': toUnicode
	};

	/** Expose `punycode` */
	// Some AMD build optimizers, like r.js, check for specific condition patterns
	// like the following:
	if (
		true
	) {
		!(__WEBPACK_AMD_DEFINE_RESULT__ = (function() {
			return punycode;
		}).call(exports, __webpack_require__, exports, module),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));
	} else {}

}(this));

/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! ./../webpack/buildin/module.js */ "./node_modules/webpack/buildin/module.js")(module), __webpack_require__(/*! ./../webpack/buildin/global.js */ "./node_modules/webpack/buildin/global.js")))

/***/ }),

/***/ "./node_modules/querystring-es3/decode.js":
/*!************************************************!*\
  !*** ./node_modules/querystring-es3/decode.js ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
// Copyright Joyent, Inc. and other Node contributors.
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to permit
// persons to whom the Software is furnished to do so, subject to the
// following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
// USE OR OTHER DEALINGS IN THE SOFTWARE.



// If obj.hasOwnProperty has been overridden, then calling
// obj.hasOwnProperty(prop) will break.
// See: https://github.com/joyent/node/issues/1707
function hasOwnProperty(obj, prop) {
  return Object.prototype.hasOwnProperty.call(obj, prop);
}

module.exports = function(qs, sep, eq, options) {
  sep = sep || '&';
  eq = eq || '=';
  var obj = {};

  if (typeof qs !== 'string' || qs.length === 0) {
    return obj;
  }

  var regexp = /\+/g;
  qs = qs.split(sep);

  var maxKeys = 1000;
  if (options && typeof options.maxKeys === 'number') {
    maxKeys = options.maxKeys;
  }

  var len = qs.length;
  // maxKeys <= 0 means that we should not limit keys count
  if (maxKeys > 0 && len > maxKeys) {
    len = maxKeys;
  }

  for (var i = 0; i < len; ++i) {
    var x = qs[i].replace(regexp, '%20'),
        idx = x.indexOf(eq),
        kstr, vstr, k, v;

    if (idx >= 0) {
      kstr = x.substr(0, idx);
      vstr = x.substr(idx + 1);
    } else {
      kstr = x;
      vstr = '';
    }

    k = decodeURIComponent(kstr);
    v = decodeURIComponent(vstr);

    if (!hasOwnProperty(obj, k)) {
      obj[k] = v;
    } else if (isArray(obj[k])) {
      obj[k].push(v);
    } else {
      obj[k] = [obj[k], v];
    }
  }

  return obj;
};

var isArray = Array.isArray || function (xs) {
  return Object.prototype.toString.call(xs) === '[object Array]';
};


/***/ }),

/***/ "./node_modules/querystring-es3/encode.js":
/*!************************************************!*\
  !*** ./node_modules/querystring-es3/encode.js ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
// Copyright Joyent, Inc. and other Node contributors.
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to permit
// persons to whom the Software is furnished to do so, subject to the
// following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
// USE OR OTHER DEALINGS IN THE SOFTWARE.



var stringifyPrimitive = function(v) {
  switch (typeof v) {
    case 'string':
      return v;

    case 'boolean':
      return v ? 'true' : 'false';

    case 'number':
      return isFinite(v) ? v : '';

    default:
      return '';
  }
};

module.exports = function(obj, sep, eq, name) {
  sep = sep || '&';
  eq = eq || '=';
  if (obj === null) {
    obj = undefined;
  }

  if (typeof obj === 'object') {
    return map(objectKeys(obj), function(k) {
      var ks = encodeURIComponent(stringifyPrimitive(k)) + eq;
      if (isArray(obj[k])) {
        return map(obj[k], function(v) {
          return ks + encodeURIComponent(stringifyPrimitive(v));
        }).join(sep);
      } else {
        return ks + encodeURIComponent(stringifyPrimitive(obj[k]));
      }
    }).join(sep);

  }

  if (!name) return '';
  return encodeURIComponent(stringifyPrimitive(name)) + eq +
         encodeURIComponent(stringifyPrimitive(obj));
};

var isArray = Array.isArray || function (xs) {
  return Object.prototype.toString.call(xs) === '[object Array]';
};

function map (xs, f) {
  if (xs.map) return xs.map(f);
  var res = [];
  for (var i = 0; i < xs.length; i++) {
    res.push(f(xs[i], i));
  }
  return res;
}

var objectKeys = Object.keys || function (obj) {
  var res = [];
  for (var key in obj) {
    if (Object.prototype.hasOwnProperty.call(obj, key)) res.push(key);
  }
  return res;
};


/***/ }),

/***/ "./node_modules/querystring-es3/index.js":
/*!***********************************************!*\
  !*** ./node_modules/querystring-es3/index.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


exports.decode = exports.parse = __webpack_require__(/*! ./decode */ "./node_modules/querystring-es3/decode.js");
exports.encode = exports.stringify = __webpack_require__(/*! ./encode */ "./node_modules/querystring-es3/encode.js");


/***/ }),

/***/ "./node_modules/react-fast-compare/index.js":
/*!**************************************************!*\
  !*** ./node_modules/react-fast-compare/index.js ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var isArray = Array.isArray;
var keyList = Object.keys;
var hasProp = Object.prototype.hasOwnProperty;
var hasElementType = typeof Element !== 'undefined';

function equal(a, b) {
  // fast-deep-equal index.js 2.0.1
  if (a === b) return true;

  if (a && b && typeof a == 'object' && typeof b == 'object') {
    var arrA = isArray(a)
      , arrB = isArray(b)
      , i
      , length
      , key;

    if (arrA && arrB) {
      length = a.length;
      if (length != b.length) return false;
      for (i = length; i-- !== 0;)
        if (!equal(a[i], b[i])) return false;
      return true;
    }

    if (arrA != arrB) return false;

    var dateA = a instanceof Date
      , dateB = b instanceof Date;
    if (dateA != dateB) return false;
    if (dateA && dateB) return a.getTime() == b.getTime();

    var regexpA = a instanceof RegExp
      , regexpB = b instanceof RegExp;
    if (regexpA != regexpB) return false;
    if (regexpA && regexpB) return a.toString() == b.toString();

    var keys = keyList(a);
    length = keys.length;

    if (length !== keyList(b).length)
      return false;

    for (i = length; i-- !== 0;)
      if (!hasProp.call(b, keys[i])) return false;
    // end fast-deep-equal

    // start react-fast-compare
    // custom handling for DOM elements
    if (hasElementType && a instanceof Element && b instanceof Element)
      return a === b;

    // custom handling for React
    for (i = length; i-- !== 0;) {
      key = keys[i];
      if (key === '_owner' && a.$$typeof) {
        // React-specific: avoid traversing React elements' _owner.
        //  _owner contains circular references
        // and is not needed when comparing the actual elements (and not their owners)
        // .$$typeof and ._store on just reasonable markers of a react element
        continue;
      } else {
        // all other properties should be traversed as usual
        if (!equal(a[key], b[key])) return false;
      }
    }
    // end react-fast-compare

    // fast-deep-equal index.js 2.0.1
    return true;
  }

  return a !== a && b !== b;
}
// end fast-deep-equal

module.exports = function exportedEqual(a, b) {
  try {
    return equal(a, b);
  } catch (error) {
    if ((error.message && error.message.match(/stack|recursion/i)) || (error.number === -2146828260)) {
      // warn on circular references, don't crash
      // browsers give this different errors name and messages:
      // chrome/safari: "RangeError", "Maximum call stack size exceeded"
      // firefox: "InternalError", too much recursion"
      // edge: "Error", "Out of stack space"
      console.warn('Warning: react-fast-compare does not handle circular references.', error.name, error.message);
      return false;
    }
    // some other error. we should definitely know about these
    throw error;
  }
};


/***/ }),

/***/ "./node_modules/react-is/cjs/react-is.development.js":
/*!***********************************************************!*\
  !*** ./node_modules/react-is/cjs/react-is.development.js ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/** @license React v16.9.0
 * react-is.development.js
 *
 * Copyright (c) Facebook, Inc. and its affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */





if (true) {
  (function() {
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

// The Symbol used to tag the ReactElement-like types. If there is no native Symbol
// nor polyfill, then a plain number is used for performance.
var hasSymbol = typeof Symbol === 'function' && Symbol.for;

var REACT_ELEMENT_TYPE = hasSymbol ? Symbol.for('react.element') : 0xeac7;
var REACT_PORTAL_TYPE = hasSymbol ? Symbol.for('react.portal') : 0xeaca;
var REACT_FRAGMENT_TYPE = hasSymbol ? Symbol.for('react.fragment') : 0xeacb;
var REACT_STRICT_MODE_TYPE = hasSymbol ? Symbol.for('react.strict_mode') : 0xeacc;
var REACT_PROFILER_TYPE = hasSymbol ? Symbol.for('react.profiler') : 0xead2;
var REACT_PROVIDER_TYPE = hasSymbol ? Symbol.for('react.provider') : 0xeacd;
var REACT_CONTEXT_TYPE = hasSymbol ? Symbol.for('react.context') : 0xeace;
// TODO: We don't use AsyncMode or ConcurrentMode anymore. They were temporary
// (unstable) APIs that have been removed. Can we remove the symbols?
var REACT_ASYNC_MODE_TYPE = hasSymbol ? Symbol.for('react.async_mode') : 0xeacf;
var REACT_CONCURRENT_MODE_TYPE = hasSymbol ? Symbol.for('react.concurrent_mode') : 0xeacf;
var REACT_FORWARD_REF_TYPE = hasSymbol ? Symbol.for('react.forward_ref') : 0xead0;
var REACT_SUSPENSE_TYPE = hasSymbol ? Symbol.for('react.suspense') : 0xead1;
var REACT_SUSPENSE_LIST_TYPE = hasSymbol ? Symbol.for('react.suspense_list') : 0xead8;
var REACT_MEMO_TYPE = hasSymbol ? Symbol.for('react.memo') : 0xead3;
var REACT_LAZY_TYPE = hasSymbol ? Symbol.for('react.lazy') : 0xead4;
var REACT_FUNDAMENTAL_TYPE = hasSymbol ? Symbol.for('react.fundamental') : 0xead5;
var REACT_RESPONDER_TYPE = hasSymbol ? Symbol.for('react.responder') : 0xead6;

function isValidElementType(type) {
  return typeof type === 'string' || typeof type === 'function' ||
  // Note: its typeof might be other than 'symbol' or 'number' if it's a polyfill.
  type === REACT_FRAGMENT_TYPE || type === REACT_CONCURRENT_MODE_TYPE || type === REACT_PROFILER_TYPE || type === REACT_STRICT_MODE_TYPE || type === REACT_SUSPENSE_TYPE || type === REACT_SUSPENSE_LIST_TYPE || typeof type === 'object' && type !== null && (type.$$typeof === REACT_LAZY_TYPE || type.$$typeof === REACT_MEMO_TYPE || type.$$typeof === REACT_PROVIDER_TYPE || type.$$typeof === REACT_CONTEXT_TYPE || type.$$typeof === REACT_FORWARD_REF_TYPE || type.$$typeof === REACT_FUNDAMENTAL_TYPE || type.$$typeof === REACT_RESPONDER_TYPE);
}

/**
 * Forked from fbjs/warning:
 * https://github.com/facebook/fbjs/blob/e66ba20ad5be433eb54423f2b097d829324d9de6/packages/fbjs/src/__forks__/warning.js
 *
 * Only change is we use console.warn instead of console.error,
 * and do nothing when 'console' is not supported.
 * This really simplifies the code.
 * ---
 * Similar to invariant but only logs a warning if the condition is not met.
 * This can be used to log issues in development environments in critical
 * paths. Removing the logging code for production environments will keep the
 * same logic and follow the same code paths.
 */

var lowPriorityWarning = function () {};

{
  var printWarning = function (format) {
    for (var _len = arguments.length, args = Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
      args[_key - 1] = arguments[_key];
    }

    var argIndex = 0;
    var message = 'Warning: ' + format.replace(/%s/g, function () {
      return args[argIndex++];
    });
    if (typeof console !== 'undefined') {
      console.warn(message);
    }
    try {
      // --- Welcome to debugging React ---
      // This error was thrown as a convenience so that you can use this stack
      // to find the callsite that caused this warning to fire.
      throw new Error(message);
    } catch (x) {}
  };

  lowPriorityWarning = function (condition, format) {
    if (format === undefined) {
      throw new Error('`lowPriorityWarning(condition, format, ...args)` requires a warning ' + 'message argument');
    }
    if (!condition) {
      for (var _len2 = arguments.length, args = Array(_len2 > 2 ? _len2 - 2 : 0), _key2 = 2; _key2 < _len2; _key2++) {
        args[_key2 - 2] = arguments[_key2];
      }

      printWarning.apply(undefined, [format].concat(args));
    }
  };
}

var lowPriorityWarning$1 = lowPriorityWarning;

function typeOf(object) {
  if (typeof object === 'object' && object !== null) {
    var $$typeof = object.$$typeof;
    switch ($$typeof) {
      case REACT_ELEMENT_TYPE:
        var type = object.type;

        switch (type) {
          case REACT_ASYNC_MODE_TYPE:
          case REACT_CONCURRENT_MODE_TYPE:
          case REACT_FRAGMENT_TYPE:
          case REACT_PROFILER_TYPE:
          case REACT_STRICT_MODE_TYPE:
          case REACT_SUSPENSE_TYPE:
            return type;
          default:
            var $$typeofType = type && type.$$typeof;

            switch ($$typeofType) {
              case REACT_CONTEXT_TYPE:
              case REACT_FORWARD_REF_TYPE:
              case REACT_PROVIDER_TYPE:
                return $$typeofType;
              default:
                return $$typeof;
            }
        }
      case REACT_LAZY_TYPE:
      case REACT_MEMO_TYPE:
      case REACT_PORTAL_TYPE:
        return $$typeof;
    }
  }

  return undefined;
}

// AsyncMode is deprecated along with isAsyncMode
var AsyncMode = REACT_ASYNC_MODE_TYPE;
var ConcurrentMode = REACT_CONCURRENT_MODE_TYPE;
var ContextConsumer = REACT_CONTEXT_TYPE;
var ContextProvider = REACT_PROVIDER_TYPE;
var Element = REACT_ELEMENT_TYPE;
var ForwardRef = REACT_FORWARD_REF_TYPE;
var Fragment = REACT_FRAGMENT_TYPE;
var Lazy = REACT_LAZY_TYPE;
var Memo = REACT_MEMO_TYPE;
var Portal = REACT_PORTAL_TYPE;
var Profiler = REACT_PROFILER_TYPE;
var StrictMode = REACT_STRICT_MODE_TYPE;
var Suspense = REACT_SUSPENSE_TYPE;

var hasWarnedAboutDeprecatedIsAsyncMode = false;

// AsyncMode should be deprecated
function isAsyncMode(object) {
  {
    if (!hasWarnedAboutDeprecatedIsAsyncMode) {
      hasWarnedAboutDeprecatedIsAsyncMode = true;
      lowPriorityWarning$1(false, 'The ReactIs.isAsyncMode() alias has been deprecated, ' + 'and will be removed in React 17+. Update your code to use ' + 'ReactIs.isConcurrentMode() instead. It has the exact same API.');
    }
  }
  return isConcurrentMode(object) || typeOf(object) === REACT_ASYNC_MODE_TYPE;
}
function isConcurrentMode(object) {
  return typeOf(object) === REACT_CONCURRENT_MODE_TYPE;
}
function isContextConsumer(object) {
  return typeOf(object) === REACT_CONTEXT_TYPE;
}
function isContextProvider(object) {
  return typeOf(object) === REACT_PROVIDER_TYPE;
}
function isElement(object) {
  return typeof object === 'object' && object !== null && object.$$typeof === REACT_ELEMENT_TYPE;
}
function isForwardRef(object) {
  return typeOf(object) === REACT_FORWARD_REF_TYPE;
}
function isFragment(object) {
  return typeOf(object) === REACT_FRAGMENT_TYPE;
}
function isLazy(object) {
  return typeOf(object) === REACT_LAZY_TYPE;
}
function isMemo(object) {
  return typeOf(object) === REACT_MEMO_TYPE;
}
function isPortal(object) {
  return typeOf(object) === REACT_PORTAL_TYPE;
}
function isProfiler(object) {
  return typeOf(object) === REACT_PROFILER_TYPE;
}
function isStrictMode(object) {
  return typeOf(object) === REACT_STRICT_MODE_TYPE;
}
function isSuspense(object) {
  return typeOf(object) === REACT_SUSPENSE_TYPE;
}

exports.typeOf = typeOf;
exports.AsyncMode = AsyncMode;
exports.ConcurrentMode = ConcurrentMode;
exports.ContextConsumer = ContextConsumer;
exports.ContextProvider = ContextProvider;
exports.Element = Element;
exports.ForwardRef = ForwardRef;
exports.Fragment = Fragment;
exports.Lazy = Lazy;
exports.Memo = Memo;
exports.Portal = Portal;
exports.Profiler = Profiler;
exports.StrictMode = StrictMode;
exports.Suspense = Suspense;
exports.isValidElementType = isValidElementType;
exports.isAsyncMode = isAsyncMode;
exports.isConcurrentMode = isConcurrentMode;
exports.isContextConsumer = isContextConsumer;
exports.isContextProvider = isContextProvider;
exports.isElement = isElement;
exports.isForwardRef = isForwardRef;
exports.isFragment = isFragment;
exports.isLazy = isLazy;
exports.isMemo = isMemo;
exports.isPortal = isPortal;
exports.isProfiler = isProfiler;
exports.isStrictMode = isStrictMode;
exports.isSuspense = isSuspense;
  })();
}


/***/ }),

/***/ "./node_modules/react-is/index.js":
/*!****************************************!*\
  !*** ./node_modules/react-is/index.js ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


if (false) {} else {
  module.exports = __webpack_require__(/*! ./cjs/react-is.development.js */ "./node_modules/react-is/cjs/react-is.development.js");
}


/***/ }),

/***/ "./node_modules/react-use/esm/createMemo.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/createMemo.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var createMemo = function (fn) { return function () {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    return Object(react__WEBPACK_IMPORTED_MODULE_0__["useMemo"])(function () { return fn.apply(void 0, args); }, args);
}; };
/* harmony default export */ __webpack_exports__["default"] = (createMemo);


/***/ }),

/***/ "./node_modules/react-use/esm/createReducer.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/createReducer.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUpdateEffect */ "./node_modules/react-use/esm/useUpdateEffect.js");


function composeMiddleware(chain) {
    return function (context, dispatch) {
        return chain.reduceRight(function (res, middleware) {
            return middleware(context)(res);
        }, dispatch);
    };
}
var createReducer = function () {
    var middlewares = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        middlewares[_i] = arguments[_i];
    }
    var composedMiddleware = composeMiddleware(middlewares);
    return function (reducer, initialState, initializer) {
        if (initializer === void 0) { initializer = function (value) { return value; }; }
        var ref = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(initializer(initialState));
        var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(ref.current), setState = _a[1];
        var dispatch = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (action) {
            ref.current = reducer(ref.current, action);
            setState(ref.current);
            return action;
        }, [reducer]);
        var dispatchRef = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(composedMiddleware({
            getState: function () { return ref.current; },
            dispatch: function () {
                var args = [];
                for (var _i = 0; _i < arguments.length; _i++) {
                    args[_i] = arguments[_i];
                }
                return dispatchRef.current.apply(dispatchRef, args);
            },
        }, dispatch));
        Object(_useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
            dispatchRef.current = composedMiddleware({
                getState: function () { return ref.current; },
                dispatch: function () {
                    var args = [];
                    for (var _i = 0; _i < arguments.length; _i++) {
                        args[_i] = arguments[_i];
                    }
                    return dispatchRef.current.apply(dispatchRef, args);
                },
            }, dispatch);
        }, [dispatch]);
        return [ref.current, dispatchRef.current];
    };
};
/* harmony default export */ __webpack_exports__["default"] = (createReducer);


/***/ }),

/***/ "./node_modules/react-use/esm/index.js":
/*!*********************************************!*\
  !*** ./node_modules/react-use/esm/index.js ***!
  \*********************************************/
/*! exports provided: createMemo, createReducer, useAsync, useAsyncFn, useAsyncRetry, useAudio, useBattery, useBeforeUnload, useBoolean, useClickAway, useCopyToClipboard, useCounter, useCss, useDebounce, useDeepCompareEffect, useDefault, useDrop, useDropArea, useEffectOnce, useEvent, useFavicon, useFullscreen, useGeolocation, useGetSet, useGetSetState, useHover, useHoverDirty, useIdle, useInterval, useIsomorphicLayoutEffect, useKey, useKeyPress, useKeyPressEvent, useLifecycles, useList, useLocalStorage, useLocation, useLockBodyScroll, useLogger, useMap, useMedia, useMediaDevices, useMotion, useMount, useMountedState, useMouse, useMouseHovered, useNetwork, useNumber, useObservable, useOrientation, usePageLeave, usePermission, usePrevious, usePromise, useRaf, useRafLoop, useRefMounted, useScroll, useScrolling, useSessionStorage, useSetState, useSize, useSpeech, useStartTyping, useThrottle, useThrottleFn, useTimeout, useTitle, useToggle, useTween, useUnmount, useUpdate, useUpdateEffect, useVideo, useWait, Waiter, useWindowScroll, useWindowSize */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _createMemo__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./createMemo */ "./node_modules/react-use/esm/createMemo.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "createMemo", function() { return _createMemo__WEBPACK_IMPORTED_MODULE_0__["default"]; });

/* harmony import */ var _createReducer__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./createReducer */ "./node_modules/react-use/esm/createReducer.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "createReducer", function() { return _createReducer__WEBPACK_IMPORTED_MODULE_1__["default"]; });

/* harmony import */ var _useAsync__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./useAsync */ "./node_modules/react-use/esm/useAsync.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useAsync", function() { return _useAsync__WEBPACK_IMPORTED_MODULE_2__["default"]; });

/* harmony import */ var _useAsyncFn__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./useAsyncFn */ "./node_modules/react-use/esm/useAsyncFn.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useAsyncFn", function() { return _useAsyncFn__WEBPACK_IMPORTED_MODULE_3__["default"]; });

/* harmony import */ var _useAsyncRetry__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./useAsyncRetry */ "./node_modules/react-use/esm/useAsyncRetry.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useAsyncRetry", function() { return _useAsyncRetry__WEBPACK_IMPORTED_MODULE_4__["default"]; });

/* harmony import */ var _useAudio__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./useAudio */ "./node_modules/react-use/esm/useAudio.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useAudio", function() { return _useAudio__WEBPACK_IMPORTED_MODULE_5__["default"]; });

/* harmony import */ var _useBattery__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./useBattery */ "./node_modules/react-use/esm/useBattery.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useBattery", function() { return _useBattery__WEBPACK_IMPORTED_MODULE_6__["default"]; });

/* harmony import */ var _useBeforeUnload__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./useBeforeUnload */ "./node_modules/react-use/esm/useBeforeUnload.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useBeforeUnload", function() { return _useBeforeUnload__WEBPACK_IMPORTED_MODULE_7__["default"]; });

/* harmony import */ var _useBoolean__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./useBoolean */ "./node_modules/react-use/esm/useBoolean.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useBoolean", function() { return _useBoolean__WEBPACK_IMPORTED_MODULE_8__["default"]; });

/* harmony import */ var _useClickAway__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./useClickAway */ "./node_modules/react-use/esm/useClickAway.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useClickAway", function() { return _useClickAway__WEBPACK_IMPORTED_MODULE_9__["default"]; });

/* harmony import */ var _useCopyToClipboard__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./useCopyToClipboard */ "./node_modules/react-use/esm/useCopyToClipboard.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useCopyToClipboard", function() { return _useCopyToClipboard__WEBPACK_IMPORTED_MODULE_10__["default"]; });

/* harmony import */ var _useCounter__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./useCounter */ "./node_modules/react-use/esm/useCounter.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useCounter", function() { return _useCounter__WEBPACK_IMPORTED_MODULE_11__["default"]; });

/* harmony import */ var _useCss__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./useCss */ "./node_modules/react-use/esm/useCss.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useCss", function() { return _useCss__WEBPACK_IMPORTED_MODULE_12__["default"]; });

/* harmony import */ var _useDebounce__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./useDebounce */ "./node_modules/react-use/esm/useDebounce.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useDebounce", function() { return _useDebounce__WEBPACK_IMPORTED_MODULE_13__["default"]; });

/* harmony import */ var _useDeepCompareEffect__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./useDeepCompareEffect */ "./node_modules/react-use/esm/useDeepCompareEffect.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useDeepCompareEffect", function() { return _useDeepCompareEffect__WEBPACK_IMPORTED_MODULE_14__["default"]; });

/* harmony import */ var _useDefault__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./useDefault */ "./node_modules/react-use/esm/useDefault.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useDefault", function() { return _useDefault__WEBPACK_IMPORTED_MODULE_15__["default"]; });

/* harmony import */ var _useDrop__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./useDrop */ "./node_modules/react-use/esm/useDrop.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useDrop", function() { return _useDrop__WEBPACK_IMPORTED_MODULE_16__["default"]; });

/* harmony import */ var _useDropArea__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./useDropArea */ "./node_modules/react-use/esm/useDropArea.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useDropArea", function() { return _useDropArea__WEBPACK_IMPORTED_MODULE_17__["default"]; });

/* harmony import */ var _useEffectOnce__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./useEffectOnce */ "./node_modules/react-use/esm/useEffectOnce.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useEffectOnce", function() { return _useEffectOnce__WEBPACK_IMPORTED_MODULE_18__["default"]; });

/* harmony import */ var _useEvent__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./useEvent */ "./node_modules/react-use/esm/useEvent.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useEvent", function() { return _useEvent__WEBPACK_IMPORTED_MODULE_19__["default"]; });

/* harmony import */ var _useFavicon__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./useFavicon */ "./node_modules/react-use/esm/useFavicon.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useFavicon", function() { return _useFavicon__WEBPACK_IMPORTED_MODULE_20__["default"]; });

/* harmony import */ var _useFullscreen__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./useFullscreen */ "./node_modules/react-use/esm/useFullscreen.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useFullscreen", function() { return _useFullscreen__WEBPACK_IMPORTED_MODULE_21__["default"]; });

/* harmony import */ var _useGeolocation__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./useGeolocation */ "./node_modules/react-use/esm/useGeolocation.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useGeolocation", function() { return _useGeolocation__WEBPACK_IMPORTED_MODULE_22__["default"]; });

/* harmony import */ var _useGetSet__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./useGetSet */ "./node_modules/react-use/esm/useGetSet.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useGetSet", function() { return _useGetSet__WEBPACK_IMPORTED_MODULE_23__["default"]; });

/* harmony import */ var _useGetSetState__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./useGetSetState */ "./node_modules/react-use/esm/useGetSetState.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useGetSetState", function() { return _useGetSetState__WEBPACK_IMPORTED_MODULE_24__["default"]; });

/* harmony import */ var _useHover__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! ./useHover */ "./node_modules/react-use/esm/useHover.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useHover", function() { return _useHover__WEBPACK_IMPORTED_MODULE_25__["default"]; });

/* harmony import */ var _useHoverDirty__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! ./useHoverDirty */ "./node_modules/react-use/esm/useHoverDirty.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useHoverDirty", function() { return _useHoverDirty__WEBPACK_IMPORTED_MODULE_26__["default"]; });

/* harmony import */ var _useIdle__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./useIdle */ "./node_modules/react-use/esm/useIdle.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useIdle", function() { return _useIdle__WEBPACK_IMPORTED_MODULE_27__["default"]; });

/* harmony import */ var _useInterval__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./useInterval */ "./node_modules/react-use/esm/useInterval.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useInterval", function() { return _useInterval__WEBPACK_IMPORTED_MODULE_28__["default"]; });

/* harmony import */ var _useIsomorphicLayoutEffect__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./useIsomorphicLayoutEffect */ "./node_modules/react-use/esm/useIsomorphicLayoutEffect.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useIsomorphicLayoutEffect", function() { return _useIsomorphicLayoutEffect__WEBPACK_IMPORTED_MODULE_29__["default"]; });

/* harmony import */ var _useKey__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! ./useKey */ "./node_modules/react-use/esm/useKey.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useKey", function() { return _useKey__WEBPACK_IMPORTED_MODULE_30__["default"]; });

/* harmony import */ var _useKeyPress__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! ./useKeyPress */ "./node_modules/react-use/esm/useKeyPress.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useKeyPress", function() { return _useKeyPress__WEBPACK_IMPORTED_MODULE_31__["default"]; });

/* harmony import */ var _useKeyPressEvent__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! ./useKeyPressEvent */ "./node_modules/react-use/esm/useKeyPressEvent.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useKeyPressEvent", function() { return _useKeyPressEvent__WEBPACK_IMPORTED_MODULE_32__["default"]; });

/* harmony import */ var _useLifecycles__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! ./useLifecycles */ "./node_modules/react-use/esm/useLifecycles.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useLifecycles", function() { return _useLifecycles__WEBPACK_IMPORTED_MODULE_33__["default"]; });

/* harmony import */ var _useList__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! ./useList */ "./node_modules/react-use/esm/useList.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useList", function() { return _useList__WEBPACK_IMPORTED_MODULE_34__["default"]; });

/* harmony import */ var _useLocalStorage__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! ./useLocalStorage */ "./node_modules/react-use/esm/useLocalStorage.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useLocalStorage", function() { return _useLocalStorage__WEBPACK_IMPORTED_MODULE_35__["default"]; });

/* harmony import */ var _useLocation__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! ./useLocation */ "./node_modules/react-use/esm/useLocation.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useLocation", function() { return _useLocation__WEBPACK_IMPORTED_MODULE_36__["default"]; });

/* harmony import */ var _useLockBodyScroll__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! ./useLockBodyScroll */ "./node_modules/react-use/esm/useLockBodyScroll.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useLockBodyScroll", function() { return _useLockBodyScroll__WEBPACK_IMPORTED_MODULE_37__["default"]; });

/* harmony import */ var _useLogger__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ./useLogger */ "./node_modules/react-use/esm/useLogger.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useLogger", function() { return _useLogger__WEBPACK_IMPORTED_MODULE_38__["default"]; });

/* harmony import */ var _useMap__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./useMap */ "./node_modules/react-use/esm/useMap.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMap", function() { return _useMap__WEBPACK_IMPORTED_MODULE_39__["default"]; });

/* harmony import */ var _useMedia__WEBPACK_IMPORTED_MODULE_40__ = __webpack_require__(/*! ./useMedia */ "./node_modules/react-use/esm/useMedia.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMedia", function() { return _useMedia__WEBPACK_IMPORTED_MODULE_40__["default"]; });

/* harmony import */ var _useMediaDevices__WEBPACK_IMPORTED_MODULE_41__ = __webpack_require__(/*! ./useMediaDevices */ "./node_modules/react-use/esm/useMediaDevices.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMediaDevices", function() { return _useMediaDevices__WEBPACK_IMPORTED_MODULE_41__["default"]; });

/* harmony import */ var _useMotion__WEBPACK_IMPORTED_MODULE_42__ = __webpack_require__(/*! ./useMotion */ "./node_modules/react-use/esm/useMotion.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMotion", function() { return _useMotion__WEBPACK_IMPORTED_MODULE_42__["default"]; });

/* harmony import */ var _useMount__WEBPACK_IMPORTED_MODULE_43__ = __webpack_require__(/*! ./useMount */ "./node_modules/react-use/esm/useMount.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMount", function() { return _useMount__WEBPACK_IMPORTED_MODULE_43__["default"]; });

/* harmony import */ var _useMountedState__WEBPACK_IMPORTED_MODULE_44__ = __webpack_require__(/*! ./useMountedState */ "./node_modules/react-use/esm/useMountedState.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMountedState", function() { return _useMountedState__WEBPACK_IMPORTED_MODULE_44__["default"]; });

/* harmony import */ var _useMouse__WEBPACK_IMPORTED_MODULE_45__ = __webpack_require__(/*! ./useMouse */ "./node_modules/react-use/esm/useMouse.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMouse", function() { return _useMouse__WEBPACK_IMPORTED_MODULE_45__["default"]; });

/* harmony import */ var _useMouseHovered__WEBPACK_IMPORTED_MODULE_46__ = __webpack_require__(/*! ./useMouseHovered */ "./node_modules/react-use/esm/useMouseHovered.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useMouseHovered", function() { return _useMouseHovered__WEBPACK_IMPORTED_MODULE_46__["default"]; });

/* harmony import */ var _useNetwork__WEBPACK_IMPORTED_MODULE_47__ = __webpack_require__(/*! ./useNetwork */ "./node_modules/react-use/esm/useNetwork.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useNetwork", function() { return _useNetwork__WEBPACK_IMPORTED_MODULE_47__["default"]; });

/* harmony import */ var _useNumber__WEBPACK_IMPORTED_MODULE_48__ = __webpack_require__(/*! ./useNumber */ "./node_modules/react-use/esm/useNumber.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useNumber", function() { return _useNumber__WEBPACK_IMPORTED_MODULE_48__["default"]; });

/* harmony import */ var _useObservable__WEBPACK_IMPORTED_MODULE_49__ = __webpack_require__(/*! ./useObservable */ "./node_modules/react-use/esm/useObservable.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useObservable", function() { return _useObservable__WEBPACK_IMPORTED_MODULE_49__["default"]; });

/* harmony import */ var _useOrientation__WEBPACK_IMPORTED_MODULE_50__ = __webpack_require__(/*! ./useOrientation */ "./node_modules/react-use/esm/useOrientation.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useOrientation", function() { return _useOrientation__WEBPACK_IMPORTED_MODULE_50__["default"]; });

/* harmony import */ var _usePageLeave__WEBPACK_IMPORTED_MODULE_51__ = __webpack_require__(/*! ./usePageLeave */ "./node_modules/react-use/esm/usePageLeave.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "usePageLeave", function() { return _usePageLeave__WEBPACK_IMPORTED_MODULE_51__["default"]; });

/* harmony import */ var _usePermission__WEBPACK_IMPORTED_MODULE_52__ = __webpack_require__(/*! ./usePermission */ "./node_modules/react-use/esm/usePermission.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "usePermission", function() { return _usePermission__WEBPACK_IMPORTED_MODULE_52__["default"]; });

/* harmony import */ var _usePrevious__WEBPACK_IMPORTED_MODULE_53__ = __webpack_require__(/*! ./usePrevious */ "./node_modules/react-use/esm/usePrevious.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "usePrevious", function() { return _usePrevious__WEBPACK_IMPORTED_MODULE_53__["default"]; });

/* harmony import */ var _usePromise__WEBPACK_IMPORTED_MODULE_54__ = __webpack_require__(/*! ./usePromise */ "./node_modules/react-use/esm/usePromise.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "usePromise", function() { return _usePromise__WEBPACK_IMPORTED_MODULE_54__["default"]; });

/* harmony import */ var _useRaf__WEBPACK_IMPORTED_MODULE_55__ = __webpack_require__(/*! ./useRaf */ "./node_modules/react-use/esm/useRaf.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useRaf", function() { return _useRaf__WEBPACK_IMPORTED_MODULE_55__["default"]; });

/* harmony import */ var _useRafLoop__WEBPACK_IMPORTED_MODULE_56__ = __webpack_require__(/*! ./useRafLoop */ "./node_modules/react-use/esm/useRafLoop.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useRafLoop", function() { return _useRafLoop__WEBPACK_IMPORTED_MODULE_56__["default"]; });

/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_57__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useRefMounted", function() { return _useRefMounted__WEBPACK_IMPORTED_MODULE_57__["default"]; });

/* harmony import */ var _useScroll__WEBPACK_IMPORTED_MODULE_58__ = __webpack_require__(/*! ./useScroll */ "./node_modules/react-use/esm/useScroll.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useScroll", function() { return _useScroll__WEBPACK_IMPORTED_MODULE_58__["default"]; });

/* harmony import */ var _useScrolling__WEBPACK_IMPORTED_MODULE_59__ = __webpack_require__(/*! ./useScrolling */ "./node_modules/react-use/esm/useScrolling.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useScrolling", function() { return _useScrolling__WEBPACK_IMPORTED_MODULE_59__["default"]; });

/* harmony import */ var _useSessionStorage__WEBPACK_IMPORTED_MODULE_60__ = __webpack_require__(/*! ./useSessionStorage */ "./node_modules/react-use/esm/useSessionStorage.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useSessionStorage", function() { return _useSessionStorage__WEBPACK_IMPORTED_MODULE_60__["default"]; });

/* harmony import */ var _useSetState__WEBPACK_IMPORTED_MODULE_61__ = __webpack_require__(/*! ./useSetState */ "./node_modules/react-use/esm/useSetState.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useSetState", function() { return _useSetState__WEBPACK_IMPORTED_MODULE_61__["default"]; });

/* harmony import */ var _useSize__WEBPACK_IMPORTED_MODULE_62__ = __webpack_require__(/*! ./useSize */ "./node_modules/react-use/esm/useSize.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useSize", function() { return _useSize__WEBPACK_IMPORTED_MODULE_62__["default"]; });

/* harmony import */ var _useSpeech__WEBPACK_IMPORTED_MODULE_63__ = __webpack_require__(/*! ./useSpeech */ "./node_modules/react-use/esm/useSpeech.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useSpeech", function() { return _useSpeech__WEBPACK_IMPORTED_MODULE_63__["default"]; });

/* harmony import */ var _useStartTyping__WEBPACK_IMPORTED_MODULE_64__ = __webpack_require__(/*! ./useStartTyping */ "./node_modules/react-use/esm/useStartTyping.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useStartTyping", function() { return _useStartTyping__WEBPACK_IMPORTED_MODULE_64__["default"]; });

/* harmony import */ var _useThrottle__WEBPACK_IMPORTED_MODULE_65__ = __webpack_require__(/*! ./useThrottle */ "./node_modules/react-use/esm/useThrottle.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useThrottle", function() { return _useThrottle__WEBPACK_IMPORTED_MODULE_65__["default"]; });

/* harmony import */ var _useThrottleFn__WEBPACK_IMPORTED_MODULE_66__ = __webpack_require__(/*! ./useThrottleFn */ "./node_modules/react-use/esm/useThrottleFn.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useThrottleFn", function() { return _useThrottleFn__WEBPACK_IMPORTED_MODULE_66__["default"]; });

/* harmony import */ var _useTimeout__WEBPACK_IMPORTED_MODULE_67__ = __webpack_require__(/*! ./useTimeout */ "./node_modules/react-use/esm/useTimeout.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useTimeout", function() { return _useTimeout__WEBPACK_IMPORTED_MODULE_67__["default"]; });

/* harmony import */ var _useTitle__WEBPACK_IMPORTED_MODULE_68__ = __webpack_require__(/*! ./useTitle */ "./node_modules/react-use/esm/useTitle.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useTitle", function() { return _useTitle__WEBPACK_IMPORTED_MODULE_68__["default"]; });

/* harmony import */ var _useToggle__WEBPACK_IMPORTED_MODULE_69__ = __webpack_require__(/*! ./useToggle */ "./node_modules/react-use/esm/useToggle.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useToggle", function() { return _useToggle__WEBPACK_IMPORTED_MODULE_69__["default"]; });

/* harmony import */ var _useTween__WEBPACK_IMPORTED_MODULE_70__ = __webpack_require__(/*! ./useTween */ "./node_modules/react-use/esm/useTween.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useTween", function() { return _useTween__WEBPACK_IMPORTED_MODULE_70__["default"]; });

/* harmony import */ var _useUnmount__WEBPACK_IMPORTED_MODULE_71__ = __webpack_require__(/*! ./useUnmount */ "./node_modules/react-use/esm/useUnmount.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useUnmount", function() { return _useUnmount__WEBPACK_IMPORTED_MODULE_71__["default"]; });

/* harmony import */ var _useUpdate__WEBPACK_IMPORTED_MODULE_72__ = __webpack_require__(/*! ./useUpdate */ "./node_modules/react-use/esm/useUpdate.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useUpdate", function() { return _useUpdate__WEBPACK_IMPORTED_MODULE_72__["default"]; });

/* harmony import */ var _useUpdateEffect__WEBPACK_IMPORTED_MODULE_73__ = __webpack_require__(/*! ./useUpdateEffect */ "./node_modules/react-use/esm/useUpdateEffect.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useUpdateEffect", function() { return _useUpdateEffect__WEBPACK_IMPORTED_MODULE_73__["default"]; });

/* harmony import */ var _useVideo__WEBPACK_IMPORTED_MODULE_74__ = __webpack_require__(/*! ./useVideo */ "./node_modules/react-use/esm/useVideo.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useVideo", function() { return _useVideo__WEBPACK_IMPORTED_MODULE_74__["default"]; });

/* harmony import */ var _useWait__WEBPACK_IMPORTED_MODULE_75__ = __webpack_require__(/*! ./useWait */ "./node_modules/react-use/esm/useWait.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useWait", function() { return _useWait__WEBPACK_IMPORTED_MODULE_75__["useWait"]; });

/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "Waiter", function() { return _useWait__WEBPACK_IMPORTED_MODULE_75__["Waiter"]; });

/* harmony import */ var _useWindowScroll__WEBPACK_IMPORTED_MODULE_76__ = __webpack_require__(/*! ./useWindowScroll */ "./node_modules/react-use/esm/useWindowScroll.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useWindowScroll", function() { return _useWindowScroll__WEBPACK_IMPORTED_MODULE_76__["default"]; });

/* harmony import */ var _useWindowSize__WEBPACK_IMPORTED_MODULE_77__ = __webpack_require__(/*! ./useWindowSize */ "./node_modules/react-use/esm/useWindowSize.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useWindowSize", function() { return _useWindowSize__WEBPACK_IMPORTED_MODULE_77__["default"]; });
































// not exported because of peer dependency
// export { default as useKeyboardJs } from './useKeyboardJs';

































// not exported because of peer dependency
// export { default as useSpring } from './useSpring';
















/***/ }),

/***/ "./node_modules/react-use/esm/useAsync.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useAsync.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return useAsync; });
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useAsyncFn__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useAsyncFn */ "./node_modules/react-use/esm/useAsyncFn.js");


function useAsync(fn, deps) {
    if (deps === void 0) { deps = []; }
    var _a = Object(_useAsyncFn__WEBPACK_IMPORTED_MODULE_1__["default"])(fn, deps, {
        loading: true,
    }), state = _a[0], callback = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        callback();
    }, [callback]);
    return state;
}


/***/ }),

/***/ "./node_modules/react-use/esm/useAsyncFn.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useAsyncFn.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return useAsyncFn; });
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");


function useAsyncFn(fn, deps, initialState) {
    if (deps === void 0) { deps = []; }
    if (initialState === void 0) { initialState = { loading: false }; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], set = _a[1];
    var mounted = Object(_useRefMounted__WEBPACK_IMPORTED_MODULE_1__["default"])();
    var callback = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function () {
        var args = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            args[_i] = arguments[_i];
        }
        set({ loading: true });
        return fn.apply(void 0, args).then(function (value) {
            if (mounted.current) {
                set({ value: value, loading: false });
            }
            return value;
        }, function (error) {
            if (mounted.current) {
                set({ error: error, loading: false });
            }
            return error;
        });
    }, deps);
    return [state, callback];
}


/***/ }),

/***/ "./node_modules/react-use/esm/useAsyncRetry.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useAsyncRetry.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useAsync__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useAsync */ "./node_modules/react-use/esm/useAsync.js");
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};


var useAsyncRetry = function (fn, deps) {
    if (deps === void 0) { deps = []; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(0), attempt = _a[0], setAttempt = _a[1];
    var state = Object(_useAsync__WEBPACK_IMPORTED_MODULE_1__["default"])(fn, deps.concat([attempt]));
    var stateLoading = state.loading;
    var retry = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function () {
        if (stateLoading) {
            if (true) {
                console.log('You are calling useAsyncRetry hook retry() method while loading in progress, this is a no-op.');
            }
            return;
        }
        setAttempt(function (currentAttempt) { return currentAttempt + 1; });
    }, deps.concat([stateLoading, attempt]));
    return __assign({}, state, { retry: retry });
};
/* harmony default export */ __webpack_exports__["default"] = (useAsyncRetry);


/***/ }),

/***/ "./node_modules/react-use/esm/useAudio.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useAudio.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _util_createHTMLMediaHook__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./util/createHTMLMediaHook */ "./node_modules/react-use/esm/util/createHTMLMediaHook.js");

var useAudio = Object(_util_createHTMLMediaHook__WEBPACK_IMPORTED_MODULE_0__["default"])('audio');
/* harmony default export */ __webpack_exports__["default"] = (useAudio);


/***/ }),

/***/ "./node_modules/react-use/esm/useBattery.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useBattery.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useBattery = function () {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({}), state = _a[0], setState = _a[1];
    var mounted = true;
    var battery = null;
    var onChange = function () {
        var charging = battery.charging, level = battery.level, chargingTime = battery.chargingTime, dischargingTime = battery.dischargingTime;
        setState({
            charging: charging,
            level: level,
            chargingTime: chargingTime,
            dischargingTime: dischargingTime,
        });
    };
    var onBattery = function () {
        onChange();
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(battery, 'chargingchange', onChange);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(battery, 'levelchange', onChange);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(battery, 'chargingtimechange', onChange);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(battery, 'dischargingtimechange', onChange);
    };
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        navigator.getBattery().then(function (bat) {
            if (mounted) {
                battery = bat;
                onBattery();
            }
        });
        return function () {
            mounted = false;
            if (battery) {
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(battery, 'chargingchange', onChange);
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(battery, 'levelchange', onChange);
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(battery, 'chargingtimechange', onChange);
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(battery, 'dischargingtimechange', onChange);
            }
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useBattery);


/***/ }),

/***/ "./node_modules/react-use/esm/useBeforeUnload.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useBeforeUnload.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useBeforeUnload = function (enabled, message) {
    if (enabled === void 0) { enabled = true; }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (!enabled) {
            return;
        }
        var handler = function (event) {
            event.preventDefault();
            if (message) {
                event.returnValue = message;
            }
            return message;
        };
        window.addEventListener('beforeunload', handler);
        return function () { return window.removeEventListener('beforeunload', handler); };
    }, [message, enabled]);
};
/* harmony default export */ __webpack_exports__["default"] = (useBeforeUnload);


/***/ }),

/***/ "./node_modules/react-use/esm/useBoolean.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useBoolean.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useToggle__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useToggle */ "./node_modules/react-use/esm/useToggle.js");

/* harmony default export */ __webpack_exports__["default"] = (_useToggle__WEBPACK_IMPORTED_MODULE_0__["default"]);


/***/ }),

/***/ "./node_modules/react-use/esm/useClickAway.js":
/*!****************************************************!*\
  !*** ./node_modules/react-use/esm/useClickAway.js ***!
  \****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var defaultEvents = ['mousedown', 'touchstart'];
var useClickAway = function (ref, onClickAway, events) {
    if (events === void 0) { events = defaultEvents; }
    var savedCallback = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(onClickAway);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        savedCallback.current = onClickAway;
    }, [onClickAway]);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var handler = function (event) {
            var el = ref.current;
            el && !el.contains(event.target) && savedCallback.current(event);
        };
        for (var _i = 0, events_1 = events; _i < events_1.length; _i++) {
            var eventName = events_1[_i];
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(document, eventName, handler);
        }
        return function () {
            for (var _i = 0, events_2 = events; _i < events_2.length; _i++) {
                var eventName = events_2[_i];
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(document, eventName, handler);
            }
        };
    }, [events, ref]);
};
/* harmony default export */ __webpack_exports__["default"] = (useClickAway);


/***/ }),

/***/ "./node_modules/react-use/esm/useCopyToClipboard.js":
/*!**********************************************************!*\
  !*** ./node_modules/react-use/esm/useCopyToClipboard.js ***!
  \**********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var copy_to_clipboard__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! copy-to-clipboard */ "./node_modules/copy-to-clipboard/index.js");
/* harmony import */ var copy_to_clipboard__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(copy_to_clipboard__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");
/* harmony import */ var _useSetState__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./useSetState */ "./node_modules/react-use/esm/useSetState.js");




var useCopyToClipboard = function () {
    var mounted = Object(_useRefMounted__WEBPACK_IMPORTED_MODULE_2__["default"])();
    var _a = Object(_useSetState__WEBPACK_IMPORTED_MODULE_3__["default"])({
        value: undefined,
        error: undefined,
        noUserInteraction: true,
    }), state = _a[0], setState = _a[1];
    var copyToClipboard = Object(react__WEBPACK_IMPORTED_MODULE_1__["useCallback"])(function (value) {
        try {
            if (true) {
                if (typeof value !== 'string') {
                    console.error("Cannot copy typeof " + typeof value + " to clipboard, must be a string");
                }
            }
            var noUserInteraction = copy_to_clipboard__WEBPACK_IMPORTED_MODULE_0__(value);
            if (!mounted.current) {
                return;
            }
            setState({
                value: value,
                error: undefined,
                noUserInteraction: noUserInteraction,
            });
        }
        catch (error) {
            if (!mounted.current) {
                return;
            }
            setState({
                value: undefined,
                error: error,
                noUserInteraction: true,
            });
        }
    }, []);
    return [state, copyToClipboard];
};
/* harmony default export */ __webpack_exports__["default"] = (useCopyToClipboard);


/***/ }),

/***/ "./node_modules/react-use/esm/useCounter.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useCounter.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useGetSet__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useGetSet */ "./node_modules/react-use/esm/useGetSet.js");


var useCounter = function (initialValue) {
    if (initialValue === void 0) { initialValue = 0; }
    var _a = Object(_useGetSet__WEBPACK_IMPORTED_MODULE_1__["default"])(initialValue), get = _a[0], set = _a[1];
    var inc = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (delta) {
        if (delta === void 0) { delta = 1; }
        return set(get() + delta);
    }, []);
    var dec = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (delta) {
        if (delta === void 0) { delta = 1; }
        return inc(-delta);
    }, []);
    var reset = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (value) {
        if (value === void 0) { value = initialValue; }
        initialValue = value;
        set(value);
    }, []);
    var actions = {
        inc: inc,
        dec: dec,
        get: get,
        set: set,
        reset: reset,
    };
    return [get(), actions];
};
/* harmony default export */ __webpack_exports__["default"] = (useCounter);


/***/ }),

/***/ "./node_modules/react-use/esm/useCss.js":
/*!**********************************************!*\
  !*** ./node_modules/react-use/esm/useCss.js ***!
  \**********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var nano_css__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! nano-css */ "./node_modules/nano-css/index.js");
/* harmony import */ var nano_css__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(nano_css__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var nano_css_addon_cssom__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! nano-css/addon/cssom */ "./node_modules/nano-css/addon/cssom.js");
/* harmony import */ var nano_css_addon_cssom__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(nano_css_addon_cssom__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var nano_css_addon_vcssom__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! nano-css/addon/vcssom */ "./node_modules/nano-css/addon/vcssom.js");
/* harmony import */ var nano_css_addon_vcssom__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(nano_css_addon_vcssom__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var nano_css_addon_vcssom_cssToTree__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! nano-css/addon/vcssom/cssToTree */ "./node_modules/nano-css/addon/vcssom/cssToTree.js");
/* harmony import */ var nano_css_addon_vcssom_cssToTree__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(nano_css_addon_vcssom_cssToTree__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_4__);





var nano = Object(nano_css__WEBPACK_IMPORTED_MODULE_0__["create"])();
Object(nano_css_addon_cssom__WEBPACK_IMPORTED_MODULE_1__["addon"])(nano);
Object(nano_css_addon_vcssom__WEBPACK_IMPORTED_MODULE_2__["addon"])(nano);
var counter = 0;
var useCss = function (css) {
    var className = Object(react__WEBPACK_IMPORTED_MODULE_4__["useMemo"])(function () { return 'react-use-css-' + (counter++).toString(36); }, []);
    var sheet = Object(react__WEBPACK_IMPORTED_MODULE_4__["useMemo"])(function () { return new nano.VSheet(); }, []);
    Object(react__WEBPACK_IMPORTED_MODULE_4__["useLayoutEffect"])(function () {
        var tree = {};
        Object(nano_css_addon_vcssom_cssToTree__WEBPACK_IMPORTED_MODULE_3__["cssToTree"])(tree, css, '.' + className, '');
        sheet.diff(tree);
        return function () {
            sheet.diff({});
        };
    });
    return className;
};
/* harmony default export */ __webpack_exports__["default"] = (useCss);


/***/ }),

/***/ "./node_modules/react-use/esm/useDebounce.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useDebounce.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useUpdateEffect__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useUpdateEffect */ "./node_modules/react-use/esm/useUpdateEffect.js");

var useDebounce = function (fn, ms, args) {
    if (ms === void 0) { ms = 0; }
    if (args === void 0) { args = []; }
    Object(_useUpdateEffect__WEBPACK_IMPORTED_MODULE_0__["default"])(function () {
        var handle = setTimeout(fn.bind(null, args), ms);
        return function () {
            // if args change then clear timeout
            clearTimeout(handle);
        };
    }, args);
};
/* harmony default export */ __webpack_exports__["default"] = (useDebounce);


/***/ }),

/***/ "./node_modules/react-use/esm/useDeepCompareEffect.js":
/*!************************************************************!*\
  !*** ./node_modules/react-use/esm/useDeepCompareEffect.js ***!
  \************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var react_fast_compare__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react-fast-compare */ "./node_modules/react-fast-compare/index.js");
/* harmony import */ var react_fast_compare__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react_fast_compare__WEBPACK_IMPORTED_MODULE_1__);


var isPrimitive = function (val) { return val !== Object(val); };
var useDeepCompareEffect = function (effect, deps) {
    if (true) {
        if (!deps || !deps.length) {
            console.warn('`useDeepCompareEffect` should not be used with no dependencies. Use React.useEffect instead.');
        }
        if (deps.every(isPrimitive)) {
            console.warn('`useDeepCompareEffect` should not be used with dependencies that are all primitive values. Use React.useEffect instead.');
        }
    }
    var ref = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(undefined);
    if (!react_fast_compare__WEBPACK_IMPORTED_MODULE_1__(deps, ref.current)) {
        ref.current = deps;
    }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(effect, ref.current);
};
/* harmony default export */ __webpack_exports__["default"] = (useDeepCompareEffect);


/***/ }),

/***/ "./node_modules/react-use/esm/useDefault.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useDefault.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useDefault = function (defaultValue, initialValue) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialValue), value = _a[0], setValue = _a[1];
    if (value === undefined || value === null) {
        return [defaultValue, setValue];
    }
    return [value, setValue];
};
/* harmony default export */ __webpack_exports__["default"] = (useDefault);


/***/ }),

/***/ "./node_modules/react-use/esm/useDrop.js":
/*!***********************************************!*\
  !*** ./node_modules/react-use/esm/useDrop.js ***!
  \***********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");


var useState = react__WEBPACK_IMPORTED_MODULE_0__["useState"], useMemo = react__WEBPACK_IMPORTED_MODULE_0__["useMemo"], useCallback = react__WEBPACK_IMPORTED_MODULE_0__["useCallback"], useEffect = react__WEBPACK_IMPORTED_MODULE_0__["useEffect"];
var noop = function () { };
/*
const defaultState: DropAreaState = {
  over: false,
};
*/
var createProcess = function (options, mounted) { return function (dataTransfer, event) {
    var uri = dataTransfer.getData('text/uri-list');
    if (uri) {
        (options.onUri || noop)(uri, event);
        return;
    }
    if (dataTransfer.files && dataTransfer.files.length) {
        (options.onFiles || noop)(Array.from(dataTransfer.files), event);
        return;
    }
    if (dataTransfer.items && dataTransfer.items.length) {
        dataTransfer.items[0].getAsString(function (text) {
            if (mounted.current) {
                (options.onText || noop)(text, event);
            }
        });
    }
}; };
var useDrop = function (options, args) {
    if (options === void 0) { options = {}; }
    if (args === void 0) { args = []; }
    var onFiles = options.onFiles, onText = options.onText, onUri = options.onUri;
    var mounted = Object(_useRefMounted__WEBPACK_IMPORTED_MODULE_1__["default"])();
    var _a = useState(false), over = _a[0], setOverRaw = _a[1];
    var setOver = useCallback(setOverRaw, []);
    var process = useMemo(function () { return createProcess(options, mounted); }, [onFiles, onText, onUri]);
    useEffect(function () {
        var onDragOver = function (event) {
            event.preventDefault();
            setOver(true);
        };
        var onDragEnter = function (event) {
            event.preventDefault();
            setOver(true);
        };
        var onDragLeave = function () {
            setOver(false);
        };
        var onDragExit = function () {
            setOver(false);
        };
        var onDrop = function (event) {
            event.preventDefault();
            setOver(false);
            process(event.dataTransfer, event);
        };
        var onPaste = function (event) {
            process(event.clipboardData, event);
        };
        document.addEventListener('dragover', onDragOver);
        document.addEventListener('dragenter', onDragEnter);
        document.addEventListener('dragleave', onDragLeave);
        document.addEventListener('dragexit', onDragExit);
        document.addEventListener('drop', onDrop);
        if (onText) {
            document.addEventListener('paste', onPaste);
        }
        return function () {
            document.removeEventListener('dragover', onDragOver);
            document.removeEventListener('dragenter', onDragEnter);
            document.removeEventListener('dragleave', onDragLeave);
            document.removeEventListener('dragexit', onDragExit);
            document.removeEventListener('drop', onDrop);
            document.removeEventListener('paste', onPaste);
        };
    }, [process].concat(args));
    return { over: over };
};
/* harmony default export */ __webpack_exports__["default"] = (useDrop);


/***/ }),

/***/ "./node_modules/react-use/esm/useDropArea.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useDropArea.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");


var noop = function () { };
/*
const defaultState: DropAreaState = {
  over: false,
};
*/
var createProcess = function (options, mounted) { return function (dataTransfer, event) {
    var uri = dataTransfer.getData('text/uri-list');
    if (uri) {
        (options.onUri || noop)(uri, event);
        return;
    }
    if (dataTransfer.files && dataTransfer.files.length) {
        (options.onFiles || noop)(Array.from(dataTransfer.files), event);
        return;
    }
    if (dataTransfer.items && dataTransfer.items.length) {
        dataTransfer.items[0].getAsString(function (text) {
            if (mounted.current) {
                (options.onText || noop)(text, event);
            }
        });
    }
}; };
var createBond = function (process, setOver) { return ({
    onDragOver: function (event) {
        event.preventDefault();
    },
    onDragEnter: function (event) {
        event.preventDefault();
        setOver(true);
    },
    onDragLeave: function () {
        setOver(false);
    },
    onDrop: function (event) {
        event.preventDefault();
        event.persist();
        setOver(false);
        process(event.dataTransfer, event);
    },
    onPaste: function (event) {
        event.persist();
        process(event.clipboardData, event);
    },
}); };
var useDropArea = function (options) {
    if (options === void 0) { options = {}; }
    var onFiles = options.onFiles, onText = options.onText, onUri = options.onUri;
    var mounted = Object(_useRefMounted__WEBPACK_IMPORTED_MODULE_1__["default"])();
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(false), over = _a[0], setOver = _a[1];
    var process = Object(react__WEBPACK_IMPORTED_MODULE_0__["useMemo"])(function () { return createProcess(options, mounted); }, [onFiles, onText, onUri]);
    var bond = Object(react__WEBPACK_IMPORTED_MODULE_0__["useMemo"])(function () { return createBond(process, setOver); }, [process, setOver]);
    return [bond, { over: over }];
};
/* harmony default export */ __webpack_exports__["default"] = (useDropArea);


/***/ }),

/***/ "./node_modules/react-use/esm/useEffectOnce.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useEffectOnce.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useEffectOnce = function (effect) {
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(effect, []);
};
/* harmony default export */ __webpack_exports__["default"] = (useEffectOnce);


/***/ }),

/***/ "./node_modules/react-use/esm/useEvent.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useEvent.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var defaultTarget = _util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? window : null;
var useEvent = function (name, handler, target, options) {
    if (target === void 0) { target = defaultTarget; }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (!handler) {
            return;
        }
        if (!target) {
            return;
        }
        var fn = target.addEventListener || target.on;
        fn.call(target, name, handler, options);
        return function () {
            var cleanFn = target.removeEventListener || target.off;
            cleanFn.call(target, name, handler, options);
        };
    }, [name, handler, target, JSON.stringify(options)]);
};
/* harmony default export */ __webpack_exports__["default"] = (useEvent);


/***/ }),

/***/ "./node_modules/react-use/esm/useFavicon.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useFavicon.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useFavicon = function (href) {
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var link = document.querySelector("link[rel*='icon']") || document.createElement('link');
        link.type = 'image/x-icon';
        link.rel = 'shortcut icon';
        link.href = href;
        document.getElementsByTagName('head')[0].appendChild(link);
    }, [href]);
};
/* harmony default export */ __webpack_exports__["default"] = (useFavicon);


/***/ }),

/***/ "./node_modules/react-use/esm/useFullscreen.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useFullscreen.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var screenfull__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! screenfull */ "./node_modules/screenfull/dist/screenfull.js");
/* harmony import */ var screenfull__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(screenfull__WEBPACK_IMPORTED_MODULE_1__);


var noop = function () { };
var useFullscreen = function (ref, on, options) {
    if (options === void 0) { options = {}; }
    var video = options.video, _a = options.onClose, onClose = _a === void 0 ? noop : _a;
    var _b = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(on), isFullscreen = _b[0], setIsFullscreen = _b[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useLayoutEffect"])(function () {
        if (!on) {
            return;
        }
        if (!ref.current) {
            return;
        }
        var onWebkitEndFullscreen = function () {
            video.current.removeEventListener('webkitendfullscreen', onWebkitEndFullscreen);
            onClose();
        };
        var onChange = function () {
            if (screenfull__WEBPACK_IMPORTED_MODULE_1___default.a) {
                var isScreenfullFullscreen = screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.isFullscreen;
                setIsFullscreen(isScreenfullFullscreen);
                if (!isScreenfullFullscreen) {
                    onClose();
                }
            }
        };
        if (screenfull__WEBPACK_IMPORTED_MODULE_1___default.a && screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.enabled) {
            try {
                screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.request(ref.current);
                setIsFullscreen(true);
            }
            catch (error) {
                onClose(error);
                setIsFullscreen(false);
            }
            screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.on('change', onChange);
        }
        else if (video && video.current && video.current.webkitEnterFullscreen) {
            video.current.webkitEnterFullscreen();
            video.current.addEventListener('webkitendfullscreen', onWebkitEndFullscreen);
            setIsFullscreen(true);
        }
        else {
            onClose();
            setIsFullscreen(false);
        }
        return function () {
            setIsFullscreen(false);
            if (screenfull__WEBPACK_IMPORTED_MODULE_1___default.a && screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.enabled) {
                try {
                    screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.off('change', onChange);
                    screenfull__WEBPACK_IMPORTED_MODULE_1___default.a.exit();
                }
                catch (_a) { }
            }
            else if (video && video.current && video.current.webkitExitFullscreen) {
                video.current.removeEventListener('webkitendfullscreen', onWebkitEndFullscreen);
                video.current.webkitExitFullscreen();
            }
        };
    }, [ref.current, video, on]);
    return isFullscreen;
};
/* harmony default export */ __webpack_exports__["default"] = (useFullscreen);


/***/ }),

/***/ "./node_modules/react-use/esm/useGeolocation.js":
/*!******************************************************!*\
  !*** ./node_modules/react-use/esm/useGeolocation.js ***!
  \******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};

var useGeolocation = function (options) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({
        loading: true,
        accuracy: null,
        altitude: null,
        altitudeAccuracy: null,
        heading: null,
        latitude: null,
        longitude: null,
        speed: null,
        timestamp: Date.now(),
    }), state = _a[0], setState = _a[1];
    var mounted = true;
    var watchId;
    var onEvent = function (event) {
        if (mounted) {
            setState({
                loading: false,
                accuracy: event.coords.accuracy,
                altitude: event.coords.altitude,
                altitudeAccuracy: event.coords.altitudeAccuracy,
                heading: event.coords.heading,
                latitude: event.coords.latitude,
                longitude: event.coords.longitude,
                speed: event.coords.speed,
                timestamp: event.timestamp,
            });
        }
    };
    var onEventError = function (error) {
        return mounted && setState(function (oldState) { return (__assign({}, oldState, { loading: false, error: error })); });
    };
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        navigator.geolocation.getCurrentPosition(onEvent, onEventError, options);
        watchId = navigator.geolocation.watchPosition(onEvent, onEventError, options);
        return function () {
            mounted = false;
            navigator.geolocation.clearWatch(watchId);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useGeolocation);


/***/ }),

/***/ "./node_modules/react-use/esm/useGetSet.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useGetSet.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useUpdate__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUpdate */ "./node_modules/react-use/esm/useUpdate.js");


var useGetSet = function (initialValue) {
    var state = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(initialValue);
    var update = Object(_useUpdate__WEBPACK_IMPORTED_MODULE_1__["default"])();
    var get = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function () { return state.current; }, []);
    var set = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (value) {
        state.current = value;
        update();
    }, []);
    return [get, set];
};
/* harmony default export */ __webpack_exports__["default"] = (useGetSet);


/***/ }),

/***/ "./node_modules/react-use/esm/useGetSetState.js":
/*!******************************************************!*\
  !*** ./node_modules/react-use/esm/useGetSetState.js ***!
  \******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useUpdate__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUpdate */ "./node_modules/react-use/esm/useUpdate.js");
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};


var useGetSetState = function (initialState) {
    if (initialState === void 0) { initialState = {}; }
    if (true) {
        if (typeof initialState !== 'object') {
            console.error('useGetSetState initial state must be an object.');
        }
    }
    var update = Object(_useUpdate__WEBPACK_IMPORTED_MODULE_1__["default"])();
    var state = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(__assign({}, initialState));
    var get = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function () { return state.current; }, []);
    var set = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (patch) {
        if (!patch) {
            return;
        }
        if (true) {
            if (typeof patch !== 'object') {
                console.error('useGetSetState setter patch must be an object.');
            }
        }
        Object.assign(state.current, patch);
        update();
    }, []);
    return [get, set];
};
/* harmony default export */ __webpack_exports__["default"] = (useGetSetState);


/***/ }),

/***/ "./node_modules/react-use/esm/useHover.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useHover.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useState = react__WEBPACK_IMPORTED_MODULE_0__["useState"];
var noop = function () { };
var useHover = function (element) {
    var _a = useState(false), state = _a[0], setState = _a[1];
    var onMouseEnter = function (originalOnMouseEnter) { return function (event) {
        (originalOnMouseEnter || noop)(event);
        setState(true);
    }; };
    var onMouseLeave = function (originalOnMouseLeave) { return function (event) {
        (originalOnMouseLeave || noop)(event);
        setState(false);
    }; };
    if (typeof element === 'function') {
        element = element(state);
    }
    var el = react__WEBPACK_IMPORTED_MODULE_0__["cloneElement"](element, {
        onMouseEnter: onMouseEnter(element.props.onMouseEnter),
        onMouseLeave: onMouseLeave(element.props.onMouseLeave),
    });
    return [el, state];
};
/* harmony default export */ __webpack_exports__["default"] = (useHover);


/***/ }),

/***/ "./node_modules/react-use/esm/useHoverDirty.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useHoverDirty.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

// kudos: https://usehooks.com/
var useHoverDirty = function (ref, enabled) {
    if (enabled === void 0) { enabled = true; }
    if (true) {
        if (typeof ref !== 'object' || typeof ref.current === 'undefined') {
            console.error('useHoverDirty expects a single ref argument.');
        }
    }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(false), value = _a[0], setValue = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var onMouseOver = function () { return setValue(true); };
        var onMouseOut = function () { return setValue(false); };
        if (enabled && ref && ref.current) {
            ref.current.addEventListener('mouseover', onMouseOver);
            ref.current.addEventListener('mouseout', onMouseOut);
        }
        return function () {
            if (enabled && ref && ref.current) {
                ref.current.removeEventListener('mouseover', onMouseOver);
                ref.current.removeEventListener('mouseout', onMouseOut);
            }
        };
    }, [enabled, ref]);
    return value;
};
/* harmony default export */ __webpack_exports__["default"] = (useHoverDirty);


/***/ }),

/***/ "./node_modules/react-use/esm/useIdle.js":
/*!***********************************************!*\
  !*** ./node_modules/react-use/esm/useIdle.js ***!
  \***********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var throttle_debounce__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! throttle-debounce */ "./node_modules/throttle-debounce/dist/index.esm.js");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");



var defaultEvents = ['mousemove', 'mousedown', 'resize', 'keydown', 'touchstart', 'wheel'];
var oneMinute = 60e3;
var useIdle = function (ms, initialState, events) {
    if (ms === void 0) { ms = oneMinute; }
    if (initialState === void 0) { initialState = false; }
    if (events === void 0) { events = defaultEvents; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var mounted = true;
        var timeout;
        var localState = state;
        var set = function (newState) {
            if (mounted) {
                localState = newState;
                setState(newState);
            }
        };
        var onEvent = Object(throttle_debounce__WEBPACK_IMPORTED_MODULE_1__["throttle"])(50, function () {
            if (localState) {
                set(false);
            }
            clearTimeout(timeout);
            timeout = setTimeout(function () { return set(true); }, ms);
        });
        var onVisibility = function () {
            if (!document.hidden) {
                onEvent();
            }
        };
        for (var i = 0; i < events.length; i++) {
            Object(_util__WEBPACK_IMPORTED_MODULE_2__["on"])(window, events[i], onEvent);
        }
        Object(_util__WEBPACK_IMPORTED_MODULE_2__["on"])(document, 'visibilitychange', onVisibility);
        timeout = setTimeout(function () { return set(true); }, ms);
        return function () {
            mounted = false;
            for (var i = 0; i < events.length; i++) {
                Object(_util__WEBPACK_IMPORTED_MODULE_2__["off"])(window, events[i], onEvent);
            }
            Object(_util__WEBPACK_IMPORTED_MODULE_2__["off"])(document, 'visibilitychange', onVisibility);
        };
    }, [ms, events]);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useIdle);


/***/ }),

/***/ "./node_modules/react-use/esm/useInterval.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useInterval.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useInterval = function (callback, delay) {
    var latestCallback = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(function () { });
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        latestCallback.current = callback;
    });
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (delay !== null) {
            var interval_1 = setInterval(function () { return latestCallback.current(); }, delay || 0);
            return function () { return clearInterval(interval_1); };
        }
        return undefined;
    }, [delay]);
};
/* harmony default export */ __webpack_exports__["default"] = (useInterval);


/***/ }),

/***/ "./node_modules/react-use/esm/useIsomorphicLayoutEffect.js":
/*!*****************************************************************!*\
  !*** ./node_modules/react-use/esm/useIsomorphicLayoutEffect.js ***!
  \*****************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useIsomorphicLayoutEffect =  true ? react__WEBPACK_IMPORTED_MODULE_0__["useLayoutEffect"] : undefined;
/* harmony default export */ __webpack_exports__["default"] = (useIsomorphicLayoutEffect);


/***/ }),

/***/ "./node_modules/react-use/esm/useKey.js":
/*!**********************************************!*\
  !*** ./node_modules/react-use/esm/useKey.js ***!
  \**********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useEvent__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useEvent */ "./node_modules/react-use/esm/useEvent.js");


var noop = function () { };
var createKeyPredicate = function (keyFilter) {
    return typeof keyFilter === 'function'
        ? keyFilter
        : typeof keyFilter === 'string'
            ? function (event) { return event.key === keyFilter; }
            : keyFilter
                ? function () { return true; }
                : function () { return false; };
};
var useKey = function (key, fn, opts, deps) {
    if (fn === void 0) { fn = noop; }
    if (opts === void 0) { opts = {}; }
    if (deps === void 0) { deps = [key]; }
    var _a = opts.event, event = _a === void 0 ? 'keydown' : _a, target = opts.target, options = opts.options;
    var useMemoHandler = Object(react__WEBPACK_IMPORTED_MODULE_0__["useMemo"])(function () {
        var predicate = createKeyPredicate(key);
        var handler = function (handlerEvent) {
            if (predicate(handlerEvent)) {
                return fn(handlerEvent);
            }
        };
        return handler;
    }, deps);
    Object(_useEvent__WEBPACK_IMPORTED_MODULE_1__["default"])(event, useMemoHandler, target, options);
};
/* harmony default export */ __webpack_exports__["default"] = (useKey);


/***/ }),

/***/ "./node_modules/react-use/esm/useKeyPress.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useKeyPress.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useKey__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useKey */ "./node_modules/react-use/esm/useKey.js");


var useKeyPress = function (keyFilter) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])([false, null]), state = _a[0], set = _a[1];
    Object(_useKey__WEBPACK_IMPORTED_MODULE_1__["default"])(keyFilter, function (event) { return set([true, event]); }, { event: 'keydown' }, [state]);
    Object(_useKey__WEBPACK_IMPORTED_MODULE_1__["default"])(keyFilter, function (event) { return set([false, event]); }, { event: 'keyup' }, [state]);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useKeyPress);


/***/ }),

/***/ "./node_modules/react-use/esm/useKeyPressEvent.js":
/*!********************************************************!*\
  !*** ./node_modules/react-use/esm/useKeyPressEvent.js ***!
  \********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useKeyPress__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useKeyPress */ "./node_modules/react-use/esm/useKeyPress.js");
/* harmony import */ var _useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUpdateEffect */ "./node_modules/react-use/esm/useUpdateEffect.js");


var useKeyPressEvent = function (key, keydown, keyup, useKeyPress) {
    if (useKeyPress === void 0) { useKeyPress = _useKeyPress__WEBPACK_IMPORTED_MODULE_0__["default"]; }
    var _a = useKeyPress(key), pressed = _a[0], event = _a[1];
    Object(_useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        if (!pressed && keyup) {
            keyup(event);
        }
        else if (pressed && keydown) {
            keydown(event);
        }
    }, [pressed]);
};
/* harmony default export */ __webpack_exports__["default"] = (useKeyPressEvent);


/***/ }),

/***/ "./node_modules/react-use/esm/useLifecycles.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useLifecycles.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useLifecycles = function (mount, unmount) {
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (mount) {
            mount();
        }
        return function () {
            if (unmount) {
                unmount();
            }
        };
    }, []);
};
/* harmony default export */ __webpack_exports__["default"] = (useLifecycles);


/***/ }),

/***/ "./node_modules/react-use/esm/useList.js":
/*!***********************************************!*\
  !*** ./node_modules/react-use/esm/useList.js ***!
  \***********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useList = function (initialList) {
    if (initialList === void 0) { initialList = []; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialList), list = _a[0], set = _a[1];
    return [
        list,
        {
            set: set,
            clear: function () { return set([]); },
            updateAt: function (index, entry) {
                return set(function (currentList) { return currentList.slice(0, index).concat([entry], currentList.slice(index + 1)); });
            },
            remove: function (index) { return set(function (currentList) { return currentList.slice(0, index).concat(currentList.slice(index + 1)); }); },
            push: function (entry) { return set(function (currentList) { return currentList.concat([entry]); }); },
            filter: function (fn) { return set(function (currentList) { return currentList.filter(fn); }); },
            sort: function (fn) { return set(function (currentList) { return currentList.slice().sort(fn); }); },
        },
    ];
};
/* harmony default export */ __webpack_exports__["default"] = (useList);


/***/ }),

/***/ "./node_modules/react-use/esm/useLocalStorage.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useLocalStorage.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useLocalStorage = function (key, initialValue, raw) {
    if (!_util__WEBPACK_IMPORTED_MODULE_1__["isClient"]) {
        return [initialValue, function () { }];
    }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(function () {
        try {
            var localStorageValue = localStorage.getItem(key);
            if (typeof localStorageValue !== 'string') {
                localStorage.setItem(key, raw ? String(initialValue) : JSON.stringify(initialValue));
                return initialValue;
            }
            else {
                return raw ? localStorageValue : JSON.parse(localStorageValue || 'null');
            }
        }
        catch (_a) {
            // If user is in private mode or has storage restriction
            // localStorage can throw. JSON.parse and JSON.stringify
            // can throw, too.
            return initialValue;
        }
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        try {
            var serializedState = raw ? String(state) : JSON.stringify(state);
            localStorage.setItem(key, serializedState);
        }
        catch (_a) {
            // If user is in private mode or has storage restriction
            // localStorage can throw. Also JSON.stringify can throw.
        }
    }, [state]);
    return [state, setState];
};
/* harmony default export */ __webpack_exports__["default"] = (useLocalStorage);


/***/ }),

/***/ "./node_modules/react-use/esm/useLocation.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useLocation.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var patchHistoryMethod = function (method) {
    var original = history[method];
    history[method] = function (state) {
        var result = original.apply(this, arguments);
        var event = new Event(method.toLowerCase());
        event.state = state;
        window.dispatchEvent(event);
        return result;
    };
};
if (_util__WEBPACK_IMPORTED_MODULE_1__["isClient"]) {
    patchHistoryMethod('pushState');
    patchHistoryMethod('replaceState');
}
var useLocationServer = function () { return ({
    trigger: 'load',
    length: 1,
}); };
var buildState = function (trigger) {
    var state = history.state, length = history.length;
    var hash = location.hash, host = location.host, hostname = location.hostname, href = location.href, origin = location.origin, pathname = location.pathname, port = location.port, protocol = location.protocol, search = location.search;
    return {
        trigger: trigger,
        state: state,
        length: length,
        hash: hash,
        host: host,
        hostname: hostname,
        href: href,
        origin: origin,
        pathname: pathname,
        port: port,
        protocol: protocol,
        search: search,
    };
};
var useLocationBrowser = function () {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(buildState('load')), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var onPopstate = function () { return setState(buildState('popstate')); };
        var onPushstate = function () { return setState(buildState('pushstate')); };
        var onReplacestate = function () { return setState(buildState('replacestate')); };
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'popstate', onPopstate);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'pushstate', onPushstate);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'replacestate', onReplacestate);
        return function () {
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'popstate', onPopstate);
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'pushstate', onPushstate);
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'replacestate', onReplacestate);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (_util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? useLocationBrowser : useLocationServer);


/***/ }),

/***/ "./node_modules/react-use/esm/useLockBodyScroll.js":
/*!*********************************************************!*\
  !*** ./node_modules/react-use/esm/useLockBodyScroll.js ***!
  \*********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var counter = 0;
var originalOverflow = null;
var lock = function () {
    originalOverflow = window.getComputedStyle(document.body).overflow;
    document.body.style.overflow = 'hidden';
};
var unlock = function () {
    document.body.style.overflow = originalOverflow;
    originalOverflow = null;
};
var increment = function () {
    counter++;
    if (counter === 1) {
        lock();
    }
};
var decrement = function () {
    counter--;
    if (counter === 0) {
        unlock();
    }
};
var useLockBodyScroll = function (enabled) {
    if (enabled === void 0) { enabled = true; }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () { return (enabled ? (increment(), decrement) : undefined); }, [enabled]);
};
/* harmony default export */ __webpack_exports__["default"] = (useLockBodyScroll);


/***/ }),

/***/ "./node_modules/react-use/esm/useLogger.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useLogger.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useEffectOnce__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useEffectOnce */ "./node_modules/react-use/esm/useEffectOnce.js");
/* harmony import */ var _useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUpdateEffect */ "./node_modules/react-use/esm/useUpdateEffect.js");


var useLogger = function (componentName) {
    var rest = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        rest[_i - 1] = arguments[_i];
    }
    Object(_useEffectOnce__WEBPACK_IMPORTED_MODULE_0__["default"])(function () {
        console.log.apply(console, [componentName + " mounted"].concat(rest));
        return function () { return console.log(componentName + " unmounted"); };
    });
    Object(_useUpdateEffect__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        console.log.apply(console, [componentName + " updated"].concat(rest));
    });
};
/* harmony default export */ __webpack_exports__["default"] = (useLogger);


/***/ }),

/***/ "./node_modules/react-use/esm/useMap.js":
/*!**********************************************!*\
  !*** ./node_modules/react-use/esm/useMap.js ***!
  \**********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var __rest = (undefined && undefined.__rest) || function (s, e) {
    var t = {};
    for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
        t[p] = s[p];
    if (s != null && typeof Object.getOwnPropertySymbols === "function")
        for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
            if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                t[p[i]] = s[p[i]];
        }
    return t;
};

var useMap = function (initialMap) {
    if (initialMap === void 0) { initialMap = {}; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialMap), map = _a[0], set = _a[1];
    return [
        map,
        {
            get: function (key) { return map[key]; },
            set: function (key, entry) {
                set(function (prevMap) {
                    var _a;
                    return (__assign({}, prevMap, (_a = {}, _a[key] = entry, _a)));
                });
            },
            remove: function (key) {
                set(function (prevMap) {
                    var _a = key, omit = prevMap[_a], rest = __rest(prevMap, [typeof _a === "symbol" ? _a : _a + ""]);
                    return rest;
                });
            },
            reset: function () { return set(initialMap); },
        },
    ];
};
/* harmony default export */ __webpack_exports__["default"] = (useMap);


/***/ }),

/***/ "./node_modules/react-use/esm/useMedia.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useMedia.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useMedia = function (query, defaultState) {
    if (defaultState === void 0) { defaultState = false; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(_util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? function () { return window.matchMedia(query).matches; } : defaultState), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var mounted = true;
        var mql = window.matchMedia(query);
        var onChange = function () {
            if (!mounted) {
                return;
            }
            setState(!!mql.matches);
        };
        mql.addListener(onChange);
        setState(mql.matches);
        return function () {
            mounted = false;
            mql.removeListener(onChange);
        };
    }, [query]);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useMedia);


/***/ }),

/***/ "./node_modules/react-use/esm/useMediaDevices.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useMediaDevices.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var noop = function () { };
var useMediaDevices = function () {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({}), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var mounted = true;
        var onChange = function () {
            navigator.mediaDevices
                .enumerateDevices()
                .then(function (devices) {
                if (mounted) {
                    setState({
                        devices: devices.map(function (_a) {
                            var deviceId = _a.deviceId, groupId = _a.groupId, kind = _a.kind, label = _a.label;
                            return ({ deviceId: deviceId, groupId: groupId, kind: kind, label: label });
                        }),
                    });
                }
            })
                .catch(noop);
        };
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(navigator.mediaDevices, 'devicechange', onChange);
        onChange();
        return function () {
            mounted = false;
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(navigator.mediaDevices, 'devicechange', onChange);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useMediaDevices);


/***/ }),

/***/ "./node_modules/react-use/esm/useMotion.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useMotion.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var defaultState = {
    acceleration: {
        x: null,
        y: null,
        z: null,
    },
    accelerationIncludingGravity: {
        x: null,
        y: null,
        z: null,
    },
    rotationRate: {
        alpha: null,
        beta: null,
        gamma: null,
    },
    interval: 16,
};
var useMotion = function (initialState) {
    if (initialState === void 0) { initialState = defaultState; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var handler = function (event) {
            var acceleration = event.acceleration, accelerationIncludingGravity = event.accelerationIncludingGravity, rotationRate = event.rotationRate, interval = event.interval;
            setState({
                acceleration: {
                    x: acceleration.x,
                    y: acceleration.y,
                    z: acceleration.z,
                },
                accelerationIncludingGravity: {
                    x: accelerationIncludingGravity.x,
                    y: accelerationIncludingGravity.y,
                    z: accelerationIncludingGravity.z,
                },
                rotationRate: {
                    alpha: rotationRate.alpha,
                    beta: rotationRate.beta,
                    gamma: rotationRate.gamma,
                },
                interval: interval,
            });
        };
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'devicemotion', handler);
        return function () {
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'devicemotion', handler);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useMotion);


/***/ }),

/***/ "./node_modules/react-use/esm/useMount.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useMount.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useEffectOnce__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useEffectOnce */ "./node_modules/react-use/esm/useEffectOnce.js");

var useMount = function (fn) {
    Object(_useEffectOnce__WEBPACK_IMPORTED_MODULE_0__["default"])(function () {
        fn();
    });
};
/* harmony default export */ __webpack_exports__["default"] = (useMount);


/***/ }),

/***/ "./node_modules/react-use/esm/useMountedState.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useMountedState.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return useMountedState; });
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

function useMountedState() {
    var mountedRef = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(false);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        mountedRef.current = true;
        return function () {
            mountedRef.current = false;
        };
    });
    return function () { return mountedRef.current; };
}


/***/ }),

/***/ "./node_modules/react-use/esm/useMouse.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useMouse.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useMouse = function (ref) {
    if (true) {
        if (typeof ref !== 'object' || typeof ref.current === 'undefined') {
            console.error('useMouse expects a single ref argument.');
        }
    }
    var frame = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(0);
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({
        docX: 0,
        docY: 0,
        posX: 0,
        posY: 0,
        elX: 0,
        elY: 0,
        elH: 0,
        elW: 0,
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var moveHandler = function (event) {
            cancelAnimationFrame(frame.current);
            frame.current = requestAnimationFrame(function () {
                if (ref && ref.current) {
                    var _a = ref.current.getBoundingClientRect(), left = _a.left, top_1 = _a.top, elW = _a.width, elH = _a.height;
                    var posX = left + window.scrollX;
                    var posY = top_1 + window.scrollY;
                    var elX = event.pageX - posX;
                    var elY = event.pageY - posY;
                    setState({
                        docX: event.pageX,
                        docY: event.pageY,
                        posX: posX,
                        posY: posY,
                        elX: elX,
                        elY: elY,
                        elH: elH,
                        elW: elW,
                    });
                }
            });
        };
        document.addEventListener('mousemove', moveHandler);
        return function () {
            cancelAnimationFrame(frame.current);
            document.removeEventListener('mousemove', moveHandler);
        };
    }, [ref.current]);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useMouse);


/***/ }),

/***/ "./node_modules/react-use/esm/useMouseHovered.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useMouseHovered.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useHoverDirty__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useHoverDirty */ "./node_modules/react-use/esm/useHoverDirty.js");
/* harmony import */ var _useMouse__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useMouse */ "./node_modules/react-use/esm/useMouse.js");


var nullRef = { current: null };
var useMouseHovered = function (ref, options) {
    if (options === void 0) { options = {}; }
    var whenHovered = !!options.whenHovered;
    var bound = !!options.bound;
    var isHovered = Object(_useHoverDirty__WEBPACK_IMPORTED_MODULE_0__["default"])(ref, whenHovered);
    var state = Object(_useMouse__WEBPACK_IMPORTED_MODULE_1__["default"])(whenHovered && !isHovered ? nullRef : ref);
    if (bound) {
        state.elX = Math.max(0, Math.min(state.elX, state.elW));
        state.elY = Math.max(0, Math.min(state.elY, state.elH));
    }
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useMouseHovered);


/***/ }),

/***/ "./node_modules/react-use/esm/useNetwork.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useNetwork.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};


var getConnection = function () {
    if (typeof navigator !== 'object') {
        return null;
    }
    var nav = navigator;
    return nav.connection || nav.mozConnection || nav.webkitConnection;
};
var getConnectionState = function () {
    var connection = getConnection();
    if (!connection) {
        return {};
    }
    var downlink = connection.downlink, downlinkMax = connection.downlinkMax, effectiveType = connection.effectiveType, type = connection.type, rtt = connection.rtt;
    return {
        downlink: downlink,
        downlinkMax: downlinkMax,
        effectiveType: effectiveType,
        type: type,
        rtt: rtt,
    };
};
var useNetwork = function (initialState) {
    if (initialState === void 0) { initialState = {}; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var localState = state;
        var localSetState = function (patch) {
            localState = __assign({}, localState, patch);
            setState(localState);
        };
        var connection = getConnection();
        var onOnline = function () {
            localSetState({
                online: true,
                since: new Date(),
            });
        };
        var onOffline = function () {
            localSetState({
                online: false,
                since: new Date(),
            });
        };
        var onConnectionChange = function () {
            localSetState(getConnectionState());
        };
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'online', onOnline);
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'offline', onOffline);
        if (connection) {
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(connection, 'change', onConnectionChange);
            localSetState(__assign({}, state, { online: navigator.onLine, since: undefined }, getConnectionState()));
        }
        return function () {
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'online', onOnline);
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'offline', onOffline);
            if (connection) {
                Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(connection, 'change', onConnectionChange);
            }
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useNetwork);


/***/ }),

/***/ "./node_modules/react-use/esm/useNumber.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useNumber.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useCounter__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useCounter */ "./node_modules/react-use/esm/useCounter.js");

/* harmony default export */ __webpack_exports__["default"] = (_useCounter__WEBPACK_IMPORTED_MODULE_0__["default"]);


/***/ }),

/***/ "./node_modules/react-use/esm/useObservable.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useObservable.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useIsomorphicLayoutEffect__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useIsomorphicLayoutEffect */ "./node_modules/react-use/esm/useIsomorphicLayoutEffect.js");


function useObservable(observable$, initialValue) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialValue), value = _a[0], update = _a[1];
    Object(_useIsomorphicLayoutEffect__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        var s = observable$.subscribe(update);
        return function () { return s.unsubscribe(); };
    }, [observable$]);
    return value;
}
/* harmony default export */ __webpack_exports__["default"] = (useObservable);


/***/ }),

/***/ "./node_modules/react-use/esm/useOrientation.js":
/*!******************************************************!*\
  !*** ./node_modules/react-use/esm/useOrientation.js ***!
  \******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var defaultState = {
    angle: 0,
    type: 'landscape-primary',
};
var useOrientation = function (initialState) {
    if (initialState === void 0) { initialState = defaultState; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var mounted = true;
        var onChange = function () {
            if (mounted) {
                var orientation_1 = screen.orientation;
                if (orientation_1) {
                    var angle = orientation_1.angle, type = orientation_1.type;
                    setState({ angle: angle, type: type });
                }
                else if (window.orientation) {
                    setState({
                        angle: typeof window.orientation === 'number' ? window.orientation : 0,
                        type: '',
                    });
                }
                else {
                    setState(initialState);
                }
            }
        };
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(window, 'orientationchange', onChange);
        onChange();
        return function () {
            mounted = false;
            Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(window, 'orientationchange', onChange);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useOrientation);


/***/ }),

/***/ "./node_modules/react-use/esm/usePageLeave.js":
/*!****************************************************!*\
  !*** ./node_modules/react-use/esm/usePageLeave.js ***!
  \****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var usePageLeave = function (onPageLeave, args) {
    if (args === void 0) { args = []; }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (!onPageLeave) {
            return;
        }
        var handler = function (event) {
            event = event ? event : window.event;
            var from = event.relatedTarget || event.toElement;
            if (!from || from.nodeName === 'HTML') {
                onPageLeave();
            }
        };
        document.addEventListener('mouseout', handler);
        return function () {
            document.removeEventListener('mouseout', handler);
        };
    }, args);
};
/* harmony default export */ __webpack_exports__["default"] = (usePageLeave);


/***/ }),

/***/ "./node_modules/react-use/esm/usePermission.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/usePermission.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var noop = function () { };
var usePermission = function (permissionDesc) {
    var mounted = true;
    var permissionStatus = null;
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(''), state = _a[0], setState = _a[1];
    var onChange = function () {
        if (mounted && permissionStatus) {
            setState(permissionStatus.state);
        }
    };
    var changeState = function () {
        onChange();
        Object(_util__WEBPACK_IMPORTED_MODULE_1__["on"])(permissionStatus, 'change', onChange);
    };
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        navigator.permissions
            .query(permissionDesc)
            .then(function (status) {
            permissionStatus = status;
            changeState();
        })
            .catch(noop);
        return function () {
            mounted = false;
            permissionStatus && Object(_util__WEBPACK_IMPORTED_MODULE_1__["off"])(permissionStatus, 'change', onChange);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (usePermission);


/***/ }),

/***/ "./node_modules/react-use/esm/usePrevious.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/usePrevious.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var usePrevious = function (state) {
    var ref = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])();
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        ref.current = state;
    });
    return ref.current;
};
/* harmony default export */ __webpack_exports__["default"] = (usePrevious);


/***/ }),

/***/ "./node_modules/react-use/esm/usePromise.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/usePromise.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useRefMounted__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useRefMounted */ "./node_modules/react-use/esm/useRefMounted.js");


var usePromise = function () {
    var refMounted = Object(_useRefMounted__WEBPACK_IMPORTED_MODULE_1__["default"])();
    return Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (promise) {
        return new Promise(function (resolve, reject) {
            var onValue = function (value) {
                if (refMounted.current) {
                    resolve(value);
                }
            };
            var onError = function (error) {
                if (refMounted.current) {
                    reject(error);
                }
            };
            promise.then(onValue, onError);
        });
    }, []);
};
/* harmony default export */ __webpack_exports__["default"] = (usePromise);


/***/ }),

/***/ "./node_modules/react-use/esm/useRaf.js":
/*!**********************************************!*\
  !*** ./node_modules/react-use/esm/useRaf.js ***!
  \**********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useRaf = function (ms, delay) {
    if (ms === void 0) { ms = 1e12; }
    if (delay === void 0) { delay = 0; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(0), elapsed = _a[0], set = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useLayoutEffect"])(function () {
        var raf;
        var timerStop;
        var start;
        var onFrame = function () {
            var time = Math.min(1, (Date.now() - start) / ms);
            set(time);
            loop();
        };
        var loop = function () {
            raf = requestAnimationFrame(onFrame);
        };
        var onStart = function () {
            timerStop = setTimeout(function () {
                cancelAnimationFrame(raf);
                set(1);
            }, ms);
            start = Date.now();
            loop();
        };
        var timerDelay = setTimeout(onStart, delay);
        return function () {
            clearTimeout(timerStop);
            clearTimeout(timerDelay);
            cancelAnimationFrame(raf);
        };
    }, [ms, delay]);
    return elapsed;
};
/* harmony default export */ __webpack_exports__["default"] = (useRaf);


/***/ }),

/***/ "./node_modules/react-use/esm/useRafLoop.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useRafLoop.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return useRafLoop; });
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

function useRafLoop(callback) {
    var raf = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(true), isActive = _a[0], setIsActive = _a[1];
    function loopStep() {
        callback();
        raf.current = requestAnimationFrame(loopStep);
    }
    function loopStop() {
        setIsActive(false);
    }
    function loopStart() {
        setIsActive(true);
    }
    function clearCurrentLoop() {
        raf.current && cancelAnimationFrame(raf.current);
    }
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () { return clearCurrentLoop; }, []);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        clearCurrentLoop();
        isActive && (raf.current = requestAnimationFrame(loopStep));
        return clearCurrentLoop;
    }, [isActive, callback]);
    return [loopStop, isActive, loopStart];
}


/***/ }),

/***/ "./node_modules/react-use/esm/useRefMounted.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useRefMounted.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useRefMounted = function () {
    var refMounted = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(false);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        refMounted.current = true;
        return function () {
            refMounted.current = false;
        };
    }, []);
    return refMounted;
};
/* harmony default export */ __webpack_exports__["default"] = (useRefMounted);


/***/ }),

/***/ "./node_modules/react-use/esm/useScroll.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useScroll.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useScroll = function (ref) {
    if (true) {
        if (typeof ref !== 'object' || typeof ref.current === 'undefined') {
            console.error('`useScroll` expects a single ref argument.');
        }
    }
    var frame = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(0);
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({
        x: 0,
        y: 0,
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var handler = function () {
            cancelAnimationFrame(frame.current);
            frame.current = requestAnimationFrame(function () {
                if (ref.current) {
                    setState({
                        x: ref.current.scrollLeft,
                        y: ref.current.scrollTop,
                    });
                }
            });
        };
        if (ref.current) {
            ref.current.addEventListener('scroll', handler, {
                capture: false,
                passive: true,
            });
        }
        return function () {
            if (frame.current) {
                cancelAnimationFrame(frame.current);
            }
            if (ref.current) {
                ref.current.removeEventListener('scroll', handler);
            }
        };
    }, [ref.current]);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useScroll);


/***/ }),

/***/ "./node_modules/react-use/esm/useScrolling.js":
/*!****************************************************!*\
  !*** ./node_modules/react-use/esm/useScrolling.js ***!
  \****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useScrolling = function (ref) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(false), scrolling = _a[0], setScrolling = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (ref.current) {
            var scrollingTimeout_1;
            var handleScrollEnd_1 = function () {
                setScrolling(false);
            };
            var handleScroll_1 = function () {
                setScrolling(true);
                clearTimeout(scrollingTimeout_1);
                scrollingTimeout_1 = setTimeout(function () { return handleScrollEnd_1(); }, 150);
            };
            ref.current.addEventListener('scroll', handleScroll_1, false);
            return function () {
                if (ref.current) {
                    ref.current.removeEventListener('scroll', handleScroll_1, false);
                }
            };
        }
        return function () { };
    }, [ref.current]);
    return scrolling;
};
/* harmony default export */ __webpack_exports__["default"] = (useScrolling);


/***/ }),

/***/ "./node_modules/react-use/esm/useSessionStorage.js":
/*!*********************************************************!*\
  !*** ./node_modules/react-use/esm/useSessionStorage.js ***!
  \*********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useSessionStorage = function (key, initialValue, raw) {
    if (!_util__WEBPACK_IMPORTED_MODULE_1__["isClient"]) {
        return [initialValue, function () { }];
    }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(function () {
        try {
            var sessionStorageValue = sessionStorage.getItem(key);
            if (typeof sessionStorageValue !== 'string') {
                sessionStorage.setItem(key, raw ? String(initialValue) : JSON.stringify(initialValue));
                return initialValue;
            }
            else {
                return raw ? sessionStorageValue : JSON.parse(sessionStorageValue || 'null');
            }
        }
        catch (_a) {
            // If user is in private mode or has storage restriction
            // sessionStorage can throw. JSON.parse and JSON.stringify
            // cat throw, too.
            return initialValue;
        }
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        try {
            var serializedState = raw ? String(state) : JSON.stringify(state);
            sessionStorage.setItem(key, serializedState);
        }
        catch (_a) {
            // If user is in private mode or has storage restriction
            // sessionStorage can throw. Also JSON.stringify can throw.
        }
    });
    return [state, setState];
};
/* harmony default export */ __webpack_exports__["default"] = (useSessionStorage);


/***/ }),

/***/ "./node_modules/react-use/esm/useSetState.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useSetState.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useSetState = function (initialState) {
    if (initialState === void 0) { initialState = {}; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialState), state = _a[0], set = _a[1];
    var setState = function (patch) {
        set(function (prevState) { return Object.assign({}, prevState, patch instanceof Function ? patch(prevState) : patch); });
    };
    return [state, setState];
};
/* harmony default export */ __webpack_exports__["default"] = (useSetState);


/***/ }),

/***/ "./node_modules/react-use/esm/useSize.js":
/*!***********************************************!*\
  !*** ./node_modules/react-use/esm/useSize.js ***!
  \***********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useState = react__WEBPACK_IMPORTED_MODULE_0__["useState"], useEffect = react__WEBPACK_IMPORTED_MODULE_0__["useEffect"], useRef = react__WEBPACK_IMPORTED_MODULE_0__["useRef"];
var DRAF = function (callback) { return setTimeout(callback, 35); };
var useSize = function (element, _a) {
    var _b = _a === void 0 ? {} : _a, _c = _b.width, width = _c === void 0 ? Infinity : _c, _d = _b.height, height = _d === void 0 ? Infinity : _d;
    if (!_util__WEBPACK_IMPORTED_MODULE_1__["isClient"]) {
        return [typeof element === 'function' ? element({ width: width, height: height }) : element, { width: width, height: height }];
    }
    var _e = useState({ width: width, height: height }), state = _e[0], setState = _e[1];
    if (typeof element === 'function') {
        element = element(state);
    }
    var style = element.props.style || {};
    var ref = useRef(null);
    var window = null;
    var setSize = function () {
        var iframe = ref.current;
        var size = iframe
            ? {
                width: iframe.offsetWidth,
                height: iframe.offsetHeight,
            }
            : { width: width, height: height };
        setState(size);
    };
    var onWindow = function (windowToListenOn) {
        windowToListenOn.addEventListener('resize', setSize);
        DRAF(setSize);
    };
    useEffect(function () {
        var iframe = ref.current;
        if (!iframe) {
            // iframe will be undefined if component is already unmounted
            return;
        }
        if (iframe.contentWindow) {
            window = iframe.contentWindow;
            onWindow(window);
        }
        else {
            var onLoad_1 = function () {
                iframe.removeEventListener('load', onLoad_1);
                window = iframe.contentWindow;
                onWindow(window);
            };
            iframe.addEventListener('load', onLoad_1);
        }
        return function () {
            if (window) {
                window.removeEventListener('resize', setSize);
            }
        };
    }, []);
    style.position = 'relative';
    var sized = react__WEBPACK_IMPORTED_MODULE_0__["cloneElement"].apply(react__WEBPACK_IMPORTED_MODULE_0__, [element,
        { style: style }].concat([
        react__WEBPACK_IMPORTED_MODULE_0__["createElement"]('iframe', {
            ref: ref,
            style: {
                background: 'transparent',
                border: 'none',
                height: '100%',
                left: 0,
                position: 'absolute',
                top: 0,
                width: '100%',
                zIndex: -1,
            },
        })
    ].concat(react__WEBPACK_IMPORTED_MODULE_0__["Children"].toArray(element.props.children))));
    return [sized, state];
};
/* harmony default export */ __webpack_exports__["default"] = (useSize);


/***/ }),

/***/ "./node_modules/react-use/esm/useSpeech.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useSpeech.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useMount__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useMount */ "./node_modules/react-use/esm/useMount.js");
/* harmony import */ var _useSetState__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./useSetState */ "./node_modules/react-use/esm/useSetState.js");



var voices =  true && typeof window.speechSynthesis === 'object' ? window.speechSynthesis.getVoices() : [];
var useSpeech = function (text, opts) {
    if (opts === void 0) { opts = {}; }
    var _a = Object(_useSetState__WEBPACK_IMPORTED_MODULE_2__["default"])({
        isPlaying: false,
        lang: opts.lang || 'default',
        voice: opts.voice || voices[0],
        rate: opts.rate || 1,
        pitch: opts.pitch || 1,
        volume: opts.volume || 1,
    }), state = _a[0], setState = _a[1];
    var uterranceRef = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    Object(_useMount__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        var utterance = new SpeechSynthesisUtterance(text);
        opts.lang && (utterance.lang = opts.lang);
        opts.voice && (utterance.voice = opts.voice);
        utterance.rate = opts.rate || 1;
        utterance.pitch = opts.pitch || 1;
        utterance.volume = opts.volume || 1;
        utterance.onstart = function () { return setState({ isPlaying: true }); };
        utterance.onresume = function () { return setState({ isPlaying: true }); };
        utterance.onend = function () { return setState({ isPlaying: false }); };
        utterance.onpause = function () { return setState({ isPlaying: false }); };
        uterranceRef.current = utterance;
        window.speechSynthesis.speak(uterranceRef.current);
    });
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useSpeech);


/***/ }),

/***/ "./node_modules/react-use/esm/useStartTyping.js":
/*!******************************************************!*\
  !*** ./node_modules/react-use/esm/useStartTyping.js ***!
  \******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var isFocusedElementEditable = function () {
    var activeElement = document.activeElement, body = document.body;
    if (!activeElement) {
        return false;
    }
    // If not element has focus, we assume it is not editable, too.
    if (activeElement === body) {
        return false;
    }
    // Assume <input> and <textarea> elements are editable.
    switch (activeElement.tagName) {
        case 'INPUT':
        case 'TEXTAREA':
            return true;
    }
    // Check if any other focused element id editable.
    return activeElement.hasAttribute('contenteditable');
};
var isTypedCharGood = function (_a) {
    var keyCode = _a.keyCode, metaKey = _a.metaKey, ctrlKey = _a.ctrlKey, altKey = _a.altKey;
    if (metaKey || ctrlKey || altKey) {
        return false;
    }
    // 0...9
    if (keyCode >= 48 && keyCode <= 57) {
        return true;
    }
    // a...z
    if (keyCode >= 65 && keyCode <= 90) {
        return true;
    }
    // All other keys.
    return false;
};
var useStartTyping = function (onStartTyping) {
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useLayoutEffect"])(function () {
        var keydown = function (event) {
            !isFocusedElementEditable() && isTypedCharGood(event) && onStartTyping(event);
        };
        document.addEventListener('keydown', keydown);
        return function () {
            document.removeEventListener('keydown', keydown);
        };
    }, []);
};
/* harmony default export */ __webpack_exports__["default"] = (useStartTyping);


/***/ }),

/***/ "./node_modules/react-use/esm/useThrottle.js":
/*!***************************************************!*\
  !*** ./node_modules/react-use/esm/useThrottle.js ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useUnmount__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUnmount */ "./node_modules/react-use/esm/useUnmount.js");


var useThrottle = function (value, ms) {
    if (ms === void 0) { ms = 200; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(value), state = _a[0], setState = _a[1];
    var timeout = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    var nextValue = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    var hasNextValue = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(0);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (!timeout.current) {
            setState(value);
            var timeoutCallback_1 = function () {
                if (hasNextValue.current) {
                    hasNextValue.current = false;
                    setState(nextValue.current);
                    timeout.current = setTimeout(timeoutCallback_1, ms);
                }
                else {
                    timeout.current = null;
                }
            };
            timeout.current = setTimeout(timeoutCallback_1, ms);
        }
        else {
            nextValue.current = value;
            hasNextValue.current = true;
        }
    }, [value]);
    Object(_useUnmount__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        clearTimeout(timeout.current);
    });
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useThrottle);


/***/ }),

/***/ "./node_modules/react-use/esm/useThrottleFn.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useThrottleFn.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useUnmount__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useUnmount */ "./node_modules/react-use/esm/useUnmount.js");


var useThrottleFn = function (fn, ms, args) {
    if (ms === void 0) { ms = 200; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(null), state = _a[0], setState = _a[1];
    var timeout = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    var nextArgs = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
    var hasNextArgs = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(false);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (!timeout.current) {
            setState(fn.apply(void 0, args));
            var timeoutCallback_1 = function () {
                if (hasNextArgs.current) {
                    hasNextArgs.current = false;
                    setState(fn.apply(void 0, nextArgs.current));
                    timeout.current = setTimeout(timeoutCallback_1, ms);
                }
                else {
                    timeout.current = null;
                }
            };
            timeout.current = setTimeout(timeoutCallback_1, ms);
        }
        else {
            nextArgs.current = args;
            hasNextArgs.current = true;
        }
    }, args);
    Object(_useUnmount__WEBPACK_IMPORTED_MODULE_1__["default"])(function () {
        clearTimeout(timeout.current);
    });
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useThrottleFn);


/***/ }),

/***/ "./node_modules/react-use/esm/useTimeout.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useTimeout.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useTimeout = function (ms) {
    if (ms === void 0) { ms = 0; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(false), ready = _a[0], setReady = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var timer = setTimeout(function () {
            setReady(true);
        }, ms);
        return function () {
            clearTimeout(timer);
        };
    }, [ms]);
    return ready;
};
/* harmony default export */ __webpack_exports__["default"] = (useTimeout);


/***/ }),

/***/ "./node_modules/react-use/esm/useTitle.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useTitle.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useTitle = function (title) {
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        document.title = title;
    }, [title]);
};
/* harmony default export */ __webpack_exports__["default"] = (useTitle);


/***/ }),

/***/ "./node_modules/react-use/esm/useToggle.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useToggle.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useToggle = function (initialValue) {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(initialValue), value = _a[0], setValue = _a[1];
    var toggle = Object(react__WEBPACK_IMPORTED_MODULE_0__["useCallback"])(function (nextValue) {
        if (typeof nextValue === 'boolean') {
            setValue(nextValue);
        }
        else {
            setValue(function (currentValue) { return !currentValue; });
        }
    }, [setValue]);
    return [value, toggle];
};
/* harmony default export */ __webpack_exports__["default"] = (useToggle);


/***/ }),

/***/ "./node_modules/react-use/esm/useTween.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useTween.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var ts_easing__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ts-easing */ "./node_modules/ts-easing/lib/index.js");
/* harmony import */ var ts_easing__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(ts_easing__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useRaf__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./useRaf */ "./node_modules/react-use/esm/useRaf.js");


var useTween = function (easingName, ms, delay) {
    if (easingName === void 0) { easingName = 'inCirc'; }
    if (ms === void 0) { ms = 200; }
    if (delay === void 0) { delay = 0; }
    var fn = ts_easing__WEBPACK_IMPORTED_MODULE_0__["easing"][easingName];
    var t = Object(_useRaf__WEBPACK_IMPORTED_MODULE_1__["default"])(ms, delay);
    if (true) {
        if (typeof fn !== 'function') {
            console.error('useTween() expected "easingName" property to be a valid easing function name, like:' +
                '"' +
                Object.keys(ts_easing__WEBPACK_IMPORTED_MODULE_0__["easing"]).join('", "') +
                '".');
            console.trace();
            return 0;
        }
    }
    return fn(t);
};
/* harmony default export */ __webpack_exports__["default"] = (useTween);


/***/ }),

/***/ "./node_modules/react-use/esm/useUnmount.js":
/*!**************************************************!*\
  !*** ./node_modules/react-use/esm/useUnmount.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _useEffectOnce__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./useEffectOnce */ "./node_modules/react-use/esm/useEffectOnce.js");

var useUnmount = function (fn) {
    Object(_useEffectOnce__WEBPACK_IMPORTED_MODULE_0__["default"])(function () { return fn; });
};
/* harmony default export */ __webpack_exports__["default"] = (useUnmount);


/***/ }),

/***/ "./node_modules/react-use/esm/useUpdate.js":
/*!*************************************************!*\
  !*** ./node_modules/react-use/esm/useUpdate.js ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useUpdate = function () {
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])(0), setState = _a[1];
    return function () { return setState(function (cnt) { return cnt + 1; }); };
};
/* harmony default export */ __webpack_exports__["default"] = (useUpdate);


/***/ }),

/***/ "./node_modules/react-use/esm/useUpdateEffect.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useUpdateEffect.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var useUpdateEffect = function (effect, deps) {
    var isInitialMount = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(true);
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(isInitialMount.current
        ? function () {
            isInitialMount.current = false;
        }
        : effect, deps);
};
/* harmony default export */ __webpack_exports__["default"] = (useUpdateEffect);


/***/ }),

/***/ "./node_modules/react-use/esm/useVideo.js":
/*!************************************************!*\
  !*** ./node_modules/react-use/esm/useVideo.js ***!
  \************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _util_createHTMLMediaHook__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./util/createHTMLMediaHook */ "./node_modules/react-use/esm/util/createHTMLMediaHook.js");

var useVideo = Object(_util_createHTMLMediaHook__WEBPACK_IMPORTED_MODULE_0__["default"])('video');
/* harmony default export */ __webpack_exports__["default"] = (useVideo);


/***/ }),

/***/ "./node_modules/react-use/esm/useWait.js":
/*!***********************************************!*\
  !*** ./node_modules/react-use/esm/useWait.js ***!
  \***********************************************/
/*! exports provided: useWait, Waiter */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react_wait__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react-wait */ "./node_modules/react-wait/dist/react-wait.esm.js");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "useWait", function() { return react_wait__WEBPACK_IMPORTED_MODULE_0__["useWait"]; });

/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "Waiter", function() { return react_wait__WEBPACK_IMPORTED_MODULE_0__["Waiter"]; });





/***/ }),

/***/ "./node_modules/react-use/esm/useWindowScroll.js":
/*!*******************************************************!*\
  !*** ./node_modules/react-use/esm/useWindowScroll.js ***!
  \*******************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useWindowScroll = function () {
    var frame = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(0);
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({
        x: _util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? window.pageXOffset : 0,
        y: _util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? window.pageYOffset : 0,
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        var handler = function () {
            cancelAnimationFrame(frame.current);
            frame.current = requestAnimationFrame(function () {
                setState({
                    x: window.pageXOffset,
                    y: window.pageYOffset,
                });
            });
        };
        window.addEventListener('scroll', handler, {
            capture: false,
            passive: true,
        });
        return function () {
            cancelAnimationFrame(frame.current);
            window.removeEventListener('scroll', handler);
        };
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useWindowScroll);


/***/ }),

/***/ "./node_modules/react-use/esm/useWindowSize.js":
/*!*****************************************************!*\
  !*** ./node_modules/react-use/esm/useWindowSize.js ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./util */ "./node_modules/react-use/esm/util.js");


var useWindowSize = function (initialWidth, initialHeight) {
    if (initialWidth === void 0) { initialWidth = Infinity; }
    if (initialHeight === void 0) { initialHeight = Infinity; }
    var _a = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])({
        width: _util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? window.innerWidth : initialWidth,
        height: _util__WEBPACK_IMPORTED_MODULE_1__["isClient"] ? window.innerHeight : initialHeight,
    }), state = _a[0], setState = _a[1];
    Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
        if (_util__WEBPACK_IMPORTED_MODULE_1__["isClient"]) {
            var handler_1 = function () {
                setState({
                    width: window.innerWidth,
                    height: window.innerHeight,
                });
            };
            window.addEventListener('resize', handler_1);
            return function () { return window.removeEventListener('resize', handler_1); };
        }
        else {
            return undefined;
        }
    }, []);
    return state;
};
/* harmony default export */ __webpack_exports__["default"] = (useWindowSize);


/***/ }),

/***/ "./node_modules/react-use/esm/util.js":
/*!********************************************!*\
  !*** ./node_modules/react-use/esm/util.js ***!
  \********************************************/
/*! exports provided: isClient, on, off */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "isClient", function() { return isClient; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "on", function() { return on; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "off", function() { return off; });
var isClient = "object" === 'object';
var on = function (obj) {
    var args = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        args[_i - 1] = arguments[_i];
    }
    return obj.addEventListener.apply(obj, args);
};
var off = function (obj) {
    var args = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        args[_i - 1] = arguments[_i];
    }
    return obj.removeEventListener.apply(obj, args);
};


/***/ }),

/***/ "./node_modules/react-use/esm/util/createHTMLMediaHook.js":
/*!****************************************************************!*\
  !*** ./node_modules/react-use/esm/util/createHTMLMediaHook.js ***!
  \****************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _useSetState__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../useSetState */ "./node_modules/react-use/esm/useSetState.js");
/* harmony import */ var _parseTimeRanges__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./parseTimeRanges */ "./node_modules/react-use/esm/util/parseTimeRanges.js");
var __assign = (undefined && undefined.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};




var createHTMLMediaHook = function (tag) {
    var hook = function (elOrProps) {
        var element;
        var props;
        if (react__WEBPACK_IMPORTED_MODULE_0__["isValidElement"](elOrProps)) {
            element = elOrProps;
            props = element.props;
        }
        else {
            props = elOrProps;
        }
        var _a = Object(_useSetState__WEBPACK_IMPORTED_MODULE_1__["default"])({
            buffered: [],
            time: 0,
            duration: 0,
            isPlaying: false,
            muted: false,
            volume: 1,
        }), state = _a[0], setState = _a[1];
        var ref = Object(react__WEBPACK_IMPORTED_MODULE_0__["useRef"])(null);
        var wrapEvent = function (userEvent, proxyEvent) {
            return function (event) {
                try {
                    proxyEvent && proxyEvent(event);
                }
                finally {
                    userEvent && userEvent(event);
                }
            };
        };
        var onPlay = function () { return setState({ isPlaying: true }); };
        var onPause = function () { return setState({ isPlaying: false }); };
        var onVolumeChange = function () {
            var el = ref.current;
            if (!el) {
                return;
            }
            setState({
                muted: el.muted,
                volume: el.volume,
            });
        };
        var onDurationChange = function () {
            var el = ref.current;
            if (!el) {
                return;
            }
            var duration = el.duration, buffered = el.buffered;
            setState({
                duration: duration,
                buffered: Object(_parseTimeRanges__WEBPACK_IMPORTED_MODULE_2__["default"])(buffered),
            });
        };
        var onTimeUpdate = function () {
            var el = ref.current;
            if (!el) {
                return;
            }
            setState({ time: el.currentTime });
        };
        var onProgress = function () {
            var el = ref.current;
            if (!el) {
                return;
            }
            setState({ buffered: Object(_parseTimeRanges__WEBPACK_IMPORTED_MODULE_2__["default"])(el.buffered) });
        };
        if (element) {
            element = react__WEBPACK_IMPORTED_MODULE_0__["cloneElement"](element, __assign({ controls: false }, props, { ref: ref, onPlay: wrapEvent(props.onPlay, onPlay), onPause: wrapEvent(props.onPause, onPause), onVolumeChange: wrapEvent(props.onVolumeChange, onVolumeChange), onDurationChange: wrapEvent(props.onDurationChange, onDurationChange), onTimeUpdate: wrapEvent(props.onTimeUpdate, onTimeUpdate), onProgress: wrapEvent(props.onProgress, onProgress) }));
        }
        else {
            element = react__WEBPACK_IMPORTED_MODULE_0__["createElement"](tag, __assign({ controls: false }, props, { ref: ref, onPlay: wrapEvent(props.onPlay, onPlay), onPause: wrapEvent(props.onPause, onPause), onVolumeChange: wrapEvent(props.onVolumeChange, onVolumeChange), onDurationChange: wrapEvent(props.onDurationChange, onDurationChange), onTimeUpdate: wrapEvent(props.onTimeUpdate, onTimeUpdate), onProgress: wrapEvent(props.onProgress, onProgress) })); // TODO: fix this typing.
        }
        // Some browsers return `Promise` on `.play()` and may throw errors
        // if one tries to execute another `.play()` or `.pause()` while that
        // promise is resolving. So we prevent that with this lock.
        // See: https://bugs.chromium.org/p/chromium/issues/detail?id=593273
        var lockPlay = false;
        var controls = {
            play: function () {
                var el = ref.current;
                if (!el) {
                    return undefined;
                }
                if (!lockPlay) {
                    var promise = el.play();
                    var isPromise = typeof promise === 'object';
                    if (isPromise) {
                        lockPlay = true;
                        var resetLock = function () {
                            lockPlay = false;
                        };
                        promise.then(resetLock, resetLock);
                    }
                    return promise;
                }
                return undefined;
            },
            pause: function () {
                var el = ref.current;
                if (el && !lockPlay) {
                    return el.pause();
                }
            },
            seek: function (time) {
                var el = ref.current;
                if (!el || state.duration === undefined) {
                    return;
                }
                time = Math.min(state.duration, Math.max(0, time));
                el.currentTime = time;
            },
            volume: function (volume) {
                var el = ref.current;
                if (!el) {
                    return;
                }
                volume = Math.min(1, Math.max(0, volume));
                el.volume = volume;
                setState({ volume: volume });
            },
            mute: function () {
                var el = ref.current;
                if (!el) {
                    return;
                }
                el.muted = true;
            },
            unmute: function () {
                var el = ref.current;
                if (!el) {
                    return;
                }
                el.muted = false;
            },
        };
        Object(react__WEBPACK_IMPORTED_MODULE_0__["useEffect"])(function () {
            var el = ref.current;
            if (!el) {
                if (true) {
                    console.error('useAudio() ref to <audio> element is empty at mount. ' +
                        'It seem you have not rendered the audio element, which is ' +
                        'returns as the first argument const [audio] = useAudio(...).');
                }
                return;
            }
            setState({
                volume: el.volume,
                muted: el.muted,
                isPlaying: !el.paused,
            });
            // Start media, if autoPlay requested.
            if (props.autoPlay && el.paused) {
                controls.play();
            }
        }, [props.src]);
        return [element, state, controls, ref];
    };
    return hook;
};
/* harmony default export */ __webpack_exports__["default"] = (createHTMLMediaHook);


/***/ }),

/***/ "./node_modules/react-use/esm/util/parseTimeRanges.js":
/*!************************************************************!*\
  !*** ./node_modules/react-use/esm/util/parseTimeRanges.js ***!
  \************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
var parseTimeRanges = function (ranges) {
    var result = [];
    for (var i = 0; i < ranges.length; i++) {
        result.push({
            start: ranges.start(i),
            end: ranges.end(i),
        });
    }
    return result;
};
/* harmony default export */ __webpack_exports__["default"] = (parseTimeRanges);


/***/ }),

/***/ "./node_modules/react-wait/dist/react-wait.esm.js":
/*!********************************************************!*\
  !*** ./node_modules/react-wait/dist/react-wait.esm.js ***!
  \********************************************************/
/*! exports provided: Waiter, useWait */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Waiter", function() { return f; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "useWait", function() { return s; });
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);

var i = function(n) {
    return n.length > 0;
  },
  e = function(n, t) {
    return n.includes(t);
  },
  u = function(n, t) {
    return e(n, t) ? n : n.concat([t]);
  },
  c = function(n, t) {
    return n.filter(function(n) {
      return n !== t;
    });
  },
  a = react__WEBPACK_IMPORTED_MODULE_0___default.a.createContext();
function o(n) {
  return Object(react__WEBPACK_IMPORTED_MODULE_0__["useContext"])(a).waiters.includes(n.on) ? n.fallback : n.children;
}
function f(r) {
  var f = Object(react__WEBPACK_IMPORTED_MODULE_0__["useState"])([]),
    s = f[0],
    g = f[1];
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(
    a.Provider,
    {
      value: {
        waiters: s,
        createWaitingContext: function(t) {
          return {
            isWaiting: function() {
              return e(s, t);
            },
            startWaiting: function() {
              return g(u(s, t));
            },
            endWaiting: function() {
              return g(c(s, t));
            },
            Wait: function(r) {
              return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(o, Object.assign({}, { on: t }, r));
            }
          };
        },
        anyWaiting: function() {
          return i(s);
        },
        isWaiting: function(n) {
          return e(s, n);
        },
        startWaiting: function(n) {
          g(u(s, n));
        },
        endWaiting: function(n) {
          g(c(s, n));
        }
      }
    },
    r.children
  );
}
function s() {
  var n = Object(react__WEBPACK_IMPORTED_MODULE_0__["useContext"])(a);
  return Object.assign({}, n, { Wait: o });
}

//# sourceMappingURL=react-wait.esm.js.map


/***/ }),

/***/ "./node_modules/react/index.js":
/*!*******************************************************************************************!*\
  !*** delegated ./node_modules/react/index.js from dll-reference dll_01f9a3fa864a7b7414d8 ***!
  \*******************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = (__webpack_require__(/*! dll-reference dll_01f9a3fa864a7b7414d8 */ "dll-reference dll_01f9a3fa864a7b7414d8"))("./node_modules/react/index.js");

/***/ }),

/***/ "./node_modules/regenerator-runtime/runtime.js":
/*!*****************************************************!*\
  !*** ./node_modules/regenerator-runtime/runtime.js ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

/**
 * Copyright (c) 2014-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

var runtime = (function (exports) {
  "use strict";

  var Op = Object.prototype;
  var hasOwn = Op.hasOwnProperty;
  var undefined; // More compressible than void 0.
  var $Symbol = typeof Symbol === "function" ? Symbol : {};
  var iteratorSymbol = $Symbol.iterator || "@@iterator";
  var asyncIteratorSymbol = $Symbol.asyncIterator || "@@asyncIterator";
  var toStringTagSymbol = $Symbol.toStringTag || "@@toStringTag";

  function wrap(innerFn, outerFn, self, tryLocsList) {
    // If outerFn provided and outerFn.prototype is a Generator, then outerFn.prototype instanceof Generator.
    var protoGenerator = outerFn && outerFn.prototype instanceof Generator ? outerFn : Generator;
    var generator = Object.create(protoGenerator.prototype);
    var context = new Context(tryLocsList || []);

    // The ._invoke method unifies the implementations of the .next,
    // .throw, and .return methods.
    generator._invoke = makeInvokeMethod(innerFn, self, context);

    return generator;
  }
  exports.wrap = wrap;

  // Try/catch helper to minimize deoptimizations. Returns a completion
  // record like context.tryEntries[i].completion. This interface could
  // have been (and was previously) designed to take a closure to be
  // invoked without arguments, but in all the cases we care about we
  // already have an existing method we want to call, so there's no need
  // to create a new function object. We can even get away with assuming
  // the method takes exactly one argument, since that happens to be true
  // in every case, so we don't have to touch the arguments object. The
  // only additional allocation required is the completion record, which
  // has a stable shape and so hopefully should be cheap to allocate.
  function tryCatch(fn, obj, arg) {
    try {
      return { type: "normal", arg: fn.call(obj, arg) };
    } catch (err) {
      return { type: "throw", arg: err };
    }
  }

  var GenStateSuspendedStart = "suspendedStart";
  var GenStateSuspendedYield = "suspendedYield";
  var GenStateExecuting = "executing";
  var GenStateCompleted = "completed";

  // Returning this object from the innerFn has the same effect as
  // breaking out of the dispatch switch statement.
  var ContinueSentinel = {};

  // Dummy constructor functions that we use as the .constructor and
  // .constructor.prototype properties for functions that return Generator
  // objects. For full spec compliance, you may wish to configure your
  // minifier not to mangle the names of these two functions.
  function Generator() {}
  function GeneratorFunction() {}
  function GeneratorFunctionPrototype() {}

  // This is a polyfill for %IteratorPrototype% for environments that
  // don't natively support it.
  var IteratorPrototype = {};
  IteratorPrototype[iteratorSymbol] = function () {
    return this;
  };

  var getProto = Object.getPrototypeOf;
  var NativeIteratorPrototype = getProto && getProto(getProto(values([])));
  if (NativeIteratorPrototype &&
      NativeIteratorPrototype !== Op &&
      hasOwn.call(NativeIteratorPrototype, iteratorSymbol)) {
    // This environment has a native %IteratorPrototype%; use it instead
    // of the polyfill.
    IteratorPrototype = NativeIteratorPrototype;
  }

  var Gp = GeneratorFunctionPrototype.prototype =
    Generator.prototype = Object.create(IteratorPrototype);
  GeneratorFunction.prototype = Gp.constructor = GeneratorFunctionPrototype;
  GeneratorFunctionPrototype.constructor = GeneratorFunction;
  GeneratorFunctionPrototype[toStringTagSymbol] =
    GeneratorFunction.displayName = "GeneratorFunction";

  // Helper for defining the .next, .throw, and .return methods of the
  // Iterator interface in terms of a single ._invoke method.
  function defineIteratorMethods(prototype) {
    ["next", "throw", "return"].forEach(function(method) {
      prototype[method] = function(arg) {
        return this._invoke(method, arg);
      };
    });
  }

  exports.isGeneratorFunction = function(genFun) {
    var ctor = typeof genFun === "function" && genFun.constructor;
    return ctor
      ? ctor === GeneratorFunction ||
        // For the native GeneratorFunction constructor, the best we can
        // do is to check its .name property.
        (ctor.displayName || ctor.name) === "GeneratorFunction"
      : false;
  };

  exports.mark = function(genFun) {
    if (Object.setPrototypeOf) {
      Object.setPrototypeOf(genFun, GeneratorFunctionPrototype);
    } else {
      genFun.__proto__ = GeneratorFunctionPrototype;
      if (!(toStringTagSymbol in genFun)) {
        genFun[toStringTagSymbol] = "GeneratorFunction";
      }
    }
    genFun.prototype = Object.create(Gp);
    return genFun;
  };

  // Within the body of any async function, `await x` is transformed to
  // `yield regeneratorRuntime.awrap(x)`, so that the runtime can test
  // `hasOwn.call(value, "__await")` to determine if the yielded value is
  // meant to be awaited.
  exports.awrap = function(arg) {
    return { __await: arg };
  };

  function AsyncIterator(generator) {
    function invoke(method, arg, resolve, reject) {
      var record = tryCatch(generator[method], generator, arg);
      if (record.type === "throw") {
        reject(record.arg);
      } else {
        var result = record.arg;
        var value = result.value;
        if (value &&
            typeof value === "object" &&
            hasOwn.call(value, "__await")) {
          return Promise.resolve(value.__await).then(function(value) {
            invoke("next", value, resolve, reject);
          }, function(err) {
            invoke("throw", err, resolve, reject);
          });
        }

        return Promise.resolve(value).then(function(unwrapped) {
          // When a yielded Promise is resolved, its final value becomes
          // the .value of the Promise<{value,done}> result for the
          // current iteration.
          result.value = unwrapped;
          resolve(result);
        }, function(error) {
          // If a rejected Promise was yielded, throw the rejection back
          // into the async generator function so it can be handled there.
          return invoke("throw", error, resolve, reject);
        });
      }
    }

    var previousPromise;

    function enqueue(method, arg) {
      function callInvokeWithMethodAndArg() {
        return new Promise(function(resolve, reject) {
          invoke(method, arg, resolve, reject);
        });
      }

      return previousPromise =
        // If enqueue has been called before, then we want to wait until
        // all previous Promises have been resolved before calling invoke,
        // so that results are always delivered in the correct order. If
        // enqueue has not been called before, then it is important to
        // call invoke immediately, without waiting on a callback to fire,
        // so that the async generator function has the opportunity to do
        // any necessary setup in a predictable way. This predictability
        // is why the Promise constructor synchronously invokes its
        // executor callback, and why async functions synchronously
        // execute code before the first await. Since we implement simple
        // async functions in terms of async generators, it is especially
        // important to get this right, even though it requires care.
        previousPromise ? previousPromise.then(
          callInvokeWithMethodAndArg,
          // Avoid propagating failures to Promises returned by later
          // invocations of the iterator.
          callInvokeWithMethodAndArg
        ) : callInvokeWithMethodAndArg();
    }

    // Define the unified helper method that is used to implement .next,
    // .throw, and .return (see defineIteratorMethods).
    this._invoke = enqueue;
  }

  defineIteratorMethods(AsyncIterator.prototype);
  AsyncIterator.prototype[asyncIteratorSymbol] = function () {
    return this;
  };
  exports.AsyncIterator = AsyncIterator;

  // Note that simple async functions are implemented on top of
  // AsyncIterator objects; they just return a Promise for the value of
  // the final result produced by the iterator.
  exports.async = function(innerFn, outerFn, self, tryLocsList) {
    var iter = new AsyncIterator(
      wrap(innerFn, outerFn, self, tryLocsList)
    );

    return exports.isGeneratorFunction(outerFn)
      ? iter // If outerFn is a generator, return the full iterator.
      : iter.next().then(function(result) {
          return result.done ? result.value : iter.next();
        });
  };

  function makeInvokeMethod(innerFn, self, context) {
    var state = GenStateSuspendedStart;

    return function invoke(method, arg) {
      if (state === GenStateExecuting) {
        throw new Error("Generator is already running");
      }

      if (state === GenStateCompleted) {
        if (method === "throw") {
          throw arg;
        }

        // Be forgiving, per 25.3.3.3.3 of the spec:
        // https://people.mozilla.org/~jorendorff/es6-draft.html#sec-generatorresume
        return doneResult();
      }

      context.method = method;
      context.arg = arg;

      while (true) {
        var delegate = context.delegate;
        if (delegate) {
          var delegateResult = maybeInvokeDelegate(delegate, context);
          if (delegateResult) {
            if (delegateResult === ContinueSentinel) continue;
            return delegateResult;
          }
        }

        if (context.method === "next") {
          // Setting context._sent for legacy support of Babel's
          // function.sent implementation.
          context.sent = context._sent = context.arg;

        } else if (context.method === "throw") {
          if (state === GenStateSuspendedStart) {
            state = GenStateCompleted;
            throw context.arg;
          }

          context.dispatchException(context.arg);

        } else if (context.method === "return") {
          context.abrupt("return", context.arg);
        }

        state = GenStateExecuting;

        var record = tryCatch(innerFn, self, context);
        if (record.type === "normal") {
          // If an exception is thrown from innerFn, we leave state ===
          // GenStateExecuting and loop back for another invocation.
          state = context.done
            ? GenStateCompleted
            : GenStateSuspendedYield;

          if (record.arg === ContinueSentinel) {
            continue;
          }

          return {
            value: record.arg,
            done: context.done
          };

        } else if (record.type === "throw") {
          state = GenStateCompleted;
          // Dispatch the exception by looping back around to the
          // context.dispatchException(context.arg) call above.
          context.method = "throw";
          context.arg = record.arg;
        }
      }
    };
  }

  // Call delegate.iterator[context.method](context.arg) and handle the
  // result, either by returning a { value, done } result from the
  // delegate iterator, or by modifying context.method and context.arg,
  // setting context.delegate to null, and returning the ContinueSentinel.
  function maybeInvokeDelegate(delegate, context) {
    var method = delegate.iterator[context.method];
    if (method === undefined) {
      // A .throw or .return when the delegate iterator has no .throw
      // method always terminates the yield* loop.
      context.delegate = null;

      if (context.method === "throw") {
        // Note: ["return"] must be used for ES3 parsing compatibility.
        if (delegate.iterator["return"]) {
          // If the delegate iterator has a return method, give it a
          // chance to clean up.
          context.method = "return";
          context.arg = undefined;
          maybeInvokeDelegate(delegate, context);

          if (context.method === "throw") {
            // If maybeInvokeDelegate(context) changed context.method from
            // "return" to "throw", let that override the TypeError below.
            return ContinueSentinel;
          }
        }

        context.method = "throw";
        context.arg = new TypeError(
          "The iterator does not provide a 'throw' method");
      }

      return ContinueSentinel;
    }

    var record = tryCatch(method, delegate.iterator, context.arg);

    if (record.type === "throw") {
      context.method = "throw";
      context.arg = record.arg;
      context.delegate = null;
      return ContinueSentinel;
    }

    var info = record.arg;

    if (! info) {
      context.method = "throw";
      context.arg = new TypeError("iterator result is not an object");
      context.delegate = null;
      return ContinueSentinel;
    }

    if (info.done) {
      // Assign the result of the finished delegate to the temporary
      // variable specified by delegate.resultName (see delegateYield).
      context[delegate.resultName] = info.value;

      // Resume execution at the desired location (see delegateYield).
      context.next = delegate.nextLoc;

      // If context.method was "throw" but the delegate handled the
      // exception, let the outer generator proceed normally. If
      // context.method was "next", forget context.arg since it has been
      // "consumed" by the delegate iterator. If context.method was
      // "return", allow the original .return call to continue in the
      // outer generator.
      if (context.method !== "return") {
        context.method = "next";
        context.arg = undefined;
      }

    } else {
      // Re-yield the result returned by the delegate method.
      return info;
    }

    // The delegate iterator is finished, so forget it and continue with
    // the outer generator.
    context.delegate = null;
    return ContinueSentinel;
  }

  // Define Generator.prototype.{next,throw,return} in terms of the
  // unified ._invoke helper method.
  defineIteratorMethods(Gp);

  Gp[toStringTagSymbol] = "Generator";

  // A Generator should always return itself as the iterator object when the
  // @@iterator function is called on it. Some browsers' implementations of the
  // iterator prototype chain incorrectly implement this, causing the Generator
  // object to not be returned from this call. This ensures that doesn't happen.
  // See https://github.com/facebook/regenerator/issues/274 for more details.
  Gp[iteratorSymbol] = function() {
    return this;
  };

  Gp.toString = function() {
    return "[object Generator]";
  };

  function pushTryEntry(locs) {
    var entry = { tryLoc: locs[0] };

    if (1 in locs) {
      entry.catchLoc = locs[1];
    }

    if (2 in locs) {
      entry.finallyLoc = locs[2];
      entry.afterLoc = locs[3];
    }

    this.tryEntries.push(entry);
  }

  function resetTryEntry(entry) {
    var record = entry.completion || {};
    record.type = "normal";
    delete record.arg;
    entry.completion = record;
  }

  function Context(tryLocsList) {
    // The root entry object (effectively a try statement without a catch
    // or a finally block) gives us a place to store values thrown from
    // locations where there is no enclosing try statement.
    this.tryEntries = [{ tryLoc: "root" }];
    tryLocsList.forEach(pushTryEntry, this);
    this.reset(true);
  }

  exports.keys = function(object) {
    var keys = [];
    for (var key in object) {
      keys.push(key);
    }
    keys.reverse();

    // Rather than returning an object with a next method, we keep
    // things simple and return the next function itself.
    return function next() {
      while (keys.length) {
        var key = keys.pop();
        if (key in object) {
          next.value = key;
          next.done = false;
          return next;
        }
      }

      // To avoid creating an additional object, we just hang the .value
      // and .done properties off the next function object itself. This
      // also ensures that the minifier will not anonymize the function.
      next.done = true;
      return next;
    };
  };

  function values(iterable) {
    if (iterable) {
      var iteratorMethod = iterable[iteratorSymbol];
      if (iteratorMethod) {
        return iteratorMethod.call(iterable);
      }

      if (typeof iterable.next === "function") {
        return iterable;
      }

      if (!isNaN(iterable.length)) {
        var i = -1, next = function next() {
          while (++i < iterable.length) {
            if (hasOwn.call(iterable, i)) {
              next.value = iterable[i];
              next.done = false;
              return next;
            }
          }

          next.value = undefined;
          next.done = true;

          return next;
        };

        return next.next = next;
      }
    }

    // Return an iterator with no values.
    return { next: doneResult };
  }
  exports.values = values;

  function doneResult() {
    return { value: undefined, done: true };
  }

  Context.prototype = {
    constructor: Context,

    reset: function(skipTempReset) {
      this.prev = 0;
      this.next = 0;
      // Resetting context._sent for legacy support of Babel's
      // function.sent implementation.
      this.sent = this._sent = undefined;
      this.done = false;
      this.delegate = null;

      this.method = "next";
      this.arg = undefined;

      this.tryEntries.forEach(resetTryEntry);

      if (!skipTempReset) {
        for (var name in this) {
          // Not sure about the optimal order of these conditions:
          if (name.charAt(0) === "t" &&
              hasOwn.call(this, name) &&
              !isNaN(+name.slice(1))) {
            this[name] = undefined;
          }
        }
      }
    },

    stop: function() {
      this.done = true;

      var rootEntry = this.tryEntries[0];
      var rootRecord = rootEntry.completion;
      if (rootRecord.type === "throw") {
        throw rootRecord.arg;
      }

      return this.rval;
    },

    dispatchException: function(exception) {
      if (this.done) {
        throw exception;
      }

      var context = this;
      function handle(loc, caught) {
        record.type = "throw";
        record.arg = exception;
        context.next = loc;

        if (caught) {
          // If the dispatched exception was caught by a catch block,
          // then let that catch block handle the exception normally.
          context.method = "next";
          context.arg = undefined;
        }

        return !! caught;
      }

      for (var i = this.tryEntries.length - 1; i >= 0; --i) {
        var entry = this.tryEntries[i];
        var record = entry.completion;

        if (entry.tryLoc === "root") {
          // Exception thrown outside of any try block that could handle
          // it, so set the completion value of the entire function to
          // throw the exception.
          return handle("end");
        }

        if (entry.tryLoc <= this.prev) {
          var hasCatch = hasOwn.call(entry, "catchLoc");
          var hasFinally = hasOwn.call(entry, "finallyLoc");

          if (hasCatch && hasFinally) {
            if (this.prev < entry.catchLoc) {
              return handle(entry.catchLoc, true);
            } else if (this.prev < entry.finallyLoc) {
              return handle(entry.finallyLoc);
            }

          } else if (hasCatch) {
            if (this.prev < entry.catchLoc) {
              return handle(entry.catchLoc, true);
            }

          } else if (hasFinally) {
            if (this.prev < entry.finallyLoc) {
              return handle(entry.finallyLoc);
            }

          } else {
            throw new Error("try statement without catch or finally");
          }
        }
      }
    },

    abrupt: function(type, arg) {
      for (var i = this.tryEntries.length - 1; i >= 0; --i) {
        var entry = this.tryEntries[i];
        if (entry.tryLoc <= this.prev &&
            hasOwn.call(entry, "finallyLoc") &&
            this.prev < entry.finallyLoc) {
          var finallyEntry = entry;
          break;
        }
      }

      if (finallyEntry &&
          (type === "break" ||
           type === "continue") &&
          finallyEntry.tryLoc <= arg &&
          arg <= finallyEntry.finallyLoc) {
        // Ignore the finally entry if control is not jumping to a
        // location outside the try/catch block.
        finallyEntry = null;
      }

      var record = finallyEntry ? finallyEntry.completion : {};
      record.type = type;
      record.arg = arg;

      if (finallyEntry) {
        this.method = "next";
        this.next = finallyEntry.finallyLoc;
        return ContinueSentinel;
      }

      return this.complete(record);
    },

    complete: function(record, afterLoc) {
      if (record.type === "throw") {
        throw record.arg;
      }

      if (record.type === "break" ||
          record.type === "continue") {
        this.next = record.arg;
      } else if (record.type === "return") {
        this.rval = this.arg = record.arg;
        this.method = "return";
        this.next = "end";
      } else if (record.type === "normal" && afterLoc) {
        this.next = afterLoc;
      }

      return ContinueSentinel;
    },

    finish: function(finallyLoc) {
      for (var i = this.tryEntries.length - 1; i >= 0; --i) {
        var entry = this.tryEntries[i];
        if (entry.finallyLoc === finallyLoc) {
          this.complete(entry.completion, entry.afterLoc);
          resetTryEntry(entry);
          return ContinueSentinel;
        }
      }
    },

    "catch": function(tryLoc) {
      for (var i = this.tryEntries.length - 1; i >= 0; --i) {
        var entry = this.tryEntries[i];
        if (entry.tryLoc === tryLoc) {
          var record = entry.completion;
          if (record.type === "throw") {
            var thrown = record.arg;
            resetTryEntry(entry);
          }
          return thrown;
        }
      }

      // The context.catch method must only be called with a location
      // argument that corresponds to a known catch block.
      throw new Error("illegal catch attempt");
    },

    delegateYield: function(iterable, resultName, nextLoc) {
      this.delegate = {
        iterator: values(iterable),
        resultName: resultName,
        nextLoc: nextLoc
      };

      if (this.method === "next") {
        // Deliberately forget the last sent value so that we don't
        // accidentally pass it on to the delegate.
        this.arg = undefined;
      }

      return ContinueSentinel;
    }
  };

  // Regardless of whether this script is executing as a CommonJS module
  // or not, return the runtime object so that we can declare the variable
  // regeneratorRuntime in the outer scope, which allows this module to be
  // injected easily by `bin/regenerator --include-runtime script.js`.
  return exports;

}(
  // If this script is executing as a CommonJS module, use module.exports
  // as the regeneratorRuntime namespace. Otherwise create a new empty
  // object. Either way, the resulting object will be used to initialize
  // the regeneratorRuntime variable at the top of this file.
   true ? module.exports : undefined
));

try {
  regeneratorRuntime = runtime;
} catch (accidentalStrictMode) {
  // This module should not be running in strict mode, so the above
  // assignment should always work unless something is misconfigured. Just
  // in case runtime.js accidentally runs in strict mode, we can escape
  // strict mode using a global Function call. This could conceivably fail
  // if a Content Security Policy forbids using Function, but in that case
  // the proper solution is to fix the accidental strict mode problem. If
  // you've misconfigured your bundler to force strict mode and applied a
  // CSP to forbid Function, and you're not willing to fix either of those
  // problems, please detail your unique predicament in a GitHub issue.
  Function("r", "regeneratorRuntime = r")(runtime);
}


/***/ }),

/***/ "./node_modules/screenfull/dist/screenfull.js":
/*!****************************************************!*\
  !*** ./node_modules/screenfull/dist/screenfull.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

/*!
* screenfull
* v4.2.1 - 2019-07-27
* (c) Sindre Sorhus; MIT License
*/
(function () {
	'use strict';

	var document =  true && typeof window.document !== 'undefined' ? window.document : {};
	var isCommonjs =  true && module.exports;
	var keyboardAllowed = typeof Element !== 'undefined' && 'ALLOW_KEYBOARD_INPUT' in Element;

	var fn = (function () {
		var val;

		var fnMap = [
			[
				'requestFullscreen',
				'exitFullscreen',
				'fullscreenElement',
				'fullscreenEnabled',
				'fullscreenchange',
				'fullscreenerror'
			],
			// New WebKit
			[
				'webkitRequestFullscreen',
				'webkitExitFullscreen',
				'webkitFullscreenElement',
				'webkitFullscreenEnabled',
				'webkitfullscreenchange',
				'webkitfullscreenerror'

			],
			// Old WebKit (Safari 5.1)
			[
				'webkitRequestFullScreen',
				'webkitCancelFullScreen',
				'webkitCurrentFullScreenElement',
				'webkitCancelFullScreen',
				'webkitfullscreenchange',
				'webkitfullscreenerror'

			],
			[
				'mozRequestFullScreen',
				'mozCancelFullScreen',
				'mozFullScreenElement',
				'mozFullScreenEnabled',
				'mozfullscreenchange',
				'mozfullscreenerror'
			],
			[
				'msRequestFullscreen',
				'msExitFullscreen',
				'msFullscreenElement',
				'msFullscreenEnabled',
				'MSFullscreenChange',
				'MSFullscreenError'
			]
		];

		var i = 0;
		var l = fnMap.length;
		var ret = {};

		for (; i < l; i++) {
			val = fnMap[i];
			if (val && val[1] in document) {
				for (i = 0; i < val.length; i++) {
					ret[fnMap[0][i]] = val[i];
				}
				return ret;
			}
		}

		return false;
	})();

	var eventNameMap = {
		change: fn.fullscreenchange,
		error: fn.fullscreenerror
	};

	var screenfull = {
		request: function (elem) {
			return new Promise(function (resolve, reject) {
				var request = fn.requestFullscreen;

				var onFullScreenEntered = function () {
					this.off('change', onFullScreenEntered);
					resolve();
				}.bind(this);

				this.on('change', onFullScreenEntered);

				elem = elem || document.documentElement;

				var promise;

				// Work around Safari 5.1 bug: reports support for
				// keyboard in fullscreen even though it doesn't.
				// Browser sniffing, since the alternative with
				// setTimeout is even worse.
				if (/ Version\/5\.1(?:\.\d+)? Safari\//.test(navigator.userAgent)) {
					promise = elem[request]();
				} else {
					promise = elem[request](keyboardAllowed ? Element.ALLOW_KEYBOARD_INPUT : {});
				}

				Promise.resolve(promise).catch(reject);
			}.bind(this));
		},
		exit: function () {
			return new Promise(function (resolve) {
				if (!this.isFullscreen) {
					resolve();
					return;
				}

				var onFullScreenExit = function () {
					this.off('change', onFullScreenExit);
					resolve();
				}.bind(this);

				document[fn.exitFullscreen]();

				this.on('change', onFullScreenExit);
			}.bind(this));
		},
		toggle: function (elem) {
			return this.isFullscreen ? this.exit() : this.request(elem);
		},
		onchange: function (callback) {
			this.on('change', callback);
		},
		onerror: function (callback) {
			this.on('error', callback);
		},
		on: function (event, callback) {
			var eventName = eventNameMap[event];
			if (eventName) {
				document.addEventListener(eventName, callback, false);
			}
		},
		off: function (event, callback) {
			var eventName = eventNameMap[event];
			if (eventName) {
				document.removeEventListener(eventName, callback, false);
			}
		},
		raw: fn
	};

	if (!fn) {
		if (isCommonjs) {
			module.exports = false;
		} else {
			window.screenfull = false;
		}

		return;
	}

	Object.defineProperties(screenfull, {
		isFullscreen: {
			get: function () {
				return Boolean(document[fn.fullscreenElement]);
			}
		},
		element: {
			enumerable: true,
			get: function () {
				return document[fn.fullscreenElement];
			}
		},
		enabled: {
			enumerable: true,
			get: function () {
				// Coerce to boolean in case of old WebKit
				return Boolean(document[fn.fullscreenEnabled]);
			}
		}
	});

	if (isCommonjs) {
		module.exports = screenfull;
		// TODO: remove this in the next major version
		module.exports.default = screenfull;
	} else {
		window.screenfull = screenfull;
	}
})();


/***/ }),

/***/ "./node_modules/throttle-debounce/dist/index.esm.js":
/*!**********************************************************!*\
  !*** ./node_modules/throttle-debounce/dist/index.esm.js ***!
  \**********************************************************/
/*! exports provided: throttle, debounce */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "throttle", function() { return throttle; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "debounce", function() { return debounce; });
/* eslint-disable no-undefined,no-param-reassign,no-shadow */

/**
 * Throttle execution of a function. Especially useful for rate limiting
 * execution of handlers on events like resize and scroll.
 *
 * @param  {Number}    delay          A zero-or-greater delay in milliseconds. For event callbacks, values around 100 or 250 (or even higher) are most useful.
 * @param  {Boolean}   [noTrailing]   Optional, defaults to false. If noTrailing is true, callback will only execute every `delay` milliseconds while the
 *                                    throttled-function is being called. If noTrailing is false or unspecified, callback will be executed one final time
 *                                    after the last throttled-function call. (After the throttled-function has not been called for `delay` milliseconds,
 *                                    the internal counter is reset)
 * @param  {Function}  callback       A function to be executed after delay milliseconds. The `this` context and all arguments are passed through, as-is,
 *                                    to `callback` when the throttled-function is executed.
 * @param  {Boolean}   [debounceMode] If `debounceMode` is true (at begin), schedule `clear` to execute after `delay` ms. If `debounceMode` is false (at end),
 *                                    schedule `callback` to execute after `delay` ms.
 *
 * @return {Function}  A new, throttled, function.
 */
function throttle (delay, noTrailing, callback, debounceMode) {
  /*
   * After wrapper has stopped being called, this timeout ensures that
   * `callback` is executed at the proper times in `throttle` and `end`
   * debounce modes.
   */
  var timeoutID;
  var cancelled = false; // Keep track of the last time `callback` was executed.

  var lastExec = 0; // Function to clear existing timeout

  function clearExistingTimeout() {
    if (timeoutID) {
      clearTimeout(timeoutID);
    }
  } // Function to cancel next exec


  function cancel() {
    clearExistingTimeout();
    cancelled = true;
  } // `noTrailing` defaults to falsy.


  if (typeof noTrailing !== 'boolean') {
    debounceMode = callback;
    callback = noTrailing;
    noTrailing = undefined;
  }
  /*
   * The `wrapper` function encapsulates all of the throttling / debouncing
   * functionality and when executed will limit the rate at which `callback`
   * is executed.
   */


  function wrapper() {
    var self = this;
    var elapsed = Date.now() - lastExec;
    var args = arguments;

    if (cancelled) {
      return;
    } // Execute `callback` and update the `lastExec` timestamp.


    function exec() {
      lastExec = Date.now();
      callback.apply(self, args);
    }
    /*
     * If `debounceMode` is true (at begin) this is used to clear the flag
     * to allow future `callback` executions.
     */


    function clear() {
      timeoutID = undefined;
    }

    if (debounceMode && !timeoutID) {
      /*
       * Since `wrapper` is being called for the first time and
       * `debounceMode` is true (at begin), execute `callback`.
       */
      exec();
    }

    clearExistingTimeout();

    if (debounceMode === undefined && elapsed > delay) {
      /*
       * In throttle mode, if `delay` time has been exceeded, execute
       * `callback`.
       */
      exec();
    } else if (noTrailing !== true) {
      /*
       * In trailing throttle mode, since `delay` time has not been
       * exceeded, schedule `callback` to execute `delay` ms after most
       * recent execution.
       *
       * If `debounceMode` is true (at begin), schedule `clear` to execute
       * after `delay` ms.
       *
       * If `debounceMode` is false (at end), schedule `callback` to
       * execute after `delay` ms.
       */
      timeoutID = setTimeout(debounceMode ? clear : exec, debounceMode === undefined ? delay - elapsed : delay);
    }
  }

  wrapper.cancel = cancel; // Return the wrapper function.

  return wrapper;
}

/* eslint-disable no-undefined */
/**
 * Debounce execution of a function. Debouncing, unlike throttling,
 * guarantees that a function is only executed a single time, either at the
 * very beginning of a series of calls, or at the very end.
 *
 * @param  {Number}   delay         A zero-or-greater delay in milliseconds. For event callbacks, values around 100 or 250 (or even higher) are most useful.
 * @param  {Boolean}  [atBegin]     Optional, defaults to false. If atBegin is false or unspecified, callback will only be executed `delay` milliseconds
 *                                  after the last debounced-function call. If atBegin is true, callback will be executed only at the first debounced-function call.
 *                                  (After the throttled-function has not been called for `delay` milliseconds, the internal counter is reset).
 * @param  {Function} callback      A function to be executed after delay milliseconds. The `this` context and all arguments are passed through, as-is,
 *                                  to `callback` when the debounced-function is executed.
 *
 * @return {Function} A new, debounced function.
 */

function debounce (delay, atBegin, callback) {
  return callback === undefined ? throttle(delay, atBegin, false) : throttle(delay, callback, atBegin !== false);
}




/***/ }),

/***/ "./node_modules/toggle-selection/index.js":
/*!************************************************!*\
  !*** ./node_modules/toggle-selection/index.js ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {


module.exports = function () {
  var selection = document.getSelection();
  if (!selection.rangeCount) {
    return function () {};
  }
  var active = document.activeElement;

  var ranges = [];
  for (var i = 0; i < selection.rangeCount; i++) {
    ranges.push(selection.getRangeAt(i));
  }

  switch (active.tagName.toUpperCase()) { // .toUpperCase handles XHTML
    case 'INPUT':
    case 'TEXTAREA':
      active.blur();
      break;

    default:
      active = null;
      break;
  }

  selection.removeAllRanges();
  return function () {
    selection.type === 'Caret' &&
    selection.removeAllRanges();

    if (!selection.rangeCount) {
      ranges.forEach(function(range) {
        selection.addRange(range);
      });
    }

    active &&
    active.focus();
  };
};


/***/ }),

/***/ "./node_modules/ts-easing/lib/index.js":
/*!*********************************************!*\
  !*** ./node_modules/ts-easing/lib/index.js ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
exports.easing = {
    // No easing, no acceleration
    linear: function (t) { return t; },
    // Accelerates fast, then slows quickly towards end.
    quadratic: function (t) { return t * (-(t * t) * t + 4 * t * t - 6 * t + 4); },
    // Overshoots over 1 and then returns to 1 towards end.
    cubic: function (t) { return t * (4 * t * t - 9 * t + 6); },
    // Overshoots over 1 multiple times - wiggles around 1.
    elastic: function (t) { return t * (33 * t * t * t * t - 106 * t * t * t + 126 * t * t - 67 * t + 15); },
    // Accelerating from zero velocity
    inQuad: function (t) { return t * t; },
    // Decelerating to zero velocity
    outQuad: function (t) { return t * (2 - t); },
    // Acceleration until halfway, then deceleration
    inOutQuad: function (t) { return t < .5 ? 2 * t * t : -1 + (4 - 2 * t) * t; },
    // Accelerating from zero velocity
    inCubic: function (t) { return t * t * t; },
    // Decelerating to zero velocity
    outCubic: function (t) { return (--t) * t * t + 1; },
    // Acceleration until halfway, then deceleration
    inOutCubic: function (t) { return t < .5 ? 4 * t * t * t : (t - 1) * (2 * t - 2) * (2 * t - 2) + 1; },
    // Accelerating from zero velocity
    inQuart: function (t) { return t * t * t * t; },
    // Decelerating to zero velocity
    outQuart: function (t) { return 1 - (--t) * t * t * t; },
    // Acceleration until halfway, then deceleration
    inOutQuart: function (t) { return t < .5 ? 8 * t * t * t * t : 1 - 8 * (--t) * t * t * t; },
    // Accelerating from zero velocity
    inQuint: function (t) { return t * t * t * t * t; },
    // Decelerating to zero velocity
    outQuint: function (t) { return 1 + (--t) * t * t * t * t; },
    // Acceleration until halfway, then deceleration
    inOutQuint: function (t) { return t < .5 ? 16 * t * t * t * t * t : 1 + 16 * (--t) * t * t * t * t; },
    // Accelerating from zero velocity
    inSine: function (t) { return -Math.cos(t * (Math.PI / 2)) + 1; },
    // Decelerating to zero velocity
    outSine: function (t) { return Math.sin(t * (Math.PI / 2)); },
    // Accelerating until halfway, then decelerating
    inOutSine: function (t) { return -(Math.cos(Math.PI * t) - 1) / 2; },
    // Exponential accelerating from zero velocity
    inExpo: function (t) { return Math.pow(2, 10 * (t - 1)); },
    // Exponential decelerating to zero velocity
    outExpo: function (t) { return -Math.pow(2, -10 * t) + 1; },
    // Exponential accelerating until halfway, then decelerating
    inOutExpo: function (t) {
        t /= .5;
        if (t < 1)
            return Math.pow(2, 10 * (t - 1)) / 2;
        t--;
        return (-Math.pow(2, -10 * t) + 2) / 2;
    },
    // Circular accelerating from zero velocity
    inCirc: function (t) { return -Math.sqrt(1 - t * t) + 1; },
    // Circular decelerating to zero velocity Moves VERY fast at the beginning and
    // then quickly slows down in the middle. This tween can actually be used
    // in continuous transitions where target value changes all the time,
    // because of the very quick start, it hides the jitter between target value changes.
    outCirc: function (t) { return Math.sqrt(1 - (t = t - 1) * t); },
    // Circular acceleration until halfway, then deceleration
    inOutCirc: function (t) {
        t /= .5;
        if (t < 1)
            return -(Math.sqrt(1 - t * t) - 1) / 2;
        t -= 2;
        return (Math.sqrt(1 - t * t) + 1) / 2;
    }
};


/***/ }),

/***/ "./node_modules/url/url.js":
/*!*********************************!*\
  !*** ./node_modules/url/url.js ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
// Copyright Joyent, Inc. and other Node contributors.
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to permit
// persons to whom the Software is furnished to do so, subject to the
// following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
// USE OR OTHER DEALINGS IN THE SOFTWARE.



var punycode = __webpack_require__(/*! punycode */ "./node_modules/punycode/punycode.js");
var util = __webpack_require__(/*! ./util */ "./node_modules/url/util.js");

exports.parse = urlParse;
exports.resolve = urlResolve;
exports.resolveObject = urlResolveObject;
exports.format = urlFormat;

exports.Url = Url;

function Url() {
  this.protocol = null;
  this.slashes = null;
  this.auth = null;
  this.host = null;
  this.port = null;
  this.hostname = null;
  this.hash = null;
  this.search = null;
  this.query = null;
  this.pathname = null;
  this.path = null;
  this.href = null;
}

// Reference: RFC 3986, RFC 1808, RFC 2396

// define these here so at least they only have to be
// compiled once on the first module load.
var protocolPattern = /^([a-z0-9.+-]+:)/i,
    portPattern = /:[0-9]*$/,

    // Special case for a simple path URL
    simplePathPattern = /^(\/\/?(?!\/)[^\?\s]*)(\?[^\s]*)?$/,

    // RFC 2396: characters reserved for delimiting URLs.
    // We actually just auto-escape these.
    delims = ['<', '>', '"', '`', ' ', '\r', '\n', '\t'],

    // RFC 2396: characters not allowed for various reasons.
    unwise = ['{', '}', '|', '\\', '^', '`'].concat(delims),

    // Allowed by RFCs, but cause of XSS attacks.  Always escape these.
    autoEscape = ['\''].concat(unwise),
    // Characters that are never ever allowed in a hostname.
    // Note that any invalid chars are also handled, but these
    // are the ones that are *expected* to be seen, so we fast-path
    // them.
    nonHostChars = ['%', '/', '?', ';', '#'].concat(autoEscape),
    hostEndingChars = ['/', '?', '#'],
    hostnameMaxLen = 255,
    hostnamePartPattern = /^[+a-z0-9A-Z_-]{0,63}$/,
    hostnamePartStart = /^([+a-z0-9A-Z_-]{0,63})(.*)$/,
    // protocols that can allow "unsafe" and "unwise" chars.
    unsafeProtocol = {
      'javascript': true,
      'javascript:': true
    },
    // protocols that never have a hostname.
    hostlessProtocol = {
      'javascript': true,
      'javascript:': true
    },
    // protocols that always contain a // bit.
    slashedProtocol = {
      'http': true,
      'https': true,
      'ftp': true,
      'gopher': true,
      'file': true,
      'http:': true,
      'https:': true,
      'ftp:': true,
      'gopher:': true,
      'file:': true
    },
    querystring = __webpack_require__(/*! querystring */ "./node_modules/querystring-es3/index.js");

function urlParse(url, parseQueryString, slashesDenoteHost) {
  if (url && util.isObject(url) && url instanceof Url) return url;

  var u = new Url;
  u.parse(url, parseQueryString, slashesDenoteHost);
  return u;
}

Url.prototype.parse = function(url, parseQueryString, slashesDenoteHost) {
  if (!util.isString(url)) {
    throw new TypeError("Parameter 'url' must be a string, not " + typeof url);
  }

  // Copy chrome, IE, opera backslash-handling behavior.
  // Back slashes before the query string get converted to forward slashes
  // See: https://code.google.com/p/chromium/issues/detail?id=25916
  var queryIndex = url.indexOf('?'),
      splitter =
          (queryIndex !== -1 && queryIndex < url.indexOf('#')) ? '?' : '#',
      uSplit = url.split(splitter),
      slashRegex = /\\/g;
  uSplit[0] = uSplit[0].replace(slashRegex, '/');
  url = uSplit.join(splitter);

  var rest = url;

  // trim before proceeding.
  // This is to support parse stuff like "  http://foo.com  \n"
  rest = rest.trim();

  if (!slashesDenoteHost && url.split('#').length === 1) {
    // Try fast path regexp
    var simplePath = simplePathPattern.exec(rest);
    if (simplePath) {
      this.path = rest;
      this.href = rest;
      this.pathname = simplePath[1];
      if (simplePath[2]) {
        this.search = simplePath[2];
        if (parseQueryString) {
          this.query = querystring.parse(this.search.substr(1));
        } else {
          this.query = this.search.substr(1);
        }
      } else if (parseQueryString) {
        this.search = '';
        this.query = {};
      }
      return this;
    }
  }

  var proto = protocolPattern.exec(rest);
  if (proto) {
    proto = proto[0];
    var lowerProto = proto.toLowerCase();
    this.protocol = lowerProto;
    rest = rest.substr(proto.length);
  }

  // figure out if it's got a host
  // user@server is *always* interpreted as a hostname, and url
  // resolution will treat //foo/bar as host=foo,path=bar because that's
  // how the browser resolves relative URLs.
  if (slashesDenoteHost || proto || rest.match(/^\/\/[^@\/]+@[^@\/]+/)) {
    var slashes = rest.substr(0, 2) === '//';
    if (slashes && !(proto && hostlessProtocol[proto])) {
      rest = rest.substr(2);
      this.slashes = true;
    }
  }

  if (!hostlessProtocol[proto] &&
      (slashes || (proto && !slashedProtocol[proto]))) {

    // there's a hostname.
    // the first instance of /, ?, ;, or # ends the host.
    //
    // If there is an @ in the hostname, then non-host chars *are* allowed
    // to the left of the last @ sign, unless some host-ending character
    // comes *before* the @-sign.
    // URLs are obnoxious.
    //
    // ex:
    // http://a@b@c/ => user:a@b host:c
    // http://a@b?@c => user:a host:c path:/?@c

    // v0.12 TODO(isaacs): This is not quite how Chrome does things.
    // Review our test case against browsers more comprehensively.

    // find the first instance of any hostEndingChars
    var hostEnd = -1;
    for (var i = 0; i < hostEndingChars.length; i++) {
      var hec = rest.indexOf(hostEndingChars[i]);
      if (hec !== -1 && (hostEnd === -1 || hec < hostEnd))
        hostEnd = hec;
    }

    // at this point, either we have an explicit point where the
    // auth portion cannot go past, or the last @ char is the decider.
    var auth, atSign;
    if (hostEnd === -1) {
      // atSign can be anywhere.
      atSign = rest.lastIndexOf('@');
    } else {
      // atSign must be in auth portion.
      // http://a@b/c@d => host:b auth:a path:/c@d
      atSign = rest.lastIndexOf('@', hostEnd);
    }

    // Now we have a portion which is definitely the auth.
    // Pull that off.
    if (atSign !== -1) {
      auth = rest.slice(0, atSign);
      rest = rest.slice(atSign + 1);
      this.auth = decodeURIComponent(auth);
    }

    // the host is the remaining to the left of the first non-host char
    hostEnd = -1;
    for (var i = 0; i < nonHostChars.length; i++) {
      var hec = rest.indexOf(nonHostChars[i]);
      if (hec !== -1 && (hostEnd === -1 || hec < hostEnd))
        hostEnd = hec;
    }
    // if we still have not hit it, then the entire thing is a host.
    if (hostEnd === -1)
      hostEnd = rest.length;

    this.host = rest.slice(0, hostEnd);
    rest = rest.slice(hostEnd);

    // pull out port.
    this.parseHost();

    // we've indicated that there is a hostname,
    // so even if it's empty, it has to be present.
    this.hostname = this.hostname || '';

    // if hostname begins with [ and ends with ]
    // assume that it's an IPv6 address.
    var ipv6Hostname = this.hostname[0] === '[' &&
        this.hostname[this.hostname.length - 1] === ']';

    // validate a little.
    if (!ipv6Hostname) {
      var hostparts = this.hostname.split(/\./);
      for (var i = 0, l = hostparts.length; i < l; i++) {
        var part = hostparts[i];
        if (!part) continue;
        if (!part.match(hostnamePartPattern)) {
          var newpart = '';
          for (var j = 0, k = part.length; j < k; j++) {
            if (part.charCodeAt(j) > 127) {
              // we replace non-ASCII char with a temporary placeholder
              // we need this to make sure size of hostname is not
              // broken by replacing non-ASCII by nothing
              newpart += 'x';
            } else {
              newpart += part[j];
            }
          }
          // we test again with ASCII char only
          if (!newpart.match(hostnamePartPattern)) {
            var validParts = hostparts.slice(0, i);
            var notHost = hostparts.slice(i + 1);
            var bit = part.match(hostnamePartStart);
            if (bit) {
              validParts.push(bit[1]);
              notHost.unshift(bit[2]);
            }
            if (notHost.length) {
              rest = '/' + notHost.join('.') + rest;
            }
            this.hostname = validParts.join('.');
            break;
          }
        }
      }
    }

    if (this.hostname.length > hostnameMaxLen) {
      this.hostname = '';
    } else {
      // hostnames are always lower case.
      this.hostname = this.hostname.toLowerCase();
    }

    if (!ipv6Hostname) {
      // IDNA Support: Returns a punycoded representation of "domain".
      // It only converts parts of the domain name that
      // have non-ASCII characters, i.e. it doesn't matter if
      // you call it with a domain that already is ASCII-only.
      this.hostname = punycode.toASCII(this.hostname);
    }

    var p = this.port ? ':' + this.port : '';
    var h = this.hostname || '';
    this.host = h + p;
    this.href += this.host;

    // strip [ and ] from the hostname
    // the host field still retains them, though
    if (ipv6Hostname) {
      this.hostname = this.hostname.substr(1, this.hostname.length - 2);
      if (rest[0] !== '/') {
        rest = '/' + rest;
      }
    }
  }

  // now rest is set to the post-host stuff.
  // chop off any delim chars.
  if (!unsafeProtocol[lowerProto]) {

    // First, make 100% sure that any "autoEscape" chars get
    // escaped, even if encodeURIComponent doesn't think they
    // need to be.
    for (var i = 0, l = autoEscape.length; i < l; i++) {
      var ae = autoEscape[i];
      if (rest.indexOf(ae) === -1)
        continue;
      var esc = encodeURIComponent(ae);
      if (esc === ae) {
        esc = escape(ae);
      }
      rest = rest.split(ae).join(esc);
    }
  }


  // chop off from the tail first.
  var hash = rest.indexOf('#');
  if (hash !== -1) {
    // got a fragment string.
    this.hash = rest.substr(hash);
    rest = rest.slice(0, hash);
  }
  var qm = rest.indexOf('?');
  if (qm !== -1) {
    this.search = rest.substr(qm);
    this.query = rest.substr(qm + 1);
    if (parseQueryString) {
      this.query = querystring.parse(this.query);
    }
    rest = rest.slice(0, qm);
  } else if (parseQueryString) {
    // no query string, but parseQueryString still requested
    this.search = '';
    this.query = {};
  }
  if (rest) this.pathname = rest;
  if (slashedProtocol[lowerProto] &&
      this.hostname && !this.pathname) {
    this.pathname = '/';
  }

  //to support http.request
  if (this.pathname || this.search) {
    var p = this.pathname || '';
    var s = this.search || '';
    this.path = p + s;
  }

  // finally, reconstruct the href based on what has been validated.
  this.href = this.format();
  return this;
};

// format a parsed object into a url string
function urlFormat(obj) {
  // ensure it's an object, and not a string url.
  // If it's an obj, this is a no-op.
  // this way, you can call url_format() on strings
  // to clean up potentially wonky urls.
  if (util.isString(obj)) obj = urlParse(obj);
  if (!(obj instanceof Url)) return Url.prototype.format.call(obj);
  return obj.format();
}

Url.prototype.format = function() {
  var auth = this.auth || '';
  if (auth) {
    auth = encodeURIComponent(auth);
    auth = auth.replace(/%3A/i, ':');
    auth += '@';
  }

  var protocol = this.protocol || '',
      pathname = this.pathname || '',
      hash = this.hash || '',
      host = false,
      query = '';

  if (this.host) {
    host = auth + this.host;
  } else if (this.hostname) {
    host = auth + (this.hostname.indexOf(':') === -1 ?
        this.hostname :
        '[' + this.hostname + ']');
    if (this.port) {
      host += ':' + this.port;
    }
  }

  if (this.query &&
      util.isObject(this.query) &&
      Object.keys(this.query).length) {
    query = querystring.stringify(this.query);
  }

  var search = this.search || (query && ('?' + query)) || '';

  if (protocol && protocol.substr(-1) !== ':') protocol += ':';

  // only the slashedProtocols get the //.  Not mailto:, xmpp:, etc.
  // unless they had them to begin with.
  if (this.slashes ||
      (!protocol || slashedProtocol[protocol]) && host !== false) {
    host = '//' + (host || '');
    if (pathname && pathname.charAt(0) !== '/') pathname = '/' + pathname;
  } else if (!host) {
    host = '';
  }

  if (hash && hash.charAt(0) !== '#') hash = '#' + hash;
  if (search && search.charAt(0) !== '?') search = '?' + search;

  pathname = pathname.replace(/[?#]/g, function(match) {
    return encodeURIComponent(match);
  });
  search = search.replace('#', '%23');

  return protocol + host + pathname + search + hash;
};

function urlResolve(source, relative) {
  return urlParse(source, false, true).resolve(relative);
}

Url.prototype.resolve = function(relative) {
  return this.resolveObject(urlParse(relative, false, true)).format();
};

function urlResolveObject(source, relative) {
  if (!source) return relative;
  return urlParse(source, false, true).resolveObject(relative);
}

Url.prototype.resolveObject = function(relative) {
  if (util.isString(relative)) {
    var rel = new Url();
    rel.parse(relative, false, true);
    relative = rel;
  }

  var result = new Url();
  var tkeys = Object.keys(this);
  for (var tk = 0; tk < tkeys.length; tk++) {
    var tkey = tkeys[tk];
    result[tkey] = this[tkey];
  }

  // hash is always overridden, no matter what.
  // even href="" will remove it.
  result.hash = relative.hash;

  // if the relative url is empty, then there's nothing left to do here.
  if (relative.href === '') {
    result.href = result.format();
    return result;
  }

  // hrefs like //foo/bar always cut to the protocol.
  if (relative.slashes && !relative.protocol) {
    // take everything except the protocol from relative
    var rkeys = Object.keys(relative);
    for (var rk = 0; rk < rkeys.length; rk++) {
      var rkey = rkeys[rk];
      if (rkey !== 'protocol')
        result[rkey] = relative[rkey];
    }

    //urlParse appends trailing / to urls like http://www.example.com
    if (slashedProtocol[result.protocol] &&
        result.hostname && !result.pathname) {
      result.path = result.pathname = '/';
    }

    result.href = result.format();
    return result;
  }

  if (relative.protocol && relative.protocol !== result.protocol) {
    // if it's a known url protocol, then changing
    // the protocol does weird things
    // first, if it's not file:, then we MUST have a host,
    // and if there was a path
    // to begin with, then we MUST have a path.
    // if it is file:, then the host is dropped,
    // because that's known to be hostless.
    // anything else is assumed to be absolute.
    if (!slashedProtocol[relative.protocol]) {
      var keys = Object.keys(relative);
      for (var v = 0; v < keys.length; v++) {
        var k = keys[v];
        result[k] = relative[k];
      }
      result.href = result.format();
      return result;
    }

    result.protocol = relative.protocol;
    if (!relative.host && !hostlessProtocol[relative.protocol]) {
      var relPath = (relative.pathname || '').split('/');
      while (relPath.length && !(relative.host = relPath.shift()));
      if (!relative.host) relative.host = '';
      if (!relative.hostname) relative.hostname = '';
      if (relPath[0] !== '') relPath.unshift('');
      if (relPath.length < 2) relPath.unshift('');
      result.pathname = relPath.join('/');
    } else {
      result.pathname = relative.pathname;
    }
    result.search = relative.search;
    result.query = relative.query;
    result.host = relative.host || '';
    result.auth = relative.auth;
    result.hostname = relative.hostname || relative.host;
    result.port = relative.port;
    // to support http.request
    if (result.pathname || result.search) {
      var p = result.pathname || '';
      var s = result.search || '';
      result.path = p + s;
    }
    result.slashes = result.slashes || relative.slashes;
    result.href = result.format();
    return result;
  }

  var isSourceAbs = (result.pathname && result.pathname.charAt(0) === '/'),
      isRelAbs = (
          relative.host ||
          relative.pathname && relative.pathname.charAt(0) === '/'
      ),
      mustEndAbs = (isRelAbs || isSourceAbs ||
                    (result.host && relative.pathname)),
      removeAllDots = mustEndAbs,
      srcPath = result.pathname && result.pathname.split('/') || [],
      relPath = relative.pathname && relative.pathname.split('/') || [],
      psychotic = result.protocol && !slashedProtocol[result.protocol];

  // if the url is a non-slashed url, then relative
  // links like ../.. should be able
  // to crawl up to the hostname, as well.  This is strange.
  // result.protocol has already been set by now.
  // Later on, put the first path part into the host field.
  if (psychotic) {
    result.hostname = '';
    result.port = null;
    if (result.host) {
      if (srcPath[0] === '') srcPath[0] = result.host;
      else srcPath.unshift(result.host);
    }
    result.host = '';
    if (relative.protocol) {
      relative.hostname = null;
      relative.port = null;
      if (relative.host) {
        if (relPath[0] === '') relPath[0] = relative.host;
        else relPath.unshift(relative.host);
      }
      relative.host = null;
    }
    mustEndAbs = mustEndAbs && (relPath[0] === '' || srcPath[0] === '');
  }

  if (isRelAbs) {
    // it's absolute.
    result.host = (relative.host || relative.host === '') ?
                  relative.host : result.host;
    result.hostname = (relative.hostname || relative.hostname === '') ?
                      relative.hostname : result.hostname;
    result.search = relative.search;
    result.query = relative.query;
    srcPath = relPath;
    // fall through to the dot-handling below.
  } else if (relPath.length) {
    // it's relative
    // throw away the existing file, and take the new path instead.
    if (!srcPath) srcPath = [];
    srcPath.pop();
    srcPath = srcPath.concat(relPath);
    result.search = relative.search;
    result.query = relative.query;
  } else if (!util.isNullOrUndefined(relative.search)) {
    // just pull out the search.
    // like href='?foo'.
    // Put this after the other two cases because it simplifies the booleans
    if (psychotic) {
      result.hostname = result.host = srcPath.shift();
      //occationaly the auth can get stuck only in host
      //this especially happens in cases like
      //url.resolveObject('mailto:local1@domain1', 'local2@domain2')
      var authInHost = result.host && result.host.indexOf('@') > 0 ?
                       result.host.split('@') : false;
      if (authInHost) {
        result.auth = authInHost.shift();
        result.host = result.hostname = authInHost.shift();
      }
    }
    result.search = relative.search;
    result.query = relative.query;
    //to support http.request
    if (!util.isNull(result.pathname) || !util.isNull(result.search)) {
      result.path = (result.pathname ? result.pathname : '') +
                    (result.search ? result.search : '');
    }
    result.href = result.format();
    return result;
  }

  if (!srcPath.length) {
    // no path at all.  easy.
    // we've already handled the other stuff above.
    result.pathname = null;
    //to support http.request
    if (result.search) {
      result.path = '/' + result.search;
    } else {
      result.path = null;
    }
    result.href = result.format();
    return result;
  }

  // if a url ENDs in . or .., then it must get a trailing slash.
  // however, if it ends in anything else non-slashy,
  // then it must NOT get a trailing slash.
  var last = srcPath.slice(-1)[0];
  var hasTrailingSlash = (
      (result.host || relative.host || srcPath.length > 1) &&
      (last === '.' || last === '..') || last === '');

  // strip single dots, resolve double dots to parent dir
  // if the path tries to go above the root, `up` ends up > 0
  var up = 0;
  for (var i = srcPath.length; i >= 0; i--) {
    last = srcPath[i];
    if (last === '.') {
      srcPath.splice(i, 1);
    } else if (last === '..') {
      srcPath.splice(i, 1);
      up++;
    } else if (up) {
      srcPath.splice(i, 1);
      up--;
    }
  }

  // if the path is allowed to go above the root, restore leading ..s
  if (!mustEndAbs && !removeAllDots) {
    for (; up--; up) {
      srcPath.unshift('..');
    }
  }

  if (mustEndAbs && srcPath[0] !== '' &&
      (!srcPath[0] || srcPath[0].charAt(0) !== '/')) {
    srcPath.unshift('');
  }

  if (hasTrailingSlash && (srcPath.join('/').substr(-1) !== '/')) {
    srcPath.push('');
  }

  var isAbsolute = srcPath[0] === '' ||
      (srcPath[0] && srcPath[0].charAt(0) === '/');

  // put the host back
  if (psychotic) {
    result.hostname = result.host = isAbsolute ? '' :
                                    srcPath.length ? srcPath.shift() : '';
    //occationaly the auth can get stuck only in host
    //this especially happens in cases like
    //url.resolveObject('mailto:local1@domain1', 'local2@domain2')
    var authInHost = result.host && result.host.indexOf('@') > 0 ?
                     result.host.split('@') : false;
    if (authInHost) {
      result.auth = authInHost.shift();
      result.host = result.hostname = authInHost.shift();
    }
  }

  mustEndAbs = mustEndAbs || (result.host && srcPath.length);

  if (mustEndAbs && !isAbsolute) {
    srcPath.unshift('');
  }

  if (!srcPath.length) {
    result.pathname = null;
    result.path = null;
  } else {
    result.pathname = srcPath.join('/');
  }

  //to support request.http
  if (!util.isNull(result.pathname) || !util.isNull(result.search)) {
    result.path = (result.pathname ? result.pathname : '') +
                  (result.search ? result.search : '');
  }
  result.auth = relative.auth || result.auth;
  result.slashes = result.slashes || relative.slashes;
  result.href = result.format();
  return result;
};

Url.prototype.parseHost = function() {
  var host = this.host;
  var port = portPattern.exec(host);
  if (port) {
    port = port[0];
    if (port !== ':') {
      this.port = port.substr(1);
    }
    host = host.substr(0, host.length - port.length);
  }
  if (host) this.hostname = host;
};


/***/ }),

/***/ "./node_modules/url/util.js":
/*!**********************************!*\
  !*** ./node_modules/url/util.js ***!
  \**********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


module.exports = {
  isString: function(arg) {
    return typeof(arg) === 'string';
  },
  isObject: function(arg) {
    return typeof(arg) === 'object' && arg !== null;
  },
  isNull: function(arg) {
    return arg === null;
  },
  isNullOrUndefined: function(arg) {
    return arg == null;
  }
};


/***/ }),

/***/ "./node_modules/webpack/buildin/global.js":
/*!***********************************!*\
  !*** (webpack)/buildin/global.js ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var g;

// This works in non-strict mode
g = (function() {
	return this;
})();

try {
	// This works if eval is allowed (see CSP)
	g = g || new Function("return this")();
} catch (e) {
	// This works if the window reference is available
	if (true) g = window;
}

// g can still be undefined, but nothing to do about it...
// We return undefined, instead of nothing here, so it's
// easier to handle this case. if(!global) { ...}

module.exports = g;


/***/ }),

/***/ "./node_modules/webpack/buildin/module.js":
/*!***********************************!*\
  !*** (webpack)/buildin/module.js ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = function(module) {
	if (!module.webpackPolyfill) {
		module.deprecate = function() {};
		module.paths = [];
		// module.parent = undefined by default
		if (!module.children) module.children = [];
		Object.defineProperty(module, "loaded", {
			enumerable: true,
			get: function() {
				return module.l;
			}
		});
		Object.defineProperty(module, "id", {
			enumerable: true,
			get: function() {
				return module.i;
			}
		});
		module.webpackPolyfill = 1;
	}
	return module;
};


/***/ }),

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
/* harmony import */ var _components_ProductOptionsController__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ../components/ProductOptionsController */ "./components/ProductOptionsController.jsx");

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
      lineNumber: 30
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Nav__WEBPACK_IMPORTED_MODULE_3__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 31
    },
    __self: this
  }), isLoading === false && currentProduct && react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-page-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 34
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Breadcumb__WEBPACK_IMPORTED_MODULE_7__["default"], {
    paths: [currentProduct.category, currentProduct.name],
    __source: {
      fileName: _jsxFileName,
      lineNumber: 35
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_TitleWithFloater__WEBPACK_IMPORTED_MODULE_9__["default"], {
    label: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 36
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
      lineNumber: 37
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("div", {
    className: "product-display-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 42
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement("img", {
    className: "image",
    src: currentProduct.image,
    alt: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 43
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_ProductOptionsController__WEBPACK_IMPORTED_MODULE_13__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 48
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Description__WEBPACK_IMPORTED_MODULE_11__["default"], {
    text: currentProduct.description,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 51
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Button__WEBPACK_IMPORTED_MODULE_12__["default"], {
    label: "Adicionar ao carrinho",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 52
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_1___default.a.createElement(_components_Footer__WEBPACK_IMPORTED_MODULE_6__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 55
    },
    __self: this
  }));
}

/* harmony default export */ __webpack_exports__["default"] = (product);

/***/ }),

/***/ "./services/api.js":
/*!*************************!*\
  !*** ./services/api.js ***!
  \*************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var axios__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! axios */ "./node_modules/axios/index.js");
/* harmony import */ var axios__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(axios__WEBPACK_IMPORTED_MODULE_0__);

var api = axios__WEBPACK_IMPORTED_MODULE_0___default.a.create({
  baseURL: 'http://localhost:5000/api/',
  headers: {
    Authorization: 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMCIsImVtYWlsIjoiYWRtaW5Ac2ltcGxjb21tZXJjZS5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsIm5iZiI6MTU2Njc1NDUxNiwiZXhwIjoxNTY2NzU2MzE2LCJpc3MiOiJTaW1wbENvbW1lcmNlIiwiYXVkIjoiQW55b25lIn0.QSQ0fDOyZIDGDoVxdmjn_yEsk32FjRTgPKTXfR1rXq4'
  }
});
/* harmony default export */ __webpack_exports__["default"] = (api);

/***/ }),

/***/ "./static/assets/icons/favorite.svg":
/*!******************************************!*\
  !*** ./static/assets/icons/favorite.svg ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjMiIGhlaWdodD0iMjMiIHZpZXdCb3g9IjAgMCAyMyAyMyIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0xMiAxOC44NDc2TDExLjI0MTMgMTguMDU0NEwxMS4yMzA3IDE4LjA0MzNMMTEuMjE5NSAxOC4wMzI5QzkuMTMxNDIgMTYuMTAxOCA3LjQ0MzY3IDE0LjUxOTkgNi4yNzMwNyAxMy4wMzFDNS4xMDg3MSAxMS41NDk5IDQuNSAxMC4yMTQ0IDQuNSA4Ljc4MTgyQzQuNSA2LjQ0NDA1IDYuMjE2ODYgNC42ODE4MiA4LjQgNC42ODE4MkM5LjYwMjA3IDQuNjgxODIgMTAuODIxOCA1LjI3NzE4IDExLjYxMTMgNi4yNTI3NEwxMiA2LjczMjk0TDEyLjM4ODcgNi4yNTI3NEMxMy4xNzgyIDUuMjc3MTggMTQuMzk3OSA0LjY4MTgyIDE1LjYgNC42ODE4MkMxNy43ODMxIDQuNjgxODIgMTkuNSA2LjQ0NDA1IDE5LjUgOC43ODE4MkMxOS41IDEwLjIxNDQgMTguODkxMyAxMS41NDk5IDE3LjcyNjkgMTMuMDMxQzE2LjU1NjMgMTQuNTE5OSAxNC44Njg2IDE2LjEwMTggMTIuNzgwNSAxOC4wMzI5TDEyLjc2OTMgMTguMDQzM0wxMi43NTg3IDE4LjA1NDRMMTIgMTguODQ3NloiIHN0cm9rZT0iYmxhY2siLz4NCjwvc3ZnPg0K"

/***/ }),

/***/ "./static/assets/icons/favorited.svg":
/*!*******************************************!*\
  !*** ./static/assets/icons/favorited.svg ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjMiIGhlaWdodD0iMjMiIHZpZXdCb3g9IjAgMCAyMyAyMyIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0xMiAxOC44NDc2TDExLjI0MTMgMTguMDU0NEwxMS4yMzA3IDE4LjA0MzNMMTEuMjE5NSAxOC4wMzI5QzkuMTMxNDIgMTYuMTAxOCA3LjQ0MzY3IDE0LjUxOTkgNi4yNzMwNyAxMy4wMzFDNS4xMDg3MSAxMS41NDk5IDQuNSAxMC4yMTQ0IDQuNSA4Ljc4MTgyQzQuNSA2LjQ0NDA1IDYuMjE2ODYgNC42ODE4MiA4LjQgNC42ODE4MkM5LjYwMjA3IDQuNjgxODIgMTAuODIxOCA1LjI3NzE4IDExLjYxMTMgNi4yNTI3NEwxMiA2LjczMjk0TDEyLjM4ODcgNi4yNTI3NEMxMy4xNzgyIDUuMjc3MTggMTQuMzk3OSA0LjY4MTgyIDE1LjYgNC42ODE4MkMxNy43ODMxIDQuNjgxODIgMTkuNSA2LjQ0NDA1IDE5LjUgOC43ODE4MkMxOS41IDEwLjIxNDQgMTguODkxMyAxMS41NDk5IDE3LjcyNjkgMTMuMDMxQzE2LjU1NjMgMTQuNTE5OSAxNC44Njg2IDE2LjEwMTggMTIuNzgwNSAxOC4wMzI5TDEyLjc2OTMgMTguMDQzM0wxMi43NTg3IDE4LjA1NDRMMTIgMTguODQ3NloiIGZpbGw9IiNERjM2MkIiIHN0cm9rZT0iYmxhY2siLz4NCjwvc3ZnPg0K"

/***/ }),

/***/ "./static/assets/icons/hamburguerCloseMenu.svg":
/*!*****************************************************!*\
  !*** ./static/assets/icons/hamburguerCloseMenu.svg ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNDUiIGhlaWdodD0iNDUiIHZpZXdCb3g9IjAgMCA0NSA0NSIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxyZWN0IHk9IjIyLjYxMzYiIHdpZHRoPSIzMS44MjAyIiBoZWlnaHQ9IjMxLjgyMDIiIHRyYW5zZm9ybT0icm90YXRlKC00NS4yODkxIDAgMjIuNjEzNikiIGZpbGw9IndoaXRlIi8+DQo8bGluZSB4MT0iMTYuODU0MyIgeTE9IjI3LjkyOTEiIHgyPSIyOS44NzQ2IiB5Mj0iMTYuNTUwOSIgc3Ryb2tlPSJibGFjayIgc3Ryb2tlLXdpZHRoPSIyIi8+DQo8bGluZSB4MT0iMTYuOTQyOCIgeTE9IjE1LjgyOTUiIHgyPSIyOC40OTI2IiB5Mj0iMjguNjk3OSIgc3Ryb2tlPSJibGFjayIgc3Ryb2tlLXdpZHRoPSIyIi8+DQo8L3N2Zz4NCg=="

/***/ }),

/***/ "./static/assets/icons/hamburguerMenu.svg":
/*!************************************************!*\
  !*** ./static/assets/icons/hamburguerMenu.svg ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNDUiIGhlaWdodD0iNDUiIHZpZXdCb3g9IjAgMCA0NSA0NSIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxyZWN0IHk9IjIyLjYxMzYiIHdpZHRoPSIzMS44MjAyIiBoZWlnaHQ9IjMxLjgyMDIiIHRyYW5zZm9ybT0icm90YXRlKC00NS4yODkxIDAgMjIuNjEzNikiIGZpbGw9IndoaXRlIi8+DQo8cGF0aCBkPSJNMzAuNDYxNiAyNy45MjMxSDE0LjIxNTRNMzAuNDYxNiAyMi4zMzg1SDE0LjIxNTRNMzAuNDYxNiAxNi4yNDYySDE0LjIxNTQiIHN0cm9rZT0iYmxhY2siIHN0cm9rZS13aWR0aD0iMiIvPg0KPC9zdmc+DQo="

/***/ }),

/***/ "./static/assets/icons/menuToggleArrow.svg":
/*!*************************************************!*\
  !*** ./static/assets/icons/menuToggleArrow.svg ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjEiIGhlaWdodD0iMTIiIHZpZXdCb3g9IjAgMCAyMSAxMiIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0xIDFMMTAuNSAxMC41TDIwIDEiIHN0cm9rZT0iYmxhY2siLz4NCjwvc3ZnPg0K"

/***/ }),

/***/ "./static/assets/icons/payments.svg":
/*!******************************************!*\
  !*** ./static/assets/icons/payments.svg ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/_next/static/images/payments-01c8cb2e477ee742a9b441942da5b2d8.svg";

/***/ }),

/***/ "./static/assets/icons/search.svg":
/*!****************************************!*\
  !*** ./static/assets/icons/search.svg ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjIiIGhlaWdodD0iMjIiIHZpZXdCb3g9IjAgMCAyMiAyMiIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0yMC44NDA4IDE5Ljk1NDlMMTUuNzMwOCAxNC44NDVDMTcuMTAxNiAxMy4yNjkxIDE3LjkzMTUgMTEuMjEzIDE3LjkzMTUgOC45NjU3NEMxNy45MzE1IDQuMDE4OTYgMTMuOTA3OCAwIDguOTY1NzQgMEM0LjAxODk2IDAgMCA0LjAyMzYyIDAgOC45NjU3NEMwIDEzLjkwNzggNC4wMjM2MiAxNy45MzE1IDguOTY1NzQgMTcuOTMxNUMxMS4yMTMgMTcuOTMxNSAxMy4yNjkxIDE3LjEwMTYgMTQuODQ1IDE1LjczMDhMMTkuOTU0OSAyMC44NDA4QzIwLjA3NjIgMjAuOTYyIDIwLjIzOTMgMjEuMDI3MyAyMC4zOTc5IDIxLjAyNzNDMjAuNTU2NCAyMS4wMjczIDIwLjcxOTYgMjAuOTY2NyAyMC44NDA4IDIwLjg0MDhDMjEuMDgzMiAyMC41OTgzIDIxLjA4MzIgMjAuMTk3NCAyMC44NDA4IDE5Ljk1NDlaTTEuMjU0MTggOC45NjU3NEMxLjI1NDE4IDQuNzEzNjYgNC43MTM2NSAxLjI1ODg0IDguOTYxMDcgMS4yNTg4NEMxMy4yMTMyIDEuMjU4ODQgMTYuNjY4IDQuNzE4MzIgMTYuNjY4IDguOTY1NzRDMTYuNjY4IDEzLjIxMzIgMTMuMjEzMiAxNi42NzczIDguOTYxMDcgMTYuNjc3M0M0LjcxMzY1IDE2LjY3NzMgMS4yNTQxOCAxMy4yMTc4IDEuMjU0MTggOC45NjU3NFoiIGZpbGw9ImJsYWNrIi8+DQo8L3N2Zz4NCg=="

/***/ }),

/***/ "./static/assets/icons/shoppingCart.svg":
/*!**********************************************!*\
  !*** ./static/assets/icons/shoppingCart.svg ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNDUiIGhlaWdodD0iNDUiIHZpZXdCb3g9IjAgMCA0NSA0NSIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxyZWN0IHk9IjIyLjI3MDkiIHdpZHRoPSIzMS4zMzgxIiBoZWlnaHQ9IjMxLjMzODEiIHRyYW5zZm9ybT0icm90YXRlKC00NS4yODkxIDAgMjIuMjcwOSkiIGZpbGw9IndoaXRlIi8+DQo8cGF0aCBkPSJNMTcuNzk5NCAyNC42MzY5SDE3LjgwMDJDMTcuODAwOSAyNC42MzY5IDE3LjgwMTYgMjQuNjM2NyAxNy44MDIzIDI0LjYzNjdIMjcuMzYzM0MyNy41OTg3IDI0LjYzNjcgMjcuODA1NiAyNC40ODA2IDI3Ljg3MDMgMjQuMjU0M0wyOS45Nzk3IDE2Ljg3MTRDMzAuMDI1MSAxNi43MTIzIDI5Ljk5MzMgMTYuNTQxMiAyOS44OTM3IDE2LjQwOTFDMjkuNzk0IDE2LjI3NjkgMjkuNjM4MSAxNi4xOTkyIDI5LjQ3MjcgMTYuMTk5MkgxNi41ODMyTDE2LjIwNjMgMTQuNTAyOEMxNi4xNTI2IDE0LjI2MTUgMTUuOTM4NiAxNC4wODk4IDE1LjY5MTQgMTQuMDg5OEgxMi41MjczQzEyLjIzNjEgMTQuMDg5OCAxMiAxNC4zMjU5IDEyIDE0LjYxNzJDMTIgMTQuOTA4NSAxMi4yMzYxIDE1LjE0NDUgMTIuNTI3MyAxNS4xNDQ1SDE1LjI2ODRDMTUuMzM1MiAxNS40NDUxIDE3LjA3MjQgMjMuMjYyNyAxNy4xNzI0IDIzLjcxMjVDMTYuNjExOSAyMy45NTYxIDE2LjIxODggMjQuNTE0OSAxNi4yMTg4IDI1LjE2NDFDMTYuMjE4OCAyNi4wMzY0IDE2LjkyODUgMjYuNzQ2MSAxNy44MDA4IDI2Ljc0NjFIMjcuMzYzM0MyNy42NTQ2IDI2Ljc0NjEgMjcuODkwNiAyNi41MSAyNy44OTA2IDI2LjIxODhDMjcuODkwNiAyNS45Mjc1IDI3LjY1NDYgMjUuNjkxNCAyNy4zNjMzIDI1LjY5MTRIMTcuODAwOEMxNy41MTAxIDI1LjY5MTQgMTcuMjczNCAyNS40NTQ4IDE3LjI3MzQgMjUuMTY0MUMxNy4yNzM0IDI0Ljg3MzggMTcuNTA5MiAyNC42Mzc1IDE3Ljc5OTQgMjQuNjM2OVpNMjguNzczNSAxNy4yNTM5TDI2Ljk2NTQgMjMuNTgySDE4LjIyMzhMMTYuODE3NSAxNy4yNTM5SDI4Ljc3MzVaIiBmaWxsPSJibGFjayIvPg0KPHBhdGggZD0iTTE3LjI3MzQgMjguMzI4MUMxNy4yNzM0IDI5LjIwMDQgMTcuOTgzMiAyOS45MTAyIDE4Ljg1NTUgMjkuOTEwMkMxOS43Mjc4IDI5LjkxMDIgMjAuNDM3NSAyOS4yMDA0IDIwLjQzNzUgMjguMzI4MUMyMC40Mzc1IDI3LjQ1NTggMTkuNzI3OCAyNi43NDYxIDE4Ljg1NTUgMjYuNzQ2MUMxNy45ODMyIDI2Ljc0NjEgMTcuMjczNCAyNy40NTU4IDE3LjI3MzQgMjguMzI4MVpNMTguODU1NSAyNy44MDA4QzE5LjE0NjIgMjcuODAwOCAxOS4zODI4IDI4LjAzNzQgMTkuMzgyOCAyOC4zMjgxQzE5LjM4MjggMjguNjE4OSAxOS4xNDYyIDI4Ljg1NTUgMTguODU1NSAyOC44NTU1QzE4LjU2NDcgMjguODU1NSAxOC4zMjgxIDI4LjYxODkgMTguMzI4MSAyOC4zMjgxQzE4LjMyODEgMjguMDM3NCAxOC41NjQ3IDI3LjgwMDggMTguODU1NSAyNy44MDA4WiIgZmlsbD0iYmxhY2siLz4NCjxwYXRoIGQ9Ik0yNC43MjY2IDI4LjMyODFDMjQuNzI2NiAyOS4yMDA0IDI1LjQzNjMgMjkuOTEwMiAyNi4zMDg2IDI5LjkxMDJDMjcuMTgwOSAyOS45MTAyIDI3Ljg5MDYgMjkuMjAwNCAyNy44OTA2IDI4LjMyODFDMjcuODkwNiAyNy40NTU4IDI3LjE4MDkgMjYuNzQ2MSAyNi4zMDg2IDI2Ljc0NjFDMjUuNDM2MyAyNi43NDYxIDI0LjcyNjYgMjcuNDU1OCAyNC43MjY2IDI4LjMyODFaTTI2LjMwODYgMjcuODAwOEMyNi41OTkzIDI3LjgwMDggMjYuODM1OSAyOC4wMzc0IDI2LjgzNTkgMjguMzI4MUMyNi44MzU5IDI4LjYxODkgMjYuNTk5MyAyOC44NTU1IDI2LjMwODYgMjguODU1NUMyNi4wMTc5IDI4Ljg1NTUgMjUuNzgxMiAyOC42MTg5IDI1Ljc4MTIgMjguMzI4MUMyNS43ODEyIDI4LjAzNzQgMjYuMDE3OSAyNy44MDA4IDI2LjMwODYgMjcuODAwOFoiIGZpbGw9ImJsYWNrIi8+DQo8L3N2Zz4NCiA="

/***/ }),

/***/ "./static/assets/logo.svg":
/*!********************************!*\
  !*** ./static/assets/logo.svg ***!
  \********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMTU3IiBoZWlnaHQ9IjI5IiB2aWV3Qm94PSIwIDAgMTU3IDI5IiBmaWxsPSJub25lIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciPg0KPHBhdGggZD0iTTIxLjI2OTIgMjQuNDlDMjMuMjQ1MiAyMi41MTQgMjQuMzUwMiAxOS40MiAyNC41ODQyIDE1LjIwOEwyNS4zNjQyIDAuNjk5OTk4SDI4Ljg3NDJMMjguMDk0MiAxNS4zNjRDMjcuOTEyMiAxOC43OTYgMjcuMzAxMiAyMS41MjYgMjYuMjYxMiAyMy41NTRDMjUuMjQ3MiAyNS41ODIgMjMuNTU3MiAyNy4zMjQgMjEuMTkxMiAyOC43OEMxOS4xMTEyIDI3LjI5OCAxNy42NjgyIDI1LjQ3OCAxNi44NjIyIDIzLjMyQzE2LjA1NjIgMjEuMTM2IDE1LjQzMjIgMTguMTg1IDE0Ljk5MDIgMTQuNDY3SDE0LjgzNDJDMTQuNjI2MiAxOC4zNDEgMTQuMTE5MiAyMS4yMjcgMTMuMzEzMiAyMy4xMjVDMTIuNTMzMiAyNS4wMjMgMTAuOTczMiAyNi45MDggOC42MzMxOCAyOC43OEM2LjI2NzE4IDI3LjMyNCA0LjU2NDE4IDI1LjU4MiAzLjUyNDE4IDIzLjU1NEMyLjUxMDE4IDIxLjUyNiAxLjkxMjE4IDE4Ljc5NiAxLjczMDE4IDE1LjM2NEwwLjk1MDE3NiAwLjY5OTk5OEg0LjQ2MDE4TDUuMjQwMTggMTUuMjA4QzUuNDc0MTggMTkuNDIgNi41NzkxOCAyMi41MTQgOC41NTUxOCAyNC40OUM5LjgyOTE4IDIzLjM5OCAxMC43NzgyIDIxLjc3MyAxMS40MDIyIDE5LjYxNUMxMi4wMjYyIDE3LjQzMSAxMi42MTEyIDEzLjk4NiAxMy4xNTcyIDkuMjhIMTYuNjY3MkMxNy4zOTUyIDEzLjMzNiAxOC4wNTgyIDE2LjQ4MiAxOC42NTYyIDE4LjcxOEMxOS4yNTQyIDIwLjk1NCAxOS43MDkyIDIyLjM3MSAyMC4wMjEyIDIyLjk2OUMyMC4zNTkyIDIzLjU2NyAyMC43NzUyIDI0LjA3NCAyMS4yNjkyIDI0LjQ5Wk0zOC40MzU5IDI4SDM1LjAwMzlWMTIuNTU2SDMxLjgwNTlMMzMuMzY1OSA5LjI4SDM4LjQzNTlWMjhaTTM0Ljg0NzkgNS4zOEMzNC41MDk5IDQuOTM4IDM0LjM0MDkgNC40NTcgMzQuMzQwOSAzLjkzN0MzNC4zNDA5IDMuNDE3IDM0LjUwOTkgMi45NDkgMzQuODQ3OSAyLjUzM0MzNS4xODU5IDIuMDkxIDM1LjcwNTkgMS44NyAzNi40MDc5IDEuODdDMzcuMTA5OSAxLjg3IDM3LjYyOTkgMi4wOTEgMzcuOTY3OSAyLjUzM0MzOC4zMDU5IDIuOTQ5IDM4LjQ3NDkgMy40MTcgMzguNDc0OSAzLjkzN0MzOC40NzQ5IDQuNDU3IDM4LjMwNTkgNC45MzggMzcuOTY3OSA1LjM4QzM3LjYyOTkgNS43OTYgMzcuMTA5OSA2LjAwNCAzNi40MDc5IDYuMDA0QzM1LjcwNTkgNi4wMDQgMzUuMTg1OSA1Ljc5NiAzNC44NDc5IDUuMzhaTTQxLjY5OTEgMTIuNTU2TDQ4LjY4MDEgNS41NzVWOS4yOEg1My45NDUxVjEyLjU1Nkg0OC42ODAxVjIwLjU5QzQ4LjY4MDEgMjEuNSA0OC44MjMxIDIyLjI1NCA0OS4xMDkxIDIyLjg1MkM0OS40MjExIDIzLjQ1IDQ5Ljg2MzEgMjMuODc5IDUwLjQzNTEgMjQuMTM5QzUxLjAwNzEgMjQuMzczIDUxLjU0MDEgMjQuNTI5IDUyLjAzNDEgMjQuNjA3QzUyLjU1NDEgMjQuNjg1IDUzLjE5MTEgMjQuNzI0IDUzLjk0NTEgMjQuNzI0VjI4QzUwLjk1NTEgMjggNDguNzQ1MSAyNy40MjggNDcuMzE1MSAyNi4yODRDNDUuODg1MSAyNS4xNCA0NS4xNzAxIDIzLjI0MiA0NS4xNzAxIDIwLjU5VjEyLjU1Nkg0MS42OTkxWk01NS43MTQ3IDEyLjU1Nkw2Mi42OTU3IDUuNTc1VjkuMjhINjcuOTYwN1YxMi41NTZINjIuNjk1N1YyMC41OUM2Mi42OTU3IDIxLjUgNjIuODM4NyAyMi4yNTQgNjMuMTI0NyAyMi44NTJDNjMuNDM2NyAyMy40NSA2My44Nzg3IDIzLjg3OSA2NC40NTA3IDI0LjEzOUM2NS4wMjI3IDI0LjM3MyA2NS41NTU3IDI0LjUyOSA2Ni4wNDk3IDI0LjYwN0M2Ni41Njk3IDI0LjY4NSA2Ny4yMDY3IDI0LjcyNCA2Ny45NjA3IDI0LjcyNFYyOEM2NC45NzA3IDI4IDYyLjc2MDcgMjcuNDI4IDYxLjMzMDcgMjYuMjg0QzU5LjkwMDcgMjUuMTQgNTkuMTg1NyAyMy4yNDIgNTkuMTg1NyAyMC41OVYxMi41NTZINTUuNzE0N1pNNzUuMTEyMyAwLjY5OTk5OFY5LjI4SDc4LjQyNzNDODEuMzEzMyA5LjI4IDgzLjM4MDMgOS43MDkgODQuNjI4MyAxMC41NjdDODUuNzQ2MyAxMS4zMjEgODYuNDQ4MyAxMi4yMzEgODYuNzM0MyAxMy4yOTdDODcuMDQ2MyAxNC4zMzcgODcuMjAyMyAxNS43MTUgODcuMjAyMyAxNy40MzFWMjhIODMuNzcwM1YxNy40N0M4My43NzAzIDE3LjAwMiA4My43NTczIDE2LjYxMiA4My43MzEzIDE2LjNDODMuNzA1MyAxNS45NjIgODMuNjE0MyAxNS41NDYgODMuNDU4MyAxNS4wNTJDODMuMzAyMyAxNC41MzIgODMuMDgxMyAxNC4xMTYgODIuNzk1MyAxMy44MDRDODIuNTA5MyAxMy40NjYgODIuMDkzMyAxMy4xOCA4MS41NDczIDEyLjk0NkM4MS4wMDEzIDEyLjY4NiA4MC4zMzgzIDEyLjU1NiA3OS41NTgzIDEyLjU1Nkg3NS4xMTIzVjI4SDcxLjY4MDNWMC42OTk5OThINzUuMTEyM1pNOTQuMDEwOSAxMS43MzdDOTUuODMwOSA5LjgzOSA5OC4xMDU5IDguODkgMTAwLjgzNiA4Ljg5QzEwMi4xNjIgOC44OSAxMDMuMzk3IDkuMTUgMTA0LjU0MSA5LjY3QzEwNS43MTEgMTAuMTY0IDEwNi43MjUgMTAuODUzIDEwNy41ODMgMTEuNzM3QzEwOC40NjcgMTIuNjIxIDEwOS4xNTYgMTMuNjYxIDEwOS42NSAxNC44NTdDMTEwLjE0NCAxNi4wMjcgMTEwLjM5MSAxNy4yODggMTEwLjM5MSAxOC42NEMxMTAuMzkxIDE5Ljk5MiAxMTAuMTQ0IDIxLjI2NiAxMDkuNjUgMjIuNDYyQzEwOS4xODIgMjMuNjMyIDEwOC41MTkgMjQuNjU5IDEwNy42NjEgMjUuNTQzQzEwNi44MDMgMjYuNDI3IDEwNS43ODkgMjcuMTI5IDEwNC42MTkgMjcuNjQ5QzEwMy40NDkgMjguMTQzIDEwMi4xODggMjguMzkgMTAwLjgzNiAyOC4zOUM5OS40NTc5IDI4LjM5IDk4LjE4MzkgMjguMTQzIDk3LjAxMzkgMjcuNjQ5Qzk1Ljg2OTkgMjcuMTI5IDk0Ljg2ODkgMjYuNDI3IDk0LjAxMDkgMjUuNTQzQzkzLjE1MjkgMjQuNjU5IDkyLjQ3NjkgMjMuNjMyIDkxLjk4MjkgMjIuNDYyQzkxLjUxNDkgMjEuMjY2IDkxLjI4MDkgMTkuOTkyIDkxLjI4MDkgMTguNjRDOTEuMjgwOSAxNS44ODQgOTIuMTkwOSAxMy41ODMgOTQuMDEwOSAxMS43MzdaTTEwMC44MzYgMTIuMTY2Qzk5LjAxNTkgMTIuMTY2IDk3LjU0NjkgMTIuNzY0IDk2LjQyODkgMTMuOTZDOTUuMzM2OSAxNS4xNTYgOTQuNzkwOSAxNi43MTYgOTQuNzkwOSAxOC42NEM5NC43OTA5IDIwLjU2NCA5NS4zMzY5IDIyLjEyNCA5Ni40Mjg5IDIzLjMyQzk3LjU0NjkgMjQuNTE2IDk5LjAxNTkgMjUuMTE0IDEwMC44MzYgMjUuMTE0QzEwMi42ODIgMjUuMTE0IDEwNC4xNTEgMjQuNTE2IDEwNS4yNDMgMjMuMzJDMTA2LjMzNSAyMi4wOTggMTA2Ljg4MSAyMC41MzggMTA2Ljg4MSAxOC42NEMxMDYuODgxIDE2Ljc0MiAxMDYuMzM1IDE1LjE5NSAxMDUuMjQzIDEzLjk5OUMxMDQuMTUxIDEyLjc3NyAxMDIuNjgyIDEyLjE2NiAxMDAuODM2IDEyLjE2NlpNMTIzLjY1NCA4Ljg5QzEyOC4wNzQgOS4wNzIgMTMwLjI4NCAxMC45MDUgMTMwLjI4NCAxNC4zODlDMTMwLjI4NCAxOC43MzEgMTI3LjQzNyAyMC45MDIgMTIxLjc0MyAyMC45MDJIMTIwLjE0NFYxNy44OTlIMTIyLjAxNkMxMjMuNzU4IDE3Ljg5OSAxMjQuOTY3IDE3LjYzOSAxMjUuNjQzIDE3LjExOUMxMjYuMzE5IDE2LjU3MyAxMjYuNjU3IDE1LjY3NiAxMjYuNjU3IDE0LjQyOEMxMjYuNjU3IDEzLjYyMiAxMjYuMzU4IDEzLjAyNCAxMjUuNzYgMTIuNjM0QzEyNS4xNjIgMTIuMjE4IDEyNC4zOTUgMTIuMDEgMTIzLjQ1OSAxMi4wMUMxMjEuNjEzIDEyLjAxIDEyMC4xNTcgMTIuNjYgMTE5LjA5MSAxMy45NkMxMTguMDUxIDE1LjI2IDExNy41MzEgMTYuODIgMTE3LjUzMSAxOC42NEMxMTcuNTMxIDIwLjU2NCAxMTguMDkgMjIuMTI0IDExOS4yMDggMjMuMzJDMTIwLjM1MiAyNC41MTYgMTIxLjgzNCAyNS4xMTQgMTIzLjY1NCAyNS4xMTRDMTI1LjI5MiAyNS4xMTQgMTI2LjYzMSAyNC43MTEgMTI3LjY3MSAyMy45MDVMMTMwLjAxMSAyNi4yMDZDMTI4LjIxNyAyNy42NjIgMTI2LjA5OCAyOC4zOSAxMjMuNjU0IDI4LjM5QzEyMC42OSAyOC4zOSAxMTguMzI0IDI3LjUxOSAxMTYuNTU2IDI1Ljc3N0MxMTQuNzg4IDI0LjAzNSAxMTMuOTA0IDIxLjc4NiAxMTMuOTA0IDE5LjAzQzExMy45MDQgMTUuOTYyIDExNC43NzUgMTMuNDc5IDExNi41MTcgMTEuNTgxQzExOC4yNTkgOS42ODMgMTIwLjYzOCA4Ljc4NiAxMjMuNjU0IDguODlaTTE0My4zODMgMTIuNTU2SDEzOC44OThWMjhIMTM1LjM4OFYxMi41NTZIMTMyLjczNkwxMzQuMjk2IDkuMjhIMTM1LjM4OEMxMzUuMzg4IDYuNjI4IDEzNi4yODUgNC41MzUgMTM4LjA3OSAzLjAwMUMxMzkuODczIDEuNDQxIDE0Mi4xNjEgMC42NjA5OTkgMTQ0Ljk0MyAwLjY2MDk5OVYzLjkzN0MxNDAuOTEzIDMuOTM3IDEzOC44OTggNS43MTggMTM4Ljg5OCA5LjI4SDE0My4zODNWMTIuNTU2Wk0xNDQuNTY5IDEyLjU1NkwxNTEuNTUgNS41NzVWOS4yOEgxNTYuODE1VjEyLjU1NkgxNTEuNTVWMjAuNTlDMTUxLjU1IDIxLjUgMTUxLjY5MyAyMi4yNTQgMTUxLjk3OSAyMi44NTJDMTUyLjI5MSAyMy40NSAxNTIuNzMzIDIzLjg3OSAxNTMuMzA1IDI0LjEzOUMxNTMuODc3IDI0LjM3MyAxNTQuNDEgMjQuNTI5IDE1NC45MDQgMjQuNjA3QzE1NS40MjQgMjQuNjg1IDE1Ni4wNjEgMjQuNzI0IDE1Ni44MTUgMjQuNzI0VjI4QzE1My44MjUgMjggMTUxLjYxNSAyNy40MjggMTUwLjE4NSAyNi4yODRDMTQ4Ljc1NSAyNS4xNCAxNDguMDQgMjMuMjQyIDE0OC4wNCAyMC41OVYxMi41NTZIMTQ0LjU2OVoiIGZpbGw9IndoaXRlIi8+DQo8L3N2Zz4NCg=="

/***/ }),

/***/ "./static/consts/menuItems.js":
/*!************************************!*\
  !*** ./static/consts/menuItems.js ***!
  \************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ([{
  label: "Entrar",
  link: "login"
}, {
  label: 'Produtos',
  prefix: 'produtos',
  subItems: [{
    label: "Camisetas"
  }, {
    label: "Bermudas"
  }, {
    label: "Acessorios"
  }]
}, {
  label: 'Contato',
  link: 'contato'
}]);

/***/ }),

/***/ 2:
/*!*************************************************************************************************************************************************************!*\
  !*** multi next-client-pages-loader?page=%2Fproduct&absolutePagePath=C%3A%5CUsers%5CDanilo%5CDocuments%5CGitHub%5CWithoffStore%5CWeb%5Cpages%5Cproduct.jsx ***!
  \*************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! next-client-pages-loader?page=%2Fproduct&absolutePagePath=C%3A%5CUsers%5CDanilo%5CDocuments%5CGitHub%5CWithoffStore%5CWeb%5Cpages%5Cproduct.jsx! */"./node_modules/next/dist/build/webpack/loaders/next-client-pages-loader.js?page=%2Fproduct&absolutePagePath=C%3A%5CUsers%5CDanilo%5CDocuments%5CGitHub%5CWithoffStore%5CWeb%5Cpages%5Cproduct.jsx!./");


/***/ }),

/***/ "dll-reference dll_01f9a3fa864a7b7414d8":
/*!*******************************************!*\
  !*** external "dll_01f9a3fa864a7b7414d8" ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = dll_01f9a3fa864a7b7414d8;

/***/ })

},[[2,"static/runtime/webpack.js","styles"]]]);
//# sourceMappingURL=product.js.map