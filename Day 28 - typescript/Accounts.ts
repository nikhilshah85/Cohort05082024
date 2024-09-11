import { MongoCryptInvalidArgumentError } from "mongodb";

class Accounts
{
    accNo:number = 1001;
    accType:string = "Savings";
    accBalance:number = 10000;
    accEmail:string[] = ["nikhil@gmail.com","nikhil@hotmail.com","nikhil@.yahoocom"];
    displayDetails()
    {
        console.log("Account No: "+this.accNo);
        console.log("Account Type: "+this.accType);
        console.log("Account Balance: "+this.accBalance);
        console.log("Account Email: "+this.accEmail);
    }
}
class Savings extends Accounts
{
    bonus:number = 5000;
    displayDetails()
    {
        super.displayDetails();
    }
}

var obj = new Savings();
console.log(obj.accNo);
obj.displayDetails();
