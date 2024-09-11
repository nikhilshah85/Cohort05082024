
class Employee{

myName:string = "Nikhil";
myPhone:number = 908989;
myEmail:string = "nikhilshah@hotmail.com";
isPermenant:boolean = true;
salary:any = "Ten thousand";

displayDetails(){
console.log("My name is "+this.myName+" and I am a permanent employee");
}

}

var empObj = new Employee();
empObj.displayDetails();

