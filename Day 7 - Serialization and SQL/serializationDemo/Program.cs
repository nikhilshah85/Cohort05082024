
// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;



Console.WriteLine("Hello, World!");


int choice = 0;

// while (choice != 3)
// {
// Console.Clear();
// Console.WriteLine("Welcome to Banking");
// Console.WriteLine("1. Open a New Account");
// Console.WriteLine("2. Get Account Details");

// Console.WriteLine("3. Exit");

//  choice = Convert.ToInt32(Console.ReadLine());

// switch (choice)
// {
//     case 1:    
// #region XML Serialization
//     Console.Clear();
// Accounts accObj = new Accounts();

// Console.WriteLine("Enter Account No");
// accObj.AccountNo = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter Account Name");
// accObj.AccountName = Console.ReadLine();

// Console.WriteLine("Enter Account Type");
// accObj.AccountType = Console.ReadLine();

// Console.WriteLine("Enter Account Balance");
// accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter Account Is Active");
// accObj.AccountIsActive = Convert.ToBoolean(Console.ReadLine());

// Console.WriteLine("Thank you account created successfully");

// Console.WriteLine("You can withdraw or deposit");

// FileStream myFile = new FileStream(accObj.AccountNo + ".xml", FileMode.Create, FileAccess.Write);


// XmlSerializer xs = new XmlSerializer(typeof(Accounts));
// xs.Serialize(myFile, accObj);
// myFile.Close();

// Console.WriteLine("Object Serialized");
// Console.ReadLine();

// #endregion
//     break;

//     case 2:
// //let us bring the object back to memory
// //We call it as Deserialization
// #region  Deserialization
// // //1
// Accounts acc; //no need to create a new object, because object is created and stored in memory


// Console.WriteLine("Enter Account No");
// int accNo = Convert.ToInt32(Console.ReadLine());

// //2 
// FileStream myFile2 = new FileStream(accNo + ".xml", FileMode.Open, FileAccess.Read);

// //3
// XmlSerializer getAccount  = new XmlSerializer(typeof(Accounts));
// acc = (Accounts) getAccount.Deserialize(myFile2);


// Console.WriteLine("Account Number " + acc.AccountNo);
// Console.WriteLine("Account Name " + acc.AccountName);
// Console.WriteLine("Account Type " + acc.AccountType);
// Console.WriteLine("Account Balance " + acc.AccountBalance);
// Console.WriteLine("Account Is Active " + acc.AccountIsActive);

// myFile2.Close();

// #endregion
//     break;

//     default:
//     Console.WriteLine("Wrong Option");
//         break;

// }


// }

// List<Accounts> accList = new List<Accounts>()
// {
//     new Accounts(){ AccountNo=101, AccountName="Rax", AccountBalance=9000, AccountIsActive=true, AccountType="Savings"},
//     new Accounts(){ AccountNo=102, AccountName="Max", AccountBalance=19000, AccountIsActive=true, AccountType="Loan"},
//     new Accounts(){ AccountNo=103, AccountName="Sundar", AccountBalance=29000, AccountIsActive=false, AccountType="Savings"},
//     new Accounts(){ AccountNo=104, AccountName="Aflex", AccountBalance=39000, AccountIsActive=true, AccountType="Checking"},
//     new Accounts(){ AccountNo=105, AccountName="Richard", AccountBalance=45000, AccountIsActive=true, AccountType="Savings"},
// };


// FileStream myFile = new FileStream("accounts.xml", FileMode.Create, FileAccess.Write);

XmlSerializer xs = new XmlSerializer(typeof(List<Accounts>));
// xs.Serialize(myFile, accList);
// myFile.Close();


List<Accounts> readAllAccounts;
FileStream myFile2 = new FileStream("accounts.xml", FileMode.Open, FileAccess.Read);
readAllAccounts = (List<Accounts>)xs.Deserialize(myFile2);

foreach (var item in readAllAccounts)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine(item.AccountNo);
    Console.WriteLine(item.AccountName);
    Console.WriteLine(item.AccountType);
    Console.WriteLine(item.AccountBalance);
    Console.WriteLine(item.AccountIsActive);
    Console.WriteLine("----------------------------------");
}

myFile2.Close();