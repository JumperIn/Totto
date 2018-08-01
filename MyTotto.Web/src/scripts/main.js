'use strict'

//Константы и переменные

var constants = {
	SCREEN_SMALL: 576,
	SCREEN_MEDIUM: 768,
	SCREEN_LARGE: 992,
	SCREEN_EXTRA_LARGE: 1200

}
var variables = {
	numProductsDisp: 1,
	shiftProducts: 0,
	shiftBanners: 0,
	numProducts: getLengthWrapper(),
	numBanners: getBannersLengthWrapper(),
}

//Адаптивность сайта

function resize() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function() {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			//условия нужны для отслеживания события, когда ширина экрана переходит
			//из области от (0 до 768) в область (>= 768) и обратно.
			if (window.innerWidth > 0 && window.innerWidth < constants.SCREEN_MEDIUM && windowWidth >= constants.SCREEN_MEDIUM) {
				hideMenu();
				windowWidth = window.innerWidth
			} else if (window.innerWidth >= constants.SCREEN_MEDIUM && window.innerWidth < 1920 && windowWidth < constants.SCREEN_MEDIUM) {
				showMenu();
				windowWidth = window.innerWidth;
			}
			//для нормального отображения банеров и карусели, при изменении ширины экрана они плавно возвращаются в начальное положение
			variables.shiftProducts = 0;
			variables.shiftBanners = 0;
			//данные функции выполняются при каждом событии изменения экрана, для адаптивной работы баннеров и карусели
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
function getNumProductDisp() {
	if (window.innerWidth > 0) { variables.numProductsDisp = 1; };
	if (window.innerWidth >= constants.SCREEN_SMALL) { variables.numProductsDisp = 2; };
	if (window.innerWidth >= constants.SCREEN_MEDIUM) { variables.numProductsDisp = 3; };
	if (window.innerWidth >= constants.SCREEN_LARGE) { variables.numProductsDisp = 4; };
	if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) { variables.numProductsDisp = 4; };
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

function moveCarouselRight() {
    var elem = document.getElementsByClassName('products-wrapper')[0];
    //граничное условие, при котором необходимо вернуть карусель в начальное состояние
    var distanceTolastProduct = (variables.numProducts - variables.numProductsDisp) * getProductWidth();
    var returnToStartCondition = variables.shiftProducts == distanceTolastProduct || variables.shiftProducts > distanceTolastProduct;
    if (returnToStartCondition) {
        variables.shiftProducts = 0;
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    } else {
        variables.shiftProducts = +variables.shiftProducts + +getProductWidth();
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    }
};
function moveCarouselRightEvent() {
    var elem = document.getElementById('moveCarouselRight');
    elem.addEventListener('click', moveCarouselRight);
};
moveCarouselRightEvent();

function moveCarouselLeft() {
    var elem = document.getElementsByClassName('products-wrapper')[0];
    var returnToEndCondition = variables.shiftProducts == 0 || variables.shiftProducts < 0;
    if (returnToEndCondition) {
        variables.shiftProducts = (variables.numProducts - variables.numProductsDisp) * getProductWidth();
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
    } else {
        variables.shiftProducts = +variables.shiftProducts - +getProductWidth();
        elem.style.transform = 'translateX(-' + +variables.shiftProducts + 'px)';
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
	var elem = document.getElementsByClassName('menu-link')[0];
    if (window.innerWidth < constants.SCREEN_MEDIUM) {
        elem.nextElementSibling.classList.toggle('hidden');
        elem.parentElement.parentElement.classList.remove('container_padding');
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

dropDownMenu();

function dropDownList() {
	adaptDropDownList();
	dropDownListEvent();
}

function adaptDropDownList() {
	var elems = document.getElementsByClassName('accordion');
    for (var i = 0; i < elems.length; i++) {
        if (window.innerWidth < constants.SCREEN_MEDIUM) {
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

dropDownList();

function dropDownItem() {
	adaptDropDownItem();
	dropDownItemEvent();
}

function adaptDropDownItem() {
	var elems = document.getElementsByClassName('accordion-list');
    for (var i = 0; i < elems.length; i++) {
        if (window.innerWidth < constants.SCREEN_MEDIUM) {
            elems[i].parentElement.nextElementSibling.classList.toggle('hidden');
            elems[i].parentElement.parentElement.parentElement.parentElement.classList.remove('container_padding');
        };
        if (window.innerWidth >= constants.SCREEN_MEDIUM) {
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
	var elem = document.getElementsByClassName('menu-link')[0];
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