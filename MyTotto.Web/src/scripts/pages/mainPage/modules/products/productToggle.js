import { toggleExistClass, toggleNotExistClass } from "../../../../shared/const/toggleClass";

function toggleProductsEventAll() {
	var elem = document.getElementsByClassName('js-main-nav__item-all')[0];
	var elems = document.getElementsByClassName('products__item');
	elem.addEventListener('click', function() {
		for ( var i = 0; i < elems.length; i++) {
			toggleExistClass('products__item', 'hidden', i);
		}
	})
}

function toggleProductsEventItems(classButton, classProduct) {
	var elem = document.getElementsByClassName(classButton)[0];
	var elems1 = document.getElementsByClassName('products__item');
	var elems2 = document.getElementsByClassName(classProduct);
	elem.addEventListener('click', function() {
		for ( var i = 0; i < elems1.length; i++) {
			toggleNotExistClass('products__item', 'hidden', i);
		}
		// для ограничения, можно добавить в условие для && i < 8 чтоб, не выводить слишком много товаров
		for ( var i = 0; i < elems2.length; i++) {
			toggleExistClass(classProduct, 'hidden', i);
		}
	})
}

export { toggleProductsEventAll, toggleProductsEventItems };