// See https://aka.ms/new-console-template for more information

#region example 1 - Handle System Exception

// try
// {
// Console.WriteLine("Enter First  number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int divideResult = num1 / num2;
// Console.WriteLine(divideResult);

// }
// catch(FormatException ex)
// {
//     Console.WriteLine("Please Enter number in Numeric format only");
// }
// catch(DivideByZeroException ex)
// {
//     Console.WriteLine("You cannot divide any number by Zero universally");
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }


// Console.WriteLine("Thank you for useing my program");
#endregion


bool continueExecution = true;

while(continueExecution)
{
try
{
    List<string> friends = new List<string>();
    string val = "";	

        while(val.Length != 1)
        {
            Console.WriteLine("Enter your friends name");
           val = Console.ReadLine();
        }

    // while(val != "End")
    // {
    //       Console.WriteLine("Enter your friends name");
    //       val = Console.ReadLine();
    //       if(val.Length == 1)
    //       {
    //           throw new Exception("Your name should not be less than 2 characters " + val + " is not added to friends list ");
    //       }
    //       else
    //       {

    //       friends.Add(val);
    //       if(val == "End")
    //       {
    //         continueExecution = false;
    //         Console.WriteLine("Thank you for using my program, all the friends are added and save");
    //       }
    //       }
    // }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Thank you for using my program");
}
}