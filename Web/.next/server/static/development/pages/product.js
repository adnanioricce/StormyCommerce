module.exports =
/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = require('../../../ssr-module-cache.js');
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		var threw = true;
/******/ 		try {
/******/ 			modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/ 			threw = false;
/******/ 		} finally {
/******/ 			if(threw) delete installedModules[moduleId];
/******/ 		}
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = 4);
/******/ })
/************************************************************************/
/******/ ({

/***/ "./components/Breadcumb.jsx":
/*!**********************************!*\
  !*** ./components/Breadcumb.jsx ***!
  \**********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Breadcumb.jsx";


function Breadcumb({
  paths = []
}) {
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "breadcumb",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: this
  }, ['Loja', ...paths].reduce((arr, element, index, array) => {
    return index >= array.length - 1 ? [...arr, element] : [...arr, element, '/'];
  }, []).map((e, index) => {
    return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("p", {
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");


var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Button.jsx";


function Button(_ref) {
  let {
    label,
    type = 'primary'
  } = _ref,
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var react_use__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react-use */ "react-use");
/* harmony import */ var react_use__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react_use__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");
/* harmony import */ var _Title__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./Title */ "./components/Title.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ColorSelector.jsx";





function ColorSelector({
  options,
  activeColor,
  setActiveColor
}) {
  const [isPopupActive, setIsPopupActive] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState(false);
  react__WEBPACK_IMPORTED_MODULE_0___default.a.useEffect(() => {
    if (isPopupActive && window) {
      window.document.body.style.overflow = 'hidden';
    } else if (window) {
      window.document.body.style.overflow = 'auto';
    }
  }, [isPopupActive]);
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(react__WEBPACK_IMPORTED_MODULE_0___default.a.Fragment, null, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(ColorPopup, {
    state: [isPopupActive, setIsPopupActive, activeColor, setActiveColor],
    options: options,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 17
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_Title__WEBPACK_IMPORTED_MODULE_3__["default"], {
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
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_2__["default"], {
    className: "color-selector",
    style: {
      backgroundColor: activeColor
    },
    tag: "div",
    onClick: () => {
      setIsPopupActive(true);
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 22
    },
    __self: this
  }));
}

const ColorPopup = ({
  state,
  options
}) => {
  const [isPopupActive, setIsPopupActive, activeColor, setActiveColor] = state;
  const popupRef = react__WEBPACK_IMPORTED_MODULE_0___default.a.useRef(null);
  Object(react_use__WEBPACK_IMPORTED_MODULE_1__["useClickAway"])(popupRef, () => {
    setIsPopupActive(false);
  });
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
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
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "color-popup",
    ref: popupRef,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 48
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "color-popup-header",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 49
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_Title__WEBPACK_IMPORTED_MODULE_3__["default"], {
    label: "Selecione uma cor",
    style: {
      color: 'white',
      fontSize: 10
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 50
    },
    __self: undefined
  })), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "color-popup-body",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 55
    },
    __self: undefined
  }, options.map(({
    value,
    color
  }, index) => {
    const handleColorClick = () => {
      setActiveColor(value);
      setIsPopupActive(false);
    };

    return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_2__["default"], {
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
      __self: undefined
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Description.jsx";

/* harmony default export */ __webpack_exports__["default"] = (({
  text,
  style
}) => react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
  className: "description",
  style: style,
  __source: {
    fileName: _jsxFileName,
    lineNumber: 4
  },
  __self: undefined
}, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 5
  },
  __self: undefined
}, text)));

/***/ }),

/***/ "./components/FavoriteFloater.jsx":
/*!****************************************!*\
  !*** ./components/FavoriteFloater.jsx ***!
  \****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/assets/icons/favorited.svg */ "./static/assets/icons/favorited.svg");
/* harmony import */ var _static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_favorited_svg__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/icons/favorite.svg */ "./static/assets/icons/favorite.svg");
/* harmony import */ var _static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_favorite_svg__WEBPACK_IMPORTED_MODULE_2__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\FavoriteFloater.jsx";




function FavoriteFloater({
  isFavorited,
  style
}) {
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/assets/icons/payments.svg */ "./static/assets/icons/payments.svg");
/* harmony import */ var _static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_payments_svg__WEBPACK_IMPORTED_MODULE_1__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Footer.jsx";



function Footer({
  style
}) {
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\InteractiveElement.jsx";

/* harmony default export */ __webpack_exports__["default"] = (react__WEBPACK_IMPORTED_MODULE_1__["forwardRef"]((props, ref) => {
  return react__WEBPACK_IMPORTED_MODULE_1__["createElement"](props.tag, Object(_babel_runtime_corejs2_helpers_esm_extends__WEBPACK_IMPORTED_MODULE_0__["default"])({
    role: "button",
    tabIndex: 0,
    onKeyPress: e => e.key === 'Enter' && props.onClick && props.onClick(e),
    ref: ref
  }, props, {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: undefined
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! next/router */ "next/router");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/icons/menuToggleArrow.svg */ "./static/assets/icons/menuToggleArrow.svg");
/* harmony import */ var _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _static_consts_menuItems__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../static/consts/menuItems */ "./static/consts/menuItems.js");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Menu.jsx";




/* harmony default export */ __webpack_exports__["default"] = (react__WEBPACK_IMPORTED_MODULE_0__["forwardRef"](({
  isActive
}, ref) => {
  const [translateXValue, setTranslateXValue] = react__WEBPACK_IMPORTED_MODULE_0__["useState"](-100);
  const Router = Object(next_router__WEBPACK_IMPORTED_MODULE_1__["useRouter"])();
  react__WEBPACK_IMPORTED_MODULE_0__["useEffect"](() => {
    if (isActive) {
      setTranslateXValue(0);
    } else {
      setTranslateXValue(-100);
    }
  }, [isActive]);
  const itens = _static_consts_menuItems__WEBPACK_IMPORTED_MODULE_3__["default"].map((menuItem, index) => {
    const [subMenuIsActive, setSubMenuIsActive] = react__WEBPACK_IMPORTED_MODULE_0__["useState"](false);

    function handleClick(e) {
      if (e.subItems) {
        setSubMenuIsActive(!subMenuIsActive);
      } else {
        const {
          prefix,
          label
        } = e;
        const link = prefix ? `/${prefix}/${label.toLowerCase()}` : '/' + label.toLowerCase();
        Router.push(link);
      }
    }

    return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
      className: "menu-item",
      key: index,
      __source: {
        fileName: _jsxFileName,
        lineNumber: 28
      },
      __self: undefined
    }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
      className: "label",
      onClick: () => handleClick(menuItem),
      __source: {
        fileName: _jsxFileName,
        lineNumber: 30
      },
      __self: undefined
    }, menuItem.label, menuItem.subItems && react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("img", {
      className: "menu-toggle-arrow",
      src: _static_assets_icons_menuToggleArrow_svg__WEBPACK_IMPORTED_MODULE_2___default.a,
      style: {
        transform: `rotate(${subMenuIsActive ? 180 : 0}deg)`
      },
      __source: {
        fileName: _jsxFileName,
        lineNumber: 31
      },
      __self: undefined
    })), menuItem.subItems && subMenuIsActive && react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
      className: "menu-sub-item-container",
      __source: {
        fileName: _jsxFileName,
        lineNumber: 34
      },
      __self: undefined
    }, menuItem.subItems.map((e, index) => {
      e.prefix = menuItem.prefix;
      return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
        className: "menu-sub-item",
        onClick: () => handleClick(e),
        key: index,
        __source: {
          fileName: _jsxFileName,
          lineNumber: 39
        },
        __self: undefined
      }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
        className: "label",
        __source: {
          fileName: _jsxFileName,
          lineNumber: 40
        },
        __self: undefined
      }, e.label));
    })));
  });
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "menu",
    ref: ref,
    style: {
      transform: `translateX(${translateXValue}%)`
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 52
    },
    __self: undefined
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! next/router */ "next/router");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/logo.svg */ "./static/assets/logo.svg");
/* harmony import */ var _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../static/assets/icons/hamburguerMenu.svg */ "./static/assets/icons/hamburguerMenu.svg");
/* harmony import */ var _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../static/assets/icons/hamburguerCloseMenu.svg */ "./static/assets/icons/hamburguerCloseMenu.svg");
/* harmony import */ var _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../static/assets/icons/shoppingCart.svg */ "./static/assets/icons/shoppingCart.svg");
/* harmony import */ var _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../static/assets/icons/search.svg */ "./static/assets/icons/search.svg");
/* harmony import */ var _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(_static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _Menu__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./Menu */ "./components/Menu.jsx");
/* harmony import */ var _ShopCartMenu__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./ShopCartMenu */ "./components/ShopCartMenu.jsx");
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Nav.jsx";











const Nav = () => {
  const Router = Object(next_router__WEBPACK_IMPORTED_MODULE_1__["useRouter"])();
  const [isMenuActive, setIsMenuActive] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState(false);
  const [isShopCartMenuActive, setIsShopCartMenuActive] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState(false);
  const menuRef = react__WEBPACK_IMPORTED_MODULE_0___default.a.useRef();
  const navRef = react__WEBPACK_IMPORTED_MODULE_0___default.a.useRef();
  const hamburguerMenuRef = react__WEBPACK_IMPORTED_MODULE_0___default.a.useRef();

  function handleHamburguerMenu(e) {
    e.preventDefault();
    setIsMenuActive(!isMenuActive);
  }

  function handleShopCartMenu() {
    setIsShopCartMenuActive(!isShopCartMenuActive);
  }

  react__WEBPACK_IMPORTED_MODULE_0___default.a.useEffect(() => {
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


  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("nav", {
    ref: navRef,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 59
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_Menu__WEBPACK_IMPORTED_MODULE_7__["default"], {
    ref: menuRef,
    isActive: isMenuActive,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 60
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_ShopCartMenu__WEBPACK_IMPORTED_MODULE_8__["default"], {
    isActive: isShopCartMenuActive,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 61
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_9__["default"], {
    src: isMenuActive ? _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_4___default.a : _static_assets_icons_hamburguerMenu_svg__WEBPACK_IMPORTED_MODULE_3___default.a,
    ref: hamburguerMenuRef,
    onClick: handleHamburguerMenu,
    className: "hamburguer-menu",
    alt: "Hamburguer Menu",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 62
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_9__["default"], {
    className: "logo",
    onClick: handleLogoClick,
    src: _static_assets_logo_svg__WEBPACK_IMPORTED_MODULE_2___default.a,
    alt: "Logo",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 70
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_9__["default"], {
    onClick: handleShopCartMenu,
    className: "shopping-cart",
    src: isShopCartMenuActive ? _static_assets_icons_hamburguerCloseMenu_svg__WEBPACK_IMPORTED_MODULE_4___default.a : _static_assets_icons_shoppingCart_svg__WEBPACK_IMPORTED_MODULE_5___default.a,
    alt: "Carrinho de Compras",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 77
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "search-bar",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 84
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("input", {
    type: "search",
    placeholder: "Digite Aqui",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 85
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_InteractiveElement__WEBPACK_IMPORTED_MODULE_9__["default"], {
    src: _static_assets_icons_search_svg__WEBPACK_IMPORTED_MODULE_6___default.a,
    alt: "Pesquisar",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 86
    },
    __self: undefined
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/styles/main.scss */ "./static/styles/main.scss");
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Page.jsx";



function Page({
  children
}) {
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _ColorSelector__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./ColorSelector */ "./components/ColorSelector.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ProductOptionsController.jsx";



function ProductOptionsController() {
  const [activeColor, setActiveColor] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState('red');
  console.log(activeColor);
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "product-options-controller",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_ColorSelector__WEBPACK_IMPORTED_MODULE_1__["default"], {
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ShopCartMenu.jsx";

/* harmony default export */ __webpack_exports__["default"] = (({
  isActive
}) => {
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "menu",
    style: {
      left: 'unset',
      right: 0,
      transform: `translateX(${isActive ? 0 : 100}%)`
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: undefined
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
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Title.jsx";

/* harmony default export */ __webpack_exports__["default"] = (({
  label,
  style
}) => react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
  className: "title-container",
  style: style,
  __source: {
    fileName: _jsxFileName,
    lineNumber: 4
  },
  __self: undefined
}, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("h1", {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 5
  },
  __self: undefined
}, label)));

/***/ }),

/***/ "./components/TitleWithFloater.jsx":
/*!*****************************************!*\
  !*** ./components/TitleWithFloater.jsx ***!
  \*****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _Title__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./Title */ "./components/Title.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\TitleWithFloater.jsx";


/* harmony default export */ __webpack_exports__["default"] = (({
  children,
  label
}) => {
  console.log(children);
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "title-floater-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 7
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_Title__WEBPACK_IMPORTED_MODULE_1__["default"], {
    label: label,
    style: {
      minHeight: 40
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: undefined
  }), children);
});

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/assign.js":
/*!**********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/assign.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/assign */ "core-js/library/fn/object/assign");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-own-property-symbols */ "core-js/library/fn/object/get-own-property-symbols");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js":
/*!********************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/keys.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/keys */ "core-js/library/fn/object/keys");

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

/***/ "./pages/product.jsx":
/*!***************************!*\
  !*** ./pages/product.jsx ***!
  \***************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! next/router */ "next/router");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _components_Nav__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../components/Nav */ "./components/Nav.jsx");
/* harmony import */ var _components_Page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../components/Page */ "./components/Page.jsx");
/* harmony import */ var _services_api__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/api */ "./services/api.js");
/* harmony import */ var _components_Footer__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../components/Footer */ "./components/Footer.jsx");
/* harmony import */ var _components_Breadcumb__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../components/Breadcumb */ "./components/Breadcumb.jsx");
/* harmony import */ var _components_FavoriteFloater__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../components/FavoriteFloater */ "./components/FavoriteFloater.jsx");
/* harmony import */ var _components_TitleWithFloater__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../components/TitleWithFloater */ "./components/TitleWithFloater.jsx");
/* harmony import */ var _components_Title__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ../components/Title */ "./components/Title.jsx");
/* harmony import */ var _components_Description__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ../components/Description */ "./components/Description.jsx");
/* harmony import */ var _components_Button__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ../components/Button */ "./components/Button.jsx");
/* harmony import */ var _components_ProductOptionsController__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ../components/ProductOptionsController */ "./components/ProductOptionsController.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\pages\\product.jsx";














function product() {
  const {
    query
  } = Object(next_router__WEBPACK_IMPORTED_MODULE_1__["useRouter"])();
  const {
    id: productID
  } = query;
  const [isLoading, setIsLoading] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState(true);
  const [currentProduct, setCurrentProduct] = react__WEBPACK_IMPORTED_MODULE_0___default.a.useState(null);
  react__WEBPACK_IMPORTED_MODULE_0___default.a.useEffect(() => {
    _services_api__WEBPACK_IMPORTED_MODULE_4__["default"].get(`products`).then(({
      data: products
    }) => {
      console.log(products);
      setCurrentProduct(products[productID]);
      console.log(products[productID]);
      setIsLoading(false);
    });
  }, [productID]);
  console.log(currentProduct);
  return react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Page__WEBPACK_IMPORTED_MODULE_3__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 30
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Nav__WEBPACK_IMPORTED_MODULE_2__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 31
    },
    __self: this
  }), isLoading === false && currentProduct && react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "product-page-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 34
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Breadcumb__WEBPACK_IMPORTED_MODULE_6__["default"], {
    paths: [currentProduct.category, currentProduct.name],
    __source: {
      fileName: _jsxFileName,
      lineNumber: 35
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_TitleWithFloater__WEBPACK_IMPORTED_MODULE_8__["default"], {
    label: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 36
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_FavoriteFloater__WEBPACK_IMPORTED_MODULE_7__["default"], {
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
  })), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("div", {
    className: "product-display-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 42
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement("img", {
    className: "image",
    src: currentProduct.image,
    alt: currentProduct.name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 43
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_ProductOptionsController__WEBPACK_IMPORTED_MODULE_12__["default"], {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 48
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Description__WEBPACK_IMPORTED_MODULE_10__["default"], {
    text: currentProduct.description,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 51
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Button__WEBPACK_IMPORTED_MODULE_11__["default"], {
    label: "Adicionar ao carrinho",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 52
    },
    __self: this
  })), react__WEBPACK_IMPORTED_MODULE_0___default.a.createElement(_components_Footer__WEBPACK_IMPORTED_MODULE_5__["default"], {
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
/* harmony import */ var axios__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! axios */ "axios");
/* harmony import */ var axios__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(axios__WEBPACK_IMPORTED_MODULE_0__);

const api = axios__WEBPACK_IMPORTED_MODULE_0___default.a.create({
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

/***/ "./static/styles/main.scss":
/*!*********************************!*\
  !*** ./static/styles/main.scss ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports) {



/***/ }),

/***/ 4:
/*!*********************************!*\
  !*** multi ./pages/product.jsx ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\Danilo\Documents\GitHub\WithoffStore\Web\pages\product.jsx */"./pages/product.jsx");


/***/ }),

/***/ "axios":
/*!************************!*\
  !*** external "axios" ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("axios");

/***/ }),

/***/ "core-js/library/fn/object/assign":
/*!***************************************************!*\
  !*** external "core-js/library/fn/object/assign" ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/assign");

/***/ }),

/***/ "core-js/library/fn/object/get-own-property-symbols":
/*!*********************************************************************!*\
  !*** external "core-js/library/fn/object/get-own-property-symbols" ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/get-own-property-symbols");

/***/ }),

/***/ "core-js/library/fn/object/keys":
/*!*************************************************!*\
  !*** external "core-js/library/fn/object/keys" ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/keys");

/***/ }),

/***/ "next/router":
/*!******************************!*\
  !*** external "next/router" ***!
  \******************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next/router");

/***/ }),

/***/ "react":
/*!************************!*\
  !*** external "react" ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("react");

/***/ }),

/***/ "react-use":
/*!****************************!*\
  !*** external "react-use" ***!
  \****************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("react-use");

/***/ })

/******/ });
//# sourceMappingURL=product.js.map