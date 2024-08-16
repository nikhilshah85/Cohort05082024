using P0_nikhil_bankingAPP.Models;
public class AdminOperations
{

   P0NikhilBankingDbContext db = new P0NikhilBankingDbContext();

    public bool CheckAdminCredentials(string username, string password)
    {
        var checkAdmin = (from a in db.AdminUsers
                        where a.UserName == username && a.Password == password
                        select a).Single();

        if (checkAdmin != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAdminMenu()
    {
        // 1. Create New Account
		// 	2. Delete Account
		// 	3. Edit Account Details
		// 	4. Display Summary 
		// 	5. Reset Customer Password
		// 	6. Approve Cheque book request
		// 	7. Exit

        Console.WriteLine("1. Create New Account");
        Console.WriteLine("2. Delete Account");
        Console.WriteLine("3. Edit Account Details");
        Console.WriteLine("4. Display Summary ");
        Console.WriteLine("5. Reset Customer Password");
        Console.WriteLine("6. Approve Cheque book request");
        Console.WriteLine("7. Exit");
    




    }

    public  void CreateNewAccount(AccountInfo accObj)
    {
        //we can validate the data here

        db.AccountInfos.Add(accObj);
        db.SaveChanges();

    }

    public void DeleteAccount(int accNo)
    {
        //we can validate the data here
        AccountInfo accObj = db.AccountInfos.Find(accNo);
        db.AccountInfos.Remove(accObj);
        db.SaveChanges();

    }

    public void EditAccountDetails(AccountInfo changes)
    {
        //we can validate the data here

        AccountInfo acc = db.AccountInfos.Find(changes.AccNo);

        if (acc != null)
        {
            //update
            acc.AccName = changes.AccName;
            acc.AccType = changes.AccType;
            acc.AccBalance = changes.AccBalance;
            acc.AccIsActive = changes.AccIsActive;
        }


      //  db.AccountInfos.Update(changes);
        db.SaveChanges();
    }

}