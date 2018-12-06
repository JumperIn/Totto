import { PopupEvents } from "../../shared/popup/popup";
import { CarouselWithButtons } from "./modules/products/carousel";

// popap

PopupEvents('modal-product-carousel-wrapper', 'product-info__main-img', 'js-modal-product-carousel-close');

// Carousel

let modalProductCarousel = new CarouselWithButtons('div.js-product-carousel', 'div.js-product-carousel-button_left', 'div.js-product-carousel-button_right', 'div.product-info__sub-img');
modalProductCarousel.moveCarouselEvents();
modalProductCarousel.moveCarouselClickButtonEvent();
modalProductCarousel.swipeEvents();
