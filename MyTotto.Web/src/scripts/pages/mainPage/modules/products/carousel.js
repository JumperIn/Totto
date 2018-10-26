import { constants, variables } from "../../../../shared/const/const";

function returnCarouselBack(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.style.transform = 'translateX(0px)';
}

function getNumNewProductDisp(i) {
	if (window.innerWidth > 0) { variables.numProductsDisp[i] = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numProductsDisp[i] = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numProductsDisp[i] = 3; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numProductsDisp[i] = 4; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numProductsDisp[i] = 4; };
}

function getNumPromoProductDisp(i) {
	if (window.innerWidth > 0) { variables.numProductsDisp[i] = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numProductsDisp[i] = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numProductsDisp[i] = 2; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numProductsDisp[i] = 3; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numProductsDisp[i] = 3; };
}

function getProductWidth(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	return elem.firstElementChild.offsetWidth;
};

function getLengthWrapper(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
    return elem.children.length;
}

function moveCarouselRight(classWrapper, i) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var distanceTolastProduct = (getLengthWrapper(classWrapper) - variables.numProductsDisp[i]) * getProductWidth(classWrapper);
    var returnToStartCondition = variables.shift[i] == distanceTolastProduct || variables.shift[i] > distanceTolastProduct;
    if (returnToStartCondition) {
        variables.shift[i] = 0;
        elem.style.transform = 'translateX(-' + +variables.shift[i] + 'px)';
    } else {
        variables.shift[i] = +variables.shift[i] + +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shift[i] + 'px)';
	}
};
function moveCarouselRightEvent(classButtonRight, classWrapper, i) {
	var elem = document.getElementsByClassName(classButtonRight)[0];
    elem.addEventListener('click', function() {
		moveCarouselRight(classWrapper, i);
	})
};

function moveCarouselLeft(classWrapper, i) {
    var elem = document.getElementsByClassName(classWrapper)[0];
    var returnToEndCondition = variables.shift[i] == 0 || variables.shift[i] < 0;
    if (returnToEndCondition) {
        variables.shift[i] = (getLengthWrapper(classWrapper) - variables.numProductsDisp[i]) * getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shift[i] + 'px)';
    } else {
        variables.shift[i] = +variables.shift[i] - +getProductWidth(classWrapper);
        elem.style.transform = 'translateX(-' + +variables.shift[i] + 'px)';
	}
};
function moveCarouselLeftEvent(classButtonLeft, classWrapper, i) {
    var elem = document.getElementsByClassName(classButtonLeft)[0];
    elem.addEventListener('click', function() {
		moveCarouselLeft(classWrapper, i);
	})
};

function moveCarouselEvent(classButtonRight, classButtonLeft, classWrapper, i) {
	moveCarouselRightEvent(classButtonRight, classWrapper, i);
	moveCarouselLeftEvent(classButtonLeft, classWrapper, i);
}

export { getNumNewProductDisp, getNumPromoProductDisp, moveCarouselEvent, returnCarouselBack };