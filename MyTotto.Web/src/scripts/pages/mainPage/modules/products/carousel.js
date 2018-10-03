import { constants, variables } from "../../../../shared/const/const";

function returnCarouselBack(j = 0) {
	var elem = document.getElementsByClassName('products-wrapper')[j];
	elem.style.transform = 'translateX(0px)';
}

function getNumProductDisp() {
	if (window.innerWidth > 0) { variables.numProductsDisp = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numProductsDisp = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numProductsDisp = 3; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numProductsDisp = 4; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numProductsDisp = 4; };
}

function getProductWidth(j) {
    var elem = document.getElementsByClassName('products-wrapper')[j];
    return elem.firstElementChild.offsetWidth;
};

function getLengthWrapper(j) {
    var elem = document.getElementsByClassName('products-wrapper')[j];
    return elem.children.length
}

function moveCarouselRight(j) {
    var elem = document.getElementsByClassName('products-wrapper')[j];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var distanceTolastProduct = (getLengthWrapper(j) - variables.numProductsDisp) * getProductWidth(j);
    var returnToStartCondition = variables.shiftProducts == distanceTolastProduct || variables.shiftProducts > distanceTolastProduct;
    if (returnToStartCondition) {
        variables.shiftProducts = 0;
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    } else {
        variables.shiftProducts = +variables.shiftProducts + +getProductWidth(j);
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    }
};
function moveCarouselRightEvent(j) {
    var elem = document.getElementById('moveCarouselRight' + j);
    elem.addEventListener('click', function() {
		moveCarouselRight(j);
	})
};


function moveCarouselLeft(j) {
    var elem = document.getElementsByClassName('products-wrapper')[j];
    var returnToEndCondition = variables.shiftProducts == 0 || variables.shiftProducts < 0;
    if (returnToEndCondition) {
        variables.shiftProducts = (getLengthWrapper(j) - variables.numProductsDisp) * getProductWidth(j);
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    } else {
        variables.shiftProducts = +variables.shiftProducts - +getProductWidth(j);
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    }
};
function moveCarouselLeftEvent(j) {
    var elem = document.getElementById('moveCarouselLeft' + j);
    elem.addEventListener('click', function() {
		moveCarouselLeft(j);
	})
};

export { getNumProductDisp, moveCarouselRightEvent, moveCarouselLeftEvent, returnCarouselBack };