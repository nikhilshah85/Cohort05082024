public class Loan : Accounts
{
    public double RateOfIntrest { get; set; }

    public override double WithDraw(double amount)
    {
        throw new Exception("Loan account holders cannot withdraw, please contact bank");
    }
}