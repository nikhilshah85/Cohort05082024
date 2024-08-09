// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Accounts accObj = new Accounts();  // this is not an real world entity, it is an Absract for all the types of accounts, this this class     
                                    //should be marked as Abstract

Savings savObj = new Savings();
savObj.AccountNo = 101;
savObj.AccountName = "Trisha";
savObj.AccountBalance = 40000;


Checking chkObj = new Checking();
chkObj.AccountNo = 102;
chkObj.AccountName = "Mansi";
chkObj.AccountBalance = 40000; 
chkObj.EnableOverDraftFacilty = true;
//conditions to test

//1. Available balance is 40000, and Overdraft facility is set to false, which means user can withdraw maximum of 40000 and not more than that
//2. Available balance is 40000, and Overdraft facility is set to true, which means user can withdraw maximum of 100000 and not more than that

Loan lnObj = new Loan();


bool transactmore = true;

while(transactmore)
{
try
{
    Console.Clear();
    Console.WriteLine("Enter Amount you wish to Withdraw");
    int amount = Convert.ToInt32(Console.ReadLine());
    double newBalance = chkObj.WithDraw(amount);
   
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("New Availabe Balance " + chkObj.AccountBalance);
    Console.ReadLine();
}
}

