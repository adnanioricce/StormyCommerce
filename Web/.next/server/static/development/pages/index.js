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
/******/ 	return __webpack_require__(__webpack_require__.s = 3);
/******/ })
/************************************************************************/
/******/ ({

/***/ "./actions/index.js":
/*!**************************!*\
  !*** ./actions/index.js ***!
  \**************************/
/*! exports provided: consts, default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "consts", function() { return consts; });
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_objectSpread__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/objectSpread */ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectSpread.js");

const consts = {
  favorite: 'PRODUCTS/FAVORITE',
  fetchProducts: 'PRODUCTS/FETCHPRODUCTS',
  setProducts: 'PRODUCTS/SETPRODUCTS'
};
const products = {
  favorite: productID => ({
    type: consts.favorite,
    productID
  }),
  setProducts: productsArray => ({
    type: consts.setProducts,
    products: productsArray
  }),
  fetchProducts: () => ({
    type: consts.fetchProducts
  })
};
/* harmony default export */ __webpack_exports__["default"] = (Object(_babel_runtime_corejs2_helpers_esm_objectSpread__WEBPACK_IMPORTED_MODULE_0__["default"])({}, products));

/***/ }),

/***/ "./components/Categories.jsx":
/*!***********************************!*\
  !*** ./components/Categories.jsx ***!
  \***********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_consts_categories__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/consts/categories */ "./static/consts/categories.js");
/* harmony import */ var _Header__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./Header */ "./components/Header.jsx");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! next/router */ "next/router");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_3__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Categories.jsx";




/* harmony default export */ __webpack_exports__["default"] = (() => {
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"](react__WEBPACK_IMPORTED_MODULE_0__["Fragment"], null, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_Header__WEBPACK_IMPORTED_MODULE_2__["default"], {
    label: "Categorias",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 8
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "categories-card-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 9
    },
    __self: undefined
  }, _static_consts_categories__WEBPACK_IMPORTED_MODULE_1__["default"].map(categoryCard)));
});

const categoryCard = (category, index) => {
  const Router = Object(next_router__WEBPACK_IMPORTED_MODULE_3__["useRouter"])();

  function handleCategoryClick() {
    Router.push('/' + category.link);
  }

  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "category-card",
    key: index,
    onClick: handleCategoryClick,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 23
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("img", {
    src: category.photo,
    alt: category.label,
    className: "photo",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 24
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
    className: "label",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 25
    },
    __self: undefined
  }, category.label));
};

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

/***/ "./components/Header.jsx":
/*!*******************************!*\
  !*** ./components/Header.jsx ***!
  \*******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Header.jsx";

/* harmony default export */ __webpack_exports__["default"] = (({
  label,
  border = true
}) => {
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "header",
    style: {
      border: border === false ? 'none' : 'solid 1px black'
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 5
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
    __source: {
      fileName: _jsxFileName,
      lineNumber: 6
    },
    __self: undefined
  }, label));
});

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

/***/ "./components/ProductCard.jsx":
/*!************************************!*\
  !*** ./components/ProductCard.jsx ***!
  \************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_link__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! next/link */ "./node_modules/next/link.js");
/* harmony import */ var next_link__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_link__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _FavoriteFloater__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./FavoriteFloater */ "./components/FavoriteFloater.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\ProductCard.jsx";



/* harmony default export */ __webpack_exports__["default"] = (({
  isFavorited,
  name,
  image,
  price,
  id
}, index, algo, route) => {
  // const [image, setImage] = React.useState('');
  // React.useEffect(()=>{
  //   fetch(product.image).then(
  //     res=>console.log(res)
  //   )
  // }, [])
  function handleProductClick() {
    console.log(route);
    route.query = {
      productID: index
    };
    route.push('/product');
  }

  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"](next_link__WEBPACK_IMPORTED_MODULE_1___default.a, {
    href: `/product?id=${index}`,
    key: id,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 24
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    onClick: handleProductClick,
    className: "product",
    key: index,
    role: "button",
    onKeyPress: e => e.key === 'Enter' && handleProductClick(),
    tabIndex: 0,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 25
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("img", {
    className: "image",
    src: image,
    alt: name,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 33
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_FavoriteFloater__WEBPACK_IMPORTED_MODULE_2__["default"], {
    style: {
      position: 'absolute',
      top: -1,
      right: -1
    },
    isFavorited: isFavorited,
    __source: {
      fileName: _jsxFileName,
      lineNumber: 34
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "info",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 38
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
    className: "title",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 39
    },
    __self: undefined
  }, name), react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("p", {
    className: "price",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 40
    },
    __self: undefined
  }, `R$ ${price.toFixed(2)}`))));
});

/***/ }),

/***/ "./components/Products.jsx":
/*!*********************************!*\
  !*** ./components/Products.jsx ***!
  \*********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! next/router */ "next/router");
/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var react_redux__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! react-redux */ "react-redux");
/* harmony import */ var react_redux__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(react_redux__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _Header__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./Header */ "./components/Header.jsx");
/* harmony import */ var _ProductCard__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./ProductCard */ "./components/ProductCard.jsx");
/* harmony import */ var _actions__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../actions */ "./actions/index.js");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Products.jsx";






/* harmony default export */ __webpack_exports__["default"] = (() => {
  const products = Object(react_redux__WEBPACK_IMPORTED_MODULE_2__["useSelector"])(state => state.products, react_redux__WEBPACK_IMPORTED_MODULE_2__["shallowEqual"]);
  const dispatch = Object(react_redux__WEBPACK_IMPORTED_MODULE_2__["useDispatch"])();
  react__WEBPACK_IMPORTED_MODULE_0__["useEffect"](() => {
    dispatch(_actions__WEBPACK_IMPORTED_MODULE_5__["default"].fetchProducts());
  }, []);
  const route = Object(next_router__WEBPACK_IMPORTED_MODULE_1__["useRouter"])();
  console.log(products, dispatch);
  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"](react__WEBPACK_IMPORTED_MODULE_0__["Fragment"], null, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_Header__WEBPACK_IMPORTED_MODULE_3__["default"], {
    label: "Destaques",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 18
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "products-container",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 19
    },
    __self: undefined
  }, products.map((...params) => Object(_ProductCard__WEBPACK_IMPORTED_MODULE_4__["default"])(...params, route))));
});

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

/***/ "./components/Slide.jsx":
/*!******************************!*\
  !*** ./components/Slide.jsx ***!
  \******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/assets/slides/nextSlide.svg */ "./static/assets/slides/nextSlide.svg");
/* harmony import */ var _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/slides/previousSlide.svg */ "./static/assets/slides/previousSlide.svg");
/* harmony import */ var _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Slide.jsx";




/* harmony default export */ __webpack_exports__["default"] = (() => {
  const [index, setIndex] = react__WEBPACK_IMPORTED_MODULE_0__["useState"](2);
  const imgRef = react__WEBPACK_IMPORTED_MODULE_0__["useRef"]();
  const [images] = react__WEBPACK_IMPORTED_MODULE_0__["useState"]([0, 1, 2, 3, 4]);
  const [slideWidth, setSlideWidth] = react__WEBPACK_IMPORTED_MODULE_0__["useState"](0);
  const [slides, setSlides] = react__WEBPACK_IMPORTED_MODULE_0__["useState"](null);
  const timer = react__WEBPACK_IMPORTED_MODULE_0__["useRef"]();
  react__WEBPACK_IMPORTED_MODULE_0__["useEffect"](() => {
    const newSlides = images.map((e, eIndex) => react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
      ref: imgRef,
      key: e,
      className: eIndex === index ? 'main image' : 'image',
      __source: {
        fileName: _jsxFileName,
        lineNumber: 15
      },
      __self: undefined
    }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], {
      tag: "img",
      onClick: () => {
        setIndex(e);
      },
      src: `/static/assets/slides/${e}.svg`,
      alt: `Slide numero ${e}`,
      __source: {
        fileName: _jsxFileName,
        lineNumber: 20
      },
      __self: undefined
    })));
    setSlides(newSlides);
  }, [index, images]);
  react__WEBPACK_IMPORTED_MODULE_0__["useEffect"](() => {
    if (imgRef.current) {
      setSlideWidth(imgRef.current.offsetWidth);
    }
  });

  function handleNextSlide() {
    if (index <= images.length - 2) {
      setIndex(index + 1);
    } else {
      setIndex(0);
    }
  }

  function handlePreviousSlide() {
    if (index !== 0) {
      setIndex(index - 1);
    } else {
      setIndex(images.length - 1);
    }
  }

  react__WEBPACK_IMPORTED_MODULE_0__["useEffect"](() => {
    // setTimeout(()=>{
    //   handleNextSlide()
    // }, 500)
    clearTimeout(timer.current);
    timer.current = setTimeout(() => {
      if (index <= images.length - 2) {
        setIndex(index + 1);
      } else {
        setIndex(0);
      }
    }, 4000);
    return () => clearTimeout(timer.current);
  }, [index]); // const modifier = width<=425 ? 0 : (-0.12*slideWidth)

  return react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "overflow-not-allower",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 69
    },
    __self: undefined
  }, react__WEBPACK_IMPORTED_MODULE_0__["createElement"]("div", {
    className: "Slide",
    style: {
      transform: `translateX(${index * slideWidth * -1}px)`
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 70
    },
    __self: undefined
  }, slides), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], {
    className: "left-slider-button",
    onClick: handlePreviousSlide,
    src: _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_2___default.a,
    alt: "Bot\xE3o Esquerdo do Slider",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 76
    },
    __self: undefined
  }), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_3__["default"], {
    className: "right-slider-button",
    onClick: handleNextSlide,
    src: _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_1___default.a,
    alt: "Bot\xE3o Direito do Slider",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 83
    },
    __self: undefined
  }));
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

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js":
/*!*******************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js ***!
  \*******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/define-property */ "core-js/library/fn/object/define-property");

/***/ }),

/***/ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js":
/*!*******************************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js ***!
  \*******************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-own-property-descriptor */ "core-js/library/fn/object/get-own-property-descriptor");

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

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/defineProperty.js":
/*!***************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/defineProperty.js ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _defineProperty; });
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/define-property */ "./node_modules/@babel/runtime-corejs2/core-js/object/define-property.js");
/* harmony import */ var _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0__);

function _defineProperty(obj, key, value) {
  if (key in obj) {
    _core_js_object_define_property__WEBPACK_IMPORTED_MODULE_0___default()(obj, key, {
      value: value,
      enumerable: true,
      configurable: true,
      writable: true
    });
  } else {
    obj[key] = value;
  }

  return obj;
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

/***/ "./node_modules/@babel/runtime-corejs2/helpers/esm/objectSpread.js":
/*!*************************************************************************!*\
  !*** ./node_modules/@babel/runtime-corejs2/helpers/esm/objectSpread.js ***!
  \*************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return _objectSpread; });
/* harmony import */ var _core_js_object_get_own_property_descriptor__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../core-js/object/get-own-property-descriptor */ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js");
/* harmony import */ var _core_js_object_get_own_property_descriptor__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_get_own_property_descriptor__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../core-js/object/get-own-property-symbols */ "./node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-symbols.js");
/* harmony import */ var _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _core_js_object_keys__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../core-js/object/keys */ "./node_modules/@babel/runtime-corejs2/core-js/object/keys.js");
/* harmony import */ var _core_js_object_keys__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_core_js_object_keys__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _defineProperty__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./defineProperty */ "./node_modules/@babel/runtime-corejs2/helpers/esm/defineProperty.js");




function _objectSpread(target) {
  for (var i = 1; i < arguments.length; i++) {
    var source = arguments[i] != null ? arguments[i] : {};

    var ownKeys = _core_js_object_keys__WEBPACK_IMPORTED_MODULE_2___default()(source);

    if (typeof _core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_1___default.a === 'function') {
      ownKeys = ownKeys.concat(_core_js_object_get_own_property_symbols__WEBPACK_IMPORTED_MODULE_1___default()(source).filter(function (sym) {
        return _core_js_object_get_own_property_descriptor__WEBPACK_IMPORTED_MODULE_0___default()(source, sym).enumerable;
      }));
    }

    ownKeys.forEach(function (key) {
      Object(_defineProperty__WEBPACK_IMPORTED_MODULE_3__["default"])(target, key, source[key]);
    });
  }

  return target;
}

/***/ }),

/***/ "./node_modules/next/dist/client/link.js":
/*!***********************************************!*\
  !*** ./node_modules/next/dist/client/link.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireWildcard = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireWildcard */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireWildcard.js");

var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

exports.__esModule = true;
exports.default = void 0;

var _map = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/map */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/map.js"));

var _url = __webpack_require__(/*! url */ "url");

var _react = _interopRequireWildcard(__webpack_require__(/*! react */ "react"));

var _propTypes = _interopRequireDefault(__webpack_require__(/*! prop-types */ "prop-types"));

var _router = _interopRequireDefault(__webpack_require__(/*! ./router */ "./node_modules/next/dist/client/router.js"));

var _rewriteUrlForExport = __webpack_require__(/*! next-server/dist/lib/router/rewrite-url-for-export */ "next-server/dist/lib/router/rewrite-url-for-export");

var _utils = __webpack_require__(/*! next-server/dist/lib/utils */ "next-server/dist/lib/utils");
/* global __NEXT_DATA__ */


function isLocal(href) {
  const url = (0, _url.parse)(href, false, true);
  const origin = (0, _url.parse)((0, _utils.getLocationOrigin)(), false, true);
  return !url.host || url.protocol === origin.protocol && url.host === origin.host;
}

function memoizedFormatUrl(formatFunc) {
  let lastHref = null;
  let lastAs = null;
  let lastResult = null;
  return (href, as) => {
    if (lastResult && href === lastHref && as === lastAs) {
      return lastResult;
    }

    const result = formatFunc(href, as);
    lastHref = href;
    lastAs = as;
    lastResult = result;
    return result;
  };
}

function formatUrl(url) {
  return url && typeof url === 'object' ? (0, _utils.formatWithValidation)(url) : url;
}

let observer;
const listeners = new _map.default();
const IntersectionObserver =  false ? undefined : null;

function getObserver() {
  // Return shared instance of IntersectionObserver if already created
  if (observer) {
    return observer;
  } // Only create shared IntersectionObserver if supported in browser


  if (!IntersectionObserver) {
    return undefined;
  }

  return observer = new IntersectionObserver(entries => {
    entries.forEach(entry => {
      if (!listeners.has(entry.target)) {
        return;
      }

      const cb = listeners.get(entry.target);

      if (entry.isIntersecting || entry.intersectionRatio > 0) {
        observer.unobserve(entry.target);
        listeners.delete(entry.target);
        cb();
      }
    });
  }, {
    rootMargin: '200px'
  });
}

const listenToIntersections = (el, cb) => {
  const observer = getObserver();

  if (!observer) {
    return () => {};
  }

  observer.observe(el);
  listeners.set(el, cb);
  return () => {
    observer.unobserve(el);
    listeners.delete(el);
  };
};

class Link extends _react.Component {
  constructor() {
    super(...arguments);

    this.cleanUpListeners = () => {};

    this.formatUrls = memoizedFormatUrl((href, asHref) => {
      return {
        href: formatUrl(href),
        as: asHref ? formatUrl(asHref) : asHref
      };
    });

    this.linkClicked = e => {
      // @ts-ignore target exists on currentTarget
      const {
        nodeName,
        target
      } = e.currentTarget;

      if (nodeName === 'A' && (target && target !== '_self' || e.metaKey || e.ctrlKey || e.shiftKey || e.nativeEvent && e.nativeEvent.which === 2)) {
        // ignore click for new tab / new window behavior
        return;
      }

      let {
        href,
        as
      } = this.formatUrls(this.props.href, this.props.as);

      if (!isLocal(href)) {
        // ignore click if it's outside our scope
        return;
      }

      const {
        pathname
      } = window.location;
      href = (0, _url.resolve)(pathname, href);
      as = as ? (0, _url.resolve)(pathname, as) : href;
      e.preventDefault(); //  avoid scroll for urls with anchor refs

      let {
        scroll
      } = this.props;

      if (scroll == null) {
        scroll = as.indexOf('#') < 0;
      } // replace state instead of push if prop is present


      _router.default[this.props.replace ? 'replace' : 'push'](href, as, {
        shallow: this.props.shallow
      }).then(success => {
        if (!success) return;

        if (scroll) {
          window.scrollTo(0, 0);
          document.body.focus();
        }
      });
    };
  }

  componentWillUnmount() {
    this.cleanUpListeners();
  }

  handleRef(ref) {
    if (this.props.prefetch && IntersectionObserver && ref && ref.tagName) {
      this.cleanUpListeners();
      this.cleanUpListeners = listenToIntersections(ref, () => {
        this.prefetch();
      });
    }
  } // The function is memoized so that no extra lifecycles are needed
  // as per https://reactjs.org/blog/2018/06/07/you-probably-dont-need-derived-state.html


  prefetch() {
    if (!this.props.prefetch || "undefined" === 'undefined') return; // Prefetch the JSON page if asked (only in the client)

    const {
      pathname
    } = window.location;
    const {
      href: parsedHref
    } = this.formatUrls(this.props.href, this.props.as);
    const href = (0, _url.resolve)(pathname, parsedHref);

    _router.default.prefetch(href);
  }

  render() {
    let {
      children
    } = this.props;
    const {
      href,
      as
    } = this.formatUrls(this.props.href, this.props.as); // Deprecated. Warning shown by propType check. If the childen provided is a string (<Link>example</Link>) we wrap it in an <a> tag

    if (typeof children === 'string') {
      children = _react.default.createElement("a", null, children);
    } // This will return the first child, if multiple are provided it will throw an error


    const child = _react.Children.only(children);

    const props = {
      ref: el => this.handleRef(el),
      onMouseEnter: e => {
        if (child.props && typeof child.props.onMouseEnter === 'function') {
          child.props.onMouseEnter(e);
        }

        this.prefetch();
      },
      onClick: e => {
        if (child.props && typeof child.props.onClick === 'function') {
          child.props.onClick(e);
        }

        if (!e.defaultPrevented) {
          this.linkClicked(e);
        }
      } // If child is an <a> tag and doesn't have a href attribute, or if the 'passHref' property is
      // defined, we specify the current 'href', so that repetition is not needed by the user

    };

    if (this.props.passHref || child.type === 'a' && !('href' in child.props)) {
      props.href = as || href;
    } // Add the ending slash to the paths. So, we can serve the
    // "<page>/index.html" directly.


    if (false) {}

    return _react.default.cloneElement(child, props);
  }

}

Link.propTypes = void 0;
Link.defaultProps = {
  prefetch: true
};

if (true) {
  const warn = (0, _utils.execOnce)(console.error); // This module gets removed by webpack.IgnorePlugin

  const exact = __webpack_require__(/*! prop-types-exact */ "prop-types-exact");

  Link.propTypes = exact({
    href: _propTypes.default.oneOfType([_propTypes.default.string, _propTypes.default.object]).isRequired,
    as: _propTypes.default.oneOfType([_propTypes.default.string, _propTypes.default.object]),
    prefetch: _propTypes.default.bool,
    replace: _propTypes.default.bool,
    shallow: _propTypes.default.bool,
    passHref: _propTypes.default.bool,
    scroll: _propTypes.default.bool,
    children: _propTypes.default.oneOfType([_propTypes.default.element, (props, propName) => {
      const value = props[propName];

      if (typeof value === 'string') {
        warn("Warning: You're using a string directly inside <Link>. This usage has been deprecated. Please add an <a> tag as child of <Link>");
      }

      return null;
    }]).isRequired
  });
}

var _default = Link;
exports.default = _default;

/***/ }),

/***/ "./node_modules/next/dist/client/router.js":
/*!*************************************************!*\
  !*** ./node_modules/next/dist/client/router.js ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var _interopRequireWildcard = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireWildcard */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireWildcard.js");

var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

exports.__esModule = true;
exports.useRouter = useRouter;
exports.makePublicRouterInstance = makePublicRouterInstance;
exports.createRouter = exports.withRouter = exports.default = void 0;

var _extends2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/extends */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js"));

var _defineProperty = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/core-js/object/define-property */ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js"));

var _react = _interopRequireDefault(__webpack_require__(/*! react */ "react"));

var _router2 = _interopRequireWildcard(__webpack_require__(/*! next-server/dist/lib/router/router */ "next-server/dist/lib/router/router"));

exports.Router = _router2.default;
exports.NextRouter = _router2.NextRouter;

var _routerContext = __webpack_require__(/*! next-server/dist/lib/router-context */ "next-server/dist/lib/router-context");

var _withRouter = _interopRequireDefault(__webpack_require__(/*! ./with-router */ "./node_modules/next/dist/client/with-router.js"));

exports.withRouter = _withRouter.default;
/* global window */

const singletonRouter = {
  router: null,
  // holds the actual router instance
  readyCallbacks: [],

  ready(cb) {
    if (this.router) return cb();

    if (false) {}
  }

}; // Create public properties and methods of the router in the singletonRouter

const urlPropertyFields = ['pathname', 'route', 'query', 'asPath'];
const propertyFields = ['components'];
const routerEvents = ['routeChangeStart', 'beforeHistoryChange', 'routeChangeComplete', 'routeChangeError', 'hashChangeStart', 'hashChangeComplete'];
const coreMethodFields = ['push', 'replace', 'reload', 'back', 'prefetch', 'beforePopState']; // Events is a static property on the router, the router doesn't have to be initialized to use it

(0, _defineProperty.default)(singletonRouter, 'events', {
  get() {
    return _router2.default.events;
  }

});
propertyFields.concat(urlPropertyFields).forEach(field => {
  // Here we need to use Object.defineProperty because, we need to return
  // the property assigned to the actual router
  // The value might get changed as we change routes and this is the
  // proper way to access it
  (0, _defineProperty.default)(singletonRouter, field, {
    get() {
      const router = getRouter();
      return router[field];
    }

  });
});
coreMethodFields.forEach(field => {
  // We don't really know the types here, so we add them later instead
  ;

  singletonRouter[field] = function () {
    const router = getRouter();
    return router[field](...arguments);
  };
});
routerEvents.forEach(event => {
  singletonRouter.ready(() => {
    _router2.default.events.on(event, function () {
      const eventField = "on" + event.charAt(0).toUpperCase() + event.substring(1);
      const _singletonRouter = singletonRouter;

      if (_singletonRouter[eventField]) {
        try {
          _singletonRouter[eventField](...arguments);
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
    const message = 'No router instance found.\n' + 'You should only use "next/router" inside the client side of your app.\n';
    throw new Error(message);
  }

  return singletonRouter.router;
} // Export the singletonRouter and this is the public API.


var _default = singletonRouter; // Reexport the withRoute HOC

exports.default = _default;

function useRouter() {
  return _react.default.useContext(_routerContext.RouterContext);
} // INTERNAL APIS
// -------------
// (do not use following exports inside the app)
// Create a router and assign it as the singleton instance.
// This is used in client side when we are initilizing the app.
// This should **not** use inside the server.


const createRouter = function createRouter() {
  for (var _len = arguments.length, args = new Array(_len), _key = 0; _key < _len; _key++) {
    args[_key] = arguments[_key];
  }

  singletonRouter.router = new _router2.default(...args);
  singletonRouter.readyCallbacks.forEach(cb => cb());
  singletonRouter.readyCallbacks = [];
  return singletonRouter.router;
}; // This function is used to create the `withRouter` router instance


exports.createRouter = createRouter;

function makePublicRouterInstance(router) {
  const _router = router;
  const instance = {};

  for (const property of urlPropertyFields) {
    if (typeof _router[property] === 'object') {
      instance[property] = (0, _extends2.default)({}, _router[property]); // makes sure query is not stateful

      continue;
    }

    instance[property] = _router[property];
  } // Events is a static property on the router, the router doesn't have to be initialized to use it


  instance.events = _router2.default.events;
  propertyFields.forEach(field => {
    // Here we need to use Object.defineProperty because, we need to return
    // the property assigned to the actual router
    // The value might get changed as we change routes and this is the
    // proper way to access it
    (0, _defineProperty.default)(instance, field, {
      get() {
        return _router[field];
      }

    });
  });
  coreMethodFields.forEach(field => {
    instance[field] = function () {
      return _router[field](...arguments);
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


var _interopRequireDefault = __webpack_require__(/*! @babel/runtime-corejs2/helpers/interopRequireDefault */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/interopRequireDefault.js");

exports.__esModule = true;
exports.default = withRouter;

var _extends2 = _interopRequireDefault(__webpack_require__(/*! @babel/runtime-corejs2/helpers/extends */ "./node_modules/next/node_modules/@babel/runtime-corejs2/helpers/extends.js"));

var _react = _interopRequireDefault(__webpack_require__(/*! react */ "react"));

var _propTypes = _interopRequireDefault(__webpack_require__(/*! prop-types */ "prop-types"));

function withRouter(ComposedComponent) {
  class WithRouteWrapper extends _react.default.Component {
    constructor() {
      super(...arguments);
      this.context = void 0;
    }

    render() {
      return _react.default.createElement(ComposedComponent, (0, _extends2.default)({
        router: this.context.router
      }, this.props));
    }

  }

  WithRouteWrapper.displayName = void 0;
  WithRouteWrapper.getInitialProps = void 0;
  WithRouteWrapper.contextTypes = {
    router: _propTypes.default.object
  };
  WithRouteWrapper.getInitialProps = ComposedComponent.getInitialProps;

  if (true) {
    const name = ComposedComponent.displayName || ComposedComponent.name || 'Unknown';
    WithRouteWrapper.displayName = "withRouter(" + name + ")";
  }

  return WithRouteWrapper;
}

/***/ }),

/***/ "./node_modules/next/link.js":
/*!***********************************!*\
  !*** ./node_modules/next/link.js ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! ./dist/client/link */ "./node_modules/next/dist/client/link.js")


/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/map.js":
/*!******************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/map.js ***!
  \******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/map */ "core-js/library/fn/map");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/assign.js":
/*!****************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/assign.js ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/assign */ "core-js/library/fn/object/assign");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js":
/*!*************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/define-property.js ***!
  \*************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/define-property */ "core-js/library/fn/object/define-property");

/***/ }),

/***/ "./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/next/node_modules/@babel/runtime-corejs2/core-js/object/get-own-property-descriptor.js ***!
  \*************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! core-js/library/fn/object/get-own-property-descriptor */ "core-js/library/fn/object/get-own-property-descriptor");

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

/***/ "./pages/index.jsx":
/*!*************************!*\
  !*** ./pages/index.jsx ***!
  \*************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react */ "react");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../static/styles/main.scss */ "./static/styles/main.scss");
/* harmony import */ var _static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_static_styles_main_scss__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _components_Nav__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../components/Nav */ "./components/Nav.jsx");
/* harmony import */ var _components_Slide__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../components/Slide */ "./components/Slide.jsx");
/* harmony import */ var _components_Products__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../components/Products */ "./components/Products.jsx");
/* harmony import */ var _components_Categories__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../components/Categories */ "./components/Categories.jsx");
/* harmony import */ var _components_Footer__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../components/Footer */ "./components/Footer.jsx");
/* harmony import */ var _components_Page__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../components/Page */ "./components/Page.jsx");
var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\pages\\index.jsx";








/* harmony default export */ __webpack_exports__["default"] = (() => react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Page__WEBPACK_IMPORTED_MODULE_7__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 11
  },
  __self: undefined
}, react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Nav__WEBPACK_IMPORTED_MODULE_2__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 12
  },
  __self: undefined
}), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Slide__WEBPACK_IMPORTED_MODULE_3__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 13
  },
  __self: undefined
}), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Products__WEBPACK_IMPORTED_MODULE_4__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 14
  },
  __self: undefined
}), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Categories__WEBPACK_IMPORTED_MODULE_5__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 15
  },
  __self: undefined
}), react__WEBPACK_IMPORTED_MODULE_0__["createElement"](_components_Footer__WEBPACK_IMPORTED_MODULE_6__["default"], {
  __source: {
    fileName: _jsxFileName,
    lineNumber: 16
  },
  __self: undefined
})));

/***/ }),

/***/ "./static/assets/categories/acessorios.jpg":
/*!*************************************************!*\
  !*** ./static/assets/categories/acessorios.jpg ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/_next/static/images/acessorios-9d71cd6ca2abc5b05fd495ab7ea5b00b.jpg";

/***/ }),

/***/ "./static/assets/categories/bermudas.jpg":
/*!***********************************************!*\
  !*** ./static/assets/categories/bermudas.jpg ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/_next/static/images/bermudas-2239a730a3479a65a83a28948ab4f022.jpg";

/***/ }),

/***/ "./static/assets/categories/camisetas.png":
/*!************************************************!*\
  !*** ./static/assets/categories/camisetas.png ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/_next/static/images/camisetas-83a71d6dbb1f8d57773091ffbc3c4ddd.png";

/***/ }),

/***/ "./static/assets/categories/casacos.jpg":
/*!**********************************************!*\
  !*** ./static/assets/categories/casacos.jpg ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/_next/static/images/casacos-51b108f8bf0bee274477b582d4fe8785.jpg";

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

/***/ "./static/assets/slides/nextSlide.svg":
/*!********************************************!*\
  !*** ./static/assets/slides/nextSlide.svg ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMTE1IiBoZWlnaHQ9IjIzMCIgdmlld0JveD0iMCAwIDExNSAyMzAiIGZpbGw9Im5vbmUiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+DQo8cGF0aCBkPSJNMSAxMTVMMTEzLjUgMS41TDExNCAyMjhMMSAxMTVaIiBmaWxsPSJ3aGl0ZSIgc3Ryb2tlPSJibGFjayIvPg0KPHBhdGggZD0iTTY0Ljg4NzkgODFMODQgMTExLjAzM0w2NC44ODc5IDE0MS4wNjciIHN0cm9rZT0iYmxhY2siLz4NCjwvc3ZnPg0K"

/***/ }),

/***/ "./static/assets/slides/previousSlide.svg":
/*!************************************************!*\
  !*** ./static/assets/slides/previousSlide.svg ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMTE1IiBoZWlnaHQ9IjIzMCIgdmlld0JveD0iMCAwIDExNSAyMzAiIGZpbGw9Im5vbmUiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+DQo8cGF0aCBkPSJNMTE0IDExNUwxLjUgMS41TDEgMjI4TDExNCAxMTVaIiBmaWxsPSJ3aGl0ZSIgc3Ryb2tlPSJibGFjayIvPg0KPHBhdGggZD0iTTUwLjExMjEgODFMMzEgMTExLjAzM0w1MC4xMTIxIDE0MS4wNjciIHN0cm9rZT0iYmxhY2siLz4NCjwvc3ZnPg0K"

/***/ }),

/***/ "./static/consts/categories.js":
/*!*************************************!*\
  !*** ./static/consts/categories.js ***!
  \*************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _assets_categories_camisetas_png__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../assets/categories/camisetas.png */ "./static/assets/categories/camisetas.png");
/* harmony import */ var _assets_categories_camisetas_png__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_assets_categories_camisetas_png__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _assets_categories_bermudas_jpg__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../assets/categories/bermudas.jpg */ "./static/assets/categories/bermudas.jpg");
/* harmony import */ var _assets_categories_bermudas_jpg__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_assets_categories_bermudas_jpg__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _assets_categories_casacos_jpg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../assets/categories/casacos.jpg */ "./static/assets/categories/casacos.jpg");
/* harmony import */ var _assets_categories_casacos_jpg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_assets_categories_casacos_jpg__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _assets_categories_acessorios_jpg__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../assets/categories/acessorios.jpg */ "./static/assets/categories/acessorios.jpg");
/* harmony import */ var _assets_categories_acessorios_jpg__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_assets_categories_acessorios_jpg__WEBPACK_IMPORTED_MODULE_3__);




/* harmony default export */ __webpack_exports__["default"] = ([{
  label: 'Camisetas',
  photo: _assets_categories_camisetas_png__WEBPACK_IMPORTED_MODULE_0___default.a,
  link: 'produtos/camisetas'
}, {
  label: 'Bermudas',
  photo: _assets_categories_bermudas_jpg__WEBPACK_IMPORTED_MODULE_1___default.a,
  link: 'produtos/camisetas'
}, {
  label: 'Casacos',
  photo: _assets_categories_casacos_jpg__WEBPACK_IMPORTED_MODULE_2___default.a,
  link: 'produtos/camisetas'
}, {
  label: 'Acessorios',
  photo: _assets_categories_acessorios_jpg__WEBPACK_IMPORTED_MODULE_3___default.a,
  link: 'produtos/camisetas'
}]);

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

/***/ 3:
/*!*******************************!*\
  !*** multi ./pages/index.jsx ***!
  \*******************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\Danilo\Documents\GitHub\WithoffStore\Web\pages\index.jsx */"./pages/index.jsx");


/***/ }),

/***/ "core-js/library/fn/map":
/*!*****************************************!*\
  !*** external "core-js/library/fn/map" ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/map");

/***/ }),

/***/ "core-js/library/fn/object/assign":
/*!***************************************************!*\
  !*** external "core-js/library/fn/object/assign" ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/assign");

/***/ }),

/***/ "core-js/library/fn/object/define-property":
/*!************************************************************!*\
  !*** external "core-js/library/fn/object/define-property" ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/define-property");

/***/ }),

/***/ "core-js/library/fn/object/get-own-property-descriptor":
/*!************************************************************************!*\
  !*** external "core-js/library/fn/object/get-own-property-descriptor" ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("core-js/library/fn/object/get-own-property-descriptor");

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

/***/ "next-server/dist/lib/router-context":
/*!******************************************************!*\
  !*** external "next-server/dist/lib/router-context" ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next-server/dist/lib/router-context");

/***/ }),

/***/ "next-server/dist/lib/router/rewrite-url-for-export":
/*!*********************************************************************!*\
  !*** external "next-server/dist/lib/router/rewrite-url-for-export" ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next-server/dist/lib/router/rewrite-url-for-export");

/***/ }),

/***/ "next-server/dist/lib/router/router":
/*!*****************************************************!*\
  !*** external "next-server/dist/lib/router/router" ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next-server/dist/lib/router/router");

/***/ }),

/***/ "next-server/dist/lib/utils":
/*!*********************************************!*\
  !*** external "next-server/dist/lib/utils" ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next-server/dist/lib/utils");

/***/ }),

/***/ "next/router":
/*!******************************!*\
  !*** external "next/router" ***!
  \******************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("next/router");

/***/ }),

/***/ "prop-types":
/*!*****************************!*\
  !*** external "prop-types" ***!
  \*****************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("prop-types");

/***/ }),

/***/ "prop-types-exact":
/*!***********************************!*\
  !*** external "prop-types-exact" ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("prop-types-exact");

/***/ }),

/***/ "react":
/*!************************!*\
  !*** external "react" ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("react");

/***/ }),

/***/ "react-redux":
/*!******************************!*\
  !*** external "react-redux" ***!
  \******************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("react-redux");

/***/ }),

/***/ "url":
/*!**********************!*\
  !*** external "url" ***!
  \**********************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = require("url");

/***/ })

/******/ });
//# sourceMappingURL=index.js.map