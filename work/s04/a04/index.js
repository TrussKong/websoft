/**
 * @author Daniel Kongdet
 * 
 *  Assignment 4
 */
"use strict";

const port = process.env.DBWEBB_PORT || 1337;
const express = require("express");
const app = express();
const path = require("path");
const routeIndex = require("./route/index.js");
const routeLotto = require("./route/lotto.js");
const routeLottoJson = require("./route/lotto-json.js");
const middleware = require("./middleware/index.js");

app.set("use views", "ejs");

app.use(middleware.incomingToConsole);
app.use(express.static(path.join(__dirname,"public")));
app.use("/", routeIndex);
app.use("/lotto", routeLotto);
app.use("/lotto-json", routeLottoJson);
app.listen(port, logStartUpDetailsToConsole);



function logStartUpDetailsToConsole() {
    let routes = [];

    app._router.stack.forEach((middleware) => {
        if (middleware.route) {
            routes.push(middleware.route);

        } else if (middleware.name === "router") {

            middleware.handle.stack.forEach((handler) => {
                let route;

                route = handler.route;
                route && routes.push(route);
            });
        }
    });

    console.info(`Server is listening on port ${port}.`);
    console.info("Available routes are:");
    console.info(routes);
}
