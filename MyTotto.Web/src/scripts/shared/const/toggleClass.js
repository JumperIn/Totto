function toggleClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	elem.classList.toggle(class2);
}

function toggleNotExistClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	if (!elem.classList.contains(class2)) {
		elem.classList.toggle(class2);
	}
}

function toggleExistClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	if (elem.classList.contains(class2)) {
		elem.classList.toggle(class2);
	}
}

//	Переключение иконки при нажатии блок

function toggleIcon(elem, icon1, icon2) {
	if (elem.getAttribute('xlink:href') === icon1) {
		elem.setAttribute('xlink:href', icon2);
	} else if (elem.getAttribute('xlink:href') === icon2) {
		elem.setAttribute('xlink:href', icon1);
	}
}

function toggleExistIcon(classToggle, icon1, icon2, j = 0) {
	var elems = document.getElementsByClassName(classToggle);
	if (elems[j].getAttribute('xlink:href') === icon2) {
		elems[j].setAttribute('xlink:href', icon1);
	}
}

export { toggleClass, toggleExistClass, toggleNotExistClass, toggleIcon, toggleExistIcon };