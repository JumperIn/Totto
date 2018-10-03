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

//	Переключение иконки при нажатии блок

function toggleIconClick(classClick, classToggle, icon1, icon2) {
	var elems1 = document.getElementsByClassName(classClick);
	var elems2 = document.getElementsByClassName(classToggle);
	for ( var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', () => {
			toggleIcon(elem, icon1, icon2, i)
		// 	if (elem.getAttribute('xlink:href') === icon1) {
		// 		elem.setAttribute('xlink:href', icon2);
		// 	} else if (elem.getAttribute('xlink:href') === icon2) {
		// 		elem.setAttribute('xlink:href', icon1);
		// 	}
		})
	}
}

function toggleIcon(elem, icon1, icon2) {
	if (elem.getAttribute('xlink:href') === icon1) {
		elem.setAttribute('xlink:href', icon2);
	} else if (elem.getAttribute('xlink:href') === icon2) {
		elem.setAttribute('xlink:href', icon1);
	}
}

export { toggleClass, toggleExistClass, toggleNotExistClass, toggleIconClick, toggleIcon };