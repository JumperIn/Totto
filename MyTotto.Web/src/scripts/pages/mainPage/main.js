'use strict'

import { resizeMain } from "../../shared/resize/resizeMain";
import { moveBannerRightEvent, moveBannerLeftEvent, slideBannerTimer, moveBannerMouseOut } from "./modules/banner/banner";
import { setClasses } from "./modules/products/mainNavAnimation";
import { moveCarouselEvent, getNumNewProductDisp, getNumPromoProductDisp, Carousel } from "./modules/products/carousel";
import { toggleProductsEventItems } from "./modules/products/productToggle";
import { hidePopupEvent, showPopupEvent, resetClick } from "../../shared/popup/popup";
import { swipeEvent } from "../../shared/swipe/swipe";

//Адаптивность сайта

resizeMain();

//слайдер баннера

let bannersCarousel = new Carousel('div.banners-wrapper', '#moveBannerLeft', '#moveBannerRight');
bannersCarousel.moveCarouselEvents();

// moveBannerRightEvent();
// moveBannerLeftEvent();
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

let newProductCarousel = new Carousel('div.new-products__wrapper', 'div.js-move-new-products-left', 'div.js-move-new-products-right');
newProductCarousel.moveCarouselEvents();

let promoCarousel = new Carousel('div.discounts__wrapper', 'div.js-move-discounts-left', 'div.js-move-discounts-right');
promoCarousel.moveCarouselEvents();

// moveCarouselEvent('js-move-discounts-right', 'js-move-discounts-left', 'discounts__wrapper', 0);
// moveCarouselEvent('js-move-new-products-right', 'js-move-new-products-left', 'new-products__wrapper', 1);

// reset click

resetClick();

// popaps

hidePopupEvent('js-modal-basket-close', 'js-modal-basket');
showPopupEvent('js-product-basket-modal', 'js-modal-basket');

// Свайп

swipeEvent('discounts__wrapper', 0);
swipeEvent('new-products__wrapper', 1);
swipeEvent('banners-wrapper');

export { bannersCarousel, newProductCarousel, promoCarousel };