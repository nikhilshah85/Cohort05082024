public class FileIOOperations
{
    public void WriteToFile()
    {
        Console.WriteLine("Enter your name");
string guestName = Console.ReadLine();


FileStream myFile2 = new FileStream(guestName + ".txt",FileMode.Create,FileAccess.Write);
StreamWriter pen2 = new StreamWriter(myFile2);
try
{
    Console.WriteLine("Please enter your message");
    string message = Console.ReadLine();
    pen2.WriteLine(message);

    Console.WriteLine("What is your Fav Hobby");
    string hobby = Console.ReadLine();  
    pen2.WriteLine(hobby);
   
    Console.WriteLine("Please keep telling us more about yourself, press Enter 2 times once done");
    hobby = Console.ReadLine();
    pen2.WriteLine(hobby);

    bool continueLoop = true;
    while(continueLoop)
    {
        Console.Clear();
        Console.WriteLine("Thanks, Tell us more, press Enter 2 times once done");
        hobby = Console.ReadLine();
        if(hobby == "")
        {

            continueLoop = false;
        }
        else
        {
            pen2.WriteLine(hobby);
        }
    }
}
catch(IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    pen2.Close();
    myFile2.Close();
    Console.WriteLine("Content written to file and file is saved");
}


    }

public void ReadFromFile()
{
         Console.WriteLine("Enter Your Name");
string fileName = Console.ReadLine();

if(File.Exists(fileName + ".txt"))
{

FileStream readFile = new FileStream(fileName + ".txt",FileMode.Open,FileAccess.Read);
StreamReader rd = new StreamReader(readFile);
try
{
    Console.WriteLine(rd.ReadToEnd());
}
catch(IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    rd.Close();
    readFile.Close();
    Console.WriteLine("Content read from file and file is closed");
}
}
else
{
    Console.WriteLine("File does not exist");
}

}


}