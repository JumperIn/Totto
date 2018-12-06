import { bannersCarousel, newProductCarousel, promoCarousel } from "../../pages/mainPage/main";


function resizeMain() {
	var timeOut;
	window.addEventListener('resize', function () {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			bannersCarousel.refreshCarousel();
			newProductCarousel.refreshCarousel();
			promoCarousel.refreshCarousel();
		}, 200)
	})
}

export { resizeMain };