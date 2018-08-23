import { toggleExistClass, toggleNotExistClass } from "./toggleClassModule";
import { constants } from "./constModule";

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
	var elem = document.getElementsByClassName('menu-link')[0];
	elem.addEventListener('click', function () {
		var panel = this.nextElementSibling;
		if (!panel.classList.contains('hidden')) {
			hideMenu();
		} else {
			panel.classList.toggle('hidden');
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
		toggleExistClass('accordion', 'fa-minus', i);
		toggleExistClass('accordion', 'fa-angle-down', i);
		toggleExistClass('accordion', 'icon-accordion-active', i);
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
	var elem = document.getElementsByClassName('menu-link')[0];
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
		elems[i].classList.add('fa-angle-down');
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

export { dropDownMenu, dropDownListEvent, dropDownItemEvent, hideMenu, showMenu };