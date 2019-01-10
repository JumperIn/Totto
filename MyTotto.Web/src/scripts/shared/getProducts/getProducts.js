import createRequest from '../../shared/createRequest/createRequest'

const reqQueryParams = {};

function drawProducts(products) {

	let productsWrapper = document.querySelector('div.catalog__products');
	productsWrapper.innerHTML = null;

	for (let i = 0; i < products.length; i++) {
		const template = document.querySelector('template.products__item-template');
		// const link = template.content.querySelector('a.product');
		let image = template.content.querySelector('div.product__img');
		const productName = template.content.querySelector('h4.product__name');
		const price = template.content.querySelector('p.product__price-before');
		const discountPrice = template.content.querySelector('p.product__price-after');
		const productSale = template.content.querySelector('div.product-sale');

		// link.href = ``;
		image.style.backgroundImage = `url(${products[i].cardImage})`;
		productName.innerHTML = `${products[i].manufacturer.title} ${products[i].title}`;
		price.innerHTML = products[i].discount !== 0 ? products[i].price.toFixed(2).toString().replace('.', ',') : '';
		discountPrice.innerHTML = products[i].discountPrice.toFixed(2).toString().replace('.', ',');
		if (products[i].productType === 0) {
			productSale.innerHTML = '<div class="js-product-sale__hit product-sale_orange">Хит</div>';
		} else if (products[i].productType === 1) {
			productSale.innerHTML = '<div class="js-product-sale__new product-sale_light-blue">New</div>';
		} else if (products[i].productType === 2) {
			productSale.innerHTML = '<div class="js-product-sale__stock product-sale_red">Акция</div>';
		}

		let clone = document.importNode(template.content, true);

		productsWrapper.appendChild(clone);
	}
}

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
		.then((products) => {
			console.log('result', products)
			// TODO: удаление содержимого обёртки
			// отрисовка полученных товаров через template
			drawProducts(products);
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