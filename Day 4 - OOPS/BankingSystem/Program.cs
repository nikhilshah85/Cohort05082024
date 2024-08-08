// See https://aka.ms/new-console-template for more information

using System.Collections;
#region OOPS Accounts Class Testing


// Accounts accObj1 = new Accounts();
// accObj1.AccountNumber = 1006;
// accObj1.AccountName = "Bill";
// accObj1.AccountBalance = 12000;
// accObj1.AccountCity = "NYK";
// accObj1.AccountIsActive = false;
// bool continiueBanking = true;
// while(continiueBanking)
// {
// Console.WriteLine("Choose An Option");
// Console.WriteLine("1. To Withdraw");
// Console.WriteLine("2. To Deposit");
// Console.WriteLine("3. Check Balance");
// Console.WriteLine("4. Exit");
// try
// {
// int choice = Convert.ToInt32(Console.ReadLine());


// switch (choice)
// {
//     case 1:
//         Console.WriteLine("Enter Amount To Withdraw");
//         int withdrawAmount = Convert.ToInt32(Console.ReadLine());
//         accObj1.Withdraw(withdrawAmount);
//         Console.WriteLine("Balance After Withdraw " + accObj1.CheckBalance());
//         break;
//     case 2:
//         Console.WriteLine("Enter Amount To Deposit");
//         int depositAmount = Convert.ToInt32(Console.ReadLine());
//         accObj1.Deposit(depositAmount);
//         Console.WriteLine("Balance After Deposit " + accObj1.CheckBalance());
//         break;
//     case 3:
//         Console.WriteLine("Avaialble Balance is " + accObj1.CheckBalance());
//         break;
//     case 4:
//         continiueBanking = false;
//         Console.WriteLine("Thank You for banking with us");
//         break;
//     default:
//         Console.WriteLine("Invalid Choice");
//         break;
// }
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// }

#endregion


#region List of Accounts
// Accounts acc1 = new Accounts(){ AccountNumber = 1, AccountName = "Bill", AccountBalance = 12000, AccountCity = "NYK", AccountIsActive = true};
// Accounts acc2  = new Accounts(){ AccountNumber = 2, AccountName = "Steve", AccountBalance = 3000, AccountCity = "DC", AccountIsActive = false};
// Accounts acc3  = new Accounts(){ AccountNumber = 3, AccountName = "William", AccountBalance = 18000, AccountCity = "Reston", AccountIsActive = false};
// Accounts acc4 = new Accounts(){ AccountNumber = 4, AccountName = "John", AccountBalance = 9000, AccountCity = "Middletown", AccountIsActive = false};
// Accounts acc5  = new Accounts(){ AccountNumber = 5, AccountName = "Undertaker", AccountBalance = 150000, AccountCity = "Mumbai", AccountIsActive = true};
// Accounts acc6 = new Accounts(){ AccountNumber = 6, AccountName = "Stepheny", AccountBalance = 300, AccountCity = "London", AccountIsActive = false};
// Accounts acc7 = new Accounts(){ AccountNumber = 7, AccountName = "Paris", AccountBalance = 20000, AccountCity = "Atlanta", AccountIsActive = true};
// Accounts acc8 = new Accounts(){ AccountNumber = 8, AccountName = "Peter Parker", AccountBalance = 2500000, AccountCity = "Bahamas", AccountIsActive = false};
// Accounts acc9 = new Accounts(){ AccountNumber = 9, AccountName = "Gotham", AccountBalance = 35000, AccountCity = "Tokyo", AccountIsActive = false};
// Accounts acc10 = new Accounts(){ AccountNumber = 10, AccountName = "Angelina", AccountBalance = 38000, AccountCity = "Reston", AccountIsActive = true};
// Accounts acc11 = new Accounts(){ AccountNumber = 11, AccountName = "Drew Berry", AccountBalance = 1200000, AccountCity = "Reston", AccountIsActive = true};


// //List<string> friends = new List<string>();
// List<Accounts> accList = new List<Accounts>();

// accList.Add(acc1);
// accList.Add(acc2);
// accList.Add(acc3);
// accList.Add(acc4);
// accList.Add(acc5);
// accList.Add(acc6);
// accList.Add(acc7);
// accList.Add(acc8);
// accList.Add(acc9);
// accList.Add(acc10);
// accList.Add(acc11);


// int totalAccounts = 0;
// int totalActiveAccounts = 0;
// int totalInActiveAccounts = 0;
// double totalBalanceWithBank = 0;


// foreach(Accounts a in accList)
// {
//     Console.WriteLine(a.AccountNumber);
//     Console.WriteLine(a.AccountName.ToUpper());
//     Console.WriteLine(a.AccountBalance);
//     Console.WriteLine(a.AccountCity);
//     Console.WriteLine(a.AccountIsActive);
//     Console.WriteLine("-------------------------");

//     if(a.AccountIsActive == true)
//     {
//         totalActiveAccounts = totalActiveAccounts + 1;
//     }
//     else
//     {
//         totalInActiveAccounts = totalInActiveAccounts + 1;
//     }
//     totalBalanceWithBank = totalBalanceWithBank + a.AccountBalance;

//     totalAccounts = totalAccounts + 1;
// }

// Console.WriteLine("Press enter to View summary");
// Console.ReadLine();

// Console.WriteLine("==============================================================================");
// Console.WriteLine("Total Accounts : " + totalAccounts);
// Console.WriteLine("Total Active Accounts : " + totalActiveAccounts);
// Console.WriteLine("Total InActive Accounts : " + totalInActiveAccounts);
// Console.WriteLine("Total Balance With Bank : " + totalBalanceWithBank);

// Console.WriteLine("==============================================================================");

#endregion



MethodsDemo obj = new MethodsDemo();
// int result = obj.Add(10, 20);
// Console.WriteLine(result);

// int result2 = obj.Add(10, 20, 30);
// Console.WriteLine(result2);

// double result3 = obj.Add(30.88,90.97);
// Console.WriteLine(result3);

// string result4 = obj.Add("Hello", "Nikhil");
// Console.WriteLine(result4);


// int result = obj.Add(20,5,5,6,7,8,9,0,6,3,5,6,7,4,6,3,6,3,4,5,7,8,9,0,0);
// Console.WriteLine(result);


string order = obj.PlaceAnOrderAtRestaurant("Wanton Soup","American Choupsey", desertName:"Apple Pie");
Console.WriteLine(order);

























