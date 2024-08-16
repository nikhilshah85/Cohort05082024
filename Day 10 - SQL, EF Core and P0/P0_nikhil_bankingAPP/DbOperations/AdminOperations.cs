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
}