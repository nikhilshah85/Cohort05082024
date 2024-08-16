// See https://aka.ms/new-console-template for more information
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
        Console.WriteLine("Welcome Admin" + userName);
         Console.WriteLine("Admin Menu will be here");
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


