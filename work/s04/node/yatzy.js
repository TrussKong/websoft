/**
 * @author Daniel Kongdet
 * 
 */
"use strict";

let Dice = require("./dice.js");
let hand = [];

for (let i = 0; i < 5; i++) {
    hand[i] = new Dice();
    hand[i].roll();
}

console.info("Here is the dices you have rolled.");
console.info(hand);
console.info(hand.join());