import { variables } from "../const/const";
import { moveCarouselRight, moveCarouselLeft } from "../../pages/mainPage/modules/products/carousel";
import { moveBannerRight, moveBannerLeft } from "../../pages/mainPage/modules/banner/banner";

function swipeStart(e) {
	variables.stateSwipe = true;
	variables.timeStampStart = e.timeStamp;
	variables.startX = e.touches[0].clientX;
}

function swipeMove(e) {
	variables.endX = e.touches[0].clientX;
}

function swipeCancel(e) {
	variables.stateSwipe = false;
}

function swipeEnd(e, classWrapper, i) {
	var wrapper,
		wrapperWidth,
		difference,
		conditionSwipeLeft,
		conditionSwipeRight,
		deffTimeStamp;

	variables.timeStampEnd = e.timeStamp;

	deffTimeStamp = variables.timeStampEnd - variables.timeStampStart;
	// если время между началом свайпа и его концом больше секунды, то событие не происходит
	if (deffTimeStamp > 1000) {variables.stateSwipe = false}

	wrapper = document.getElementsByClassName(classWrapper)[0];
	wrapperWidth = wrapper.offsetWidth;

	difference = variables.startX - variables.endX;

	conditionSwipeLeft = -difference >= wrapperWidth/3;
	conditionSwipeRight = difference >= wrapperWidth/3;

	if (variables.stateSwipe === true) {
		if (classWrapper === 'discounts__wrapper' || classWrapper === 'new-products__wrapper') {
			if (conditionSwipeLeft) {
				moveCarouselLeft(classWrapper, i);
			} else if (conditionSwipeRight) {
				moveCarouselRight(classWrapper, i);
			}
		} else if (classWrapper === 'banners-wrapper') {
			if (conditionSwipeLeft) {
				moveBannerLeft();
			} else if (conditionSwipeRight) {
				moveBannerRight();
			}
		}
	} else {
		return;
	}
}

// Функции, присваивающие события на обёртку

function swipeStartEvent(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.addEventListener('touchstart', swipeStart);
}

function swipeMoveEvent(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.addEventListener('touchmove', swipeMove);
}

function swipeCancelEvent(classWrapper) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.addEventListener('touchcancel', swipeCancel);
}

function swipeEndEvent(classWrapper, i) {
	var elem = document.getElementsByClassName(classWrapper)[0];
	elem.addEventListener('touchend', function(e) {
		swipeEnd(e, classWrapper, i)
	});
}

// объединящая функция

function swipeEvent (classWrapper, i) {
	swipeStartEvent(classWrapper);
	swipeMoveEvent(classWrapper);
	swipeCancelEvent(classWrapper);
	swipeEndEvent(classWrapper, i);
}

export { swipeEvent };