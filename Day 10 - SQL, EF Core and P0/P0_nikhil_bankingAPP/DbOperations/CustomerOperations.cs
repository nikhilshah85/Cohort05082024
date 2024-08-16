using P0_nikhil_bankingAPP.Models;
public class CustomerOperations
{

    P0NikhilBankingDbContext db = new P0NikhilBankingDbContext();

    public bool checkCustomerLogin(string userName, string passeword)
    {
        var checkCustomer = (from a in db.CustomerUsers
                            where a.UserName == userName && a.Password == passeword
                            select a).Single();

        if (checkCustomer != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void Withdraw(int accNo, int amount)
    {
        //withdraw logic, LINQ query to update the table 

        Console.WriteLine("Withdraw successfully done");
    }

    public void Deposit(int accNo, int amount)
    {
        //deposit logic, LINQ query to update the table
        Console.WriteLine("Deposit successfully done"); 
    }

    public void Transfer(int accNo, int amount)
    {
        //transfer logic, LINQ query to update the table
        Console.WriteLine("Transfer successfully done");
    }



}

