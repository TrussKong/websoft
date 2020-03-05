"use strict"


var express = require("express");
var router = express.Router();

router.get("/", (req,res) =>{
    let LottoBall = require("./lottoBall");
    let lottoDraw = [];

    for (let i = 0; i < 7; i++) {
        lottoDraw[i] = new LottoBall();
        lottoDraw[i].ball();
         console.info("Ball "+ [i+1] + " is the number = " + lottoDraw[i]);

    }
     res.json({row :[lottoDraw.toString()]});

});

module.exports = router;