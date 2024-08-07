// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;


#region Sample code to show values gets overridden with data types
//Console.WriteLine("Hello, World!");


// string guestName = "Alex";
// // Console.WriteLine(guestName);

// guestName = "Maria";
// Console.WriteLine(guestName);

// guestName = "John"; //this will overide the previous value
#endregion

#region Array Demo

#region example 1
// string[] friends = new string[5];
// friends[0] = "Alex";
// friends[1] = "Maria";
// friends[2] = "Smith";
// friends[3] = "Stephen";
// friends[4] = "Shailesh";

// Console.WriteLine(friends[0]);
// Console.WriteLine(friends[1]);
// Console.WriteLine(friends[2]);
// Console.WriteLine(friends[3]);
// Console.WriteLine(friends[4]);
#endregion

#region  example 2

// Console.WriteLine("How many friends do you have ?" );
// int friendsCount = int.Parse(Console.ReadLine());

// string[] friends = new string[friendsCount];

// for(int i=0; i < friendsCount; i++)
// {
//     Console.WriteLine("Enter friend name " + (i+1)); 
//     friends[i] = Console.ReadLine();
//     Console.Clear();
// }

// Console.Clear();
// for(int i = 0 ;i<friendsCount; i++)
// {
//     Console.WriteLine(friends[i]);
// }
#endregion

#region example 3

// int[] favNumber = new int[10];

// int sumOfNumber = 0;



// for (int i = 0; i < favNumber.Length; i++)
// {
//     Console.WriteLine("Enter your favourite number : ");
//     favNumber[i] = int.Parse(Console.ReadLine());
//     Console.Clear();
// }



// for (int i = 0; i < favNumber.Length ; i++)
// {
//     sumOfNumber = sumOfNumber + favNumber[i];
// }

// Console.WriteLine("Sum of all your numbers are  " + sumOfNumber);




#endregion

#endregion


#region ArrayList Demo
#region example 1
// ArrayList myValues = new ArrayList();

// myValues.Add(10);
// myValues.Add("Nikhil");
// myValues.Add(20.30);
// myValues.Add(true);
// myValues.Add("Julie");
// myValues.Add(-40);


// for(int i = 0; i < myValues.Count; i++)
// {
//     Console.WriteLine(myValues[i]);
// }
#endregion

#region example 2
// ArrayList mynewvalues = new ArrayList();

// string val = "";

// while (val != "End")
// {
// Console.WriteLine("Enter the value, keep entering till you want, Type End to exit");
// val = Console.ReadLine();
//     if(val != "End")
//     {
//         mynewvalues.Add(val);
//     }
// }

// Console.Clear();
// Console.WriteLine("Thank you");
#endregion

#endregion


#region List



// List<string> friends = new List<string>();
// //keep on adding the values
// friends.Add("Alex");
// friends.Add("Maria");
// friends.Add("John");
// friends.Add("Stephen");
// friends.Add("Shailesh");
// friends.Add("Sonam");	
// friends.Add("Marie");
// friends.Add("Peter");
// friends.Add("Parker");
// friends.Add("Jane");
// friends.Add("Drew Berry");
// friends.Add("John Cena");

// foreach(var item in friends)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine("Total friends " + friends.Count);

#endregion


//dictionary is another collection which is for key and a value pair



Dictionary<int,string> guestList = new Dictionary<int, string>();

//int here is a key - which will need to be unique throughout the collection
//string is the value - which will always be string in this case

guestList.Add(101,"Nikhil");
guestList.Add(102,"Alex");
guestList.Add(103,"Maria");
guestList.Add(104,"John");
guestList.Add(105,"Stephen");
guestList.Add(106,"Shailesh");
guestList.Add(107,"Sonam");
guestList.Add(108,"Marie");
guestList.Add(109,"Peter");
guestList.Add(110,"Parker");
guestList.Add(111,"Jane");
guestList.Add(112,"Drew Berry");
guestList.Add(113,"John Cena");
guestList.Add(114,"Julie"); 

foreach(var item in guestList)
{   
    System.Console.WriteLine(item.Key + " " + item.Value);
}

