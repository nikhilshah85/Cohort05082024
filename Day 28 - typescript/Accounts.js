"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var Accounts = /** @class */ (function () {
    function Accounts() {
        this.accNo = 1001;
        this.accType = "Savings";
        this.accBalance = 10000;
        this.accEmail = ["nikhil@gmail.com", "nikhil@hotmail.com", "nikhil@.yahoocom"];
    }
    Accounts.prototype.displayDetails = function () {
        console.log("Account No: " + this.accNo);
        console.log("Account Type: " + this.accType);
        console.log("Account Balance: " + this.accBalance);
        console.log("Account Email: " + this.accEmail);
    };
    return Accounts;
}());
var Savings = /** @class */ (function (_super) {
    __extends(Savings, _super);
    function Savings() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.bonus = 5000;
        return _this;
    }
    Savings.prototype.displayDetails = function () {
        _super.prototype.displayDetails.call(this);
    };
    return Savings;
}(Accounts));
var obj = new Savings();
console.log(obj.accNo);
obj.displayDetails();
