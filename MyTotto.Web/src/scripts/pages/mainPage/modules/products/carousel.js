import { constants, variables } from "../../../../shared/const/const";

function returnCarouselBack(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.style.transform = 'translateX(0px)';
}

function getNumNewProductDisp() {
	if (window.innerWidth > 0) { variables.numNewProductsDisp = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numNewProductsDisp = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numNewProductsDisp = 2; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numNewProductsDisp = 3; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numNewProductsDisp = 3; };
}

function getNumPromoProductDisp() {
	if (window.innerWidth > 0) { variables.numPromoProductsDisp = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numPromoProductsDisp = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numPromoProductsDisp = 3; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numPromoProductsDisp = 4; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numPromoProductsDisp = 4; };
}

function getProductWidth(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	return elem.firstElementChild.offsetWidth;
};

function getLengthWrapper(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
    return elem.children.length
}

// Карусель для новых продуктов

function moveCarouselNewProductRight(classWrapper) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var distanceTolastProduct = (getLengthWrapper(classWrapper) - variables.numNewProductsDisp) * getProductWidth(classWrapper);
    var returnToStartCondition = variables.shiftNewProducts == distanceTolastProduct || variables.shiftNewProducts > distanceTolastProduct;
    if (returnToStartCondition) {
        variables.shiftNewProducts = 0;
        elem.style.transform = 'translateX(-' + +variables.shiftNewProducts + 'px)';
    } else {
        variables.shiftNewProducts = +variables.shiftNewProducts + +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftNewProducts + 'px)';
	}
};
function moveCarouselNewProductRightEvent(classButtonRight, classWrapper) {
	var elem = document.getElementsByClassName(classButtonRight)[0];
    elem.addEventListener('click', function() {
		moveCarouselNewProductRight(classWrapper);
	})
};

function moveCarouselNewProductLeft(classWrapper) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    var returnToEndCondition = variables.shiftNewProducts == 0 || variables.shiftNewProducts < 0;
    if (returnToEndCondition) {
        variables.shiftNewProducts = (getLengthWrapper(classWrapper) - variables.numNewProductsDisp) * getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftNewProducts + 'px)';
    } else {
        variables.shiftNewProducts = +variables.shiftNewProducts - +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftNewProducts + 'px)';
	}
};
function moveCarouselNewProductLeftEvent(classButtonLeft, classWrapper) {
    var elem = document.getElementsByClassName(classButtonLeft)[0];
    elem.addEventListener('click', function() {
		moveCarouselNewProductLeft(classWrapper);
	})
};

function moveCarouselNewProductEvent(classButtonRight, classButtonLeft, classWrapper) {
	moveCarouselNewProductRightEvent(classButtonRight, classWrapper);
	moveCarouselNewProductLeftEvent(classButtonLeft, classWrapper);
}

// Карусель для промо продуктов


function moveCarouselPromoProductRight(classWrapper) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var distanceTolastProduct = (getLengthWrapper(classWrapper) - variables.numPromoProductsDisp) * getProductWidth(classWrapper);
    var returnToStartCondition = variables.shiftPromoProducts == distanceTolastProduct || variables.shiftPromoProducts > distanceTolastProduct;
    if (returnToStartCondition) {
        variables.shiftPromoProducts = 0;
        elem.style.transform = 'translateX(-' + +variables.shiftPromoProducts + 'px)';
    } else {
        variables.shiftPromoProducts = +variables.shiftPromoProducts + +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftPromoProducts + 'px)';
	}
};
function moveCarouselPromoProductRightEvent(classButtonRight, classWrapper) {
	var elem = document.getElementsByClassName(classButtonRight)[0];
    elem.addEventListener('click', function() {
		moveCarouselPromoProductRight(classWrapper);
	})
};

function moveCarouselPromoProductLeft(classWrapper) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    var returnToEndCondition = variables.shiftPromoProducts == 0 || variables.shiftPromoProducts < 0;
    if (returnToEndCondition) {
        variables.shiftPromoProducts = (getLengthWrapper(classWrapper) - variables.numPromoProductsDisp) * getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftPromoProducts + 'px)';
    } else {
        variables.shiftPromoProducts = +variables.shiftPromoProducts - +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shiftPromoProducts + 'px)';
	}
};
function moveCarouselPromoProductLeftEvent(classButtonLeft, classWrapper) {
    var elem = document.getElementsByClassName(classButtonLeft)[0];
    elem.addEventListener('click', function() {
		moveCarouselPromoProductLeft(classWrapper);
	})
};

function moveCarouselPromoProductEvent(classButtonRight, classButtonLeft, classWrapper) {
	moveCarouselPromoProductRightEvent(classButtonRight, classWrapper);
	moveCarouselPromoProductLeftEvent(classButtonLeft, classWrapper);
}

export { getNumNewProductDisp, getNumPromoProductDisp, moveCarouselNewProductEvent, moveCarouselPromoProductEvent, returnCarouselBack };