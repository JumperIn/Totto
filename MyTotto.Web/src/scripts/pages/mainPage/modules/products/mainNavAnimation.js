function setClasses() {
	var elem = document.getElementsByClassName('js-products__watch-all')[0];
	var itemsNav = document.getElementsByClassName('main-nav__item');
	for (var i = 0; i < itemsNav.length; i++) {
		itemsNav[i].addEventListener('click', function (event) {
			for (var j = 0; j < itemsNav.length; j++) {
				itemsNav[j].classList.remove('main-nav__item_active');
			}
			event.target.classList.add('main-nav__item_active');
		})
	}
	// при нажатии на кнопку "смотреть все" активной становится кнопка "все" из навигации 
	elem.addEventListener('click', function() {
		for (var i = 0; i < itemsNav.length; i++) {
			itemsNav[i].classList.remove('main-nav__item_active');
		}
		itemsNav[0].classList.add('main-nav__item_active');
	})
}

export { setClasses };