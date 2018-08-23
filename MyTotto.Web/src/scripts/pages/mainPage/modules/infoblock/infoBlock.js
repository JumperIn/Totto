function dropDownInfoItems() {
	var elems = document.getElementsByClassName('faq-accordion');
	for (var i = 0; i < elems.length; i++) {
		elems[i].addEventListener('click', function() {
			this.classList.toggle('faq-accordion-active');
			this.nextElementSibling.classList.toggle('hidden');
			this.lastElementChild.classList.toggle('fa-angle-down');
			this.lastElementChild.classList.toggle('fa-angle-up');
		})
	}
}

export { dropDownInfoItems };