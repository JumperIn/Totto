'use strict'

import { resize } from "../../shared/resize/resize";
// import { scrollNavEvent, dropDownNav } from "../../shared/navigation/scrollNav";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/products/mainNavAnimation";
import { toggleProductsEventItems } from "./modules/products/productToggle";
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

//переключатель продуктов

toggleProductsEventItems('js-main-nav__item-all', 'js-products_all', true);
toggleProductsEventItems('js-products__watch-all', 'js-products_all', true);
toggleProductsEventItems('js-main-nav__item-new', 'js-products_new');
toggleProductsEventItems('js-main-nav__item-hits', 'js-products_hit');
toggleProductsEventItems('js-main-nav__item-discount', 'js-products_discount');

//анимация main-nav

setClasses();

//Адаптация футера

adaptFooter();
dropDownFooterItems();

// export { moveCarouselLeftEvent };
// Таким образом можно выносить объекты в глобальную область видимости