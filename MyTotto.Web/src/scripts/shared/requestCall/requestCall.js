import createRequest from '../createRequest/createRequest';
import { requestCallBack } from '../createRequest/apiConfig';
import { hidePopup } from '../popup/popup';

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

	const errorsConditions = {};
	const formBody = {};

	form.addEventListener('submit', function (e) {
		e.preventDefault();
		const valid = pristine.validate();

		if (valid) {
			removeErrorMessages('div.modal-callback__inputs-wrapper');
			createRequest(requestCallBack, null, formBody)
				.then(({ statusText }) => {
					if (statusText === 'OK') {
						nameInput.value = null;
						phoneInput.value = null;
						setTimeout(function () {
							hidePopup('modal-callback-wrapper');
						}, 1000)
					}
				})
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
		if (value.length > 0) {
			errorsConditions.nameInput = true;
			formBody.name = value;
			return true;
		}
		errorsConditions.nameInput = false;
		return false;
	}, "Введите имя", 1, false);

	pristine.addValidator(phoneInput, function (value, phoneInput) {
		if (value.length <= 20 && value.length >= 11) {
			errorsConditions.phoneInput = true;
			formBody.phone = value;
			return true;
		}
		errorsConditions.phoneInput = false;
		return false;
	}, "Введите номер телефона полностью (от 11 до 20 символов)", 3, false);
}

export { requestCallValidation };