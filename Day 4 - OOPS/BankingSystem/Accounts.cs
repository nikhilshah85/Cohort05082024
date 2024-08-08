public class Accounts
{
    //properties
    public int AccountNumber { get; set; }

    public string AccountName { get; set; }

    public double AccountBalance { get; set; }

    public bool AccountIsActive { get; set; }

    public string  AccountCity { get; set; }


    //for withdraw method, we will want to make sure of the following things before processing the request
    //1. Make sure that the account is active
    //2. Make sure that the withdrawal amount is less than the account balance
    //3. Make sure user does not input a negative amount, otherwise it will work reverersely, rather than reducing the balance, it will increase the balance
    //4. Minimum amount to withdraw is 100

    //Methods
    public double Withdraw(int withdrawalAmount)
    {
        //1. do your validations, like the above 4 points
        //2. do any calculations, formating of data, etc, business logic eg. apply some discount, or widrawal fees in case if needed
        //3. process the request which may be like reduce the balance from availablebalance, or fire an SQL query to database server to update the balance there
        //4. make an entry to log system

        if(AccountIsActive == false)
        {
            throw new Exception("Sorry you cannot perform this operation on an inactive account");
        }
        else if(withdrawalAmount > AccountBalance)
        {
            throw new Exception("Insufficient Balance");
        }
        else if(withdrawalAmount > 0 &&   withdrawalAmount < 100)
        {
            throw new Exception("Minimum amount to withdraw is 100");
        }
        else if(withdrawalAmount < 0)
        {
            throw new Exception("Withdrawal amount cannot be negative, please enter an value equal to or greater than 100");
        }
        AccountBalance = AccountBalance - withdrawalAmount;
        return AccountBalance;
    }

     public double Deposit(int depositAmount)
    {
        AccountBalance = AccountBalance + depositAmount;
        return AccountBalance;
    }
 public double CheckBalance()
    {
        return AccountBalance;
    }
   
}

