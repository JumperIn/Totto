class Carousel {
	constructor(wrapper, buttonLeft, buttonRight) {
		this._buttonLeft = document.querySelector(buttonLeft);
		this._buttonRight = document.querySelector(buttonRight);
		this._wrapper = document.querySelector(wrapper);
		this._wrapperPosition = 0;
		this._wrapperPositionBefore = 0;
		this._slideInterval = null;
		this._stateSwipe = false;
		this._timeStampStart;
		this._timeStampEnd;
		this._startX;
		this._endX;
		this._swipeMoveEvent = false;
	}

	refreshCarousel() {
		this._wrapperPosition = 0;
		this._wrapperPositionBefore = 0;
		this._wrapper.style.transform = `translateX(0)`;
	}

	getNumProductsDisplay() {
		return Math.round(this._wrapper.offsetWidth / this._wrapper.firstElementChild.offsetWidth);
	}

	getMaxWrapperPosition() {
		return this._wrapper.children.length - this.getNumProductsDisplay();
	}

	moveCarouselLeft() {
		--this._wrapperPosition;
		if (this._wrapperPositionBefore === 0 && this._wrapperPosition === - 1) {
			this._wrapperPosition = this.getMaxWrapperPosition();
			this._wrapper.style.transform = `translateX(${-this._wrapperPosition * 100 / this.getNumProductsDisplay()}%)`;
		} else {
			this._wrapper.style.transform = `translateX(${-this._wrapperPosition * 100 / this.getNumProductsDisplay()}%)`;
		}
		this._wrapperPositionBefore = this._wrapperPosition;
	}

	moveCarouselRight() {
		++this._wrapperPosition;
		if (this._wrapperPositionBefore === this.getMaxWrapperPosition() && this._wrapperPosition === this.getMaxWrapperPosition() + 1) {
			this._wrapperPosition = 0;
			this._wrapper.style.transform = `translateX(0)`;
		} else {
			this._wrapper.style.transform = `translateX(${-this._wrapperPosition * 100 / this.getNumProductsDisplay()}%)`;
		}
		this._wrapperPositionBefore = this._wrapperPosition;
	}

	moveCarouselInterval(delay) {
		this._slideInterval = setInterval(() => this.moveCarouselRight(), delay);
	}

	stopCarousel() {
		clearInterval(this._slideInterval)
	}

	moveCarouselIntervalEvent(delay) {
		this._wrapper.addEventListener('mouseover', () => this.stopCarousel());

		this._wrapper.addEventListener('mouseout', () => this.moveCarouselInterval(delay));

		this.moveCarouselInterval(delay);
	};

	// swipe

	swipeStart(e) {
		this._stateSwipe = true;
		this._timeStampStart = e.timeStamp;
		this._startX = e.touches[0].clientX;
	}

	swipeMove(e) {
		this._endX = e.touches[0].clientX;
		this._swipeMoveEvent = true;
	}

	swipeCancel(e) {
		this._stateSwipe = false;
	}

	swipeEnd(e) {
		if (!this._swipeMoveEvent) { return }
		let wrapperWidth,
			difference,
			conditionSwipeLeft,
			conditionSwipeRight,
			deffTimeStamp;

		this._timeStampEnd = e.timeStamp;

		deffTimeStamp = this._timeStampEnd - this._timeStampStart;
		// если время между началом свайпа и его концом больше секунды, то событие не происходит
		if (deffTimeStamp > 1000) { this._stateSwipe = false }

		wrapperWidth = this._wrapper.offsetWidth;

		difference = this._startX - this._endX;

		conditionSwipeLeft = -difference >= wrapperWidth / 3;
		conditionSwipeRight = difference >= wrapperWidth / 3;

		if (this._stateSwipe === true) {
			if (conditionSwipeLeft) {
				this.moveCarouselLeft();
			} else if (conditionSwipeRight) {
				this.moveCarouselRight();
			} else {
				return;
			}
		}
		this._swipeMoveEvent = false;
	}

	// объединящая функция

	swipeEvents() {
		this._wrapper.addEventListener('touchstart', e => this.swipeStart(e));
		this._wrapper.addEventListener('touchmove', e => this.swipeMove(e));
		this._wrapper.addEventListener('touchcancel', e => this.swipeCancel(e));
		this._wrapper.addEventListener('touchend', e => this.swipeEnd(e));
	}


	moveCarouselEvents() {
		this._buttonLeft.addEventListener('click', () => { this.moveCarouselLeft() });
		this._buttonRight.addEventListener('click', () => { this.moveCarouselRight() });
	}
}

export { Carousel };