webpackHotUpdate("static\\development\\pages\\index.js",{

/***/ "./components/Slide.jsx":
/*!******************************!*\
  !*** ./components/Slide.jsx ***!
  \******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime-corejs2/helpers/esm/slicedToArray */ "./node_modules/@babel/runtime-corejs2/helpers/esm/slicedToArray.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! react */ "./node_modules/react/index.js");
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../static/assets/slides/nextSlide.svg */ "./static/assets/slides/nextSlide.svg");
/* harmony import */ var _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../static/assets/slides/previousSlide.svg */ "./static/assets/slides/previousSlide.svg");
/* harmony import */ var _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _InteractiveElement__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./InteractiveElement */ "./components/InteractiveElement.jsx");

var _jsxFileName = "C:\\Users\\Danilo\\Documents\\GitHub\\WithoffStore\\Web\\components\\Slide.jsx";




/* harmony default export */ __webpack_exports__["default"] = (function () {
  var _React$useState = react__WEBPACK_IMPORTED_MODULE_1__["useState"](2),
      _React$useState2 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState, 2),
      index = _React$useState2[0],
      setIndex = _React$useState2[1];

  var imgRef = react__WEBPACK_IMPORTED_MODULE_1__["useRef"]();

  var _React$useState3 = react__WEBPACK_IMPORTED_MODULE_1__["useState"]([0, 1, 2, 3, 4]),
      _React$useState4 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState3, 2),
      images = _React$useState4[0],
      setImages = _React$useState4[1];

  var _React$useState5 = react__WEBPACK_IMPORTED_MODULE_1__["useState"](0),
      _React$useState6 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState5, 2),
      slideWidth = _React$useState6[0],
      setSlideWidth = _React$useState6[1];

  var _React$useState7 = react__WEBPACK_IMPORTED_MODULE_1__["useState"](null),
      _React$useState8 = Object(_babel_runtime_corejs2_helpers_esm_slicedToArray__WEBPACK_IMPORTED_MODULE_0__["default"])(_React$useState7, 2),
      slides = _React$useState8[0],
      setSlides = _React$useState8[1];

  var timer = react__WEBPACK_IMPORTED_MODULE_1__["useRef"]();
  react__WEBPACK_IMPORTED_MODULE_1__["useEffect"](function () {
    var newSlides = images.map(function (e, eIndex) {
      return react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
        ref: imgRef,
        key: e,
        className: eIndex === index ? 'main image' : 'image',
        __source: {
          fileName: _jsxFileName,
          lineNumber: 15
        },
        __self: this
      }, react__WEBPACK_IMPORTED_MODULE_1__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_4__["default"], {
        tag: "img",
        onClick: function onClick() {
          setIndex(e);
        },
        src: "/static/assets/slides/".concat(e, ".svg"),
        alt: "Slide numero ".concat(e),
        __source: {
          fileName: _jsxFileName,
          lineNumber: 20
        },
        __self: this
      }));
    });
    setSlides(newSlides);
  }, [index, images]);
  react__WEBPACK_IMPORTED_MODULE_1__["useEffect"](function () {
    if (imgRef.current) {
      setSlideWidth(imgRef.current.offsetWidth);
    }
  });

  function handleNextSlide() {
    if (index <= images.length - 2) {
      setIndex(index + 1);
    }
  }

  function handlePreviousSlide() {
    if (index !== 0) {
      setIndex(index - 1);
    }
  }

  react__WEBPACK_IMPORTED_MODULE_1__["useEffect"](function () {
    // setTimeout(()=>{
    //   handleNextSlide()
    // }, 500)
    clearTimeout(timer.current);
    timer.current = setTimeout(function () {
      if (index <= images.length - 2) {
        setIndex(index + 1);
      } else {
        setIndex(0);
      }
    }, 4000);
    return function () {
      return clearTimeout(timer.current);
    };
  }, [index]); // const modifier = width<=425 ? 0 : (-0.12*slideWidth)

  return react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
    className: "overflow-not-allower",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 65
    },
    __self: this
  }, react__WEBPACK_IMPORTED_MODULE_1__["createElement"]("div", {
    className: "Slide",
    style: {
      transform: "translateX(".concat(index * slideWidth * -1, "px)")
    },
    __source: {
      fileName: _jsxFileName,
      lineNumber: 66
    },
    __self: this
  }, slides), react__WEBPACK_IMPORTED_MODULE_1__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_4__["default"], {
    className: "left-slider-button",
    onClick: handlePreviousSlide,
    src: _static_assets_slides_previousSlide_svg__WEBPACK_IMPORTED_MODULE_3___default.a,
    alt: "Bot\xE3o Esquerdo do Slider",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 72
    },
    __self: this
  }), react__WEBPACK_IMPORTED_MODULE_1__["createElement"](_InteractiveElement__WEBPACK_IMPORTED_MODULE_4__["default"], {
    className: "right-slider-button",
    onClick: handleNextSlide,
    src: _static_assets_slides_nextSlide_svg__WEBPACK_IMPORTED_MODULE_2___default.a,
    alt: "Bot\xE3o Direito do Slider",
    tag: "img",
    __source: {
      fileName: _jsxFileName,
      lineNumber: 79
    },
    __self: this
  }));
});

/***/ })

})
//# sourceMappingURL=index.js.da5faa5f036d8327474e.hot-update.js.map