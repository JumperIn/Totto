import { variables } from "../const/const";
import { toggleExistClass, toggleNotExistClass } from "../const/toggleClass";

// задаём для body свойства

function addBodyProperties() {
	var body = document.body;
	variables.yOffset = window.pageYOffset;
	body.style.width = '100%';
	body.style.top = '-' + variables.yOffset + 'px';
	body.style.position = 'fixed';
	body.style.overflowY = 'scroll';
}

// удаляем свойства у body

function removeBodyProperties() {
	var body = document.body;
	body.style.width = null;
	body.style.top = null;
	body.style.position = null;
	body.style.overflowY = null;
	window.scrollTo(0, variables.yOffset);
}

// функция обнуления кликабельности

function prevDefault(e) {
	e.preventDefault();
}

// обнуление кликабельности кнопок

function resetClick() {
	var elems = document.getElementsByClassName('js-reset-click');
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', prevDefault)
	}
}

// popup

function showPopup(popupClass) {
	toggleExistClass('modal', 'hidden');
	toggleExistClass(popupClass, 'hidden');
	addBodyProperties();


	// обработчик событий для возможности отключить popup кликнув по внешней области
	window.addEventListener('click', hidePopupClickArea);
}

function hidePopup(popupClass) {
	toggleNotExistClass('modal', 'hidden');
	toggleNotExistClass(popupClass, 'hidden');
	removeBodyProperties()
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