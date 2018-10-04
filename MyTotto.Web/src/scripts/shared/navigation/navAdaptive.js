import { toggleExistClass, toggleNotExistClass, toggleIcon, toggleExistIcon } from "../const/toggleClass";
import { constants } from "../const/const";

function dropDownMenu() {
	adaptMenu();
	dropDownMenuEvent();
}

function adaptMenu() {
	if (window.innerWidth < constants.SCREEN_MEDIUM) {
		hideMenu();
	} else if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		showMenu();
	}
}

function dropDownMenuEvent() {
	var elem1 = document.getElementsByClassName('menu-title')[0];
	var elem2 = document.getElementsByClassName('menu__list')[0];
	var elem3 = document.getElementsByClassName('menu-title__icon-toggle')[0];
	elem1.addEventListener('click', function () {
		if (!elem2.classList.contains('hidden')) {
			hideMenu();
		} else {
			elem2.classList.toggle('hidden');
		}
		toggleIcon(elem3, '#icon-angle-bottom', '#icon-angle-top');
	})
}


function dropDownListEvent() {
	var elems1 = document.getElementsByClassName('accordion');
	var elems2 = document.getElementsByClassName('menu-item__icon-drop-toggle');
    for (var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', function () {
            var panel = this.parentElement.nextElementSibling;
            if (window.innerWidth < constants.SCREEN_MEDIUM) {
				this.classList.toggle('icon-accordion-active');
				this.parentElement.classList.toggle('accordion-active');
				panel.classList.toggle('hidden');
				toggleIcon(elem, '#icon-plus', '#icon-minus');
            }
        })
	}
}


function dropDownItemEvent() {
	var elems1 = document.getElementsByClassName('accordion-list');
	var elems2 = document.getElementsByClassName('menu-drop__icon-toggle');
	for (var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', function () {
			this.classList.toggle('sub-accordion-active');
			var panel = this.parentElement.nextElementSibling;
			panel.classList.toggle('hidden');
			toggleIcon(elem, '#icon-plus', '#icon-minus');
		})
	}
}

function hideMenu() {
	//menu
	toggleNotExistClass('menu__list', 'hidden');
	toggleExistIcon('menu-title__icon-toggle', '#icon-angle-bottom', '#icon-angle-top')

	//list
	hideList();
	//item
	hideItem();
}

function hideList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('menu-drop', 'hidden', i);
		toggleNotExistClass('menu-drop__title', 'hidden', i);
		toggleNotExistClass('menu-drop-img', 'hidden', i);
		toggleExistClass('accordion', 'icon-accordion-active', i);
		toggleExistClass('accordion', 'hidden', i);
		toggleExistClass('menu__wrap', 'accordion-active', i);
		toggleExistIcon('menu-item__icon-drop-toggle', '#icon-plus', '#icon-minus', i);
	}
}

function hideItem() {
	var elems = document.getElementsByClassName('accordion-list');
    for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('menu-drop__list', 'hidden', i);
		toggleExistClass('accordion-list', 'sub-accordion-active', i);
		toggleExistClass('accordion-list', 'hidden', i);
		toggleExistIcon('menu-drop__icon-toggle', '#icon-plus', '#icon-minus', i);
	}
}

function showMenu() {
	//menu
	var elem = document.getElementsByClassName('menu-title')[0];
	elem.nextElementSibling.classList.remove('hidden');
	//list
	showList();
	//item
	showItem();
}

function showList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		elems[i].parentElement.nextElementSibling.classList.remove('hidden');
		elems[i].parentElement.classList.remove('accordion-active');
		elems[i].classList.remove('icon-accordion-active');
		toggleExistClass('menu-drop__title', 'hidden', i);
		toggleExistClass('menu-drop-img', 'hidden', i);
		toggleNotExistClass('accordion', 'hidden', i);
	}
}

function showItem() {
	var elems = document.getElementsByClassName('accordion-list');
    for (var i = 0; i < elems.length; i++) {
		elems[i].parentElement.nextElementSibling.classList.remove('hidden');
		elems[i].classList.remove('sub-accordion-active');
		elems[i].classList.toggle('hidden');
	}
}

// отцентровать выпадающие списки из навигации

function toCenterDropMenu() {
	var elems1 = document.getElementsByClassName('menu-drop');
	var elems2 = document.getElementsByClassName('menu__wrap');
	if (window.innerWidth < constants.SCREEN_MEDIUM) {
		for ( var i = 0; i < elems1.length; i++) {
			elems1[i].style.left = `0px`;
		}
	} else if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		for ( var i = 0; i < elems1.length; i++) {
			elems1[i].style.display = "flex";
	
			var widthMenu = elems1[i].offsetWidth;
			var widthTitle = elems2[i].offsetWidth;
	
			elems1[i].style.left = `-${(widthMenu/2) - (widthTitle/2)}px`;
	
			elems1[i].style.display = "";
		}
	}
}

export { dropDownMenu, dropDownListEvent, dropDownItemEvent, hideMenu, showMenu, toCenterDropMenu };