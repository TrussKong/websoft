(function () {
    'use strict';

    let url;

    url = "data/1081.json";
    fetch(url)
        .then((response) => {
            return response.json();
        })
        .then((myJson) => {
            console.log(myJson);
        })

        console.log('Sandbox MEGA is ready');

 })();



