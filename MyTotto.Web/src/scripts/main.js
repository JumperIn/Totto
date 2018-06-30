'use strict'

//карусель
var x;
if(window.matchMedia('(min-width: 0px)').matches){ x = 1; };
if(window.matchMedia('(min-width: 576px)').matches){ x = 2; };
if(window.matchMedia('(min-width: 768px)').matches){ x = 3; };
if(window.matchMedia('(min-width: 992px)').matches){ x = 4; };
if(window.matchMedia('(min-width: 1200px)').matches){ x = 4; };

var getProductWidth = function() {
	var elem = document.getElementsByClassName('main-content-products__item')[0];
	return elem.offsetWidth;
};

var getLengthWrapper = function () {
	var elem = document.getElementsByClassName('products-wrapper')[0];
	return elem.children.length
}
var z = getLengthWrapper();
var shift = 0;

var moveCarouselRight = function() {
	var elem = document.getElementsByClassName('MoveCarouselRight')[0];
	elem.onclick = function() {
		var elem = document.getElementsByClassName('products-wrapper')[0];
		elem.style.transform = 'translateX(0px)';
		// if (shift == (z - x * (z / x - z % x / x))*getProductWidth()) {
		if (shift == (z - x)*getProductWidth() || shift > (z - x)*getProductWidth()) {
			shift = 0;
			elem.style.transform = 'translateX(-' + +shift + 'px)';
		} else {
			shift = +shift + +getProductWidth();
			elem.style.transform = 'translateX(-' + +shift + 'px)';
			console.log(shift);
		}
	}
};
moveCarouselRight();

var moveCarouselLeft = function() {
	var elem = document.getElementsByClassName('MoveCarouselLeft')[0];
	elem.onclick = function() {
		var elem = document.getElementsByClassName('products-wrapper')[0];
		elem.style.transform = 'translateX(0px)';
		if (shift == 0 || shift < 0) {
			// shift = (z - x * (z / x - z % x / x))*getProductWidth();
			shift = (z - x)*getProductWidth();
			elem.style.transform = 'translateX(-' + +shift + 'px)';
		} else {
		
			shift = +shift - +getProductWidth();
			elem.style.transform = 'translateX(-' + +shift + 'px)';
			console.log(shift);
		}
	}
};
moveCarouselLeft();

//анимация main-nav
function setClasses() {
	var itemsNav = document.getElementsByClassName('main-nav__item');
	for (var i = 0; i < itemsNav.length; i++) {
		itemsNav[i].addEventListener('click', function(event) {
			for (var j = 0; j < itemsNav.length; j++) {
				itemsNav[j].classList.remove('main-nav__item_active');
			}
			event.target.classList.add('main-nav__item_active');
		})
	}
}
setClasses();

//слайдер баннера
var getBannerWidth = function() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	return elem.offsetWidth;
};
var getBannersLengthWrapper = function () {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	return elem.children.length
}
var numBanners = getBannersLengthWrapper();
var shiftBanners = 0;

function moveBannerRight() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
	// if (shift == (z - x * (z / x - z % x / x))*getProductWidth()) {
	if (shiftBanners == (numBanners - 1)*getBannerWidth() || shiftBanners > (numBanners - 1)*getBannerWidth()) {
		shiftBanners = 0;
		elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
	} else {
		shiftBanners = +shiftBanners + +getBannerWidth();
		elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
		console.log(shiftBanners);
	}
}

var moveBannerRightEvent = function() {
	var elem = document.getElementsByClassName('banners-button-right')[0];
	elem.onclick = function() {
		moveBannerRight();
	}
};
moveBannerRightEvent();

function moveBannerLeft() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
	if (shiftBanners == 0 || shiftBanners < 0) {
		// shift = (z - x * (z / x - z % x / x))*getProductWidth();
		shiftBanners = (numBanners - 1)*getBannerWidth();
		elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
	} else {
	
		shiftBanners = +shiftBanners - +getBannerWidth();
		elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
		console.log(shiftBanners);
	}
}

var moveBannerLeftEvent = function() {
	var elem = document.getElementsByClassName('banners-button-left')[0];
	elem.onclick = function() {
		moveBannerLeft();
	}
};
moveBannerLeftEvent();

//таймер слайда баннеров
var slideBannerTimer = function() {
	var slideBanner = setInterval(function() {moveBannerRight();}, 4000);
	var stopMoveBanner = function() {
		var elem = document.getElementsByClassName('banners')[0];
		elem.addEventListener('mouseover', function(){
			clearInterval(slideBanner);
		});
	}
	stopMoveBanner();
}
slideBannerTimer();

var moveBannerMouseOut = function() {
	var elem = document.getElementsByClassName('banners')[0];
	elem.addEventListener('mouseout', function() {
	slideBannerTimer();
	})
}
moveBannerMouseOut();