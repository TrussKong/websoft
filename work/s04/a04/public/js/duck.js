

(function () {
    'use strict';

    var area = document.body,
        areaHeight = innerHeight,
        areaWidth = innerWidth,
        timer = 1800;

    duck.src='img/pngguru.com.png';
    duck.style.position ='absolute';
    duck.width = '128';
    duck.height = '190';
    duck.addEventListener('click', newDuck);

    function newDuck() {
        var newX = Math.floor(Math.random() * (areaWidth-duck.width)),
            newY = Math.floor(Math.random() * (areaHeight-duck.height));

        duck.style.left = newX+'px';
        duck.style.top = newY+'px';
        area.appendChild(duck);
    }

    function showDuck() {
        window.setInterval(newDuck, timer);
    }


    showDuck();
})();