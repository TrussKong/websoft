/**
 * @Daniel Kongdet
 */

 "use strict"

 const port = process.env.DBWEBB_PORT || 1337;
 const express = require("express");
 const router = express.Router();

 router.get('/',(req,res) => {
     res.send("Hello Ninja");
 });

 router.get('/about',(req,res)=> {
     res.send("About something");
 });

 module.exports = router;