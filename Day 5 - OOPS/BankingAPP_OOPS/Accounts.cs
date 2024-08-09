public abstract class Accounts
{
    public int AccountNo { get; set; }
    public string AccountName { get; set; }
    public double AccountBalance { get; set; }
    public bool AccountIsActive { get; set; }
    public string AccountBranch { get; set; }

    public virtual double WithDraw(double amount)
    {
        if (amount > AccountBalance)
        {
            throw new Exception("Insufficient Balance");            
        }
        else
        {
            AccountBalance = AccountBalance - amount;
            return AccountBalance;
        }
    }

    public double Deposit(double amount)
    {
        AccountBalance = AccountBalance + amount;
        return AccountBalance;
    }

    public double CheckBalance()
    {
        return AccountBalance;
    }


}