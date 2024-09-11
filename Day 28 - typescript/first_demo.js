var Employee = /** @class */ (function () {
    function Employee() {
        this.myName = "Nikhil";
        this.myPhone = 908989;
        this.myEmail = "nikhilshah@hotmail.com";
        this.isPermenant = true;
        this.salary = "Ten thousand";
    }
    Employee.prototype.displayDetails = function () {
        console.log("My name is " + this.myName + " and I am a permanent employee");
    };
    return Employee;
}());
var empObj = new Employee();
empObj.displayDetails();


class Manager{
    
}