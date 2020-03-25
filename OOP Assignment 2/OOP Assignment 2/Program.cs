using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static string GetFile() // function to get the location of the file
    {
        Console.WriteLine("Please enter the location of the file:");
        string file = Console.ReadLine(); // assigns user input to string
        return file; // returns string
    }
    static void Main()
    {
        // Explains what the program will do
        Console.WriteLine("Git diff compares files and returns the differences between them");

        string file1 = GetFile();
        string file2 = GetFile();

        while (File.Exists(file1) == false)
        {
            Console.WriteLine("File 1 does not exist, remember .txt and check the location you entered", Console.ForegroundColor = ConsoleColor.Yellow);
            file1 = GetFile();
        }
        
        while (File.Exists(file2) == false)
        {
            Console.WriteLine("File 2 does not exist, remember .txt and check the location you entered", Console.ForegroundColor = ConsoleColor.Yellow);
            file2 = GetFile();
        }

        //reads file name or location into memory
        string[] file1Array = { }; //instantiates array of strings for each line from file
        string[] file2Array = { };
        
        file1Array = File.ReadAllLines(file1); //reads lines into array
        file2Array = File.ReadAllLines(file2);
        
        Git git = new Git(); //creates instance of Git class
        bool result = git.diff(file1Array,file2Array); // creates variable result and assigns it with the boolean value from the diff function
        if (result == true) // if the files are identical
        {
            Console.WriteLine("These files are identical", Console.ForegroundColor = ConsoleColor.Green); // prints message in green, indicating the same
        }
        else // if the files are not identical
        {
            Console.WriteLine("These files are not the same", Console.ForegroundColor = ConsoleColor.Red); // prints message in red, indicating that these are not the same
        }
        Console.ForegroundColor = ConsoleColor.Black; // hides console closing text

    }
}