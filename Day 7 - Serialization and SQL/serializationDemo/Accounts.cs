
[Serializable]
public class Accounts
{
  public int AccountNo { get; set; }
  public string AccountName { get; set; }

  public double AccountBalance { get; set; }    

  public bool AccountIsActive { get; set; }

  public string AccountType { get; set; }


  public double Deposit(double amount)
  {
    AccountBalance = AccountBalance + amount;
    return AccountBalance;
  }

  public double Withdraw(double amount)
  {
    AccountBalance = AccountBalance - amount;
    return AccountBalance;
  }
}