'use strict'

import { resize } from "./js-modules/resizeModule";
import { scrollNavEvent, dropDownNav } from "./js-modules/scrollNavModule";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent } from "./js-modules/navAdaptiveModule";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./js-modules/bannerModule";
import { setClasses } from "./js-modules/mainNavAnimationModule";
import { getNumProductDisp, moveCarouselLeftEvent, moveCarouselRightEvent, toggleProductsEvent } from "./js-modules/carouselModule";
import { dropDownInfoItems } from "./js-modules/infoBlockModule";
import { adaptFooter, dropDownFooterItems } from "./js-modules/footerModule";

//Адаптивность сайта

resize();

//scroll-navigation

scrollNavEvent();
dropDownNav();

//Адаптивность навигации

dropDownMenu();
dropDownListEvent();
dropDownItemEvent();

//слайдер баннера

moveBannerRightEvent();
moveBannerLeftEvent();
slideBannerTimer();
moveBannerMouseOut();

//анимация main-nav

setClasses();

//карусель

getNumProductDisp();

moveCarouselRightEvent(0);
moveCarouselRightEvent(1);
moveCarouselRightEvent(2);

moveCarouselLeftEvent(0);
moveCarouselLeftEvent(1);
moveCarouselLeftEvent(2);

toggleProductsEvent();

//инфо-блок

dropDownInfoItems();

//Адаптация футера

adaptFooter();
dropDownFooterItems();