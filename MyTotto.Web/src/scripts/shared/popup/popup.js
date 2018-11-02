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

// убираем скролл

function disableScroll() {
	window.scrollTo(0, variables.yOffset);
}

function disableScrollEvent() {
	variables.yOffset = window.pageYOffset;
	window.addEventListener('scroll', disableScroll);
}

// возвращаем скролл

function enableScroll() {
	window.removeEventListener('scroll', disableScroll);
}

// popup для продукта

function showPopup() {
	toggleExistClass('modal', 'hidden');
	toggleExistClass('js-modal-basket', 'hidden');
	disableScrollEvent();
	// обработчик событий для возможности отключить popup кликнув по внешней области
	window.addEventListener('click', hidePopupClickArea);
}

function hidePopup() {
	toggleNotExistClass('modal', 'hidden');
	toggleNotExistClass('js-modal-basket', 'hidden');
	toggleNotExistClass('js-modal-basket', 'hidden');
	enableScroll();
}

function showPopupEvent() {
	var elems = document.getElementsByClassName('js-product-inbasket-modal');
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', function() {
			showPopup();
		})
	}
}

// скрываем попап по нажатию по пустому полю

function hidePopupClickArea(event) {
	var modal = document.getElementsByClassName('modal')[0];
	if (event.target == modal) {
		hidePopup();
		// удаляем обработчик событий
		window.removeEventListener('click', hidePopupClickArea);
	}
}

function hidePopupEvent() {
	var elems = document.getElementsByClassName('js-modal-close');
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', function() {
			hidePopup();
		})
	}
}

export { showPopupEvent, hidePopupEvent, resetClick };