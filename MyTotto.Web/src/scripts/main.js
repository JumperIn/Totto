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
				hideMenu();
				windowWidth = window.innerWidth
			} else if (window.innerWidth > 767 && window.innerWidth < 1920 && windowWidth < 768) {
				console.log('от 767 до 1920');
				showMenu();
				windowWidth = window.innerWidth;
			}
			shiftProducts = 0;
			shiftBanners = 0;
			getNumProductDisp();
			returnBannerBack();
			returnCarouselBack();
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
        elem.nextElementSibling.classList.toggle('hidden');
        elem.parentElement.parentElement.classList.remove('container_padding');
    }
}
function dropDownMenuEvent() {
	var elem = document.getElementsByClassName('header-nav-menu__link')[0];
	elem.addEventListener('click', function () {
		var panel = this.nextElementSibling;
		if (!panel.classList.contains('hidden')) {
			hideMenu();
		} else {
			panel.classList.toggle('hidden');
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
            elems[i].parentElement.nextElementSibling.classList.toggle('hidden');
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
            if (window.innerWidth < 768) {
				this.classList.toggle('icon-accordion-active');
				this.parentElement.classList.toggle('accordion-active');
                this.classList.toggle('fa-plus');
                this.classList.toggle('fa-minus');
				panel.classList.toggle('hidden');
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
            elems[i].parentElement.nextElementSibling.classList.toggle('hidden');
            elems[i].parentElement.parentElement.parentElement.parentElement.classList.remove('container_padding');
        };
        if (window.innerWidth > 767) {
            elems[i].classList.toggle('hidden');
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
			panel.classList.toggle('hidden');
		})
	}
}
dropDownItem();

function hideMenu() {
	//menu
	var elem = document.getElementsByClassName('header-nav-menu__link')[0];
	if (!elem.nextElementSibling.classList.contains('hidden')) {
		elem.nextElementSibling.classList.toggle('hidden');
        elem.parentElement.parentElement.classList.remove('container_padding');
	}
	//list
	hideList();
	//item
	hideItem();
}

function hideList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
		if (!elems[i].classList.contains('fa-plus')) {
            elems[i].parentElement.classList.remove('accordion-active');
            elems[i].parentElement.classList.add('accordion-active');
            elems[i].classList.remove('icon-accordion-active');
            elems[i].classList.add('icon-accordion-active');
			elems[i].classList.remove('fa-minus');
			elems[i].classList.add('fa-minus');
			elems[i].classList.remove('fa-angle-down');
		}
		if (!elems[i].parentElement.nextElementSibling.classList.contains('hidden')) {
			elems[i].parentElement.nextElementSibling.classList.toggle('hidden');
            elems[i].parentElement.classList.toggle('accordion-active');
            elems[i].classList.toggle('icon-accordion-active');
			elems[i].classList.toggle('fa-plus');
			elems[i].classList.toggle('fa-minus');
			elems[i].classList.remove('fa-angle-down');
		}
	}
}

function hideItem() {
	var elems = document.getElementsByClassName('accordion-list');
    for (var i = 0; i < elems.length; i++) {
		if (elems[i].classList.contains('hidden')) {
			elems[i].classList.toggle('sub-accordion-active');
			elems[i].classList.toggle('fa-minus');
			elems[i].classList.toggle('fa-plus');
			elems[i].classList.toggle('hidden');
		}
		if (!elems[i].parentElement.nextElementSibling.classList.contains('hidden')) {
			elems[i].parentElement.nextElementSibling.classList.toggle('hidden');
			elems[i].parentElement.parentElement.parentElement.parentElement.classList.remove('container_padding');
			elems[i].classList.toggle('sub-accordion-active');
			elems[i].classList.toggle('fa-plus');
			elems[i].classList.toggle('fa-minus');
		}
	}
}

function showMenu() {
	//menu
	var elem = document.getElementsByClassName('header-nav-menu__link')[0];
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
    for (var i = 0; i < elems.length; i++) {
		elems[i].parentElement.nextElementSibling.classList.remove('hidden');
		elems[i].parentElement.parentElement.parentElement.parentElement.classList.add('container_padding');
		elems[i].classList.remove('sub-accordion-active');
		elems[i].classList.remove('fa-plus');
		elems[i].classList.remove('fa-minus');
		elems[i].classList.add('fa-plus');
		elems[i].classList.toggle('hidden');
	}
}