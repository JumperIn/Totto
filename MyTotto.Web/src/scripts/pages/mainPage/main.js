'use strict'

import { resizeMain } from "../../shared/resize/resizeMain";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/products/mainNavAnimation";
import { moveCarouselEvent, getNumNewProductDisp, getNumPromoProductDisp } from "./modules/products/carousel";
import { toggleProductsEventItems } from "./modules/products/productToggle";
import { hidePopupEvent, showPopupEvent, resetClick } from "../../shared/popup/popup";
import { swipeEvent } from "../../shared/swipe/swipe";

//Адаптивность сайта

resizeMain();

//слайдер баннера

moveBannerRightEvent();
moveBannerLeftEvent();
slideBannerTimer();
moveBannerMouseOut();

//переключатель продуктов

toggleProductsEventItems('js-main-nav__item-all', 'js-products_all', true);
toggleProductsEventItems('js-products__watch-all', 'js-products_all', true);
toggleProductsEventItems('js-main-nav__item-new', 'js-products_new');
toggleProductsEventItems('js-main-nav__item-hits', 'js-products_hit');
toggleProductsEventItems('js-main-nav__item-discount', 'js-products_discount');

//анимация main-nav

setClasses();

// получить числа отображаемых новых товаров и промо товаров

getNumPromoProductDisp(0);
getNumNewProductDisp(1);

//Карусель для Новых товаров и промо

moveCarouselEvent('js-move-discounts-right', 'js-move-discounts-left', 'discounts__wrapper', 0);
moveCarouselEvent('js-move-new-products-right', 'js-move-new-products-left', 'new-products__wrapper', 1);

// reset click

resetClick();

// popaps

hidePopupEvent('js-modal-basket-close', 'js-modal-basket');
showPopupEvent('js-product-basket-modal', 'js-modal-basket');

// Свайп

swipeEvent('discounts__wrapper', 0);
swipeEvent('new-products__wrapper', 1);
swipeEvent('banners-wrapper');