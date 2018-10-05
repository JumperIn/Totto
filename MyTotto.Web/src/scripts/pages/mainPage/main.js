'use strict'

import { resize } from "../../shared/resize/resize";
// import { scrollNavEvent, dropDownNav } from "../../shared/navigation/scrollNav";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/products/mainNavAnimation";
import { toggleProductsEventAll, toggleProductsEventItems } from "./modules/products/productToggle";
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

toggleProductsEventAll();
toggleProductsEventItems('js-main-nav__item-new', 'js-products__item-new');
toggleProductsEventItems('js-main-nav__item-hits', 'js-products__item-hit');
toggleProductsEventItems('js-main-nav__item-stocks', 'js-products__item-stock');

//Адаптация футера

adaptFooter();
dropDownFooterItems();

// export { moveCarouselLeftEvent };
// Таким образом можно выносить объекты в глобальную область видимости