export var module1 = (function() {
	var a = 20;
		module1 = {};

	module1.getModule = function() {
		return a;
	} 

	return module1;
})();

