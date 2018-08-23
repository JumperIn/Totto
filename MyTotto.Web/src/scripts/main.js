'use strict'

import { resize } from "./resizeModule";
import { scrollNavEvent, dropDownNav } from "./scrollNavModule";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent } from "./navAdaptiveModule";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./bannerModule";
import { setClasses } from "./mainNavAnimationModule";
import { getNumProductDisp, moveCarouselLeftEvent, moveCarouselRightEvent, toggleProductsEvent } from "./carouselModule";
import { dropDownInfoItems } from "./infoBlockModule";
import { adaptFooter, dropDownFooterItems } from "./footerModule";

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