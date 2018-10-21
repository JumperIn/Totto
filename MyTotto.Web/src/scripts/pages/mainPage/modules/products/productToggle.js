import { toggleExistClass, toggleNotExistClass } from "../../../../shared/const/toggleClass";

function toggleProductsEventItems(classButton, classProduct) {
	var elem = document.getElementsByClassName(classButton)[0];
	var elems1 = document.getElementsByClassName('products');
	elem.addEventListener('click', function() {
		if (!elem.classList.contains('main-nav__item_active')) {
			for ( var i = 0; i < elems1.length; i++) {
				toggleNotExistClass('products', 'hidden', i);
			}
			// для ограничения, можно добавить в условие для && i < 8 чтоб, не выводить слишком много товаров
			toggleExistClass(classProduct, 'hidden', 0);
		}
	})
}

export { toggleProductsEventItems };