'use strict'

import { resizeMain } from "../../shared/resize/resizeMain";
import { setClasses } from "./modules/products/mainNavAnimation";
import { Carousel } from "./modules/products/carousel";
import { toggleProductsEventItems } from "./modules/products/productToggle";
import { PopupEvents } from "../../shared/popup/popup";

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


// popap

PopupEvents('modal-basket-wrapper', 'js-product-basket-modal', 'js-modal-basket-close')

export { bannersCarousel, newProductCarousel, promoCarousel };