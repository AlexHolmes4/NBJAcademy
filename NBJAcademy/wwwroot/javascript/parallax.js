window.setParallax = function (selector) {
    const el = document.querySelector(selector);
    window.addEventListener('scroll', function () {
        let offset = window.pageYOffset;
        el.style.backgroundPositionY = offset * 0.2 + "px";
    });
}

window.removeParallax = function () {
    if (parallaxHandler) {
        window.removeEventListener('scroll', parallaxHandler);
        parallaxHandler = null;
    }
}