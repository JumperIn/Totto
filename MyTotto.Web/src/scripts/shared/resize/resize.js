import { constants, variables } from "../const/const";
import { hideMenu, showMenu, toCenterDropMenu } from "../navigation/navAdaptive";
// import { hideDropNavAdaptive, scrollNavEvent } from "../navigation/scrollNav";
import { adaptFooter } from "../footer/footer";
import { getNumNewProductDisp, getNumPromoProductDisp, returnCarouselBack } from "../../pages/mainPage/modules/products/carousel";
import { returnBannerBack } from "../../pages/mainPage/modules/banner/banner";


function resize() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function() {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			//условия нужны для отслеживания события, когда ширина экрана переходит
			//из области от (0 до 768) в область (>= 768) и обратно.
			if (window.innerWidth > 0 && window.innerWidth < constants.SCREEN_EXTRA_LARGE && windowWidth >= constants.SCREEN_EXTRA_LARGE) {
				hideMenu();	
				// hideDropNavAdaptive();
				adaptFooter();
				windowWidth = window.innerWidth;
			} else if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE && window.innerWidth < 1920 && windowWidth < constants.SCREEN_EXTRA_LARGE) {
				showMenu();
				// scrollNavEvent();
				adaptFooter();
				windowWidth = window.innerWidth;
			}
			//для нормального отображения банеров и карусели, при изменении ширины экрана они плавно возвращаются в начальное положение
			variables.shift[0] = 0;
			variables.shift[1] = 0;
			variables.shiftBanners = 0;
			//данные функции выполняются при каждом событии изменения экрана, для адаптивной работы баннеров и карусели
			getNumPromoProductDisp(0);
			getNumNewProductDisp(1);
			returnBannerBack();
			toCenterDropMenu();
			returnCarouselBack('discounts__wrapper');
			returnCarouselBack('new-products__wrapper');
		}, 200)
	})
}

export { resize };