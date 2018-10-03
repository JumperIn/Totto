import { toggleExistClass, toggleNotExistClass } from "../const/toggleClass";
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
	elem1.addEventListener('click', function () {
		if (!elem2.classList.contains('hidden')) {
			hideMenu();
		} else {
			elem2.classList.toggle('hidden');
		}
	})
}


function dropDownListEvent() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
            var panel = this.parentElement.nextElementSibling;
            if (window.innerWidth < constants.SCREEN_MEDIUM) {
				this.classList.toggle('icon-accordion-active');
				this.parentElement.classList.toggle('accordion-active');
                this.classList.toggle('fa-plus');
                this.classList.toggle('fa-minus');
				panel.classList.toggle('hidden');
            }
        })
	}
}


function dropDownItemEvent() {
	var elems = document.getElementsByClassName('accordion-list');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
			this.classList.toggle('sub-accordion-active');
			this.classList.toggle('fa-plus');
			this.classList.toggle('fa-minus');
			var panel = this.parentElement.nextElementSibling;
			panel.classList.toggle('hidden');
		})
	}
}

function hideMenu() {
	//menu
	toggleNotExistClass('menu__list', 'hidden');
	toggleExistClass('js-nav-wrapper', 'container_padding');

	//list
	hideList();
	//item
	hideItem();
}

function hideList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('accordion', 'fa-plus', i);
		toggleNotExistClass('menu-drop', 'hidden', i);
		toggleNotExistClass('menu-drop__title', 'hidden', i);
		toggleNotExistClass('menu-drop-img', 'hidden', i);
		toggleExistClass('accordion', 'fa-minus', i);
		toggleExistClass('accordion', 'icon-accordion-active', i);
		toggleExistClass('accordion', 'hidden', i);
		toggleExistClass('menu__wrap', 'accordion-active', i);
	}
}

function hideItem() {
	var elems = document.getElementsByClassName('accordion-list');
	var elems2 = document.getElementsByClassName('js-menu-wrapper')
    for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('accordion-list', 'fa-plus', i);
		toggleNotExistClass('menu-drop__list', 'hidden', i);
		toggleExistClass('accordion-list', 'fa-minus', i);
		toggleExistClass('accordion-list', 'sub-accordion-active', i);
		toggleExistClass('accordion-list', 'hidden', i);
	}
	for (var i = 0; i < elems2.length; i++) {
		toggleExistClass('js-menu-wrapper', 'container_padding', i);
	}
}

function showMenu() {
	//menu
	var elem = document.getElementsByClassName('menu-title')[0];
	elem.nextElementSibling.classList.remove('hidden');
	elem.parentElement.parentElement.classList.add('container_padding');
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
		elems[i].classList.remove('fa-plus');
		elems[i].classList.remove('fa-minus');
		toggleExistClass('menu-drop__title', 'hidden', i);
		toggleExistClass('menu-drop-img', 'hidden', i);
		toggleNotExistClass('accordion', 'hidden', i);
	}
}

function showItem() {
	var elems = document.getElementsByClassName('accordion-list');
	var elems2 = document.getElementsByClassName('js-menu-wrapper');
    for (var i = 0; i < elems.length; i++) {
		elems[i].parentElement.nextElementSibling.classList.remove('hidden');
		elems[i].classList.remove('sub-accordion-active');
		elems[i].classList.remove('fa-plus');
		elems[i].classList.remove('fa-minus');
		elems[i].classList.add('fa-plus');
		elems[i].classList.toggle('hidden');
	}
	for (var i = 0; i < elems2.length; i++) {
		elems2[i].classList.add('container_padding');
	}
}

// отцентровать выпадающие списки из навигации

function toCenterDropMenu() {
	var elems1 = document.getElementsByClassName('menu-drop');
	var elems2 = document.getElementsByClassName('menu__wrap');
	if (window.innerWidth < constants.SCREEN_MEDIUM) {
		for ( var i = 0; i < elems1.length; i++) {
			elems1[i].style.left = `0px`
		}
	} else if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		for ( var i = 0; i < elems1.length; i++) {
			elems1[i].style.display = "flex";
	
			var widthMenu = elems1[i].offsetWidth;
			var widthTitle = elems2[i].offsetWidth;
	
			elems1[i].style.left = `-${(widthMenu/2) - (widthTitle/2)}px`
	
			elems1[i].style.display = "";
		}
	}
}

//	Переключение иконки при нажатии блок

function toggleIcon(classClick, classToggle, icon1, icon2) {
	var elems1 = document.getElementsByClassName(classClick);
	var elems2 = document.getElementsByClassName(classToggle);
	for ( var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', function() {
			if (elem.getAttribute('xlink:href') === icon1) {
				elem.setAttribute('xlink:href', icon2);
			} else if (elem.getAttribute('xlink:href') === icon2) {
				elem.setAttribute('xlink:href', icon1);
			}
		})
	}
}

export { dropDownMenu, dropDownListEvent, dropDownItemEvent, hideMenu, showMenu, toCenterDropMenu, toggleIcon };