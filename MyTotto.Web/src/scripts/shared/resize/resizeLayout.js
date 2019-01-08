import { constants } from "../const/const";
import { hideMenu, showMenu, toCenterDropMenu } from "../navigation/navAdaptive";
import { adaptFooter } from "../footer/footer";

function resizeLayout() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function () {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			//условия нужны для отслеживания события, когда ширина экрана переходит
			//из области от (0 до 1200) в область (>= 1200) и обратно.
			if (window.innerWidth > 0 && window.innerWidth < constants.SCREEN_EXTRA_LARGE && windowWidth >= constants.SCREEN_EXTRA_LARGE) {
				hideMenu();
				adaptFooter();
				windowWidth = window.innerWidth;
			} else if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE && windowWidth < constants.SCREEN_EXTRA_LARGE) {
				showMenu();
				adaptFooter();
				windowWidth = window.innerWidth;
			}
			toCenterDropMenu();
		}, 200)
	})
}

export { resizeLayout };