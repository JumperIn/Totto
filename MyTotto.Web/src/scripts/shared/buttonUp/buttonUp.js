function showButtonUp() {
	const anchor = document.querySelector('a.footer-anchor__wrapper');
	anchor.classList.remove('hidden');
}

function hideButtonUp() {
	const anchor = document.querySelector('a.footer-anchor__wrapper');
	anchor.classList.add('hidden');
}

function buttonUpEvent() {
	window.addEventListener('scroll', function () {
		if (window.innerHeight < window.pageYOffset) {
			showButtonUp();
		} else {
			hideButtonUp();
		}
	})
}

export { buttonUpEvent };