import createRequest from '../createRequest/createRequest';
import { subscribeOnNews } from '../createRequest/apiConfig';
import { addErrorMessage, removeErrorMessages } from '../requestCall/requestCall';

function subscribeNews() {
	const form = document.querySelector('form.footer-connection__form');
	const pristine = new Pristine(form);
	const emailInput = document.querySelector('input.footer-connection__input');

	const errorsConditions = {};
	const formBody = {};

	form.addEventListener('submit', function (e) {
		e.preventDefault();
		const valid = pristine.validate();

		if (valid) {
			removeErrorMessages('div.footer-connection__input-wrapper');
			createRequest(subscribeOnNews, null, formBody)
				.then(({ statusText }) => {
					if (statusText === 'OK') {
						emailInput.value = null;
						console.log('statusText', statusText);
					}
				})
		} else {
			removeErrorMessages('div.footer-connection__input-wrapper');
			const errorMessages = pristine.getErrors(emailInput);
			for (let i = 0; i < errorMessages.length; i++) {
				if (!errorsConditions.emailInput) addErrorMessage('div.footer-connection__input-wrapper', errorMessages[i]);
			}
		}
	})

	// TODO: добавить нормальную валидацию для этих полей
	pristine.addValidator(emailInput, function (value, emailInput) {
		if (value.length > 0) {
			errorsConditions.emailInput = true;
			formBody.email = value;
			return true;
		}
		errorsConditions.emailInput = false;
		return false;
	}, "Введите email", 1, false);
}

export { subscribeNews };