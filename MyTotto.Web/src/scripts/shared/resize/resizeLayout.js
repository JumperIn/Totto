import { constants } from "../const/const";
import { hideMenu, showMenu, toCenterDropMenu } from "../navigation/navAdaptive";
import { adaptFooter } from "../footer/footer";

function resizeLayout() {
	var timeOut;
	var windowWidth = window.innerWidth;
	window.addEventListener('resize', function() {
		clearTimeout(timeOut);
		timeOut = setTimeout(() => {
			//условия нужны для отслеживания события, когда ширина экрана переходит
			//из области от (0 до 768) в область (>= 768) и обратно.
			if (window.innerWidth > 0 && window.innerWidth < constants.SCREEN_EXTRA_LARGE && windowWidth >= constants.SCREEN_EXTRA_LARGE) {
				hideMenu();	
				adaptFooter();
				windowWidth = window.innerWidth;
			} else if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE && window.innerWidth < 1920 && windowWidth < constants.SCREEN_EXTRA_LARGE) {
				showMenu();
				adaptFooter();
				windowWidth = window.innerWidth;
			}
			toCenterDropMenu();
		}, 200)
	})
}

export { resizeLayout };