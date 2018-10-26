var constants = (function() {
	var constants = {
		SCREEN_SMALL: 576,
		SCREEN_MEDIUM: 768,
		SCREEN_LARGE: 992,
		SCREEN_EXTRA_LARGE: 1200
	}
	return constants;
})();

var variables = (function() {
	function getBannersLengthWrapper() {
		var elem = document.getElementsByClassName('banners-wrapper')[0];
		return elem.children.length
	}
	var variables = {
		numNewProductsDisp: 1,
		numPromoProductsDisp: 1,
		shiftNewProducts: 0,
		shiftPromoProducts: 0,
		shiftBanners: 0,
		numBanners: getBannersLengthWrapper(),
	}
	return variables;
})();

export { constants, variables };