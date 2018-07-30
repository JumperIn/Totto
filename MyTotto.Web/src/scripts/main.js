'use strict'

//Константы



//Адаптивность сайта

function resize() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function() {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			if (window.innerWidth > 0 && window.innerWidth < 768 && windowWidth > 767) {
				console.log('от 0 до 767');
				windowWidth = window.innerWidth
			} else if (window.innerWidth > 767 && window.innerWidth < 1366 && windowWidth < 768) {
				console.log('от 767 до 1366');
				windowWidth = window.innerWidth;
			}
			shiftProducts = 0;
			shiftBanners = 0;
			getNumProductDisp();
			returnBannerBack();
			returnCarouselBack();

			//внутри можно вызывать функции, которые определяют адаптивность сайта
			//Можно так же вызывать функции, которые скажут, чтоб банеры и карусель прокрутились в начальное положение
		}, 200)
	})
}
resize();

function returnCarouselBack() {
	var elem = document.getElementsByClassName('products-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
}

function returnBannerBack() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
}

//карусель
var numProductsDisp;
function getNumProductDisp() {
	if (window.innerWidth > 0) { numProductsDisp = 1; };
	if (window.innerWidth > 575) { numProductsDisp = 2; };
	if (window.innerWidth > 767) { numProductsDisp = 3; };
	if (window.innerWidth > 991) { numProductsDisp = 4; };
	if (window.innerWidth > 1999) { numProductsDisp = 4; };
}
getNumProductDisp();

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

//Адаптивность навигации

function dropDownMenu() {
	adaptDropDownMenu();
	dropDownMenuEvent();
}

function adaptDropDownMenu() {
	var elem = document.getElementsByClassName('header-nav-menu__link')[0];
    if (window.innerWidth < 768) {
        elem.nextElementSibling.style.display = 'none'
        elem.parentElement.parentElement.classList.remove('container_padding');
    }
}
function dropDownMenuEvent() {
	var elem = document.getElementsByClassName('header-nav-menu__link')[0];
	elem.addEventListener('click', function () {
		var panel = this.nextElementSibling;
		if (panel.style.display === 'none') {
			panel.style.display = 'flex';
		} else {
			panel.style.display = 'none';
		}
	})

}

dropDownMenu();

function dropDownList() {
	adaptDropDownList();
	dropDownListEvent();
}

function adaptDropDownList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
        if (window.innerWidth < 768) {
            elems[i].parentElement.nextElementSibling.classList.toggle('hiden');
            elems[i].classList.remove('fa-angle-down');
            elems[i].classList.add('fa-plus');
		};
	}
}

function dropDownListEvent() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function () {
            var panel = this.parentElement.nextElementSibling;
            this.classList.toggle('icon-accordion-active');
            this.parentElement.classList.toggle('accordion-active');
            if (window.innerWidth < 768) {
                this.classList.toggle('fa-plus');
                this.classList.toggle('fa-minus');
				panel.classList.toggle('hiden');
            }
        })
	}
}

dropDownList();

function dropDownItem() {
	adaptDropDownItem();
	dropDownItemEvent();
}

function adaptDropDownItem() {
	var elems = document.getElementsByClassName('accordion-list');
    for (var i = 0; i < elems.length; i++) {
        if (window.innerWidth < 768) {
            elems[i].parentElement.nextElementSibling.classList.toggle('hiden');
            elems[i].parentElement.parentElement.parentElement.parentElement.classList.remove('container_padding');
        };
        if (window.innerWidth > 767) {
            elems[i].style.display = 'none';
		};
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
			panel.classList.toggle('hiden');
		})
	}
}
dropDownItem();