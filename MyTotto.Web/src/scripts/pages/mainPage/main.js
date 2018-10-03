'use strict'

import { resize } from "../../shared/resize/resize";
// import { scrollNavEvent, dropDownNav } from "../../shared/navigation/scrollNav";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/carousel/mainNavAnimation";
import { getNumProductDisp, moveCarouselLeftEvent, moveCarouselRightEvent, toggleProductsEvent } from "./modules/carousel/carousel";
import { adaptFooter, dropDownFooterItems } from "../../shared/footer/footer";

//Адаптивность сайта

resize();

//scroll-navigation

// scrollNavEvent();
// dropDownNav();

//Адаптивность навигации

dropDownMenu();
dropDownListEvent();
dropDownItemEvent();

toCenterDropMenu();

//слайдер баннера

moveBannerRightEvent();
moveBannerLeftEvent();
// slideBannerTimer();
// moveBannerMouseOut();

//анимация main-nav

setClasses();

//переключатель продуктов

toggleProductsEvent();

//Адаптация футера

adaptFooter();
dropDownFooterItems();

// export { moveCarouselLeftEvent };
// Таким образом можно выносить объекты в глобальную область видимости