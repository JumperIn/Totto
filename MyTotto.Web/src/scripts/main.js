'use strict'

//карусель
var numProductsDisp;
if (window.matchMedia('(min-width: 0px)').matches) { numProductsDisp = 1; };
if (window.matchMedia('(min-width: 576px)').matches) { numProductsDisp = 2; };
if (window.matchMedia('(min-width: 768px)').matches) { numProductsDisp = 3; };
if (window.matchMedia('(min-width: 992px)').matches) { numProductsDisp = 4; };
if (window.matchMedia('(min-width: 1200px)').matches) { numProductsDisp = 4; };

function getProductWidth() {
    var elem = document.getElementsByClassName('products__item')[0];
    return elem.offsetWidth;
};

function getLengthWrapper() {
    var elem = document.getElementsByClassName('products-wrapper')[0];
    return elem.children.length
}
var numProducts = getLengthWrapper();
var shiftProducts = 0;

function moveCarouselRight() {
    var elem = document.getElementsByClassName('products-wrapper')[0];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var lastProduct = (numProducts - numProductsDisp) * getProductWidth();
    if (shiftProducts == lastProduct || shiftProducts > lastProduct) {
        shiftProducts = 0;
        elem.style.transform = 'translateX(-' + +shiftProducts + 'px)';
    } else {
        shiftProducts = +shiftProducts + +getProductWidth();
        elem.style.transform = 'translateX(-' + +shiftProducts + 'px)';
    }
};
function moveCarouselRightEvent() {
    var elem = document.getElementById('moveCarouselRight');
    elem.addEventListener('click', moveCarouselRight);
};
moveCarouselRightEvent();

function moveCarouselLeft() {
    var elem = document.getElementsByClassName('products-wrapper')[0];
    if (shiftProducts == 0 || shiftProducts < 0) {
        shiftProducts = (numProducts - numProductsDisp) * getProductWidth();
        elem.style.transform = 'translateX(-' + +shiftProducts + 'px)';
    } else {
        shiftProducts = +shiftProducts - +getProductWidth();
        elem.style.transform = 'translateX(-' + +shiftProducts + 'px)';
    }
};
function moveCarouselLeftEvent() {
    var elem = document.getElementById('moveCarouselLeft');
    elem.addEventListener('click', moveCarouselLeft);
};
moveCarouselLeftEvent();

//анимация main-nav
function setClasses() {
    var itemsNav = document.getElementsByClassName('main-nav__item');
    for (var i = 0; i < itemsNav.length; i++) {
        itemsNav[i].addEventListener('click', function (event) {
            for (var j = 0; j < itemsNav.length; j++) {
                itemsNav[j].classList.remove('main-nav__item_active');
            }
            event.target.classList.add('main-nav__item_active');
        })
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
    return elem.children.length
}
var numBanners = getBannersLengthWrapper();
var shiftBanners = 0;

function moveBannerRight() {
    var elem = document.getElementsByClassName('banners-wrapper')[0];
    if (shiftBanners == (numBanners - 1) * getBannerWidth() || shiftBanners > (numBanners - 1) * getBannerWidth()) {
        shiftBanners = 0;
        elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
    } else {
        shiftBanners = +shiftBanners + +getBannerWidth();
        elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
    }
}

function moveBannerRightEvent() {
    var elem = document.getElementById('moveBannerRight');
    elem.addEventListener('click', moveBannerRight);
};
moveBannerRightEvent();

function moveBannerLeft() {
    var elem = document.getElementsByClassName('banners-wrapper')[0];
    if (shiftBanners == 0 || shiftBanners < 0) {
        shiftBanners = (numBanners - 1) * getBannerWidth();
        elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
    } else {

        shiftBanners = +shiftBanners - +getBannerWidth();
        elem.style.transform = 'translateX(-' + +shiftBanners + 'px)';
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
    var stopMoveBanner = function () {
        var elem = document.getElementsByClassName('banners')[0];
        elem.addEventListener('mouseover', function () {
            clearInterval(slideBanner);
        });
    }
    stopMoveBanner();
}
slideBannerTimer();

function moveBannerMouseOut() {
    var elem = document.getElementsByClassName('banners')[0];
    elem.addEventListener('mouseout', slideBannerTimer);
}
moveBannerMouseOut();