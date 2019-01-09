import createRequest from '../../shared/createRequest/createRequest'

const reqQueryParams = {};

function getReqParams() {
	const catalog = '/catalog';
	const pathIndex = location.href.indexOf(catalog);
	return {
		path: `/api/v1/Products/section${location.href.slice(pathIndex + catalog.length)}`,
		method: 'GET'
	}
}

function getProducts() {
	createRequest(getReqParams(), reqQueryParams)
		.then((response) => {
			if (response.statusText === 'OK') {
				console.log('response', response);
				return response.json();
			}
		})
		.then((result) => {
			console.log('result', result)
		})
}

function getProductsBySorting() {
	const elem = document.querySelector('select.catalog__sorting-select');

	elem.addEventListener('change', function () {
		reqQueryParams[elem.dataset.reqName] = elem.value;
		getProducts();
	})
}

function getProductsByCount() {
	const elem = document.querySelectorAll('span.js-product-num');

	for (let i = 0; i < elem.length; i++) {
		elem[i].addEventListener('click', function () {
			reqQueryParams[elem[i].dataset.reqName] = elem[i].dataset.productNum;
			// каждый раз при изменении количества отображаемых товаров задаём page = 1
			reqQueryParams.page = 1;
			getProducts();
		})
	}
}


export { getProductsBySorting, getProductsByCount };