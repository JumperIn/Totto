function setClasses() {
	var itemsNav = document.getElementsByClassName('main-nav__item');
	for (var i = 0; i < itemsNav.length; i++) {
		itemsNav[i].addEventListener('click', function (event) {
			for (var j = 0; j < itemsNav.length; j++) {
				itemsNav[j].classList.remove('main-nav__item_active');
			}
			event.target.classList.add('main-nav__item_active');
		})
	}
}

export { setClasses };