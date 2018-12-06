'use strict'

import { resizeMain } from "../../shared/resize/resizeMain";
import { setClasses } from "./modules/products/mainNavAnimation";
import { Carousel } from "./modules/products/carousel";
import { toggleProductsEventItems } from "./modules/products/productToggle";
import { hidePopupEvent, showPopupEvent, resetClick } from "../../shared/popup/popup";

//Адаптивность сайта

resizeMain();

//слайдер баннера

let bannersCarousel = new Carousel('div.banners-wrapper', '#moveBannerLeft', '#moveBannerRight');
bannersCarousel.moveCarouselEvents();
bannersCarousel.moveCarouselIntervalEvent(4000);
bannersCarousel.swipeEvents();

//переключатель продуктов

toggleProductsEventItems('js-main-nav__item-all', 'js-products_all', true);
toggleProductsEventItems('js-products__watch-all', 'js-products_all', true);
toggleProductsEventItems('js-main-nav__item-new', 'js-products_new');
toggleProductsEventItems('js-main-nav__item-hits', 'js-products_hit');
toggleProductsEventItems('js-main-nav__item-discount', 'js-products_discount');

//анимация main-nav

setClasses();

//Карусель для Новых товаров и промо

let newProductCarousel = new Carousel('div.new-products__wrapper', 'div.js-move-new-products-left', 'div.js-move-new-products-right');
newProductCarousel.moveCarouselEvents();
newProductCarousel.swipeEvents();

let promoCarousel = new Carousel('div.discounts__wrapper', 'div.js-move-discounts-left', 'div.js-move-discounts-right');
promoCarousel.moveCarouselEvents();
promoCarousel.swipeEvents();

// reset click

resetClick();

// popaps

hidePopupEvent('js-modal-basket-close', 'js-modal-basket');
showPopupEvent('js-product-basket-modal', 'js-modal-basket');

export { bannersCarousel, newProductCarousel, promoCarousel };