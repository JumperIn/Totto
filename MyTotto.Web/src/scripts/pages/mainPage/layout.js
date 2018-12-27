'use strict'

import { resizeLayout } from "../../shared/resize/resizeLayout";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { adaptFooter, dropDownFooterItems } from "../../shared/footer/footer";
import { PopupEvents } from "../../shared/popup/popup";
import { requestCall } from "../../shared/requestCall/requestCall";
import { subscribeNews } from "../../shared/subscribeNews/subscribeNews";

//Адаптивность сайта

resizeLayout();

//Адаптивность навигации

dropDownMenu();
dropDownListEvent();
dropDownItemEvent();

toCenterDropMenu();

// popaps

PopupEvents('modal-callback-wrapper', 'js-modal-phone', 'js-modal-callback-close');

//Адаптация футера

adaptFooter();
dropDownFooterItems();

// заказ звонка

requestCall();

// подписка на новости

subscribeNews();
