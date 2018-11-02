import { variables } from "../const/const";
import { toggleExistClass, toggleNotExistClass } from "../const/toggleClass";

// обнуление кликабельности кнопок

function resetClick() {
	var elems = document.getElementsByClassName('js-reset-click');
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', function(event) {
			event.preventDefault();
		})
	}
}

// убираем событие "скролл"

function disableScroll() {
	window.scrollTo(0, variables.yOffset);
}

function disableScrollEvent() {
	variables.yOffset = window.pageYOffset;
	window.addEventListener('scroll', disableScroll);
}

// возвращаем событие "скролл"

function enableScrollEvent() {
	window.removeEventListener('scroll', disableScroll);
}

// popup

function showPopup(popupClass) {
	toggleExistClass('modal', 'hidden');
	toggleExistClass(popupClass, 'hidden');
	disableScrollEvent();
	// обработчик событий для возможности отключить popup кликнув по внешней области
	window.addEventListener('click', hidePopupClickArea);
}

function hidePopup(popupClass) {
	toggleNotExistClass('modal', 'hidden');
	toggleNotExistClass(popupClass, 'hidden');
	enableScrollEvent();
}

function showPopupEvent(buttonClass, popupClass) {
	var elems = document.getElementsByClassName(buttonClass);
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', function() {
			showPopup(popupClass);
		})
	}
}

// скрываем попап по нажатию по пустому полю

function hidePopupClickArea(event) {
	var modal = document.getElementsByClassName('modal')[0];
	if (event.target == modal) {
		hidePopup('js-modal-basket');
		hidePopup('js-modal-callback');
		// удаляем обработчик событий
		window.removeEventListener('click', hidePopupClickArea);
	}
}

function hidePopupEvent(buttonClass, popupClass) {
	var elems = document.getElementsByClassName(buttonClass);
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', function() {
			hidePopup(popupClass);
		})
	}
}

export { showPopupEvent, hidePopupEvent, resetClick };