'use strict'

import { resizeLayout } from "../../shared/resize/resizeLayout";
import { dropDownMenu, dropDownListEvent, dropDownItemEvent, toCenterDropMenu } from "../../shared/navigation/navAdaptive";
import { adaptFooter, dropDownFooterItems } from "../../shared/footer/footer";
import { hidePopupEvent, showPopupEvent } from "../../shared/popup/popup";

//Адаптивность сайта

resizeLayout();

//Адаптивность навигации

dropDownMenu();
dropDownListEvent();
dropDownItemEvent();

toCenterDropMenu();

// popaps

hidePopupEvent('js-modal-callback-close', 'js-modal-callback');
showPopupEvent('js-modal-phone', 'js-modal-callback');

//Адаптация футера

adaptFooter();
dropDownFooterItems();
