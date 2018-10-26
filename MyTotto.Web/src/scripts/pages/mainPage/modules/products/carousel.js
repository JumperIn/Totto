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
	console.log('widthProduct: ' +elem.firstElementChild.offsetWidth);
	return elem.firstElementChild.offsetWidth;
};

function getLengthWrapper(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	console.log('LengthWrapper: ' +elem.children.length)
    return elem.children.length
}

function moveCarouselRight(classWrapper) {
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
function moveCarouselRightEvent(classButtonRight, classWrapper) {
	var elem = document.getElementsByClassName(classButtonRight)[0];
    elem.addEventListener('click', function() {
		moveCarouselRight(classWrapper);
	})
};

function moveCarouselLeft(classWrapper) {
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
function moveCarouselLeftEvent(classButtonLeft, classWrapper) {
    var elem = document.getElementsByClassName(classButtonLeft)[0];
    elem.addEventListener('click', function() {
		moveCarouselLeft(classWrapper);
	})
};

function moveCarouselEvent(classButtonRight, classButtonLeft, classWrapper) {
	moveCarouselRightEvent(classButtonRight, classWrapper);
	moveCarouselLeftEvent(classButtonLeft, classWrapper);
}

export { getNumNewProductDisp, getNumPromoProductDisp, moveCarouselEvent, returnCarouselBack };