import { constants } from "../const/const";
import { toggleClass, toggleExistClass, toggleNotExistClass } from "../const/toggleClass";

function scrollNavEvent() {	
	if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		var elem = document.getElementsByClassName('header')[0];
		var heightToggle = 0;
		window.onscroll = function() {
			if (window.pageYOffset > elem.offsetHeight && heightToggle < elem.offsetHeight) {
				heightToggle = window.pageYOffset;
				showDropNav();
				
			} else if (window.pageYOffset < elem.offsetHeight && heightToggle > elem.offsetHeight) {
				heightToggle = 0;
				hideDropNav();
			}
		}
	}
}

function showDropNav() {
	toggleClass('header-info', 'header-info_fixed');
	toggleClass('header-nav', 'header-nav_fixed');
	toggleClass('header-info-logo', 'header-info-logo_padding');
	toggleClass('header-info-search_flex', 'col-md-7');
	toggleClass('header-info-search_flex', 'col-md-6');
	toggleClass('header-info__icon-wrapper', 'hidden');
	toggleNotExistClass('header-nav', 'hidden');
	toggleClass('header-title', 'header-title_height');
	toggleClass('header-info', 'header-info_shadow');
}

function hideDropNav() {
	toggleClass('header-info', 'header-info_fixed');
	toggleClass('header-nav', 'header-nav_fixed');
	toggleClass('header-info-logo', 'header-info-logo_padding');
	toggleClass('header-info-search_flex', 'col-md-7');
	toggleClass('header-info-search_flex', 'col-md-6');
	toggleClass('header-info__icon-wrapper', 'hidden');
	toggleExistClass('header-nav', 'hidden');
	toggleExistClass('header-info__icon', 'header-info__icon_active');
	toggleClass('header-title', 'header-title_height');
	toggleExistClass('header-info', 'header-info_shadow');	
}

function hideDropNavAdaptive() {
	var elem = document.getElementsByClassName('header')[0];
	if (window.pageYOffset > elem.offsetHeight) {
		hideDropNav();
	}
	window.onscroll = {}
}

function dropDownNav() {
	var elem = document.getElementsByClassName('header-info__icon')[0];
	elem.addEventListener('click', function() {
		this.classList.toggle('header-info__icon_active');
		toggleClass('header-nav', 'hidden');
		toggleClass('header-info', 'header-info_shadow');
	})
}

export { scrollNavEvent, hideDropNavAdaptive, dropDownNav };