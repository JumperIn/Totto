import { variables } from "../const/const";
import { getNumNewProductDisp, getNumPromoProductDisp, returnCarouselBack } from "../../pages/mainPage/modules/products/carousel";
import { returnBannerBack } from "../../pages/mainPage/modules/banner/banner";

function resizeMain() {
	var timeOut;
	window.addEventListener('resize', function() {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			//для нормального отображения банеров и карусели, при изменении ширины экрана они плавно возвращаются в начальное положение
			variables.shift[0] = 0;
			variables.shift[1] = 0;
			variables.shiftBanners = 0;
			//данные функции выполняются при каждом событии изменения экрана, для адаптивной работы баннеров и карусели
			getNumPromoProductDisp(0);
			getNumNewProductDisp(1);
			returnBannerBack();
			returnCarouselBack('discounts__wrapper');
			returnCarouselBack('new-products__wrapper');
		}, 200)
	})
}

export { resizeMain };