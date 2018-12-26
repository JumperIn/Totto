
function addErrorMessage(classWrapper, errorMessage) {
	const wrapper = document.querySelector(classWrapper);
	const elem = document.createElement('p');

	// проверка на существующую ошибку
	for (let i = 0; i < wrapper.children.length; i++) {
		if (wrapper.children[i].dataset.errorname === errorMessage) {
			return;
		}
	}

	elem.classList.add('error-message');
	elem.innerHTML = errorMessage;
	elem.dataset.errorname = errorMessage;

	wrapper.appendChild(elem);
}

function removeErrorMessages(classWrapper) {
	const wrapper = document.querySelector(classWrapper);
	const elems = wrapper.querySelectorAll('p.error-message');
	for (let i = 0; i < elems.length; i++) {
		elems[i].remove();
	}
}

function requestCallValidation() {
	const form = document.querySelector('form.modal-callback__form');
	const pristine = new Pristine(form);
	const nameInput = document.querySelector('input.modal-callback__input-name');
	const phoneInput = document.querySelector('input.modal-callback__input-phone');

	const errorsConditions = {}

	form.addEventListener('submit', function (e) {
		e.preventDefault();
		const valid = pristine.validate();

		if (valid) {
			removeErrorMessages('div.modal-callback__inputs-wrapper');
			// TODO: добавить отправление XMLHttpRequest
			console.log('отправление формы на сервер и закрытие формы')
			// TODO: добавить закрытие попапа
		} else {
			removeErrorMessages('div.modal-callback__inputs-wrapper');
			const nameErrorMessages = pristine.getErrors(nameInput);
			const phoneErrorMessages = pristine.getErrors(phoneInput);
			for (let i = 0; i < nameErrorMessages.length; i++) {
				if (!errorsConditions.nameInput) addErrorMessage('div.modal-callback__inputs-wrapper', nameErrorMessages[i]);
			}
			for (let i = 0; i < phoneErrorMessages.length; i++) {
				if (!errorsConditions.phoneInput) addErrorMessage('div.modal-callback__inputs-wrapper', phoneErrorMessages[i]);
			}
		}
	})

	// TODO: добавить нормальную валидацию для этих полей
	pristine.addValidator(nameInput, function (value, nameInput) {
		// пример
		if (value.length && value[0] === value[0].toUpperCase()) {
			errorsConditions.nameInput = true;
			return true;
		}
		errorsConditions.nameInput = false;
		return false;
	}, "The first character must be capitalized", 1, false);

	pristine.addValidator(phoneInput, function (value, phoneInput) {
		if (value.length <= 20) {
			errorsConditions.phoneInput = true;
			return true;
		}
		errorsConditions.phoneInput = false;
		return false;
	}, "Введите номер телефона, не больше 20 символов", 2, false);
}

export { requestCallValidation };