// C# program to create a directory
using System;
using System.IO;
class Program
{
    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a name for the new directory:");
        string DirName = Console.ReadLine();
        // Checking if string is empty or not
        if (DirName != String.Empty)
        {
            // Creating the Directory
            Directory.CreateDirectory(DirName);
            // Checking Directory is created
            // Successfully or not
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("The directory was created!");
                Console.ReadKey();
            }
        }
    }
}