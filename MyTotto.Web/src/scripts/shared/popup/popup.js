import { variables } from "../const/const";
import { toggleExistClass, toggleNotExistClass } from "../const/toggleClass";

// функция обнуления кликабельности

function prevDefault(e) {
	e.preventDefault();
}

function prevDefaultModal(e) {
	var modal = document.getElementsByClassName('modal')[0];
	if (event.target == modal) {
		e.preventDefault();
	}
}

// обнуление кликабельности кнопок

function resetClick() {
	var elems = document.getElementsByClassName('js-reset-click');
	for ( var i = 0; i < elems.length; i++ ) {
		elems[i].addEventListener('click', prevDefault)
	}
}

// убираем событие "скролл"

function disableScroll() {
	window.scrollTo(0, variables.yOffset);
}

function disableScrollEvent() {
	variables.yOffset = window.pageYOffset;
	window.addEventListener('scroll', disableScroll);
	// обработчики, устроняющие баг с дёрганием страницы, при попытки скрола или свайпа при открытом попапе
	// убирают возможность свайпа или скрола колесиком мыши вне попапа, при этом сам попап можно прокручивать
	window.addEventListener('touchstart', prevDefaultModal, { passive: false }); 
	window.addEventListener('wheel', prevDefaultModal, { passive: false });
}

// возвращаем событие "скролл"

function enableScrollEvent() {
	window.removeEventListener('scroll', disableScroll);
	window.removeEventListener('touchstart', prevDefaultModal, { passive: false }); 
	window.removeEventListener('wheel', prevDefaultModal, { passive: false });
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