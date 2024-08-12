// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Security.Cryptography;

#region File I/O Demo 1 
// Console.WriteLine("Hello, World!");

// FileStream myFileObj = new FileStream("demo.txt",FileMode.Create,FileAccess.Write);

// StreamWriter pen = new StreamWriter(myFileObj);
// try
// {

//     pen.WriteLine("Hello My Name is Nikhil");
//     pen.WriteLine("I am from India");
//     pen.WriteLine("I love Programming");
//     pen.WriteLine("I am from IT background and  I am mostly working on softwares on Microsoft platform");
// }
// catch(IOException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     pen.Close();
//     myFileObj.Close();
//     Console.WriteLine("Content written to file and file is saved");
// }

#endregion

#region File I/O Demo 2 - take user input and dynamic file name


// Console.WriteLine("Enter your name");
// string guestName = Console.ReadLine();


// FileStream myFile2 = new FileStream(guestName + ".txt",FileMode.Create,FileAccess.Write);
// StreamWriter pen2 = new StreamWriter(myFile2);
// try
// {
//     Console.WriteLine("Please enter your message");
//     string message = Console.ReadLine();
//     pen2.WriteLine(message);

//     Console.WriteLine("What is your Fav Hobby");
//     string hobby = Console.ReadLine();  
//     pen2.WriteLine(hobby);
   
//     Console.WriteLine("Please keep telling us more about yourself, press Enter 2 times once done");
//     hobby = Console.ReadLine();
//     pen2.WriteLine(hobby);

//     bool continueLoop = true;
//     while(continueLoop)
//     {
//         Console.Clear();
//         Console.WriteLine("Thanks, Tell us more, press Enter 2 times once done");
//         hobby = Console.ReadLine();
//         if(hobby == "")
//         {

//             continueLoop = false;
//         }
//         else
//         {
//             pen2.WriteLine(hobby);
//         }
//     }
// }
// catch(IOException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     pen2.Close();
//     myFile2.Close();
//     Console.WriteLine("Content written to file and file is saved");
// }

#endregion

#region  Read A File
// FileStream readAFile = new FileStream("John.txt",FileMode.Open,FileAccess.Read);
// StreamReader rd = new StreamReader(readAFile);
// try
// {
// //    Console.WriteLine(rd.ReadLine());
// //     Console.WriteLine(rd.ReadLine());
// //      Console.WriteLine(rd.ReadLine());
// //       Console.WriteLine(rd.ReadLine());
// //        Console.WriteLine(rd.ReadLine());
// //         Console.WriteLine(rd.ReadLine());

//         //this way we do not know how many lines a file will have, so we cannot decide till when we should keep doing
//         // Console.WriteLine(rd.ReadLine());

        

//         Console.WriteLine(rd.ReadToEnd());
// }
// catch(IOException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     rd.Close();
//     readAFile.Close();
//     Console.WriteLine("Content read from file and file is closed");
// }

#endregion

#region Read A File - Dynamically
// Console.WriteLine("Enter Your Name");
// string fileName = Console.ReadLine();

// if(File.Exists(fileName + ".txt"))
// {

// FileStream readFile = new FileStream(fileName + ".txt",FileMode.Open,FileAccess.Read);
// StreamReader rd = new StreamReader(readFile);
// try
// {
//     Console.WriteLine(rd.ReadToEnd());
// }
// catch(IOException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     rd.Close();
//     readFile.Close();
//     Console.WriteLine("Content read from file and file is closed");
// }
// }
// else
// {
//     Console.WriteLine("File does not exist");
// }

#endregion




FileIOOperations myOperations = new FileIOOperations();
int choice = 0;
while(choice != 4)
{
    
Console.WriteLine("Welcome to File I/O Demo");
Console.WriteLine("1. To Write a New File");
Console.WriteLine("2. Read A file");
 choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    

switch(choice)
{
    case 1:
        myOperations.WriteToFile();
        break;
    case 2:
        myOperations.ReadFromFile();
        break;
    case 3:
    Console.WriteLine("Sorry Wrong choice");
    break;
    default:
        break;
}

}
