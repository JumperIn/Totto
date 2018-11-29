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
		if (elem) {
			return elem.children.length;
		}
	}
	var variables = {
		// переменные для свайпа
		stateSwipe: false,
		timeStampStart: 0,
		timeStampEnd: 0,
		startX: 0,
		endX: 0,
		// переменная для попапов
		yOffset: 0,
		numProductsDisp: [0, 0],
		shift: [0, 0],
		shiftBanners: 0,
		numBanners: getBannersLengthWrapper(),
	}
	return variables;
})();

export { constants, variables };