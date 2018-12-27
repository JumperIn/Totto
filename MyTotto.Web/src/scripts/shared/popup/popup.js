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

// popup

let popupClassWrapper;

function showPopup(popupClass) {
	popupClassWrapper = popupClass;
	toggleExistClass(popupClass, 'hidden');
	addBodyProperties();
	window.addEventListener('keydown', hidePopupEscapeEvent);
	// обработчик событий для возможности отключить popup кликнув по внешней области
	window.addEventListener('click', e => hidePopupClickArea(e, popupClass));
}

function hidePopup(popupClass) {
	toggleNotExistClass(popupClass, 'hidden');
	removeBodyProperties();
	window.removeEventListener('keydown', hidePopupEscapeEvent);
	window.removeEventListener('click', hidePopupClickArea);
}

function showPopupEvent(buttonClass, popupClass) {
	var elems = document.getElementsByClassName(buttonClass);
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', (e) => {
			e.preventDefault();
			showPopup(popupClass);
		});
	}
}

// скрываем попап по нажатию по пустому полю и на клавишу ESC

// задаю класс popup через замыкание, а не передаю параметром, для того
// чтобы можно было добавлять и удалять обработчики событий, вызывающие эти функции

function hidePopupEscapeEvent(event) {
	if (event.keyCode == 27) {
		hidePopup(popupClassWrapper);
	}
}

function hidePopupClickArea(event) {
	let modal = document.getElementsByClassName(popupClassWrapper)[0];
	if (event.target == modal) {
		hidePopup(popupClassWrapper);
	}
}

function hidePopupEvent(buttonClass, popupClass) {
	let buttons = document.getElementsByClassName(buttonClass);
	for (var i = 0; i < buttons.length; i++) {
		buttons[i].addEventListener('click', () => hidePopup(popupClass));
	}
}

function PopupEvents(popupClass, openButtonClass, closeButtonsClass) {
	showPopupEvent(openButtonClass, popupClass)
	hidePopupEvent(closeButtonsClass, popupClass);
}

export { PopupEvents, hidePopup };