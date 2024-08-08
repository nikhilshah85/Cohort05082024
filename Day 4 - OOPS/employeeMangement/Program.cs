// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee empObj1 = new Employee(); //your very first object 
//set part of properies
empObj1.EmployeeNo = 501;
empObj1.EmployeeName = "John";
empObj1.EmployeeSalary = 10000.00;

//get part of the properties
Console.WriteLine("Employee Number : " + empObj1.EmployeeNo);
Console.WriteLine("Employee Name : " + empObj1.EmployeeName);
Console.WriteLine("Employee Salary : " + empObj1.EmployeeSalary);



// Console.WriteLine(empObj1.GetEmployeeDetails());

string _empDetails = empObj1.GetEmployeeDetails();
Console.WriteLine(_empDetails);

double _empBonus = empObj1.GetEmployeeBonus();
Console.WriteLine("Employee Bonus : " + _empBonus);

