"use strict"

let LottoBall = require("./lottoBall")
let lottoDraw = [];

for (let i = 0; i < 7; i++) {
lottoDraw[i] = new LottoBall();
lottoDraw[i].ball();

console.info("Ball "+ [i+1] + " is the number = " + lottoDraw[i]);
    
}

console.info(lottoDraw);
console.info(lottoDraw.join());