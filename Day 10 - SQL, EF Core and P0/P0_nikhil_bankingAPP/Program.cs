// See https://aka.ms/new-console-template for more information
using P0_nikhil_bankingAPP.Models;

Console.WriteLine(" Welcome To Banking");


int userType = 0;

Console.WriteLine("1. Admin");
Console.WriteLine("2. Customer");


userType = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Enter User Name");
string userName = Console.ReadLine();
Console.WriteLine("Enter Password");
string password = Console.ReadLine();

try
{
if (userType == 1)
{
    AdminOperations admin = new AdminOperations();
   bool Loginresult = admin.CheckAdminCredentials(userName,password);

    if (Loginresult == true)
    {
        Console.WriteLine("Welcome " + userName);
       admin.DisplayAdminMenu();
        int adminMenuChoice = Convert.ToInt32(Console.ReadLine());
        switch (adminMenuChoice)
        {
            #region Case 1 : Add new Account
            case 1:
                //Console.WriteLine("Create New Account");
                AccountInfo newAcc = new AccountInfo();
                Console.WriteLine("Enter Account Details");

                Console.WriteLine("Enter Account No");
                newAcc.AccNo = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter Customer Name");
                newAcc.AccName = Console.ReadLine();


                Console.WriteLine("Enter Account Type");
                newAcc.AccType = Console.ReadLine();               

                Console.WriteLine("Enter Balance");
                newAcc.AccBalance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Account is Active");
                newAcc.AccIsActive = Convert.ToBoolean(Console.ReadLine());

                admin.CreateNewAccount(newAcc);
                Console.WriteLine("Account created successfully");
              
             
                break;
         #endregion

            #region Case 2 : Delete Account
            case 2:
        
                Console.WriteLine("Delete Account");
                Console.WriteLine("Enter Account No to delete the account");
                int accNo = Convert.ToInt32(Console.ReadLine());
                admin.DeleteAccount(accNo);
                Console.WriteLine("Account deleted successfully");
                break;
                #endregion
          
            #region  Case 3: Edit Account
            case 3:

               AccountInfo newAcc2 = new AccountInfo();
                Console.WriteLine("Enter Account Details");

                Console.WriteLine("Enter Account No");
                newAcc2.AccNo = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter Customer Name");
                newAcc2.AccName = Console.ReadLine();


                Console.WriteLine("Enter Account Type");
                newAcc2.AccType = Console.ReadLine();               

                Console.WriteLine("Enter Balance");
                newAcc2.AccBalance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Account is Active");
                newAcc2.AccIsActive = Convert.ToBoolean(Console.ReadLine());

                admin.EditAccountDetails(newAcc2);
                Console.WriteLine("Account Edited successfully");
              
                break;
                #endregion
            case 4:
                Console.WriteLine("Display Summary");
                break;
            case 5:
                Console.WriteLine("Reset Customer Password");
                break;
            case 6:
                Console.WriteLine("Approve Cheque book request");
                break;
            case 7:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid Credentials");
        //developer can decide to loop and ask for username and password again
    }
    
}
else
{
    CustomerOperations customer = new CustomerOperations();
    customer.checkCustomerLogin(userName, password);

     bool Loginresult = customer.checkCustomerLogin(userName,password);

    if (Loginresult == true)
    {
        Console.WriteLine("Welcome " + userName);
         Console.WriteLine("Customer Menu will be here");
    }
    else
    {
        Console.WriteLine("Invalid Credentials");
        //developer can decide to loop and ask for username and password again
    }
}
}
catch (Exception ex)
{
    Console.WriteLine("Invaid Credentials");
}


