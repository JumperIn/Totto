'use strict'

import { resize } from "../../shared/resize/resize";
// import { scrollNavEvent, dropDownNav } from "../../shared/navigation/scrollNav";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/carousel/mainNavAnimation";
import { getNumProductDisp, moveCarouselLeftEvent, moveCarouselRightEvent, toggleProductsEvent } from "./modules/carousel/carousel";
import { dropDownInfoItems } from "./modules/infoblock/infoBlock";
import { adaptFooter, dropDownFooterItems } from "../../shared/footer/footer";
import { toggleIcon } from "../../shared/const/toggleClass";

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

toggleIcon('accordion', 'menu-item__icon-drop-toggle', '#icon-plus', '#icon-minus');
toggleIcon('accordion-list', 'menu-drop__icon-toggle', '#icon-plus', '#icon-minus');

toggleIcon('menu-title', 'menu-title__icon-toggle', '#icon-angle-bottom', '#icon-angle-top');

//слайдер баннера

moveBannerRightEvent();
moveBannerLeftEvent();
// slideBannerTimer();
// moveBannerMouseOut();

//анимация main-nav

setClasses();

//карусель

// getNumProductDisp();

// moveCarouselRightEvent(0);
// moveCarouselRightEvent(1);
// moveCarouselRightEvent(2);

// moveCarouselLeftEvent(0);
// moveCarouselLeftEvent(1);
// moveCarouselLeftEvent(2);

toggleProductsEvent();

//инфо-блок

dropDownInfoItems();

//Адаптация футера

adaptFooter();
dropDownFooterItems();

toggleIcon('footer-accordion', 'footer-block__icon-toggle', '#icon-angle-bottom', '#icon-angle-top');

// export { moveCarouselLeftEvent };
// Таким образом можно выносить объекты в глобальную область видимости