'ise strict';

import { constants } from "./constModule";
import { toggleExistClass, toggleNotExistClass } from "./toggleClassModule";

function hideFooterItems() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('footer-block__body', 'hidden', i);
	}
}

function showFooterItems() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleExistClass('footer-block__body', 'hidden', i);
	}
}

function hideFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('footer-block__icon', 'hidden', i)
	}
}

function showFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleExistClass('footer-block__icon', 'hidden', i);
	}
}

function toggleFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__icon');
	for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('footer-block__icon', 'fa-angle-down', i);
		toggleExistClass('footer-block__icon', 'fa-angle-up', i);
	}
}

function adaptFooter() {
	if (window.innerWidth < constants.SCREEN_MEDIUM) {
		hideFooterItems();
		showFooterIcons();
		toggleFooterIcons();
	} else if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		showFooterItems();
		hideFooterIcons();
		toggleFooterIcons();
	}
}
function dropDownFooterItems() {
	var elems = document.getElementsByClassName('footer-accordion');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function() {
			this.nextElementSibling.classList.toggle('hidden');
			this.lastElementChild.classList.toggle('fa-angle-down');
			this.lastElementChild.classList.toggle('fa-angle-up');
		})
	}
}

export { adaptFooter, dropDownFooterItems };