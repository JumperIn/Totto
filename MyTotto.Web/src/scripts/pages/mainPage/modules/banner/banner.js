import { variables } from "../../../../shared/const/const";

function returnBannerBack() {
	var elem = document.getElementsByClassName('banners-wrapper')[0];
	elem.style.transform = 'translateX(0px)';
}

function getBannerWidth() {
    var elem = document.getElementsByClassName('banners-wrapper')[0];
    return elem.offsetWidth;
};

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
};

function moveBannerMouseOut() {
    var elem = document.getElementsByClassName('banners')[0];
    elem.addEventListener('mouseout', slideBannerTimer);
};

export { returnBannerBack, moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut };
