public class Checking : Accounts
{
    public bool EnableOverDraftFacilty { get; set; } //OverDraftFacility is like a short loan facility, in which even if you do not have
                                                     //enough balance in account, you will be able to withdraw or transfer it.



        // lets say AccountBalance for checking account obj is 40000
        //they wish to withdraw 200000,
        //should that be allowed
        //here you can withdraw max 140000

        //however, they are allowed to transact max 100000

    public override double WithDraw(double amount)
    {
        if(amount > 100000)
        {
            throw new Exception("Checking account can withdraw maximum 100000");
        }
        else if( AccountBalance - amount < 100000 && EnableOverDraftFacilty == true)
        {
            AccountBalance = AccountBalance - amount;
            return AccountBalance;
        }
        else if (AccountBalance - amount >  100000)
        {
            throw new Exception("You have exceeded the overdraft limit")
        }
      return base.WithDraw(amount);
      

       
    }
}