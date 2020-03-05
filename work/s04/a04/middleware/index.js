"use strict"

function incomingToConsole(req,res,next) {
    console.info(`Got request on ${req.path} (${req.method}).`);
    next();
}

module.exports = {
    incomingToConsole: incomingToConsole
};