import { constants } from "../const/const";
import { toggleExistClass, toggleNotExistClass, toggleIcon } from "../const/toggleClass";

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
	var elems1 = document.getElementsByClassName('footer-accordion');
	var elems2 = document.getElementsByClassName('footer-block__icon-toggle');
	for (var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', function() {
			this.nextElementSibling.classList.toggle('hidden');
			this.lastElementChild.classList.toggle('fa-angle-down');
			this.lastElementChild.classList.toggle('fa-angle-up');
			toggleIcon(elem, '#icon-angle-bottom', '#icon-angle-top')
		})
	}
}

export { adaptFooter, dropDownFooterItems };