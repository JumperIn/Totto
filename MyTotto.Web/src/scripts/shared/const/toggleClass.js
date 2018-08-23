function toggleClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	elem.classList.toggle(class2);
}

function toggleNotExistClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	if (!elem.classList.contains(class2)) {
		elem.classList.toggle(class2)
	}
}

function toggleExistClass(class1, class2, j = 0) {
	var elem = document.getElementsByClassName(class1)[j];
	if (elem.classList.contains(class2)) {
		elem.classList.toggle(class2)
	}
}

export { toggleClass, toggleExistClass, toggleNotExistClass };