/**
 * @author
 * lotto ball object
 */

 class LottoBall{
constructor(){
    this.lottoBall=null;
    }

    ball(number = 36){
        this.lottoBall = Math.floor(Math.random() * number + 1);
        return this.lottoBall;
    }
    lastLottoBall(){
        return this.lottoBall;
    }
    toString(){
        return this.lottoBall;
    }

 } 
 module.exports = LottoBall;