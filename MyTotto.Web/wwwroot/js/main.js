'use strict';

//Константы и переменные

var constants = {
	SCREEN_SMALL: 576,
	SCREEN_MEDIUM: 768,
	SCREEN_LARGE: 992,
	SCREEN_EXTRA_LARGE: 1200

};
var variables = {
	numProductsDisp: 1,
	shiftProducts: 0,
	shiftBanners: 0,
	numBanners: getBannersLengthWrapper()

	//Адаптивность сайта

};function resize() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function () {
		clearTimeout(timeOut);
		timeOut = setTimeout(function () {
			//условия нужны для отслеживания события, когда ширина экрана переходит
			//из области от (0 до 768) в область (>= 768) и обратно.
			if (window.innerWidth > 0 && window.innerWidth < constants.SCREEN_MEDIUM && windowWidth >= constants.SCREEN_MEDIUM) {
				hideMenu();
				hideDropNavAdaptive();
				adaptFooter();
				windowWidth = window.innerWidth;
			} else if (window.innerWidth >= constants.SCREEN_MEDIUM && window.innerWidth < 1920 && windowWidth < constants.SCREEN_MEDIUM) {
				showMenu();
				scrollNavEvent();
				adaptFooter();
				windowWidth = window.innerWidth;
			}
			//для нормального отображения банеров и карусели, при изменении ширины экрана они плавно возвращаются в начальное положение
			variables.shiftProducts = 0;
			variables.shiftBanners = 0;
			//данные функции выполняются при каждом событии изменения экрана, для адаптивной работы баннеров и карусели
			getNumProductDisp();
			returnBannerBack();
			returnCarouselBack(0);
			returnCarouselBack(1);
			returnCarouselBack(2);
		}, 200);
	});
}
resize();

function returnCarouselBack() {
	var j = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 0;

	var elem = document.getElementsByClassName('products-wrapper')[j];
	elem.style.transform = 'translateX(0px)';
}

function returnBannerBack() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
}

//карусель
function getNumProductDisp() {
	if (window.innerWidth > 0) {
		variables.numProductsDisp = 1;
	};
	if (window.innerWidth >= constants.SCREEN_SMALL) {
		variables.numProductsDisp = 2;
	};
	if (window.innerWidth >= constants.SCREEN_MEDIUM) {
		variables.numProductsDisp = 3;
	};
	if (window.innerWidth >= constants.SCREEN_LARGE) {
		variables.numProductsDisp = 4;
	};
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) {
		variables.numProductsDisp = 4;
	};
}
getNumProductDisp();

function getProductWidth(j) {
	var elem = document.getElementsByClassName('products-wrapper')[j];
	return elem.firstElementChild.offsetWidth;
};

function getLengthWrapper(j) {
	var elem = document.getElementsByClassName('products-wrapper')[j];
	return elem.children.length;
}

function moveCarouselRight(j) {
	var elem = document.getElementsByClassName('products-wrapper')[j];
	//граничное условие, при котором необходимо вернуть карусель в начальное состояние
	var distanceTolastProduct = (getLengthWrapper(j) - variables.numProductsDisp) * getProductWidth(j);
	var returnToStartCondition = variables.shiftProducts == distanceTolastProduct || variables.shiftProducts > distanceTolastProduct;
	if (returnToStartCondition) {
		variables.shiftProducts = 0;
		elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
	} else {
		variables.shiftProducts = +variables.shiftProducts + +getProductWidth(j);
		elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
	}
};
function moveCarouselRightEvent(j) {
	var elem = document.getElementById('moveCarouselRight' + j);
	elem.addEventListener('click', function () {
		moveCarouselRight(j);
	});
};
moveCarouselRightEvent(0);
moveCarouselRightEvent(1);
moveCarouselRightEvent(2);

function moveCarouselLeft(j) {
	var elem = document.getElementsByClassName('products-wrapper')[j];
	var returnToEndCondition = variables.shiftProducts == 0 || variables.shiftProducts < 0;
	if (returnToEndCondition) {
		variables.shiftProducts = (getLengthWrapper(j) - variables.numProductsDisp) * getProductWidth(j);
		elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
	} else {
		variables.shiftProducts = +variables.shiftProducts - +getProductWidth(j);
		elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
	}
};
function moveCarouselLeftEvent(j) {
	var elem = document.getElementById('moveCarouselLeft' + j);
	elem.addEventListener('click', function () {
		moveCarouselLeft(j);
	});
};
moveCarouselLeftEvent(0);
moveCarouselLeftEvent(1);
moveCarouselLeftEvent(2);

function toggleProductsEvent() {
	var elems = document.getElementsByClassName('main-nav__item');
	// за цикл присваивается три обработчика событий на кнопки: "Новинки", "Хиты продаж", "Скидки и акции"

	var _loop = function _loop(i) {
		elems[i].addEventListener('click', function () {
			var arr = [0, 1, 2];
			// массив имеет 3 значения, так как есть всего 3 кнопки
			toggleExistClass('products', 'hidden', arr.splice(i, 1)[0]);
			toggleNotExistClass('products', 'hidden', arr[0]);
			toggleNotExistClass('products', 'hidden', arr[1]);
			returnCarouselBack(0);
			variables.shiftProducts = 0;
		});
	};

	for (var i = 0; i < elems.length; i++) {
		_loop(i);
	}
}
toggleProductsEvent();

//анимация main-nav
function setClasses() {
	var itemsNav = document.getElementsByClassName('main-nav__item');
	for (var i = 0; i < itemsNav.length; i++) {
		itemsNav[i].addEventListener('click', function (event) {
			for (var j = 0; j < itemsNav.length; j++) {
				itemsNav[j].classList.remove('main-nav__item_active');
			}
			event.target.classList.add('main-nav__item_active');
		});
	}
}
setClasses();

//слайдер баннера
function getBannerWidth() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	return elem.offsetWidth;
};
function getBannersLengthWrapper() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	return elem.children.length;
}

function moveBannerRight() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	var returnToStartCondition = variables.shiftBanners == (variables.numBanners - 1) * getBannerWidth() || variables.shiftBanners > (variables.numBanners - 1) * getBannerWidth();
	if (returnToStartCondition) {
		variables.shiftBanners = 0;
		elem.style.transform = 'translateX(-' + +variables.shiftBanners + 'px)';
	} else {
		variables.shiftBanners = +variables.shiftBanners + +getBannerWidth();
		elem.style.transform = 'translateX(-' + +variables.shiftBanners + 'px)';
	}
}

function moveBannerRightEvent() {
	var elem = document.getElementById('moveBannerRight');
	elem.addEventListener('click', moveBannerRight);
};
moveBannerRightEvent();

function moveBannerLeft() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	var returnToEndCondition = variables.shiftBanners == 0 || variables.shiftBanners < 0;
	if (returnToEndCondition) {
		variables.shiftBanners = (variables.numBanners - 1) * getBannerWidth();
		elem.style.transform = 'translateX(-' + +variables.shiftBanners + 'px)';
	} else {

		variables.shiftBanners = +variables.shiftBanners - +getBannerWidth();
		elem.style.transform = 'translateX(-' + +variables.shiftBanners + 'px)';
	}
}

function moveBannerLeftEvent() {
	var elem = document.getElementById('moveBannerLeft');
	elem.addEventListener('click', moveBannerLeft);
};
moveBannerLeftEvent();

//таймер слайда баннеров
function slideBannerTimer() {
	var slideBanner = setInterval(moveBannerRight, 4000);
	var stopMoveBanner = function stopMoveBanner() {
		var elem = document.getElementsByClassName('banners')[0];
		elem.addEventListener('mouseover', function () {
			clearInterval(slideBanner);
		});
	};
	stopMoveBanner();
}
slideBannerTimer();

function moveBannerMouseOut() {
	var elem = document.getElementsByClassName('banners')[0];
	elem.addEventListener('mouseout', slideBannerTimer);
}
moveBannerMouseOut();

//scroll-navigation

function scrollNavEvent() {
	var elem = document.getElementsByClassName('header')[0];
	var heightToggle = 0;
	window.onscroll = function () {
		if (window.pageYOffset > elem.offsetHeight && heightToggle < elem.offsetHeight) {
			heightToggle = window.pageYOffset;
			showDropNav();
		} else if (window.pageYOffset < elem.offsetHeight && heightToggle > elem.offsetHeight) {
			heightToggle = 0;
			hideDropNav();
		}
	};
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
	window.onscroll = {};
}

if (window.innerWidth >= constants.SCREEN_MEDIUM) {
	scrollNavEvent();
}

function toggleClass(class1, class2) {
	var j = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : 0;

	var elem = document.getElementsByClassName(class1)[j];
	elem.classList.toggle(class2);
}

function toggleNotExistClass(class1, class2) {
	var j = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : 0;

	var elem = document.getElementsByClassName(class1)[j];
	if (!elem.classList.contains(class2)) {
		elem.classList.toggle(class2);
	}
}

function toggleExistClass(class1, class2) {
	var j = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : 0;

	var elem = document.getElementsByClassName(class1)[j];
	if (elem.classList.contains(class2)) {
		elem.classList.toggle(class2);
	}
}

function dropDownNav() {
	var elem = document.getElementsByClassName('header-info__icon')[0];
	elem.addEventListener('click', function () {
		this.classList.toggle('header-info__icon_active');
		toggleClass('header-nav', 'hidden');
		toggleClass('header-info', 'header-info_shadow');
	});
}
dropDownNav();

//Адаптивность навигации

function dropDownMenu() {
	adaptMenu();
	// adaptDropDownMenu();
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
	});
}

dropDownMenu();

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
		});
	}
}

dropDownListEvent();

function dropDownItemEvent() {
	var elems = document.getElementsByClassName('accordion-list');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
			this.classList.toggle('sub-accordion-active');
			this.classList.toggle('fa-plus');
			this.classList.toggle('fa-minus');
			var panel = this.parentElement.nextElementSibling;
			panel.classList.toggle('hidden');
		});
	}
}
dropDownItemEvent();

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
	var elems2 = document.getElementsByClassName('js-menu-wrapper');
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

//инфо-блок

function dropDownInfoItems() {
	var elems = document.getElementsByClassName('faq-accordion');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
			this.classList.toggle('faq-accordion-active');
			this.nextElementSibling.classList.toggle('hidden');
			this.lastElementChild.classList.toggle('fa-angle-down');
			this.lastElementChild.classList.toggle('fa-angle-up');
		});
	}
}
dropDownInfoItems();

//Адаптация футера

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
		toggleNotExistClass('footer-block__icon', 'hidden', i);
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
adaptFooter();

function dropDownFooterItems() {
	var elems = document.getElementsByClassName('footer-accordion');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
			this.nextElementSibling.classList.toggle('hidden');
			this.lastElementChild.classList.toggle('fa-angle-down');
			this.lastElementChild.classList.toggle('fa-angle-up');
		});
	}
}
dropDownFooterItems();