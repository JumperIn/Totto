var constants = (function () {
	var constants = {
		SCREEN_SMALL: 576,
		SCREEN_MEDIUM: 768,
		SCREEN_LARGE: 992,
		SCREEN_EXTRA_LARGE: 1200
	}
	return constants;
})();

var variables = (function () {
	var variables = {
		// переменная для попапов
		yOffset: 0,
	}
	return variables;
})();

export { constants, variables };