

#region List of Basic fundamental topics
// See https://aka.ms/new-console-template for more information



// Console.WriteLine("Hello, World!");

// Console.WriteLine("Welcome to Day 2");
// System.Console.WriteLine("Let us have a look at basics of programming ");

// //list of topics which are very basic in programming, we will learn then 1 by 1
// System.Console.WriteLine("1. Data Types");
// System.Console.WriteLine("2. Variables");
// System.Console.WriteLine("3. Operators");
// System.Console.WriteLine("4. Conditional Statements");
// System.Console.WriteLine("5. Looping");
#endregion

#region Numbers datatype intro 

// Console.WriteLine("Enter First Number");
// int num1 = Convert.ToInt32(Console.ReadLine()); //this is called as a type conversion from string to int


// Console.WriteLine("Enter 2nd Number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int addition = num1 + num2;
// int multiplication = num1 * num2;
// int subtraction = num1 - num2;
// int division = num1 / num2;

// System.Console.WriteLine("Addition of Numbers are " + addition);
// System.Console.WriteLine("Multiplication of Numbers are " + multiplication);
// System.Console.WriteLine("Subtraction of Numbers are " + subtraction);
// System.Console.WriteLine("Division of Numbers are " + division);
#endregion

#region String datatype introduction
// Console.WriteLine("Please enter your name");
// string firstName = Console.ReadLine();

// Console.WriteLine("Please enter your designation ");
// string designation = Console.ReadLine();

// System.Console.WriteLine("Welcome " + firstName + " " + designation);	
#endregion

//Conditions - they play a very important role in any programming language
//if...else
//if...else if...else if...else
//switch case 


#region Conditions

#region if...else
//Console.WriteLine("Please Enter a Number");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// if(userNumber > 0)
// {
//     Console.WriteLine("Number is Positive");
// }
// else
// {
//     Console.WriteLine("Number is Negative");
// }
#endregion

#region if...else if...else
// Console.WriteLine("Enter a Number");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());

// int USERNUMBER = 10;
// int usernumber = 30;
// int userNumber = 40;
// int UserNumber = 30;
//int _userNumber = 30;

// if(userNumber1 > 0 && userNumber1 < 10)
// {
//     Console.WriteLine("Good Number");
// }
// else if(userNumber1 > 10 && userNumber1 < 20)
// {
//     Console.WriteLine("Very Good Number");
// }
// else if(userNumber1 > 20 && userNumber1 < 30)
// {
//     Console.WriteLine("Great Number");	
// }
// else if(userNumber1 > 30 && userNumber1 < 40)
// {
//     Console.WriteLine("Excellent Number");
// }
// else if(userNumber1 > 50)
// {
//     Console.WriteLine("Magnificient !!");
// }
// else if(userNumber1 < 0)
// {
//     Console.WriteLine("Number is Negative and not accepted");
// }
#endregion


// #region switch case

// #region Options


// Console.WriteLine(" !! ~~~~~~~~~~~~~~  Welcome to Banking Management System - CITI Bank ~~~~~~~~~~~~~~ !! ");	
// Console.WriteLine("1. To Open A New Account");
// Console.WriteLine("2. Widraw Funds");
// Console.WriteLine("3. Deposit Funds");
// Console.WriteLine("4. Transfer Funds");
// Console.WriteLine("5. Raise A request for new cheque book");
// Console.WriteLine("6. Change ATM PIN");
// Console.WriteLine("7. Close Account");	


// int userChoice = Convert.ToInt32(Console.ReadLine());

// #endregion

// #region Switch case
// switch(userChoice)
// {
//     #region Case 1 : Open A New Account
//     case 1:
//      Console.WriteLine("Opening a new account, please provide below details");
//      Console.WriteLine("Enter First Name");
//      string firstName = Console.ReadLine();
//      Console.WriteLine("Enter Last Name");
//      string lastName = Console.ReadLine();
//      Console.WriteLine("Enter Email Id");
//      string emailId = Console.ReadLine();
//      Console.WriteLine("Enter Mobile Number");
//      string mobileNumber = Console.ReadLine();
//      Console.WriteLine("Enter Aadhar Number");
//      string aadharNumber = Console.ReadLine();
//      Console.WriteLine("Enter Pan Number");
//      string panNumber = Console.ReadLine();
//      Console.WriteLine("Enter Account Number");

//      System.Console.WriteLine("Your Account Has been opened, Happy Banking !!", firstName);
//      break;
//     #endregion
   
//     #region Case 2 : Widraw Funds
//     case 2:
//         Console.WriteLine("Enter the Amount You wish to widraw");
//         Console.WriteLine("Widraw Successful, enjoy your money");
//         break;
//  #endregion

//     #region Case 3 : Deposit Funds
//     case 3:
//         Console.WriteLine("Enter the Amount You wish to deposit");
//         Console.WriteLine("Deposit Successful");
//         break;
// #endregion

//     #region Case 4 : Transfer Funds
//     case 4:
//         Console.WriteLine("Enter the Amount You wish to transfer");
//         Console.WriteLine("Transfer Successful");
//         break;
// #endregion

//     #region Case 5 : Raise A request for new cheque book
//     case 5:
//         Console.WriteLine("Request for new cheque book is booked, please wait for approval");
//         break;
// #endregion

//     #region Case 6 : Change ATM PIN
//         case 6:
//         Console.WriteLine("Enter the new ATM PIN");
//         Console.WriteLine("ATM PIN Changed Successfully");
//         break;
// #endregion

//     #region Case 7 : Close Account
//     case 7:
//         Console.WriteLine("Account Closed Successfully");
//         Console.WriteLine("We will miss you ");
//         break;
// #endregion

//     #region Default Case
//     default:
//         Console.WriteLine("Invalid Choice");
//         break;
//  #endregion
// }
// #endregion








// #endregion

#endregion


//Loops - Iterations, when you wish to repeate the process multiple times, you can use loops

//Types of loops 

// 1. For Loop - this is when you are aware how many iterations you want to run 
//eg. print a table of 5 - do a 10 iterations 

#region For Loop

// Console.WriteLine("Enter a number to print table");
// int table = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10 ; i++)
// {
//     Console.WriteLine(table + " * " + i + " = " + table * i);
// }

#endregion


 #region  While loop

// Console.WriteLine("Enter a number");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 0;
// int oddNumbers = 0;
// int greaterThan100 = 0;
// int totalNumber = 0;
// int positiveNumbers = 0;
// int negativeNumbers = 0;


// while(number != 10)
// { 
//     if(number % 2 == 0)
//     {
//         evenNumber++;
//     }
//     else
//     {
//         oddNumbers++;
//     }

//     if(number > 100)
//     {
//         greaterThan100++;
//     }

//     totalNumber++;

//     if(number >= 0)
//     {
//         positiveNumbers++;
//     }
//     else
//     {
//         negativeNumbers++;
//     }



//     Console.WriteLine("Enter another  number");
//     number = Convert.ToInt32(Console.ReadLine());
// }


// Console.Clear();
// Console.WriteLine("Even Numbers : " + evenNumber);
// Console.WriteLine("Odd Numbers : " + oddNumbers);
// Console.WriteLine("Greater than 100 : " + greaterThan100);
// Console.WriteLine("Total Number : " + totalNumber);
// Console.WriteLine("Positive Numbers : " + positiveNumbers);
// Console.WriteLine("Negative Numbers : " + negativeNumbers);

 #endregion


#region While loop, switch case, if condition
// bool continueOperation = true;
// while(continueOperation)
// {


// Console.WriteLine(" !! ~~~~~~~~~~~~~~  Welcome to Banking Management System - CITI Bank ~~~~~~~~~~~~~~ !! ");	
// Console.WriteLine("1. To Open A New Account");
// Console.WriteLine("2. Widraw Funds");
// Console.WriteLine("3. Deposit Funds");
// Console.WriteLine("4. Transfer Funds");
// Console.WriteLine("5. Raise A request for new cheque book");
// Console.WriteLine("6. Change ATM PIN");
// Console.WriteLine("7. Close Account");	



// int userChoice = Convert.ToInt32(Console.ReadLine());


// switch(userChoice)
// {
//     case 1:
//         Console.WriteLine("Opening A New Account process, please wait...");        
//         break;

//     case 2:
//         Console.WriteLine("Widraw Funds process, please wait...");
//         int widrawAmount = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Widraw Successful");
//         break;

//     case 3:
//         Console.WriteLine("Deposit Funds");
//         break;

//     case 4:
//         Console.WriteLine("Transfer Funds");
//         break;

//     case 5:
//         Console.WriteLine("Raise A request for new cheque book");
//         break;

//     case 6:
//         Console.WriteLine("Change ATM PIN");
//         break;

//     case 7:
//         Console.WriteLine("Close Account");
//         break;
  
//     default:
//         Console.WriteLine("Invalid Choice");
//         break;  

// }

//   Console.WriteLine("Do you wish to continue? (y/n)");
//     string continueChoice = Console.ReadLine();
//     if(continueChoice == "n")
//     {
//         continueOperation = false;
//     }
//     Console.Clear();

// }

#endregion

















