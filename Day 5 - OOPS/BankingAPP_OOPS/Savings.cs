public class Savings : Accounts
{

    public int IntrestEarned { get; set; }

    public override double WithDraw(double amount)
    {
            if(amount > 20000)
            {
                throw new Exception("Savings account can withdraw maximum 20000");
            }

        return base.WithDraw(amount); //go to parent class, find the method withdraw and execute it
    }

}