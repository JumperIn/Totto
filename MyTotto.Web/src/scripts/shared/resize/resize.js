import { constants, variables } from "../const/const";
import { hideMenu, showMenu, toCenterDropMenu } from "../navigation/navAdaptive";
// import { hideDropNavAdaptive, scrollNavEvent } from "../navigation/scrollNav";
import { adaptFooter } from "../footer/footer";
// import { getNumProductDisp, returnCarouselBack } from "../../pages/mainPage/modules/carousel/carousel";
import { returnBannerBack } from "../../pages/mainPage/modules/banner/banner";


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
				// hideDropNavAdaptive();
				adaptFooter();
				windowWidth = window.innerWidth;
			} else if (window.innerWidth >= constants.SCREEN_MEDIUM && window.innerWidth < 1920 && windowWidth < constants.SCREEN_MEDIUM) {
				showMenu();
				// scrollNavEvent();
				adaptFooter();
				windowWidth = window.innerWidth;
			}
			//для нормального отображения банеров и карусели, при изменении ширины экрана они плавно возвращаются в начальное положение
			variables.shiftProducts = 0;
			variables.shiftBanners = 0;
			//данные функции выполняются при каждом событии изменения экрана, для адаптивной работы баннеров и карусели
			// getNumProductDisp();
			returnBannerBack();
			toCenterDropMenu();
			// returnCarouselBack(0);
			// returnCarouselBack(1);
			// returnCarouselBack(2);
		}, 200)
	})
}

export { resize };