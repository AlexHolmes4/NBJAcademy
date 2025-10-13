window.registerResizeCallback = function (dotNetHelper) {
    window.onresize = () => {
        dotNetHelper.invokeMethodAsync('OnBrowserResize');
    };
};

window.getWindowDimensions = function () {
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};